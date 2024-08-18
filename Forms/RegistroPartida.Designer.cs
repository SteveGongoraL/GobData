namespace GobData
{
    partial class RegistroPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPartida));
            btnGuardarPartida = new ControlSTV.ButtonSTV();
            btnVolverPartida = new ControlSTV.ButtonSTV();
            txtDescripcionPartida = new TextBox();
            lblEjemplo = new Label();
            txtNumeroPartida = new TextBox();
            label1 = new Label();
            txtCantidadMinimo = new TextBox();
            label2 = new Label();
            txtMarca = new TextBox();
            label3 = new Label();
            txtMedida = new TextBox();
            label4 = new Label();
            txtCatalogo = new TextBox();
            label5 = new Label();
            txtFabricante = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtCambio = new TextBox();
            label8 = new Label();
            txtGanancia = new TextBox();
            label9 = new Label();
            txtCostoUnitario = new TextBox();
            label10 = new Label();
            txtPaisOrigen = new TextBox();
            label11 = new Label();
            txtSeOfrece = new TextBox();
            label12 = new Label();
            txtCantidadMaxima = new TextBox();
            label13 = new Label();
            lblTituloRegisto = new Label();
            panelPrincipal = new Panel();
            cbMoneda = new ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panelstv1 = new ControlSTV.PanelSTV();
            panel1 = new Panel();
            panelPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            btnGuardarPartida.ForeColor = Color.Black;
            btnGuardarPartida.Location = new Point(260, 9);
            btnGuardarPartida.Name = "btnGuardarPartida";
            btnGuardarPartida.Size = new Size(96, 36);
            btnGuardarPartida.TabIndex = 15;
            btnGuardarPartida.Text = "Guardar";
            btnGuardarPartida.TextColor = Color.Black;
            btnGuardarPartida.UseVisualStyleBackColor = false;
            btnGuardarPartida.Click += btnGuardarPartida_Click;
            // 
            // btnVolverPartida
            // 
            btnVolverPartida.BackColor = Color.FromArgb(254, 143, 143);
            btnVolverPartida.BackgroundColor = Color.FromArgb(254, 143, 143);
            btnVolverPartida.BorderColor = Color.FromArgb(239, 75, 94);
            btnVolverPartida.BorderRadius = 36;
            btnVolverPartida.BorderSize = 2;
            btnVolverPartida.FlatAppearance.BorderSize = 0;
            btnVolverPartida.FlatStyle = FlatStyle.Flat;
            btnVolverPartida.Font = new Font("Arial Narrow", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolverPartida.ForeColor = Color.Black;
            btnVolverPartida.Location = new Point(158, 9);
            btnVolverPartida.Name = "btnVolverPartida";
            btnVolverPartida.Size = new Size(96, 36);
            btnVolverPartida.TabIndex = 16;
            btnVolverPartida.Text = "Volver";
            btnVolverPartida.TextColor = Color.Black;
            btnVolverPartida.UseVisualStyleBackColor = false;
            btnVolverPartida.Click += btnVolverPartida_Click;
            // 
            // txtDescripcionPartida
            // 
            txtDescripcionPartida.Location = new Point(378, 13);
            txtDescripcionPartida.Name = "txtDescripcionPartida";
            txtDescripcionPartida.Size = new Size(120, 23);
            txtDescripcionPartida.TabIndex = 2;
            // 
            // lblEjemplo
            // 
            lblEjemplo.AutoSize = true;
            lblEjemplo.Location = new Point(300, 21);
            lblEjemplo.Name = "lblEjemplo";
            lblEjemplo.Size = new Size(72, 15);
            lblEjemplo.TabIndex = 10;
            lblEjemplo.Text = "Descripción:";
            // 
            // txtNumeroPartida
            // 
            txtNumeroPartida.Location = new Point(124, 13);
            txtNumeroPartida.Name = "txtNumeroPartida";
            txtNumeroPartida.Size = new Size(120, 23);
            txtNumeroPartida.TabIndex = 1;
            txtNumeroPartida.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 21);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 12;
            label1.Text = "Numero de partida:";
            // 
            // txtCantidadMinimo
            // 
            txtCantidadMinimo.Location = new Point(124, 42);
            txtCantidadMinimo.Name = "txtCantidadMinimo";
            txtCantidadMinimo.Size = new Size(120, 23);
            txtCantidadMinimo.TabIndex = 3;
            txtCantidadMinimo.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 50);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 14;
            label2.Text = "Cantidad mínima:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(124, 100);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(120, 23);
            txtMarca.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 108);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 18;
            label3.Text = "Marca:";
            // 
            // txtMedida
            // 
            txtMedida.Location = new Point(124, 71);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(120, 23);
            txtMedida.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 79);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 16;
            label4.Text = "Unidad de medida:";
            // 
            // txtCatalogo
            // 
            txtCatalogo.Location = new Point(378, 100);
            txtCatalogo.Name = "txtCatalogo";
            txtCatalogo.Size = new Size(120, 23);
            txtCatalogo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 108);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 20;
            label5.Text = "Catalogo:";
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(377, 129);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(120, 23);
            txtFabricante.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 137);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 22;
            label6.Text = "Fabricante:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(318, 166);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 24;
            label7.Text = "Moneda:";
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(124, 187);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(120, 23);
            txtCambio.TabIndex = 13;
            txtCambio.KeyPress += txtDecimal_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 195);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 36;
            label8.Text = "Tasa de cambio:";
            // 
            // txtGanancia
            // 
            txtGanancia.Location = new Point(377, 187);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(120, 23);
            txtGanancia.TabIndex = 14;
            txtGanancia.KeyPress += txtDecimal_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(254, 195);
            label9.Name = "label9";
            label9.Size = new Size(118, 15);
            label9.TabIndex = 34;
            label9.Text = "Margen de ganancia:";
            // 
            // txtCostoUnitario
            // 
            txtCostoUnitario.Location = new Point(124, 158);
            txtCostoUnitario.Name = "txtCostoUnitario";
            txtCostoUnitario.Size = new Size(120, 23);
            txtCostoUnitario.TabIndex = 11;
            txtCostoUnitario.KeyPress += txtDecimal_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 166);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 32;
            label10.Text = "Costo unitario:";
            // 
            // txtPaisOrigen
            // 
            txtPaisOrigen.Location = new Point(124, 129);
            txtPaisOrigen.Name = "txtPaisOrigen";
            txtPaisOrigen.Size = new Size(120, 23);
            txtPaisOrigen.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 137);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 30;
            label11.Text = "País de origen:";
            // 
            // txtSeOfrece
            // 
            txtSeOfrece.Location = new Point(378, 71);
            txtSeOfrece.Name = "txtSeOfrece";
            txtSeOfrece.Size = new Size(120, 23);
            txtSeOfrece.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(312, 79);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 28;
            label12.Text = "Se ofrece:";
            // 
            // txtCantidadMaxima
            // 
            txtCantidadMaxima.Location = new Point(378, 42);
            txtCantidadMaxima.Name = "txtCantidadMaxima";
            txtCantidadMaxima.Size = new Size(120, 23);
            txtCantidadMaxima.TabIndex = 4;
            txtCantidadMaxima.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(268, 50);
            label13.Name = "label13";
            label13.Size = new Size(104, 15);
            label13.TabIndex = 26;
            label13.Text = "Cantidad máxima:";
            // 
            // lblTituloRegisto
            // 
            lblTituloRegisto.AutoSize = true;
            lblTituloRegisto.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloRegisto.ForeColor = Color.Crimson;
            lblTituloRegisto.Location = new Point(153, 8);
            lblTituloRegisto.Name = "lblTituloRegisto";
            lblTituloRegisto.Size = new Size(204, 30);
            lblTituloRegisto.TabIndex = 37;
            lblTituloRegisto.Text = "Registrar Partida";
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.Controls.Add(cbMoneda);
            panelPrincipal.Controls.Add(txtCambio);
            panelPrincipal.Controls.Add(label9);
            panelPrincipal.Controls.Add(label10);
            panelPrincipal.Controls.Add(txtGanancia);
            panelPrincipal.Controls.Add(txtCostoUnitario);
            panelPrincipal.Controls.Add(label11);
            panelPrincipal.Controls.Add(txtPaisOrigen);
            panelPrincipal.Controls.Add(lblEjemplo);
            panelPrincipal.Controls.Add(txtDescripcionPartida);
            panelPrincipal.Controls.Add(label8);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(txtNumeroPartida);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(txtCantidadMinimo);
            panelPrincipal.Controls.Add(label4);
            panelPrincipal.Controls.Add(txtMedida);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(txtSeOfrece);
            panelPrincipal.Controls.Add(txtMarca);
            panelPrincipal.Controls.Add(label12);
            panelPrincipal.Controls.Add(label5);
            panelPrincipal.Controls.Add(txtCantidadMaxima);
            panelPrincipal.Controls.Add(txtCatalogo);
            panelPrincipal.Controls.Add(label13);
            panelPrincipal.Controls.Add(label6);
            panelPrincipal.Controls.Add(txtFabricante);
            panelPrincipal.Controls.Add(label7);
            panelPrincipal.Location = new Point(27, 74);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(515, 222);
            panelPrincipal.TabIndex = 38;
            // 
            // cbMoneda
            // 
            cbMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMoneda.FormattingEnabled = true;
            cbMoneda.ItemHeight = 15;
            cbMoneda.Items.AddRange(new object[] { "EUR", "GBP", "JPY", "MXN", "USD" });
            cbMoneda.Location = new Point(377, 158);
            cbMoneda.Name = "cbMoneda";
            cbMoneda.Size = new Size(120, 23);
            cbMoneda.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnGuardarPartida);
            panel2.Controls.Add(btnVolverPartida);
            panel2.Location = new Point(27, 302);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 54);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblTituloRegisto);
            panel3.Location = new Point(27, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 45);
            panel3.TabIndex = 40;
            // 
            // panelstv1
            // 
            panelstv1.ColorBottom = Color.FromArgb(6, 159, 210);
            panelstv1.ColorTop = Color.FromArgb(0, 72, 131);
            panelstv1.Dock = DockStyle.Top;
            panelstv1.Location = new Point(0, 0);
            panelstv1.Name = "panelstv1";
            panelstv1.Size = new Size(571, 12);
            panelstv1.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 167, 198);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 369);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 25);
            panel1.TabIndex = 42;
            // 
            // RegistroPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 394);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panelstv1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistroPartida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroPartida";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ControlSTV.ButtonSTV btnGuardarPartida;
        private ControlSTV.ButtonSTV btnVolverPartida;
        private TextBox txtDescripcionPartida;
        private Label lblEjemplo;
        private TextBox txtNumeroPartida;
        private Label label1;
        private TextBox txtCantidadMinimo;
        private Label label2;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtMedida;
        private Label label4;
        private TextBox txtCatalogo;
        private Label label5;
        private TextBox txtFabricante;
        private Label label6;
        private Label label7;
        private TextBox txtCambio;
        private Label label8;
        private TextBox txtGanancia;
        private Label label9;
        private TextBox txtCostoUnitario;
        private Label label10;
        private TextBox txtPaisOrigen;
        private Label label11;
        private TextBox txtSeOfrece;
        private Label label12;
        private TextBox txtCantidadMaxima;
        private Label label13;
        private Label lblTituloRegisto;
        private Panel panelPrincipal;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbMoneda;
        private ControlSTV.PanelSTV panelstv1;
        private Panel panel1;
    }
}