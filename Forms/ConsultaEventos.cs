using GobData.Utilities;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace GobData
{
    public partial class ConsultaEventos : Form
    {
        private NombreEvento nombreEvento;
        private BuscarDataService buscarDataService;
        private ParametrosNombreEvento parametrosNombreEvento;

        public ConsultaEventos()
        {
            InitializeComponent();
            // Obtener los datos de la conexion a la Base de Datos
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            nombreEvento = new NombreEvento(conexion);
            buscarDataService = new BuscarDataService(conexion);
            // Llamar al metodo para llenar el DGV por defecto
            CargarDatosDGV();
        }


        // Funcionalidad en los botones
        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void btnConsultarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener ParametrosNombreEvento
            ParametrosNombreEvento nombreEvento = ObtenerNombreEventoSeleccionado();

            if( nombreEvento != null )
            {
                ConsultarPartida consultarPartida = new ConsultarPartida(nombreEvento);
                consultarPartida.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecciona un producto para editar.");
            }
        }


        // Llenar el DGView con la información de los eventos
        private void CargarDatosDGV()
        {
            string divisionEventoSeleccionada;

            // Validar que se haya seleccionado una division
            if(cbConsultarEventos.SelectedItem != null)
            {
                divisionEventoSeleccionada = cbConsultarEventos.SelectedItem.ToString();
            }
            else
            {
                divisionEventoSeleccionada = "Todos";
            }

            // Poner el titulo de la pantalla
            lblTituloConsultaEventos.Text = divisionEventoSeleccionada;

            // Consultar los datos
            try
            {
                DataTable dtAllEventName = nombreEvento.GetSpecificEventName(divisionEventoSeleccionada);
                dgvConsultarEventos.DataSource = dtAllEventName;

                FormUtilities.OcultarPrimeraColumna(dgvConsultarEventos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        // Obtener los datos de una fila
        private ParametrosNombreEvento ObtenerNombreEventoSeleccionado()
        {
            if (dgvConsultarEventos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvConsultarEventos.SelectedRows[0];
                // Creando una instancia de ParametrosNombreEvento
                ParametrosNombreEvento parametrosNombreEvento = new ParametrosNombreEvento
                {
                    IdEvento = Convert.ToString(selectedRow.Cells[0].Value),
                    Mes = Convert.ToString(selectedRow.Cells[1].Value),
                    Dia = Convert.ToInt32(selectedRow.Cells[2].Value),
                    Estado = Convert.ToString(selectedRow.Cells[3].Value),
                    Convocante = Convert.ToString(selectedRow.Cells[4].Value),
                    NumeroEvento = Convert.ToString(selectedRow.Cells[5].Value),
                    IsShown = true
                };

                return parametrosNombreEvento;
            }
            return null;
        }


        // Mostrar información dependiendo del valor seleccionado en el combobox
        private void cbConsultarEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el txtBuscarEventos al cambiar de Division
            txtBuscarEventos.Text = "";

            // Cargar la información cada que se cambia de Division
            CargarDatosDGV();
        }


        // Buscador los eventos que contengan una palabra en especifico
        private void txtBuscarEventos_TextChanged(object sender, EventArgs e)
        {
            string filtradoEventos = lblTituloConsultaEventos.Text;
            string buscadorEventos = txtBuscarEventos.Text.ToUpper();

            try
            {
                DataTable dtSearchSpecificEventName = buscarDataService.SearchSpecificEventName(filtradoEventos, buscadorEventos);
                dgvConsultarEventos.DataSource = dtSearchSpecificEventName;

                FormUtilities.OcultarPrimeraColumna(dgvConsultarEventos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
