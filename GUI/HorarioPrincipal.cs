using BL;
using ET;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class HorarioPrincipal : Form
    {
        #region Variables Globales
        // ID del estudiante activo, recibido desde el login
        private int _idEstudiante;

        // ID y objeto completo de la materia seleccionada en cualquier DGV del horario
        private int _idMateriaSeleccionada = 0;
        private int _estadoGuardar = 0; // 1 = Insertar, 2 = Actualizar
        private ET_Materia _materiaSeleccionada = null;

        // Instancias de BL reutilizadas en todo el form
        private readonly BL_Materia _blMateria = new BL_Materia();
        private readonly BL_Estudiante _blEstudiante = new BL_Estudiante();
        private readonly BL_SesionEstudio _blSesion = new BL_SesionEstudio();
        #endregion

        #region Constructor
        // Recibe el ID del estudiante y la fecha de conexión anterior para
        // verificar inactividad (Regla 3) antes de que cargue el form.
        // La fecha anterior se pasa aquí porque después del login ya se actualizó
        // la fechaConexion en BD, por lo que se debe guardar el valor previo.
        public HorarioPrincipal(int idEstudiante, string fechaConexionAnterior)
        {
            InitializeComponent();
            _idEstudiante = idEstudiante;

            VerificarInactividad(fechaConexionAnterior);
        }
        #endregion

        #region Load
        private void HorarioPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            InicializarComboBoxHoras();

            // Todos los eventos de botones y DGVs se registran aquí en código
            // porque estaban comentados en el designer
            ConfigurarEventosDGV();

            RefrescarTodoElHorario();
            OcultarTodosLosPaneles();

            // Verifica si hay tareas Kanban próximas a vencer y muestra el aviso
            string recordatorio = RecordatorioKanban.ObtenerMensajeRecordatorio(_idEstudiante);
            if (recordatorio != null)
                MessageBox.Show(recordatorio, "Recordatorio de tareas",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.WindowState = FormWindowState.Maximized;
            this.Show();
            this.BringToFront();
            this.Activate();
        }
        #endregion

        #region Inicialización

        // Rellena los ComboBox de horas con intervalos de 30 minutos (00:00 a 23:30)
        // y los de prioridad y día con sus valores fijos permitidos
        private void InicializarComboBoxHoras()
        {
            CBhoraInicio.Items.Clear();
            CBhoraFinal.Items.Clear();
            for (int h = 0; h < 24; h++)
            {
                CBhoraInicio.Items.Add(h.ToString("00") + ":00");
                CBhoraInicio.Items.Add(h.ToString("00") + ":30");
                CBhoraFinal.Items.Add(h.ToString("00") + ":00");
                CBhoraFinal.Items.Add(h.ToString("00") + ":30");
            }

            CBprioridad.Items.Clear();
            CBprioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });

            CBdiaSemana.Items.Clear();
            CBdiaSemana.Items.AddRange(new object[]
            {
                "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"
            });
        }

        // Registra el mismo handler DGV_CellClick en los siete DGVs del horario
        // y conecta todos los botones que el designer dejó sin evento asignado
        private void ConfigurarEventosDGV()
        {
            DGVmateriasLunes.CellClick += DGV_CellClick;
            DGVmateriasMartes.CellClick += DGV_CellClick;
            DGVmateriasMiercoles.CellClick += DGV_CellClick;
            DGVmateriasJueves.CellClick += DGV_CellClick;
            DGVmateriasViernes.CellClick += DGV_CellClick;
            DGVmateriasSabado.CellClick += DGV_CellClick;
            DGVmateriasDomingo.CellClick += DGV_CellClick;

            // Los DGVs del horario son de solo lectura — el usuario no puede editar celdas
            DGVmateriasLunes.ReadOnly = true;
            DGVmateriasMartes.ReadOnly = true;
            DGVmateriasMiercoles.ReadOnly = true;
            DGVmateriasJueves.ReadOnly = true;
            DGVmateriasViernes.ReadOnly = true;
            DGVmateriasSabado.ReadOnly = true;
            DGVmateriasDomingo.ReadOnly = true;

            agregarMateriaBTN.Click += agregarMateriaBTN_Click;
            btnCancelarGestionMateria.Click += btnCancelarGestionMateria_Click;
            cancelarMateriaBTN.Click += cancelarMateriaBTN_Click;
            btnEditarMateria.Click += btnEditarMateria_Click;
            btnEliminarMateria.Click += btnEliminarMateria_Click;
            button3.Click += button3_Click;       // Comenzar sesión de estudio
            button1.Click += button1_Click;       // Aceptar alerta de inactividad
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            btnEditarCuenta.Click += btnEditarCuenta_Click;
            btnCancelarCuenta.Click += btnCancelarCuenta_Click;
            BtnSalir.Click += BtnSalir_Click;
            BtnKanban.Click += BtnKanban_Click;
            BtnNotas.Click += BtnNotas_Click;
        }

        // Oculta todos los paneles flotantes al cargar para que el horario
        // arranque limpio sin ningún panel superpuesto
        private void OcultarTodosLosPaneles()
        {
            pnlMateria.Visible = false;
            pnlGestionarMateria.Visible = false;
            pnlEditarCuenta.Visible = false;
            groupBox2.Visible = false;
        }
        #endregion

        #region Regla 3 — Alerta de Inactividad

        // Verifica si el estudiante lleva 3 o más días sin conectarse.
        // Si es así, consulta la materia menos estudiada y muestra el mensaje
        // de recomendación en el groupBox2. El catch silencioso evita que un
        // error en esta validación impida abrir el form.
        private void VerificarInactividad(string fechaConexionAnterior)
        {
            try
            {
                if (!_blEstudiante.VerificarInactividad(fechaConexionAnterior))
                    return;

                DataTable dt = _blSesion.ObtenerMateriaMenosEstudiada(_idEstudiante);
                if (dt == null || dt.Rows.Count == 0) return;

                string nombreMateria = dt.Rows[0]["nombre"].ToString();
                string prioridad = dt.Rows[0]["prioridad"].ToString();
                string mensaje = _blSesion.ConstruirMensajeRecomendacion(nombreMateria, prioridad);

                label15.Text = mensaje;
                groupBox2.Visible = true;
                groupBox2.BringToFront();
            }
            catch { }
        }

        // Cierra el panel de alerta de inactividad al presionar Aceptar
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
        #endregion

        #region Horario — Listado y Formateo

        // Recarga los siete DGVs del horario semanal desde la BD
        private void RefrescarTodoElHorario()
        {
            CargarDGVDia(DGVmateriasLunes, "Lunes");
            CargarDGVDia(DGVmateriasMartes, "Martes");
            CargarDGVDia(DGVmateriasMiercoles, "Miércoles");
            CargarDGVDia(DGVmateriasJueves, "Jueves");
            CargarDGVDia(DGVmateriasViernes, "Viernes");
            CargarDGVDia(DGVmateriasSabado, "Sábado");
            CargarDGVDia(DGVmateriasDomingo, "Domingo");
        }

        // Carga todas las materias del estudiante y filtra las del día indicado
        // para mostrarlas en el DGV correspondiente. El filtrado se hace en memoria
        // porque ya se tiene el DataTable completo desde el USP.
        private void CargarDGVDia(DataGridView dgv, string dia)
        {
            try
            {
                DataTable todas = _blMateria.ListarMaterias("", _idEstudiante);
                DataTable filtrada = todas.Clone();

                foreach (DataRow row in todas.Rows)
                    if (row["diaSemana"].ToString() == dia)
                        filtrada.ImportRow(row);

                dgv.DataSource = filtrada;
                FormatearDGVHorario(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar {dia}: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Oculta columnas internas, renombra headers y ajusta el ancho de columnas
        // para que el horario sea legible. Se aplica a cualquier DGV del horario,
        // incluyendo el DGVgestionMateria del panel flotante.
        private void FormatearDGVHorario(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0) return;

            // Oculta campos que no son relevantes para el usuario en la vista del horario
            string[] ocultas = { "ID", "ID_Estudiante", "diaSemana", "estado" };
            foreach (string col in ocultas)
                if (dgv.Columns.Contains(col))
                    dgv.Columns[col].Visible = false;

            if (dgv.Columns.Contains("nombre"))
            {
                dgv.Columns["nombre"].HeaderText = "Materia";
                dgv.Columns["nombre"].Width = 100;
            }
            if (dgv.Columns.Contains("horaInicio")) dgv.Columns["horaInicio"].HeaderText = "Inicio";
            if (dgv.Columns.Contains("horaFinal")) dgv.Columns["horaFinal"].HeaderText = "Fin";
            if (dgv.Columns.Contains("prioridad")) dgv.Columns["prioridad"].HeaderText = "Prioridad";

            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }
        #endregion

        #region Horario — Click en materia

        // Handler compartido por los siete DGVs del horario.
        // Al hacer clic en una fila, construye el ET_Materia completo desde el DataSource
        // del DGV (sin hacer otra consulta a BD) y posiciona el panel flotante
        // justo debajo de la celda seleccionada para que aparezca contextualmente.
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = sender as DataGridView;
            DataRow row = ((DataTable)dgv.DataSource).Rows[e.RowIndex];

            _idMateriaSeleccionada = Convert.ToInt32(row["ID"]);
            _materiaSeleccionada = new ET_Materia
            {
                ID = Convert.ToInt32(row["ID"]),
                ID_Estudiante = _idEstudiante,
                nombre = row["nombre"].ToString(),
                horaInicio = row["horaInicio"].ToString(),
                horaFinal = row["horaFinal"].ToString(),
                prioridad = row["prioridad"].ToString(),
                diaSemana = row["diaSemana"].ToString(),
                estado = Convert.ToBoolean(row["estado"])
            };

            // Muestra solo la fila seleccionada en el DGV interno del panel flotante
            DataTable fila = ((DataTable)dgv.DataSource).Clone();
            fila.ImportRow(row);
            DGVgestionMateria.DataSource = fila;
            FormatearDGVHorario(DGVgestionMateria);

            // Posiciona el panel flotante relativo al DGV y al tableLayoutPanel
            Point pos = tableLayoutPanel1.Location;
            pnlMateria.Location = new Point(pos.X + dgv.Location.X,
                                            pos.Y + dgv.Location.Y + 40);
            pnlMateria.Visible = true;
            pnlMateria.BringToFront();
            pnlGestionarMateria.Visible = false;
        }
        #endregion

        #region CRUD Materia

        // Prepara el formulario para insertar una nueva materia
        private void agregarMateriaBTN_Click(object sender, EventArgs e)
        {
            _estadoGuardar = 1;
            _idMateriaSeleccionada = 0;
            LimpiarFormularioMateria();
            pnlGestionarMateria.Text = "Agregar Materia";
            pnlGestionarMateria.Visible = true;
            pnlGestionarMateria.BringToFront();
            pnlMateria.Visible = false;
        }

        // Precarga los datos de la materia seleccionada en el formulario para edición
        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            if (_materiaSeleccionada == null) return;

            _estadoGuardar = 2;
            txtNombreMateria.Text = _materiaSeleccionada.nombre;
            CBhoraInicio.Text = _materiaSeleccionada.horaInicio;
            CBhoraFinal.Text = _materiaSeleccionada.horaFinal;
            CBdiaSemana.Text = _materiaSeleccionada.diaSemana;
            CBprioridad.Text = _materiaSeleccionada.prioridad;

            pnlGestionarMateria.Text = "Editar Materia";
            pnlGestionarMateria.Visible = true;
            pnlGestionarMateria.BringToFront();
            pnlMateria.Visible = false;
        }

        // Guarda la materia en modo inserción o actualización según _estadoGuardar.
        // Si la BL lanza excepción (validación o solapamiento) se muestra como advertencia.
        private void btnGuardarGestionMateria_Click(object sender, EventArgs e)
        {
            try
            {
                ET_Materia oMateria = new ET_Materia
                {
                    ID = _idMateriaSeleccionada,
                    ID_Estudiante = _idEstudiante,
                    nombre = txtNombreMateria.Text.Trim(),
                    horaInicio = CBhoraInicio.Text,
                    horaFinal = CBhoraFinal.Text,
                    diaSemana = CBdiaSemana.Text,
                    prioridad = CBprioridad.Text,
                    estado = true
                };

                string rpta = _estadoGuardar == 1
                    ? _blMateria.InsertarMateria(oMateria)
                    : _blMateria.ActualizarMateria(oMateria);

                if (rpta == "OK")
                {
                    MessageBox.Show(_estadoGuardar == 1
                        ? "Materia agregada correctamente."
                        : "Materia actualizada correctamente.",
                        "Apice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pnlGestionarMateria.Visible = false;
                    RefrescarTodoElHorario();
                    LimpiarFormularioMateria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Pide confirmación antes de eliminar porque la acción también borra
        // en cascada las sesiones y disponibilidad asociadas a la materia
        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (_idMateriaSeleccionada == 0) return;

            if (MessageBox.Show("¿Deseas eliminar esta materia? Se eliminarán también sus sesiones y disponibilidad.",
                "Apice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string rpta = _blMateria.EliminarMateria(_idMateriaSeleccionada);
                    if (rpta == "OK")
                    {
                        MessageBox.Show("Materia eliminada correctamente.", "Apice",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlMateria.Visible = false;
                        _idMateriaSeleccionada = 0;
                        _materiaSeleccionada = null;
                        RefrescarTodoElHorario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Cancela la operación de agregar/editar sin guardar cambios
        private void btnCancelarGestionMateria_Click(object sender, EventArgs e)
        {
            pnlGestionarMateria.Visible = false;
            LimpiarFormularioMateria();
        }

        // Cierra el panel flotante de detalle de materia y limpia la selección
        private void cancelarMateriaBTN_Click(object sender, EventArgs e)
        {
            pnlMateria.Visible = false;
            _idMateriaSeleccionada = 0;
            _materiaSeleccionada = null;
        }

        // Resetea todos los campos del formulario de materia
        private void LimpiarFormularioMateria()
        {
            txtNombreMateria.Text = "";
            CBhoraInicio.SelectedIndex = -1;
            CBhoraFinal.SelectedIndex = -1;
            CBdiaSemana.SelectedIndex = -1;
            CBprioridad.SelectedIndex = -1;
        }
        #endregion

        #region Sesión de Estudio — Botón "Comenzar"

        // Calcula la duración de la materia a partir de su horario y abre el
        // FrmSesionEstudio con esos datos. Usa ShowDialog para que la sesión
        // bloquee el HorarioPrincipal mientras está activa.
        private void button3_Click(object sender, EventArgs e)
        {
            if (_materiaSeleccionada == null) return;

            int duracionMinutos = CalcularDuracionMinutos(
                _materiaSeleccionada.horaInicio,
                _materiaSeleccionada.horaFinal);

            if (duracionMinutos <= 0)
            {
                MessageBox.Show("No se pudo calcular la duración de la materia.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmSesionEstudio frmSesion = new FrmSesionEstudio(
                _idEstudiante,
                _materiaSeleccionada.ID,
                _materiaSeleccionada.nombre,
                duracionMinutos);

            pnlMateria.Visible = false;
            frmSesion.ShowDialog();
        }

        // Convierte dos strings de hora en minutos de diferencia.
        // Retorna 0 si alguna de las horas no tiene formato válido.
        private int CalcularDuracionMinutos(string horaInicio, string horaFinal)
        {
            if (TimeSpan.TryParse(horaInicio, out TimeSpan inicio) &&
                TimeSpan.TryParse(horaFinal, out TimeSpan fin))
                return (int)(fin - inicio).TotalMinutes;
            return 0;
        }
        #endregion

        #region Editar Cuenta

        // Muestra el panel de edición de cuenta del estudiante
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            pnlEditarCuenta.Visible = true;
            pnlEditarCuenta.BringToFront();
        }

        // Construye el ET_Estudiante con los datos del formulario y llama a la BL.
        // No actualiza la racha ni la fechaConexion — eso solo ocurre en el Login.
        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                ET_Estudiante oEstudiante = new ET_Estudiante
                {
                    ID = _idEstudiante,
                    nombre = txtNombreCuenta.Text.Trim(),
                    correo = txtCorreoCuenta.Text.Trim(),
                    contrasena = txtContrasenaCuenta.Text.Trim()
                };

                string rpta = _blEstudiante.ActualizarEstudiante(oEstudiante);
                if (rpta == "OK")
                {
                    MessageBox.Show("Cuenta actualizada correctamente.", "Apice",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlEditarCuenta.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Cancela la edición de cuenta y limpia los campos del formulario
        private void btnCancelarCuenta_Click(object sender, EventArgs e)
        {
            pnlEditarCuenta.Visible = false;
            txtNombreCuenta.Text = "";
            txtCorreoCuenta.Text = "";
            txtContrasenaCuenta.Text = "";
        }
        #endregion

        #region Navegación

        // Pide confirmación antes de cerrar sesión para evitar cierres accidentales
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "Apice",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        // Usa Hide en lugar de Close para no destruir el HorarioPrincipal al navegar
        private void BtnKanban_Click(object sender, EventArgs e)
        {
            FrmKanban frmKanban = new FrmKanban(_idEstudiante);
            frmKanban.Show();
            this.Hide();
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            FrmEvaluacion frmEvaluacion = new FrmEvaluacion(_idEstudiante);
            frmEvaluacion.Show();
            this.Hide();
        }
        #endregion

        // Cierra la aplicación completamente — botón alternativo al cerrar sesión
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento generado automáticamente por el designer, sin lógica asociada
        private void labelLunes_Click(object sender, EventArgs e) { }
    }
}