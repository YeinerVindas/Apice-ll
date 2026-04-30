using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_Estudiante
    {
        private int _ID;
        private string _Nombre;
        private string _Correo;
        private string _Contrasena;
        private DateTime _FechaConexion;
        private int _RachaActual;


        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
        public DateTime FechaConexion { get => _FechaConexion; set => _FechaConexion = value; }
        public int RachaActual { get => _RachaActual; set => _RachaActual = value; }
    }
}
