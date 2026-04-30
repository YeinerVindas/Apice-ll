using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_Kanban
    {
        private int _ID;
        private int _ID_Estudiante;
        private int _ID_Materia;
        private string _Descripcion;
        private DateTime _FechaEntrega;
        private string _Dificultad;
        private string _Estado;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public int ID_Materia { get => _ID_Materia; set => _ID_Materia = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public DateTime FechaEntrega { get => _FechaEntrega; set => _FechaEntrega = value; }
        public string Dificultad { get => _Dificultad; set => _Dificultad = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
    }
}
