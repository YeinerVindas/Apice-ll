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
            if (DGV.Columns.Count == 0) return;

            DGV.Columns[0].Width = 100;
            DGV.Columns[0].HeaderText = "MATERIA";
            DGV.Columns[1].Visible = false;
            DGV.Columns[2].Visible = false;
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
                string rpta = BL_Evaluacion.GuardarEva(EstadoGuarda, new ET.ET_Evaluacion
                {
                    ID = IdRubro,
                    ID_Materia = IdMateria,
                    ID_Estudiante = IdEstudiante,
                    NombreRubro = txtNombreRubro.Text,
                    ValorPorcentual = Convert.ToDecimal(txtValorPorcentual.Text),
                    CalificacionObtenida = Convert.ToDecimal(txtNotaObtenida.Text),
                });

                pnlAgregarRubro.Visible = false;
                RefrescarVista();
                agregarRubroBTN.Enabled = true;
                MessageBox.Show(rpta);
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