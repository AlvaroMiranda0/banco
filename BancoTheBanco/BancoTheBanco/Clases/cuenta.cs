namespace BancoTheBanco.Clases
{
    class cuenta
    {
        private string rut;
        private int contraseña;
        private int saldo;
        private int id_cuente;
        private int deuda;

        public cuenta(string rut, int contraseña, int saldo, int id_cuente)
        {
            this.rut = rut;
            this.contraseña = contraseña;
            this.saldo = saldo;
            this.id_cuente = id_cuente;
        }

        public cuenta(string rut, int contraseña, int saldo, int id_cuente, int deuda)
        {
            this.rut = rut;
            this.contraseña = contraseña;
            this.saldo = saldo;
            this.id_cuente = id_cuente;
            this.deuda = deuda;
        }

        public string Rut { get => rut; set => rut = value; }
        public int Contraseña { get => contraseña; set => contraseña = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public int Id_cuente { get => id_cuente; set => id_cuente = value; }
        public int Deuda { get => deuda; set => deuda = value; }
    }
}
