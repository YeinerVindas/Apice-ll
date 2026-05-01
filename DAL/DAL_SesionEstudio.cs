using ET;
using System.Data;
using Microsoft.Data.SqlClient;
using Utilities;

namespace DAL
{
    public class DAL_SesionEstudio : DAL_utilities
    {
        #region Listados

        // Lista las sesiones filtradas por el ID del Estudiante (Útil para estadísticas)
        public DataTable ListadoSesiones(string ctexto, int idEstudiante)
        {
            // Usamos el método Listado de la clase padre (Utilities)
            return Listado(ctexto, "USP_Listado_Sesiones", idEstudiante);
        }

        #endregion

        #region Gestion de Sesion de Estudio

        public string GuardarSesion(int nOpcion, ET_SesionEstudio sesion)
        {
            // Definimos los parámetros según tu entidad ET_SesionEstudio
            SqlParameter[] parametros = {
                new SqlParameter("@nOpcion", SqlDbType.Int) { Value = nOpcion },
                new SqlParameter("@ID", SqlDbType.Int) { Value = sesion.ID },
                new SqlParameter("@ID_Estudiante", SqlDbType.Int) { Value = sesion.ID_Estudiante },
                new SqlParameter("@Fecha", SqlDbType.DateTime) { Value = sesion.Fecha },
                new SqlParameter("@Duracion", SqlDbType.Int) { Value = sesion.Duracion },
                new SqlParameter("@Completada", SqlDbType.Bit) { Value = sesion.Completada }
            };

            // Ejecutamos usando el método protegido de DAL_utilities
            return Guardar("USP_Guardar_Sesion", parametros);
        }

        #endregion
    }
}