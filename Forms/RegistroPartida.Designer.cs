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
            btnCancelarPartida = new ControlSTV.ButtonSTV();
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
            label14 = new Label();
            panelPrincipal = new Panel();
            cbMoneda = new ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
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
            btnGuardarPartida.ForeColor = Color.White;
            btnGuardarPartida.Location = new Point(238, 9);
            btnGuardarPartida.Name = "btnGuardarPartida";
            btnGuardarPartida.Size = new Size(82, 36);
            btnGuardarPartida.TabIndex = 15;
            btnGuardarPartida.Text = "Guardar";
            btnGuardarPartida.TextColor = Color.White;
            btnGuardarPartida.UseVisualStyleBackColor = false;
            btnGuardarPartida.Click += btnGuardarPartida_Click;
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
            btnCancelarPartida.Location = new Point(150, 9);
            btnCancelarPartida.Name = "btnCancelarPartida";
            btnCancelarPartida.Size = new Size(82, 36);
            btnCancelarPartida.TabIndex = 16;
            btnCancelarPartida.Text = "Cancelar";
            btnCancelarPartida.TextColor = Color.White;
            btnCancelarPartida.UseVisualStyleBackColor = false;
            // 
            // txtDescripcionPartida
            // 
            txtDescripcionPartida.Location = new Point(322, 13);
            txtDescripcionPartida.Name = "txtDescripcionPartida";
            txtDescripcionPartida.Size = new Size(120, 23);
            txtDescripcionPartida.TabIndex = 2;
            // 
            // lblEjemplo
            // 
            lblEjemplo.AutoSize = true;
            lblEjemplo.Location = new Point(244, 21);
            lblEjemplo.Name = "lblEjemplo";
            lblEjemplo.Size = new Size(72, 15);
            lblEjemplo.TabIndex = 10;
            lblEjemplo.Text = "Descripcion:";
            // 
            // txtNumeroPartida
            // 
            txtNumeroPartida.Location = new Point(90, 13);
            txtNumeroPartida.Name = "txtNumeroPartida";
            txtNumeroPartida.Size = new Size(120, 23);
            txtNumeroPartida.TabIndex = 1;
            txtNumeroPartida.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 12;
            label1.Text = "No. Partida:";
            // 
            // txtCantidadMinimo
            // 
            txtCantidadMinimo.Location = new Point(90, 42);
            txtCantidadMinimo.Name = "txtCantidadMinimo";
            txtCantidadMinimo.Size = new Size(120, 23);
            txtCantidadMinimo.TabIndex = 3;
            txtCantidadMinimo.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 50);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 14;
            label2.Text = "Minimo:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(90, 100);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(120, 23);
            txtMarca.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 108);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 18;
            label3.Text = "Marca:";
            // 
            // txtMedida
            // 
            txtMedida.Location = new Point(90, 71);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(120, 23);
            txtMedida.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 79);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 16;
            label4.Text = "Medida:";
            // 
            // txtCatalogo
            // 
            txtCatalogo.Location = new Point(90, 129);
            txtCatalogo.Name = "txtCatalogo";
            txtCatalogo.Size = new Size(120, 23);
            txtCatalogo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 137);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 20;
            label5.Text = "Catalogo:";
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(322, 158);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(120, 23);
            txtFabricante.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 166);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 22;
            label6.Text = "Fabricante:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 195);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 24;
            label7.Text = "Moneda:";
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(322, 187);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(120, 23);
            txtCambio.TabIndex = 14;
            txtCambio.KeyPress += txtDecimal_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(264, 195);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 36;
            label8.Text = "Cambio:";
            // 
            // txtGanancia
            // 
            txtGanancia.Location = new Point(90, 158);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(120, 23);
            txtGanancia.TabIndex = 11;
            txtGanancia.KeyPress += txtDecimal_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 166);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 34;
            label9.Text = "Ganancia:";
            // 
            // txtCostoUnitario
            // 
            txtCostoUnitario.Location = new Point(322, 129);
            txtCostoUnitario.Name = "txtCostoUnitario";
            txtCostoUnitario.Size = new Size(120, 23);
            txtCostoUnitario.TabIndex = 10;
            txtCostoUnitario.KeyPress += txtDecimal_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(230, 137);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 32;
            label10.Text = "Costo Unitario:";
            // 
            // txtPaisOrigen
            // 
            txtPaisOrigen.Location = new Point(322, 100);
            txtPaisOrigen.Name = "txtPaisOrigen";
            txtPaisOrigen.Size = new Size(120, 23);
            txtPaisOrigen.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(246, 108);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 30;
            label11.Text = "Pais Origen:";
            // 
            // txtSeOfrece
            // 
            txtSeOfrece.Location = new Point(322, 71);
            txtSeOfrece.Name = "txtSeOfrece";
            txtSeOfrece.Size = new Size(120, 23);
            txtSeOfrece.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(256, 79);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 28;
            label12.Text = "Se Ofrece:";
            // 
            // txtCantidadMaxima
            // 
            txtCantidadMaxima.Location = new Point(322, 42);
            txtCantidadMaxima.Name = "txtCantidadMaxima";
            txtCantidadMaxima.Size = new Size(120, 23);
            txtCantidadMaxima.TabIndex = 4;
            txtCantidadMaxima.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(262, 50);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 26;
            label13.Text = "Maximo:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 15.75F);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(150, 11);
            label14.Name = "label14";
            label14.Size = new Size(171, 24);
            label14.TabIndex = 37;
            label14.Text = "Registrar Partida";
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.Controls.Add(cbMoneda);
            panelPrincipal.Controls.Add(txtCambio);
            panelPrincipal.Controls.Add(lblEjemplo);
            panelPrincipal.Controls.Add(txtDescripcionPartida);
            panelPrincipal.Controls.Add(label8);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(txtGanancia);
            panelPrincipal.Controls.Add(txtNumeroPartida);
            panelPrincipal.Controls.Add(label9);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(txtCostoUnitario);
            panelPrincipal.Controls.Add(txtCantidadMinimo);
            panelPrincipal.Controls.Add(label10);
            panelPrincipal.Controls.Add(label4);
            panelPrincipal.Controls.Add(txtPaisOrigen);
            panelPrincipal.Controls.Add(txtMedida);
            panelPrincipal.Controls.Add(label11);
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
            panelPrincipal.Location = new Point(27, 63);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(480, 222);
            panelPrincipal.TabIndex = 38;
            // 
            // cbMoneda
            // 
            cbMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMoneda.FormattingEnabled = true;
            cbMoneda.ItemHeight = 15;
            cbMoneda.Items.AddRange(new object[] { "EUR", "GBP", "JPY", "MXN", "USD" });
            cbMoneda.Location = new Point(90, 187);
            cbMoneda.Name = "cbMoneda";
            cbMoneda.Size = new Size(121, 23);
            cbMoneda.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnGuardarPartida);
            panel2.Controls.Add(btnCancelarPartida);
            panel2.Location = new Point(27, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 54);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label14);
            panel3.Location = new Point(27, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 45);
            panel3.TabIndex = 40;
            // 
            // RegistroPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 357);
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
        private ControlSTV.ButtonSTV btnCancelarPartida;
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
        private Label label14;
        private Panel panelPrincipal;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbMoneda;
    }
}