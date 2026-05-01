using System.Drawing.Printing;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GUII
{
    partial class FrmSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnIniciar_Click = new Button();
            btnPausar_Click = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciar_Click
            // 
            btnIniciar_Click.BackColor = Color.Transparent;
            btnIniciar_Click.BackgroundImage = Properties.Resources.pausa_removebg_preview;
            btnIniciar_Click.BackgroundImageLayout = ImageLayout.Zoom;
            btnIniciar_Click.FlatAppearance.BorderSize = 0;
            btnIniciar_Click.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIniciar_Click.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIniciar_Click.FlatStyle = FlatStyle.Flat;
            btnIniciar_Click.Location = new Point(390, 520);
            btnIniciar_Click.Margin = new Padding(3, 4, 3, 4);
            btnIniciar_Click.Name = "btnIniciar_Click";
            btnIniciar_Click.Size = new Size(107, 89);
            btnIniciar_Click.TabIndex = 1;
            btnIniciar_Click.UseVisualStyleBackColor = false;
            btnIniciar_Click.Click += btnIniciar_Click_Click;
            // 
            // btnPausar_Click
            // 
            btnPausar_Click.BackColor = Color.Transparent;
            btnPausar_Click.BackgroundImage = Properties.Resources.Pausa_sin_fondo;
            btnPausar_Click.BackgroundImageLayout = ImageLayout.Zoom;
            btnPausar_Click.FlatAppearance.BorderSize = 0;
            btnPausar_Click.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPausar_Click.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPausar_Click.FlatStyle = FlatStyle.Flat;
            btnPausar_Click.Location = new Point(533, 509);
            btnPausar_Click.Margin = new Padding(3, 4, 3, 4);
            btnPausar_Click.Name = "btnPausar_Click";
            btnPausar_Click.Size = new Size(87, 91);
            btnPausar_Click.TabIndex = 2;
            btnPausar_Click.UseVisualStyleBackColor = false;
            btnPausar_Click.Click += btnPausar_Click_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 30F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(513, 347);
            label1.Name = "label1";
            label1.Size = new Size(165, 67);
            label1.TabIndex = 3;
            label1.Text = "00.00";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Reloj;
            pictureBox2.Location = new Point(341, 311);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 127);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.fondo_negro;
            pictureBox3.Location = new Point(293, 62);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(541, 189);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new System.Drawing.Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(478, 131);
            label2.Name = "label2";
            label2.Size = new Size(159, 46);
            label2.TabIndex = 6;
            label2.Text = "Materias";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumAquamarine;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(808, 656);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(206, 71);
            button3.TabIndex = 9;
            button3.Text = "Salir de sesión";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(642, 503);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 236);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(146, 100);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(74, 43);
            button2.TabIndex = 2;
            button2.Text = "No";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(50, 100);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(74, 43);
            button1.TabIndex = 1;
            button1.Text = "Si";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(3, 27);
            label3.Name = "label3";
            label3.Size = new Size(437, 20);
            label3.TabIndex = 0;
            label3.Text = "¿Está seguro (a) que desea salir de la sesion de estudio?";
            // 
            // FrmSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_23_0826164;
            ClientSize = new Size(1110, 752);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnPausar_Click);
            Controls.Add(btnIniciar_Click);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmSesion";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIniciar_Click;
        private Button btnPausar_Click;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Button button3;
        private Panel panel1;
        private Label label3;
        private Button button2;
        private Button button1;
    }
}