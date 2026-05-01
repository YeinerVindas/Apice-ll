using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ET;
using Utilities;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class DAL_Evaluacion : DAL_utilities
    {
        #region 🔹 Gestión de Evaluaciones

        public string GuardarEva(int nOpcion, ET_Evaluacion et)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@nOpcion", SqlDbType.Int) { Value = nOpcion },
                new SqlParameter("@ID", SqlDbType.Int) { Value = et.ID },
                new SqlParameter("@ID_materia", SqlDbType.Int) { Value = et.ID_Materia },
                new SqlParameter("@ID_estudiante", SqlDbType.Int) { Value = et.ID_Estudiante },
                new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = et.NombreRubro },
                new SqlParameter("@ValorPorcentual", SqlDbType.Decimal)
                {
                    Precision = 5,
                    Scale = 2,
                    Value = et.ValorPorcentual
                },
                new SqlParameter("@CalificacionObtenida", SqlDbType.Decimal)
                {
                    Precision = 5,
                    Scale = 2,
                    Value = et.CalificacionObtenida
                },
            };

            return Guardar("USP_Guardar_eva", parametros);
        }

        public string EditarEvaluacion(ET_Evaluacion eva)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string confirmacion = "";

            try
            {
                // sqlConnection = Conexion.GetInstancia().CrearConexion; 

                SqlCommand sqlCommand = new SqlCommand("USP_Editar_eva", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = eva.ID;
                sqlCommand.Parameters.Add("@IdMateria", SqlDbType.Int).Value = eva.ID_Materia;
                sqlCommand.Parameters.Add("@NombreRubro", SqlDbType.VarChar).Value = eva.NombreRubro;
                sqlCommand.Parameters.Add("@ValorPorcentual", SqlDbType.Decimal).Value = eva.ValorPorcentual;
                sqlCommand.Parameters.Add("@CalificacionObtenida", SqlDbType.Decimal).Value = eva.CalificacionObtenida;

                sqlConnection.Open();

                confirmacion = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar la evaluación";
            }
            catch (Exception ex)
            {
                confirmacion = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return confirmacion;
        }

        public string EliminarEVA(int IdRubro)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@IdRubro", SqlDbType.Int) { Value = IdRubro }
            };

            return Guardar("USP_Eliminar_eva", parametros);
        }

        #endregion

        #region 🔹 Listados

        public DataTable ListadoRubro(string ctexto, int idEstudiante, int idMateria)
        {
            return ListadoRubro(ctexto, "USP_Listado_eva", idEstudiante, idMateria);
        }

        #endregion

        #region 🔹 Validaciones
        public decimal ObtenerPorcentajeAcumulado(int idEstudiante, int idMateria)
        {
            // Reutilizamos el método ListadoRubro que ya existe en Utilities
            DataTable dt = ListadoRubro("", "USP_Obtener_Porcentaje_Acumulado", idEstudiante, idMateria);

            if (dt.Rows.Count > 0 && dt.Rows[0]["Acumulado"] != DBNull.Value)
            {
                return Convert.ToDecimal(dt.Rows[0]["Acumulado"]);
            }
            return 0;
        }

        #endregion
    }
}