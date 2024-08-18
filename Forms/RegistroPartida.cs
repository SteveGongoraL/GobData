using GobData.Utilities;
using System.Configuration;

namespace GobData
{
    public partial class RegistroPartida : Form
    {
        private ParametrosPartida partidaActual;
        private Partidas partidas;
        string IdEventoPartida;
        private bool esEditar;

        public RegistroPartida(string IdEvento)
        {
            InitializeComponent();
            ObtenerIdEvento(IdEvento);
            // Obtener los datos de la conexion a la Base de Datos
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            partidas = new Partidas(conexion);

            esEditar = false;
        }
        // Sobrecarga del constructor para modo edición
        public RegistroPartida(ParametrosPartida parametrosPartida, string IdEvento) : this(IdEvento)
        {
            esEditar = true;
            partidaActual = parametrosPartida;
            CargarDatosPartida();
        }


        // Funcionalidad en los botones
        private void btnGuardarPartida_Click(object sender, EventArgs e)
        {
            // Validar que todos los textbox esten llenos
            if (!FormUtilities.ValidarTextBox(panelPrincipal))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Validar que los combobox esten seleccionados
            else if (!FormUtilities.ValidarComboBox(panelPrincipal))
            {
                MessageBox.Show("Debes seleccionar una opción en todos los ComboBox.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(esEditar)
                {
                    MessageBox.Show("Estas editando");
                }
                else
                {
                    // Recopilar los parametros necesarios
                    ParametrosPartida parametrosPartida = ObtenerDatosPartida();

                    // Guardar la información
                    try
                    {
                        partidas.InsertPartida(parametrosPartida);
                        MessageBox.Show("Operación realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                    // Limpiar los campos
                    FormUtilities.LimpiarTextBox(panelPrincipal);
                }
            }
        }
        private void btnVolverPartida_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Obtener el Id del evento donde se guardara la partida
        private void ObtenerIdEvento(string idEvento)
        {
            if (idEvento != null)
            {
                IdEventoPartida = idEvento;
            }
        }

        // Cargar los datos de la Partida en los textbox
        private void CargarDatosPartida()
        {
            if(partidaActual != null)
            {
                string tipoMoneda = partidaActual.Moneda;
                int indexMoneda = cbMoneda.FindString(tipoMoneda);

                txtNumeroPartida.Text = partidaActual.NumeroPartida.ToString();
                txtDescripcionPartida.Text = partidaActual.Descripcion;
                txtCantidadMinimo.Text = partidaActual.CantidadMinima.ToString();
                txtCantidadMaxima.Text = partidaActual.CantidadMaxima.ToString();
                txtMedida.Text = partidaActual.UnidadMedida;
                txtSeOfrece.Text = partidaActual.SeOfrece;
                txtMarca.Text = partidaActual.Marca;
                txtCatalogo.Text = partidaActual.Catalogo;
                txtPaisOrigen.Text = partidaActual.PaisOrigen;
                txtFabricante.Text = partidaActual.Fabricante;
                txtCostoUnitario.Text = partidaActual.CostoUnitario.ToString();
                cbMoneda.SelectedIndex = indexMoneda;
                txtCambio.Text = partidaActual.CostoNacional.ToString();
                txtGanancia.Text = partidaActual.PorcentajeGanancia.ToString();
            }

            btnGuardarPartida.Text = "Actualizar";
            lblTituloRegisto.Text = "Editrar Producto";
        }

        // Obtener los datos de la partida
        private ParametrosPartida  ObtenerDatosPartida()
        {
            decimal tasaCambio = Convert.ToDecimal(txtCambio.Text);
            decimal costoMonedaNacional;
            
            if (tasaCambio <= 0)
            {
                costoMonedaNacional = Convert.ToDecimal(txtCostoUnitario.Text);
            }
            else
            {
                costoMonedaNacional = Convert.ToDecimal(txtCostoUnitario.Text) * Convert.ToDecimal(txtCambio.Text);
            }

            decimal porcentajeGanancia = Convert.ToDecimal(txtGanancia.Text) / 100;
            decimal precioUnitarioTotal = ((costoMonedaNacional * porcentajeGanancia) + costoMonedaNacional);

            ParametrosPartida parametrosPartida = new ParametrosPartida
            {
                NumeroPartida = Convert.ToInt32(txtNumeroPartida.Text),
                Descripcion = txtDescripcionPartida.Text.ToUpper(),
                CantidadMinima = Convert.ToInt32(txtCantidadMinimo.Text),
                CantidadMaxima = Convert.ToInt32(txtCantidadMaxima.Text),
                UnidadMedida = txtMedida.Text.ToUpper(),
                SeOfrece = txtSeOfrece.Text.ToUpper(),
                Marca = txtMarca.Text.ToUpper(),
                Catalogo = txtCatalogo.Text.ToUpper(),
                PaisOrigen = txtPaisOrigen.Text.ToUpper(),
                Fabricante = txtFabricante.Text.ToUpper(),
                CostoUnitario = Convert.ToDecimal(txtCostoUnitario.Text),
                Moneda = cbMoneda.SelectedItem.ToString(),
                CostoNacional = costoMonedaNacional,
                PorcentajeGanancia = porcentajeGanancia,
                TotalUnitario = precioUnitarioTotal,
                IdNombreEvento = Convert.ToInt32(IdEventoPartida)
            };

            return parametrosPartida;
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
