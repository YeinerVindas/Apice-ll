using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ET;
using Utilities;

namespace DAL
{
    public class DAL_Materia : DAL_utilities
    {
        #region Métodos de Listado

        public DataTable ListarMaterias(string cTexto, int idEstudiante)
        {
            // Utilizamos el método Listado de la clase base (DAL_utilities)
            return Listado(cTexto, "USP_ListarMaterias", idEstudiante);
        }

        #endregion

        #region Métodos de Escritura (Guardar/Eliminar)

        public string GuardarMateria(int nOpcion, ET_Materia oPropiedad)
        {
            string rpta = "";
            try
            {

                SqlParameter[] parametros =
                {
                    new SqlParameter("@nOpcion", SqlDbType.Int) { Value = nOpcion },
                    new SqlParameter("@ID", SqlDbType.Int) { Value = oPropiedad.ID },
                    new SqlParameter("@ID_Estudiante", SqlDbType.Int) { Value = oPropiedad.ID_Estudiante },
                    new SqlParameter("@nombre", SqlDbType.VarChar, 50) { Value = oPropiedad.nombre },
                    new SqlParameter("@horaInicio", SqlDbType.VarChar, 50) { Value = oPropiedad.horaInicio },
                    new SqlParameter("@horaFinal", SqlDbType.VarChar, 50) { Value = oPropiedad.horaFinal },
                    new SqlParameter("@prioridad", SqlDbType.VarChar, 50) { Value = oPropiedad.prioridad },
                    new SqlParameter("@diaSemana", SqlDbType.VarChar, 50) { Value = oPropiedad.diaSemana },
                    new SqlParameter("@estado", SqlDbType.Bit) { Value = oPropiedad.estado },
                    new SqlParameter("@notaMinima", SqlDbType.Decimal) { Value = (object)oPropiedad.notaMinima ?? DBNull.Value, Precision = 5, Scale = 2 }
                };

                // Llamamos al método protegido Guardar de la clase base
                rpta = Guardar("USP_GuardarMateria", parametros);
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string EliminarMateria(int idMateria)
        {
            // Preparamos el parámetro para la eliminación
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = idMateria }
            };

            // Llamamos al método protegido Eliminar de la clase base
            return Eliminar("USP_EliminarMateria", parametros);
        }

        #endregion
    }
}