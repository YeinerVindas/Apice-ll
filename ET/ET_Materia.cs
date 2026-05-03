namespace ET
{
    public class ET_Materia
    {
        private int _ID;
        private int _ID_Estudiante;
        private string _nombre;
        private string _horaInicio;
        private string _horaFinal;
        private string _prioridad;
        private string _diaSemana;
        private bool _estado;
        private decimal? _notaMinima;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string horaInicio { get => _horaInicio; set => _horaInicio = value; }
        public string horaFinal { get => _horaFinal; set => _horaFinal = value; }
        public string prioridad { get => _prioridad; set => _prioridad = value; }
        public string diaSemana { get => _diaSemana; set => _diaSemana = value; }
        public bool estado { get => _estado; set => _estado = value; }
        public decimal? notaMinima { get => _notaMinima; set => _notaMinima = value; }


    }
}
