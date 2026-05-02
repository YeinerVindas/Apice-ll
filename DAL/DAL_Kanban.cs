using ET;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Utilities;

namespace DAL
{
    public class DAL_Kanban : DAL_utilities
    {
        #region 🔹 Listados de Tareas

        public DataTable ListadoTareasPendientes(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_tareas_pendientes", IdEstudiate_Materia);
        }

        public DataTable ListadoTareasEnProceso(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_tareas_enproceso", IdEstudiate_Materia);
        }

        public DataTable ListadoTareasCompletadas(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_tareas_completadas", IdEstudiate_Materia);
        }

        #endregion

        #region 🔹 Gestión de Tareas

        public string GuardarTarea(int nOpcion, ET_Kanban tr)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@ID", SqlDbType.Int) { Value = tr.ID },
                new SqlParameter("@nOpcion", SqlDbType.Int) { Value = nOpcion },
                new SqlParameter("@ID_Estudiante", SqlDbType.Int) { Value = tr.ID_Estudiante },
                new SqlParameter("@Descripcion", SqlDbType.VarChar) { Value = tr.Descripcion },
                new SqlParameter("@FechaEntrega", SqlDbType.DateTime) { Value = tr.FechaEntrega },
                new SqlParameter("@Avance", SqlDbType.VarChar) { Value = tr.Dificultad },
            };

            return Guardar("USP_Guardar_tarea", parametros);
        }

        public string EliminarTarea(int IdMateria)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@ID", SqlDbType.Int) { Value = IdMateria }
            };

            return Guardar("USP_Eliminar_tarea", parametros);
        }

        public string ActualizarEstadoTarea(int idTarea, string nuevoEstado)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@ID", SqlDbType.Int) { Value = idTarea },
                new SqlParameter("@NuevoEstado", SqlDbType.VarChar) { Value = nuevoEstado }
            };

            return Guardar("USP_Actualizar_Estado_Tarea", parametros);
        }

        #endregion
    }
}