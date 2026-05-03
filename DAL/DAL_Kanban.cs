using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ET;
using Utilities;

namespace DAL
{
    public class DAL_Kanban : DAL_utilities
    {
        #region Métodos de Listado

        public DataTable ListarKanban(int idEstudiante)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_Estudiante", SqlDbType.Int) { Value = idEstudiante }
            };

            return ListadoSimple("USP_ListarKanban", idEstudiante);
        }

        #endregion

        #region Métodos de Escritura (Guardar/Eliminar)

        public string GuardarKanban(int nOpcion, ET_Kanban oPropiedad)
        {
            string rpta = "";
            try
            {
                SqlParameter[] parametros =
                {
                    new SqlParameter("@nOpcion",       SqlDbType.Int)          { Value = nOpcion },
                    new SqlParameter("@ID",            SqlDbType.Int)          { Value = oPropiedad.ID },
                    new SqlParameter("@ID_Estudiante", SqlDbType.Int)          { Value = oPropiedad.ID_Estudiante },
                    new SqlParameter("@titulo",        SqlDbType.VarChar, 100) { Value = oPropiedad.titulo },
                    new SqlParameter("@descripcion",   SqlDbType.VarChar, 500) { Value = (object)oPropiedad.descripcion ?? DBNull.Value },
                    new SqlParameter("@estado",        SqlDbType.VarChar, 20)  { Value = oPropiedad.estado },
                    new SqlParameter("@fechaEntrega",  SqlDbType.Date)         { Value = oPropiedad.fechaEntrega }
                };

                rpta = Guardar("USP_GuardarKanban", parametros);
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string EliminarKanban(int idKanban)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = idKanban }
            };

            return Guardar("USP_EliminarKanban", parametros);
        }

        public string ActualizarEstadoKanban(int idKanban, string estado)
        {
            string rpta = "";
            try
            {
                SqlParameter[] parametros =
                {
                    new SqlParameter("@ID",     SqlDbType.Int)         { Value = idKanban },
                    new SqlParameter("@estado", SqlDbType.VarChar, 20) { Value = estado }
                };

                rpta = Guardar("USP_ActualizarEstadoKanban", parametros);
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        #endregion
    }
}