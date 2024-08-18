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
            panelPrincipal = new Panel();
            label7 = new Label();
            cbMesEvento = new ComboBox();
            cbDivisionEvento = new ComboBox();
            txtNumeroEvento = new TextBox();
            txtConvocanteEvento = new TextBox();
            txtEstadoEvento = new TextBox();
            txtDiaEvento = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelstv1 = new ControlSTV.PanelSTV();
            panel2 = new Panel();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardarRegistro
            // 
            btnGuardarRegistro.BackColor = Color.LightSteelBlue;
            btnGuardarRegistro.BackgroundColor = Color.LightSteelBlue;
            btnGuardarRegistro.BorderColor = Color.FromArgb(59, 167, 198);
            btnGuardarRegistro.BorderRadius = 40;
            btnGuardarRegistro.BorderSize = 2;
            btnGuardarRegistro.Cursor = Cursors.Hand;
            btnGuardarRegistro.FlatAppearance.BorderSize = 0;
            btnGuardarRegistro.FlatStyle = FlatStyle.Flat;
            btnGuardarRegistro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarRegistro.ForeColor = Color.Black;
            btnGuardarRegistro.Location = new Point(271, 302);
            btnGuardarRegistro.Name = "btnGuardarRegistro";
            btnGuardarRegistro.Size = new Size(195, 45);
            btnGuardarRegistro.TabIndex = 7;
            btnGuardarRegistro.Text = "Guardar";
            btnGuardarRegistro.TextColor = Color.Black;
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
            btnCancelarRegistro.Cursor = Cursors.Hand;
            btnCancelarRegistro.FlatAppearance.BorderSize = 0;
            btnCancelarRegistro.FlatStyle = FlatStyle.Flat;
            btnCancelarRegistro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarRegistro.ForeColor = Color.Black;
            btnCancelarRegistro.Location = new Point(72, 302);
            btnCancelarRegistro.Name = "btnCancelarRegistro";
            btnCancelarRegistro.Size = new Size(195, 45);
            btnCancelarRegistro.TabIndex = 8;
            btnCancelarRegistro.Text = "Cancelar";
            btnCancelarRegistro.TextColor = Color.Black;
            btnCancelarRegistro.UseVisualStyleBackColor = false;
            btnCancelarRegistro.Click += btnCancelarRegistro_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.Control;
            panelPrincipal.Controls.Add(label7);
            panelPrincipal.Controls.Add(cbMesEvento);
            panelPrincipal.Controls.Add(cbDivisionEvento);
            panelPrincipal.Controls.Add(txtNumeroEvento);
            panelPrincipal.Controls.Add(txtConvocanteEvento);
            panelPrincipal.Controls.Add(txtEstadoEvento);
            panelPrincipal.Controls.Add(txtDiaEvento);
            panelPrincipal.Controls.Add(label6);
            panelPrincipal.Controls.Add(label5);
            panelPrincipal.Controls.Add(label4);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(btnCancelarRegistro);
            panelPrincipal.Controls.Add(btnGuardarRegistro);
            panelPrincipal.Location = new Point(61, 24);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(538, 362);
            panelPrincipal.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 36F);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(72, 18);
            label7.Name = "label7";
            label7.Size = new Size(394, 58);
            label7.TabIndex = 9;
            label7.Text = "Registrar Evento";
            // 
            // cbMesEvento
            // 
            cbMesEvento.BackColor = Color.White;
            cbMesEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMesEvento.FormattingEnabled = true;
            cbMesEvento.Items.AddRange(new object[] { "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC" });
            cbMesEvento.Location = new Point(196, 105);
            cbMesEvento.Name = "cbMesEvento";
            cbMesEvento.Size = new Size(250, 23);
            cbMesEvento.TabIndex = 1;
            // 
            // cbDivisionEvento
            // 
            cbDivisionEvento.BackColor = Color.White;
            cbDivisionEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDivisionEvento.FormattingEnabled = true;
            cbDivisionEvento.Items.AddRange(new object[] { "Clinicos", "Industria", "Investigacion", "Servicios" });
            cbDivisionEvento.Location = new Point(196, 250);
            cbDivisionEvento.Name = "cbDivisionEvento";
            cbDivisionEvento.Size = new Size(250, 23);
            cbDivisionEvento.TabIndex = 6;
            // 
            // txtNumeroEvento
            // 
            txtNumeroEvento.Location = new Point(196, 221);
            txtNumeroEvento.Name = "txtNumeroEvento";
            txtNumeroEvento.Size = new Size(250, 23);
            txtNumeroEvento.TabIndex = 5;
            // 
            // txtConvocanteEvento
            // 
            txtConvocanteEvento.Location = new Point(196, 192);
            txtConvocanteEvento.Name = "txtConvocanteEvento";
            txtConvocanteEvento.Size = new Size(250, 23);
            txtConvocanteEvento.TabIndex = 4;
            // 
            // txtEstadoEvento
            // 
            txtEstadoEvento.Location = new Point(196, 163);
            txtEstadoEvento.Name = "txtEstadoEvento";
            txtEstadoEvento.Size = new Size(250, 23);
            txtEstadoEvento.TabIndex = 3;
            txtEstadoEvento.KeyPress += txtSoloTexto_KeyPress;
            // 
            // txtDiaEvento
            // 
            txtDiaEvento.Location = new Point(196, 134);
            txtDiaEvento.Name = "txtDiaEvento";
            txtDiaEvento.Size = new Size(250, 23);
            txtDiaEvento.TabIndex = 2;
            txtDiaEvento.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 258);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 8;
            label6.Text = "Division";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 229);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 7;
            label5.Text = "Numero de evento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 200);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Convocante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 171);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 142);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 4;
            label2.Text = "Dia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 112);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 3;
            label1.Text = "Mes";
            // 
            // panelstv1
            // 
            panelstv1.ColorBottom = Color.FromArgb(6, 159, 210);
            panelstv1.ColorTop = Color.FromArgb(0, 72, 131);
            panelstv1.Dock = DockStyle.Top;
            panelstv1.Location = new Point(0, 0);
            panelstv1.Name = "panelstv1";
            panelstv1.Size = new Size(660, 12);
            panelstv1.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 167, 198);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 29);
            panel2.TabIndex = 47;
            // 
            // RegistroNombreEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(660, 434);
            Controls.Add(panel2);
            Controls.Add(panelstv1);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistroNombreEvento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nombre del Evento";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNumeroEvento;
        private TextBox txtConvocanteEvento;
        private TextBox txtEstadoEvento;
        private TextBox txtDiaEvento;
        private ControlSTV.ButtonSTV btnGuardarRegistro;
        private ControlSTV.ButtonSTV btnCancelarRegistro;
        private ComboBox cbDivisionEvento;
        private ComboBox cbMesEvento;
        private ControlSTV.PanelSTV panelstv1;
        private Label label7;
        private Panel panel2;
    }
}