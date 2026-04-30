using System;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public class ET_Disponibilidad
    {
        private int _ID;
        private int _ID_Estudiante;
        private string _DiaSemana;
        private TimeSpan _HoraInicio;
        private TimeSpan _HoraFin;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public string DiaSemana { get => _DiaSemana; set => _DiaSemana = value; }
        public TimeSpan HoraInicio { get => _HoraInicio; set => _HoraInicio = value; }
        public TimeSpan HoraFin { get => _HoraFin; set => _HoraFin = value; }
    }
}
