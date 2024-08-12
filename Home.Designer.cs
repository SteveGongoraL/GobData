namespace GobData
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnRegistrarEvento = new ControlSTV.ButtonSTV();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelstv1 = new ControlSTV.PanelSTV();
            btnConsultarEvento = new ControlSTV.ButtonSTV();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarEvento
            // 
            btnRegistrarEvento.BackColor = Color.LightSteelBlue;
            btnRegistrarEvento.BackgroundColor = Color.LightSteelBlue;
            btnRegistrarEvento.BorderColor = Color.FromArgb(59, 167, 198);
            btnRegistrarEvento.BorderRadius = 40;
            btnRegistrarEvento.BorderSize = 2;
            btnRegistrarEvento.FlatAppearance.BorderSize = 0;
            btnRegistrarEvento.FlatStyle = FlatStyle.Flat;
            btnRegistrarEvento.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistrarEvento.ForeColor = Color.White;
            btnRegistrarEvento.Location = new Point(91, 222);
            btnRegistrarEvento.Name = "btnRegistrarEvento";
            btnRegistrarEvento.Size = new Size(251, 45);
            btnRegistrarEvento.TabIndex = 0;
            btnRegistrarEvento.Text = "Registrar evento";
            btnRegistrarEvento.TextColor = Color.White;
            btnRegistrarEvento.UseVisualStyleBackColor = false;
            btnRegistrarEvento.Click += btnRegistrarEvento_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 167, 198);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 425);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 25);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.GD_Logo;
            pictureBox1.Location = new Point(82, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 242, 244);
            panel2.Controls.Add(btnConsultarEvento);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnRegistrarEvento);
            panel2.Location = new Point(79, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 380);
            panel2.TabIndex = 3;
            // 
            // panelstv1
            // 
            panelstv1.ColorBottom = Color.FromArgb(6, 159, 210);
            panelstv1.ColorTop = Color.FromArgb(0, 72, 131);
            panelstv1.Dock = DockStyle.Top;
            panelstv1.Location = new Point(0, 0);
            panelstv1.Name = "panelstv1";
            panelstv1.Size = new Size(588, 12);
            panelstv1.TabIndex = 4;
            // 
            // btnConsultarEvento
            // 
            btnConsultarEvento.BackColor = Color.LightSteelBlue;
            btnConsultarEvento.BackgroundColor = Color.LightSteelBlue;
            btnConsultarEvento.BorderColor = Color.FromArgb(59, 167, 198);
            btnConsultarEvento.BorderRadius = 40;
            btnConsultarEvento.BorderSize = 2;
            btnConsultarEvento.FlatAppearance.BorderSize = 0;
            btnConsultarEvento.FlatStyle = FlatStyle.Flat;
            btnConsultarEvento.Font = new Font("Arial Narrow", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConsultarEvento.ForeColor = Color.White;
            btnConsultarEvento.Location = new Point(91, 284);
            btnConsultarEvento.Name = "btnConsultarEvento";
            btnConsultarEvento.Size = new Size(251, 45);
            btnConsultarEvento.TabIndex = 3;
            btnConsultarEvento.Text = "Consultar eventos";
            btnConsultarEvento.TextColor = Color.White;
            btnConsultarEvento.UseVisualStyleBackColor = false;
            btnConsultarEvento.Click += btnConsultarEvento_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(588, 450);
            Controls.Add(panelstv1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ControlSTV.ButtonSTV btnRegistrarEvento;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ControlSTV.PanelSTV panelstv1;
        private ControlSTV.ButtonSTV btnConsultarEvento;
    }
}
