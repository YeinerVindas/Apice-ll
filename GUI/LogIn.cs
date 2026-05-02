using BL;
using GUI;
using System.Data;
using System.Drawing.Drawing2D;
using WinFormsApp1;

namespace Mockup;

public partial class LogIn : Form
{
    #region 🔹 Constructor
    public LogIn()
    {
        InitializeComponent();
        BordesRedondeados(panel1, 25); // 25 = radio de las esquinas
    }
    #endregion

    #region 🔹 Load
    private void LogIn_Load(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;
        this.Show();
        this.BringToFront();
        this.Activate();
    }
    #endregion

    #region 🔹 Métodos

    private void BordesRedondeados(Panel panel, int radio)
    {
        GraphicsPath path = new GraphicsPath();

        path.StartFigure();
        path.AddArc(0, 0, radio, radio, 180, 90);
        path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
        path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
        path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
        path.CloseFigure();

        panel.Region = new Region(path);
    }

    #endregion

    #region 🔹 Eventos Botones

    private void BtnRegistrarse_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form1 Frm = new Form1();
        Frm.Show();
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        DataTable tabla = BL_Estudiante.ComprobarES(txtUsername.Text, TxtPassword.Text);

        if (tabla != null && tabla.Rows.Count > 0)
        {
            int idEstudiante = Convert.ToInt32(tabla.Rows[0]["ID"]);

            MessageBox.Show("¡Bienvenido a Ápice!", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HorarioPrincipal frm = new HorarioPrincipal(idEstudiante);
            frm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Credenciales inválidas. Verifique su correo o contraseña.",
                            "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }

    #endregion
}