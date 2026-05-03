using BL;
using ET;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LogIn : Form
    {
        #region Variables
        private readonly BL_Estudiante _blEstudiante = new BL_Estudiante();
        #endregion

        #region Constructor
        public LogIn()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void LogIn_Load(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = '*';
            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.BringToFront();
            this.Activate();
        }
        #endregion

        #region Login

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtUsername.Text.Trim();
            string contrasena = TxtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor ingresa tu correo y contraseña.",
                    "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener la fechaConexion anterior ANTES de que Login la actualice
                // Se hace una consulta previa a la DAL para leer el valor actual
                string fechaAnterior = ObtenerFechaAnterior(correo, contrasena);

                // Login real — valida credenciales, actualiza racha y fechaConexion
                // Retorna ET_Estudiante con los datos del estudiante autenticado
                ET_Estudiante estudiante = _blEstudiante.Login(correo, contrasena);

                // Abrir home pasando el ID y la fecha anterior para la regla de inactividad
                HorarioPrincipal home = new HorarioPrincipal(estudiante.ID, fechaAnterior);
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Lee la fechaConexion actual del estudiante antes de que Login la sobreescriba.
        /// Así HorarioPrincipal puede calcular si hubo inactividad >= 3 días.
        /// </summary>
        private string ObtenerFechaAnterior(string correo, string contrasena)
        {
            try
            {
                // Usamos la DAL directamente para no disparar ActualizarRacha dos veces
                DAL.DAL_Estudiante dal = new DAL.DAL_Estudiante();
                System.Data.DataTable dt = dal.Login(correo, contrasena);

                if (dt != null && dt.Rows.Count > 0)
                    return dt.Rows[0]["fechaConexion"].ToString();
            }
            catch { }

            return DateTime.Today.ToString("yyyy-MM-dd");
        }

        #endregion

        #region Registro

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.ShowDialog();
        }

        #endregion
    }
}
