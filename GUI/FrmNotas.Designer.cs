namespace GUII
{
    partial class FrmNotas
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
            button1 = new Button();
            btnKanban = new Button();
            pictureBoxLogo = new PictureBox();
            agregarRubroBTN = new Button();
            label7 = new Label();
            label6 = new Label();
            dgvMateriasNotas = new DataGridView();
            pnlAgregarRubro = new GroupBox();
            label14 = new Label();
            txtNotaObtenida = new TextBox();
            label13 = new Label();
            txtValorPorcentual = new TextBox();
            label17 = new Label();
            txtNombreRubro = new TextBox();
            btnEditarCuenta = new Button();
            btnCancelarCuenta = new Button();
            BtnSalir = new Button();
            pnlGestionarRubro = new GroupBox();
            SalirGestionRubrosbtn = new Button();
            btnEliminarRubro = new Button();
            btnEditarRubro = new Button();
            NombreMateria = new Label();
            DGVgestionarRubros = new DataGridView();
            btnHorario = new Button();
            label4 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriasNotas).BeginInit();
            pnlAgregarRubro.SuspendLayout();
            pnlGestionarRubro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVgestionarRubros).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_23_215949;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(11, 256);
            button1.Name = "button1";
            button1.Size = new Size(245, 90);
            button1.TabIndex = 47;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnKanban
            // 
            btnKanban.BackgroundImage = Properties.Resources.sd;
            btnKanban.BackgroundImageLayout = ImageLayout.Stretch;
            btnKanban.FlatAppearance.BorderSize = 0;
            btnKanban.FlatStyle = FlatStyle.Flat;
            btnKanban.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKanban.ForeColor = SystemColors.HighlightText;
            btnKanban.Location = new Point(11, 152);
            btnKanban.Name = "btnKanban";
            btnKanban.Size = new Size(245, 75);
            btnKanban.TabIndex = 46;
            btnKanban.UseVisualStyleBackColor = true;
            btnKanban.Click += btnKanban_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Image = Properties.Resources.Captura_de_pantalla_2026_04_22_183054;
            pictureBoxLogo.Location = new Point(26, 9);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(195, 127);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 45;
            pictureBoxLogo.TabStop = false;
            // 
            // agregarRubroBTN
            // 
            agregarRubroBTN.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            agregarRubroBTN.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarRubroBTN.ForeColor = SystemColors.HighlightText;
            agregarRubroBTN.Location = new Point(13, 222);
            agregarRubroBTN.Name = "agregarRubroBTN";
            agregarRubroBTN.Size = new Size(128, 40);
            agregarRubroBTN.TabIndex = 44;
            agregarRubroBTN.Text = "Agregar Rubro";
            agregarRubroBTN.UseVisualStyleBackColor = true;
            agregarRubroBTN.Click += agregarMateriaBTN_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(515, 134);
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(606, 196);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(417, 15);
            label7.TabIndex = 52;
            label7.Text = "\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f\u001f__________________________________________________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold);
            label6.Location = new Point(645, 99);
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("MS Reference Sans Serif", 30F, FontStyle.Bold);
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(713, 154);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(162, 40);
            label6.TabIndex = 51;
            label6.Text = "Materias";
            // 
            // dgvMateriasNotas
            // 
            dgvMateriasNotas.BackgroundColor = Color.LightCyan;
            dgvMateriasNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriasNotas.Location = new Point(653, 160);
            dgvMateriasNotas.Margin = new Padding(2);
            dgvMateriasNotas.Name = "dgvMateriasNotas";
            dgvMateriasNotas.RowHeadersWidth = 62;
            dgvMateriasNotas.Size = new Size(159, 519);
            dgvMateriasNotas.Location = new Point(405, 232);
            dgvMateriasNotas.Margin = new Padding(2);
            dgvMateriasNotas.Name = "dgvMateriasNotas";
            dgvMateriasNotas.RowHeadersWidth = 62;
            dgvMateriasNotas.Size = new Size(824, 478);
            dgvMateriasNotas.TabIndex = 50;
            dgvMateriasNotas.CellClick += dgvMateriasNotas_CellClick;
            // 
            // pnlAgregarRubro
            // 
            pnlAgregarRubro.BackColor = Color.AliceBlue;
            pnlAgregarRubro.BackgroundImage = Properties.Resources.verde_oscuro;
            pnlAgregarRubro.Controls.Add(label14);
            pnlAgregarRubro.Controls.Add(txtNotaObtenida);
            pnlAgregarRubro.Controls.Add(label13);
            pnlAgregarRubro.Controls.Add(txtValorPorcentual);
            pnlAgregarRubro.Controls.Add(label17);
            pnlAgregarRubro.Controls.Add(txtNombreRubro);
            pnlAgregarRubro.Controls.Add(btnEditarCuenta);
            pnlAgregarRubro.Controls.Add(btnCancelarCuenta);
            pnlAgregarRubro.ForeColor = SystemColors.Control;
            pnlAgregarRubro.Location = new Point(336, 216);
            pnlAgregarRubro.Location = new Point(459, 423);
            pnlAgregarRubro.Name = "pnlAgregarRubro";
            pnlAgregarRubro.Size = new Size(238, 244);
            pnlAgregarRubro.TabIndex = 53;
            pnlAgregarRubro.TabStop = false;
            pnlAgregarRubro.Text = "Rubro";
            pnlAgregarRubro.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(67, 128);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 22;
            label14.Text = "Nota obtenida";
            // 
            // txtNotaObtenida
            // 
            txtNotaObtenida.Location = new Point(60, 152);
            txtNotaObtenida.Margin = new Padding(3, 2, 3, 2);
            txtNotaObtenida.Name = "txtNotaObtenida";
            txtNotaObtenida.Size = new Size(110, 23);
            txtNotaObtenida.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(67, 78);
            label13.Name = "label13";
            label13.Size = new Size(93, 15);
            label13.TabIndex = 20;
            label13.Text = "Valor Porcentual";
            // 
            // txtValorPorcentual
            // 
            txtValorPorcentual.Location = new Point(60, 98);
            txtValorPorcentual.Margin = new Padding(3, 2, 3, 2);
            txtValorPorcentual.Name = "txtValorPorcentual";
            txtValorPorcentual.Size = new Size(110, 23);
            txtValorPorcentual.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(86, 28);
            label17.Name = "label17";
            label17.Size = new Size(51, 15);
            label17.TabIndex = 18;
            label17.Text = "Nombre";
            // 
            // txtNombreRubro
            // 
            txtNombreRubro.Location = new Point(60, 44);
            txtNombreRubro.Margin = new Padding(3, 2, 3, 2);
            txtNombreRubro.Name = "txtNombreRubro";
            txtNombreRubro.Size = new Size(110, 23);
            txtNombreRubro.TabIndex = 17;
            // 
            // btnEditarCuenta
            // 
            btnEditarCuenta.BackgroundImage = Properties.Resources.verde_claro;
            btnEditarCuenta.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCuenta.ForeColor = SystemColors.HighlightText;
            btnEditarCuenta.Location = new Point(126, 190);
            btnEditarCuenta.Name = "btnEditarCuenta";
            btnEditarCuenta.Size = new Size(90, 35);
            btnEditarCuenta.TabIndex = 16;
            btnEditarCuenta.Text = "Guardar";
            btnEditarCuenta.UseVisualStyleBackColor = true;
            btnEditarCuenta.Click += btnEditarCuenta_Click;
            // 
            // btnCancelarCuenta
            // 
            btnCancelarCuenta.BackgroundImage = Properties.Resources.verde_claro;
            btnCancelarCuenta.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarCuenta.ForeColor = SystemColors.HighlightText;
            btnCancelarCuenta.Location = new Point(13, 190);
            btnCancelarCuenta.Name = "btnCancelarCuenta";
            btnCancelarCuenta.Size = new Size(90, 35);
            btnCancelarCuenta.TabIndex = 15;
            btnCancelarCuenta.Text = "Cancelar";
            btnCancelarCuenta.UseVisualStyleBackColor = true;
            btnCancelarCuenta.Click += btnCancelarCuenta_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Transparent;
            BtnSalir.BackgroundImage = Properties.Resources.salir;
            BtnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.HighlightText;
            BtnSalir.Location = new Point(1304, 20);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(50, 42);
            BtnSalir.TabIndex = 54;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // pnlGestionarRubro
            // 
            pnlGestionarRubro.BackColor = Color.AliceBlue;
            pnlGestionarRubro.BackgroundImage = Properties.Resources.verde_oscuro;
            pnlGestionarRubro.Controls.Add(SalirGestionRubrosbtn);
            pnlGestionarRubro.Controls.Add(btnEliminarRubro);
            pnlGestionarRubro.Controls.Add(btnEditarRubro);
            pnlGestionarRubro.Controls.Add(NombreMateria);
            pnlGestionarRubro.Controls.Add(agregarRubroBTN);
            pnlGestionarRubro.Controls.Add(DGVgestionarRubros);
            pnlGestionarRubro.ForeColor = SystemColors.Control;
            pnlGestionarRubro.Location = new Point(600, 228);
            pnlGestionarRubro.Location = new Point(795, 367);
            pnlGestionarRubro.Name = "pnlGestionarRubro";
            pnlGestionarRubro.Size = new Size(644, 278);
            pnlGestionarRubro.TabIndex = 55;
            pnlGestionarRubro.TabStop = false;
            pnlGestionarRubro.Text = "Gestionar Rubros";
            pnlGestionarRubro.Visible = false;
            // 
            // SalirGestionRubrosbtn
            // 
            SalirGestionRubrosbtn.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            SalirGestionRubrosbtn.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalirGestionRubrosbtn.ForeColor = SystemColors.HighlightText;
            SalirGestionRubrosbtn.Location = new Point(425, 230);
            SalirGestionRubrosbtn.Name = "SalirGestionRubrosbtn";
            SalirGestionRubrosbtn.Size = new Size(26, 23);
            SalirGestionRubrosbtn.TabIndex = 56;
            SalirGestionRubrosbtn.Text = "X";
            SalirGestionRubrosbtn.UseVisualStyleBackColor = true;
            SalirGestionRubrosbtn.Click += SalirGestionRubrosbtn_Click;
            // 
            // btnEliminarRubro
            // 
            btnEliminarRubro.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            btnEliminarRubro.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarRubro.ForeColor = SystemColors.HighlightText;
            btnEliminarRubro.Location = new Point(279, 222);
            btnEliminarRubro.Name = "btnEliminarRubro";
            btnEliminarRubro.Size = new Size(128, 40);
            btnEliminarRubro.TabIndex = 55;
            btnEliminarRubro.Text = "Eliminar Rubro";
            btnEliminarRubro.UseVisualStyleBackColor = true;
            btnEliminarRubro.Click += btnEliminarRubro_Click;
            // 
            // btnEditarRubro
            // 
            btnEditarRubro.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            btnEditarRubro.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarRubro.ForeColor = SystemColors.HighlightText;
            btnEditarRubro.Location = new Point(146, 222);
            btnEditarRubro.Name = "btnEditarRubro";
            btnEditarRubro.Size = new Size(128, 40);
            btnEditarRubro.TabIndex = 54;
            btnEditarRubro.Text = "Editar Rubro";
            btnEditarRubro.UseVisualStyleBackColor = true;
            btnEditarRubro.Click += btnEditarRubro_Click;
            // 
            // NombreMateria
            // 
            NombreMateria.AutoSize = true;
            NombreMateria.BackColor = Color.Transparent;
            NombreMateria.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NombreMateria.Location = new Point(235, 14);
            NombreMateria.Margin = new Padding(2, 0, 2, 0);
            NombreMateria.Name = "NombreMateria";
            NombreMateria.Size = new Size(162, 40);
            NombreMateria.TabIndex = 53;
            NombreMateria.Text = "Materias";
            // 
            // DGVgestionarRubros
            // 
            DGVgestionarRubros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVgestionarRubros.Location = new Point(5, 56);
            DGVgestionarRubros.Name = "DGVgestionarRubros";
            DGVgestionarRubros.RowHeadersWidth = 51;
            DGVgestionarRubros.Size = new Size(634, 160);
            DGVgestionarRubros.TabIndex = 0;
            DGVgestionarRubros.CellClick += DGVgestionarRubros_CellClick;
            // 
            // btnHorario
            // 
            btnHorario.BackColor = Color.Transparent;
            btnHorario.BackgroundImage = Properties.Resources.casita;
            btnHorario.BackgroundImageLayout = ImageLayout.Stretch;
            btnHorario.FlatAppearance.BorderSize = 0;
            btnHorario.FlatStyle = FlatStyle.Flat;
            btnHorario.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHorario.ForeColor = SystemColors.HighlightText;
            btnHorario.Location = new Point(290, 20);
            btnHorario.Location = new Point(321, 31);
            btnHorario.Name = "btnHorario";
            btnHorario.Size = new Size(50, 42);
            btnHorario.TabIndex = 56;
            btnHorario.UseVisualStyleBackColor = false;
            btnHorario.Click += btnHorario_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 32);
            label4.Location = new Point(368, 40);
            label4.Name = "label4";
            label4.Size = new Size(88, 24);
            label4.TabIndex = 60;
            label4.Text = "Horario";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.BackgroundImage = Properties.Resources.verde_oscuro;
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button3);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(356, 478);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 250);
            groupBox2.TabIndex = 71;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recordatorio";
            groupBox2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(75, 113);
            label9.Name = "label9";
            label9.Size = new Size(88, 24);
            label9.TabIndex = 61;
            label9.Text = "Horario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(66, 232);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 22;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.verde_claro;
            button3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(75, 172);
            button3.Name = "button3";
            button3.Size = new Size(90, 35);
            button3.TabIndex = 16;
            button3.Text = "Aceptar";
            button3.UseVisualStyleBackColor = true;
            // 
            // FrmNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Presentación_diapositivas_cosmética_natural_negocio_elegante_minimalista_beige;
            ClientSize = new Size(1402, 753);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(btnHorario);
            Controls.Add(pnlGestionarRubro);
            Controls.Add(BtnSalir);
            Controls.Add(pnlAgregarRubro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvMateriasNotas);
            Controls.Add(button1);
            Controls.Add(btnKanban);
            Controls.Add(pictureBoxLogo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmNotas";
            Text = "FrmNotas";
            Load += FrmNotas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriasNotas).EndInit();
            pnlAgregarRubro.ResumeLayout(false);
            pnlAgregarRubro.PerformLayout();
            pnlGestionarRubro.ResumeLayout(false);
            pnlGestionarRubro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVgestionarRubros).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnKanban;
        private PictureBox pictureBoxLogo;
        private Button agregarRubroBTN;
        private Label label7;
        private Label label6;
        private DataGridView dgvMateriasNotas;
        private GroupBox pnlAgregarRubro;
        private Label label14;
        private TextBox txtNotaObtenida;
        private Label label13;
        private TextBox txtValorPorcentual;
        private Label label17;
        private TextBox txtNombreRubro;
        private Button btnEditarCuenta;
        private Button btnCancelarCuenta;
        private Button BtnSalir;
        private GroupBox pnlGestionarRubro;
        private DataGridView DGVgestionarRubros;
        private Button btnEliminarRubro;
        private Button btnEditarRubro;
        private Label NombreMateria;
        private Button SalirGestionRubrosbtn;
        private Button btnHorario;
        private Label label4;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Button button3;
    }
}