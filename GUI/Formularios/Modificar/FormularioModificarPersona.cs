using ActividadIntegradoraNro1.Clases;
using ActividadIntegradoraNro1.Utilidades;

namespace ActividadIntegradoraNro1.GUI
{
    public partial class FormularioModificarPersona : Form
    {
        public Persona Persona { get; set; }
        public FormularioModificarPersona(Persona persona)
        {
            InitializeComponent();
            CargarDatosPersona(in persona);
        }

        private void CargarDatosPersona(Persona persona)
        {
            campoTextoDNI.Text = persona.DNI;
            campoTextoNombre.Text = persona.Nombre;
            campoTextoApellido.Text = persona.Apellido;
            Persona = persona;
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Persona.DNI = campoTextoDNI.Text;
            Persona.Nombre = campoTextoNombre.Text;
            Persona.Apellido = campoTextoApellido.Text;
            DialogResult = DialogResult.OK;
        }

        private void ValidarCampos(object sender, EventArgs e) => botonAgregar.Enabled = ValidarCampoDeTextoDNI() && ValidarCampoDeTextoNombre() && ValidarCampoDeTextoApellido();

        private bool ValidarCampoDeTextoApellido() => campoTextoApellido.Text.TieneSoloLetras();

        private bool ValidarCampoDeTextoNombre() => campoTextoNombre.Text.TieneSoloLetras();

        private bool ValidarCampoDeTextoDNI()
        {
            var dni = campoTextoDNI.Text;
            var largoDNI = dni.Length;

            return largoDNI >= 7 && largoDNI <= 8 && uint.TryParse(dni, out _);
        }
    }
}
