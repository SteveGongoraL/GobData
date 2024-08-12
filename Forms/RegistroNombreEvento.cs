using GobData.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GobData
{
    public partial class RegistroNombreEvento : Form
    {
        string[] datosRegistro = new string[6];
        public RegistroNombreEvento()
        {
            InitializeComponent();
        }


        // Funcionalidad en Boton Cancelar
        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }


        // Funcionalidad en Boton Guardar Registro
        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            // Validar que todos los textbox esten llenos
            if(!FormUtilities.ValidarTextBox(panelPrincipal))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Validar que los combobox esten seleccionados
            else if(!FormUtilities.ValidarComboBox(panelPrincipal))
            {
                MessageBox.Show("Debes seleccionar una opción en todos los ComboBox.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Guardar la información
                datosRegistro[0] = txtMesEvento.Text;
                datosRegistro[1] = txtDiaEvento.Text;
                datosRegistro[2] = txtEstadoEvento.Text;
                datosRegistro[3] = txtConvocanteEvento.Text;
                datosRegistro[4] = txtNumeroEvento.Text;
                datosRegistro[5] = cbDivisionEvento.SelectedItem.ToString();

                string resultado = "";
                for (int y = 0; y < 6; y++)
                {
                    resultado += datosRegistro[y] + "\n";
                }
                MessageBox.Show(resultado);
                
                // Cambiar de ventana
                RegistrarEvento registrarEvento = new RegistrarEvento();
                registrarEvento.Show();
                this.Hide();
            }
        }


        // Restricciones de datos en los textbox
        private void onlyText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDiaEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
