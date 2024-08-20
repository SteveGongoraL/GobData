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
            dgvDatosPartida = new DataGridView();
            gbInfoPartida = new GroupBox();
            btnClearPartida = new ControlSTV.ButtonSTV();
            txtBusquedaPartida = new TextBox();
            btnEditarPartida = new ControlSTV.ButtonSTV();
            groupBox2 = new GroupBox();
            lblTitulo = new Label();
            btnEliminarDoc = new ControlSTV.ButtonSTV();
            btnVerDoc = new ControlSTV.ButtonSTV();
            btnAgregarDoc = new ControlSTV.ButtonSTV();
            dgvDocumentosPartida = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panelstv1 = new ControlSTV.PanelSTV();
            panelNombreEvento = new Panel();
            pictureBack = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPartida).BeginInit();
            gbInfoPartida.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentosPartida).BeginInit();
            panel1.SuspendLayout();
            panelNombreEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).BeginInit();
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
            btnEliminarPartida.BorderRadius = 30;
            btnEliminarPartida.BorderSize = 1;
            btnEliminarPartida.Cursor = Cursors.Hand;
            btnEliminarPartida.FlatAppearance.BorderSize = 0;
            btnEliminarPartida.FlatStyle = FlatStyle.Flat;
            btnEliminarPartida.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarPartida.ForeColor = Color.Black;
            btnEliminarPartida.Location = new Point(97, 274);
            btnEliminarPartida.Name = "btnEliminarPartida";
            btnEliminarPartida.Size = new Size(82, 36);
            btnEliminarPartida.TabIndex = 5;
            btnEliminarPartida.Text = "Eliminar";
            btnEliminarPartida.TextColor = Color.Black;
            btnEliminarPartida.UseVisualStyleBackColor = false;
            btnEliminarPartida.Click += btnEliminarPartida_Click;
            // 
            // btnAgregarPartida
            // 
            btnAgregarPartida.BackColor = Color.LightSteelBlue;
            btnAgregarPartida.BackgroundColor = Color.LightSteelBlue;
            btnAgregarPartida.BorderColor = Color.FromArgb(59, 167, 198);
            btnAgregarPartida.BorderRadius = 30;
            btnAgregarPartida.BorderSize = 1;
            btnAgregarPartida.Cursor = Cursors.Hand;
            btnAgregarPartida.FlatAppearance.BorderSize = 0;
            btnAgregarPartida.FlatStyle = FlatStyle.Flat;
            btnAgregarPartida.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarPartida.ForeColor = Color.Black;
            btnAgregarPartida.Location = new Point(273, 274);
            btnAgregarPartida.Name = "btnAgregarPartida";
            btnAgregarPartida.Size = new Size(82, 36);
            btnAgregarPartida.TabIndex = 3;
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
            btnFinalizarPartida.BorderRadius = 5;
            btnFinalizarPartida.BorderSize = 1;
            btnFinalizarPartida.Cursor = Cursors.Hand;
            btnFinalizarPartida.FlatAppearance.BorderSize = 0;
            btnFinalizarPartida.FlatStyle = FlatStyle.Flat;
            btnFinalizarPartida.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarPartida.ForeColor = Color.Black;
            btnFinalizarPartida.Location = new Point(320, 6);
            btnFinalizarPartida.Name = "btnFinalizarPartida";
            btnFinalizarPartida.Size = new Size(147, 36);
            btnFinalizarPartida.TabIndex = 6;
            btnFinalizarPartida.Text = "Finalizar";
            btnFinalizarPartida.TextColor = Color.Black;
            btnFinalizarPartida.UseVisualStyleBackColor = false;
            btnFinalizarPartida.Click += btnFinalizarPartida_Click;
            // 
            // dgvDatosPartida
            // 
            dgvDatosPartida.AllowUserToAddRows = false;
            dgvDatosPartida.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvDatosPartida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPartida.Location = new Point(16, 63);
            dgvDatosPartida.Name = "dgvDatosPartida";
            dgvDatosPartida.ReadOnly = true;
            dgvDatosPartida.RowHeadersVisible = false;
            dgvDatosPartida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosPartida.Size = new Size(421, 205);
            dgvDatosPartida.TabIndex = 9;
            // 
            // gbInfoPartida
            // 
            gbInfoPartida.BackColor = SystemColors.Control;
            gbInfoPartida.Controls.Add(btnClearPartida);
            gbInfoPartida.Controls.Add(txtBusquedaPartida);
            gbInfoPartida.Controls.Add(btnEditarPartida);
            gbInfoPartida.Controls.Add(dgvDatosPartida);
            gbInfoPartida.Controls.Add(btnAgregarPartida);
            gbInfoPartida.Controls.Add(btnEliminarPartida);
            gbInfoPartida.Location = new Point(35, 79);
            gbInfoPartida.Name = "gbInfoPartida";
            gbInfoPartida.Size = new Size(455, 316);
            gbInfoPartida.TabIndex = 10;
            gbInfoPartida.TabStop = false;
            gbInfoPartida.Text = "Información de Partidas";
            // 
            // btnClearPartida
            // 
            btnClearPartida.BackColor = Color.FromArgb(162, 219, 250);
            btnClearPartida.BackgroundColor = Color.FromArgb(162, 219, 250);
            btnClearPartida.BorderColor = Color.FromArgb(57, 162, 219);
            btnClearPartida.BorderRadius = 0;
            btnClearPartida.BorderSize = 1;
            btnClearPartida.Cursor = Cursors.Hand;
            btnClearPartida.FlatAppearance.BorderSize = 0;
            btnClearPartida.FlatStyle = FlatStyle.Flat;
            btnClearPartida.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearPartida.ForeColor = Color.Black;
            btnClearPartida.Location = new Point(337, 33);
            btnClearPartida.Name = "btnClearPartida";
            btnClearPartida.Size = new Size(100, 23);
            btnClearPartida.TabIndex = 2;
            btnClearPartida.Text = "Limpiar";
            btnClearPartida.TextColor = Color.Black;
            btnClearPartida.UseVisualStyleBackColor = false;
            btnClearPartida.Click += btnClearPartida_Click;
            // 
            // txtBusquedaPartida
            // 
            txtBusquedaPartida.Cursor = Cursors.IBeam;
            txtBusquedaPartida.Location = new Point(16, 34);
            txtBusquedaPartida.Name = "txtBusquedaPartida";
            txtBusquedaPartida.Size = new Size(315, 23);
            txtBusquedaPartida.TabIndex = 1;
            txtBusquedaPartida.TextChanged += txtBusquedaPartida_TextChanged;
            // 
            // btnEditarPartida
            // 
            btnEditarPartida.BackColor = Color.LightSteelBlue;
            btnEditarPartida.BackgroundColor = Color.LightSteelBlue;
            btnEditarPartida.BorderColor = Color.FromArgb(59, 167, 198);
            btnEditarPartida.BorderRadius = 30;
            btnEditarPartida.BorderSize = 1;
            btnEditarPartida.Cursor = Cursors.Hand;
            btnEditarPartida.FlatAppearance.BorderSize = 0;
            btnEditarPartida.FlatStyle = FlatStyle.Flat;
            btnEditarPartida.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarPartida.ForeColor = Color.Black;
            btnEditarPartida.Location = new Point(185, 274);
            btnEditarPartida.Name = "btnEditarPartida";
            btnEditarPartida.Size = new Size(82, 36);
            btnEditarPartida.TabIndex = 4;
            btnEditarPartida.Text = "Editar";
            btnEditarPartida.TextColor = Color.Black;
            btnEditarPartida.UseVisualStyleBackColor = false;
            btnEditarPartida.Click += btnEditarPartida_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(lblTitulo);
            groupBox2.Controls.Add(btnEliminarDoc);
            groupBox2.Controls.Add(btnVerDoc);
            groupBox2.Controls.Add(btnAgregarDoc);
            groupBox2.Controls.Add(dgvDocumentosPartida);
            groupBox2.Location = new Point(496, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 316);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Crimson;
            lblTitulo.Location = new Point(30, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 24);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Documentos disponibles";
            // 
            // btnEliminarDoc
            // 
            btnEliminarDoc.BackColor = Color.White;
            btnEliminarDoc.BackgroundColor = Color.White;
            btnEliminarDoc.BorderColor = Color.FromArgb(239, 75, 94);
            btnEliminarDoc.BorderRadius = 20;
            btnEliminarDoc.BorderSize = 1;
            btnEliminarDoc.Cursor = Cursors.Hand;
            btnEliminarDoc.FlatAppearance.BorderSize = 0;
            btnEliminarDoc.FlatStyle = FlatStyle.Flat;
            btnEliminarDoc.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarDoc.ForeColor = Color.Black;
            btnEliminarDoc.Location = new Point(212, 274);
            btnEliminarDoc.Name = "btnEliminarDoc";
            btnEliminarDoc.Size = new Size(82, 36);
            btnEliminarDoc.TabIndex = 12;
            btnEliminarDoc.Text = "Eliminar";
            btnEliminarDoc.TextColor = Color.Black;
            btnEliminarDoc.UseVisualStyleBackColor = false;
            btnEliminarDoc.Click += btnEliminarDoc_Click;
            // 
            // btnVerDoc
            // 
            btnVerDoc.BackColor = Color.White;
            btnVerDoc.BackgroundColor = Color.White;
            btnVerDoc.BorderColor = Color.FromArgb(59, 167, 198);
            btnVerDoc.BorderRadius = 20;
            btnVerDoc.BorderSize = 1;
            btnVerDoc.Cursor = Cursors.Hand;
            btnVerDoc.FlatAppearance.BorderSize = 0;
            btnVerDoc.FlatStyle = FlatStyle.Flat;
            btnVerDoc.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerDoc.ForeColor = Color.Black;
            btnVerDoc.Location = new Point(116, 274);
            btnVerDoc.Name = "btnVerDoc";
            btnVerDoc.Size = new Size(90, 36);
            btnVerDoc.TabIndex = 11;
            btnVerDoc.Text = "Ver Archivo";
            btnVerDoc.TextColor = Color.Black;
            btnVerDoc.UseVisualStyleBackColor = false;
            btnVerDoc.Click += btnVerDoc_Click;
            // 
            // btnAgregarDoc
            // 
            btnAgregarDoc.BackColor = Color.White;
            btnAgregarDoc.BackgroundColor = Color.White;
            btnAgregarDoc.BorderColor = Color.FromArgb(59, 167, 198);
            btnAgregarDoc.BorderRadius = 20;
            btnAgregarDoc.BorderSize = 1;
            btnAgregarDoc.Cursor = Cursors.Hand;
            btnAgregarDoc.FlatAppearance.BorderSize = 0;
            btnAgregarDoc.FlatStyle = FlatStyle.Flat;
            btnAgregarDoc.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarDoc.ForeColor = Color.Black;
            btnAgregarDoc.Location = new Point(28, 274);
            btnAgregarDoc.Name = "btnAgregarDoc";
            btnAgregarDoc.Size = new Size(82, 36);
            btnAgregarDoc.TabIndex = 10;
            btnAgregarDoc.Text = "Agregar";
            btnAgregarDoc.TextColor = Color.Black;
            btnAgregarDoc.UseVisualStyleBackColor = false;
            btnAgregarDoc.Click += btnAgregarDoc_Click;
            // 
            // dgvDocumentosPartida
            // 
            dgvDocumentosPartida.AllowUserToAddRows = false;
            dgvDocumentosPartida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocumentosPartida.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvDocumentosPartida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocumentosPartida.Location = new Point(28, 63);
            dgvDocumentosPartida.Name = "dgvDocumentosPartida";
            dgvDocumentosPartida.ReadOnly = true;
            dgvDocumentosPartida.RowHeadersVisible = false;
            dgvDocumentosPartida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocumentosPartida.Size = new Size(266, 205);
            dgvDocumentosPartida.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnFinalizarPartida);
            panel1.Location = new Point(35, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 47);
            panel1.TabIndex = 12;
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
            panelNombreEvento.Controls.Add(pictureBack);
            panelNombreEvento.Controls.Add(lblTituloPartida);
            panelNombreEvento.Location = new Point(35, 27);
            panelNombreEvento.Name = "panelNombreEvento";
            panelNombreEvento.Size = new Size(784, 42);
            panelNombreEvento.TabIndex = 45;
            // 
            // pictureBack
            // 
            pictureBack.Cursor = Cursors.Hand;
            pictureBack.Image = Properties.Resources.Arrow;
            pictureBack.Location = new Point(736, 0);
            pictureBack.Name = "pictureBack";
            pictureBack.Size = new Size(45, 42);
            pictureBack.TabIndex = 1;
            pictureBack.TabStop = false;
            pictureBack.Click += pictureBack_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            Controls.Add(gbInfoPartida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ConsultarPartida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Partida";
            ((System.ComponentModel.ISupportInitialize)dgvDatosPartida).EndInit();
            gbInfoPartida.ResumeLayout(false);
            gbInfoPartida.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentosPartida).EndInit();
            panel1.ResumeLayout(false);
            panelNombreEvento.ResumeLayout(false);
            panelNombreEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloPartida;
        private ControlSTV.ButtonSTV btnEliminarPartida;
        private ControlSTV.ButtonSTV btnAgregarPartida;
        private ControlSTV.ButtonSTV btnFinalizarPartida;
        private DataGridView dgvDatosPartida;
        private GroupBox gbInfoPartida;
        private GroupBox groupBox2;
        private DataGridView dgvDocumentosPartida;
        private ControlSTV.ButtonSTV btnEditarPartida;
        private Panel panel1;
        private TextBox txtBusquedaPartida;
        private Panel panel2;
        private ControlSTV.PanelSTV panelstv1;
        private Panel panelNombreEvento;
        private PictureBox pictureBack;
        private ControlSTV.ButtonSTV btnClearPartida;
        private ControlSTV.ButtonSTV btnAgregarDoc;
        private ControlSTV.ButtonSTV btnEliminarDoc;
        private ControlSTV.ButtonSTV btnVerDoc;
        private OpenFileDialog openFileDialog1;
        private Label lblTitulo;
    }
}