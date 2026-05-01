using ET;
using DAL;
using System.Data;
using System.Text.RegularExpressions;

namespace BL
{
    public class BL_Estudiante
    {
        #region 🔹 Validaciones Privadas

        // Valida que los datos del estudiante cumplan con las validaciones antes de operar.
        private static string ValidarObjetoEstudiante(ET_Estudiante es)
        {
            // Verifica que los campos obligatorios no estén vacíos o con espacios.
            if (string.IsNullOrWhiteSpace(es.Nombre)) return "El nombre no puede estar vacío.";
            if (string.IsNullOrWhiteSpace(es.Correo)) return "El correo electrónico es obligatorio.";
            if (string.IsNullOrWhiteSpace(es.Contrasena)) return "La contraseña no puede estar vacía.";

            // Aplica el patrón de expresión regular para validar la estructura del correo.
            string expresion = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(es.Correo, expresion))
            {
                return "El formato del correo electrónico no es válido.";
            }

            // Valida que la contraseña cumpla con la longitud mínima de seguridad.
            if (es.Contrasena.Length < 8)
            {
                return "La contraseña debe tener al menos 8 caracteres.";
            }

            // Evita que se registren valores de racha inconsistentes.
            if (es.RachaActual < 0)
            {
                return "La racha de conexión no puede ser negativa.";
            }

            return null; // Indica que la validación fue exitosa.
        }

        #endregion

        #region 🔹 Métodos CRUD

        // Procesa el guardado o actualización tras superar las validaciones de negocio.
        public static string GuardarES(int nOpcion, ET_Estudiante es)
        {
            string error = ValidarObjetoEstudiante(es);
            if (error != null) return error;

            DAL_Estudiante Datos = new DAL_Estudiante();

            // Si es un registro nuevo, se inicializa la racha y la fecha de conexión actual.
            if (nOpcion == 1)
            {
                es.RachaActual = 0;
                es.FechaConexion = DateTime.Now;
            }

            return Datos.GuardarES(nOpcion, es);
        }

        // Valida el ID antes de solicitar la eliminación a la capa de datos.
        public static string EliminarES(int ID)
        {
            if (ID <= 0) return "ID de estudiante no válido.";

            DAL_Estudiante Datos = new DAL_Estudiante();
            return Datos.EliminarES(ID);
        }

        #endregion

        #region 🔹 Consultas y Autenticación

        // Realiza la comprobación de credenciales si los campos no están vacíos.
        public static DataTable ComprobarES(string correo, string contrasena)
        {
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                return new DataTable();
            }

            DAL_Estudiante Datos = new DAL_Estudiante();
            return Datos.ComprobarLogIn(correo, contrasena);
        }

        // Obtiene la lista de estudiantes enviando una cadena vacía si el filtro es nulo.
        public static DataTable ListadoES(string ctexto)
        {
            DAL_Estudiante Datos = new DAL_Estudiante();
            return Datos.ListadoES(ctexto ?? string.Empty);
        }

        #endregion
    }
}