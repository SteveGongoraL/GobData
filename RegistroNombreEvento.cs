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
    public partial class RegistroNombreEvento : Form
    {
        public RegistroNombreEvento()
        {
            InitializeComponent();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            RegistrarEvento registrarEvento = new RegistrarEvento();
            registrarEvento.Show();
            this.Hide();
        }
    }
}
