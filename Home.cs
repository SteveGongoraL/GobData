namespace GobData
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnRegistrarEvento_Click(object sender, EventArgs e)
        {
            RegistroNombreEvento registroNombreEvento = new RegistroNombreEvento();
            registroNombreEvento.Show();
            this.Hide();
        }

        private void btnConsultarEvento_Click(object sender, EventArgs e)
        {
            ConsultaEventos consultaEventos  = new ConsultaEventos();
            consultaEventos.Show();
            this.Hide();
        }
    }
}
