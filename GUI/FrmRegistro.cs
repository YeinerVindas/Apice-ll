using BL;
using ET;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmRegistro : Form
    {
        #region Variables
        // Instancia de la BL para el registro del estudiante
        private readonly BL_Estudiante _blEstudiante = new BL_Estudiante();
        #endregion

        #region Constructor
        public FrmRegistro()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            // Enmascara el campo de contraseña para que no se vea el texto al escribir
            txtContrasena.PasswordChar = '*';
            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.BringToFront();
            this.Activate();
        }
        #endregion

        #region Botón Crear
        // Construye el objeto ET_Estudiante con los datos del formulario y lo envía a la BL.
        // Si la BL lanza excepción por validación fallida, se muestra el mensaje de error
        // sin cerrar el form para que el usuario pueda corregir los datos.
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                ET_Estudiante oEstudiante = new ET_Estudiante
                {
                    nombre = txtNombre.Text.Trim(),
                    correo = txtCorreo.Text.Trim(),
                    contrasena = txtContrasena.Text.Trim()
                };

                string rpta = _blEstudiante.RegistrarEstudiante(oEstudiante);

                if (rpta == "OK")
                {
                    MessageBox.Show("¡Cuenta creada exitosamente! Ya puedes iniciar sesión.",
                        "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Cierra el form de registro y regresa al login
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Los errores de validación de la BL se muestran como advertencia, no como error,
                // porque son mensajes esperados para el usuario y no fallos del sistema
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Botón Cancelar
        // Cierra el form sin hacer nada, regresando al login
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}