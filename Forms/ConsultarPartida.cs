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
            registroPartida.FormClosed += new FormClosedEventHandler(AgregarProductoForm_FormClosed);
            registroPartida.Show();
        }

        private void AgregarProductoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Aquí actualizas los productos después de que se cierre la ventana de agregar producto
            CargarPartidasDGV(IdEventoPartida);
        }


        // Generar el titulo del form
        private void ObtenerNombreEvento(ParametrosNombreEvento evento)
        {
            if(evento != null)
            {
                IdEventoPartida = evento.IdEvento;
                string mes = evento.Mes;
                string dia = Convert.ToString(evento.Dia);
                string estado = evento.Estado.Replace(" ", "");
                string convocante = evento.Convocante.Replace(" ","");
                string numeroEvento = evento.NumeroEvento;

                lblTituloPartida.Text = mes + "-" + dia + "-" + estado + "-" + convocante + "-" + numeroEvento;
            }

            // Centrar Label
            lblTituloPartida.Left = (panelNombreEvento.Width - lblTituloPartida.Width) / 2;
            lblTituloPartida.Top = (panelNombreEvento.Height - lblTituloPartida.Height) / 2;

            // Llenar el DGView
            CargarPartidasDGV(IdEventoPartida);
        }


        // Llenar el DGView con la información de las partidas
        private void CargarPartidasDGV(string IdEventoPartidaSeleccionada)
        {
            try
            {
                DataTable dtAllDeparture = partidas.GetSpecificDeparture(IdEventoPartidaSeleccionada);
                dgDatosPartida.DataSource = dtAllDeparture;

                FormUtilities.OcultarPrimeraColumna(dgDatosPartida);
                dgDatosPartida.Columns[16].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
