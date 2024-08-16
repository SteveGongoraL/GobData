namespace GobData
{
    public partial class ConsultarPartida : Form
    {
        public ConsultarPartida(string IdEvento)
        {
            InitializeComponent();
            ChecarIdEvento(IdEvento);
        }

        private void ChecarIdEvento(string idEvento)
        {
            if (idEvento != null)
            {
                lblID.Text = idEvento;
            }
        }

        private void btnFinalizarPartida_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
