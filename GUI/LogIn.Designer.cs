namespace Mockup
{
    partial class LogIn
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            BtnRegistrarse = new Button();
            label1 = new Label();
            BtnLogin = new Button();
            TxtPassword = new TextBox();
            txtUsername = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.MenuBar;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BtnRegistrarse);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(TxtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(650, 190);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 689);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = GUII.Properties.Resources.Captura_de_pantalla_2026_04_22_183054;
            pictureBox1.Location = new Point(115, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 367);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 308);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Correo:";
            // 
            // BtnRegistrarse
            // 
            BtnRegistrarse.BackColor = Color.DarkCyan;
            BtnRegistrarse.FlatAppearance.BorderColor = Color.Black;
            BtnRegistrarse.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            BtnRegistrarse.ForeColor = SystemColors.ControlLightLight;
            BtnRegistrarse.Location = new Point(225, 474);
            BtnRegistrarse.Margin = new Padding(3, 4, 3, 4);
            BtnRegistrarse.Name = "BtnRegistrarse";
            BtnRegistrarse.Size = new Size(97, 39);
            BtnRegistrarse.TabIndex = 4;
            BtnRegistrarse.Text = "Registrarse";
            BtnRegistrarse.UseVisualStyleBackColor = false;
            BtnRegistrarse.Click += BtnRegistrarse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 225);
            label1.Name = "label1";
            label1.Size = new Size(285, 52);
            label1.TabIndex = 3;
            label1.Text = "Iniciar Sesión";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.DarkCyan;
            BtnLogin.FlatAppearance.BorderColor = Color.Black;
            BtnLogin.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            BtnLogin.ForeColor = SystemColors.ControlLightLight;
            BtnLogin.Location = new Point(225, 427);
            BtnLogin.Margin = new Padding(3, 4, 3, 4);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(97, 39);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(194, 364);
            TxtPassword.Margin = new Padding(3, 4, 3, 4);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(166, 27);
            TxtPassword.TabIndex = 1;
            TxtPassword.Tag = "   Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(194, 305);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(166, 27);
            txtUsername.TabIndex = 0;
            txtUsername.Tag = "Username";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = GUII.Properties.Resources.verde_claro;
            ClientSize = new Size(1578, 846);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogIn";
            Text = "Form1";
            Load += LogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button BtnLogin;
        private TextBox TxtPassword;
        private TextBox txtUsername;
        private Button BtnRegistrarse;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
