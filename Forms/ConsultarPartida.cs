namespace GobData
{
    public partial class ConsultarPartida : Form
    {
        string IdEventoPartida;

        public ConsultarPartida(string IdEvento)
        {
            InitializeComponent();
            ChecarIdEvento(IdEvento);
        }

        private void ChecarIdEvento(string idEvento)
        {
            if (idEvento != null)
            {
                IdEventoPartida = idEvento;
                lblID.Text = IdEventoPartida;
            }
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
