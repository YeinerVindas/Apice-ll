using System;
using System.Data;
using ET;
using DAL;
using System.Collections.Generic;

namespace BL
{
    public class BL_SesionEstudio
    {
        private readonly DAL_SesionEstudio oDAL = new DAL_SesionEstudio();

        #region 🔹 Métodos de Listado
        public DataTable ListadoSesiones(string ctexto, int idEstudiante)
        {
            return oDAL.ListadoSesiones(ctexto.Trim(), idEstudiante);
        }
        #endregion

        #region 🔹 Gestión de Sesiones (Reglas de Negocio)

        public string GuardarSesion(int nOpcion, ET_SesionEstudio sesion)
        {
            // --- REGLA 3: Recordatorio de descanso nocturno ---
            // Se dispara al intentar registrar o iniciar una sesión
            int horaActual = DateTime.Now.Hour;
            if (horaActual >= 22 || horaActual < 5)
            {
                // Solo enviamos el mensaje, pero permitimos el flujo según la regla
                // En la GUI podrías usar un MessageBox.Show() con este retorno
                return "RECORDATORIO: Es tarde (rango 22:00 - 5:00). Prioriza tu descanso nocturno.";
            }

            // Validaciones básicas de integridad
            if (sesion.Duracion <= 0) return "La duración debe ser mayor a 0.";
            if (sesion.ID_Estudiante <= 0) return "ID de estudiante no válido.";

            return oDAL.GuardarSesion(nOpcion, sesion);
        }

        /// <summary>
        /// --- REGLA 2: Alerta de inactividad prolongada ---
        /// Se dispara en el Login. Verifica si han pasado 3 o más días.
        /// </summary>
        public string VerificarInactividad(int idEstudiante, DateTime ultimaConexion)
        {
            TimeSpan diferencia = DateTime.Now - ultimaConexion;

            if (diferencia.TotalDays >= 3)
            {
                // Aquí llamarías a un método de la DAL que busque la materia con menos sesiones
                // Por ahora devolvemos el mensaje sugerido
                return "ALERTA: Has estado inactivo por más de 3 días. " +
                       "Te sugerimos una sesión de 30 minutos en la materia con menos progreso.";
            }

            return "OK";
        }

        /// <summary>
        /// --- REGLA 1: Reposición dinámica ---
        /// Busca sesiones omitidas y sugiere reprogramación.
        /// </summary>
        public string ReprogramarSesionOmitida(ET_SesionEstudio sesionOmitida)
        {
            // 1. Verificar si fue completada según la hora local
            if (!sesionOmitida.Completada && sesionOmitida.Fecha < DateTime.Now)
            {
                // 2. Lógica de búsqueda de espacio (Simulada)
                // Aquí podrías consultar a la DAL por el próximo hueco libre en el horario
                bool hayEspacioDisponible = false; // Resultado de consulta DAL

                if (hayEspacioDisponible)
                {
                    // Lógica para cambiar la fecha de la sesión al nuevo hueco
                    sesionOmitida.Fecha = DateTime.Now.AddHours(2); // Ejemplo
                    oDAL.GuardarSesion(2, sesionOmitida); // 2 = Editar
                    return "Sesión reprogramada automáticamente.";
                }
                else
                {
                    return "No se encontró espacio disponible. Por favor, realice la reposición manualmente.";
                }
            }
            return "Sesión al día.";
        }

        #endregion
    }
}