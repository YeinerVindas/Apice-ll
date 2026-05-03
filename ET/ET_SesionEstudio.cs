namespace ET
{
    public class ET_SesionEstudio
    {
        private int _ID;
        private int _ID_Estudiante;
        private int _ID_Materia;
        private string _fecha;
        private int _duracion;
        private int _cantidadBloques;
        private bool _completada;
        private string _estado;
        public int ID { get => _ID; set => _ID = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public int ID_Materia { get => _ID_Materia; set => _ID_Materia = value; }
        public string fecha { get => _fecha; set => _fecha = value; }
        public int duracion { get => _duracion; set => _duracion = value; }
        public int cantidadBloques { get => _cantidadBloques; set => _cantidadBloques = value; }
        public bool completada { get => _completada; set => _completada = value; }
        public string estado { get => _estado; set => _estado = value; }
    }
}
