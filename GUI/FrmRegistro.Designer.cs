using System.Windows.Forms;

namespace GUI
{
    partial class FrmRegistro
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
            Agregar_Nombre.Location = new Point(200, 110);
            Agregar_Nombre.Name = "Agregar_Nombre";
            Agregar_Nombre.Size = new Size(73, 28);
            Agregar_Nombre.TabIndex = 0;
            Agregar_Nombre.Text = "Cuenta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(25, 164);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 182);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(431, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(25, 243);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(436, 23);
            txtCorreo.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(25, 305);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(436, 23);
            txtContrasena.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(25, 287);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 7;
            label2.Text = "Ingrese la Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(25, 225);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 8;
            label3.Text = "Correo Electrónico";
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(248, 437);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(90, 23);
            BtnCrear.TabIndex = 12;
            BtnCrear.Text = "Crear";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(185, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(135, 437);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
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
            panel1.Location = new Point(528, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 523);
            panel1.TabIndex = 1;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.verde_oscuro;
            ClientSize = new Size(1061, 598);
            Controls.Add(panel1);
            Name = "FrmRegistro";
            Text = "Form1";
            Load += FrmRegistro_Load;
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
