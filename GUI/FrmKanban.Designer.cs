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
            SalirGestionRubrosbtn = new Button();
            Btn_mover_a_progreso1 = new Button();
            label5 = new Label();
            MoverTareaEnProceso = new GroupBox();
            button1 = new Button();
            Btn_mover_a_pendiente = new Button();
            Btn_mover_a_completado = new Button();
            label6 = new Label();
            MoverTareaCompletado = new GroupBox();
            button2 = new Button();
            Btn_mover_a_proceso2 = new Button();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVtareasCompletado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVtareasEnProceso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVtareasPendientes).BeginInit();
            pnlAgregarTarea.SuspendLayout();
            MoverTareaPendiente.SuspendLayout();
            MoverTareaEnProceso.SuspendLayout();
            MoverTareaCompletado.SuspendLayout();
            groupBox2.SuspendLayout();
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
            pictureBoxLogo.Location = new Point(33, 27);
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
            tableLayoutPanel1.Location = new Point(377, 180);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1267, 693);
            tableLayoutPanel1.TabIndex = 44;
            // 
            // DGVtareasCompletado
            // 
            DGVtareasCompletado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVtareasCompletado.Dock = DockStyle.Fill;
            DGVtareasCompletado.Location = new Point(847, 118);
            DGVtareasCompletado.Name = "DGVtareasCompletado";
            DGVtareasCompletado.RowHeadersWidth = 51;
            DGVtareasCompletado.Size = new Size(417, 572);
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
            DGVtareasEnProceso.Size = new Size(416, 572);
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
            DGVtareasPendientes.Size = new Size(416, 572);
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
            btnHorario.Location = new Point(323, 27);
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
            BtnSalir.Location = new Point(1427, 27);
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
            btnEliminarTarea.Location = new Point(630, 845);
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
            btnEditarTarea.Location = new Point(478, 845);
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
            agregarTareaBTN.Location = new Point(326, 845);
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
            pnlAgregarTarea.Location = new Point(309, 485);
            pnlAgregarTarea.Margin = new Padding(3, 4, 3, 4);
            pnlAgregarTarea.Name = "pnlAgregarTarea";
            pnlAgregarTarea.Padding = new Padding(3, 4, 3, 4);
            pnlAgregarTarea.Size = new Size(272, 333);
            pnlAgregarTarea.TabIndex = 64;
            pnlAgregarTarea.TabStop = false;
            pnlAgregarTarea.Text = "Tarea";
            pnlAgregarTarea.Visible = false;
            // 
            // DTPtarea
            // 
            DTPtarea.Location = new Point(6, 213);
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
            label14.Location = new Point(75, 309);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(69, 191);
            label13.Name = "label13";
            label13.Size = new Size(123, 20);
            label13.TabIndex = 20;
            label13.Text = "Fecha de entrega";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(91, 24);
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
            MoverTareaPendiente.Controls.Add(SalirGestionRubrosbtn);
            MoverTareaPendiente.Controls.Add(Btn_mover_a_progreso1);
            MoverTareaPendiente.Controls.Add(label5);
            MoverTareaPendiente.ForeColor = SystemColors.Control;
            MoverTareaPendiente.Location = new Point(486, 1227);
            MoverTareaPendiente.Margin = new Padding(3, 5, 3, 5);
            MoverTareaPendiente.Name = "MoverTareaPendiente";
            MoverTareaPendiente.Padding = new Padding(3, 4, 3, 4);
            MoverTareaPendiente.Size = new Size(131, 95);
            MoverTareaPendiente.TabIndex = 65;
            MoverTareaPendiente.TabStop = false;
            MoverTareaPendiente.Text = "Mover tarea";
            MoverTareaPendiente.Visible = false;
            // 
            // SalirGestionRubrosbtn
            // 
            SalirGestionRubrosbtn.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            SalirGestionRubrosbtn.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalirGestionRubrosbtn.ForeColor = SystemColors.HighlightText;
            SalirGestionRubrosbtn.Location = new Point(82, 33);
            SalirGestionRubrosbtn.Margin = new Padding(3, 4, 3, 4);
            SalirGestionRubrosbtn.Name = "SalirGestionRubrosbtn";
            SalirGestionRubrosbtn.Size = new Size(30, 31);
            SalirGestionRubrosbtn.TabIndex = 67;
            SalirGestionRubrosbtn.Text = "X";
            SalirGestionRubrosbtn.UseVisualStyleBackColor = true;
            SalirGestionRubrosbtn.Click += SalirGestionRubrosbtn_Click;
            // 
            // Btn_mover_a_progreso1
            // 
            Btn_mover_a_progreso1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            Btn_mover_a_progreso1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_mover_a_progreso1.ForeColor = SystemColors.HighlightText;
            Btn_mover_a_progreso1.Location = new Point(19, 28);
            Btn_mover_a_progreso1.Margin = new Padding(3, 4, 3, 4);
            Btn_mover_a_progreso1.Name = "Btn_mover_a_progreso1";
            Btn_mover_a_progreso1.Size = new Size(56, 53);
            Btn_mover_a_progreso1.TabIndex = 65;
            Btn_mover_a_progreso1.Text = "--->";
            Btn_mover_a_progreso1.UseVisualStyleBackColor = true;
            Btn_mover_a_progreso1.Click += Btn_mover_a_progreso1_Click_1;
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
            MoverTareaEnProceso.Controls.Add(button1);
            MoverTareaEnProceso.Controls.Add(Btn_mover_a_pendiente);
            MoverTareaEnProceso.Controls.Add(Btn_mover_a_completado);
            MoverTareaEnProceso.Controls.Add(label6);
            MoverTareaEnProceso.ForeColor = SystemColors.Control;
            MoverTareaEnProceso.Location = new Point(992, 1169);
            MoverTareaEnProceso.Margin = new Padding(3, 5, 3, 5);
            MoverTareaEnProceso.Name = "MoverTareaEnProceso";
            MoverTareaEnProceso.Padding = new Padding(3, 5, 3, 5);
            MoverTareaEnProceso.Size = new Size(239, 127);
            MoverTareaEnProceso.TabIndex = 66;
            MoverTareaEnProceso.TabStop = false;
            MoverTareaEnProceso.Text = "Mover tarea";
            MoverTareaEnProceso.Visible = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(170, 37);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(30, 31);
            button1.TabIndex = 67;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Btn_mover_a_pendiente
            // 
            Btn_mover_a_pendiente.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            Btn_mover_a_pendiente.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_mover_a_pendiente.ForeColor = SystemColors.HighlightText;
            Btn_mover_a_pendiente.Location = new Point(19, 28);
            Btn_mover_a_pendiente.Margin = new Padding(3, 4, 3, 4);
            Btn_mover_a_pendiente.Name = "Btn_mover_a_pendiente";
            Btn_mover_a_pendiente.Size = new Size(56, 53);
            Btn_mover_a_pendiente.TabIndex = 66;
            Btn_mover_a_pendiente.Text = "<---";
            Btn_mover_a_pendiente.UseVisualStyleBackColor = true;
            Btn_mover_a_pendiente.Click += Btn_mover_a_pendiente_Click;
            // 
            // Btn_mover_a_completado
            // 
            Btn_mover_a_completado.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            Btn_mover_a_completado.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_mover_a_completado.ForeColor = SystemColors.HighlightText;
            Btn_mover_a_completado.Location = new Point(97, 28);
            Btn_mover_a_completado.Margin = new Padding(3, 4, 3, 4);
            Btn_mover_a_completado.Name = "Btn_mover_a_completado";
            Btn_mover_a_completado.Size = new Size(56, 53);
            Btn_mover_a_completado.TabIndex = 65;
            Btn_mover_a_completado.Text = "--->";
            Btn_mover_a_completado.UseVisualStyleBackColor = true;
            Btn_mover_a_completado.Click += Btn_mover_a_completado_Click_1;
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
            // MoverTareaCompletado
            // 
            MoverTareaCompletado.BackColor = Color.AliceBlue;
            MoverTareaCompletado.BackgroundImage = Properties.Resources.verde_oscuro;
            MoverTareaCompletado.Controls.Add(button2);
            MoverTareaCompletado.Controls.Add(Btn_mover_a_proceso2);
            MoverTareaCompletado.Controls.Add(label7);
            MoverTareaCompletado.ForeColor = SystemColors.Control;
            MoverTareaCompletado.Location = new Point(1387, 877);
            MoverTareaCompletado.Margin = new Padding(3, 4, 3, 4);
            MoverTareaCompletado.Name = "MoverTareaCompletado";
            MoverTareaCompletado.Padding = new Padding(3, 4, 3, 4);
            MoverTareaCompletado.Size = new Size(130, 95);
            MoverTareaCompletado.TabIndex = 67;
            MoverTareaCompletado.TabStop = false;
            MoverTareaCompletado.Text = "Mover tarea";
            MoverTareaCompletado.Visible = false;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            button2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(82, 40);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(30, 31);
            button2.TabIndex = 66;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Btn_mover_a_proceso2
            // 
            Btn_mover_a_proceso2.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            Btn_mover_a_proceso2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_mover_a_proceso2.ForeColor = SystemColors.HighlightText;
            Btn_mover_a_proceso2.Location = new Point(19, 28);
            Btn_mover_a_proceso2.Margin = new Padding(3, 4, 3, 4);
            Btn_mover_a_proceso2.Name = "Btn_mover_a_proceso2";
            Btn_mover_a_proceso2.Size = new Size(56, 53);
            Btn_mover_a_proceso2.TabIndex = 65;
            Btn_mover_a_proceso2.Text = "<---";
            Btn_mover_a_proceso2.UseVisualStyleBackColor = true;
            Btn_mover_a_proceso2.Click += Btn_mover_a_proceso2_Click;
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
            // panel1
            // 
            panel1.Location = new Point(571, 180);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(26, 31);
            panel1.TabIndex = 68;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(1001, 180);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(26, 31);
            panel2.TabIndex = 69;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(1408, 180);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(26, 31);
            panel3.TabIndex = 69;
            panel3.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.BackgroundImage = Properties.Resources.verde_oscuro;
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button3);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(827, 896);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(272, 333);
            groupBox2.TabIndex = 70;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recordatorio";
            groupBox2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(86, 151);
            label9.Name = "label9";
            label9.Size = new Size(104, 28);
            label9.TabIndex = 61;
            label9.Text = "Horario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(75, 309);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 22;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.verde_claro;
            button3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(86, 229);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(103, 47);
            button3.TabIndex = 16;
            button3.Text = "Aceptar";
            button3.UseVisualStyleBackColor = true;
            // 
            // FrmKanban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Presentación_diapositivas_cosmética_natural_negocio_elegante_minimalista_beige;
            ClientSize = new Size(1602, 1004);
            Controls.Add(groupBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(MoverTareaCompletado);
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
            MoverTareaCompletado.ResumeLayout(false);
            MoverTareaCompletado.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button Btn_mover_a_progreso1;
        private Label label5;
        private GroupBox MoverTareaEnProceso;
        private Button Btn_mover_a_pendiente;
        private Button Btn_mover_a_completado;
        private Label label6;
        private GroupBox MoverTareaCompletado;
        private Button Btn_mover_a_proceso2;
        private Label label7;
        private Button SalirGestionRubrosbtn;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private Label label8;
        private Button button3;
        private Label label9;
    }
}