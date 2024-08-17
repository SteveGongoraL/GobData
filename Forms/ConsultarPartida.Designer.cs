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
            btnEliminarPartida = new ControlSTV.ButtonSTV();
            btnAgregarPartida = new ControlSTV.ButtonSTV();
            btnFinalizarPartida = new ControlSTV.ButtonSTV();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            btnEditarPartida = new ControlSTV.ButtonSTV();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
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
            // btnEliminarPartida
            // 
            btnEliminarPartida.BackColor = Color.FromArgb(254, 143, 143);
            btnEliminarPartida.BackgroundColor = Color.FromArgb(254, 143, 143);
            btnEliminarPartida.BorderColor = Color.FromArgb(239, 75, 94);
            btnEliminarPartida.BorderRadius = 36;
            btnEliminarPartida.BorderSize = 2;
            btnEliminarPartida.FlatAppearance.BorderSize = 0;
            btnEliminarPartida.FlatStyle = FlatStyle.Flat;
            btnEliminarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminarPartida.ForeColor = Color.White;
            btnEliminarPartida.Location = new Point(139, 242);
            btnEliminarPartida.Name = "btnEliminarPartida";
            btnEliminarPartida.Size = new Size(82, 36);
            btnEliminarPartida.TabIndex = 6;
            btnEliminarPartida.Text = "Eliminar";
            btnEliminarPartida.TextColor = Color.White;
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
            btnFinalizarPartida.Location = new Point(351, 9);
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
            groupBox1.Controls.Add(btnEditarPartida);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnAgregarPartida);
            groupBox1.Controls.Add(btnEliminarPartida);
            groupBox1.Location = new Point(35, 43);
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
            groupBox2.Location = new Point(496, 43);
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
            // btnEditarPartida
            // 
            btnEditarPartida.BackColor = Color.LightSteelBlue;
            btnEditarPartida.BackgroundColor = Color.LightSteelBlue;
            btnEditarPartida.BorderColor = Color.FromArgb(59, 167, 198);
            btnEditarPartida.BorderRadius = 36;
            btnEditarPartida.BorderSize = 2;
            btnEditarPartida.FlatAppearance.BorderSize = 0;
            btnEditarPartida.FlatStyle = FlatStyle.Flat;
            btnEditarPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditarPartida.ForeColor = Color.White;
            btnEditarPartida.Location = new Point(227, 242);
            btnEditarPartida.Name = "btnEditarPartida";
            btnEditarPartida.Size = new Size(82, 36);
            btnEditarPartida.TabIndex = 9;
            btnEditarPartida.Text = "Editar";
            btnEditarPartida.TextColor = Color.White;
            btnEditarPartida.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnFinalizarPartida);
            panel1.Location = new Point(35, 343);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 54);
            panel1.TabIndex = 12;
            // 
            // ConsultarPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 408);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private ControlSTV.ButtonSTV btnEliminarPartida;
        private ControlSTV.ButtonSTV btnAgregarPartida;
        private ControlSTV.ButtonSTV btnFinalizarPartida;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private ControlSTV.ButtonSTV btnEditarPartida;
        private Panel panel1;
    }
}