using ActividadIntegradoraNro1.Clases;
using ActividadIntegradoraNro1.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadIntegradoraNro1.GUI
{
    public partial class FormularioAgregarPersona : Form
    {
        public Persona Persona { get; set; }
        public FormularioAgregarPersona()
        {
            InitializeComponent();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            Persona = new Persona(
                campoTextoDNI.Text,
                campoTextoNombre.Text,
                campoTextoApellido.Text
                );
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
