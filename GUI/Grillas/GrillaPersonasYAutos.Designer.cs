namespace ActividadIntegradoraNro1
{
    partial class GrillaPersonasYAutos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grillaPersonas = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            CantAutos = new DataGridViewTextBoxColumn();
            etiquetaPersonas = new Label();
            botonAgregarPersona = new Button();
            etiquetaAutos = new Label();
            grillaAutos = new DataGridView();
            Patente = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            botonAgregarAuto = new Button();
            botonAsignarAutoAPersona = new Button();
            etiquetaAutosPersonaSeleccionada = new Label();
            grillaAutosDePersona = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            botonEliminarAuto = new Button();
            botonEliminarPersona = new Button();
            botonModificarAuto = new Button();
            botonModificarPersona = new Button();
            grillaAutosYDueños = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            etiquetaAutoYDueño = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAutosDePersona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAutosYDueños).BeginInit();
            SuspendLayout();
            // 
            // grillaPersonas
            // 
            grillaPersonas.AllowUserToAddRows = false;
            grillaPersonas.AllowUserToDeleteRows = false;
            grillaPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPersonas.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombre, Apellido, CantAutos });
            grillaPersonas.Location = new Point(12, 27);
            grillaPersonas.MultiSelect = false;
            grillaPersonas.Name = "grillaPersonas";
            grillaPersonas.ReadOnly = true;
            grillaPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPersonas.Size = new Size(443, 150);
            grillaPersonas.TabIndex = 0;
            grillaPersonas.SelectionChanged += GrillaPersonas_SelectionChanged;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MaxInputLength = 8;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // CantAutos
            // 
            CantAutos.HeaderText = "Cant. Autos";
            CantAutos.Name = "CantAutos";
            CantAutos.ReadOnly = true;
            // 
            // etiquetaPersonas
            // 
            etiquetaPersonas.AutoSize = true;
            etiquetaPersonas.Location = new Point(12, 9);
            etiquetaPersonas.Name = "etiquetaPersonas";
            etiquetaPersonas.Size = new Size(54, 15);
            etiquetaPersonas.TabIndex = 1;
            etiquetaPersonas.Text = "Personas";
            // 
            // botonAgregarPersona
            // 
            botonAgregarPersona.Location = new Point(12, 183);
            botonAgregarPersona.Name = "botonAgregarPersona";
            botonAgregarPersona.Size = new Size(110, 23);
            botonAgregarPersona.TabIndex = 2;
            botonAgregarPersona.Text = "Agregar Persona";
            botonAgregarPersona.UseVisualStyleBackColor = true;
            botonAgregarPersona.Click += BotonAgregarPersona_Click;
            // 
            // etiquetaAutos
            // 
            etiquetaAutos.AutoSize = true;
            etiquetaAutos.Location = new Point(12, 221);
            etiquetaAutos.Name = "etiquetaAutos";
            etiquetaAutos.Size = new Size(38, 15);
            etiquetaAutos.TabIndex = 4;
            etiquetaAutos.Text = "Autos";
            // 
            // grillaAutos
            // 
            grillaAutos.AllowUserToAddRows = false;
            grillaAutos.AllowUserToDeleteRows = false;
            grillaAutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAutos.Columns.AddRange(new DataGridViewColumn[] { Patente, Marca, Modelo, Año, Precio });
            grillaAutos.Location = new Point(12, 239);
            grillaAutos.MultiSelect = false;
            grillaAutos.Name = "grillaAutos";
            grillaAutos.ReadOnly = true;
            grillaAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaAutos.Size = new Size(443, 150);
            grillaAutos.TabIndex = 3;
            grillaAutos.SelectionChanged += GrillaAutos_SelectionChanged;
            // 
            // Patente
            // 
            Patente.HeaderText = "Patente";
            Patente.MaxInputLength = 7;
            Patente.Name = "Patente";
            Patente.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MaxInputLength = 50;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MaxInputLength = 50;
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // Año
            // 
            Año.HeaderText = "Año";
            Año.MaxInputLength = 4;
            Año.Name = "Año";
            Año.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // botonAgregarAuto
            // 
            botonAgregarAuto.Location = new Point(12, 395);
            botonAgregarAuto.Name = "botonAgregarAuto";
            botonAgregarAuto.Size = new Size(110, 23);
            botonAgregarAuto.TabIndex = 5;
            botonAgregarAuto.Text = "Agregar Auto";
            botonAgregarAuto.UseVisualStyleBackColor = true;
            botonAgregarAuto.Click += BotonAgregarAuto_Click;
            // 
            // botonAsignarAutoAPersona
            // 
            botonAsignarAutoAPersona.Enabled = false;
            botonAsignarAutoAPersona.Location = new Point(474, 183);
            botonAsignarAutoAPersona.Name = "botonAsignarAutoAPersona";
            botonAsignarAutoAPersona.Size = new Size(147, 23);
            botonAsignarAutoAPersona.TabIndex = 6;
            botonAsignarAutoAPersona.Text = "Asignar Auto a Persona";
            botonAsignarAutoAPersona.UseVisualStyleBackColor = true;
            botonAsignarAutoAPersona.Click += BotonAsignarAutoAPersona_Click;
            // 
            // etiquetaAutosPersonaSeleccionada
            // 
            etiquetaAutosPersonaSeleccionada.AutoSize = true;
            etiquetaAutosPersonaSeleccionada.Location = new Point(474, 9);
            etiquetaAutosPersonaSeleccionada.Name = "etiquetaAutosPersonaSeleccionada";
            etiquetaAutosPersonaSeleccionada.Size = new Size(171, 15);
            etiquetaAutosPersonaSeleccionada.TabIndex = 9;
            etiquetaAutosPersonaSeleccionada.Text = "Autos de Persona Seleccionada";
            // 
            // grillaAutosDePersona
            // 
            grillaAutosDePersona.AllowUserToAddRows = false;
            grillaAutosDePersona.AllowUserToDeleteRows = false;
            grillaAutosDePersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAutosDePersona.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            grillaAutosDePersona.Location = new Point(474, 27);
            grillaAutosDePersona.MultiSelect = false;
            grillaAutosDePersona.Name = "grillaAutosDePersona";
            grillaAutosDePersona.ReadOnly = true;
            grillaAutosDePersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaAutosDePersona.Size = new Size(443, 150);
            grillaAutosDePersona.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Patente";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Marca";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Año";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Precio";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // botonEliminarAuto
            // 
            botonEliminarAuto.Enabled = false;
            botonEliminarAuto.Location = new Point(254, 395);
            botonEliminarAuto.Name = "botonEliminarAuto";
            botonEliminarAuto.Size = new Size(110, 23);
            botonEliminarAuto.TabIndex = 11;
            botonEliminarAuto.Text = "Eliminar Auto";
            botonEliminarAuto.UseVisualStyleBackColor = true;
            botonEliminarAuto.Click += BotonEliminarAuto_Click;
            // 
            // botonEliminarPersona
            // 
            botonEliminarPersona.Enabled = false;
            botonEliminarPersona.Location = new Point(254, 183);
            botonEliminarPersona.Name = "botonEliminarPersona";
            botonEliminarPersona.Size = new Size(110, 23);
            botonEliminarPersona.TabIndex = 12;
            botonEliminarPersona.Text = "Eliminar Persona";
            botonEliminarPersona.UseVisualStyleBackColor = true;
            botonEliminarPersona.Click += BotonEliminarPersona_Click;
            // 
            // botonModificarAuto
            // 
            botonModificarAuto.Enabled = false;
            botonModificarAuto.Location = new Point(128, 395);
            botonModificarAuto.Name = "botonModificarAuto";
            botonModificarAuto.Size = new Size(120, 23);
            botonModificarAuto.TabIndex = 13;
            botonModificarAuto.Text = "Modificar Auto";
            botonModificarAuto.UseVisualStyleBackColor = true;
            botonModificarAuto.Click += BotonModificarAuto_Click;
            // 
            // botonModificarPersona
            // 
            botonModificarPersona.Enabled = false;
            botonModificarPersona.Location = new Point(128, 183);
            botonModificarPersona.Name = "botonModificarPersona";
            botonModificarPersona.Size = new Size(120, 23);
            botonModificarPersona.TabIndex = 14;
            botonModificarPersona.Text = "Modificar Persona";
            botonModificarPersona.UseVisualStyleBackColor = true;
            botonModificarPersona.Click += BotonModificarPersona_Click;
            // 
            // grillaAutosYDueños
            // 
            grillaAutosYDueños.AllowUserToAddRows = false;
            grillaAutosYDueños.AllowUserToDeleteRows = false;
            grillaAutosYDueños.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAutosYDueños.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            grillaAutosYDueños.Location = new Point(474, 239);
            grillaAutosYDueños.MultiSelect = false;
            grillaAutosYDueños.Name = "grillaAutosYDueños";
            grillaAutosYDueños.ReadOnly = true;
            grillaAutosYDueños.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaAutosYDueños.Size = new Size(443, 150);
            grillaAutosYDueños.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "Marca";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Año";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Modelo";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Patente";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "DNI del Dueño";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Apellido y Nombre del Dueño";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // etiquetaAutoYDueño
            // 
            etiquetaAutoYDueño.AutoSize = true;
            etiquetaAutoYDueño.Location = new Point(474, 221);
            etiquetaAutoYDueño.Name = "etiquetaAutoYDueño";
            etiquetaAutoYDueño.Size = new Size(155, 15);
            etiquetaAutoYDueño.TabIndex = 16;
            etiquetaAutoYDueño.Text = "Autos y Dueños (Si tienen...)";
            // 
            // GrillaPersonasYAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 438);
            Controls.Add(etiquetaAutoYDueño);
            Controls.Add(grillaAutosYDueños);
            Controls.Add(botonModificarPersona);
            Controls.Add(botonModificarAuto);
            Controls.Add(botonEliminarPersona);
            Controls.Add(botonEliminarAuto);
            Controls.Add(grillaAutosDePersona);
            Controls.Add(etiquetaAutosPersonaSeleccionada);
            Controls.Add(botonAsignarAutoAPersona);
            Controls.Add(botonAgregarAuto);
            Controls.Add(etiquetaAutos);
            Controls.Add(grillaAutos);
            Controls.Add(botonAgregarPersona);
            Controls.Add(etiquetaPersonas);
            Controls.Add(grillaPersonas);
            Name = "GrillaPersonasYAutos";
            Text = "Grilla de Autos y Dueños";
            ((System.ComponentModel.ISupportInitialize)grillaPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAutosDePersona).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAutosYDueños).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaPersonas;
        private Label etiquetaPersonas;
        private Button botonAgregarPersona;
        private Label etiquetaAutos;
        private DataGridView grillaAutos;
        private Button botonAgregarAuto;
        private Button botonAsignarAutoAPersona;
        private Label etiquetaAutosPersonaSeleccionada;
        private DataGridView grillaAutosDePersona;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn CantAutos;
        private DataGridViewTextBoxColumn Patente;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Precio;
        private Button botonEliminarAuto;
        private Button botonEliminarPersona;
        private Button botonModificarAuto;
        private Button botonModificarPersona;
        private DataGridView grillaAutosYDueños;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label etiquetaAutoYDueño;
    }
}
