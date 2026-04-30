using DAL;
using ET;
using System.Data;

namespace BL
{
    public class BL_Materia
    {
        #region 🔹 Listados por Día

        public static DataTable ListadoMateriaLunes(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.ListadoMateriaLunes(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoMateriaMartes(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.ListadoMateriaMartes(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoMateriaMiercoles(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.ListadoMateriaMiercoles(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoMateriaJueves(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.ListadoMateriaJueves(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoMateriaViernes(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.ListadoMateriaViernes(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoMateriaSabado(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.ListadoMateriaSabado(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoMateriaDomingo(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.ListadoMateriaDomingo(cTexto, IdEstudiate_Materia);
        }

        #endregion

        #region 🔹 Listados Generales

        public static DataTable ListadoGestionMaterias(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.ListadoGestionMaterias(cTexto, IdEstudiate_Materia);
        }

        public static DataTable ListadoMateriasGeneral(string cTexto, int IdEstudiate_Materia)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.Listado(cTexto, "USP_Listado_materias_general", IdEstudiate_Materia);
        }

        #endregion

        #region 🔹 Gestión de Materias

        public static string GuardarMT(int nOpcion, ET_Materia mt)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.GuardarMT(nOpcion, mt);
        }

        public static string EliminarMT(int IdMateria)
        {
            DAL_Materia datos = new DAL_Materia();
            return datos.EliminarMT(IdMateria);
        }

        #endregion
    }
}