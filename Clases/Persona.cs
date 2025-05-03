namespace ActividadIntegradoraNro1.Clases
{
    public record Persona(string DNI, string Nombre, string Apellido)
    {
        private readonly HashSet<Auto> Autos = [];
        public string DNI { get; set; } = DNI;
        public string Nombre { get; set; } = Nombre;
        public string Apellido { get; set; } = Apellido;

        public ISet<Auto> Lista_De_Autos() => Autos;

        public uint Cantidad_De_Autos() => (uint)Autos.Count;

        public override int GetHashCode() => DNI.GetHashCode();

        ~Persona()
        {
            MessageBox.Show($"La Persona con DNI {DNI} ha sido eliminada!");
        }
    }
}
