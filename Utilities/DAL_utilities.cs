using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ET;
using Microsoft.Data.SqlClient;

namespace Utilities
{
    public class DAL_utilities
    {
        #region 🔹 LISTADOS

        // Se cambió IdEstudiate_Materia por idEstudiante para mayor claridad
        public DataTable Listado(string ctexto, string nombreSP, int idEstudiante)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand(nombreSP, SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = ctexto;
                comando.Parameters.Add("@idEstudiante", SqlDbType.Int).Value = idEstudiante;

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

        // Se estandarizó el nombre del parámetro a idEstudiante
        public DataTable ListadoRubro(string ctexto, string nombreSP, int idEstudiante, int idMateria)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand(nombreSP, SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = ctexto;
                comando.Parameters.Add("@idEstudiante", SqlDbType.Int).Value = idEstudiante;
                comando.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMateria;

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

        #region 🔹 GUARDAR

        protected string Guardar(string nombreSP, params SqlParameter[] parametros)
        {
            string rpta = "";

            using (SqlConnection sqlCon = Conexion.GetInstancia().CrearConexion())
            using (SqlCommand comando = new SqlCommand(nombreSP, sqlCon))
            {
                comando.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros);
                }

                sqlCon.Open();

                rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se logró registrar el dato";
            }

            return rpta;
        }

        #endregion

        #region 🔹 CONSULTAS (COMPROBAR)

        protected DataTable Comprobar(string nombreSP, params SqlParameter[] parametros)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();

            using (SqlConnection sqlCon = Conexion.GetInstancia().CrearConexion())
            using (SqlCommand comando = new SqlCommand(nombreSP, sqlCon))
            {
                comando.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros);
                }

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
            }

            return tabla;
        }

        #endregion
    }
}