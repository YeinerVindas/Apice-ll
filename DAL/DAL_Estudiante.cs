using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ET;
using Utilities;

namespace DAL
{
    public class DAL_Estudiante : DAL_utilities
    {
        #region Métodos de Autenticación y Listado

        public DataTable Login(string correo, string contrasena)
        {
            // Usamos el método Comprobar para validar credenciales
            SqlParameter[] parametros =
            {
                new SqlParameter("@correo", SqlDbType.VarChar, 50) { Value = correo },
                new SqlParameter("@contrasena", SqlDbType.VarChar, 50) { Value = contrasena }
            };

            return Comprobar("USP_LoginEstudiante", parametros);
        }

        #endregion

        #region Métodos de Escritura

        public string GuardarEstudiante(int nOpcion, ET_Estudiante oPropiedad)
        {
            string rpta = "";
            try
            {
                SqlParameter[] parametros =
                {
                    new SqlParameter("@nOpcion", SqlDbType.Int) { Value = nOpcion },
                    new SqlParameter("@ID", SqlDbType.Int) { Value = oPropiedad.ID },
                    new SqlParameter("@nombre", SqlDbType.VarChar, 50) { Value = oPropiedad.nombre },
                    new SqlParameter("@correo", SqlDbType.VarChar, 50) { Value = oPropiedad.correo },
                    new SqlParameter("@contrasena", SqlDbType.VarChar, 50) { Value = oPropiedad.contrasena },
                    new SqlParameter("@fechaConexion", SqlDbType.VarChar, 50) { Value = oPropiedad.fechaConexion },
                    new SqlParameter("@rachaActual", SqlDbType.Int) { Value = (object)oPropiedad.rachaActual ?? DBNull.Value }
                };

                rpta = Guardar("USP_GuardarEstudiante", parametros);
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string EliminarEstudiante(int idEstudiante)
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = idEstudiante }
            };

            return Eliminar("USP_EliminarEstudiante", parametros);
        }

        #endregion
    }
}