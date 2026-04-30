using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_SesionEstudio
    {
        private int _ID;
        private int _ID_Estudiante;
        private DateTime _Fecha;
        private int _Duracion;
        private bool _Completada;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int Duracion { get => _Duracion; set => _Duracion = value; }
        public bool Completada { get => _Completada; set => _Completada = value; }
    }
}
