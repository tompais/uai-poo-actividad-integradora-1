using ActividadIntegradoraNro1.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadIntegradoraNro1.GUI.Formularios
{
    public partial class FormularioAgregarAuto : Form
    {
        public FormularioAgregarAuto()
        {
            InitializeComponent();
        }

        private void FormularioAgregarAuto_Load(object sender, EventArgs e) => campoNumericoPrecio.Controls[0].Visible = false;

        private void ValidarCampos(object sender, EventArgs e)
        {
            botonAgregar.Enabled = ValidarCampoDeTextoPatente() && ValidarCampoDeTextoAño();
        }

        private bool ValidarCampoDeTextoAño()
        {
            var año = campoTextoAño.Text;

            return año.Length == 4 && uint.TryParse(año, out _);
        }

        private bool ValidarCampoDeTextoPatente() => campoTextoPatente.Text.TieneFormatoDePatenteArgentinaValida();
    }
}
