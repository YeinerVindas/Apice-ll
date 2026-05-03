namespace ET
{
    public class ET_Kanban
    {
        private int _ID;
        private int _ID_Estudiante;
        private string _titulo;
        private string _descripcion;
        private string _estado;
        private DateTime _fechaEntrega;
        private DateTime _fechaCreacion;
        private int _diasRestantes;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_Estudiante { get => _ID_Estudiante; set => _ID_Estudiante = value; }
        public string titulo { get => _titulo; set => _titulo = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public string estado { get => _estado; set => _estado = value; }
        public DateTime fechaEntrega { get => _fechaEntrega; set => _fechaEntrega = value; }
        public DateTime fechaCreacion { get => _fechaCreacion; set => _fechaCreacion = value; }
        public int diasRestantes { get => _diasRestantes; set => _diasRestantes = value; }
    }
}