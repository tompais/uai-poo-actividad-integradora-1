using ActividadIntegradoraNro1.Clases;
using ActividadIntegradoraNro1.GUI;
using ActividadIntegradoraNro1.GUI.Formularios;

namespace ActividadIntegradoraNro1
{
    public partial class GrillaPersonasYAutos : Form
    {
        private HashSet<Persona> Personas { get; set; } = [];
        private HashSet<Auto> Autos { get; set; } = [];

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

                if (Personas.All(p => p.DNI != persona.DNI))
                {
                    AgregarPersonaALaLista(in persona);
                    AgregarPersonaAGrilla(persona);
                }
                else
                {
                    MessageBox.Show($"Ya existe una persona con el DNI {persona.DNI}.");
                }


            }
        }

        private void AgregarPersonaAGrilla(Persona persona) => grillaPersonas.Rows.Add(persona.DNI, persona.Nombre, persona.Apellido, persona.Cantidad_De_Autos());

        private bool AgregarPersonaALaLista(in Persona persona) => Personas.Add(persona);

        private void BotonAgregarAuto_Click(object sender, EventArgs e)
        {
            var formularioAgregarAuto = new FormularioAgregarAuto();
            if (formularioAgregarAuto.ShowDialog() == DialogResult.OK)
            {
                var auto = formularioAgregarAuto.Auto;

                if (Autos.All(a => a.Patente != auto.Patente))
                {
                    AgregarAutoALaLista(in auto);
                    AgregarAutoAGrilla(auto);
                }
                else
                {
                    MessageBox.Show($"Ya existe un auto con la patente {auto.Patente}.");
                }
            }
        }

        private void AgregarAutoAGrilla(Auto auto) => grillaAutos.Rows.Add(auto.Patente, auto.Marca, auto.Modelo, auto.Año, auto.Precio);

        private bool AgregarAutoALaLista(in Auto auto) => Autos.Add(auto);

        private void VerificarSiAsignacionDeAutoAPersonaEsPosible(object sender, EventArgs e) => ActualizarEstadoBotonAsignarAutoAPersona();

        private void ActualizarEstadoBotonAsignarAutoAPersona() => botonAsignarAutoAPersona.Enabled = GrillaPersonasTieneFilasSeleccionadas() && GrillaAutosTieneFilasSeleccionadas() && PersonaNoEsDueñoDelAutoSeleccionado();

        private bool PersonaNoEsDueñoDelAutoSeleccionado()
        {
            var auto = ObtenerAutoDeFilaSeleccionada();
            var persona = ObtenerPersonaDeFilaSeleccionada();

            return PersonaNoEsDueñoDelAutoSeleccionado(auto, persona);
        }

        private bool GrillaAutosTieneFilasSeleccionadas() => grillaAutos.SelectedRows.Count > 0;

        private bool GrillaPersonasTieneFilasSeleccionadas() => grillaPersonas.SelectedRows.Count > 0;

        private void BotonAsignarAutoAPersona_Click(object sender, EventArgs e)
        {
            var auto = ObtenerAutoDeFilaSeleccionada();
            var persona = ObtenerPersonaDeFilaSeleccionada();

            if (PersonaNoEsDueñoDelAutoSeleccionado(auto, persona))
            {
                EliminarDueñoDeAuto(in auto);
                AsignarAutoAPersona(in auto, in persona);
                AsignarDueñoAlAuto(in auto, in persona);
                ActualizarGrillaAutosDePersona(auto);
                ActualizarGrillaPersonas();
                ActualizarEstadoBotonAsignarAutoAPersona();
            }
            else
            {
                MessageBox.Show("La persona ya es dueña del auto seleccionado.");
            }
        }

        private void ActualizarGrillaPersonas()
        {
            grillaPersonas.Rows.Clear();

            foreach (var persona in Personas)
            {
                AgregarPersonaAGrilla(persona);
            }
        }

        private static void EliminarDueñoDeAuto(in Auto auto)
        {
            if (auto.Dueño != null)
            {
                if (auto.Dueño.Lista_De_Autos().Remove(auto))
                {
                    MessageBox.Show($"El auto con patente {auto.Patente} ha sido eliminado de la lista de autos de {auto.Dueño.Nombre} {auto.Dueño.Apellido}.");
                }
                else
                {
                    MessageBox.Show($"No se pudo eliminar el auto con patente {auto.Patente} de la lista de autos de {auto.Dueño.Nombre} {auto.Dueño.Apellido}.");
                }
                auto.Dueño = null;
            }
        }

        private static bool PersonaNoEsDueñoDelAutoSeleccionado(Auto auto, Persona persona) => auto.Dueño == null || auto.Dueño.DNI != persona.DNI;

        private void ActualizarGrillaAutosDePersona(Auto auto) => grillaAutosDePersona.Rows.Add(auto.Patente, auto.Marca, auto.Modelo, auto.Año, auto.Precio);

        private static void AsignarDueñoAlAuto(in Auto auto, in Persona persona) => auto.Dueño = persona;

        private static void AsignarAutoAPersona(in Auto auto, in Persona persona) => persona.Lista_De_Autos().Add(auto);

        private Persona ObtenerPersonaDeFilaSeleccionada()
        {
            var dni = ObtenerDniDeFilaSeleccionada();

            return Personas.First(p => p.DNI == dni);
        }

        private Auto ObtenerAutoDeFilaSeleccionada()
        {
            var patente = ObtenerPatenteDeFilaSeleccionada();

            return Autos.First(a => a.Patente == patente);
        }

        private string? ObtenerDniDeFilaSeleccionada() => ObtenerFilaSeleccionadaDeGrillaPersonas().Cells[0].Value.ToString();

        private string? ObtenerPatenteDeFilaSeleccionada() => ObtenerFilaSeleccionadaDeGrillaAutos().Cells[0].Value.ToString();

        private DataGridViewRow ObtenerFilaSeleccionadaDeGrillaPersonas() => grillaPersonas.SelectedRows[0];

        private DataGridViewRow ObtenerFilaSeleccionadaDeGrillaAutos() => grillaAutos.SelectedRows[0];

        private void MostrarAutosDePersona(object sender, EventArgs e)
        {
            if (GrillaPersonasTieneFilasSeleccionadas())
            {
                var autos = ObtenerAutosDePersonaSeleccionada();

                grillaAutosDePersona.Rows.Clear();

                foreach (var auto in autos)
                {
                    grillaAutosDePersona.Rows.Add(auto.Patente, auto.Marca, auto.Modelo, auto.Año, auto.Precio);
                }
            }
        }

        private ISet<Auto> ObtenerAutosDePersonaSeleccionada() => ObtenerPersonaDeFilaSeleccionada().Lista_De_Autos();
    }
}
