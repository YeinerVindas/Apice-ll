using ET;
using DAL;
using System.Data;

namespace BL
{
    public class BL_Estudiante
    {
        #region 🔹 Listados

        public static DataTable ListadoES(string ctexto)
        {
            DAL_Estudiante Datos = new DAL_Estudiante();
            return Datos.ListadoES(ctexto);
        }

        #endregion

        #region 🔹 Métodos de Autenticación

        public static DataTable ComprobarES(string correo, string contrasena)
        {
            DAL_Estudiante Datos = new DAL_Estudiante();
            return Datos.ComprobarLogIn(correo, contrasena);
        }

        #endregion

        #region 🔹 Métodos CRUD

        public static string GuardarES(int nOpcion, ET_Estudiante es)
        {
            DAL_Estudiante Datos = new DAL_Estudiante();
            return Datos.GuardarES(nOpcion, es);
        }

        public static string EliminarES(int ID)
        {
            DAL_Estudiante Datos = new DAL_Estudiante();
            return Datos.EliminarES(ID);
        }

        #endregion
    }
}