using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ET;
using Utilities;

namespace DAL
{
    public class DAL_SesionEstudio : DAL_utilities
    {
        public string InsertarSesion(ET_SesionEstudio sesion)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    // Usamos el nombre de parámetro @idEstudiante para ser consistentes
                    new SqlParameter("@idEstudiante", sesion.IdEstudiante),
                    new SqlParameter("@idMateria", sesion.IdMateria),
                    new SqlParameter("@estado", sesion.Estado)
                };

                return this.Guardar("SP_GuardarSesionEstudio", parametros);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ActualizarProgreso(ET_SesionEstudio sesion)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    // Asegúrate de que tu SP use @idSesion o @id para evitar confusiones con idEstudiante
                    new SqlParameter("@idSesion", sesion.ID), 
                    new SqlParameter("@cantidadBloques", sesion.CantidadBloques),
                    new SqlParameter("@duracion", sesion.Duracion)
                };

                return this.Guardar("SP_ActualizarProgresoSesion", parametros);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}