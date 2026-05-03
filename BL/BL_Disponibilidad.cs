using System;
using System.Data;
using ET;
using DAL;

namespace BL
{
    public class BL_Disponibilidad
    {
        // Instancia de la DAL para todas las operaciones sobre la tabla Disponibilidad
        private readonly DAL_Disponibilidad _dalDisponibilidad = new DAL_Disponibilidad();

        // Valores permitidos para el campo diaSemana, igual que en BL_Materia
        private readonly string[] _diasValidos =
        {
            "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"
        };

        // ============================================================
        //  LISTAR
        // ============================================================

        // Retorna todos los bloques de disponibilidad registrados para un estudiante.
        // No tiene filtro de texto porque la disponibilidad se consulta completa
        // para construir la vista del horario.
        public DataTable ListarDisponibilidad(int idEstudiante)
        {
            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            return _dalDisponibilidad.ListarDisponibilidad(idEstudiante);
        }

        // ============================================================
        //  ASIGNAR DISPONIBILIDAD (Insertar)
        // ============================================================

        // Valida el bloque y lo envía a la DAL con opción 1 (INSERT).
        // La validación de conflicto de horario la maneja el USP directamente,
        // por eso si el retorno no es "OK" se lanza como excepción el mensaje
        // que devolvió la base de datos.
        public string AsignarDisponibilidad(ET_Disponibilidad oDisponibilidad)
        {
            ValidarDisponibilidad(oDisponibilidad);

            string rpta = _dalDisponibilidad.GuardarDisponibilidad(1, oDisponibilidad);

            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  MOVER DISPONIBILIDAD (Actualizar)
        // ============================================================

        // Permite reubicar un bloque de disponibilidad a otro día u hora.
        // Requiere un ID válido y re-valida el bloque destino antes de actualizar.
        // Si el slot destino ya está ocupado, el USP retorna el mensaje de conflicto
        // que se propaga como excepción hacia la GUI.
        public string MoverDisponibilidad(ET_Disponibilidad oDisponibilidad)
        {
            if (oDisponibilidad.ID <= 0)
                throw new Exception("ID de disponibilidad no válido.");

            ValidarDisponibilidad(oDisponibilidad);

            string rpta = _dalDisponibilidad.GuardarDisponibilidad(2, oDisponibilidad);

            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  VALIDACIONES PRIVADAS
        // ============================================================

        // Valida los campos del objeto ET_Disponibilidad antes de cualquier operación.
        // A diferencia de BL_Materia, aquí horaInicio y horaFinal son TimeSpan
        // (no strings), por lo que la comparación es directa sin TryParse.
        // La duración mínima de 25 minutos aplica igual que en las materias,
        // para garantizar que el bloque sea suficiente para al menos un Pomodoro.
        private void ValidarDisponibilidad(ET_Disponibilidad oDisponibilidad)
        {
            if (oDisponibilidad == null)
                throw new Exception("Los datos de disponibilidad no pueden ser nulos.");

            if (oDisponibilidad.ID_Estudiante <= 0)
                throw new Exception("El estudiante asociado no es válido.");

            if (oDisponibilidad.ID_Materia <= 0)
                throw new Exception("La materia asociada no es válida.");

            // Verifica que el día sea uno de los siete valores permitidos
            if (string.IsNullOrWhiteSpace(oDisponibilidad.diaSemana) ||
                Array.IndexOf(_diasValidos, oDisponibilidad.diaSemana) < 0)
                throw new Exception("El día debe ser: Lunes, Martes, Miércoles, Jueves, Viernes, Sábado o Domingo.");

            // La hora final debe ser estrictamente mayor a la de inicio
            if (oDisponibilidad.horaFinal <= oDisponibilidad.horaInicio)
                throw new Exception("La hora final debe ser mayor a la hora de inicio.");

            // Mínimo 25 minutos para que aplique al menos un bloque Pomodoro
            double minutos = (oDisponibilidad.horaFinal - oDisponibilidad.horaInicio).TotalMinutes;
            if (minutos < 25)
                throw new Exception("El bloque de disponibilidad debe ser de al menos 25 minutos.");
        }
    }
}