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
            tableLayoutPanel1.Location = new Point(377, 181);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.76378F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.23622F));
            tableLayoutPanel1.Size = new Size(1190, 749);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // DGVmateriasDomingo
            // 
            DGVmateriasDomingo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasDomingo.Location = new Point(1019, 80);
            DGVmateriasDomingo.Margin = new Padding(3, 4, 3, 4);
            DGVmateriasDomingo.Name = "DGVmateriasDomingo";
            DGVmateriasDomingo.RowHeadersWidth = 51;
            DGVmateriasDomingo.Size = new Size(155, 661);
            DGVmateriasDomingo.TabIndex = 13;
            DGVmateriasDomingo.CellClick += DGVmateriasDomingo_CellClick;
            // 
            // DGVmateriasSabado
            // 
            DGVmateriasSabado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasSabado.Location = new Point(850, 80);
            DGVmateriasSabado.Margin = new Padding(3, 4, 3, 4);
            DGVmateriasSabado.Name = "DGVmateriasSabado";
            DGVmateriasSabado.RowHeadersWidth = 51;
            DGVmateriasSabado.Size = new Size(155, 661);
            DGVmateriasSabado.TabIndex = 12;
            DGVmateriasSabado.CellClick += DGVmateriasSabado_CellClick;
            // 
            // DGVmateriasViernes
            // 
            DGVmateriasViernes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasViernes.Location = new Point(681, 80);
            DGVmateriasViernes.Margin = new Padding(3, 4, 3, 4);
            DGVmateriasViernes.Name = "DGVmateriasViernes";
            DGVmateriasViernes.RowHeadersWidth = 51;
            DGVmateriasViernes.Size = new Size(155, 661);
            DGVmateriasViernes.TabIndex = 11;
            DGVmateriasViernes.CellClick += DGVmateriasViernes_CellClick;
            // 
            // DGVmateriasJueves
            // 
            DGVmateriasJueves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasJueves.Location = new Point(512, 80);
            DGVmateriasJueves.Margin = new Padding(3, 4, 3, 4);
            DGVmateriasJueves.Name = "DGVmateriasJueves";
            DGVmateriasJueves.RowHeadersWidth = 51;
            DGVmateriasJueves.Size = new Size(155, 661);
            DGVmateriasJueves.TabIndex = 10;
            DGVmateriasJueves.CellClick += DGVmateriasJueves_CellClick;
            // 
            // DGVmateriasMiercoles
            // 
            DGVmateriasMiercoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasMiercoles.Location = new Point(343, 80);
            DGVmateriasMiercoles.Margin = new Padding(3, 4, 3, 4);
            DGVmateriasMiercoles.Name = "DGVmateriasMiercoles";
            DGVmateriasMiercoles.RowHeadersWidth = 51;
            DGVmateriasMiercoles.Size = new Size(155, 661);
            DGVmateriasMiercoles.TabIndex = 9;
            DGVmateriasMiercoles.CellClick += DGVmateriasMiercoles_CellClick;
            // 
            // DGVmateriasMartes
            // 
            DGVmateriasMartes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasMartes.Location = new Point(174, 80);
            DGVmateriasMartes.Margin = new Padding(3, 4, 3, 4);
            DGVmateriasMartes.Name = "DGVmateriasMartes";
            DGVmateriasMartes.RowHeadersWidth = 51;
            DGVmateriasMartes.Size = new Size(155, 661);
            DGVmateriasMartes.TabIndex = 8;
            DGVmateriasMartes.CellClick += DGVmateriasMartes_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonShadow;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(1016, 2);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(172, 72);
            label6.TabIndex = 6;
            label6.Text = "Domingo";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonShadow;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(847, 2);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(167, 72);
            label5.TabIndex = 5;
            label5.Text = "Sabado";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(678, 2);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(167, 72);
            label4.TabIndex = 4;
            label4.Text = "Viernes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(509, 2);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(167, 72);
            label3.TabIndex = 3;
            label3.Text = "Jueves";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(340, 2);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(167, 72);
            label2.TabIndex = 2;
            label2.Text = "Miercoles";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(171, 2);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(167, 72);
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
            labelLunes.Size = new Size(167, 72);
            labelLunes.TabIndex = 0;
            labelLunes.Text = "Lunes";
            labelLunes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGVmateriasLunes
            // 
            DGVmateriasLunes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriasLunes.Location = new Point(5, 80);
            DGVmateriasLunes.Margin = new Padding(3, 4, 3, 4);
            DGVmateriasLunes.Name = "DGVmateriasLunes";
            DGVmateriasLunes.RowHeadersWidth = 51;
            DGVmateriasLunes.Size = new Size(160, 661);
            DGVmateriasLunes.TabIndex = 7;
            DGVmateriasLunes.CellClick += DGVmateriasLunes_CellClick;
            // 
            // agregarMateriaBTN
            // 
            agregarMateriaBTN.BackgroundImage = GUII.Properties.Resources.Captura_de_pantalla_2026_04_22_084415;
            agregarMateriaBTN.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarMateriaBTN.ForeColor = SystemColors.HighlightText;
            agregarMateriaBTN.Location = new Point(377, 939);
            agregarMateriaBTN.Margin = new Padding(3, 4, 3, 4);
            agregarMateriaBTN.Name = "agregarMateriaBTN";
            agregarMateriaBTN.Size = new Size(146, 53);
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
            Pnl_Cliente.Location = new Point(29, 1153);
            Pnl_Cliente.Margin = new Padding(3, 4, 3, 4);
            Pnl_Cliente.Name = "Pnl_Cliente";
            Pnl_Cliente.Padding = new Padding(3, 4, 3, 4);
            Pnl_Cliente.Size = new Size(408, 245);
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
            Btn_Retornar2.Location = new Point(326, 29);
            Btn_Retornar2.Margin = new Padding(3, 4, 3, 4);
            Btn_Retornar2.Name = "Btn_Retornar2";
            Btn_Retornar2.Size = new Size(41, 33);
            Btn_Retornar2.TabIndex = 14;
            Btn_Retornar2.Text = "...";
            Btn_Retornar2.UseVisualStyleBackColor = false;
            // 
            // Txt_Buscar2
            // 
            Txt_Buscar2.Location = new Point(73, 29);
            Txt_Buscar2.Margin = new Padding(3, 4, 3, 4);
            Txt_Buscar2.Name = "Txt_Buscar2";
            Txt_Buscar2.Size = new Size(183, 27);
            Txt_Buscar2.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkGray;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(2, 35);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 12;
            label11.Text = "Buscar (*)";
            // 
            // Btn_Buscar2
            // 
            Btn_Buscar2.BackColor = Color.DodgerBlue;
            Btn_Buscar2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Buscar2.ForeColor = SystemColors.ButtonHighlight;
            Btn_Buscar2.Location = new Point(275, 29);
            Btn_Buscar2.Margin = new Padding(3, 4, 3, 4);
            Btn_Buscar2.Name = "Btn_Buscar2";
            Btn_Buscar2.Size = new Size(41, 33);
            Btn_Buscar2.TabIndex = 11;
            Btn_Buscar2.Text = "...";
            Btn_Buscar2.UseVisualStyleBackColor = false;
            // 
            // DgvCliente
            // 
            DgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCliente.Location = new Point(7, 71);
            DgvCliente.Margin = new Padding(3, 4, 3, 4);
            DgvCliente.Name = "DgvCliente";
            DgvCliente.RowHeadersWidth = 51;
            DgvCliente.Size = new Size(389, 167);
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
            pnlMateria.Location = new Point(1355, 132);
            pnlMateria.Margin = new Padding(3, 4, 3, 4);
            pnlMateria.Name = "pnlMateria";
            pnlMateria.Padding = new Padding(3, 4, 3, 4);
            pnlMateria.Size = new Size(408, 291);
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
            cancelarMateriaBTN.Location = new Point(351, 177);
            cancelarMateriaBTN.Margin = new Padding(3, 4, 3, 4);
            cancelarMateriaBTN.Name = "cancelarMateriaBTN";
            cancelarMateriaBTN.Size = new Size(35, 31);
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
            button3.Location = new Point(6, 236);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(389, 47);
            button3.TabIndex = 17;
            button3.Text = "Comenzar Sesión de estudio\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            btnEliminarMateria.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarMateria.ForeColor = SystemColors.HighlightText;
            btnEliminarMateria.Location = new Point(167, 169);
            btnEliminarMateria.Margin = new Padding(3, 4, 3, 4);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(158, 47);
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
            btnEditarMateria.Location = new Point(16, 169);
            btnEditarMateria.Margin = new Padding(3, 4, 3, 4);
            btnEditarMateria.Name = "btnEditarMateria";
            btnEditarMateria.Size = new Size(143, 47);
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
            DGVgestionMateria.Location = new Point(6, 28);
            DGVgestionMateria.Margin = new Padding(3, 4, 3, 4);
            DGVgestionMateria.Name = "DGVgestionMateria";
            DGVgestionMateria.RowHeadersWidth = 51;
            DGVgestionMateria.Size = new Size(389, 122);
            DGVgestionMateria.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Image = GUII.Properties.Resources.Captura_de_pantalla_2026_04_22_183054;
            pictureBoxLogo.Location = new Point(28, 25);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(223, 169);
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
            pnlGestionarMateria.Location = new Point(825, 132);
            pnlGestionarMateria.Margin = new Padding(3, 4, 3, 4);
            pnlGestionarMateria.Name = "pnlGestionarMateria";
            pnlGestionarMateria.Padding = new Padding(3, 4, 3, 4);
            pnlGestionarMateria.Size = new Size(530, 411);
            pnlGestionarMateria.TabIndex = 38;
            pnlGestionarMateria.TabStop = false;
            pnlGestionarMateria.Text = "Gestionar Materia";
            pnlGestionarMateria.Visible = false;
            // 
            // CBprioridad
            // 
            CBprioridad.FormattingEnabled = true;
            CBprioridad.Items.AddRange(new object[] { "ALTA", "MEDIA", "BAJA" });
            CBprioridad.Location = new Point(312, 290);
            CBprioridad.Name = "CBprioridad";
            CBprioridad.Size = new Size(127, 28);
            CBprioridad.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(341, 255);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 27;
            label12.Text = "Prioridad";
            // 
            // CBdiaSemana
            // 
            CBdiaSemana.FormattingEnabled = true;
            CBdiaSemana.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            CBdiaSemana.Location = new Point(76, 290);
            CBdiaSemana.Name = "CBdiaSemana";
            CBdiaSemana.Size = new Size(127, 28);
            CBdiaSemana.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(76, 255);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 25;
            label10.Text = "Dia de la semana";
            // 
            // CBhoraFinal
            // 
            CBhoraFinal.FormattingEnabled = true;
            CBhoraFinal.Items.AddRange(new object[] { "1:00AM", "2:00AM", "3:00AM", "4:00AM", "5:00AM", "6:00AM", "7:00AM", "8:00AM", "9:00AM", "10:00AM", "11:00AM", "12:00AM", "1:00PM", "2:00PM", "3:00PM", "4:00PM", "5:00PM", "6:00PM", "7:00PM", "8:00PM", "9:00PM", "10:00PM", "11:00PM", "12:00PM" });
            CBhoraFinal.Location = new Point(354, 192);
            CBhoraFinal.Name = "CBhoraFinal";
            CBhoraFinal.Size = new Size(127, 28);
            CBhoraFinal.TabIndex = 24;
            // 
            // CBhoraInicio
            // 
            CBhoraInicio.FormattingEnabled = true;
            CBhoraInicio.Items.AddRange(new object[] { "1:00AM", "2:00AM", "3:00AM", "4:00AM", "5:00AM", "6:00AM", "7:00AM", "8:00AM", "9:00AM", "10:00AM", "11:00AM", "12:00AM", "1:00PM", "2:00PM", "3:00PM", "4:00PM", "5:00PM", "6:00PM", "7:00PM", "8:00PM", "9:00PM", "10:00PM", "11:00PM", "12:00PM" });
            CBhoraInicio.Location = new Point(193, 192);
            CBhoraInicio.Name = "CBhoraInicio";
            CBhoraInicio.Size = new Size(127, 28);
            CBhoraInicio.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(357, 171);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 22;
            label9.Text = "Hora Finalización";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(217, 171);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 20;
            label8.Text = "Hora inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(50, 171);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 18;
            label7.Text = "Nombre";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(21, 194);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(125, 27);
            txtNombreMateria.TabIndex = 17;
            // 
            // btnGuardarGestionMateria
            // 
            btnGuardarGestionMateria.BackgroundImage = GUII.Properties.Resources.verde_claro;
            btnGuardarGestionMateria.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarGestionMateria.ForeColor = SystemColors.HighlightText;
            btnGuardarGestionMateria.Location = new Point(294, 339);
            btnGuardarGestionMateria.Margin = new Padding(3, 4, 3, 4);
            btnGuardarGestionMateria.Name = "btnGuardarGestionMateria";
            btnGuardarGestionMateria.Size = new Size(103, 47);
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
            btnCancelarGestionMateria.Location = new Point(117, 339);
            btnCancelarGestionMateria.Margin = new Padding(3, 4, 3, 4);
            btnCancelarGestionMateria.Name = "btnCancelarGestionMateria";
            btnCancelarGestionMateria.Size = new Size(103, 47);
            btnCancelarGestionMateria.TabIndex = 15;
            btnCancelarGestionMateria.Text = "Cancelar";
            btnCancelarGestionMateria.UseVisualStyleBackColor = true;
            btnCancelarGestionMateria.Click += btnCancelarGestionMateria_Click;
            // 
            // DGVgestionarMateria
            // 
            DGVgestionarMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVgestionarMateria.Location = new Point(6, 28);
            DGVgestionarMateria.Margin = new Padding(3, 4, 3, 4);
            DGVgestionarMateria.Name = "DGVgestionarMateria";
            DGVgestionarMateria.RowHeadersWidth = 51;
            DGVgestionarMateria.Size = new Size(517, 124);
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
            BtnKanban.Location = new Point(11, 216);
            BtnKanban.Margin = new Padding(3, 4, 3, 4);
            BtnKanban.Name = "BtnKanban";
            BtnKanban.Size = new Size(280, 100);
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
            BtnNotas.Location = new Point(11, 355);
            BtnNotas.Margin = new Padding(3, 4, 3, 4);
            BtnNotas.Name = "BtnNotas";
            BtnNotas.Size = new Size(280, 120);
            BtnNotas.TabIndex = 40;
            BtnNotas.UseVisualStyleBackColor = true;
            BtnNotas.Click += BtnNotas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = GUII.Properties.Resources.user;
            pictureBox1.Location = new Point(31, 898);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackgroundImage = GUII.Properties.Resources.verde_oscuro;
            btnEditarUsuario.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarUsuario.ForeColor = SystemColors.HighlightText;
            btnEditarUsuario.Location = new Point(108, 913);
            btnEditarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(143, 47);
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
            pnlEditarCuenta.Location = new Point(333, 405);
            pnlEditarCuenta.Margin = new Padding(3, 4, 3, 4);
            pnlEditarCuenta.Name = "pnlEditarCuenta";
            pnlEditarCuenta.Padding = new Padding(3, 4, 3, 4);
            pnlEditarCuenta.Size = new Size(272, 325);
            pnlEditarCuenta.TabIndex = 43;
            pnlEditarCuenta.TabStop = false;
            pnlEditarCuenta.Text = "Editar Cuenta";
            pnlEditarCuenta.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(88, 180);
            label14.Name = "label14";
            label14.Size = new Size(83, 20);
            label14.TabIndex = 22;
            label14.Text = "Contraseña";
            // 
            // txtContrasenaCuenta
            // 
            txtContrasenaCuenta.Location = new Point(68, 202);
            txtContrasenaCuenta.Name = "txtContrasenaCuenta";
            txtContrasenaCuenta.Size = new Size(125, 27);
            txtContrasenaCuenta.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(98, 108);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 20;
            label13.Text = "Correo";
            // 
            // txtCorreoCuenta
            // 
            txtCorreoCuenta.Location = new Point(69, 130);
            txtCorreoCuenta.Name = "txtCorreoCuenta";
            txtCorreoCuenta.Size = new Size(125, 27);
            txtCorreoCuenta.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(98, 36);
            label17.Name = "label17";
            label17.Size = new Size(64, 20);
            label17.TabIndex = 18;
            label17.Text = "Nombre";
            // 
            // txtNombreCuenta
            // 
            txtNombreCuenta.Location = new Point(69, 58);
            txtNombreCuenta.Name = "txtNombreCuenta";
            txtNombreCuenta.Size = new Size(125, 27);
            txtNombreCuenta.TabIndex = 17;
            // 
            // btnEditarCuenta
            // 
            btnEditarCuenta.BackgroundImage = GUII.Properties.Resources.verde_claro;
            btnEditarCuenta.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCuenta.ForeColor = SystemColors.HighlightText;
            btnEditarCuenta.Location = new Point(144, 253);
            btnEditarCuenta.Margin = new Padding(3, 4, 3, 4);
            btnEditarCuenta.Name = "btnEditarCuenta";
            btnEditarCuenta.Size = new Size(103, 47);
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
            btnCancelarCuenta.Location = new Point(15, 253);
            btnCancelarCuenta.Margin = new Padding(3, 4, 3, 4);
            btnCancelarCuenta.Name = "btnCancelarCuenta";
            btnCancelarCuenta.Size = new Size(103, 47);
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
            BtnSalir.Location = new Point(1494, 25);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(57, 56);
            BtnSalir.TabIndex = 45;
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // HorarioPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = GUII.Properties.Resources.Presentación_diapositivas_cosmética_natural_negocio_elegante_minimalista_beige;
            ClientSize = new Size(1602, 1004);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}