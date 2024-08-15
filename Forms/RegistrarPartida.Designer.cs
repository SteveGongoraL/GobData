namespace GobData
{
    partial class RegistrarPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPartida));
            lblID = new Label();
            btnCancelarPartida = new ControlSTV.ButtonSTV();
            btnGuardarPartida = new ControlSTV.ButtonSTV();
            btnFinalizarPartida = new ControlSTV.ButtonSTV();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(116, 27);
            lblID.Name = "lblID";
            lblID.Size = new Size(38, 15);
            lblID.TabIndex = 0;
            lblID.Text = "label1";
            // 
            // btnCancelarPartida
            // 
            btnCancelarPartida.BackColor = Color.FromArgb(254, 143, 143);
            btnCancelarPartida.BackgroundColor = Color.FromArgb(254, 143, 143);
            btnCancelarPartida.BorderColor = Color.FromArgb(239, 75, 94);
            btnCancelarPartida.BorderRadius = 36;
            btnCancelarPartida.BorderSize = 2;
            btnCancelarPartida.FlatAppearance.BorderSize = 0;
            btnCancelarPartida.FlatStyle = FlatStyle.Flat;
            btnCancelarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelarPartida.ForeColor = Color.White;
            btnCancelarPartida.Location = new Point(310, 203);
            btnCancelarPartida.Name = "btnCancelarPartida";
            btnCancelarPartida.Size = new Size(82, 36);
            btnCancelarPartida.TabIndex = 6;
            btnCancelarPartida.Text = "Cancelar";
            btnCancelarPartida.TextColor = Color.White;
            btnCancelarPartida.UseVisualStyleBackColor = false;
            // 
            // btnGuardarPartida
            // 
            btnGuardarPartida.BackColor = Color.LightSteelBlue;
            btnGuardarPartida.BackgroundColor = Color.LightSteelBlue;
            btnGuardarPartida.BorderColor = Color.FromArgb(59, 167, 198);
            btnGuardarPartida.BorderRadius = 36;
            btnGuardarPartida.BorderSize = 2;
            btnGuardarPartida.FlatAppearance.BorderSize = 0;
            btnGuardarPartida.FlatStyle = FlatStyle.Flat;
            btnGuardarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardarPartida.ForeColor = Color.White;
            btnGuardarPartida.Location = new Point(398, 203);
            btnGuardarPartida.Name = "btnGuardarPartida";
            btnGuardarPartida.Size = new Size(82, 36);
            btnGuardarPartida.TabIndex = 5;
            btnGuardarPartida.Text = "Guardar";
            btnGuardarPartida.TextColor = Color.White;
            btnGuardarPartida.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarPartida
            // 
            btnFinalizarPartida.BackColor = Color.LightGreen;
            btnFinalizarPartida.BackgroundColor = Color.LightGreen;
            btnFinalizarPartida.BorderColor = Color.Green;
            btnFinalizarPartida.BorderRadius = 36;
            btnFinalizarPartida.BorderSize = 2;
            btnFinalizarPartida.FlatAppearance.BorderSize = 0;
            btnFinalizarPartida.FlatStyle = FlatStyle.Flat;
            btnFinalizarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFinalizarPartida.ForeColor = Color.Black;
            btnFinalizarPartida.Location = new Point(358, 348);
            btnFinalizarPartida.Name = "btnFinalizarPartida";
            btnFinalizarPartida.Size = new Size(82, 36);
            btnFinalizarPartida.TabIndex = 7;
            btnFinalizarPartida.Text = "Finalizar";
            btnFinalizarPartida.TextColor = Color.Black;
            btnFinalizarPartida.UseVisualStyleBackColor = false;
            btnFinalizarPartida.Click += btnFinalizarPartida_Click;
            // 
            // RegistrarPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizarPartida);
            Controls.Add(btnCancelarPartida);
            Controls.Add(btnGuardarPartida);
            Controls.Add(lblID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistrarPartida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Partida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private ControlSTV.ButtonSTV btnCancelarPartida;
        private ControlSTV.ButtonSTV btnGuardarPartida;
        private ControlSTV.ButtonSTV btnFinalizarPartida;
    }
}