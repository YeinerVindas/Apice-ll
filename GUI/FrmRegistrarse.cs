using BL;
using Microsoft.VisualBasic.Logging;
using Mockup;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region ?? Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region ?? Load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.BringToFront();
            this.Activate();
        }
        #endregion

        #region ?? Eventos Botones

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn frm = new LogIn();
            frm.Show();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            string rpta = BL_Estudiante.GuardarES(1, new ET.ET_Estudiante
            {
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Contrasena = txtContrasena.Text,
                FechaConexion = DateTime.Now,
                RachaActual = 0
            });

            if (rpta.ToUpper() == "OK")
            {
                MessageBox.Show("Usuario creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Usuario creado exitosamente",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Hide();
                LogIn frm = new LogIn();
                frm.Show();
            }
            else
            {
                MessageBox.Show(rpta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}