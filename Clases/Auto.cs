namespace ActividadIntegradoraNro1.Clases
{
    public record Auto(string Patente, string Marca, string Modelo, string Año, decimal Precio)
    {
        public Persona? Dueño { get; set; } = null;

        public override int GetHashCode() => Patente.GetHashCode();

        ~Auto()
        {
            MessageBox.Show($"El auto con patente {Patente} ha sido eliminado!");
        }
    }
}
