using ActividadIntegradoraNro1.Clases;
using ActividadIntegradoraNro1.GUI;
using ActividadIntegradoraNro1.GUI.Formularios;

namespace ActividadIntegradoraNro1
{
    public partial class GrillaPersonasYAutos : Form
    {
        private List<Persona> Personas { get; set; } = [];
        private List<Auto> Autos { get; set; } = [];
        public GrillaPersonasYAutos()
        {
            InitializeComponent();
        }

        private void BotonAgregarPersona_Click(object sender, EventArgs e)
        {
            var formularioAgregarPersona = new FormularioAgregarPersona();
            if (formularioAgregarPersona.ShowDialog() == DialogResult.OK)
            {
                var persona = formularioAgregarPersona.Persona;
                AgregarPersonaALaLista(persona);
                AgregarPersonaAGrilla(persona);
            }
        }

        private void AgregarPersonaAGrilla(Persona persona) => grillaPersonas.Rows.Add(persona.DNI, persona.Nombre, persona.Apellido, persona.Cantidad_De_Autos());

        private void AgregarPersonaALaLista(Persona persona) => Personas.Add(persona);

        private void BotonAgregarAuto_Click(object sender, EventArgs e)
        {
            var formularioAgregarAuto = new FormularioAgregarAuto();
            if (formularioAgregarAuto.ShowDialog() == DialogResult.OK)
            {
                var auto = formularioAgregarAuto.Auto;
                AgregarAutoALaLista(auto);
                AgregarAutoAGrilla(auto);
            }
        }

        private void AgregarAutoAGrilla(Auto auto) => grillaAutos.Rows.Add(auto.Patente, auto.Marca, auto.Modelo, auto.Año, auto.Precio);

        private void AgregarAutoALaLista(Auto auto) => Autos.Add(auto);
    }
}
