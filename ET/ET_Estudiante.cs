namespace ET
{
    public class ET_Estudiante
    {
        private int _ID;
        private string _nombre;
        private string _correo;
        private string _contrasena;
        private string _fechaConexion;
        private int? _rachaActual;

        // Propiedades Públicas (Encapsulación)
        public int ID { get => _ID; set => _ID = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string correo { get => _correo; set => _correo = value; }
        public string contrasena { get => _contrasena; set => _contrasena = value; }
        public string fechaConexion { get => _fechaConexion; set => _fechaConexion = value; }

        public int? rachaActual
        {
            get => _rachaActual;
            set => _rachaActual = (value < 0) ? 0 : value;
        }
    }
}
