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
            panel1 = new Panel();
            txtBuscarEventos = new TextBox();
            cbConsultarEventos = new ComboBox();
            lblTituloConsultaEventos = new Label();
            dgvConsultarEventos = new DataGridView();
            panelstv1 = new ControlSTV.PanelSTV();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarEventos).BeginInit();
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
            btnCancelarConsulta.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarConsulta.ForeColor = Color.Black;
            btnCancelarConsulta.Location = new Point(67, 334);
            btnCancelarConsulta.Name = "btnCancelarConsulta";
            btnCancelarConsulta.Size = new Size(251, 45);
            btnCancelarConsulta.TabIndex = 4;
            btnCancelarConsulta.Text = "Cancelar";
            btnCancelarConsulta.TextColor = Color.Black;
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
            btnConsultarRegistro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarRegistro.ForeColor = Color.Black;
            btnConsultarRegistro.Location = new Point(335, 334);
            btnConsultarRegistro.Name = "btnConsultarRegistro";
            btnConsultarRegistro.Size = new Size(251, 45);
            btnConsultarRegistro.TabIndex = 3;
            btnConsultarRegistro.Text = "Consultar";
            btnConsultarRegistro.TextColor = Color.Black;
            btnConsultarRegistro.UseVisualStyleBackColor = false;
            btnConsultarRegistro.Click += btnConsultarRegistro_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnCancelarConsulta);
            panel1.Controls.Add(btnConsultarRegistro);
            panel1.Controls.Add(txtBuscarEventos);
            panel1.Controls.Add(cbConsultarEventos);
            panel1.Controls.Add(lblTituloConsultaEventos);
            panel1.Controls.Add(dgvConsultarEventos);
            panel1.Location = new Point(85, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 395);
            panel1.TabIndex = 5;
            // 
            // txtBuscarEventos
            // 
            txtBuscarEventos.BackColor = Color.White;
            txtBuscarEventos.Location = new Point(67, 79);
            txtBuscarEventos.Name = "txtBuscarEventos";
            txtBuscarEventos.Size = new Size(408, 23);
            txtBuscarEventos.TabIndex = 8;
            txtBuscarEventos.TextChanged += txtBuscarEventos_TextChanged;
            // 
            // cbConsultarEventos
            // 
            cbConsultarEventos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConsultarEventos.FormattingEnabled = true;
            cbConsultarEventos.Items.AddRange(new object[] { "Clinicos", "Industria", "Investigacion", "Servicios", "Todos" });
            cbConsultarEventos.Location = new Point(481, 79);
            cbConsultarEventos.Name = "cbConsultarEventos";
            cbConsultarEventos.Size = new Size(105, 23);
            cbConsultarEventos.TabIndex = 7;
            cbConsultarEventos.SelectedIndexChanged += cbConsultarEventos_SelectedIndexChanged;
            // 
            // lblTituloConsultaEventos
            // 
            lblTituloConsultaEventos.AutoSize = true;
            lblTituloConsultaEventos.BackColor = SystemColors.Control;
            lblTituloConsultaEventos.Font = new Font("Century Gothic", 36F);
            lblTituloConsultaEventos.ForeColor = Color.Crimson;
            lblTituloConsultaEventos.Location = new Point(67, 6);
            lblTituloConsultaEventos.Name = "lblTituloConsultaEventos";
            lblTituloConsultaEventos.Size = new Size(160, 58);
            lblTituloConsultaEventos.TabIndex = 6;
            lblTituloConsultaEventos.Text = "Todos";
            // 
            // dgvConsultarEventos
            // 
            dgvConsultarEventos.AllowUserToAddRows = false;
            dgvConsultarEventos.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvConsultarEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarEventos.Location = new Point(67, 108);
            dgvConsultarEventos.MultiSelect = false;
            dgvConsultarEventos.Name = "dgvConsultarEventos";
            dgvConsultarEventos.ReadOnly = true;
            dgvConsultarEventos.RowHeadersVisible = false;
            dgvConsultarEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarEventos.Size = new Size(519, 212);
            dgvConsultarEventos.TabIndex = 5;
            // 
            // panelstv1
            // 
            panelstv1.ColorBottom = Color.FromArgb(6, 159, 210);
            panelstv1.ColorTop = Color.FromArgb(0, 72, 131);
            panelstv1.Dock = DockStyle.Top;
            panelstv1.Location = new Point(0, 0);
            panelstv1.Name = "panelstv1";
            panelstv1.Size = new Size(800, 12);
            panelstv1.TabIndex = 45;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 167, 198);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 29);
            panel2.TabIndex = 46;
            // 
            // ConsultaEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 467);
            Controls.Add(panel2);
            Controls.Add(panelstv1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ConsultaEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Eventos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarEventos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ControlSTV.ButtonSTV btnCancelarConsulta;
        private ControlSTV.ButtonSTV btnConsultarRegistro;
        private Panel panel1;
        private ComboBox cbConsultarEventos;
        private Label lblTituloConsultaEventos;
        private DataGridView dgvConsultarEventos;
        private TextBox txtBuscarEventos;
        private ControlSTV.PanelSTV panelstv1;
        private Panel panel2;
    }
}