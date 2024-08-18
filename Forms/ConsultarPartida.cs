namespace GobData
{
    public partial class ConsultarPartida : Form
    {
        private ParametrosNombreEvento nombreEvento;
        string IdEventoPartida;

        public ConsultarPartida(ParametrosNombreEvento nombreEvento)
        {
            InitializeComponent();
            ObtenerNombreEvento(nombreEvento);
        }

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
    }
}
