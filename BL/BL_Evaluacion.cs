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
        #region 🔹 Listados

        public static DataTable ListarRubro(string cTexto, int idEstudiante, int idMateria)
        {
            DAL_Evaluacion DAL_Evaluacion = new DAL_Evaluacion();
            return DAL_Evaluacion.ListadoRubro(cTexto, idEstudiante, idMateria);
        }

        #endregion

        #region 🔹 Métodos CRUD

        public static string GuardarEva(int nOpcion, ET_Evaluacion ET_Evaluacion)
        {
            DAL_Evaluacion DAL_Evaluacion = new DAL_Evaluacion();
            return DAL_Evaluacion.GuardarEva(nOpcion, ET_Evaluacion);
        }

        public static string EliminarEvaluacion(int IdEvaluacion)
        {
            DAL_Evaluacion DAL_Evaluacion = new DAL_Evaluacion();
            return DAL_Evaluacion.EliminarEVA(IdEvaluacion);
        }

        #endregion
    }
}