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
        #region LISTADOS

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

        #region GUARDAR

        protected string Guardar(string nombreSP, params SqlParameter[] parametros)
        {
            string rpta = "";

            using (SqlConnection sqlCon = Conexion.GetInstancia().CrearConexion())
            using (SqlCommand comando = new SqlCommand(nombreSP, sqlCon))
            {
                comando.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                    comando.Parameters.AddRange(parametros);

                sqlCon.Open();

                // Los USPs retornan SELECT 'OK' o SELECT 'mensaje error'
                // ExecuteScalar lee ese valor en lugar de contar filas
                object resultado = comando.ExecuteScalar();
                rpta = resultado != null ? resultado.ToString() : "No se logró registrar el dato";
            }

            return rpta;
        }
        #endregion

        #region Eliminar
        protected string Eliminar(string nombreSP, params SqlParameter[] parametros)
        {
            string rpta = "";

            try
            {
                using (SqlConnection sqlCon = Conexion.GetInstancia().CrearConexion())
                using (SqlCommand comando = new SqlCommand(nombreSP, sqlCon))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    sqlCon.Open();

                    // Si devuelve >= 1, es que encontró el registro y lo borró.
                    // Si devuelve 0, el ID no existía o no se afectaron filas.
                    rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se encontró el registro para eliminar";
                }
            }
            catch (Exception ex)
            {
                rpta = "Error en la base de datos: " + ex.Message;
            }

            return rpta;
        }
        #endregion


        #region CONSULTAS (COMPROBAR)

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
        public DataTable ListadoSimple(string nombreSP, int idEstudiante)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand(nombreSP, SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@ID_Estudiante", SqlDbType.Int).Value = idEstudiante;

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


    }
}