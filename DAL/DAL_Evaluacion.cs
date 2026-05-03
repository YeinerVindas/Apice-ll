using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ET;
using Utilities;

namespace DAL
{
    public class DAL_Evaluacion : DAL_utilities
    {
        #region Métodos de Listado

        public DataTable ListarEvaluaciones(string cTexto, int idEstudiante, int idMateria)
        {
            return ListadoRubro(cTexto, "USP_ListarEvaluaciones", idEstudiante, idMateria);
        }

        #endregion

        #region Métodos de Escritura (Guardar/Eliminar)

        public string GuardarEvaluacion(int nOpcion, ET_Evaluacion oPropiedad)
        {
            string rpta = "";
            try
            {
                SqlParameter[] parametros =
                {
                    new SqlParameter("@nOpcion",       SqlDbType.Int)          { Value = nOpcion },
                    new SqlParameter("@ID",            SqlDbType.Int)          { Value = oPropiedad.ID },
                    new SqlParameter("@ID_Materia",    SqlDbType.Int)          { Value = oPropiedad.ID_Materia },
                    new SqlParameter("@ID_Estudiante", SqlDbType.Int)          { Value = oPropiedad.ID_Estudiante },
                    new SqlParameter("@nombre",        SqlDbType.VarChar, 50)  { Value = oPropiedad.nombre },
                    new SqlParameter("@porcentaje",    SqlDbType.Decimal)      { Value = oPropiedad.porcentaje, Precision = 5, Scale = 2 },
                    new SqlParameter("@nota",          SqlDbType.Decimal)      { Value = (object)oPropiedad.nota ?? DBNull.Value, Precision = 5, Scale = 2 }
                };

                rpta = Guardar("USP_GuardarEvaluacion", parametros);
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string EliminarEvaluacion(int idEvaluacion)
        {
            SqlParameter[] parametros =
            {
        new SqlParameter("@ID", SqlDbType.Int) { Value = idEvaluacion }
        };

            return Guardar("USP_EliminarEvaluacion", parametros);
        }

        #endregion
    }
}