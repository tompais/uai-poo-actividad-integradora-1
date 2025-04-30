namespace ActividadIntegradoraNro1.GUI.Formularios
{
    partial class FormularioAgregarAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            campoTextoPatente = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            campoTextoAño = new TextBox();
            etiquetaPatente = new Label();
            etiquetaMarca = new Label();
            etiquetaModelo = new Label();
            etiquetaAño = new Label();
            etiquetaPrecio = new Label();
            botonAgregar = new Button();
            campoNumericoPrecio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)campoNumericoPrecio).BeginInit();
            SuspendLayout();
            // 
            // campoTextoPatente
            // 
            campoTextoPatente.Location = new Point(116, 47);
            campoTextoPatente.MaxLength = 7;
            campoTextoPatente.Name = "campoTextoPatente";
            campoTextoPatente.Size = new Size(100, 23);
            campoTextoPatente.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // campoTextoAño
            // 
            campoTextoAño.Location = new Point(116, 134);
            campoTextoAño.MaxLength = 4;
            campoTextoAño.Name = "campoTextoAño";
            campoTextoAño.Size = new Size(100, 23);
            campoTextoAño.TabIndex = 3;
            // 
            // etiquetaPatente
            // 
            etiquetaPatente.AutoSize = true;
            etiquetaPatente.Location = new Point(63, 50);
            etiquetaPatente.Name = "etiquetaPatente";
            etiquetaPatente.Size = new Size(47, 15);
            etiquetaPatente.TabIndex = 5;
            etiquetaPatente.Text = "Patente";
            // 
            // etiquetaMarca
            // 
            etiquetaMarca.AutoSize = true;
            etiquetaMarca.Location = new Point(70, 79);
            etiquetaMarca.Name = "etiquetaMarca";
            etiquetaMarca.Size = new Size(40, 15);
            etiquetaMarca.TabIndex = 6;
            etiquetaMarca.Text = "Marca";
            // 
            // etiquetaModelo
            // 
            etiquetaModelo.AutoSize = true;
            etiquetaModelo.Location = new Point(62, 108);
            etiquetaModelo.Name = "etiquetaModelo";
            etiquetaModelo.Size = new Size(48, 15);
            etiquetaModelo.TabIndex = 7;
            etiquetaModelo.Text = "Modelo";
            // 
            // etiquetaAño
            // 
            etiquetaAño.AutoSize = true;
            etiquetaAño.Location = new Point(81, 137);
            etiquetaAño.Name = "etiquetaAño";
            etiquetaAño.Size = new Size(29, 15);
            etiquetaAño.TabIndex = 8;
            etiquetaAño.Text = "Año";
            // 
            // etiquetaPrecio
            // 
            etiquetaPrecio.AutoSize = true;
            etiquetaPrecio.Location = new Point(70, 166);
            etiquetaPrecio.Name = "etiquetaPrecio";
            etiquetaPrecio.Size = new Size(40, 15);
            etiquetaPrecio.TabIndex = 9;
            etiquetaPrecio.Text = "Precio";
            // 
            // botonAgregar
            // 
            botonAgregar.Enabled = false;
            botonAgregar.Location = new Point(128, 192);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(75, 23);
            botonAgregar.TabIndex = 10;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            // 
            // campoNumericoPrecio
            // 
            campoNumericoPrecio.DecimalPlaces = 2;
            campoNumericoPrecio.Location = new Point(116, 164);
            campoNumericoPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            campoNumericoPrecio.Minimum = new decimal(new int[] { 5000000, 0, 0, 0 });
            campoNumericoPrecio.Name = "campoNumericoPrecio";
            campoNumericoPrecio.Size = new Size(100, 23);
            campoNumericoPrecio.TabIndex = 11;
            campoNumericoPrecio.Value = new decimal(new int[] { 5000000, 0, 0, 0 });
            // 
            // FormularioAgregarAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 256);
            Controls.Add(campoNumericoPrecio);
            Controls.Add(botonAgregar);
            Controls.Add(etiquetaPrecio);
            Controls.Add(etiquetaAño);
            Controls.Add(etiquetaModelo);
            Controls.Add(etiquetaMarca);
            Controls.Add(etiquetaPatente);
            Controls.Add(campoTextoAño);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(campoTextoPatente);
            Name = "FormularioAgregarAuto";
            Text = "Agregar Auto";
            Load += FormularioAgregarAuto_Load;
            ((System.ComponentModel.ISupportInitialize)campoNumericoPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campoTextoPatente;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox campoTextoAño;
        private Label etiquetaPatente;
        private Label etiquetaMarca;
        private Label etiquetaModelo;
        private Label etiquetaAño;
        private Label etiquetaPrecio;
        private Button botonAgregar;
        private NumericUpDown campoNumericoPrecio;
    }
}