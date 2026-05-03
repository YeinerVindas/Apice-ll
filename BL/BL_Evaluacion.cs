using System;
using System.Data;
using ET;
using DAL;

namespace BL
{
    public class BL_Evaluacion
    {
        // Instancia de la DAL para todas las operaciones sobre la tabla Evaluacion
        private readonly DAL_Evaluacion _dalEvaluacion = new DAL_Evaluacion();

        // ============================================================
        //  LISTAR
        // ============================================================

        // Retorna los rubros de evaluación filtrados por estudiante y materia.
        // Ambos IDs son obligatorios porque una evaluación siempre pertenece
        // a una materia específica de un estudiante específico.
        public DataTable ListarEvaluaciones(string cTexto, int idEstudiante, int idMateria)
        {
            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            if (idMateria <= 0)
                throw new Exception("ID de materia no válido.");

            return _dalEvaluacion.ListarEvaluaciones(cTexto ?? "", idEstudiante, idMateria);
        }

        // ============================================================
        //  INSERTAR
        // ============================================================

        // Valida el rubro y lo envía a la DAL con opción 1 (INSERT).
        // El USP retorna el ID generado como string, por eso se usa int.TryParse
        // en lugar de comparar contra "OK" como en los otros módulos.
        public string InsertarEvaluacion(ET_Evaluacion oEvaluacion)
        {
            ValidarEvaluacion(oEvaluacion);

            string rpta = _dalEvaluacion.GuardarEvaluacion(1, oEvaluacion);

            if (int.TryParse(rpta, out _))
                return "OK";

            throw new Exception(rpta);
        }

        // ============================================================
        //  ACTUALIZAR
        // ============================================================

        // Valida y actualiza un rubro existente usando opción 2 (UPDATE).
        // Verifica que el ID sea válido antes de cualquier otra operación.
        public string ActualizarEvaluacion(ET_Evaluacion oEvaluacion)
        {
            if (oEvaluacion.ID <= 0)
                throw new Exception("ID de evaluación no válido.");

            ValidarEvaluacion(oEvaluacion);

            string rpta = _dalEvaluacion.GuardarEvaluacion(2, oEvaluacion);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  ELIMINAR
        // ============================================================

        // Elimina un rubro por ID. Si el USP no retorna "OK" lanza excepción
        // con el mensaje de error que devolvió la base de datos.
        public string EliminarEvaluacion(int idEvaluacion)
        {
            if (idEvaluacion <= 0)
                throw new Exception("ID de evaluación no válido.");

            string rpta = _dalEvaluacion.EliminarEvaluacion(idEvaluacion);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  CALCULOS
        // ============================================================

        // Calcula la nota acumulada actual sumando el aporte de cada rubro.
        // El aporte de cada rubro es: nota * porcentaje / 100.
        // Solo procesa filas que ya tienen nota asignada (ignora DBNull).
        public decimal CalcularNotaActual(DataTable dtEvaluaciones)
        {
            decimal total = 0;

            foreach (DataRow row in dtEvaluaciones.Rows)
            {
                if (row["nota"] != DBNull.Value)
                {
                    decimal nota = Convert.ToDecimal(row["nota"]);
                    decimal porcentaje = Convert.ToDecimal(row["porcentaje"]);
                    total += (nota * porcentaje / 100);
                }
            }

            return Math.Round(total, 2);
        }

        // Suma todos los porcentajes de los rubros registrados.
        // Se usa para verificar que el total no supere el 100%
        // y para mostrarle al estudiante cuánto porcentaje ya tiene asignado.
        public decimal CalcularPorcentajeUsado(DataTable dtEvaluaciones)
        {
            decimal total = 0;

            foreach (DataRow row in dtEvaluaciones.Rows)
                total += Convert.ToDecimal(row["porcentaje"]);

            return Math.Round(total, 2);
        }

        // Compara la nota actual contra la nota mínima de aprobación de la materia
        // y retorna un mensaje de estado legible para mostrar en la GUI.
        // Si no hay nota mínima definida, informa que no aplica la comparación.
        public string EstadoVsNotaMinima(decimal notaActual, decimal? notaMinima)
        {
            if (notaMinima == null || notaMinima <= 0)
                return "Sin nota mínima definida";

            if (notaActual >= notaMinima)
                return $"Aprobado (llevas {notaActual} de {notaMinima} mínimo)";
            else
                return $"En riesgo (llevas {notaActual} de {notaMinima} mínimo)";
        }

        // ============================================================
        //  VALIDACIONES PRIVADAS
        // ============================================================

        // Valida todos los campos del objeto ET_Evaluacion antes de insertar o actualizar.
        // La nota es opcional (nullable) porque un rubro puede existir sin nota aún,
        // pero si se ingresa debe estar en el rango 0-100.
        // El porcentaje debe ser positivo y no puede superar 100 por sí solo.
        private void ValidarEvaluacion(ET_Evaluacion oEvaluacion)
        {
            if (oEvaluacion == null)
                throw new Exception("La evaluación no puede ser nula.");

            if (oEvaluacion.ID_Estudiante <= 0)
                throw new Exception("El estudiante asociado no es válido.");

            if (oEvaluacion.ID_Materia <= 0)
                throw new Exception("La materia asociada no es válida.");

            if (string.IsNullOrWhiteSpace(oEvaluacion.nombre))
                throw new Exception("El nombre del rubro es obligatorio.");

            if (oEvaluacion.nombre.Length > 50)
                throw new Exception("El nombre no puede superar los 50 caracteres.");

            // El porcentaje debe ser un valor real entre 1 y 100
            if (oEvaluacion.porcentaje <= 0 || oEvaluacion.porcentaje > 100)
                throw new Exception("El porcentaje debe estar entre 1 y 100.");

            // La nota es opcional, pero si fue ingresada se valida su rango
            if (oEvaluacion.nota.HasValue && (oEvaluacion.nota < 0 || oEvaluacion.nota > 100))
                throw new Exception("La nota debe estar entre 0 y 100.");
        }
    }
}