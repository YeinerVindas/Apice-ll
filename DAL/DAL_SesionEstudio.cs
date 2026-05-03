using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ET;
using Utilities;

namespace DAL
{
    public class DAL_SesionEstudio : DAL_utilities
    {
        #region Métodos de Listado

        public DataTable ListarSesionesPorEstudiante(string cTexto, int idEstudiante)
        {
            // Usamos el método Listado de la clase base para filtrar sesiones de un alumno específico
            return Listado(cTexto, "USP_ListarSesionesEstudio", idEstudiante);
        }

        #endregion

        #region Métodos de Escritura

        public string GuardarSesion(int nOpcion, ET_SesionEstudio oPropiedad)
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
                    new SqlParameter("@Fecha", SqlDbType.VarChar, 50) { Value = oPropiedad.fecha },
                    new SqlParameter("@duracion", SqlDbType.Int) { Value = oPropiedad.duracion },
                    new SqlParameter("@CantidadBloques", SqlDbType.Int) { Value = oPropiedad.cantidadBloques },
                    new SqlParameter("@estado", SqlDbType.VarChar, 20) { Value = oPropiedad.estado },
                    new SqlParameter("@Completada", SqlDbType.Bit) { Value = oPropiedad.completada }
                };

                // Invocamos el método Guardar heredado de DAL_utilities
                rpta = Guardar("USP_GuardarSesionEstudio", parametros);
            }
            catch (Exception ex)
            {
                rpta = "Error en DAL_SesionEstudio: " + ex.Message;
            }
            return rpta;
        }

        #endregion
    }
}