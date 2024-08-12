namespace GobData
{
    partial class RegistroNombreEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroNombreEvento));
            btnGuardarRegistro = new ControlSTV.ButtonSTV();
            btnCancelarRegistro = new ControlSTV.ButtonSTV();
            SuspendLayout();
            // 
            // btnGuardarRegistro
            // 
            btnGuardarRegistro.BackColor = Color.LightSteelBlue;
            btnGuardarRegistro.BackgroundColor = Color.LightSteelBlue;
            btnGuardarRegistro.BorderColor = Color.FromArgb(59, 167, 198);
            btnGuardarRegistro.BorderRadius = 40;
            btnGuardarRegistro.BorderSize = 2;
            btnGuardarRegistro.FlatAppearance.BorderSize = 0;
            btnGuardarRegistro.FlatStyle = FlatStyle.Flat;
            btnGuardarRegistro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardarRegistro.ForeColor = Color.White;
            btnGuardarRegistro.Location = new Point(275, 203);
            btnGuardarRegistro.Name = "btnGuardarRegistro";
            btnGuardarRegistro.Size = new Size(251, 45);
            btnGuardarRegistro.TabIndex = 1;
            btnGuardarRegistro.Text = "Guardar";
            btnGuardarRegistro.TextColor = Color.White;
            btnGuardarRegistro.UseVisualStyleBackColor = false;
            btnGuardarRegistro.Click += btnGuardarRegistro_Click;
            // 
            // btnCancelarRegistro
            // 
            btnCancelarRegistro.BackColor = Color.FromArgb(254, 143, 143);
            btnCancelarRegistro.BackgroundColor = Color.FromArgb(254, 143, 143);
            btnCancelarRegistro.BorderColor = Color.FromArgb(239, 75, 94);
            btnCancelarRegistro.BorderRadius = 40;
            btnCancelarRegistro.BorderSize = 2;
            btnCancelarRegistro.FlatAppearance.BorderSize = 0;
            btnCancelarRegistro.FlatStyle = FlatStyle.Flat;
            btnCancelarRegistro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelarRegistro.ForeColor = Color.White;
            btnCancelarRegistro.Location = new Point(275, 270);
            btnCancelarRegistro.Name = "btnCancelarRegistro";
            btnCancelarRegistro.Size = new Size(251, 45);
            btnCancelarRegistro.TabIndex = 2;
            btnCancelarRegistro.Text = "Cancelar";
            btnCancelarRegistro.TextColor = Color.White;
            btnCancelarRegistro.UseVisualStyleBackColor = false;
            btnCancelarRegistro.Click += btnCancelarRegistro_Click;
            // 
            // RegistroNombreEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarRegistro);
            Controls.Add(btnGuardarRegistro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistroNombreEvento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nombre del Evento";
            ResumeLayout(false);
        }

        #endregion

        private ControlSTV.ButtonSTV btnGuardarRegistro;
        private ControlSTV.ButtonSTV btnCancelarRegistro;
    }
}