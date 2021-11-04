namespace BancoTheBanco.Clases
{
    class administrador
    {
        private string nombre;
        private string apellido;
        private string rut;
        private string tipo;

        public administrador(string nombre, string apellido, string rut, string tipo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
