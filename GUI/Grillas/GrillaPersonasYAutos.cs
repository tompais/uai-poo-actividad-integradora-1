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

                if (EsPersonaUnicaEnLista(persona))
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

        private bool EsPersonaUnicaEnLista(Persona persona) => Personas.All(p => p.DNI != persona.DNI);

        private void AgregarPersonaAGrilla(Persona persona) => grillaPersonas.Rows.Add(persona.DNI, persona.Nombre, persona.Apellido, persona.Cantidad_De_Autos());

        private bool AgregarPersonaALaLista(in Persona persona) => Personas.Add(persona);

        private void BotonAgregarAuto_Click(object sender, EventArgs e)
        {
            var formularioAgregarAuto = new FormularioAgregarAuto();
            if (formularioAgregarAuto.ShowDialog() == DialogResult.OK)
            {
                var auto = formularioAgregarAuto.Auto;

                if (EsAutoUnicoEnLista(auto))
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

        private bool EsAutoUnicoEnLista(Auto auto) => Autos.All(a => a.Patente != auto.Patente);

        private void AgregarAutoAGrilla(Auto auto) => grillaAutos.Rows.Add(auto.Patente, auto.Marca, auto.Modelo, auto.Año, auto.Precio);

        private bool AgregarAutoALaLista(in Auto auto) => Autos.Add(auto);

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

        private void ActualizarGrillaAutosDePersona()
        {
            if (GrillaPersonasTieneFilasSeleccionadas())
            {
                var autos = ObtenerAutosDePersonaSeleccionada();

                grillaAutosDePersona.Rows.Clear();

                foreach (var auto in autos)
                {
                    ActualizarGrillaAutosDePersona(auto);
                }
            }
            else
            {
                grillaAutosDePersona.Rows.Clear();
            }
        }

        private ISet<Auto> ObtenerAutosDePersonaSeleccionada() => ObtenerPersonaDeFilaSeleccionada().Lista_De_Autos();

        private void ActualizarEstadoBotonEliminarAuto() => botonEliminarAuto.Enabled = GrillaAutosTieneFilasSeleccionadas();

        private void ActualizarEstadoBotonEliminarPersona() => botonEliminarPersona.Enabled = GrillaPersonasTieneFilasSeleccionadas();

        private void BotonEliminarAuto_Click(object sender, EventArgs e)
        {
            if (GrillaAutosTieneFilasSeleccionadas())
            {
                EliminarDueñoDeAuto();
                EliminarAutoDeLista();
                EliminarAutoDeGrilla();
                ActualizarGrillaPersonas();
                ActualizarGrillaAutosDePersona();
                ActualizarEstadoBotonEliminarAuto();
                ActualizarEstadoBotonAsignarAutoAPersona();
                GC.WaitForPendingFinalizers();
                GC.Collect();

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún auto.");
            }
        }

        private void EliminarDueñoDeAuto() => EliminarDueñoDeAuto(ObtenerAutoDeFilaSeleccionada());

        private void EliminarAutoDeLista()
        {
            var patente = ObtenerPatenteDeFilaSeleccionada();
            Autos.RemoveWhere(a => a.Patente == patente);
        }

        private void EliminarAutoDeGrilla() => grillaAutos.Rows.Remove(ObtenerFilaSeleccionadaDeGrillaAutos());

        private void GrillaPersonas_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarGrillaAutosDePersona();
            ActualizarEstadoBotonAsignarAutoAPersona();
            ActualizarEstadoBotonEliminarPersona();
            ActualizarEstadoBotonModificarPersona();
        }

        private void ActualizarEstadoBotonModificarPersona() => botonModificarPersona.Enabled = GrillaPersonasTieneFilasSeleccionadas();

        private void GrillaAutos_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonAsignarAutoAPersona();
            ActualizarEstadoBotonEliminarAuto();
            ActualizarEstadoBotonModificarAuto();
        }

        private void ActualizarEstadoBotonModificarAuto() => botonModificarAuto.Enabled = GrillaAutosTieneFilasSeleccionadas();

        private void BotonEliminarPersona_Click(object sender, EventArgs e)
        {
            if (GrillaPersonasTieneFilasSeleccionadas())
            {
                QuitarAutosDePersona();
                EliminarPersonaDeLista();
                EliminarPersonaDeGrilla();
                ActualizarGrillaAutosDePersona();
                ActualizarEstadoBotonEliminarPersona();
                ActualizarEstadoBotonAsignarAutoAPersona();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna persona.");
            }
        }

        private void EliminarPersonaDeGrilla()
        {
            grillaPersonas.Rows.Remove(ObtenerFilaSeleccionadaDeGrillaPersonas());
        }

        private void EliminarPersonaDeLista()
        {
            var dni = ObtenerDniDeFilaSeleccionada();
            Personas.RemoveWhere(p => p.DNI == dni);
        }

        private void QuitarAutosDePersona()
        {
            var autos = ObtenerPersonaDeFilaSeleccionada().Lista_De_Autos();
            foreach (var auto in autos)
            {
                EliminarDueñoDeAuto(in auto);
            }
        }

        private void BotonModificarAuto_Click(object sender, EventArgs e)
        {
            if (GrillaAutosTieneFilasSeleccionadas())
            {
                var auto = ObtenerAutoDeFilaSeleccionada();
                var formularioModificarAuto = new FormularioModificarAuto(in auto);
                if (formularioModificarAuto.ShowDialog() == DialogResult.OK)
                {
                    var autoModificado = formularioModificarAuto.Auto;
                    ActualizarAutoDeLista(in autoModificado);
                    ActualizarGrillaAutos();
                    ActualizarGrillaAutosDePersona();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún auto.");
            }
        }

        private void ActualizarGrillaAutos()
        {
            grillaAutos.Rows.Clear();
            foreach (var auto in Autos)
            {
                AgregarAutoAGrilla(auto);
            }
        }

        private void ActualizarAutoDeLista(in Auto autoModificado)
        {
            var auto = ObtenerAutoDeFilaSeleccionada();
            if (Autos.Remove(auto))
            {
                Autos.Add(autoModificado);
                MessageBox.Show($"El auto con patente {auto.Patente} ha sido modificado.");
            }
            else
            {
                MessageBox.Show($"No se pudo modificar el auto con patente {auto.Patente}.");
            }
        }

        private void BotonModificarPersona_Click(object sender, EventArgs e)
        {
            if (GrillaPersonasTieneFilasSeleccionadas())
            {
                var persona = ObtenerPersonaDeFilaSeleccionada();
                var formularioModificarPersona = new FormularioModificarPersona(in persona);
                if (formularioModificarPersona.ShowDialog() == DialogResult.OK)
                {
                    var personaModificada = formularioModificarPersona.Persona;
                    ActualizarPersonaDeLista(in personaModificada);
                    ActualizarGrillaPersonas();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna persona.");
            }
        }

        private void ActualizarPersonaDeLista(in Persona personaModificada)
        {
            var persona = ObtenerPersonaDeFilaSeleccionada();
            if (Personas.Remove(persona))
            {
                Personas.Add(personaModificada);
                MessageBox.Show($"La persona con DNI {persona.DNI} ha sido modificada.");
            }
            else
            {
                MessageBox.Show($"No se pudo modificar la persona con DNI {persona.DNI}.");
            }
        }
    }
}
