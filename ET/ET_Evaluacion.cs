namespace ET
{
    public class ET_Evaluacion
    {
        private int _ID;
        private int _ID_Materia;
        private int _ID_Estudiante;
        private string _nombre;
        private decimal _porcentaje;
        private decimal? _nota;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Materia { get => _ID_Materia; set => _ID_Materia = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public decimal porcentaje { get => _porcentaje; set => _porcentaje = value; }
        public decimal? nota { get => _nota; set => _nota = value; }
    }
}