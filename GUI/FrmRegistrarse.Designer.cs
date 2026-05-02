using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Agregar_Nombre = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BtnCrear = new Button();
            pictureBox2 = new PictureBox();
            btnCancelar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Agregar_Nombre
            // 
            Agregar_Nombre.AutoSize = true;
            Agregar_Nombre.BackColor = Color.Transparent;
            Agregar_Nombre.Font = new Font("Segoe UI", 15F);
            Agregar_Nombre.Location = new Point(228, 146);
            Agregar_Nombre.Name = "Agregar_Nombre";
            Agregar_Nombre.Size = new Size(92, 35);
            Agregar_Nombre.TabIndex = 0;
            Agregar_Nombre.Text = "Cuenta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(29, 219);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 243);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(492, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(29, 324);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(498, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(29, 407);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(498, 27);
            txtContrasena.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(29, 383);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 7;
            label2.Text = "Ingrese la Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(29, 300);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 8;
            label3.Text = "Correo Electrónico";
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(284, 583);
            BtnCrear.Margin = new Padding(3, 4, 3, 4);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(103, 31);
            BtnCrear.TabIndex = 12;
            BtnCrear.Text = "Crear";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GUII.Properties.Resources.user;
            pictureBox2.Location = new Point(211, 22);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(154, 583);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 31);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(BtnCrear);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Agregar_Nombre);
            panel1.Location = new Point(604, 170);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 697);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            ClientSize = new Size(1213, 797);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label Agregar_Nombre;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtContrasena;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Button BtnCrear;
        private PictureBox pictureBox2;
        private Button btnCancelar;
    }
}
