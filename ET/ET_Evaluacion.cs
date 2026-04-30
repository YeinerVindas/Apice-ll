using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_Evaluacion
    {
        private int _ID;
        private int _ID_Materia;
        private int _ID_Estudiante;
        private string _NombreRubro;
        private decimal _ValorPorcentual;
        private decimal _CalificacionObtenida;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Materia { get => _ID_Materia; set => _ID_Materia = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public string NombreRubro { get => _NombreRubro; set => _NombreRubro = value; }
        public decimal ValorPorcentual { get => _ValorPorcentual; set => _ValorPorcentual = value; }
        public decimal CalificacionObtenida { get => _CalificacionObtenida; set => _CalificacionObtenida = value; }
    }
}
