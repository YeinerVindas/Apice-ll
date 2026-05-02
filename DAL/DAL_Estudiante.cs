using ET;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Utilities;

namespace DAL
{
    public class DAL_Estudiante : DAL_utilities
    {
        #region 🔹 Gestión de Estudiante (CRUD)

        // Método simplificado usando la herencia de DAL_utilities
        public DataTable ListadoEstudiantes(string ctexto)
        {
            // Usamos 0 o un ID genérico si el SP no requiere filtrar por un ID específico de estudiante para el listado global
            return this.Listado(ctexto, "USP_Listado_es", 0);
        }

        public string GuardarEstudiante(int nOpcion, ET_Estudiante es)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@nOpcion", nOpcion),
                new SqlParameter("@idEstudiante", es.ID), // Estandarizado a idEstudiante
                new SqlParameter("@Nombre", es.Nombre),
                new SqlParameter("@Correo", es.Correo),
                new SqlParameter("@Contrasena", es.Contrasena),
                new SqlParameter("@FechaConexion", es.FechaConexion),
                new SqlParameter("@RachaActual", es.RachaActual)
            };

            return Guardar("USP_Guardar_es", parametros);
        }

        public string EliminarEstudiante(int idEstudiante)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@idEstudiante", idEstudiante)
            };

            return Guardar("USP_Eliminar_es", parametros); // Cambiado a SP de estudiante
        }

        #endregion

        #region 🔹 Seguridad y Autenticación

        public DataTable ComprobarLogIn(string correo, string contrasena)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@correo", correo),
                new SqlParameter("@contrasena", contrasena)
            };

            return Comprobar("USP_Comprobar_es", parametros);
        }

        #endregion
    }
}