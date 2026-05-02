using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace GUII
{
    public partial class FrmSesion : Form
    {
        int segundos = 0;
        public FrmSesion(int idEstudiante, string nombreMateria)
        {
            InitializeComponent();

            // Aplicar esquinas redondeadas a button3 y mantenerlo al cambiar tamaño
            SetRoundedButton(button3, 12);
            button3.SizeChanged += (s, e) => SetRoundedButton(button3, 12);
            label2.Text = nombreMateria;
        }

        private void SetRoundedButton(Button btn, int radius)
        {
            if (btn == null || btn.Width <= 0 || btn.Height <= 0) return;

            var path = new GraphicsPath();
            int r = Math.Min(radius, Math.Min(btn.Width / 2, btn.Height / 2));
            var rect = new Rectangle(0, 0, btn.Width, btn.Height);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r * 2, r * 2, 180, 90);
            path.AddArc(rect.Right - r * 2, rect.Y, r * 2, r * 2, 270, 90);
            path.AddArc(rect.Right - r * 2, rect.Bottom - r * 2, r * 2, r * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r * 2, r * 2, r * 2, 90, 90);
            path.CloseFigure();

            btn.Region?.Dispose();
            btn.Region = new Region(path);

            path.Dispose();
        }

        private void btnIniciar_Click_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPausar_Click_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;

            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int seg = segundos % 60;

            label1.Text = $"{horas:00}:{minutos:00}:{seg:00}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void button3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Mostrar el panel y traerlo al frente
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            label2.Text = "peach";
        }
    }
}
