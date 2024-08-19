﻿using GobData.Utilities;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace GobData
{
    public partial class ConsultarPartida : Form
    {
        private ParametrosNombreEvento nombreEvento;
        private ParametrosPartida parametrosPartida;
        private BuscarDataService buscarDataService;
        private Partidas partidas;
        string IdEventoPartida;
        bool isShow;

        public ConsultarPartida(ParametrosNombreEvento nombreEvento)
        {
            InitializeComponent();
            // Obtener los datos de la conexion a la Base de Datos
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            partidas = new Partidas(conexion);
            buscarDataService = new BuscarDataService(conexion);
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
        private void btnEditarPartida_Click(object sender, EventArgs e)
        {
            ParametrosPartida partidaSeleccionada = ObtenerPartidaSeleccionada();

            if (partidaSeleccionada != null)
            {
                RegistroPartida editarPartida = new RegistroPartida(partidaSeleccionada, IdEventoPartida);
                editarPartida.FormClosed += new FormClosedEventHandler(AgregarProductoForm_FormClosed);
                editarPartida.Show();
            }
        }
        private void btnEliminarPartida_Click(object sender, EventArgs e)
        {
            if (dgvDatosPartida.SelectedRows.Count > 0)
            {
                string idPartidaSeleccionada = dgvDatosPartida.SelectedRows[0].Cells["IdPartida"].Value.ToString();
                string numeroPartidaSeleccionada = dgvDatosPartida.SelectedRows[0].Cells["N_Partida"].Value.ToString();

                DialogResult eliminarPartida = MessageBox.Show($"¿Estas seguro de eliminar la partida: {numeroPartidaSeleccionada}?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eliminarPartida == DialogResult.Yes)
                {
                    // Eliminar partida
                    try
                    {
                        partidas.DeleteDeparture(idPartidaSeleccionada);
                        MessageBox.Show("Partida eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                    // Actualizar las partidas despues de la eliminación
                    CargarPartidasDGV(IdEventoPartida);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
        private void btnClearPartida_Click(object sender, EventArgs e)
        {
            FormUtilities.LimpiarTextBox(gbInfoPartida);
        }


        private void AgregarProductoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Actualizar los productos después de que se cierre la ventana de RegistroPartida
            CargarPartidasDGV(IdEventoPartida);
        }


        // Generar el titulo del formulario
        private void ObtenerNombreEvento(ParametrosNombreEvento evento)
        {
            if (evento != null)
            {
                IdEventoPartida = evento.IdEvento;
                string mes = evento.Mes;
                string dia = Convert.ToString(evento.Dia);
                string estado = evento.Estado.Replace(" ", "");
                string convocante = evento.Convocante.Replace(" ", "");
                string numeroEvento = evento.NumeroEvento;
                isShow = evento.IsShown;

                lblTituloPartida.Text = mes + "-" + dia + "-" + estado + "-" + convocante + "-" + numeroEvento;
            }

            // Centrar Label
            lblTituloPartida.Left = (panelNombreEvento.Width - lblTituloPartida.Width) / 2;
            lblTituloPartida.Top = (panelNombreEvento.Height - lblTituloPartida.Height) / 2;

            // Llenar el DGView
            CargarPartidasDGV(IdEventoPartida);

            // Mostrar u ocultar img back
            if (!isShow)
            {
                pictureBack.Visible = false;
            }
        }


        // Llenar el DGView con la información de las partidas
        private void CargarPartidasDGV(string IdEventoPartidaSeleccionada)
        {
            try
            {
                DataTable dtAllDeparture = partidas.GetSpecificDeparture(IdEventoPartidaSeleccionada);
                dgvDatosPartida.DataSource = dtAllDeparture;

                FormUtilities.OcultarPrimeraColumna(dgvDatosPartida);
                dgvDatosPartida.Columns[16].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        // Obtener partida seleccionada
        private ParametrosPartida ObtenerPartidaSeleccionada()
        {
            if (dgvDatosPartida.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDatosPartida.SelectedRows[0];
                decimal costoNacional = Convert.ToDecimal(selectedRow.Cells["Costo_Nacional"].Value) / Convert.ToDecimal(selectedRow.Cells["Costo_Unitario"].Value);

                // Creando una instancia de ParametrosPartida
                ParametrosPartida parametrosPartida = new ParametrosPartida
                {
                    IdPartida = Convert.ToInt32(selectedRow.Cells["IdPartida"].Value),
                    NumeroPartida = Convert.ToInt32(selectedRow.Cells["N_Partida"].Value),
                    Descripcion = Convert.ToString(selectedRow.Cells["Descripcion"].Value),
                    CantidadMinima = Convert.ToInt32(selectedRow.Cells["Cant_Min"].Value),
                    CantidadMaxima = Convert.ToInt32(selectedRow.Cells["Cant_Max"].Value),
                    UnidadMedida = Convert.ToString(selectedRow.Cells["Unidad_Medida"].Value),
                    SeOfrece = Convert.ToString(selectedRow.Cells["Se_Ofrece"].Value),
                    Marca = Convert.ToString(selectedRow.Cells["Marca"].Value),
                    Catalogo = Convert.ToString(selectedRow.Cells["Catalogo"].Value),
                    PaisOrigen = Convert.ToString(selectedRow.Cells["Pais_Origen"].Value),
                    Fabricante = Convert.ToString(selectedRow.Cells["Fabricante"].Value),
                    CostoUnitario = Convert.ToDecimal(selectedRow.Cells["Costo_Unitario"].Value),
                    Moneda = Convert.ToString(selectedRow.Cells["Moneda"].Value),
                    CostoNacional = costoNacional,
                    PorcentajeGanancia = Convert.ToDecimal(selectedRow.Cells["Porcentaje_Ganancia"].Value) * 100
                };

                return parametrosPartida;
            }
            return null;
        }


        // Buscador las partidas que contengan una palabra en especifico
        private void txtBusquedaPartida_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBusquedaPartida.Text;

            try
            {
                DataTable dtSearchSpecificDeparture = buscarDataService.SearchSpecificDeparture(textoBusqueda, IdEventoPartida);
                dgvDatosPartida.DataSource = dtSearchSpecificDeparture;

                FormUtilities.OcultarPrimeraColumna(dgvDatosPartida);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Imagen para retroceder
        private void pictureBack_Click(object sender, EventArgs e)
        {
            ConsultaEventos consultaEventos = new ConsultaEventos();
            consultaEventos.Show();
            this.Hide();
        }

    }
}
