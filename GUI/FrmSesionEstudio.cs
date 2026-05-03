using BL;
using ET;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmSesionEstudio : Form
    {
        #region Variables Globales

        // Datos de la sesión recibidos desde el form anterior
        private int idEstudiante;
        private int idMateria;
        private string nombreMateriaTexto;
        private int duracionTotalMinutos;

        // Estado del cronómetro principal
        private int segundosTranscurridos = 0; // tiempo total acumulado desde que inició
        private bool cronometroActivo = false;
        private bool enDescanso = false; // true cuando el timer está contando un descanso

        // Control del ciclo Pomodoro
        private int bloquesCompletados = 0;
        private int segundosBloque = 0; // segundos del bloque o descanso actual
        private const int SEGUNDOS_TRABAJO = 25 * 60; // duración fija de un bloque Pomodoro
        private int segundosDescansoActual = 0; // duración del descanso activo en segundos

        // Objeto de sesión retornado por la BL al llamar a IniciarSesion,
        // necesario para finalizar o interrumpir la sesión con su ID de BD
        private ET_SesionEstudio sesionActual = null;

        // Instancia de la BL para toda la lógica de sesiones
        private BL_SesionEstudio blSesion = new BL_SesionEstudio();

        #endregion

        #region Constructor

        // Recibe todos los parámetros necesarios para la sesión desde el form que lo abre.
        // No hace consultas a la BD aquí — eso ocurre cuando el usuario presiona Iniciar.
        public FrmSesionEstudio(int idEstudiante, int idMateria, string nombreMateria, int duracionMinutos)
        {
            InitializeComponent();

            this.idEstudiante = idEstudiante;
            this.idMateria = idMateria;
            this.nombreMateriaTexto = nombreMateria;
            this.duracionTotalMinutos = duracionMinutos;

            ConfigurarFormulario();
            ConfigurarEventos();
        }

        #endregion

        #region Configuración inicial

        // Inicializa el estado visual del form: muestra el nombre de la materia,
        // pone el display en 00.00 y deja solo el botón Iniciar habilitado
        private void ConfigurarFormulario()
        {
            label2.Text = nombreMateriaTexto;
            ActualizarDisplay(0);
            btnIniciar_Click.Enabled = true;
            btnPausar_Click.Enabled = false;
        }

        // Conecta el evento Click del botón Iniciar en código porque estaba
        // comentado en el designer
        private void ConfigurarEventos()
        {
            btnIniciar_Click.Click += btnIniciar_Click_Click;
        }

        #endregion

        #region Eventos del cronómetro

        // Inicia la sesión la primera vez que se presiona el botón.
        // Llama a BL.IniciarSesion que persiste la sesión en BD y aplica la
        // advertencia nocturna (Regla 4). Si el usuario cancela la advertencia,
        // la sesión no se crea y el cronómetro no arranca.
        // Las veces siguientes (reanudar tras pausa) solo reactiva el timer.
        private void btnIniciar_Click_Click(object sender, EventArgs e)
        {
            if (!cronometroActivo)
            {
                if (sesionActual == null)
                {
                    try
                    {
                        string advertencia;
                        sesionActual = blSesion.IniciarSesion(
                            idEstudiante,
                            idMateria,
                            duracionTotalMinutos,
                            out advertencia);

                        // Si la BL detectó horario nocturno, pregunta si quiere continuar
                        if (!string.IsNullOrEmpty(advertencia))
                        {
                            DialogResult res = MessageBox.Show(
                                advertencia + "\n\n¿Deseas continuar con la sesión?",
                                "Recordatorio de descanso nocturno",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

                            if (res == DialogResult.No)
                            {
                                // Descarta la sesión creada y aborta el inicio
                                sesionActual = null;
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al iniciar sesión: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                cronometroActivo = true;
                timer1.Start();
                btnIniciar_Click.Enabled = false;
                btnPausar_Click.Enabled = true;
            }
        }

        // Pausa el cronómetro sin perder el progreso.
        // El timer se detiene pero los contadores no se resetean.
        private void btnPausar_Click_Click(object sender, EventArgs e)
        {
            if (cronometroActivo)
            {
                cronometroActivo = false;
                timer1.Stop();
                btnIniciar_Click.Enabled = true;
                btnPausar_Click.Enabled = false;
            }
        }

        // Se ejecuta cada segundo. Maneja dos modos: trabajo y descanso.
        // En modo trabajo: actualiza el display del bloque actual y verifica si
        // se completó un bloque de 25 min o si se agotó el tiempo total.
        // En modo descanso: hace cuenta regresiva hasta que termina el descanso.
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundosTranscurridos++;
            segundosBloque++;

            if (!enDescanso)
            {
                ActualizarDisplay(segundosBloque);

                // Completó un bloque de 25 minutos → inicia el descanso correspondiente
                if (segundosBloque >= SEGUNDOS_TRABAJO)
                {
                    bloquesCompletados++;
                    segundosBloque = 0;
                    IniciarDescanso();
                }

                // Se agotó el tiempo total configurado → finaliza la sesión automáticamente
                if (segundosTranscurridos >= duracionTotalMinutos * 60)
                {
                    FinalizarSesionCompleta();
                }
            }
            else
            {
                // Cuenta regresiva del descanso activo
                int restante = segundosDescansoActual - segundosBloque;

                if (restante <= 0)
                    TerminarDescanso();
                else
                    ActualizarDisplayDescanso(restante);
            }
        }

        #endregion

        #region Lógica Pomodoro

        // Activa el modo descanso y consulta a la BL cuántos minutos corresponden.
        // La BL aplica la regla: cada 4 bloques → 30 min, resto → 5 min.
        // Muestra un mensaje diferente según si es descanso corto o largo.
        private void IniciarDescanso()
        {
            enDescanso = true;
            segundosBloque = 0;

            int minutosDescanso = blSesion.ObtenerDescanso(bloquesCompletados);
            segundosDescansoActual = minutosDescanso * 60;

            if (bloquesCompletados % 4 == 0)
            {
                MessageBox.Show(
                    $"¡Completaste 4 bloques! Mereces un descanso de {minutosDescanso} minutos.",
                    "Descanso prolongado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    $"Bloque {bloquesCompletados} completado. Descansa {minutosDescanso} minutos.",
                    "Descanso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Desactiva el modo descanso y resetea los contadores del bloque
        // para que el siguiente ciclo de 25 minutos empiece desde cero
        private void TerminarDescanso()
        {
            enDescanso = false;
            segundosBloque = 0;
            segundosDescansoActual = 0;
            ActualizarDisplay(0);

            MessageBox.Show("¡Descanso terminado! Retomemos el estudio.",
                "A estudiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Actualizar display

        // Muestra el tiempo transcurrido del bloque actual en formato MM.SS
        private void ActualizarDisplay(int segundos)
        {
            int min = segundos / 60;
            int seg = segundos % 60;
            label1.Text = $"{min:D2}.{seg:D2}";
        }

        // Muestra el tiempo restante del descanso en formato MM.SS
        private void ActualizarDisplayDescanso(int segundosRestantes)
        {
            int min = segundosRestantes / 60;
            int seg = segundosRestantes % 60;
            label1.Text = $"{min:D2}.{seg:D2}";
        }

        #endregion

        #region Guardar sesión en BD

        // Detiene el timer, marca la sesión como completada en BD y cierra el form.
        // Se llama automáticamente cuando se agota el tiempo total configurado.
        private void FinalizarSesionCompleta()
        {
            timer1.Stop();
            cronometroActivo = false;

            if (sesionActual == null) return;

            try
            {
                // Convierte los segundos transcurridos a minutos para persistirlos
                sesionActual.duracion = segundosTranscurridos / 60;

                blSesion.FinalizarSesion(sesionActual, bloquesCompletados);

                MessageBox.Show(
                    $"¡Sesión completada!\n\nDuración: {sesionActual.duracion} min\nBloques completados: {bloquesCompletados}",
                    "¡Sesión finalizada!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar sesión: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        // Guarda la sesión como incompleta con los minutos y bloques reales alcanzados.
        // Se llama cuando el usuario decide salir antes de terminar el tiempo.
        private void GuardarSesionIncompleta()
        {
            if (sesionActual == null) return;

            try
            {
                blSesion.InterrumpirSesion(
                    sesionActual,
                    bloquesCompletados,
                    segundosTranscurridos / 60);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar sesión incompleta: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botón salir de sesión

        // Pausa el cronómetro y muestra el panel de confirmación de salida
        // para que el usuario confirme antes de abandonar la sesión
        private void button3_Click(object sender, EventArgs e)
        {
            if (cronometroActivo)
            {
                timer1.Stop();
                cronometroActivo = false;
                btnIniciar_Click.Enabled = true;
                btnPausar_Click.Enabled = false;
            }

            panel1.Visible = true;
            panel1.BringToFront();
        }

        // "Sí" — el usuario confirma que quiere salir.
        // Persiste la sesión como incompleta antes de cerrar el form.
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            GuardarSesionIncompleta();
            this.Close();
        }

        // "No" — el usuario cancela la salida y vuelve a la sesión activa
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        #endregion

        #region Eventos del designer sin lógica
        // Eventos generados automáticamente por el designer al hacer doble clic
        // en los controles. No tienen lógica asociada.
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        #endregion
    }
}