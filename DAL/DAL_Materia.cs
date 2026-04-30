using ET;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Utilities;

namespace DAL
{
    public class DAL_Materia : DAL_utilities
    {
        #region 🔹 Listados por Día

        public DataTable ListadoMateriaLunes(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_materias_lunes", IdEstudiate_Materia);
        }

        public DataTable ListadoMateriaMartes(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_materias_martes", IdEstudiate_Materia);
        }

        public DataTable ListadoMateriaMiercoles(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_materias_miercoles", IdEstudiate_Materia);
        }

        public DataTable ListadoMateriaJueves(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_materias_jueves", IdEstudiate_Materia);
        }

        public DataTable ListadoMateriaViernes(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_materias_viernes", IdEstudiate_Materia);
        }

        public DataTable ListadoMateriaSabado(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_materias_sabado", IdEstudiate_Materia);
        }

        public DataTable ListadoMateriaDomingo(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_materias_domingo", IdEstudiate_Materia);
        }

        #endregion

        #region 🔹 Gestión de Materias

        public DataTable ListadoGestionMaterias(string cTexto, int IdEstudiate_Materia)
        {
            return Listado(cTexto, "USP_Listado_GestionarMateria", IdEstudiate_Materia);
        }

        public string GuardarMT(int nOpcion, ET_Materia mt)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@nOpcion", SqlDbType.Int) { Value = nOpcion },
                new SqlParameter("@ID_materia", SqlDbType.Int) { Value = mt.ID },
                new SqlParameter("@ID_Estudiante", SqlDbType.Int) { Value = mt.ID_Estudiante },
                new SqlParameter("@Nombre", SqlDbType.VarChar) { Value = mt.Nombre },
                new SqlParameter("@HoraInicio", SqlDbType.VarChar) { Value = mt.HoraInicio },
                new SqlParameter("@HoraFinal", SqlDbType.VarChar) { Value = mt.HoraFinal },
                new SqlParameter("@Prioridad", SqlDbType.VarChar) { Value = mt.Prioridad },
                new SqlParameter("@DiaSemana", SqlDbType.VarChar) { Value = mt.DiaSemana }
            };

            return Guardar("USP_Guardar_Materia", parametros);
        }

        public string EliminarMT(int IdMateria)
        {
            SqlParameter[] parametros = {
                new SqlParameter("@nIdMateria", SqlDbType.Int) { Value = IdMateria }
            };

            return Guardar("USP_Eliminar_mt", parametros);
        }

        #endregion
    }
}