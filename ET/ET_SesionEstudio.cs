using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_SesionEstudio
    {
        private int _ID;
        private DateTime _Fecha;
        private int _Duracion;
        private int _CantidadBloques;
        private string _Estado;
        private bool _Completada;
        private int _IdEstudiante;
        private int _IdMateria;

        public int ID { get => _ID; set => _ID = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int Duracion { get => _Duracion; set => _Duracion = value; }
        public int CantidadBloques { get => _CantidadBloques; set => _CantidadBloques = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public bool Completada { get => _Completada; set => _Completada = value; }
        public int IdEstudiante { get => _IdEstudiante; set => _IdEstudiante = value; }
        public int IdMateria { get => _IdMateria; set => _IdMateria = value; }
    }
}