using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    partial class HorarioPrincipal
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
            tableLayoutPanel1 = new TableLayoutPanel();
            DGVmateriasDomingo = new DataGridView();
            DGVmateriasSabado = new DataGridView();
            DGVmateriasViernes = new DataGridView();
            DGVmateriasJueves = new DataGridView();
            DGVmateriasMiercoles = new DataGridView();
            DGVmateriasMartes = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelLunes = new Label();
            DGVmateriasLunes = new DataGridView();
            agregarMateriaBTN = new Button();
            Pnl_Cliente = new GroupBox();
            Btn_Retornar2 = new Button();
            Txt_Buscar2 = new TextBox();
            label11 = new Label();
            Btn_Buscar2 = new Button();
            DgvCliente = new DataGridView();
            pnlMateria = new GroupBox();
            cancelarMateriaBTN = new Button();
            button3 = new Button();
            btnEliminarMateria = new Button();
            btnEditarMateria = new Button();
            DGVgestionMateria = new DataGridView();
            pictureBoxLogo = new PictureBox();
            pnlGestionarMateria = new GroupBox();
            CBprioridad = new ComboBox();
            label12 = new Label();
            CBdiaSemana = new ComboBox();
            label10 = new Label();
            CBhoraFinal = new ComboBox();
            CBhoraInicio = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtNombreMateria = new TextBox();
            btnGuardarGestionMateria = new Button();
            btnCancelarGestionMateria = new Button();
            DGVgestionarMateria = new DataGridView();
            BtnKanban = new Button();
            BtnNotas = new Button();
            pictureBox1 = new PictureBox();
            btnEditarUsuario = new Button();
            pnlEditarCuenta = new GroupBox();
            label14 = new Label();
            txtContrasenaCuenta = new TextBox();
            label13 = new Label();
            txtCorreoCuenta = new TextBox();
            label17 = new Label();
            txtNombreCuenta = new TextBox();
            btnEditarCuenta = new Button();
            btnCancelarCuenta = new Button();
            BtnSalir = new Button();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label16 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasDomingo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasSabado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasViernes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasJueves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasMiercoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasMartes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasLunes).BeginInit();
            Pnl_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCliente).BeginInit();
            pnlMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVgestionMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            pnlGestionarMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVgestionarMateria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlEditarCuenta.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(DGVmateriasDomingo, 6, 1);
            tableLayoutPanel1.Controls.Add(DGVmateriasSabado, 5, 1);
            tableLayoutPanel1.Controls.Add(DGVmateriasViernes, 4, 1);
            tableLayoutPanel1.Controls.Add(DGVmateriasJueves, 3, 1);
            tableLayoutPanel1.Controls.Add(DGVmateriasMiercoles, 2, 1);
            tableLayoutPanel1.Controls.Add(DGVmateriasMartes, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 6, 0);
            tableLayoutPanel1.Controls.Add(label5, 5, 0);
            tableLayoutPanel1.Controls.Add(label4, 4, 0);
            tableLayoutPanel1.Controls.Add(label3, 3, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(labelLunes, 0, 0);
            tableLayoutPanel1.Controls.Add(DGVmateriasLunes, 0, 1);
            tableLayoutPanel1.Location = new Point(330, 136);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.76378F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.23622F));
            tableLayoutPanel1.Size = new Size(1041, 562);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // DGVmateriasDomingo
            // 
            DGVmateriasDomingo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasDomingo.Location = new Point(893, 61);
            DGVmateriasDomingo.Name = "DGVmateriasDomingo";
            DGVmateriasDomingo.RowHeadersWidth = 51;
            DGVmateriasDomingo.Size = new Size(136, 496);
            DGVmateriasDomingo.TabIndex = 13;
            DGVmateriasDomingo.CellClick += DGVmateriasDomingo_CellClick;
            // 
            // DGVmateriasSabado
            // 
            DGVmateriasSabado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasSabado.Location = new Point(745, 61);
            DGVmateriasSabado.Name = "DGVmateriasSabado";
            DGVmateriasSabado.RowHeadersWidth = 51;
            DGVmateriasSabado.Size = new Size(136, 496);
            DGVmateriasSabado.TabIndex = 12;
            DGVmateriasSabado.CellClick += DGVmateriasSabado_CellClick;
            // 
            // DGVmateriasViernes
            // 
            DGVmateriasViernes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasViernes.Location = new Point(597, 61);
            DGVmateriasViernes.Name = "DGVmateriasViernes";
            DGVmateriasViernes.RowHeadersWidth = 51;
            DGVmateriasViernes.Size = new Size(136, 496);
            DGVmateriasViernes.TabIndex = 11;
            DGVmateriasViernes.CellClick += DGVmateriasViernes_CellClick;
            // 
            // DGVmateriasJueves
            // 
            DGVmateriasJueves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasJueves.Location = new Point(449, 61);
            DGVmateriasJueves.Name = "DGVmateriasJueves";
            DGVmateriasJueves.RowHeadersWidth = 51;
            DGVmateriasJueves.Size = new Size(136, 496);
            DGVmateriasJueves.TabIndex = 10;
            DGVmateriasJueves.CellClick += DGVmateriasJueves_CellClick;
            // 
            // DGVmateriasMiercoles
            // 
            DGVmateriasMiercoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasMiercoles.Location = new Point(301, 61);
            DGVmateriasMiercoles.Name = "DGVmateriasMiercoles";
            DGVmateriasMiercoles.RowHeadersWidth = 51;
            DGVmateriasMiercoles.Size = new Size(136, 496);
            DGVmateriasMiercoles.TabIndex = 9;
            DGVmateriasMiercoles.CellClick += DGVmateriasMiercoles_CellClick;
            // 
            // DGVmateriasMartes
            // 
            DGVmateriasMartes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasMartes.Location = new Point(153, 61);
            DGVmateriasMartes.Name = "DGVmateriasMartes";
            DGVmateriasMartes.RowHeadersWidth = 51;
            DGVmateriasMartes.Size = new Size(136, 496);
            DGVmateriasMartes.TabIndex = 8;
            DGVmateriasMartes.CellClick += DGVmateriasMartes_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonShadow;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(890, 2);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(149, 54);
            label6.TabIndex = 6;
            label6.Text = "Domingo";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonShadow;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(742, 2);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(146, 54);
            label5.TabIndex = 5;
            label5.Text = "Sabado";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(594, 2);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(146, 54);
            label4.TabIndex = 4;
            label4.Text = "Viernes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(446, 2);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(146, 54);
            label3.TabIndex = 3;
            label3.Text = "Jueves";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(298, 2);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(146, 54);
            label2.TabIndex = 2;
            label2.Text = "Miercoles";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(150, 2);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(146, 54);
            label1.TabIndex = 1;
            label1.Text = "Martes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLunes
            // 
            labelLunes.AutoSize = true;
            labelLunes.BackColor = Color.DarkGray;
            labelLunes.Dock = DockStyle.Fill;
            labelLunes.Location = new Point(2, 2);
            labelLunes.Margin = new Padding(0);
            labelLunes.Name = "labelLunes";
            labelLunes.Size = new Size(146, 54);
            labelLunes.TabIndex = 0;
            labelLunes.Text = "Lunes";
            labelLunes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGVmateriasLunes
            // 
            DGVmateriasLunes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasLunes.Location = new Point(5, 61);
            DGVmateriasLunes.Name = "DGVmateriasLunes";
            DGVmateriasLunes.RowHeadersWidth = 51;
            DGVmateriasLunes.Size = new Size(140, 496);
            DGVmateriasLunes.TabIndex = 7;
            DGVmateriasLunes.CellClick += DGVmateriasLunes_CellClick;
            // 
            // agregarMateriaBTN
            // 
            agregarMateriaBTN.BackgroundImage = GUII.Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            agregarMateriaBTN.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarMateriaBTN.ForeColor = SystemColors.HighlightText;
            agregarMateriaBTN.Location = new Point(330, 704);
            agregarMateriaBTN.Name = "agregarMateriaBTN";
            agregarMateriaBTN.Size = new Size(128, 40);
            agregarMateriaBTN.TabIndex = 2;
            agregarMateriaBTN.Text = "Agregar Materia";
            agregarMateriaBTN.UseVisualStyleBackColor = true;
            agregarMateriaBTN.Click += agregarMateriaBTN_Click;
            // 
            // Pnl_Cliente
            // 
            Pnl_Cliente.BackColor = Color.AliceBlue;
            Pnl_Cliente.Controls.Add(Btn_Retornar2);
            Pnl_Cliente.Controls.Add(Txt_Buscar2);
            Pnl_Cliente.Controls.Add(label11);
            Pnl_Cliente.Controls.Add(Btn_Buscar2);
            Pnl_Cliente.Controls.Add(DgvCliente);
            Pnl_Cliente.ForeColor = SystemColors.ButtonFace;
            Pnl_Cliente.Location = new Point(25, 865);
            Pnl_Cliente.Name = "Pnl_Cliente";
            Pnl_Cliente.Size = new Size(357, 184);
            Pnl_Cliente.TabIndex = 35;
            Pnl_Cliente.TabStop = false;
            Pnl_Cliente.Text = "Listado de Materias";
            Pnl_Cliente.Visible = false;
            // 
            // Btn_Retornar2
            // 
            Btn_Retornar2.BackColor = Color.DodgerBlue;
            Btn_Retornar2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Retornar2.ForeColor = SystemColors.ButtonHighlight;
            Btn_Retornar2.Location = new Point(285, 22);
            Btn_Retornar2.Name = "Btn_Retornar2";
            Btn_Retornar2.Size = new Size(36, 25);
            Btn_Retornar2.TabIndex = 14;
            Btn_Retornar2.Text = "...";
            Btn_Retornar2.UseVisualStyleBackColor = false;
            // 
            // Txt_Buscar2
            // 
            Txt_Buscar2.Location = new Point(64, 22);
            Txt_Buscar2.Name = "Txt_Buscar2";
            Txt_Buscar2.Size = new Size(161, 23);
            Txt_Buscar2.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkGray;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(2, 26);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 12;
            label11.Text = "Buscar (*)";
            // 
            // Btn_Buscar2
            // 
            Btn_Buscar2.BackColor = Color.DodgerBlue;
            Btn_Buscar2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Buscar2.ForeColor = SystemColors.ButtonHighlight;
            Btn_Buscar2.Location = new Point(241, 22);
            Btn_Buscar2.Name = "Btn_Buscar2";
            Btn_Buscar2.Size = new Size(36, 25);
            Btn_Buscar2.TabIndex = 11;
            Btn_Buscar2.Text = "...";
            Btn_Buscar2.UseVisualStyleBackColor = false;
            // 
            // DgvCliente
            // 
            DgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCliente.Location = new Point(6, 53);
            DgvCliente.Name = "DgvCliente";
            DgvCliente.RowHeadersWidth = 51;
            DgvCliente.Size = new Size(340, 125);
            DgvCliente.TabIndex = 0;
            // 
            // pnlMateria
            // 
            pnlMateria.BackColor = Color.AliceBlue;
            pnlMateria.BackgroundImage = GUII.Properties.Resources.verde_claro;
            pnlMateria.Controls.Add(cancelarMateriaBTN);
            pnlMateria.Controls.Add(button3);
            pnlMateria.Controls.Add(btnEliminarMateria);
            pnlMateria.Controls.Add(btnEditarMateria);
            pnlMateria.Controls.Add(DGVgestionMateria);
            pnlMateria.ForeColor = SystemColors.Control;
            pnlMateria.Location = new Point(1186, 99);
            pnlMateria.Name = "pnlMateria";
            pnlMateria.Size = new Size(357, 218);
            pnlMateria.TabIndex = 36;
            pnlMateria.TabStop = false;
            pnlMateria.Text = "Materia";
            pnlMateria.Visible = false;
            // 
            // cancelarMateriaBTN
            // 
            cancelarMateriaBTN.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            cancelarMateriaBTN.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarMateriaBTN.ForeColor = SystemColors.HighlightText;
            cancelarMateriaBTN.Location = new Point(307, 133);
            cancelarMateriaBTN.Name = "cancelarMateriaBTN";
            cancelarMateriaBTN.Size = new Size(31, 23);
            cancelarMateriaBTN.TabIndex = 18;
            cancelarMateriaBTN.Text = "X";
            cancelarMateriaBTN.UseVisualStyleBackColor = true;
            cancelarMateriaBTN.Click += cancelarMateriaBTN_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            button3.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(5, 177);
            button3.Name = "button3";
            button3.Size = new Size(340, 35);
            button3.TabIndex = 17;
            button3.Text = "Comenzar Sesión de estudio\r\n";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            btnEliminarMateria.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarMateria.ForeColor = SystemColors.HighlightText;
            btnEliminarMateria.Location = new Point(146, 127);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(138, 35);
            btnEliminarMateria.TabIndex = 16;
            btnEliminarMateria.Text = "Eliminar Materia";
            btnEliminarMateria.UseVisualStyleBackColor = true;
            btnEliminarMateria.Click += btnEliminarMateria_Click;
            // 
            // btnEditarMateria
            // 
            btnEditarMateria.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            btnEditarMateria.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarMateria.ForeColor = SystemColors.HighlightText;
            btnEditarMateria.Location = new Point(14, 127);
            btnEditarMateria.Name = "btnEditarMateria";
            btnEditarMateria.Size = new Size(125, 35);
            btnEditarMateria.TabIndex = 15;
            btnEditarMateria.Text = "Editar Materia";
            btnEditarMateria.UseVisualStyleBackColor = true;
            btnEditarMateria.Click += btnEditarMateria_Click;
            // 
            // DGVgestionMateria
            // 
            DGVgestionMateria.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGVgestionMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVgestionMateria.GridColor = SystemColors.InactiveCaptionText;
            DGVgestionMateria.Location = new Point(5, 21);
            DGVgestionMateria.Name = "DGVgestionMateria";
            DGVgestionMateria.RowHeadersWidth = 51;
            DGVgestionMateria.Size = new Size(340, 92);
            DGVgestionMateria.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Image = GUII.Properties.Resources.Captura_de_pantalla_2026_04_22_183054;
            pictureBoxLogo.Location = new Point(24, 19);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(195, 127);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 37;
            pictureBoxLogo.TabStop = false;
            // 
            // pnlGestionarMateria
            // 
            pnlGestionarMateria.BackColor = Color.AliceBlue;
            pnlGestionarMateria.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            pnlGestionarMateria.Controls.Add(CBprioridad);
            pnlGestionarMateria.Controls.Add(label12);
            pnlGestionarMateria.Controls.Add(CBdiaSemana);
            pnlGestionarMateria.Controls.Add(label10);
            pnlGestionarMateria.Controls.Add(CBhoraFinal);
            pnlGestionarMateria.Controls.Add(CBhoraInicio);
            pnlGestionarMateria.Controls.Add(label9);
            pnlGestionarMateria.Controls.Add(label8);
            pnlGestionarMateria.Controls.Add(label7);
            pnlGestionarMateria.Controls.Add(txtNombreMateria);
            pnlGestionarMateria.Controls.Add(btnGuardarGestionMateria);
            pnlGestionarMateria.Controls.Add(btnCancelarGestionMateria);
            pnlGestionarMateria.Controls.Add(DGVgestionarMateria);
            pnlGestionarMateria.ForeColor = SystemColors.Control;
            pnlGestionarMateria.Location = new Point(722, 99);
            pnlGestionarMateria.Name = "pnlGestionarMateria";
            pnlGestionarMateria.Size = new Size(464, 308);
            pnlGestionarMateria.TabIndex = 38;
            pnlGestionarMateria.TabStop = false;
            pnlGestionarMateria.Text = "Gestionar Materia";
            pnlGestionarMateria.Visible = false;
            // 
            // CBprioridad
            // 
            CBprioridad.FormattingEnabled = true;
            CBprioridad.Items.AddRange(new object[] { "ALTA", "MEDIA", "BAJA" });
            CBprioridad.Location = new Point(273, 218);
            CBprioridad.Margin = new Padding(3, 2, 3, 2);
            CBprioridad.Name = "CBprioridad";
            CBprioridad.Size = new Size(112, 23);
            CBprioridad.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(298, 191);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 27;
            label12.Text = "Prioridad";
            // 
            // CBdiaSemana
            // 
            CBdiaSemana.FormattingEnabled = true;
            CBdiaSemana.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            CBdiaSemana.Location = new Point(66, 218);
            CBdiaSemana.Margin = new Padding(3, 2, 3, 2);
            CBdiaSemana.Name = "CBdiaSemana";
            CBdiaSemana.Size = new Size(112, 23);
            CBdiaSemana.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(66, 191);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 25;
            label10.Text = "Dia de la semana";
            // 
            // CBhoraFinal
            // 
            CBhoraFinal.FormattingEnabled = true;
            CBhoraFinal.Items.AddRange(new object[] { "1:00AM", "2:00AM", "3:00AM", "4:00AM", "5:00AM", "6:00AM", "7:00AM", "8:00AM", "9:00AM", "10:00AM", "11:00AM", "12:00AM", "1:00PM", "2:00PM", "3:00PM", "4:00PM", "5:00PM", "6:00PM", "7:00PM", "8:00PM", "9:00PM", "10:00PM", "11:00PM", "12:00PM" });
            CBhoraFinal.Location = new Point(310, 144);
            CBhoraFinal.Margin = new Padding(3, 2, 3, 2);
            CBhoraFinal.Name = "CBhoraFinal";
            CBhoraFinal.Size = new Size(112, 23);
            CBhoraFinal.TabIndex = 24;
            // 
            // CBhoraInicio
            // 
            CBhoraInicio.FormattingEnabled = true;
            CBhoraInicio.Items.AddRange(new object[] { "1:00AM", "2:00AM", "3:00AM", "4:00AM", "5:00AM", "6:00AM", "7:00AM", "8:00AM", "9:00AM", "10:00AM", "11:00AM", "12:00AM", "1:00PM", "2:00PM", "3:00PM", "4:00PM", "5:00PM", "6:00PM", "7:00PM", "8:00PM", "9:00PM", "10:00PM", "11:00PM", "12:00PM" });
            CBhoraInicio.Location = new Point(169, 144);
            CBhoraInicio.Margin = new Padding(3, 2, 3, 2);
            CBhoraInicio.Name = "CBhoraInicio";
            CBhoraInicio.Size = new Size(112, 23);
            CBhoraInicio.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(312, 128);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 22;
            label9.Text = "Hora Finalización";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(190, 128);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 20;
            label8.Text = "Hora inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(44, 128);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 18;
            label7.Text = "Nombre";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(18, 146);
            txtNombreMateria.Margin = new Padding(3, 2, 3, 2);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(110, 23);
            txtNombreMateria.TabIndex = 17;
            // 
            // btnGuardarGestionMateria
            // 
            btnGuardarGestionMateria.BackgroundImage = GUII.Properties.Resources.verde_claro;
            btnGuardarGestionMateria.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarGestionMateria.ForeColor = SystemColors.HighlightText;
            btnGuardarGestionMateria.Location = new Point(257, 254);
            btnGuardarGestionMateria.Name = "btnGuardarGestionMateria";
            btnGuardarGestionMateria.Size = new Size(90, 35);
            btnGuardarGestionMateria.TabIndex = 16;
            btnGuardarGestionMateria.Text = "Guardar";
            btnGuardarGestionMateria.UseVisualStyleBackColor = true;
            btnGuardarGestionMateria.Click += btnGuardarGestionMateria_Click;
            // 
            // btnCancelarGestionMateria
            // 
            btnCancelarGestionMateria.BackgroundImage = GUII.Properties.Resources.verde_claro;
            btnCancelarGestionMateria.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarGestionMateria.ForeColor = SystemColors.HighlightText;
            btnCancelarGestionMateria.Location = new Point(102, 254);
            btnCancelarGestionMateria.Name = "btnCancelarGestionMateria";
            btnCancelarGestionMateria.Size = new Size(90, 35);
            btnCancelarGestionMateria.TabIndex = 15;
            btnCancelarGestionMateria.Text = "Cancelar";
            btnCancelarGestionMateria.UseVisualStyleBackColor = true;
            btnCancelarGestionMateria.Click += btnCancelarGestionMateria_Click;
            // 
            // DGVgestionarMateria
            // 
            DGVgestionarMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVgestionarMateria.Location = new Point(5, 21);
            DGVgestionarMateria.Name = "DGVgestionarMateria";
            DGVgestionarMateria.RowHeadersWidth = 51;
            DGVgestionarMateria.Size = new Size(452, 93);
            DGVgestionarMateria.TabIndex = 0;
            // 
            // BtnKanban
            // 
            BtnKanban.BackgroundImage = GUII.Properties.Resources.sd;
            BtnKanban.BackgroundImageLayout = ImageLayout.Stretch;
            BtnKanban.FlatAppearance.BorderSize = 0;
            BtnKanban.FlatStyle = FlatStyle.Flat;
            BtnKanban.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKanban.ForeColor = SystemColors.HighlightText;
            BtnKanban.Location = new Point(10, 162);
            BtnKanban.Name = "BtnKanban";
            BtnKanban.Size = new Size(245, 75);
            BtnKanban.TabIndex = 39;
            BtnKanban.UseVisualStyleBackColor = true;
            BtnKanban.Click += BtnKanban_Click;
            // 
            // BtnNotas
            // 
            BtnNotas.BackgroundImage = GUII.Properties.Resources.Captura_de_pantalla_2026_04_23_215949;
            BtnNotas.BackgroundImageLayout = ImageLayout.Stretch;
            BtnNotas.FlatAppearance.BorderSize = 0;
            BtnNotas.FlatStyle = FlatStyle.Flat;
            BtnNotas.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNotas.ForeColor = SystemColors.HighlightText;
            BtnNotas.Location = new Point(10, 266);
            BtnNotas.Name = "BtnNotas";
            BtnNotas.Size = new Size(245, 90);
            BtnNotas.TabIndex = 40;
            BtnNotas.UseVisualStyleBackColor = true;
            BtnNotas.Click += BtnNotas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = GUII.Properties.Resources.user;
            pictureBox1.Location = new Point(27, 674);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            btnEditarUsuario.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarUsuario.ForeColor = SystemColors.HighlightText;
            btnEditarUsuario.Location = new Point(94, 685);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(125, 35);
            btnEditarUsuario.TabIndex = 42;
            btnEditarUsuario.Text = "Editar Usuario";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // pnlEditarCuenta
            // 
            pnlEditarCuenta.BackColor = Color.AliceBlue;
            pnlEditarCuenta.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            pnlEditarCuenta.Controls.Add(label14);
            pnlEditarCuenta.Controls.Add(txtContrasenaCuenta);
            pnlEditarCuenta.Controls.Add(label13);
            pnlEditarCuenta.Controls.Add(txtCorreoCuenta);
            pnlEditarCuenta.Controls.Add(label17);
            pnlEditarCuenta.Controls.Add(txtNombreCuenta);
            pnlEditarCuenta.Controls.Add(btnEditarCuenta);
            pnlEditarCuenta.Controls.Add(btnCancelarCuenta);
            pnlEditarCuenta.ForeColor = SystemColors.Control;
            pnlEditarCuenta.Location = new Point(291, 304);
            pnlEditarCuenta.Name = "pnlEditarCuenta";
            pnlEditarCuenta.Size = new Size(238, 244);
            pnlEditarCuenta.TabIndex = 43;
            pnlEditarCuenta.TabStop = false;
            pnlEditarCuenta.Text = "Editar Cuenta";
            pnlEditarCuenta.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(77, 135);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 22;
            label14.Text = "Contraseña";
            // 
            // txtContrasenaCuenta
            // 
            txtContrasenaCuenta.Location = new Point(60, 152);
            txtContrasenaCuenta.Margin = new Padding(3, 2, 3, 2);
            txtContrasenaCuenta.Name = "txtContrasenaCuenta";
            txtContrasenaCuenta.Size = new Size(110, 23);
            txtContrasenaCuenta.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(86, 81);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 20;
            label13.Text = "Correo";
            // 
            // txtCorreoCuenta
            // 
            txtCorreoCuenta.Location = new Point(60, 98);
            txtCorreoCuenta.Margin = new Padding(3, 2, 3, 2);
            txtCorreoCuenta.Name = "txtCorreoCuenta";
            txtCorreoCuenta.Size = new Size(110, 23);
            txtCorreoCuenta.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(86, 27);
            label17.Name = "label17";
            label17.Size = new Size(51, 15);
            label17.TabIndex = 18;
            label17.Text = "Nombre";
            // 
            // txtNombreCuenta
            // 
            txtNombreCuenta.Location = new Point(60, 44);
            txtNombreCuenta.Margin = new Padding(3, 2, 3, 2);
            txtNombreCuenta.Name = "txtNombreCuenta";
            txtNombreCuenta.Size = new Size(110, 23);
            txtNombreCuenta.TabIndex = 17;
            // 
            // btnEditarCuenta
            // 
            btnEditarCuenta.BackgroundImage = GUII.Properties.Resources.verde_claro;
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
            btnCancelarCuenta.BackgroundImage = GUII.Properties.Resources.verde_claro;
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
            BtnSalir.BackgroundImage = GUII.Properties.Resources.salir;
            BtnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.HighlightText;
            BtnSalir.Location = new Point(1307, 19);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(50, 42);
            BtnSalir.TabIndex = 45;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(button1);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(582, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 250);
            groupBox2.TabIndex = 71;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recordatorio";
            groupBox2.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(75, 113);
            label15.Name = "label15";
            label15.Size = new Size(88, 24);
            label15.TabIndex = 61;
            label15.Text = "Horario";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(66, 232);
            label16.Name = "label16";
            label16.Size = new Size(0, 15);
            label16.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackgroundImage = GUII.Properties.Resources.verde_claro;
            button1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(75, 172);
            button1.Name = "button1";
            button1.Size = new Size(90, 35);
            button1.TabIndex = 16;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // HorarioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = GUII.Properties.Resources.Presentación_diapositivas_cosmética_natural_negocio_elegante_minimalista_beige;
            ClientSize = new Size(1402, 753);
            Controls.Add(groupBox2);
            Controls.Add(BtnSalir);
            Controls.Add(pnlEditarCuenta);
            Controls.Add(btnEditarUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(BtnNotas);
            Controls.Add(BtnKanban);
            Controls.Add(pnlGestionarMateria);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pnlMateria);
            Controls.Add(Pnl_Cliente);
            Controls.Add(agregarMateriaBTN);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HorarioPrincipal";
            Text = "prue";
            WindowState = FormWindowState.Minimized;
            Load += HorarioPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasDomingo).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasSabado).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasViernes).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasJueves).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasMiercoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasMartes).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVmateriasLunes).EndInit();
            Pnl_Cliente.ResumeLayout(false);
            Pnl_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCliente).EndInit();
            pnlMateria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVgestionMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            pnlGestionarMateria.ResumeLayout(false);
            pnlGestionarMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVgestionarMateria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlEditarCuenta.ResumeLayout(false);
            pnlEditarCuenta.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelLunes;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView DGVmateriasDomingo;
        private DataGridView DGVmateriasSabado;
        private DataGridView DGVmateriasViernes;
        private DataGridView DGVmateriasJueves;
        private DataGridView DGVmateriasMiercoles;
        private DataGridView DGVmateriasMartes;
        private DataGridView DGVmateriasLunes;
        private Button agregarMateriaBTN;
        private GroupBox Pnl_Cliente;
        private Button Btn_Retornar2;
        private TextBox Txt_Buscar2;
        private Label label11;
        private Button Btn_Buscar2;
        private DataGridView DgvCliente;
        private GroupBox pnlMateria;
        private Button btnEditarMateria;
        private DataGridView DGVgestionMateria;
        private Button btnEliminarMateria;
        private Button button3;
        private PictureBox pictureBoxLogo;
        private GroupBox pnlGestionarMateria;
        private Button btnCancelarGestionMateria;
        private DataGridView DGVgestionarMateria;
        private Button btnGuardarGestionMateria;
        private TextBox txtNombreMateria;
        private Label label7;
        private Button BtnKanban;
        private ComboBox CBhoraInicio;
        private Label label9;
        private Label label8;
        private ComboBox CBdiaSemana;
        private Label label10;
        private ComboBox CBhoraFinal;
        private Button cancelarMateriaBTN;
        private Button BtnNotas;
        private ComboBox CBprioridad;
        private Label label12;
        private PictureBox pictureBox1;
        private Button btnEditarUsuario;
        private GroupBox pnlEditarCuenta;
        private Label label14;
        private TextBox txtContrasenaCuenta;
        private Label label13;
        private TextBox txtCorreoCuenta;
        private Label label17;
        private TextBox txtNombreCuenta;
        private Button btnEditarCuenta;
        private Button btnCancelarCuenta;
        private Button BtnSalir;
        private GroupBox groupBox2;
        private Label label15;
        private Label label16;
        private Button button1;
    }
}