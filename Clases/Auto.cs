using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadIntegradoraNro1.Clases
{
    public record Auto(string Patente, string Marca, string Modelo, string Año, decimal Precio)
    {
        private readonly Persona? _dueño = null;

        public Persona? Dueño() => _dueño;

        ~Auto()
        {
            MessageBox.Show($"El auto con patente {Patente} ha sido eliminado!");
        }
    }
}
