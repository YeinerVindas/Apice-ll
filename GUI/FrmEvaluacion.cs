using BL;
using ET;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmEvaluacion : Form
    {
        #region Variables Globales
        // ID del estudiante activo, recibido desde el form anterior al navegar
        private readonly int _idEstudiante;

        // Estado de la materia seleccionada actualmente en el DGV izquierdo
        private int _idMateriaSeleccionada;
        private string _nombreMateriaSeleccionada;
        private decimal? _notaMinimaSeleccionada;

        // Estado del rubro seleccionado en el DGV de rubros
        private int _idRubroSeleccionado;

        // Controla si el panel de agregar/editar está en modo edición o inserción
        private bool _modoEdicion = false;

        // Objeto completo de la materia activa, necesario para actualizar la nota mínima
        private ET_Materia _materiaSeleccionada = null;

        // Instancias de BL reutilizadas en todo el form
        private readonly BL_Evaluacion _blEvaluacion = new BL_Evaluacion();
        private readonly BL_Materia _blMateria = new BL_Materia();
        #endregion

        #region Constructor
        // Recibe el ID del estudiante desde el form de login o navegación
        public FrmEvaluacion(int idEstudiante)
        {
            InitializeComponent();
            _idEstudiante = idEstudiante;
        }
        #endregion

        #region Carga del Form
        private void FrmEvaluacion_Load(object sender, EventArgs e)
        {
            ConfigurarDGVMaterias();

            // Conecta el botón de cerrar del groupBox2 de alerta directamente en código
            button3.Click += (s, ev) => groupBox2.Visible = false;

            CargarMaterias();

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

        // Configura las columnas de ambos DGVs manualmente para controlar
        // exactamente qué campos se muestran y cuáles quedan ocultos (como los IDs).
        private void ConfigurarDGVMaterias()
        {
            // DGV de materias: muestra resumen de notas por materia
            dgvMateriasNotas.AutoGenerateColumns = false;
            dgvMateriasNotas.Columns.Clear();
            dgvMateriasNotas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Materia", DataPropertyName = "nombre", Width = 150 });
            dgvMateriasNotas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nota Actual", DataPropertyName = "notaActual", Width = 100 });
            dgvMateriasNotas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nota Mínima", DataPropertyName = "notaMinima", Width = 100 });
            dgvMateriasNotas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "estado", Width = 150 });
            dgvMateriasNotas.Columns.Add(new DataGridViewTextBoxColumn { Name = "colID", DataPropertyName = "ID", Visible = false });
            dgvMateriasNotas.AllowUserToAddRows = false;
            dgvMateriasNotas.ReadOnly = true;
            dgvMateriasNotas.DefaultCellStyle.ForeColor = Color.Black;
            dgvMateriasNotas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMateriasNotas.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;

            // DGV de rubros: muestra el detalle de evaluaciones de la materia seleccionada
            DGVgestionarRubros.AutoGenerateColumns = false;
            DGVgestionarRubros.Columns.Clear();
            DGVgestionarRubros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Rubro", DataPropertyName = "nombre", Width = 150 });
            DGVgestionarRubros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Porcentaje %", DataPropertyName = "porcentaje", Width = 100 });
            DGVgestionarRubros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nota", DataPropertyName = "nota", Width = 80 });
            DGVgestionarRubros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Aporte Total", DataPropertyName = "aporteTotal", Width = 100 });
            DGVgestionarRubros.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRubroID", DataPropertyName = "ID", Visible = false });
            DGVgestionarRubros.AllowUserToAddRows = false;
            DGVgestionarRubros.ReadOnly = true;
            DGVgestionarRubros.DefaultCellStyle.ForeColor = Color.Black;
            DGVgestionarRubros.DefaultCellStyle.SelectionForeColor = Color.White;
            DGVgestionarRubros.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
        }
        #endregion

        #region Cargar Datos
        // Construye una DataTable de vista personalizada para el DGV de materias.
        // Por cada materia carga sus rubros, calcula la nota actual y determina el estado.
        // No usa el resultado directo del USP porque necesita calcular en la BL.
        private void CargarMaterias()
        {
            try
            {
                DataTable dt = _blMateria.ListarMaterias("", _idEstudiante);

                DataTable dtVista = new DataTable();
                dtVista.Columns.Add("ID", typeof(int));
                dtVista.Columns.Add("nombre", typeof(string));
                dtVista.Columns.Add("notaMinima", typeof(string));
                dtVista.Columns.Add("notaActual", typeof(string));
                dtVista.Columns.Add("estado", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    int idMateria = Convert.ToInt32(row["ID"]);
                    string nombreMateria = row["nombre"].ToString();
                    decimal? notaMinima = row["notaMinima"] == DBNull.Value
                        ? (decimal?)null
                        : Convert.ToDecimal(row["notaMinima"]);

                    // Por cada materia se consultan sus rubros para calcular la nota acumulada
                    DataTable dtRubros = _blEvaluacion.ListarEvaluaciones("", _idEstudiante, idMateria);
                    decimal notaActual = _blEvaluacion.CalcularNotaActual(dtRubros);
                    string estado = _blEvaluacion.EstadoVsNotaMinima(notaActual, notaMinima);

                    dtVista.Rows.Add(
                        idMateria,
                        nombreMateria,
                        notaMinima.HasValue ? notaMinima.Value.ToString("0.##") : "No definida",
                        notaActual.ToString("0.##"),
                        estado
                    );
                }

                dgvMateriasNotas.DataSource = dtVista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materias: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga los rubros de la materia activa y actualiza el label de resumen.
        // Si la nota está en riesgo, muestra el groupBox2 de alerta automáticamente.
        private void CargarRubros()
        {
            try
            {
                DataTable dt = _blEvaluacion.ListarEvaluaciones("", _idEstudiante, _idMateriaSeleccionada);
                DGVgestionarRubros.DataSource = dt;

                // Aplica formato decimal a las columnas numéricas del DGV
                if (DGVgestionarRubros.Columns.Contains("porcentaje"))
                    DGVgestionarRubros.Columns["porcentaje"].DefaultCellStyle.Format = "0.##";
                if (DGVgestionarRubros.Columns.Contains("nota"))
                    DGVgestionarRubros.Columns["nota"].DefaultCellStyle.Format = "0.##";
                if (DGVgestionarRubros.Columns.Contains("aporteTotal"))
                    DGVgestionarRubros.Columns["aporteTotal"].DefaultCellStyle.Format = "0.##";

                decimal notaActual = _blEvaluacion.CalcularNotaActual(dt);
                decimal porcentajeUsado = _blEvaluacion.CalcularPorcentajeUsado(dt);
                string estado = _blEvaluacion.EstadoVsNotaMinima(notaActual, _notaMinimaSeleccionada);

                // Muestra un resumen consolidado en el label superior del panel de rubros
                NombreMateria.Text = $"{_nombreMateriaSeleccionada} | {porcentajeUsado}% | {estado}";

                // Si el estudiante está en riesgo de reprobar, activa la alerta visual
                if (estado.StartsWith("En riesgo"))
                {
                    label9.Text = estado;
                    groupBox2.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar rubros: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos DGV Materias
        // Al hacer clic en una materia, carga el objeto completo desde la BD
        // para tener acceso a todos sus campos (incluyendo notaMinima y horario)
        // sin depender solo de lo que está visible en el DGV.
        private void dgvMateriasNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMateriasNotas.Rows[e.RowIndex];
            _idMateriaSeleccionada = Convert.ToInt32(row.Cells["colID"].Value);
            _nombreMateriaSeleccionada = row.Cells[1].Value.ToString();

            // Recarga el listado de materias para construir el ET_Materia completo
            DataTable dt = _blMateria.ListarMaterias("", _idEstudiante);
            foreach (DataRow fila in dt.Rows)
            {
                if (Convert.ToInt32(fila["ID"]) == _idMateriaSeleccionada)
                {
                    _materiaSeleccionada = new ET_Materia
                    {
                        ID = Convert.ToInt32(fila["ID"]),
                        ID_Estudiante = _idEstudiante,
                        nombre = fila["nombre"].ToString(),
                        horaInicio = fila["horaInicio"].ToString(),
                        horaFinal = fila["horaFinal"].ToString(),
                        prioridad = fila["prioridad"].ToString(),
                        diaSemana = fila["diaSemana"].ToString(),
                        estado = Convert.ToBoolean(fila["estado"]),
                        notaMinima = fila["notaMinima"] == DBNull.Value
                            ? (decimal?)null
                            : Convert.ToDecimal(fila["notaMinima"])
                    };
                    break;
                }
            }

            _notaMinimaSeleccionada = _materiaSeleccionada?.notaMinima;

            NombreMateria.Text = _nombreMateriaSeleccionada;
            pnlGestionarRubro.Visible = true;
            pnlAgregarRubro.Visible = false;
            LimpiarFormulario();
            CargarRubros();
        }
        #endregion

        #region Eventos DGV Rubros
        // Al seleccionar un rubro, precarga sus datos en el formulario
        // para facilitar la edición sin que el usuario tenga que reescribir todo.
        private void DGVgestionarRubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = DGVgestionarRubros.Rows[e.RowIndex];
            _idRubroSeleccionado = Convert.ToInt32(row.Cells["colRubroID"].Value);
            txtNombreRubro.Text = row.Cells[0].Value.ToString();
            txtValorPorcentual.Text = row.Cells[1].Value.ToString();

            // La nota puede ser null si aún no se ha registrado
            txtNotaObtenida.Text = row.Cells[2].Value == DBNull.Value
                ? ""
                : row.Cells[2].Value.ToString();

            txtNotaMinima.Text = _notaMinimaSeleccionada.HasValue
                ? _notaMinimaSeleccionada.Value.ToString("0.##")
                : "";
        }
        #endregion

        #region Agregar / Editar Rubro
        // Prepara el panel para insertar un nuevo rubro limpiando el formulario
        private void agregarMateriaBTN_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            _idRubroSeleccionado = 0;
            LimpiarFormulario();
            pnlAgregarRubro.Visible = true;
        }

        // Activa el modo edición si hay un rubro seleccionado
        private void btnEditarRubro_Click(object sender, EventArgs e)
        {
            if (_idRubroSeleccionado <= 0)
            {
                MessageBox.Show("Selecciona un rubro para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _modoEdicion = true;
            pnlAgregarRubro.Visible = true;
        }

        // Guarda el rubro (insertar o actualizar según _modoEdicion).
        // También actualiza la nota mínima de la materia si el campo fue llenado,
        // lo que implica una llamada adicional a BL_Materia.
        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreRubro.Text))
                {
                    MessageBox.Show("El nombre del rubro es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtValorPorcentual.Text, out decimal porcentaje))
                {
                    MessageBox.Show("El porcentaje debe ser un número válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // La nota es opcional — se parsea solo si el campo tiene contenido
                decimal? nota = null;
                if (!string.IsNullOrWhiteSpace(txtNotaObtenida.Text))
                {
                    if (!decimal.TryParse(txtNotaObtenida.Text, out decimal notaVal))
                    {
                        MessageBox.Show("La nota debe ser un número válido.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    nota = notaVal;
                }

                // La nota mínima también es opcional — si se llena, se persiste en la materia
                decimal? notaMinima = null;
                if (!string.IsNullOrWhiteSpace(txtNotaMinima.Text))
                {
                    if (!decimal.TryParse(txtNotaMinima.Text, out decimal notaMinimaVal))
                    {
                        MessageBox.Show("La nota mínima debe ser un número válido.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    notaMinima = notaMinimaVal;
                }

                ET_Evaluacion oEval = new ET_Evaluacion
                {
                    ID = _idRubroSeleccionado,
                    ID_Materia = _idMateriaSeleccionada,
                    ID_Estudiante = _idEstudiante,
                    nombre = txtNombreRubro.Text.Trim(),
                    porcentaje = porcentaje,
                    nota = nota
                };

                if (_modoEdicion)
                    _blEvaluacion.ActualizarEvaluacion(oEval);
                else
                    _blEvaluacion.InsertarEvaluacion(oEval);

                // Si se ingresó nota mínima, se actualiza directamente en la materia
                if (notaMinima.HasValue && _materiaSeleccionada != null)
                {
                    _materiaSeleccionada.notaMinima = notaMinima;
                    _blMateria.ActualizarMateria(_materiaSeleccionada);
                    _notaMinimaSeleccionada = notaMinima;
                }

                pnlAgregarRubro.Visible = false;
                LimpiarFormulario();
                CargarRubros();
                CargarMaterias(); // Refresca el DGV principal para reflejar la nota actualizada
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCuenta_Click(object sender, EventArgs e)
        {
            pnlAgregarRubro.Visible = false;
            LimpiarFormulario();
        }
        #endregion

        #region Eliminar Rubro
        // Pide confirmación antes de eliminar para evitar borrados accidentales
        private void btnEliminarRubro_Click(object sender, EventArgs e)
        {
            if (_idRubroSeleccionado <= 0)
            {
                MessageBox.Show("Selecciona un rubro para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Deseas eliminar este rubro?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _blEvaluacion.EliminarEvaluacion(_idRubroSeleccionado);
                    _idRubroSeleccionado = 0;
                    LimpiarFormulario();
                    CargarRubros();
                    CargarMaterias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Navegación
        // Cierra el panel de rubros y limpia el estado de selección
        private void SalirGestionRubrosbtn_Click(object sender, EventArgs e)
        {
            pnlGestionarRubro.Visible = false;
            pnlAgregarRubro.Visible = false;
            groupBox2.Visible = false;
            _idMateriaSeleccionada = 0;
            _idRubroSeleccionado = 0;
            _materiaSeleccionada = null;
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            HorarioPrincipal horario = new HorarioPrincipal(_idEstudiante, "");
            horario.Show();
            this.Close();
        }

        // Usa Hide en lugar de Close para que el form no se destruya al navegar al Kanban
        private void btnKanban_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKanban kanban = new FrmKanban(_idEstudiante);
            kanban.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Utilidades
        // Limpia todos los campos del formulario de rubros y resetea el modo de edición
        private void LimpiarFormulario()
        {
            txtNombreRubro.Text = "";
            txtValorPorcentual.Text = "";
            txtNotaObtenida.Text = "";
            txtNotaMinima.Text = "";
            _modoEdicion = false;
        }
        #endregion
    }
}