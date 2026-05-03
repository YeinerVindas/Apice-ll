using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Utilities
{
    public class Conexion
    {
        //Atributos

        private string _Base;
        private string _Server;
        private bool _seguridad;
        private static Conexion Con = null;  // este atributo es la plantilla, que solo se instancia una vez en todo el uso del proyecto


        private Conexion()
        {
            this._Base = "ApiceY";
            this._Server = "(localdb)\\MSSQLLocalDB"; //esto se cambia dependiendo de la maquina en uso
            this._seguridad = true;
        }



        public SqlConnection CrearConexion()
        {


            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Server =" + this._Server + ";Database=" + this._Base + ";TrustServerCertificate=true;" + ";";
                if (_seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security=SSPI";
                }
                else
                {
                    //aca iria la conexion si fuese un error de bd
                }

            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;

        }


        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
