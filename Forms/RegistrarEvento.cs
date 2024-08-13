namespace GobData
{
    public partial class RegistrarEvento : Form
    {
        public RegistrarEvento(string IdEvento)
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
