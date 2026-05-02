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
    public partial class FrmKanban : Form
    {
        #region 🔹 Variables
        int EstadoGuarda = 0;
        int IdEstudiante = 0;
        int IdTarea = 0;
        string DescripcionTarea = "";
        DateTime FechaEntrega = DateTime.Now;
        string avance = "";
        #endregion

        #region 🔹 Constructor
        public FrmKanban(int IdEstudiante)
        {
            InitializeComponent();
            this.IdEstudiante = IdEstudiante;
        }
        #endregion

        #region 🔹 Load
        private void FrmKanban_Load(object sender, EventArgs e)
        {
            listarKanban("%", IdEstudiante);
            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.BringToFront();
            this.Activate();
        }
        #endregion

        #region 🔹 Navegación
        private void btnHorario_Click(object sender, EventArgs e)
        {
            this.Hide();
            HorarioPrincipal frm = new HorarioPrincipal(IdEstudiante);
            frm.Show();
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNotas frm = new FrmNotas(IdEstudiante);
            frm.Show();
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
        #endregion

        #region 🔹 Formato
        private void Formato_Tarea(DataGridView DGV)
        {
            if (DGV.Columns.Count == 0) return;

            DGV.Columns[0].Width = 250;
            DGV.Columns[0].HeaderText = "Descripcion";

            DGV.Columns[1].Width = 100;
            DGV.Columns[1].HeaderText = "Fecha de entrega";

            DGV.Columns["avance"].Visible = false;
            DGV.Columns["ID"].Visible = false;
        }
        #endregion

        #region 🔹 Listados
        public void listarKanban(string cTexto, int IdEstudiante)
        {
            try
            {
                DGVtareasPendientes.DataSource = BL_Kanban.ListadoTareasPendientes(cTexto, IdEstudiante);
                Formato_Tarea(DGVtareasPendientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DGVtareasEnProceso.DataSource = BL_Kanban.ListadoTareasEnProceso(cTexto, IdEstudiante);
                Formato_Tarea(DGVtareasEnProceso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DGVtareasCompletado.DataSource = BL_Kanban.ListadoTareasCompletadas(cTexto, IdEstudiante);
                Formato_Tarea(DGVtareasCompletado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 🔹 Selección
        private void Seleccionar_Tarea(DataGridView dgv)
        {
            if (dgv.CurrentRow == null) return;

            var fila = dgv.CurrentRow;

            IdTarea = fila.Cells["ID"].Value as int? ?? 0;
            DescripcionTarea = fila.Cells["descripcion"].Value.ToString() ?? "";
            FechaEntrega = fila.Cells["fechaEntrega"].Value as DateTime? ?? DateTime.Now;
            avance = fila.Cells["avance"].Value.ToString() ?? "";
        }
        #endregion

        #region 🔹 CRUD
        private void agregarTareaBTN_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            this.agregarTareaBTN.Enabled = false;
            pnlAgregarTarea.Location = DGVtareasEnProceso.Location;
            pnlAgregarTarea.Visible = true;
        }

        private void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            if (txtDescripcionTarea.Text == "")
            {
                MessageBox.Show("Ingrese una descripcion para la tarea");
                return;
            }
            else
            {
                string rpta = BL_Kanban.GuardarTarea(EstadoGuarda, new ET.ET_Kanban
                {
                    ID = IdTarea,
                    ID_Estudiante = IdEstudiante,
                    Descripcion = txtDescripcionTarea.Text,
                    FechaEntrega = DTPtarea.Value,
                    Dificultad = avance
                });

                MessageBox.Show(rpta);

                pnlAgregarTarea.Visible = false;
                listarKanban("%", IdEstudiante);
                agregarTareaBTN.Enabled = true;
            }
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;
            pnlAgregarTarea.Location = DGVtareasEnProceso.Location;
            pnlAgregarTarea.Visible = true;
            agregarTareaBTN.Enabled = false;

            txtDescripcionTarea.Text = DescripcionTarea;
            DTPtarea.Value = FechaEntrega;
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar tarea?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BL_Kanban.EliminarTarea(IdTarea);
                listarKanban("%", IdEstudiante);
            }
        }
        #endregion

        #region 🔹 Eventos DGV
        private void DGVtareasPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar_Tarea(DGVtareasPendientes);
            MoverTareaPendiente.Location = MoverTareaEnProceso.Location;
            MoverTareaPendiente.Visible = true;
        }

        private void DGVtareasEnProceso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar_Tarea(DGVtareasEnProceso);
        }

        private void DGVtareasCompletado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar_Tarea(DGVtareasCompletado);
        }
        #endregion

        #region 🔹 Otros
        private void btnCancelarCuenta_Click(object sender, EventArgs e)
        {
            pnlAgregarTarea.Visible = false;
            this.agregarTareaBTN.Enabled = true;
        }
        #endregion

        private void SalirGestionRubrosbtn_Click(object sender, EventArgs e)
        {
            MoverTareaPendiente.Visible = false;
        }
    }
}