using DAL;
using ET;
using System;
using System.Data;
using System.Text;

namespace BL
{
    public class BL_Kanban
    {
        // Instancia de la DAL para todas las operaciones sobre la tabla Kanban
        private readonly DAL_Kanban _dalKanban = new DAL_Kanban();

        // ============================================================
        //  LISTAR
        // ============================================================

        // Retorna todas las tareas Kanban de un estudiante.
        // El USP_ListarKanban también elimina automáticamente las tareas vencidas
        // antes de devolver los resultados.
        public DataTable ListarKanban(int idEstudiante)
        {
            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            return _dalKanban.ListarKanban(idEstudiante);
        }

        // ============================================================
        //  INSERTAR
        // ============================================================

        // Valida la tarea y la envía a la DAL con opción 1 (INSERT).
        // El USP retorna el ID generado como string, por eso se verifica con
        // int.TryParse en lugar de comparar contra "OK".
        public string InsertarKanban(ET_Kanban oKanban)
        {
            ValidarKanban(oKanban);

            string rpta = _dalKanban.GuardarKanban(1, oKanban);

            if (int.TryParse(rpta, out _))
                return "OK";

            throw new Exception(rpta);
        }

        // ============================================================
        //  ACTUALIZAR
        // ============================================================

        // Valida y actualiza una tarea existente usando opción 2 (UPDATE).
        // Requiere un ID válido antes de proceder.
        public string ActualizarKanban(ET_Kanban oKanban)
        {
            if (oKanban.ID <= 0)
                throw new Exception("ID de tarea no válido.");

            ValidarKanban(oKanban);

            string rpta = _dalKanban.GuardarKanban(2, oKanban);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  ELIMINAR
        // ============================================================

        // Elimina una tarea por ID. Si el USP no retorna "OK" lanza excepción.
        public string EliminarKanban(int idKanban)
        {
            if (idKanban <= 0)
                throw new Exception("ID de tarea no válido.");

            string rpta = _dalKanban.EliminarKanban(idKanban);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  ACTUALIZAR ESTADO
        // ============================================================

        // Cambia el estado de una tarea entre las tres columnas del Kanban.
        // Valida que el nuevo estado sea uno de los tres permitidos antes de
        // llamar al USP_ActualizarEstadoKanban dedicado.
        public string ActualizarEstado(int idKanban, string estado)
        {
            if (idKanban <= 0)
                throw new Exception("ID de tarea no válido.");

            string[] estadosValidos = { "No empezado", "En proceso", "Hecho" };
            if (Array.IndexOf(estadosValidos, estado) < 0)
                throw new Exception("Estado no válido. Debe ser: No empezado, En proceso o Hecho.");

            string rpta = _dalKanban.ActualizarEstadoKanban(idKanban, estado);
            if (rpta != "OK")
                throw new Exception(rpta);

            return rpta;
        }

        // ============================================================
        //  RECORDATORIO — cerca de fecha de entrega
        // ============================================================

        // Evalúa si una tarea individual está dentro del rango de alerta.
        // Por defecto alerta cuando quedan 2 días o menos para la entrega.
        public bool EstaProximaEntrega(ET_Kanban oKanban, int diasAlerta = 2)
        {
            return oKanban.diasRestantes >= 0 && oKanban.diasRestantes <= diasAlerta;
        }

        // Filtra el listado completo de tareas y retorna solo las que están
        // próximas a vencer según el umbral de días indicado.
        // Se usa desde RecordatorioKanban para construir el mensaje de alerta.
        public DataTable ObtenerTareasProximas(int idEstudiante, int diasAlerta = 2)
        {
            DataTable dt = ListarKanban(idEstudiante);
            DataTable dtProximas = dt.Clone(); // Crea una tabla vacía con la misma estructura

            foreach (DataRow row in dt.Rows)
            {
                int diasRestantes = Convert.ToInt32(row["diasRestantes"]);
                if (diasRestantes >= 0 && diasRestantes <= diasAlerta)
                    dtProximas.ImportRow(row);
            }

            return dtProximas;
        }

        // ============================================================
        //  VALIDACIONES PRIVADAS
        // ============================================================

        // Valida todos los campos del objeto ET_Kanban antes de insertar o actualizar.
        // Verifica nulidad, longitudes máximas, fecha de entrega válida y estado permitido.
        private void ValidarKanban(ET_Kanban oKanban)
        {
            if (oKanban == null)
                throw new Exception("La tarea no puede ser nula.");

            if (oKanban.ID_Estudiante <= 0)
                throw new Exception("El estudiante asociado no es válido.");

            if (string.IsNullOrWhiteSpace(oKanban.titulo))
                throw new Exception("El título de la tarea es obligatorio.");

            if (oKanban.titulo.Length > 100)
                throw new Exception("El título no puede superar los 100 caracteres.");

            // La descripción es opcional, pero si existe no puede exceder 500 caracteres
            if (oKanban.descripcion != null && oKanban.descripcion.Length > 500)
                throw new Exception("La descripción no puede superar los 500 caracteres.");

            if (oKanban.fechaEntrega == default)
                throw new Exception("La fecha de entrega es obligatoria.");

            // No se permite registrar tareas con fecha ya vencida
            if (oKanban.fechaEntrega.Date < DateTime.Today)
                throw new Exception("La fecha de entrega no puede ser anterior a hoy.");

            string[] estadosValidos = { "No empezado", "En proceso", "Hecho" };
            if (string.IsNullOrWhiteSpace(oKanban.estado) ||
                Array.IndexOf(estadosValidos, oKanban.estado) < 0)
                throw new Exception("El estado debe ser: No empezado, En proceso o Hecho.");
        }
    }

    // Clase estática de utilidad para el sistema de recordatorios del Kanban.
    // Al ser estática mantiene estado entre llamadas, lo que permite
    // controlar que el aviso no aparezca más de una vez por minuto.
    public static class RecordatorioKanban
    {
        // Almacena el último estudiante verificado y el momento de la verificación
        // para evitar mostrar el recordatorio repetidamente al navegar entre forms.
        private static int _ultimoEstudianteVerificado = -1;
        private static DateTime _ultimaVerificacion = DateTime.MinValue;

        // Verifica si el estudiante tiene tareas próximas a vencer y construye
        // el mensaje de alerta. Retorna null si no hay tareas próximas o si
        // ya se verificó en el último minuto para el mismo estudiante.
        public static string ObtenerMensajeRecordatorio(int idEstudiante)
        {
            // Throttle: si ya se verificó este estudiante en menos de 1 minuto, no repite
            if (_ultimoEstudianteVerificado == idEstudiante &&
                (DateTime.Now - _ultimaVerificacion).TotalMinutes < 1)
                return null;

            try
            {
                BL_Kanban blKanban = new BL_Kanban();
                DataTable dtProximas = blKanban.ObtenerTareasProximas(idEstudiante, 2);

                if (dtProximas.Rows.Count == 0) return null;

                // Construye el mensaje listando cada tarea con su fecha y días restantes
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Tienes tareas próximas a vencer:\n");

                foreach (DataRow row in dtProximas.Rows)
                {
                    string titulo = row["titulo"].ToString();
                    string fecha = Convert.ToDateTime(row["fechaEntrega"]).ToString("dd/MM/yyyy");
                    int dias = Convert.ToInt32(row["diasRestantes"]);

                    // Si vence hoy el mensaje es más urgente
                    string mensaje = dias == 0
                        ? $"• {titulo} — vence HOY ({fecha})"
                        : $"• {titulo} — vence en {dias} día(s) ({fecha})";

                    sb.AppendLine(mensaje);
                }

                // Actualiza el estado del throttle
                _ultimoEstudianteVerificado = idEstudiante;
                _ultimaVerificacion = DateTime.Now;

                return sb.ToString();
            }
            catch { return null; } // Si falla silenciosamente no interrumpe la navegación
        }
    }
}