using BL;
using GUII;
using Mockup;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1;

namespace GUI
{

    /** <summary>
     * Formulario principal que muestra el horario del estudiante y permite gestionar sus materias.
     * Recibe el ID del estudiante para cargar su horario específico.
     * Permite agregar, editar y eliminar materias, así como acceder a otras funcionalidades como notas y kanban.
     */
    public partial class HorarioPrincipal : Form
    {
        #region ?? Variables Globales

        int EstadoGuarda = 0;
        string nombreMateria = "";
        int IdMateria = 0;
        int IdEstudiate_Materia = 0;

        #endregion

        #region ?? Constructor

        public HorarioPrincipal(int idEstudiante_materia)// Recibe el ID del estudiante para cargar su horario
        {
            InitializeComponent();
            this.IdEstudiate_Materia = idEstudiante_materia;// Asignar el ID del estudiante a la variable global
            listadoMateriasSemana(IdEstudiate_Materia);
        }

        #endregion

        #region ?? Load

        private void HorarioPrincipal_Load(object sender, EventArgs e)
        {
            listadoMateriasSemana(IdEstudiate_Materia);

            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.BringToFront();
            this.Activate();
        }

        #endregion

        #region ?? Listados

        public void ListadoDGV_materiasLunes(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVmateriasLunes.DataSource = BL_Materia.ListadoMateriaLunes(cTexto, IdEstudiate_Materia);
                Formato_Materia(DGVmateriasLunes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListadoDGV_materiasMartes(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVmateriasMartes.DataSource = BL_Materia.ListadoMateriaMartes(cTexto, IdEstudiate_Materia);
                Formato_Materia(DGVmateriasMartes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListadoDGV_materiasMiercoles(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVmateriasMiercoles.DataSource = BL_Materia.ListadoMateriaMiercoles(cTexto, IdEstudiate_Materia);
                Formato_Materia(DGVmateriasMiercoles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListadoDGV_materiasJueves(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVmateriasJueves.DataSource = BL_Materia.ListadoMateriaJueves(cTexto, IdEstudiate_Materia);
                Formato_Materia(DGVmateriasJueves);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListadoDGV_materiasViernes(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVmateriasViernes.DataSource = BL_Materia.ListadoMateriaViernes(cTexto, IdEstudiate_Materia);
                Formato_Materia(DGVmateriasViernes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListadoDGV_materiasSabado(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVmateriasSabado.DataSource = BL_Materia.ListadoMateriaSabado(cTexto, IdEstudiate_Materia);
                Formato_Materia(DGVmateriasSabado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListadoDGV_materiasDomingo(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVmateriasDomingo.DataSource = BL_Materia.ListadoMateriaDomingo(cTexto, IdEstudiate_Materia);
                Formato_Materia(DGVmateriasDomingo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListadoDGV_GestionarMateria(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVgestionMateria.DataSource = BL_Materia.ListadoGestionMaterias(cTexto, IdEstudiate_Materia);
                DGVgestionMateria.DefaultCellStyle.ForeColor = Color.Black;
                Formato_GestionarMateria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListadoDGV_GestionaMateriaAgregar(string cTexto, int IdEstudiate_Materia)
        {
            try
            {
                DGVgestionarMateria.DataSource = BL_Materia.ListadoGestionMaterias(cTexto, IdEstudiate_Materia);
                DGVgestionarMateria.DefaultCellStyle.ForeColor = Color.Black;
                Formato_GestionarMateria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listadoMateriasSemana(int IdEstudiate_Materia)
        {
            ListadoDGV_materiasLunes("%", IdEstudiate_Materia);
            ListadoDGV_materiasMartes("%", IdEstudiate_Materia);
            ListadoDGV_materiasMiercoles("%", IdEstudiate_Materia);
            ListadoDGV_materiasJueves("%", IdEstudiate_Materia);
            ListadoDGV_materiasViernes("%", IdEstudiate_Materia);
            ListadoDGV_materiasSabado("%", IdEstudiate_Materia);
            ListadoDGV_materiasDomingo("%", IdEstudiate_Materia);
        }

        #endregion

        #region ?? Formatos

        private void Formato_Materia(DataGridView DGV)
        {
            if (DGV.Columns.Count == 0) return;

            DGV.Columns[0].Width = 85;
            DGV.Columns[0].HeaderText = "MATERIA";
            DGV.Columns[1].Visible = false;
            DGV.Columns[2].Visible = false;
        }

        private void Formato_GestionarMateria()
        {
            if (DGVgestionMateria.Columns.Count == 0) return;

            DGVgestionMateria.Columns[0].Width = 85;
            DGVgestionMateria.Columns[0].HeaderText = "MATERIA";

            DGVgestionMateria.Columns[1].Width = 90;
            DGVgestionMateria.Columns[1].HeaderText = "PRIORIDAD";

            DGVgestionMateria.Columns[2].Width = 70;
            DGVgestionMateria.Columns[2].HeaderText = "HORA INICIO";

            DGVgestionMateria.Columns[3].Width = 70;
            DGVgestionMateria.Columns[3].HeaderText = "HORA FINAL";

            DGVgestionMateria.Columns[4].Width = 70;
            DGVgestionMateria.Columns[4].HeaderText = "DIA SEMANA";
        }

        #endregion

        #region ?? Eventos Botones

        private void cancelarMateriaBTN_Click(object sender, EventArgs e)
        {
            pnlMateria.Visible = false;
            LimpiarSeleccion();
        }

        private void agregarMateriaBTN_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            MostrarPanelGestion();
        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;
            ListadoDGV_GestionaMateriaAgregar("%", IdEstudiate_Materia);
            MostrarPanelGestion();

            txtNombreMateria.Text = nombreMateria;
            CBhoraInicio.Text = DGVgestionMateria.CurrentRow.Cells["HoraInicio"].Value?.ToString() ?? "";
            CBhoraFinal.Text = DGVgestionMateria.CurrentRow.Cells["HoraFinal"].Value?.ToString() ?? "";
            CBdiaSemana.Text = DGVgestionMateria.CurrentRow.Cells["DiaSemana"].Value?.ToString() ?? "";
            CBprioridad.Text = DGVgestionMateria.CurrentRow.Cells["Prioridad"].Value?.ToString() ?? "";
        }

        private void btnCancelarGestionMateria_Click(object sender, EventArgs e)
        {
            pnlGestionarMateria.Visible = false;
            agregarMateriaBTN.Enabled = true;
            DGVgestionarMateria.DataSource = null;
        }

        private void btnGuardarGestionMateria_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            BL_Materia.GuardarMT(EstadoGuarda, new ET.ET_Materia
            {
                ID = IdMateria,
                ID_Estudiante = IdEstudiate_Materia,
                Nombre = txtNombreMateria.Text,
                Prioridad = CBprioridad.Text,
                HoraInicio = CBhoraInicio.Text,
                HoraFinal = CBhoraFinal.Text,
                DiaSemana = CBdiaSemana.Text
            });

            pnlMateria.Visible = false;
            RefrescarVista();
            agregarMateriaBTN.Enabled = true;
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar materia?", "Confirmar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BL_Materia.EliminarMT(IdMateria);
                RefrescarVista();
                pnlMateria.Visible = false;
            }
        }

        #endregion

        #region ?? Eventos DataGridView

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            Seleccionar_Materia(dgv);
            ListadoDGV_GestionarMateria(nombreMateria, IdEstudiate_Materia);

            pnlMateria.Location = DGVmateriasDomingo.Location;
            pnlMateria.Visible = true;
        }

        private void DGVmateriasLunes_CellClick(object sender, DataGridViewCellEventArgs e) => ManejarClickDGV(sender, e);
        private void DGVmateriasMartes_CellClick(object sender, DataGridViewCellEventArgs e) => ManejarClickDGV(sender, e);
        private void DGVmateriasMiercoles_CellClick(object sender, DataGridViewCellEventArgs e) => ManejarClickDGV(sender, e);
        private void DGVmateriasJueves_CellClick(object sender, DataGridViewCellEventArgs e) => ManejarClickDGV(sender, e);
        private void DGVmateriasViernes_CellClick(object sender, DataGridViewCellEventArgs e) => ManejarClickDGV(sender, e);
        private void DGVmateriasSabado_CellClick(object sender, DataGridViewCellEventArgs e) => ManejarClickDGV(sender, e);
        private void DGVmateriasDomingo_CellClick(object sender, DataGridViewCellEventArgs e) => ManejarClickDGV(sender, e);

        private void ManejarClickDGV(object sender, DataGridViewCellEventArgs e)
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
            ListadoDGV_GestionarMateria(nombreMateria, IdEstudiate_Materia);

            pnlMateria.Location = DGVmateriasMiercoles.Location;
            pnlMateria.Visible = true;
        }

        #endregion

        #region ?? Lógica Interna

        private void Seleccionar_Materia(DataGridView dgv)
        {
            if (dgv.CurrentRow == null) return;

            var fila = dgv.CurrentRow;

            IdMateria = fila.Cells["IdMateria"].Value as int? ?? 0;// Asignar el valor de IdMateria, asegurándose de manejar posibles valores nulos
            IdEstudiate_Materia = fila.Cells["IdEstudiante"].Value as int? ?? 0;// Asignar el valor de IdEstudiate_Materia, asegurándose de manejar posibles valores nulos
            nombreMateria = fila.Cells["nombre"].Value?.ToString() ?? "";// Asignar el valor de nombreMateria, asegurándose de manejar posibles valores nulos
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreMateria.Text) ||
                string.IsNullOrEmpty(CBprioridad.Text) ||
                string.IsNullOrEmpty(CBhoraInicio.Text) ||
                string.IsNullOrEmpty(CBhoraFinal.Text) ||
                string.IsNullOrEmpty(CBdiaSemana.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return false;
            }
            return true;
        }

        #endregion

        #region ?? Helpers

        private void MostrarPanelGestion()
        {
            pnlGestionarMateria.Location = DGVmateriasMiercoles.Location;
            pnlGestionarMateria.Visible = true;
            agregarMateriaBTN.Enabled = false;
        }

        private void LimpiarSeleccion()
        {
            nombreMateria = "";
            IdMateria = 0;
            IdEstudiate_Materia = 0;
        }

        private void vaciarInputsGestionMateria()
        {
            txtNombreMateria.Clear();
            CBprioridad.Text = "";
            CBhoraInicio.Text = "";
            CBhoraFinal.Text = "";
            CBdiaSemana.Text = "";
        }

        private void RefrescarVista()
        {
            ListadoDGV_GestionaMateriaAgregar("%", IdEstudiate_Materia);
            listadoMateriasSemana(IdEstudiate_Materia);
            vaciarInputsGestionMateria();
            pnlGestionarMateria.Visible = false;
        }

        #endregion

        #region ?? Eventos Extra

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            pnlEditarCuenta.Visible = true;
            pnlEditarCuenta.Location = DGVmateriasMiercoles.Location;
        }

        private void btnCancelarCuenta_Click(object sender, EventArgs e)
        {
            this.pnlEditarCuenta.Visible = false;
        }

        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            string rpta = BL_Estudiante.GuardarES(2, new ET.ET_Estudiante
            {
                ID = IdEstudiate_Materia,
                Nombre = txtNombreCuenta.Text,
                Correo = txtCorreoCuenta.Text,
                Contrasena = txtContrasenaCuenta.Text,
                FechaConexion = DateTime.Now,
                RachaActual = 0
            });

            if (rpta == "OK")
            {
                MessageBox.Show("Actualizado exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(rpta, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNotas frm = new FrmNotas(IdEstudiate_Materia);
            frm.Show();
        }

        private void BtnKanban_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKanban frm = new FrmKanban(IdEstudiate_Materia);
            frm.Show();
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSesion frm = new FrmSesion(IdEstudiate_Materia, nombreMateria);
            frm.Show();
        }
    }
}