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
            lblID = new Label();
            btnCancelarPartida = new ControlSTV.ButtonSTV();
            btnAgregarPartida = new ControlSTV.ButtonSTV();
            btnFinalizarPartida = new ControlSTV.ButtonSTV();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(58, 9);
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
            btnCancelarPartida.Location = new Point(227, 242);
            btnCancelarPartida.Name = "btnCancelarPartida";
            btnCancelarPartida.Size = new Size(82, 36);
            btnCancelarPartida.TabIndex = 6;
            btnCancelarPartida.Text = "Cancelar";
            btnCancelarPartida.TextColor = Color.White;
            btnCancelarPartida.UseVisualStyleBackColor = false;
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
            btnAgregarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregarPartida.ForeColor = Color.White;
            btnAgregarPartida.Location = new Point(315, 242);
            btnAgregarPartida.Name = "btnAgregarPartida";
            btnAgregarPartida.Size = new Size(82, 36);
            btnAgregarPartida.TabIndex = 5;
            btnAgregarPartida.Text = "Agregar";
            btnAgregarPartida.TextColor = Color.White;
            btnAgregarPartida.UseVisualStyleBackColor = false;
            btnAgregarPartida.Click += btnAgregarPartida_Click;
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
            btnFinalizarPartida.Location = new Point(422, 494);
            btnFinalizarPartida.Name = "btnFinalizarPartida";
            btnFinalizarPartida.Size = new Size(82, 36);
            btnFinalizarPartida.TabIndex = 7;
            btnFinalizarPartida.Text = "Finalizar";
            btnFinalizarPartida.TextColor = Color.Black;
            btnFinalizarPartida.UseVisualStyleBackColor = false;
            btnFinalizarPartida.Click += btnFinalizarPartida_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(355, 214);
            dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnAgregarPartida);
            groupBox1.Controls.Add(btnCancelarPartida);
            groupBox1.Location = new Point(58, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 294);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Partidas";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(523, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 294);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Documentos";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(38, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(244, 199);
            dataGridView2.TabIndex = 9;
            // 
            // ConsultarPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 542);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnFinalizarPartida);
            Controls.Add(lblID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ConsultarPartida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Partida";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private ControlSTV.ButtonSTV btnCancelarPartida;
        private ControlSTV.ButtonSTV btnAgregarPartida;
        private ControlSTV.ButtonSTV btnFinalizarPartida;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
    }
}