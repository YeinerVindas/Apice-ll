using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ET;
using Utilities;

namespace DAL
{
    public class DAL_Disponibilidad : DAL_utilities
    {
        #region Métodos de Consulta

        public DataTable ListarDisponibilidad(int idEstudiante)
        {
            // Se utiliza el método Comprobar para obtener la disponibilidad 
            // específica de un estudiante sin necesidad de un texto de búsqueda
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_Estudiante", SqlDbType.Int) { Value = idEstudiante }
            };

            return Comprobar("USP_ListarDisponibilidad", parametros);
        }

        #endregion

        #region Métodos de Escritura

        public string GuardarDisponibilidad(int nOpcion, ET_Disponibilidad oPropiedad)
        {
            string rpta = "";
            try
            {
                SqlParameter[] parametros =
                {
                    new SqlParameter("@nOpcion", SqlDbType.Int) { Value = nOpcion },
                    new SqlParameter("@ID", SqlDbType.Int) { Value = oPropiedad.ID },
                    new SqlParameter("@ID_Estudiante", SqlDbType.Int) { Value = oPropiedad.ID_Estudiante },
                    new SqlParameter("@ID_Materia", SqlDbType.Int) { Value = oPropiedad.ID_Materia },
                    new SqlParameter("@DiaSemana", SqlDbType.VarChar, 15) { Value = oPropiedad.diaSemana },
                    new SqlParameter("@HoraInicio", SqlDbType.Time) { Value = oPropiedad.horaInicio },
                    new SqlParameter("@HoraFin", SqlDbType.Time) { Value = oPropiedad.horaFinal }
                };

                rpta = Guardar("USP_GuardarDisponibilidad", parametros);
            }
            catch (Exception ex)
            {
                rpta = "Error en DAL_Disponibilidad: " + ex.Message;
            }
            return rpta;
        }



        #endregion
    }
}