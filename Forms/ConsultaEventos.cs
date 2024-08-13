using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace GobData
{
    public partial class ConsultaEventos : Form
    {
        private NombreEvento nombreEvento;
        string IdEvento;

        public ConsultaEventos()
        {
            InitializeComponent();
            // Obtener los datos de la conexion a la Base de Datos
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            nombreEvento = new NombreEvento(conexion);
            // Llamar al metodo para llenar el DGV por defecto
            CargarDatosDGV();
        }


        // Funcionalidad en los botones
        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void btnConsultarRegistro_Click(object sender, EventArgs e)
        {
            RegistrarEvento registrarEvento = new RegistrarEvento(IdEvento);
            registrarEvento.Show();
            this.Hide();
        }


        // Llenar el DGView con la información de todos los nombres de eventos
        private void CargarDatosDGV()
        {
            try
            {
                DataTable dtAllEventName = nombreEvento.GetAllEventName();
                dgvConsultarEventos.DataSource = dtAllEventName;

                // Ocultar la columna del ID
                if (dgvConsultarEventos.Columns.Count > 0)
                {
                    dgvConsultarEventos.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        // Mostrar información dependiendo del valor seleccionado en el combobox
        private void cbConsultarEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string divisionEventoSeleccionada = cbConsultarEventos.SelectedItem.ToString();
            lblTituloConsultaEventos.Text = divisionEventoSeleccionada;

            if (divisionEventoSeleccionada != "Todos")
            {
                try
                {
                    DataTable dtAllEventName = nombreEvento.GetSpecificEventName(divisionEventoSeleccionada);
                    dgvConsultarEventos.DataSource = dtAllEventName;

                    // Ocultar la columna del ID
                    if (dgvConsultarEventos.Columns.Count > 0)
                    {
                        dgvConsultarEventos.Columns[0].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                CargarDatosDGV();
            }
        }


        // Sacar el ID de la fila que esta seleccionada
        private void dgvConsultarEventos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConsultarEventos.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dgvConsultarEventos.SelectedRows[0];
                // Obtiene el valor de la columna 1
                IdEvento = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }
    }
}
