using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BL
{
    public class BL_Kanban
    {
        #region 🔹 Listados

        public static DataTable ListadoTareasPendientes(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Kanban datos = new DAL_Kanban();
            return datos.ListadoTareasPendientes(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoTareasEnProceso(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Kanban datos = new DAL_Kanban();
            return datos.ListadoTareasEnProceso(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoTareasCompletadas(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Kanban datos = new DAL_Kanban();
            return datos.ListadoTareasCompletadas(cTexto, IdEstudiate_Materia);
        }

        #endregion

        #region 🔹 Métodos CRUD

        public static string GuardarTarea(int nOpcion, ET.ET_Kanban tr)
        {
            DAL_Kanban datos = new DAL_Kanban();
            return datos.GuardarTarea(nOpcion, tr);
        }

        public static string EliminarTarea(int IdMateria)
        {
            DAL_Kanban datos = new DAL_Kanban();
            return datos.EliminarTarea(IdMateria);
        }

        #endregion
    }
}