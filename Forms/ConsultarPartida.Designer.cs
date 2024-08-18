namespace GobData
{
    partial class ConsultarPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPartida));
            lblTituloPartida = new Label();
            btnEliminarPartida = new ControlSTV.ButtonSTV();
            btnAgregarPartida = new ControlSTV.ButtonSTV();
            btnFinalizarPartida = new ControlSTV.ButtonSTV();
            dgDatosPartida = new DataGridView();
            groupBox1 = new GroupBox();
            txtBusquedaPartida = new TextBox();
            btnEditarPartida = new ControlSTV.ButtonSTV();
            groupBox2 = new GroupBox();
            dgDocumentosPartida = new DataGridView();
            panel1 = new Panel();
            lblPruebas66 = new Label();
            panel2 = new Panel();
            panelstv1 = new ControlSTV.PanelSTV();
            panelNombreEvento = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgDatosPartida).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDocumentosPartida).BeginInit();
            panel1.SuspendLayout();
            panelNombreEvento.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloPartida
            // 
            lblTituloPartida.AutoSize = true;
            lblTituloPartida.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPartida.ForeColor = Color.Crimson;
            lblTituloPartida.Location = new Point(3, 4);
            lblTituloPartida.Name = "lblTituloPartida";
            lblTituloPartida.Size = new Size(223, 33);
            lblTituloPartida.TabIndex = 0;
            lblTituloPartida.Text = "Nombre Evento";
            // 
            // btnEliminarPartida
            // 
            btnEliminarPartida.BackColor = Color.FromArgb(254, 143, 143);
            btnEliminarPartida.BackgroundColor = Color.FromArgb(254, 143, 143);
            btnEliminarPartida.BorderColor = Color.FromArgb(239, 75, 94);
            btnEliminarPartida.BorderRadius = 36;
            btnEliminarPartida.BorderSize = 2;
            btnEliminarPartida.FlatAppearance.BorderSize = 0;
            btnEliminarPartida.FlatStyle = FlatStyle.Flat;
            btnEliminarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarPartida.ForeColor = Color.Black;
            btnEliminarPartida.Location = new Point(97, 274);
            btnEliminarPartida.Name = "btnEliminarPartida";
            btnEliminarPartida.Size = new Size(82, 36);
            btnEliminarPartida.TabIndex = 6;
            btnEliminarPartida.Text = "Eliminar";
            btnEliminarPartida.TextColor = Color.Black;
            btnEliminarPartida.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPartida
            // 
            btnAgregarPartida.BackColor = Color.LightSteelBlue;
            btnAgregarPartida.BackgroundColor = Color.LightSteelBlue;
            btnAgregarPartida.BorderColor = Color.FromArgb(59, 167, 198);
            btnAgregarPartida.BorderRadius = 36;
            btnAgregarPartida.BorderSize = 2;
            btnAgregarPartida.FlatAppearance.BorderSize = 0;
            btnAgregarPartida.FlatStyle = FlatStyle.Flat;
            btnAgregarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarPartida.ForeColor = Color.Black;
            btnAgregarPartida.Location = new Point(273, 274);
            btnAgregarPartida.Name = "btnAgregarPartida";
            btnAgregarPartida.Size = new Size(82, 36);
            btnAgregarPartida.TabIndex = 5;
            btnAgregarPartida.Text = "Agregar";
            btnAgregarPartida.TextColor = Color.Black;
            btnAgregarPartida.UseVisualStyleBackColor = false;
            btnAgregarPartida.Click += btnAgregarPartida_Click;
            // 
            // btnFinalizarPartida
            // 
            btnFinalizarPartida.BackColor = Color.LightGreen;
            btnFinalizarPartida.BackgroundColor = Color.LightGreen;
            btnFinalizarPartida.BorderColor = Color.Green;
            btnFinalizarPartida.BorderRadius = 20;
            btnFinalizarPartida.BorderSize = 2;
            btnFinalizarPartida.FlatAppearance.BorderSize = 0;
            btnFinalizarPartida.FlatStyle = FlatStyle.Flat;
            btnFinalizarPartida.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarPartida.ForeColor = Color.Black;
            btnFinalizarPartida.Location = new Point(320, 6);
            btnFinalizarPartida.Name = "btnFinalizarPartida";
            btnFinalizarPartida.Size = new Size(147, 36);
            btnFinalizarPartida.TabIndex = 7;
            btnFinalizarPartida.Text = "Finalizar";
            btnFinalizarPartida.TextColor = Color.Black;
            btnFinalizarPartida.UseVisualStyleBackColor = false;
            btnFinalizarPartida.Click += btnFinalizarPartida_Click;
            // 
            // dgDatosPartida
            // 
            dgDatosPartida.AllowUserToAddRows = false;
            dgDatosPartida.BackgroundColor = SystemColors.GradientActiveCaption;
            dgDatosPartida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatosPartida.Location = new Point(16, 54);
            dgDatosPartida.Name = "dgDatosPartida";
            dgDatosPartida.ReadOnly = true;
            dgDatosPartida.RowHeadersVisible = false;
            dgDatosPartida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDatosPartida.Size = new Size(421, 214);
            dgDatosPartida.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(txtBusquedaPartida);
            groupBox1.Controls.Add(btnEditarPartida);
            groupBox1.Controls.Add(dgDatosPartida);
            groupBox1.Controls.Add(btnAgregarPartida);
            groupBox1.Controls.Add(btnEliminarPartida);
            groupBox1.Location = new Point(35, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 316);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Partidas";
            // 
            // txtBusquedaPartida
            // 
            txtBusquedaPartida.Location = new Point(16, 25);
            txtBusquedaPartida.Name = "txtBusquedaPartida";
            txtBusquedaPartida.Size = new Size(293, 23);
            txtBusquedaPartida.TabIndex = 10;
            // 
            // btnEditarPartida
            // 
            btnEditarPartida.BackColor = Color.LightSteelBlue;
            btnEditarPartida.BackgroundColor = Color.LightSteelBlue;
            btnEditarPartida.BorderColor = Color.FromArgb(59, 167, 198);
            btnEditarPartida.BorderRadius = 36;
            btnEditarPartida.BorderSize = 2;
            btnEditarPartida.FlatAppearance.BorderSize = 0;
            btnEditarPartida.FlatStyle = FlatStyle.Flat;
            btnEditarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarPartida.ForeColor = Color.Black;
            btnEditarPartida.Location = new Point(185, 274);
            btnEditarPartida.Name = "btnEditarPartida";
            btnEditarPartida.Size = new Size(82, 36);
            btnEditarPartida.TabIndex = 9;
            btnEditarPartida.Text = "Editar";
            btnEditarPartida.TextColor = Color.Black;
            btnEditarPartida.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(dgDocumentosPartida);
            groupBox2.Location = new Point(496, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 316);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Documentos";
            // 
            // dgDocumentosPartida
            // 
            dgDocumentosPartida.AllowUserToAddRows = false;
            dgDocumentosPartida.BackgroundColor = SystemColors.GradientActiveCaption;
            dgDocumentosPartida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDocumentosPartida.Location = new Point(40, 54);
            dgDocumentosPartida.Name = "dgDocumentosPartida";
            dgDocumentosPartida.ReadOnly = true;
            dgDocumentosPartida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDocumentosPartida.Size = new Size(244, 199);
            dgDocumentosPartida.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(lblPruebas66);
            panel1.Controls.Add(btnFinalizarPartida);
            panel1.Location = new Point(35, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 47);
            panel1.TabIndex = 12;
            // 
            // lblPruebas66
            // 
            lblPruebas66.AutoSize = true;
            lblPruebas66.Location = new Point(101, 17);
            lblPruebas66.Name = "lblPruebas66";
            lblPruebas66.Size = new Size(38, 15);
            lblPruebas66.TabIndex = 8;
            lblPruebas66.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 167, 198);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 29);
            panel2.TabIndex = 43;
            // 
            // panelstv1
            // 
            panelstv1.ColorBottom = Color.FromArgb(6, 159, 210);
            panelstv1.ColorTop = Color.FromArgb(0, 72, 131);
            panelstv1.Dock = DockStyle.Top;
            panelstv1.Location = new Point(0, 0);
            panelstv1.Name = "panelstv1";
            panelstv1.Size = new Size(855, 12);
            panelstv1.TabIndex = 44;
            // 
            // panelNombreEvento
            // 
            panelNombreEvento.BackColor = SystemColors.Control;
            panelNombreEvento.Controls.Add(lblTituloPartida);
            panelNombreEvento.Location = new Point(35, 27);
            panelNombreEvento.Name = "panelNombreEvento";
            panelNombreEvento.Size = new Size(784, 42);
            panelNombreEvento.TabIndex = 45;
            // 
            // ConsultarPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(855, 488);
            Controls.Add(panelNombreEvento);
            Controls.Add(panelstv1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ConsultarPartida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Partida";
            ((System.ComponentModel.ISupportInitialize)dgDatosPartida).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDocumentosPartida).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelNombreEvento.ResumeLayout(false);
            panelNombreEvento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloPartida;
        private ControlSTV.ButtonSTV btnEliminarPartida;
        private ControlSTV.ButtonSTV btnAgregarPartida;
        private ControlSTV.ButtonSTV btnFinalizarPartida;
        private DataGridView dgDatosPartida;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgDocumentosPartida;
        private ControlSTV.ButtonSTV btnEditarPartida;
        private Panel panel1;
        private TextBox txtBusquedaPartida;
        private Panel panel2;
        private ControlSTV.PanelSTV panelstv1;
        private Panel panelNombreEvento;
        private Label lblPruebas66;
    }
}