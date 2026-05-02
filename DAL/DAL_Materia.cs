using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ET;
using Utilities;

namespace DAL
{
    public class DAL_Materia : DAL_utilities
    {
        // Método unificado que reemplaza a los 7 anteriores
        public DataTable ListarMaterias(int idEstudiante, string dia = "Todos", string filtro = "")
        {
            // Usamos el nuevo SP único
            // Nota: Aquí 'Listado' ya usa el parámetro 'idEstudiante' corregido

            // Si necesitas pasar el parámetro @DiaSemana a través de la utilidad Listado, 
            // podrías necesitar una sobrecarga o usar el método 'Comprobar' que acepta parámetros libres.

            SqlParameter[] parametros = {
                new SqlParameter("@cTexto", filtro),
                new SqlParameter("@idEstudiante", idEstudiante),
                new SqlParameter("@DiaSemana", dia)
            };

            return this.Comprobar("USP_Listado_Materias_Por_Filtro", parametros);
        }

        public string GuardarMateria(ET_Materia mt, int opcion)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@nOpcion", opcion),
                new SqlParameter("@IdMateria", mt.IdMateria),
                new SqlParameter("@idEstudiante", mt.IdEstudiante), // Nombre corregido
                new SqlParameter("@Nombre", mt.Nombre),
                new SqlParameter("@HoraInicio", mt.HoraInicio),
                new SqlParameter("@HoraFinal", mt.HoraFinal),
                new SqlParameter("@Prioridad", mt.Prioridad),
                new SqlParameter("@DiaSemana", mt.DiaSemana)
            };

            return this.Guardar("USP_Guardar_Materia", parametros);
        }
    }
}