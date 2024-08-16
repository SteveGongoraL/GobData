using GobData.Utilities;
using Org.BouncyCastle.Asn1.Ocsp;

namespace GobData
{
    public partial class RegistroPartida : Form
    {
        string IdEventoPartida;

        public RegistroPartida(string IdEvento)
        {
            InitializeComponent();
            ObtenerIdEvento(IdEvento);
        }

        // Obtener el Id del evento donde se guardara la partida
        private void ObtenerIdEvento(string idEvento)
        {
            if (idEvento != null)
            {
                IdEventoPartida = idEvento;
            }
        }

        private void btnGuardarPartida_Click(object sender, EventArgs e)
        {
            // Validar que todos los textbox esten llenos
            if (!FormUtilities.ValidarTextBox(panelPrincipal))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Recopilar los parametros necesarios
                decimal costoMonedaNacional = Convert.ToDecimal(txtCostoUnitario.Text) * Convert.ToDecimal(txtCambio.Text);
                decimal porcentajeGanancia = Convert.ToDecimal(txtGanancia.Text) / 100;
                decimal precioUnitarioTotal = ((costoMonedaNacional * porcentajeGanancia) + costoMonedaNacional);

                ParametrosPartida parametrosPartida = new ParametrosPartida
                {
                    NumeroPartida = Convert.ToInt32(txtNumeroPartida.Text),
                    Descripcion = txtDescripcionPartida.Text,
                    CantidadMinima = Convert.ToInt32(txtCantidadMinimo.Text),
                    CantidadMaxima = Convert.ToInt32(txtCantidadMaxima.Text),
                    UnidadMedida = txtMedida.Text,
                    SeOfrece = txtSeOfrece.Text,
                    Marca = txtMarca.Text,
                    Catalogo = txtCatalogo.Text,
                    PaisOrigen = txtPaisOrigen.Text,
                    Fabricante = txtFabricante.Text,
                    CostoUnitario = Convert.ToDecimal(txtCostoUnitario.Text),
                    Moneda = cbMoneda.SelectedItem.ToString(),
                    CostoNacional = costoMonedaNacional,
                    PorcentajeGanancia = porcentajeGanancia,
                    TotalUnitario = precioUnitarioTotal,
                    IdNombreEvento = Convert.ToInt32(IdEventoPartida)
                };


                // Cambiar de ventana
                ConsultarPartida consultarPartida = new ConsultarPartida(IdEventoPartida);
                consultarPartida.Show();
                this.Close();
            }
        }

        // Restricciones de datos en los textbox
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.AllowOnlyIntegers(e);
        }
        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.AllowOnlyNumbersAndDecimal(e, (TextBox)sender);
        }
    }
}
