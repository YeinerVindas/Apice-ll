using BL;
using ET;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmKanban : Form
    {
        #region Variables Globales
        // ID del estudiante activo, recibido desde el form anterior al navegar
        private readonly int _idEstudiante;

        // ID y estado de la tarea actualmente seleccionada en cualquiera de los tres DGVs
        private int _idTareaSeleccionada = 0;
        private string _estadoTareaSeleccionada = "";

        // Controla si el panel de agregar/editar está en modo inserción o edición
        private bool _modoEdicion = false;

        // Instancia única de la BL reutilizada en todo el form
        private readonly BL_Kanban _blKanban = new BL_Kanban();
        #endregion

        #region Constructor
        // Recibe el ID del estudiante desde el form de login o navegación
        public FrmKanban(int idEstudiante)
        {
            InitializeComponent();
            _idEstudiante = idEstudiante;
        }
        #endregion

        #region Load
        private void FrmKanban_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ConfigurarDGVs();
            CargarTodosLosTableros();
            OcultarPaneles();

            // Verifica si hay tareas próximas a vencer y muestra el aviso global
            string recordatorio = RecordatorioKanban.ObtenerMensajeRecordatorio(_idEstudiante);
            if (recordatorio != null)
                MessageBox.Show(recordatorio, "Recordatorio de tareas",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Conecta el botón de cerrar del groupBox2 directamente en código
            button3.Click += (s, ev) => groupBox2.Visible = false;

            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.BringToFront();
            this.Activate();
        }

        // Oculta todos los paneles flotantes al iniciar para que el tablero
        // arranque limpio sin ningún panel visible por defecto
        private void OcultarPaneles()
        {
            pnlAgregarTarea.Visible = false;
            MoverTareaPendiente.Visible = false;
            MoverTareaEnProceso.Visible = false;
            MoverTareaCompletado.Visible = false;
            groupBox2.Visible = false;
        }
        #endregion

        #region Configurar DGVs
        // Aplica la misma configuración a los tres DGVs del tablero Kanban
        private void ConfigurarDGVs()
        {
            ConfigurarDGV(DGVtareasPendientes);
            ConfigurarDGV(DGVtareasEnProceso);
            ConfigurarDGV(DGVtareasCompletado);
        }

        // Configura columnas, estilos y comportamiento de un DGV del tablero.
        // El ID se agrega como columna oculta para poder recuperarlo al seleccionar una fila
        // sin exponerlo visualmente al usuario.
        private void ConfigurarDGV(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", DataPropertyName = "titulo", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "descripcion", Width = 150 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Entrega", DataPropertyName = "fechaEntrega", Width = 90 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Días", DataPropertyName = "diasRestantes", Width = 50 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", DataPropertyName = "ID", Visible = false });
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue;
        }
        #endregion

        #region Cargar Tableros
        // Obtiene todas las tareas del estudiante y las distribuye en los tres DGVs
        // filtrando por estado. El USP_ListarKanban ya elimina las tareas vencidas
        // antes de retornar, por lo que no se necesita filtrado adicional por fecha.
        private void CargarTodosLosTableros()
        {
            try
            {
                DataTable dt = _blKanban.ListarKanban(_idEstudiante);

                DGVtareasPendientes.DataSource = FiltrarPorEstado(dt, "No empezado");
                DGVtareasEnProceso.DataSource = FiltrarPorEstado(dt, "En proceso");
                DGVtareasCompletado.DataSource = FiltrarPorEstado(dt, "Hecho");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tareas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Crea una copia de la estructura del DataTable y copia solo las filas
        // que coinciden con el estado indicado. Se usa para separar el resultado
        // del USP en las tres columnas del tablero.
        private DataTable FiltrarPorEstado(DataTable dt, string estado)
        {
            DataTable filtrada = dt.Clone();
            foreach (DataRow row in dt.Rows)
                if (row["estado"].ToString() == estado)
                    filtrada.ImportRow(row);
            return filtrada;
        }
        #endregion

        #region Eventos DGVs
        // Al hacer clic en una tarea del DGV de Pendientes, guarda el ID y el estado,
        // y muestra el panel de mover correspondiente a esa columna.
        // Los otros dos paneles de mover se ocultan para no acumular paneles visibles.
        private void DGVtareasPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SeleccionarTarea(DGVtareasPendientes, e.RowIndex, "No empezado");
            MoverTareaEnProceso.Visible = false;
            MoverTareaCompletado.Visible = false;
            MoverTareaPendiente.Visible = true;
            MoverTareaPendiente.BringToFront();
        }

        private void DGVtareasEnProceso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SeleccionarTarea(DGVtareasEnProceso, e.RowIndex, "En proceso");
            MoverTareaPendiente.Visible = false;
            MoverTareaCompletado.Visible = false;
            MoverTareaEnProceso.Visible = true;
            MoverTareaEnProceso.BringToFront();
        }

        private void DGVtareasCompletado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            SeleccionarTarea(DGVtareasCompletado, e.RowIndex, "Hecho");
            MoverTareaPendiente.Visible = false;
            MoverTareaEnProceso.Visible = false;
            MoverTareaCompletado.Visible = true;
            MoverTareaCompletado.BringToFront();
        }

        // Extrae el ID y el estado de la fila seleccionada y los guarda en las variables globales
        private void SeleccionarTarea(DataGridView dgv, int rowIndex, string estado)
        {
            DataGridViewRow row = dgv.Rows[rowIndex];
            _idTareaSeleccionada = Convert.ToInt32(row.Cells["colID"].Value);
            _estadoTareaSeleccionada = estado;
        }
        #endregion

        #region CRUD Tareas
        // Prepara el panel para insertar una nueva tarea limpiando el formulario
        private void agregarTareaBTN_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            _idTareaSeleccionada = 0;
            LimpiarFormulario();
            pnlAgregarTarea.Visible = true;
            pnlAgregarTarea.BringToFront();
        }

        // Activa el modo edición y precarga los datos de la tarea seleccionada.
        // Hace una nueva consulta a la BL para obtener los datos actualizados
        // en lugar de leerlos directamente del DGV.
        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (_idTareaSeleccionada <= 0)
            {
                MessageBox.Show("Selecciona una tarea para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _modoEdicion = true;

            DataTable dt = _blKanban.ListarKanban(_idEstudiante);
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["ID"]) == _idTareaSeleccionada)
                {
                    txtTituloTarea.Text = row["titulo"].ToString();
                    txtDescripcionTarea.Text = row["descripcion"].ToString();
                    DTPtarea.Value = Convert.ToDateTime(row["fechaEntrega"]);
                    break;
                }
            }

            pnlAgregarTarea.Visible = true;
            pnlAgregarTarea.BringToFront();
        }

        // Guarda la tarea en modo inserción o edición según _modoEdicion.
        // Al editar, mantiene el estado actual de la tarea para no resetearla a "No empezado".
        private void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTituloTarea.Text))
                {
                    MessageBox.Show("El título es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ET_Kanban oKanban = new ET_Kanban
                {
                    ID = _idTareaSeleccionada,
                    ID_Estudiante = _idEstudiante,
                    titulo = txtTituloTarea.Text.Trim(),
                    descripcion = txtDescripcionTarea.Text.Trim(),
                    // Al insertar, toda tarea nueva arranca en "No empezado"
                    estado = _modoEdicion ? _estadoTareaSeleccionada : "No empezado",
                    fechaEntrega = DTPtarea.Value.Date
                };

                if (_modoEdicion)
                    _blKanban.ActualizarKanban(oKanban);
                else
                    _blKanban.InsertarKanban(oKanban);

                pnlAgregarTarea.Visible = false;
                LimpiarFormulario();
                CargarTodosLosTableros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCuenta_Click(object sender, EventArgs e)
        {
            pnlAgregarTarea.Visible = false;
            LimpiarFormulario();
        }

        // Pide confirmación antes de eliminar para evitar borrados accidentales.
        // Tras eliminar, resetea el estado de selección y oculta todos los paneles.
        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (_idTareaSeleccionada <= 0)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Deseas eliminar esta tarea?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _blKanban.EliminarKanban(_idTareaSeleccionada);
                    _idTareaSeleccionada = 0;
                    _estadoTareaSeleccionada = "";
                    OcultarPaneles();
                    CargarTodosLosTableros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Mover Tareas
        // Cada botón de flecha llama a MoverTarea con el estado destino
        // y oculta el panel de mover correspondiente al estado origen

        private void Btn_mover_a_progreso1_Click_1(object sender, EventArgs e)
        {
            MoverTarea("En proceso");
            MoverTareaPendiente.Visible = false;
        }

        private void Btn_mover_a_pendiente_Click(object sender, EventArgs e)
        {
            MoverTarea("No empezado");
            MoverTareaEnProceso.Visible = false;
        }

        private void Btn_mover_a_completado_Click_1(object sender, EventArgs e)
        {
            MoverTarea("Hecho");
            MoverTareaEnProceso.Visible = false;
        }

        private void Btn_mover_a_proceso2_Click(object sender, EventArgs e)
        {
            MoverTarea("En proceso");
            MoverTareaCompletado.Visible = false;
        }

        // Llama a ActualizarEstado en la BL y recarga los tres tableros para reflejar
        // el cambio de columna. Resetea el ID seleccionado tras mover.
        private void MoverTarea(string nuevoEstado)
        {
            if (_idTareaSeleccionada <= 0) return;

            try
            {
                _blKanban.ActualizarEstado(_idTareaSeleccionada, nuevoEstado);
                _estadoTareaSeleccionada = nuevoEstado;
                _idTareaSeleccionada = 0;
                CargarTodosLosTableros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Cerrar paneles de mover
        // Cada botón X cierra su panel de mover y limpia el ID seleccionado
        private void SalirGestionRubrosbtn_Click(object sender, EventArgs e)
        {
            MoverTareaPendiente.Visible = false;
            _idTareaSeleccionada = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoverTareaEnProceso.Visible = false;
            _idTareaSeleccionada = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoverTareaCompletado.Visible = false;
            _idTareaSeleccionada = 0;
        }
        #endregion

        #region Navegación
        private void btnHorario_Click(object sender, EventArgs e)
        {
            HorarioPrincipal horario = new HorarioPrincipal(_idEstudiante, "");
            horario.Show();
            this.Close();
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            FrmEvaluacion frmEvaluacion = new FrmEvaluacion(_idEstudiante);
            frmEvaluacion.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Utilidades
        // Limpia los campos del formulario de tarea y resetea el modo de edición
        private void LimpiarFormulario()
        {
            txtTituloTarea.Text = "";
            txtDescripcionTarea.Text = "";
            DTPtarea.Value = DateTime.Today;
            _modoEdicion = false;
        }
        #endregion
    }
}