namespace ActividadIntegradoraNro1.GUI
{
    partial class FormularioModificarPersona
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
            campoTextoDNI = new TextBox();
            campoTextoNombre = new TextBox();
            campoTextoApellido = new TextBox();
            etiquetaDNI = new Label();
            etiquetaNombre = new Label();
            etiquetaApellido = new Label();
            botonAgregar = new Button();
            SuspendLayout();
            // 
            // campoTextoDNI
            // 
            campoTextoDNI.Location = new Point(104, 45);
            campoTextoDNI.MaxLength = 8;
            campoTextoDNI.Name = "campoTextoDNI";
            campoTextoDNI.Size = new Size(100, 23);
            campoTextoDNI.TabIndex = 0;
            campoTextoDNI.TextChanged += ValidarCampos;
            // 
            // campoTextoNombre
            // 
            campoTextoNombre.Location = new Point(104, 74);
            campoTextoNombre.Name = "campoTextoNombre";
            campoTextoNombre.Size = new Size(100, 23);
            campoTextoNombre.TabIndex = 1;
            campoTextoNombre.TextChanged += ValidarCampos;
            // 
            // campoTextoApellido
            // 
            campoTextoApellido.Location = new Point(104, 103);
            campoTextoApellido.Name = "campoTextoApellido";
            campoTextoApellido.Size = new Size(100, 23);
            campoTextoApellido.TabIndex = 2;
            campoTextoApellido.TextChanged += ValidarCampos;
            // 
            // etiquetaDNI
            // 
            etiquetaDNI.AutoSize = true;
            etiquetaDNI.Location = new Point(71, 48);
            etiquetaDNI.Name = "etiquetaDNI";
            etiquetaDNI.Size = new Size(27, 15);
            etiquetaDNI.TabIndex = 3;
            etiquetaDNI.Text = "DNI";
            // 
            // etiquetaNombre
            // 
            etiquetaNombre.AutoSize = true;
            etiquetaNombre.Location = new Point(47, 77);
            etiquetaNombre.Name = "etiquetaNombre";
            etiquetaNombre.Size = new Size(51, 15);
            etiquetaNombre.TabIndex = 4;
            etiquetaNombre.Text = "Nombre";
            // 
            // etiquetaApellido
            // 
            etiquetaApellido.AutoSize = true;
            etiquetaApellido.Location = new Point(47, 106);
            etiquetaApellido.Name = "etiquetaApellido";
            etiquetaApellido.Size = new Size(51, 15);
            etiquetaApellido.TabIndex = 5;
            etiquetaApellido.Text = "Apellido";
            // 
            // botonAgregar
            // 
            botonAgregar.Enabled = false;
            botonAgregar.Location = new Point(116, 132);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(75, 23);
            botonAgregar.TabIndex = 6;
            botonAgregar.Text = "Modificar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += BotonModificar_Click;
            // 
            // FormularioModificarPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 204);
            Controls.Add(botonAgregar);
            Controls.Add(etiquetaApellido);
            Controls.Add(etiquetaNombre);
            Controls.Add(etiquetaDNI);
            Controls.Add(campoTextoApellido);
            Controls.Add(campoTextoNombre);
            Controls.Add(campoTextoDNI);
            Name = "FormularioModificarPersona";
            Text = "Modificar Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campoTextoDNI;
        private TextBox campoTextoNombre;
        private TextBox campoTextoApellido;
        private Label etiquetaDNI;
        private Label etiquetaNombre;
        private Label etiquetaApellido;
        private Button botonAgregar;
    }
}