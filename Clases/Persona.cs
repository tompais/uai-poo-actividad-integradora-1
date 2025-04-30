using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradoraNro1.Clases
{
    public record Persona(string DNI, string Nombre, string Apellido)
    {
        private readonly List<Auto> Autos = [];

        public List<Auto> Lista_De_Autos() => Autos;

        public uint Cantidad_De_Autos() => (uint)Autos.Count;

        ~Persona()
        {
            MessageBox.Show($"La Persona con DNI {DNI} ha sido eliminada!");
        }
    }
}
