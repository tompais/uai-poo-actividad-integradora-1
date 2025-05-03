using ActividadIntegradoraNro1.Clases;
using ActividadIntegradoraNro1.Utilidades;

namespace ActividadIntegradoraNro1.GUI.Formularios
{
    public partial class FormularioModificarAuto : Form
    {
        public Auto Auto { get; set; }

        public FormularioModificarAuto(in Auto auto)
        {
            InitializeComponent();
            CargarDatosAuto(in auto);
        }

        private void CargarDatosAuto(in Auto auto)
        {
            campoTextoPatente.Text = auto.Patente;
            campoDeTextoMarca.Text = auto.Marca;
            campoDeTextoModelo.Text = auto.Modelo;
            campoTextoAño.Text = auto.Año;
            campoNumericoPrecio.Value = auto.Precio;
            Auto = auto;
        }

        private void FormularioModificarAuto_Load(object sender, EventArgs e)
        {
            campoNumericoPrecio.Controls[0].Visible = false;
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            botonModificar.Enabled = ValidarCampoDeTextoPatente() && ValidarCampoDeTextoMarca() && ValidarCampoDeTextoModelo() && ValidarCampoDeTextoAño() && ValidarCampoNumericoPrecio();
        }

        private bool ValidarCampoNumericoPrecio()
        {
            var precio = campoNumericoPrecio.Value;

            return precio >= 5000000 && precio <= 100000000;
        }

        private bool ValidarCampoDeTextoModelo()
        {
            var modelo = campoDeTextoModelo.Text.Trim();

            return !string.IsNullOrWhiteSpace(modelo) && modelo.Length >= 2 && modelo.Length <= 50 && modelo.TieneLetrasYNumerosConEspacios();
        }

        private bool ValidarCampoDeTextoMarca()
        {
            var marca = campoDeTextoMarca.Text.Trim();

            return !string.IsNullOrWhiteSpace(marca) && marca.Length >= 2 && marca.Length <= 50 && marca.TieneLetrasYNumerosConEspacios();
        }

        private bool ValidarCampoDeTextoAño()
        {
            var año = campoTextoAño.Text.Trim();

            return año.Length == 4 && uint.TryParse(año, out uint añoNumerico) && añoNumerico <= DateTime.Now.Year;
        }

        private bool ValidarCampoDeTextoPatente() => campoTextoPatente.Text.Trim().TieneFormatoDePatenteArgentinaValida();

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Auto.Patente = campoTextoPatente.Text;
            Auto.Marca = campoDeTextoMarca.Text;
            Auto.Modelo = campoDeTextoModelo.Text;
            Auto.Año = campoTextoAño.Text;
            Auto.Precio = campoNumericoPrecio.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
