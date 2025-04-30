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
            ((System.ComponentModel.ISupportInitialize)grillaPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAutos).BeginInit();
            SuspendLayout();
            // 
            // grillaPersonas
            // 
            grillaPersonas.AllowUserToAddRows = false;
            grillaPersonas.AllowUserToDeleteRows = false;
            grillaPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPersonas.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombre, Apellido, CantAutos });
            grillaPersonas.Location = new Point(12, 27);
            grillaPersonas.Name = "grillaPersonas";
            grillaPersonas.ReadOnly = true;
            grillaPersonas.Size = new Size(443, 150);
            grillaPersonas.TabIndex = 0;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
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
            botonAgregarPersona.Location = new Point(461, 27);
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
            etiquetaAutos.Location = new Point(12, 199);
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
            grillaAutos.Location = new Point(12, 217);
            grillaAutos.Name = "grillaAutos";
            grillaAutos.ReadOnly = true;
            grillaAutos.Size = new Size(443, 150);
            grillaAutos.TabIndex = 3;
            // 
            // Patente
            // 
            Patente.HeaderText = "Patente";
            Patente.Name = "Patente";
            Patente.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // Año
            // 
            Año.HeaderText = "Año";
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
            botonAgregarAuto.Location = new Point(461, 217);
            botonAgregarAuto.Name = "botonAgregarAuto";
            botonAgregarAuto.Size = new Size(110, 23);
            botonAgregarAuto.TabIndex = 5;
            botonAgregarAuto.Text = "Agregar Auto";
            botonAgregarAuto.UseVisualStyleBackColor = true;
            botonAgregarAuto.Click += botonAgregarAuto_Click;
            // 
            // GrillaPersonasYAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaPersonas;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn CantAutos;
        private Label etiquetaPersonas;
        private Button botonAgregarPersona;
        private Label etiquetaAutos;
        private DataGridView grillaAutos;
        private DataGridViewTextBoxColumn Patente;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Precio;
        private Button botonAgregarAuto;
    }
}
