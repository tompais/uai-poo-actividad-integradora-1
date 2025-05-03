namespace ActividadIntegradoraNro1.Clases
{
    public record Auto(string Patente, string Marca, string Modelo, string Año, decimal Precio)
    {
        public string Patente { get; set; } = Patente;
        public string Marca { get; set; } = Marca;
        public string Modelo { get; set; } = Modelo;
        public string Año { get; set; } = Año;
        public decimal Precio { get; set; } = Precio;
        public Persona? Dueño { get; set; } = null;

        public override int GetHashCode() => Patente.GetHashCode();

        ~Auto()
        {
            MessageBox.Show($"El auto con patente {Patente} ha sido eliminado!");
        }
    }
}
