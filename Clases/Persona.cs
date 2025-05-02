namespace ActividadIntegradoraNro1.Clases
{
    public record Persona(string DNI, string Nombre, string Apellido)
    {
        private readonly HashSet<Auto> Autos = [];

        public ISet<Auto> Lista_De_Autos() => Autos;

        public uint Cantidad_De_Autos() => (uint)Autos.Count;

        public override int GetHashCode() => DNI.GetHashCode();

        ~Persona()
        {
            MessageBox.Show($"La Persona con DNI {DNI} ha sido eliminada!");
        }
    }
}
