namespace GobData
{
    partial class ConsultaEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEventos));
            btnCancelarConsulta = new ControlSTV.ButtonSTV();
            btnConsultarRegistro = new ControlSTV.ButtonSTV();
            SuspendLayout();
            // 
            // btnCancelarConsulta
            // 
            btnCancelarConsulta.BackColor = Color.FromArgb(254, 143, 143);
            btnCancelarConsulta.BackgroundColor = Color.FromArgb(254, 143, 143);
            btnCancelarConsulta.BorderColor = Color.FromArgb(239, 75, 94);
            btnCancelarConsulta.BorderRadius = 40;
            btnCancelarConsulta.BorderSize = 2;
            btnCancelarConsulta.FlatAppearance.BorderSize = 0;
            btnCancelarConsulta.FlatStyle = FlatStyle.Flat;
            btnCancelarConsulta.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelarConsulta.ForeColor = Color.White;
            btnCancelarConsulta.Location = new Point(275, 236);
            btnCancelarConsulta.Name = "btnCancelarConsulta";
            btnCancelarConsulta.Size = new Size(251, 45);
            btnCancelarConsulta.TabIndex = 4;
            btnCancelarConsulta.Text = "Cancelar";
            btnCancelarConsulta.TextColor = Color.White;
            btnCancelarConsulta.UseVisualStyleBackColor = false;
            btnCancelarConsulta.Click += btnCancelarConsulta_Click;
            // 
            // btnConsultarRegistro
            // 
            btnConsultarRegistro.BackColor = Color.LightSteelBlue;
            btnConsultarRegistro.BackgroundColor = Color.LightSteelBlue;
            btnConsultarRegistro.BorderColor = Color.FromArgb(59, 167, 198);
            btnConsultarRegistro.BorderRadius = 40;
            btnConsultarRegistro.BorderSize = 2;
            btnConsultarRegistro.FlatAppearance.BorderSize = 0;
            btnConsultarRegistro.FlatStyle = FlatStyle.Flat;
            btnConsultarRegistro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConsultarRegistro.ForeColor = Color.White;
            btnConsultarRegistro.Location = new Point(275, 169);
            btnConsultarRegistro.Name = "btnConsultarRegistro";
            btnConsultarRegistro.Size = new Size(251, 45);
            btnConsultarRegistro.TabIndex = 3;
            btnConsultarRegistro.Text = "Consultar";
            btnConsultarRegistro.TextColor = Color.White;
            btnConsultarRegistro.UseVisualStyleBackColor = false;
            btnConsultarRegistro.Click += btnConsultarRegistro_Click;
            // 
            // ConsultaEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarConsulta);
            Controls.Add(btnConsultarRegistro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ConsultaEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Eventos";
            ResumeLayout(false);
        }

        #endregion

        private ControlSTV.ButtonSTV btnCancelarConsulta;
        private ControlSTV.ButtonSTV btnConsultarRegistro;
    }
}