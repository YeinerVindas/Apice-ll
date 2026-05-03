using System;
using System.Data;
using ET;
using DAL;

namespace BL
{
    public class BL_SesionEstudio
    {
        // Instancias de la DAL para acceder a sesiones y materias
        private readonly DAL_SesionEstudio _dalSesion = new DAL_SesionEstudio();
        private readonly DAL_Materia _dalMateria = new DAL_Materia();

        // Constantes que definen la estructura del método Pomodoro:
        // 25 min de trabajo, 5 min de descanso corto, 30 min de descanso largo cada 4 bloques
        private const int MINUTOS_BLOQUE = 25;
        private const int MINUTOS_DESCANSO_CORTO = 5;
        private const int MINUTOS_DESCANSO_LARGO = 30;
        private const int BLOQUES_PARA_DESCANSO_LARGO = 4;

        // ============================================================
        //  LISTAR SESIONES
        // ============================================================

        // Devuelve todas las sesiones de un estudiante, con búsqueda opcional por texto.
        // Lanza excepción si el ID del estudiante no es válido.
        public DataTable ListarSesiones(string cTexto, int idEstudiante)
        {
            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            return _dalSesion.ListarSesionesPorEstudiante(cTexto ?? "", idEstudiante);
        }

        // ============================================================
        //  INICIAR SESIÓN DE ESTUDIO
        // ============================================================

        // Crea y persiste una nueva sesión de estudio en base a los parámetros recibidos.
        // Aplica dos reglas de negocio:
        //   - Regla 4: Si la hora actual está entre las 22:00 y las 05:00, genera una advertencia
        //              de descanso nocturno que se devuelve por el parámetro "out".
        //   - Regla 1: Calcula cuántos bloques Pomodoro caben en la duración indicada.
        // Retorna el objeto ET_SesionEstudio con el ID asignado por la base de datos.
        public ET_SesionEstudio IniciarSesion(int idEstudiante, int idMateria, int duracionMinutos,
                                               out string advertencia)
        {
            advertencia = string.Empty;

            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            if (idMateria <= 0)
                throw new Exception("ID de materia no válido.");

            if (duracionMinutos <= 0)
                throw new Exception("La duración debe ser mayor a 0 minutos.");

            // Verifica si el estudiante está estudiando en horario nocturno
            int horaActual = DateTime.Now.Hour;
            if (horaActual >= 22 || horaActual < 5)
                advertencia = "⚠️ Son las " + DateTime.Now.ToString("HH:mm") +
                              ". Te recomendamos priorizar tu descanso. " +
                              "Estudiar de noche puede afectar tu rendimiento.";

            // Calcula cuántos bloques de 25 minutos caben en la duración total
            int cantidadBloques = CalcularBloques(duracionMinutos);

            // Construye el objeto de sesión con estado inicial "En progreso"
            ET_SesionEstudio oSesion = new ET_SesionEstudio
            {
                ID_Estudiante = idEstudiante,
                ID_Materia = idMateria,
                fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                duracion = duracionMinutos,
                cantidadBloques = cantidadBloques,
                estado = "En progreso",
                completada = false
            };

            // Llama a la DAL con opción 1 (insertar) y espera el ID generado como respuesta
            string rpta = _dalSesion.GuardarSesion(1, oSesion);

            if (int.TryParse(rpta, out int idGenerado))
                oSesion.ID = idGenerado;
            else
                throw new Exception("Error al iniciar la sesión: " + rpta);

            return oSesion;
        }

        // ============================================================
        //  FINALIZAR SESIÓN (completada)
        // ============================================================

        // Marca la sesión como completada y actualiza los bloques realmente terminados.
        // Llama a la DAL con opción 2 (actualizar).
        public string FinalizarSesion(ET_SesionEstudio oSesion, int bloquesCompletados)
        {
            if (oSesion.ID <= 0)
                throw new Exception("ID de sesión no válido.");

            if (bloquesCompletados < 0)
                throw new Exception("La cantidad de bloques no puede ser negativa.");

            oSesion.cantidadBloques = bloquesCompletados;
            oSesion.completada = true;
            oSesion.estado = "Completada";

            string rpta = _dalSesion.GuardarSesion(2, oSesion);
            if (rpta != "OK")
                throw new Exception("Error al finalizar la sesión: " + rpta);

            return rpta;
        }

