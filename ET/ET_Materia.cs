namespace ET
{
    public class ET_Materia
    {
        private int _ID;
        private int _ID_Estudiante;
        private string _Nombre;
        private string horaInicio;
        private string horaFinal;
        private string diaSemana;
        private string _Prioridad;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string HoraFinal { get => horaFinal; set => horaFinal = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public string Prioridad { get => _Prioridad; set => _Prioridad = value; }
    }
}
