using ActividadIntegradoraNro1.GUI;
using ActividadIntegradoraNro1.GUI.Formularios;

namespace ActividadIntegradoraNro1
{
    public partial class GrillaPersonasYAutos : Form
    {
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
                grillaPersonas.Rows.Add(persona.DNI, persona.Nombre, persona.Apellido, persona.Cantidad_De_Autos());
            }
        }

        private void botonAgregarAuto_Click(object sender, EventArgs e)
        {
            var formularioAgregarAuto = new FormularioAgregarAuto();
            if(formularioAgregarAuto.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
