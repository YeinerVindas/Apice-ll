namespace ET
{
    public class ET_Disponibilidad
    {
        private int _ID;
        private int _ID_Estudiante;
        private int _ID_Materia;
        private string _diaSemana;
        private TimeSpan _horaInicio;
        private TimeSpan _horaFinal;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public int ID_Materia { get => _ID_Materia; set => _ID_Materia = value; }
        public string diaSemana { get => _diaSemana; set => _diaSemana = value; }
        public TimeSpan horaInicio { get => _horaInicio; set => _horaInicio = value; }
        public TimeSpan horaFinal { get => _horaFinal; set => _horaFinal = value; }
    }
}
