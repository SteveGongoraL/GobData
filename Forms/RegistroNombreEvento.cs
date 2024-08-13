using GobData.Utilities;
using System.Configuration;

namespace GobData
{
    public partial class RegistroNombreEvento : Form
    {
        private NombreEvento nombreEvento;
        int IdEvento;

        public RegistroNombreEvento()
        {
            InitializeComponent();
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            nombreEvento = new NombreEvento(conexion);
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
                // Recopilar los parametros necesarios
                ParametrosNombreEvento parametrosNombreEvento = new ParametrosNombreEvento
                {
                    Mes = cbMesEvento.SelectedItem.ToString(),
                    Dia = Convert.ToInt32(txtDiaEvento.Text),
                    Estado = txtEstadoEvento.Text.ToUpper(),
                    Convocante = txtConvocanteEvento.Text.ToUpper(),
                    NumeroEvento = txtNumeroEvento.Text.ToUpper(),
                    Division = cbDivisionEvento.SelectedItem.ToString()
                };


                // Guardar la información
                try
                {
                    IdEvento = nombreEvento.InsertEventName(parametrosNombreEvento);
                    MessageBox.Show("Operación realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                
                
                // Cambiar de ventana
                RegistrarEvento registrarEvento = new RegistrarEvento(Convert.ToString(IdEvento));
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
