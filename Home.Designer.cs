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
            buttonstv1 = new ControlSTV.ButtonSTV();
            textBoxstv1 = new ControlSTV.TextBoxSTV();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonstv1
            // 
            buttonstv1.BackColor = Color.MediumSlateBlue;
            buttonstv1.BackgroundColor = Color.MediumSlateBlue;
            buttonstv1.BorderColor = Color.PaleVioletRed;
            buttonstv1.BorderRadius = 40;
            buttonstv1.BorderSize = 0;
            buttonstv1.FlatAppearance.BorderSize = 0;
            buttonstv1.FlatStyle = FlatStyle.Flat;
            buttonstv1.ForeColor = Color.White;
            buttonstv1.Location = new Point(135, 282);
            buttonstv1.Name = "buttonstv1";
            buttonstv1.Size = new Size(150, 40);
            buttonstv1.TabIndex = 0;
            buttonstv1.Text = "buttonstv1";
            buttonstv1.TextColor = Color.White;
            buttonstv1.UseVisualStyleBackColor = false;
            buttonstv1.Click += buttonstv1_Click;
            // 
            // textBoxstv1
            // 
            textBoxstv1.BackColor = SystemColors.Window;
            textBoxstv1.BorderColor = Color.MediumSlateBlue;
            textBoxstv1.BorderFocusColor = Color.HotPink;
            textBoxstv1.BorderSize = 2;
            textBoxstv1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxstv1.ForeColor = Color.DimGray;
            textBoxstv1.Location = new Point(98, 231);
            textBoxstv1.Margin = new Padding(4);
            textBoxstv1.Multiline = false;
            textBoxstv1.Name = "textBoxstv1";
            textBoxstv1.Padding = new Padding(7);
            textBoxstv1.PasswordChar = false;
            textBoxstv1.Size = new Size(250, 31);
            textBoxstv1.TabIndex = 1;
            textBoxstv1.Texts = "";
            textBoxstv1.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Location = new Point(-9, 430);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 28);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(buttonstv1);
            groupBox1.Controls.Add(textBoxstv1);
            groupBox1.Location = new Point(81, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 369);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.GD_Logo;
            pictureBox1.Location = new Point(88, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(588, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ControlSTV.ButtonSTV buttonstv1;
        private ControlSTV.TextBoxSTV textBoxstv1;
        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}
