using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GobData
{
    public partial class ConsultaEventos : Form
    {
        public ConsultaEventos()
        {
            InitializeComponent();
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnConsultarRegistro_Click(object sender, EventArgs e)
        {
            RegistrarEvento registrarEvento = new RegistrarEvento();
            registrarEvento.Show();
            this.Hide();
        }
    }
}
