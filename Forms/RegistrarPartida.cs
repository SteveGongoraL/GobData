namespace GobData
{
    public partial class RegistrarPartida : Form
    {
        public RegistrarPartida(string IdEvento)
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
    }
}