        // ============================================================
        //  INTERRUMPIR SESIÓN (incompleta)
        // ============================================================

        // Registra una sesión que fue cortada antes de completarse.
        // Guarda los bloques alcanzados y los minutos reales transcurridos,
        // y marca el estado como "Incompleta".
        public string InterrumpirSesion(ET_SesionEstudio oSesion, int bloquesCompletados,
                                         int minutosTranscurridos)
        {
            if (oSesion.ID <= 0)
                throw new Exception("ID de sesión no válido.");

            oSesion.cantidadBloques = bloquesCompletados;
            oSesion.duracion = minutosTranscurridos;
            oSesion.completada = false;
            oSesion.estado = "Incompleta";

            string rpta = _dalSesion.GuardarSesion(2, oSesion);
            if (rpta != "OK")
                throw new Exception("Error al registrar la sesión incompleta: " + rpta);

            return rpta;
        }

        // ============================================================
        //  REGLA 1: CALCULAR BLOQUES POMODORO
        // ============================================================

        // Divide la duración entre 25 para obtener la cantidad de bloques.
        // Si la duración es menor a 25 minutos, retorna 0 porque no alcanza
        // ni para un bloque completo.
        public int CalcularBloques(int duracionMinutos)
        {
            if (duracionMinutos < MINUTOS_BLOQUE)
                return 0;

            return duracionMinutos / MINUTOS_BLOQUE;
        }

        // ============================================================
        //  REGLA 1: OBTENER TIPO DE DESCANSO
        // ============================================================

        // Determina cuántos minutos de descanso corresponden según el número de bloque actual.
        // Si el bloque es múltiplo de 4 → descanso largo (30 min).
        // Cualquier otro bloque → descanso corto (5 min).
        public int ObtenerDescanso(int bloqueActual)
        {
            if (bloqueActual <= 0)
                throw new Exception("El número de bloque debe ser mayor a 0.");

            if (bloqueActual % BLOQUES_PARA_DESCANSO_LARGO == 0)
                return MINUTOS_DESCANSO_LARGO;

            return MINUTOS_DESCANSO_CORTO;
        }

        // ============================================================
        //  REGLA 2: REPOSICIÓN DINÁMICA
        // ============================================================

        // Obtiene las sesiones incompletas del estudiante para que puedan
        // ser reprogramadas desde la GUI. Actualmente reutiliza el listado
        // general — pendiente de filtrar por estado "Incompleta" en el USP.
        public DataTable ObtenerSesionesIncompletas(int idEstudiante)
        {
            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            DAL_SesionEstudio dalAux = new DAL_SesionEstudio();
            return dalAux.ListarSesionesPorEstudiante("", idEstudiante);
        }

        // ============================================================
        //  REGLA 3: MATERIA MENOS ESTUDIADA
        // ============================================================

        // Devuelve las materias del estudiante ordenadas por menor actividad y mayor prioridad,
        // para usarse cuando se detecta inactividad prolongada.
        // Nota: actualmente llama al listado general de materias — idealmente debería
        // invocar un USP_MateriasMenosEstudiadas dedicado en la DAL.
        public DataTable ObtenerMateriaMenosEstudiada(int idEstudiante)
        {
            if (idEstudiante <= 0)
                throw new Exception("ID de estudiante no válido.");

            return _dalMateria.ListarMaterias("", idEstudiante);
        }

        // ============================================================
        //  CONSTRUIR MENSAJE DE RECOMENDACIÓN
        // ============================================================

        // Arma el mensaje que se muestra en pantalla cuando el sistema detecta
        // que el estudiante lleva 3 o más días sin registrar sesiones.
        // Incluye el nombre de la materia y su nivel de prioridad.
        public string ConstruirMensajeRecomendacion(string nombreMateria, string prioridad)
        {
            if (string.IsNullOrWhiteSpace(nombreMateria))
                return string.Empty;

            return $"📚 Llevas 3 o más días sin estudiar.\n\n" +
                   $"Te recomendamos iniciar una sesión de estudio de al menos 30 minutos " +
                   $"en la materia: {nombreMateria} (Prioridad: {prioridad}).\n\n" +
                   $"¡Retomar el hábito hoy marcará la diferencia!";
        }
    }
}