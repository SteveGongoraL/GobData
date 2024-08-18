using GobData.Utilities;
using System.Configuration;
using System.Data;

namespace GobData
{
    public partial class ConsultarPartida : Form
    {
        private ParametrosNombreEvento nombreEvento;
        private Partidas partidas;
        string IdEventoPartida;

        public ConsultarPartida(ParametrosNombreEvento nombreEvento)
        {
            InitializeComponent();
            // Obtener los datos de la conexion a la Base de Datos
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            partidas = new Partidas(conexion);
            // Obtener el nombre del evento
            ObtenerNombreEvento(nombreEvento);
            // Llamar al metodo para llenar el DGV
            CargarPartidasDGV(nombreEvento);
        }

        // Funcionalidad en los botones
        private void btnFinalizarPartida_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnAgregarPartida_Click(object sender, EventArgs e)
        {
            RegistroPartida registroPartida = new RegistroPartida(IdEventoPartida);
            //gistroPartida.FormClosed += new FormClosedEventHandler(AgregarProductoForm_FormClosed);
            registroPartida.Show();
        }

        /*
        private void AgregarProductoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Aquí actualizas los productos después de que se cierre la ventana de agregar producto
            CargarProductos();
        }

        private void CargarProductos()
        {
            // Código para cargar y actualizar la lista de productos
        }
        */


        // Llenar el DGView con la información de las partidas
        private void CargarPartidasDGV(ParametrosNombreEvento idEvento)
        {
            try
            {
                DataTable dtAllDeparture = partidas.GetSpecificDeparture(idEvento.IdEvento);
                dgDatosPartida.DataSource = dtAllDeparture;

                FormUtilities.OcultarPrimeraColumna(dgDatosPartida);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Generar el titulo del form
        private void ObtenerNombreEvento(ParametrosNombreEvento evento)
        {
            if(evento != null)
            {
                IdEventoPartida = evento.IdEvento;
                string mes = evento.Mes;
                string dia = Convert.ToString(evento.Dia);
                string estado = evento.Estado;
                string convocante = evento.Convocante;
                string numeroEvento = evento.NumeroEvento;

                lblTituloPartida.Text = mes + "-" + dia + "-" + estado + "-" + convocante + "-" + numeroEvento;
            }

            // Centrar Label
            lblTituloPartida.Left = (panelNombreEvento.Width - lblTituloPartida.Width) / 2;
            lblTituloPartida.Top = (panelNombreEvento.Height - lblTituloPartida.Height) / 2;
        }
    }
}
