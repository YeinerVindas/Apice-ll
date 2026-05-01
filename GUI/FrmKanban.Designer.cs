using System.Windows.Forms;
using System.Xml.Linq;

namespace GUII
{
    partial class FrmKanban
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
            BtnNotas = new Button();
            BtnKanban = new Button();
            pictureBoxLogo = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            DGVtareasCompletado = new DataGridView();
            DGVtareasEnProceso = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DGVtareasPendientes = new DataGridView();
            label4 = new Label();
            btnHorario = new Button();
            BtnSalir = new Button();
            btnEliminarTarea = new Button();
            btnEditarTarea = new Button();
            agregarTareaBTN = new Button();
            pnlAgregarTarea = new GroupBox();
            DTPtarea = new DateTimePicker();
            txtDescripcionTarea = new RichTextBox();
            label14 = new Label();
            label13 = new Label();
            label17 = new Label();
            btnGuardarTarea = new Button();
            btnCancelarCuenta = new Button();
            MoverTareaPendiente = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            MoverTareaEnProceso = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVtareasCompletado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVtareasEnProceso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVtareasPendientes).BeginInit();
            pnlAgregarTarea.SuspendLayout();
            MoverTareaPendiente.SuspendLayout();
            MoverTareaEnProceso.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnNotas
            // 
            BtnNotas.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_23_215949;
            BtnNotas.BackgroundImageLayout = ImageLayout.Stretch;
            BtnNotas.FlatAppearance.BorderSize = 0;
            BtnNotas.FlatStyle = FlatStyle.Flat;
            BtnNotas.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNotas.ForeColor = SystemColors.HighlightText;
            BtnNotas.Location = new Point(16, 356);
            BtnNotas.Margin = new Padding(3, 4, 3, 4);
            BtnNotas.Name = "BtnNotas";
            BtnNotas.Size = new Size(280, 120);
            BtnNotas.TabIndex = 43;
            BtnNotas.UseVisualStyleBackColor = true;
            BtnNotas.Click += BtnNotas_Click;
            // 
            // BtnKanban
            // 
            BtnKanban.BackgroundImage = Properties.Resources.sd;
            BtnKanban.BackgroundImageLayout = ImageLayout.Stretch;
            BtnKanban.FlatAppearance.BorderSize = 0;
            BtnKanban.FlatStyle = FlatStyle.Flat;
            BtnKanban.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKanban.ForeColor = SystemColors.HighlightText;
            BtnKanban.Location = new Point(16, 217);
            BtnKanban.Margin = new Padding(3, 4, 3, 4);
            BtnKanban.Name = "BtnKanban";
            BtnKanban.Size = new Size(280, 100);
            BtnKanban.TabIndex = 42;
            BtnKanban.UseVisualStyleBackColor = true;

            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Image = Properties.Resources.Captura_de_pantalla_2026_04_22_183054;
            pictureBoxLogo.Location = new Point(33, 26);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(223, 169);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 41;
            pictureBoxLogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(DGVtareasCompletado, 2, 1);
            tableLayoutPanel1.Controls.Add(DGVtareasEnProceso, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(DGVtareasPendientes, 0, 1);
            tableLayoutPanel1.Location = new Point(323, 145);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.Size = new Size(1267, 694);
            tableLayoutPanel1.TabIndex = 44;
            // 
            // DGVtareasCompletado
            // 
            DGVtareasCompletado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVtareasCompletado.Dock = DockStyle.Fill;
            DGVtareasCompletado.Location = new Point(847, 118);
            DGVtareasCompletado.Name = "DGVtareasCompletado";
            DGVtareasCompletado.RowHeadersWidth = 51;
            DGVtareasCompletado.Size = new Size(417, 573);
            DGVtareasCompletado.TabIndex = 9;
            DGVtareasCompletado.CellClick += DGVtareasCompletado_CellClick;
            // 
            // DGVtareasEnProceso
            // 
            DGVtareasEnProceso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVtareasEnProceso.Dock = DockStyle.Fill;
            DGVtareasEnProceso.Location = new Point(425, 118);
            DGVtareasEnProceso.Name = "DGVtareasEnProceso";
            DGVtareasEnProceso.RowHeadersWidth = 51;
            DGVtareasEnProceso.Size = new Size(416, 573);
            DGVtareasEnProceso.TabIndex = 8;
            DGVtareasEnProceso.CellClick += DGVtareasEnProceso_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            label3.Location = new Point(847, 0);
            label3.Name = "label3";
            label3.Size = new Size(417, 115);
            label3.TabIndex = 6;
            label3.Text = "Completado";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            label2.Location = new Point(425, 0);
            label2.Name = "label2";
            label2.Size = new Size(416, 115);
            label2.TabIndex = 5;
            label2.Text = "En Proceso";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(416, 115);
            label1.TabIndex = 3;
            label1.Text = "Pendiente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGVtareasPendientes
            // 
            DGVtareasPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVtareasPendientes.Dock = DockStyle.Fill;
            DGVtareasPendientes.Location = new Point(3, 118);
            DGVtareasPendientes.Name = "DGVtareasPendientes";
            DGVtareasPendientes.RowHeadersWidth = 51;
            DGVtareasPendientes.Size = new Size(416, 573);
            DGVtareasPendientes.TabIndex = 7;
            DGVtareasPendientes.CellClick += DGVtareasPendientes_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold);
            label4.Location = new Point(386, 44);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 59;
            label4.Text = "Horario";
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
            btnHorario.Location = new Point(323, 26);
            btnHorario.Margin = new Padding(3, 4, 3, 4);
            btnHorario.Name = "btnHorario";
            btnHorario.Size = new Size(57, 56);
            btnHorario.TabIndex = 58;
            btnHorario.UseVisualStyleBackColor = false;
            btnHorario.Click += btnHorario_Click;
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
            BtnSalir.Location = new Point(1427, 26);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(57, 56);
            BtnSalir.TabIndex = 60;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            btnEliminarTarea.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarTarea.ForeColor = SystemColors.HighlightText;
            btnEliminarTarea.Location = new Point(630, 846);
            btnEliminarTarea.Margin = new Padding(3, 4, 3, 4);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(146, 53);
            btnEliminarTarea.TabIndex = 63;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // btnEditarTarea
            // 
            btnEditarTarea.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            btnEditarTarea.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarTarea.ForeColor = SystemColors.HighlightText;
            btnEditarTarea.Location = new Point(478, 846);
            btnEditarTarea.Margin = new Padding(3, 4, 3, 4);
            btnEditarTarea.Name = "btnEditarTarea";
            btnEditarTarea.Size = new Size(146, 53);
            btnEditarTarea.TabIndex = 62;
            btnEditarTarea.Text = "Editar Tarea";
            btnEditarTarea.UseVisualStyleBackColor = true;
            btnEditarTarea.Click += btnEditarTarea_Click;
            // 
            // agregarTareaBTN
            // 
            agregarTareaBTN.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            agregarTareaBTN.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarTareaBTN.ForeColor = SystemColors.HighlightText;
            agregarTareaBTN.Location = new Point(326, 846);
            agregarTareaBTN.Margin = new Padding(3, 4, 3, 4);
            agregarTareaBTN.Name = "agregarTareaBTN";
            agregarTareaBTN.Size = new Size(146, 53);
            agregarTareaBTN.TabIndex = 61;
            agregarTareaBTN.Text = "Agregar Tarea";
            agregarTareaBTN.UseVisualStyleBackColor = true;
            agregarTareaBTN.Click += agregarTareaBTN_Click;
            // 
            // pnlAgregarTarea
            // 
            pnlAgregarTarea.BackColor = Color.AliceBlue;
            pnlAgregarTarea.BackgroundImage = Properties.Resources.verde_oscuro;
            pnlAgregarTarea.Controls.Add(DTPtarea);
            pnlAgregarTarea.Controls.Add(txtDescripcionTarea);
            pnlAgregarTarea.Controls.Add(label14);
            pnlAgregarTarea.Controls.Add(label13);
            pnlAgregarTarea.Controls.Add(label17);
            pnlAgregarTarea.Controls.Add(btnGuardarTarea);
            pnlAgregarTarea.Controls.Add(btnCancelarCuenta);
            pnlAgregarTarea.ForeColor = SystemColors.Control;
            pnlAgregarTarea.Location = new Point(308, 486);
            pnlAgregarTarea.Margin = new Padding(3, 4, 3, 4);
            pnlAgregarTarea.Name = "pnlAgregarTarea";
            pnlAgregarTarea.Padding = new Padding(3, 4, 3, 4);
            pnlAgregarTarea.Size = new Size(272, 334);
            pnlAgregarTarea.TabIndex = 64;
            pnlAgregarTarea.TabStop = false;
            pnlAgregarTarea.Text = "Tarea";
            pnlAgregarTarea.Visible = false;
            // 
            // DTPtarea
            // 
            DTPtarea.Location = new Point(6, 214);
            DTPtarea.Name = "DTPtarea";
            DTPtarea.Size = new Size(250, 27);
            DTPtarea.TabIndex = 24;
            DTPtarea.Value = new DateTime(2026, 4, 26, 18, 12, 13, 0);
            // 
            // txtDescripcionTarea
            // 
            txtDescripcionTarea.Location = new Point(15, 47);
            txtDescripcionTarea.Name = "txtDescripcionTarea";
            txtDescripcionTarea.Size = new Size(241, 131);
            txtDescripcionTarea.TabIndex = 23;
            txtDescripcionTarea.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(75, 310);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(68, 191);
            label13.Name = "label13";
            label13.Size = new Size(123, 20);
            label13.TabIndex = 20;
            label13.Text = "Fecha de entrega";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(92, 24);
            label17.Name = "label17";
            label17.Size = new Size(87, 20);
            label17.TabIndex = 18;
            label17.Text = "Descripcion";
            // 
            // btnGuardarTarea
            // 
            btnGuardarTarea.BackgroundImage = Properties.Resources.verde_claro;
            btnGuardarTarea.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarTarea.ForeColor = SystemColors.HighlightText;
            btnGuardarTarea.Location = new Point(144, 264);
            btnGuardarTarea.Margin = new Padding(3, 4, 3, 4);
            btnGuardarTarea.Name = "btnGuardarTarea";
            btnGuardarTarea.Size = new Size(103, 47);
            btnGuardarTarea.TabIndex = 16;
            btnGuardarTarea.Text = "Guardar";
            btnGuardarTarea.UseVisualStyleBackColor = true;
            btnGuardarTarea.Click += btnGuardarTarea_Click;
            // 
            // btnCancelarCuenta
            // 
            btnCancelarCuenta.BackgroundImage = Properties.Resources.verde_claro;
            btnCancelarCuenta.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarCuenta.ForeColor = SystemColors.HighlightText;
            btnCancelarCuenta.Location = new Point(15, 264);
            btnCancelarCuenta.Margin = new Padding(3, 4, 3, 4);
            btnCancelarCuenta.Name = "btnCancelarCuenta";
            btnCancelarCuenta.Size = new Size(103, 47);
            btnCancelarCuenta.TabIndex = 15;
            btnCancelarCuenta.Text = "Cancelar";
            btnCancelarCuenta.UseVisualStyleBackColor = true;
            btnCancelarCuenta.Click += btnCancelarCuenta_Click;
            // 
            // MoverTareaPendiente
            // 
            MoverTareaPendiente.BackColor = Color.AliceBlue;
            MoverTareaPendiente.BackgroundImage = Properties.Resources.verde_oscuro;
            MoverTareaPendiente.Controls.Add(button2);
            MoverTareaPendiente.Controls.Add(label5);
            MoverTareaPendiente.ForeColor = SystemColors.Control;
            MoverTareaPendiente.Location = new Point(391, 924);
            MoverTareaPendiente.Margin = new Padding(3, 4, 3, 4);
            MoverTareaPendiente.Name = "MoverTareaPendiente";
            MoverTareaPendiente.Padding = new Padding(3, 4, 3, 4);
            MoverTareaPendiente.Size = new Size(108, 95);
            MoverTareaPendiente.TabIndex = 65;
            MoverTareaPendiente.TabStop = false;
            MoverTareaPendiente.Text = "Mover tarea";
            MoverTareaPendiente.Visible = false;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            button2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(19, 28);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(56, 53);
            button2.TabIndex = 65;
            button2.Text = "--->";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(75, 311);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 22;
            // 
            // MoverTareaEnProceso
            // 
            MoverTareaEnProceso.BackColor = Color.AliceBlue;
            MoverTareaEnProceso.BackgroundImage = Properties.Resources.verde_oscuro;
            MoverTareaEnProceso.Controls.Add(button3);
            MoverTareaEnProceso.Controls.Add(button1);
            MoverTareaEnProceso.Controls.Add(label6);
            MoverTareaEnProceso.ForeColor = SystemColors.Control;
            MoverTareaEnProceso.Location = new Point(867, 934);
            MoverTareaEnProceso.Margin = new Padding(3, 4, 3, 4);
            MoverTareaEnProceso.Name = "MoverTareaEnProceso";
            MoverTareaEnProceso.Padding = new Padding(3, 4, 3, 4);
            MoverTareaEnProceso.Size = new Size(175, 95);
            MoverTareaEnProceso.TabIndex = 66;
            MoverTareaEnProceso.TabStop = false;
            MoverTareaEnProceso.Text = "Mover tarea";
            MoverTareaEnProceso.Visible = false;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            button3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(19, 28);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(56, 53);
            button3.TabIndex = 66;
            button3.Text = "<---";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(97, 28);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(56, 53);
            button1.TabIndex = 65;
            button1.Text = "--->";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(75, 312);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.BackgroundImage = Properties.Resources.verde_oscuro;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label7);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(1286, 920);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(108, 95);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mover tarea";
            groupBox1.Visible = false;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            button4.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.HighlightText;
            button4.Location = new Point(19, 28);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(56, 53);
            button4.TabIndex = 65;
            button4.Text = "<---";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(75, 312);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 22;
            // 
            // FrmKanban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Presentación_diapositivas_cosmética_natural_negocio_elegante_minimalista_beige;
            ClientSize = new Size(1602, 1004);
            Controls.Add(groupBox1);
            Controls.Add(MoverTareaEnProceso);
            Controls.Add(MoverTareaPendiente);
            Controls.Add(pnlAgregarTarea);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnEditarTarea);
            Controls.Add(agregarTareaBTN);
            Controls.Add(BtnSalir);
            Controls.Add(label4);
            Controls.Add(btnHorario);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BtnNotas);
            Controls.Add(BtnKanban);
            Controls.Add(pictureBoxLogo);
            Name = "FrmKanban";
            Text = "FrmKanban";
            Load += FrmKanban_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVtareasCompletado).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVtareasEnProceso).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVtareasPendientes).EndInit();
            pnlAgregarTarea.ResumeLayout(false);
            pnlAgregarTarea.PerformLayout();
            MoverTareaPendiente.ResumeLayout(false);
            MoverTareaPendiente.PerformLayout();
            MoverTareaEnProceso.ResumeLayout(false);
            MoverTareaEnProceso.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNotas;
        private Button BtnKanban;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView DGVtareasPendientes;
        private Label label4;
        private Button btnHorario;
        private Button BtnSalir;
        private DataGridView DGVtareasCompletado;
        private DataGridView DGVtareasEnProceso;
        private Button btnEliminarTarea;
        private Button btnEditarTarea;
        private Button agregarTareaBTN;
        private GroupBox pnlAgregarTarea;
        private DateTimePicker DTPtarea;
        private RichTextBox txtDescripcionTarea;
        private Label label14;
        private Label label13;
        private Label label17;
        private Button btnGuardarTarea;
        private Button btnCancelarCuenta;
        private GroupBox MoverTareaPendiente;
        private Button button2;
        private Label label5;
        private GroupBox MoverTareaEnProceso;
        private Button button3;
        private Button button1;
        private Label label6;
        private GroupBox groupBox1;
        private Button button4;
        private Label label7;
    }
}