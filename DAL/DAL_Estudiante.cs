using ET;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Utilities;

namespace DAL
{
    public class DAL_Estudiante : DAL_utilities
    {
        #region 🔹 Listados

        public DataTable ListadoES(string ctexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();

                SqlCommand comando = new SqlCommand("USP_Listado_es", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = ctexto;

                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        #endregion

        #region 🔹 Gestión de Estudiante

        public string GuardarES(int nOpcion, ET_Estudiante es)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@nOpcion", SqlDbType.Int) { Value = nOpcion },
                new SqlParameter("@ID", SqlDbType.Int) { Value = es.ID },
                new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = es.Nombre },
                new SqlParameter("@Correo", SqlDbType.VarChar) { Value = es.Correo },
                new SqlParameter("@Contrasena", SqlDbType.VarChar) { Value = es.Contrasena },
                new SqlParameter("@FechaConexion", SqlDbType.DateTime) { Value = es.FechaConexion },
                new SqlParameter("@RachaActual", SqlDbType.VarChar) { Value = es.RachaActual }
            };

            return Guardar("USP_Guardar_es", parametros);
        }

        public string EliminarES(int IdMateria)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@nIdMateria", SqlDbType.Int) { Value = IdMateria }
            };

            return Guardar("USP_Eliminar_mt", parametros);
        }

        #endregion



        public DataTable ComprobarLogIn(string correo, string contrasena)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@correo", SqlDbType.VarChar) { Value = correo },
                new SqlParameter("@contrasena", SqlDbType.VarChar) { Value = contrasena }
            };

            return Comprobar("USP_Comprobar_es", parametros);
        }


    }
}