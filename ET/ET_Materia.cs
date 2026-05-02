namespace ET
{
    public class ET_Materia
    {
        private int _IdMateria;
        private int _IdEstudiante;
        private string _Nombre;
        private string horaInicio;
        private string horaFinal;
        private string diaSemana;
        private string _Prioridad;
        private bool _estado;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string HoraFinal { get => horaFinal; set => horaFinal = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public string Prioridad { get => _Prioridad; set => _Prioridad = value; }
        public int IdMateria { get => _IdMateria; set => _IdMateria = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        public int IdEstudiante { get => _IdEstudiante; set => _IdEstudiante = value; }
    }
}
