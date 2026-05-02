using BL;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUII
{
    public partial class FrmNotas : Form
    {
        #region ?? Variables Globales
        int EstadoGuarda = 0;
        int IdEstudiante;
        int IdMateria;
        string nombreMateria;
        int IdRubro;
        string nombreRubro;
        #endregion

        #region ?? Constructor
        public FrmNotas(int idEstudiante)
        {
            InitializeComponent();
            this.IdEstudiante = idEstudiante;
            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.BringToFront();
            this.Activate();
        }
        #endregion

        #region ?? Load
        private void FrmNotas_Load(object sender, EventArgs e)
        {
            ListarMaterias("", IdEstudiante);
        }
        #endregion

        #region ?? Listados

        public void ListarMaterias(string cTexto, int idEstudiante)
        {
            try
            {
                dgvMateriasNotas.DataSource = BL_Materia.ListadoMateriasGeneral(cTexto, idEstudiante);
                Formato_Materia(dgvMateriasNotas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListarRubros(string cTexto, int idEstudiante, int idMateria)
        {
            try
            {
                DGVgestionarRubros.DataSource = BL_Evaluacion.ListarRubro(cTexto, idEstudiante, idMateria);
                DGVgestionarRubros.DefaultCellStyle.ForeColor = Color.Black;
                Formato_Rubro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region ?? Formatos

        private void Formato_Materia(DataGridView DGV)
        {
            if (DGV.Columns.Count == 0) return; // Sale si el control no tiene columnas cargadas

            // --- Configuración Global de Estilos ---
            DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centra texto de cabeceras
            DGV.EnableHeadersVisualStyles = false; // Permite que los cambios de color manuales funcionen
            DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue; // Aplica fondo azul claro a cabeceras
            DGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centra texto en todas las celdas
            DGV.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Asegura centrado en las filas

            // --- Manejo de la Columna de Botón "Ver" ---
            if (!DGV.Columns.Contains("btnNotas")) // Si no existe la columna de botón, la crea
            {
                var btnCol = new DataGridViewButtonColumn // Inicializa nueva columna tipo botón
                {
                    Name = "btnNotas", // Identificador interno
                    HeaderText = "NOTAS", // Título de la columna
                    Text = "Ver", // Texto que dirá el botón
                    UseColumnTextForButtonValue = true, // Fuerza a que todos los botones digan "Ver"
                    Width = 120 // Define ancho inicial
                };
                int insertIndex = Math.Min(1, DGV.Columns.Count); // Calcula posición (índice 1 o final)
                DGV.Columns.Insert(insertIndex, btnCol); // Inserta la columna en la posición calculada
            }
            else // Si la columna ya existe, solo actualiza sus propiedades
            {
                var existing = DGV.Columns["btnNotas"] as DataGridViewButtonColumn; // Referencia la columna existente
                if (existing != null)
                {
                    existing.HeaderText = "NOTAS"; // Actualiza encabezado
                    existing.Text = "Ver"; // Actualiza texto del botón
                    existing.UseColumnTextForButtonValue = true; // Asegura texto uniforme
                    existing.Width = 120; // Asegura ancho
                    existing.Visible = true; // Se asegura que sea visible
                }
            }

            // --- Formato de la Columna de Nombre de Materia ---
            if (DGV.Columns.Contains("nombre")) // Si existe la columna técnica "nombre"
            {
                DGV.Columns["nombre"].HeaderText = "MATERIA"; // Renombra a "MATERIA"
                DGV.Columns["nombre"].Width = 100; // Define ancho fijo
            }
            else // Si no la encuentra por nombre, asume que es la primera (índice 0)
            {
                DGV.Columns[0].HeaderText = "MATERIA";
                DGV.Columns[0].Width = 100;
            }

            // --- Ocultar columnas de IDs (Información técnica no visible) ---
            string[] idColumnNames = new[] { "IdMateria", "ID_Materia", "IdEstudiante", "ID_Estudiante", "Id" };
            foreach (var idName in idColumnNames) // Itera sobre la lista de nombres posibles
            {
                if (DGV.Columns.Contains(idName)) // Si encuentra la columna en el DGV
                    DGV.Columns[idName].Visible = false; // La oculta de la vista del usuario
            }

            // --- Configuración de Ajuste de Tamaño (Layout) ---
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Desactiva ajuste automático para controlar manualmente el tamaño de cada columna

            foreach (DataGridViewColumn col in DGV.Columns) // Recorre todas las columnas una por una
            {
                if (!col.Visible) continue; // Salta el proceso si la columna está oculta

                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centra cabecera de esta col
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centra celdas de esta col

                if (col.Name == "btnNotas") // Configuración específica para el botón
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Ancho manual
                    col.Width = 380; // Define un ancho específico de 380px
                }
                else // Configuración para las demás columnas visibles
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hace que se estiren para llenar el grid
                    col.MinimumWidth = 60; // Evita que desaparezcan si se reduce la ventana
                }
            }
        }
        private void Formato_Rubro()
        {
            if (DGVgestionarRubros.Columns.Count < 4) return;

            DGVgestionarRubros.Columns[0].Width = 100;
            DGVgestionarRubros.Columns[0].HeaderText = "NOMBRE";

            DGVgestionarRubros.Columns[1].Width = 100;
            DGVgestionarRubros.Columns[1].HeaderText = "VALOR %";

            DGVgestionarRubros.Columns[2].Width = 100;
            DGVgestionarRubros.Columns[2].HeaderText = "NOTA OBTENIDA";

            DGVgestionarRubros.Columns[3].HeaderText = "ID";
            DGVgestionarRubros.Columns[3].Visible = false;
        }

        #endregion

        #region ?? Eventos DataGridView

        private void dgvMateriasNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            var fila = dgv.Rows[e.RowIndex];

            if (fila.IsNewRow)
            {
                MessageBox.Show("No hay datos en esta fila",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Seleccionar_Materia(dgv);

            ListarRubros("", IdEstudiante, IdMateria);
            NombreMateria.Text = nombreMateria;

            pnlGestionarRubro.Location = dgvMateriasNotas.Location;
            pnlGestionarRubro.Visible = true;
        }

        private void DGVgestionarRubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            var fila = dgv.Rows[e.RowIndex];

            if (fila.IsNewRow)
            {
                MessageBox.Show("No hay datos en esta fila",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Seleccionar_Rubro(dgv);
        }

        #endregion

        #region ?? Eventos Botones

        private void SalirGestionRubrosbtn_Click(object sender, EventArgs e)
        {
            this.pnlGestionarRubro.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            List<Form> formulariosAbiertos = new List<Form>();
            foreach (Form f in Application.OpenForms)
            {
                formulariosAbiertos.Add(f);
            }

            foreach (Form f in formulariosAbiertos)
            {
                f.Close();
            }
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            this.Hide();
            HorarioPrincipal frm = new HorarioPrincipal(IdEstudiante);
            frm.Show();
        }

        private void agregarMateriaBTN_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            pnlAgregarRubro.Location = label6.Location;
            pnlAgregarRubro.BringToFront();
            pnlAgregarRubro.Visible = true;
            agregarRubroBTN.Enabled = false;
        }

        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ET.ET_Evaluacion objetoEva = new ET.ET_Evaluacion
                {
                    ID = IdRubro,
                    ID_Materia = IdMateria,
                    ID_Estudiante = IdEstudiante,
                    NombreRubro = txtNombreRubro.Text,
                    ValorPorcentual = Convert.ToDecimal(txtValorPorcentual.Text),
                    CalificacionObtenida = Convert.ToDecimal(txtNotaObtenida.Text),
                };

                string rpta = BL_Evaluacion.GuardarEva(EstadoGuarda, objetoEva);

                if (rpta.Trim().ToUpper() == "OK")
                {
                    pnlAgregarRubro.Visible = false;
                    RefrescarVista();
                    agregarRubroBTN.Enabled = true;
                    MessageBox.Show("Guardado con éxito");
                }
                else
                {
                    MessageBox.Show(rpta, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEditarRubro_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;
            pnlAgregarRubro.Location = label6.Location;
            pnlAgregarRubro.BringToFront();
            pnlAgregarRubro.Visible = true;
            agregarRubroBTN.Enabled = false;

            txtNombreRubro.Text = nombreRubro;
            txtNotaObtenida.Text = DGVgestionarRubros.CurrentRow.Cells["CalificacionObtenida"].Value.ToString();
            txtValorPorcentual.Text = DGVgestionarRubros.CurrentRow.Cells["ValorPorcentual"].Value.ToString();
        }

        private void btnCancelarCuenta_Click(object sender, EventArgs e)
        {
            this.pnlAgregarRubro.Visible = false;
            agregarRubroBTN.Enabled = true;
        }

        private void btnEliminarRubro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar materia?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BL_Evaluacion.EliminarEvaluacion(IdRubro);
                RefrescarVista();
            }
        }

        private void btnKanban_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKanban frm = new FrmKanban(IdEstudiante);
            frm.Show();
        }

        #endregion

        #region ?? Lógica Interna

        private void Seleccionar_Materia(DataGridView dgv)
        {
            if (dgvMateriasNotas.CurrentRow == null) return;

            var fila = dgvMateriasNotas.CurrentRow;

            IdMateria = fila.Cells["IdMateria"].Value as int? ?? 0;
            IdEstudiante = fila.Cells["IdEstudiante"].Value as int? ?? 0;
            nombreMateria = fila.Cells["nombre"].Value?.ToString() ?? "";
        }

        private void Seleccionar_Rubro(DataGridView dgv)
        {
            if (DGVgestionarRubros.CurrentRow == null) return;

            var fila = DGVgestionarRubros.CurrentRow;

            IdRubro = fila.Cells["IdRubro"].Value as int? ?? 0;
            nombreRubro = fila.Cells["NombreRubro"].Value?.ToString() ?? "";
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreRubro.Text) ||
                string.IsNullOrEmpty(txtNotaObtenida.Text) ||
                string.IsNullOrEmpty(txtValorPorcentual.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return false;
            }
            return true;
        }

        private void RefrescarVista()
        {
            ListarRubros("%", IdEstudiante, IdMateria);
            ListarMaterias("%", IdEstudiante);
            vaciarInputsAgregarRubro();
            pnlAgregarRubro.Visible = false;
        }

        private void vaciarInputsAgregarRubro()
        {
            txtNombreRubro.Text = "";
            txtNotaObtenida.Text = "";
            txtValorPorcentual.Text = "";
        }

        #endregion


    }
}