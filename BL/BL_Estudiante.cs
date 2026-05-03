using System;
using System.Data;
using ET;
using DAL;

namespace BL
{
    public class BL_Estudiante
    {
        // Instancia de la DAL para todas las operaciones sobre la tabla Estudiante
        private readonly DAL_Estudiante _dalEstudiante = new DAL_Estudiante();

        // ============================================================
        //  REGISTRO DE CUENTA
        // ============================================================

        // Valida los campos del nuevo estudiante y lo persiste en la base de datos.
        // La validación del correo es básica — verifica que tenga "@" y "." sin usar Regex.
        // Inicializa la racha en 0 y registra la fecha actual como primera conexión.
        public string RegistrarEstudiante(ET_Estudiante oEstudiante)
        {
            if (string.IsNullOrWhiteSpace(oEstudiante.nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(oEstudiante.correo))
                throw new Exception("El correo es obligatorio.");

            if (!oEstudiante.correo.Contains("@") || !oEstudiante.correo.Contains("."))
                throw new Exception("El correo no tiene un formato válido.");

            if (string.IsNullOrWhiteSpace(oEstudiante.contrasena))
                throw new Exception("La contraseña es obligatoria.");

            if (oEstudiante.contrasena.Length < 6)
                throw new Exception("La contraseña debe tener al menos 6 caracteres.");

            // Se inicializan los campos de seguimiento antes del primer insert
            oEstudiante.fechaConexion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            oEstudiante.rachaActual = 0;

            string rpta = _dalEstudiante.GuardarEstudiante(1, oEstudiante);

            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  LOGIN + RACHA
        // ============================================================

        // Autentica al estudiante contra la base de datos y construye el objeto de sesión.
        // Tras autenticar, delega en ActualizarRacha para aplicar la lógica de racha diaria.
        // Si no hay coincidencia en la BD lanza excepción con mensaje genérico para no
        // revelar si el correo existe o no.
        public ET_Estudiante Login(string correo, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(correo))
                throw new Exception("El correo es obligatorio.");

            if (string.IsNullOrWhiteSpace(contrasena))
                throw new Exception("La contraseña es obligatoria.");

            DataTable dt = _dalEstudiante.Login(correo, contrasena);

            if (dt == null || dt.Rows.Count == 0)
                throw new Exception("Correo o contraseña incorrectos.");

            DataRow row = dt.Rows[0];

            // Mapea la primera fila del resultado al objeto ET_Estudiante
            ET_Estudiante oEstudiante = new ET_Estudiante
            {
                ID = Convert.ToInt32(row["ID"]),
                nombre = row["nombre"].ToString(),
                correo = row["correo"].ToString(),
                contrasena = contrasena,
                fechaConexion = row["fechaConexion"].ToString(),
                // rachaActual puede ser null en BD si el campo es nullable
                rachaActual = row["rachaActual"] == DBNull.Value
                                ? 0
                                : Convert.ToInt32(row["rachaActual"])
            };

            // Aplica la lógica de racha y actualiza la fechaConexion en BD
            ActualizarRacha(oEstudiante);

            return oEstudiante;
        }

        // ============================================================
        //  LÓGICA DE RACHA
        // ============================================================

        // Calcula si la racha debe incrementar, mantenerse o reiniciarse
        // comparando la fecha del último login contra la fecha de hoy:
        //   - Mismo día      → no cambia (evita doble conteo en el mismo día)
        //   - Día siguiente  → incrementa en 1
        //   - 2+ días sin entrar → se reinicia a 0 (racha rota)
        // Al final persiste la nueva racha y la fecha de conexión actualizada.
        private void ActualizarRacha(ET_Estudiante oEstudiante)
        {
            DateTime hoy = DateTime.Today;
            DateTime ultimaConexion;

            bool tieneFecha = DateTime.TryParse(oEstudiante.fechaConexion, out ultimaConexion);

            if (tieneFecha)
            {
                int diasDiferencia = (hoy - ultimaConexion.Date).Days;

                if (diasDiferencia == 0)
                {
                    // Login en el mismo día: racha no cambia
                }
                else if (diasDiferencia == 1)
                {
                    // Día consecutivo: se suma 1 a la racha actual
                    oEstudiante.rachaActual = (oEstudiante.rachaActual ?? 0) + 1;
                }
                else
                {
                    // Brecha de 2 o más días: racha se rompe y vuelve a 0
                    oEstudiante.rachaActual = 0;
                }
            }
            else
            {
                // No había fecha previa registrada: es el primer login real
                oEstudiante.rachaActual = 1;
            }

            // Sella la nueva fecha de conexión y guarda los cambios en BD
            oEstudiante.fechaConexion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string rpta = _dalEstudiante.GuardarEstudiante(2, oEstudiante);
            if (rpta != "OK")
                throw new Exception("Error al actualizar la racha: " + rpta);
        }

        // ============================================================
        //  VERIFICAR INACTIVIDAD
        // ============================================================

        // Regla 3: determina si el estudiante lleva 3 o más días sin conectarse.
        // Se llama desde la GUI justo después del login, pasando la fechaConexion
        // anterior (antes de que ActualizarRacha la sobreescriba).
        // Retorna false si la fecha es inválida o vacía, para no generar falsos positivos.
        public bool VerificarInactividad(string ultimaFechaConexionAnterior)
        {
            if (string.IsNullOrWhiteSpace(ultimaFechaConexionAnterior))
                return false;

            if (!DateTime.TryParse(ultimaFechaConexionAnterior, out DateTime ultimaConexion))
                return false;

            int diasSinActividad = (DateTime.Today - ultimaConexion.Date).Days;
            return diasSinActividad >= 3;
        }

        // ============================================================
        //  ACTUALIZAR DATOS
        // ============================================================

        // Actualiza los datos personales del estudiante.
        // Nótese que el mínimo de caracteres para la contraseña aquí es 8,
        // mientras que en el registro es 6 — esto podría unificarse en el futuro.
        public string ActualizarEstudiante(ET_Estudiante oEstudiante)
        {
            if (oEstudiante.ID <= 0)
                throw new Exception("ID de estudiante no válido.");

            if (string.IsNullOrWhiteSpace(oEstudiante.nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(oEstudiante.correo))
                throw new Exception("El correo es obligatorio.");

            if (!oEstudiante.correo.Contains("@") || !oEstudiante.correo.Contains("."))
                throw new Exception("El correo no tiene un formato válido.");

            if (string.IsNullOrWhiteSpace(oEstudiante.contrasena))
                throw new Exception("La contraseña es obligatoria.");

            if (oEstudiante.contrasena.Length < 8)
                throw new Exception("La contraseña debe tener al menos 8 caracteres.");

            string rpta = _dalEstudiante.GuardarEstudiante(2, oEstudiante);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  ELIMINAR
        // ============================================================

        // Elimina la cuenta del estudiante por ID.
        // El USP debería manejar la eliminación en cascada de todas
        // las entidades relacionadas (materias, sesiones, kanban, etc.).
        public string EliminarEstudiante(int idEstudiante)
        {
            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            string rpta = _dalEstudiante.EliminarEstudiante(idEstudiante);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }
    }
}