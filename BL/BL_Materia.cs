using System;
using System.Data;
using ET;
using DAL;

namespace BL
{
    public class BL_Materia
    {
        // Instancia de la DAL para todas las operaciones sobre la tabla Materia
        private readonly DAL_Materia _dalMateria = new DAL_Materia();

        // Valores permitidos para los campos prioridad y diaSemana.
        // Se usan con Array.IndexOf para validar sin hacer múltiples if encadenados.
        private readonly string[] _prioridadesValidas = { "Alta", "Media", "Baja" };
        private readonly string[] _diasValidos =
        {
            "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"
        };

        // ============================================================
        //  LISTAR
        // ============================================================

        // Retorna todas las materias de un estudiante, con filtro de búsqueda opcional.
        // Si el texto es null se convierte a string vacío para evitar errores en el USP.
        public DataTable ListarMaterias(string cTexto, int idEstudiante)
        {
            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            return _dalMateria.ListarMaterias(cTexto ?? "", idEstudiante);
        }

        // ============================================================
        //  INSERTAR
        // ============================================================

        // Valida el objeto y verifica que no choque con el horario de otra materia
        // antes de enviarlo a la DAL con opción 1 (INSERT).
        public string InsertarMateria(ET_Materia oMateria)
        {
            ValidarMateria(oMateria);
            ValidarSolapamiento(oMateria);

            string rpta = _dalMateria.GuardarMateria(1, oMateria);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  ACTUALIZAR
        // ============================================================

        // Igual que insertar pero requiere un ID válido y usa opción 2 (UPDATE).
        // También re-valida el horario para evitar solapamientos al editar.
        public string ActualizarMateria(ET_Materia oMateria)
        {
            if (oMateria.ID <= 0)
                throw new Exception("ID de materia no válido.");

            ValidarMateria(oMateria);
            ValidarSolapamiento(oMateria);

            string rpta = _dalMateria.GuardarMateria(2, oMateria);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  ELIMINAR
        // ============================================================

        // Elimina una materia por ID. El USP se encarga de borrar
        // en cascada las evaluaciones asociadas antes del DELETE principal.
        public string EliminarMateria(int idMateria)
        {
            if (idMateria <= 0)
                throw new Exception("ID de materia no válido.");

            string rpta = _dalMateria.EliminarMateria(idMateria);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  VALIDACIONES PRIVADAS
        // ============================================================

        // Valida todos los campos del objeto ET_Materia antes de cualquier operación.
        // Verifica nulidad, longitud, valores permitidos, formato de hora y duración mínima.
        // La duración mínima de 25 minutos existe porque es el tamaño de un bloque Pomodoro.
        private void ValidarMateria(ET_Materia oMateria)
        {
            if (oMateria == null)
                throw new Exception("La materia no puede ser nula.");

            if (oMateria.ID_Estudiante <= 0)
                throw new Exception("El estudiante asociado no es válido.");

            if (string.IsNullOrWhiteSpace(oMateria.nombre))
                throw new Exception("El nombre de la materia es obligatorio.");

            if (oMateria.nombre.Length > 50)
                throw new Exception("El nombre no puede superar los 50 caracteres.");

            // Verifica que la prioridad sea uno de los tres valores definidos
            if (string.IsNullOrWhiteSpace(oMateria.prioridad) ||
                Array.IndexOf(_prioridadesValidas, oMateria.prioridad) < 0)
                throw new Exception("La prioridad debe ser: Alta, Media o Baja.");

            // Verifica que el día sea uno de los siete válidos
            if (string.IsNullOrWhiteSpace(oMateria.diaSemana) ||
                Array.IndexOf(_diasValidos, oMateria.diaSemana) < 0)
                throw new Exception("El día debe ser: Lunes, Martes, Miércoles, Jueves, Viernes, Sábado o Domingo.");

            if (string.IsNullOrWhiteSpace(oMateria.horaInicio))
                throw new Exception("La hora de inicio es obligatoria.");

            if (string.IsNullOrWhiteSpace(oMateria.horaFinal))
                throw new Exception("La hora final es obligatoria.");

            // TimeSpan.TryParse valida que el string tenga formato HH:mm correcto
            if (!TimeSpan.TryParse(oMateria.horaInicio, out TimeSpan inicio))
                throw new Exception("La hora de inicio no tiene un formato válido (HH:mm).");

            if (!TimeSpan.TryParse(oMateria.horaFinal, out TimeSpan final))
                throw new Exception("La hora final no tiene un formato válido (HH:mm).");

            // La hora final debe ser estrictamente mayor a la de inicio
            if (final <= inicio)
                throw new Exception("La hora final debe ser mayor a la hora de inicio.");

            // Mínimo 25 minutos para que la materia pueda tener al menos un bloque Pomodoro
            TimeSpan duracion = final - inicio;
            if (duracion.TotalMinutes < 25)
                throw new Exception("La materia debe tener una duración mínima de 25 minutos para poder aplicar sesiones de estudio.");
        }

        // Verifica que el horario de la materia nueva o editada no se cruce con
        // el de otra materia existente del mismo estudiante en el mismo día.
        // Usa la lógica de intersección de intervalos: dos rangos se solapan si
        // el inicio de uno es menor al final del otro y viceversa.
        // Al editar, se salta la comparación contra sí misma usando el ID.
        private void ValidarSolapamiento(ET_Materia oMateria)
        {
            DataTable dtExistentes = _dalMateria.ListarMaterias("", oMateria.ID_Estudiante);

            if (!TimeSpan.TryParse(oMateria.horaInicio, out TimeSpan nuevaInicio)) return;
            if (!TimeSpan.TryParse(oMateria.horaFinal, out TimeSpan nuevaFinal)) return;

            foreach (DataRow row in dtExistentes.Rows)
            {
                // Ignora el propio registro al editar
                if (Convert.ToInt32(row["ID"]) == oMateria.ID) continue;

                // Solo compara contra materias del mismo día de la semana
                if (row["diaSemana"].ToString() != oMateria.diaSemana) continue;

                if (!TimeSpan.TryParse(row["horaInicio"].ToString(), out TimeSpan existenteInicio)) continue;
                if (!TimeSpan.TryParse(row["horaFinal"].ToString(), out TimeSpan existenteFinal)) continue;

                // Condición de solapamiento: los intervalos se cruzan si ninguno termina
                // antes de que el otro empiece
                if (nuevaInicio < existenteFinal && nuevaFinal > existenteInicio)
                    throw new Exception($"El horario se solapa con la materia '{row["nombre"]}' " +
                                        $"({row["horaInicio"]} - {row["horaFinal"]}) el {oMateria.diaSemana}.");
            }
        }
    }
}