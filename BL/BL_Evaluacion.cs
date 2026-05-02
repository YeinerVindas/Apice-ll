using System;
using System.Collections.Generic;
using System.Text;
using ET;
using DAL;
using System.Data;

namespace BL
{
    public class BL_Evaluacion
    {
        #region 🔹 Validaciones Privadas

        // Verifica que los datos de la evaluación sean lógicos antes de enviarlos a la base de datos.
        private static string ValidarObjetoEvaluacion(ET_Evaluacion eva)
        {

            // Valida campos obligatorios y referencias a otras tablas.
            if (string.IsNullOrWhiteSpace(eva.NombreRubro)) return "El nombre del rubro (ej. Examen) es obligatorio.";
            if (eva.ID_Materia <= 0) return "Debe especificar una materia válida.";
            if (eva.ID_Estudiante <= 0) return "La evaluación debe estar asignada a un estudiante.";

            // Valida que el valor porcentual sea realista (rango 0.01 a 100).
            if (eva.ValorPorcentual <= 0 || eva.ValorPorcentual > 100)
            {
                return "El valor porcentual debe estar entre 1% y 100%.";
            }

            // Valida que la calificación obtenida no sea negativa ni superior a 100.
            if (eva.CalificacionObtenida < 0 || eva.CalificacionObtenida > 100)
            {
                return "La calificación debe ser un valor entre 0 y 100.";
            }

            // VALIDACIÓN DE SUMA TOTAL (El 100%)
            DAL_Evaluacion dal = new DAL_Evaluacion();

            // Obtiene el total del porcentaje ya registrado para el estudiante en la materia seleccionada.
            decimal actualEnBase = dal.ObtenerPorcentajeAcumulado(eva.ID_Estudiante, eva.ID_Materia);

            // Verifica si la suma del acumulado más el nuevo rubro sobrepasa el límite académico permitido.
            if ((actualEnBase + eva.ValorPorcentual) > 100)
            {
                // Calcula el margen disponible para orientar al usuario en la corrección del dato.
                decimal restante = 100 - actualEnBase;

                // Retorna un mensaje de advertencia impidiendo la persistencia de datos inconsistentes.
                return $"No puedes exceder el 100% de la materia. Actualmente llevas {actualEnBase}% acumulado. Solo puedes asignar un {restante}% más.";
            }

            return null;
        }

        #endregion

        #region 🔹 Métodos CRUD

        // Ejecuta el guardado o edición tras validar los rangos de notas y porcentajes.
        public static string GuardarEva(int nOpcion, ET_Evaluacion ET_Evaluacion)
        {
            string error = ValidarObjetoEvaluacion(ET_Evaluacion);
            if (error != null) return error;

            DAL_Evaluacion DAL_Evaluacion = new DAL_Evaluacion();
            return DAL_Evaluacion.GuardarEva(nOpcion, ET_Evaluacion);
        }

        // Valida que el ID del rubro sea correcto antes de proceder con la eliminación.
        public static string EliminarEvaluacion(int IdEvaluacion)
        {
            if (IdEvaluacion <= 0) return "ID de evaluación no válido.";

            DAL_Evaluacion DAL_Evaluacion = new DAL_Evaluacion();
            return DAL_Evaluacion.EliminarEVA(IdEvaluacion);
        }

        #endregion

        #region 🔹 Listados

        // Obtiene el desglose de rubros filtrado por estudiante y materia.
        public static DataTable ListarRubro(string cTexto, int idEstudiante, int idMateria)
        {
            DAL_Evaluacion DAL_Evaluacion = new DAL_Evaluacion();
            return DAL_Evaluacion.ListadoRubro(cTexto ?? string.Empty, idEstudiante, idMateria);
        }

        #endregion
    }
}