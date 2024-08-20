using GobData.Utilities;
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
        private Documentos documentos;
        string IdEventoPartida;
        bool isShow;

        public ConsultarPartida(ParametrosNombreEvento nombreEvento)
        {
            InitializeComponent();
            // Obtener los datos de la conexion a la Base de Datos
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            buscarDataService = new BuscarDataService(conexion);
            partidas = new Partidas(conexion);
            documentos = new Documentos(conexion);
            // Obtener el nombre del evento
            ObtenerNombreEvento(nombreEvento);
        }

        // Funcionalidad en los botones "Información Partidas"
        private void btnFinalizarPartida_Click(object sender, EventArgs e)
        {
            if (dgvDatosPartida.SelectedRows.Count > 0)
            {
                DialogResult savePartida = MessageBox.Show($"¿Quieres guardar la partida en un Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (savePartida == DialogResult.Yes)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                        sfd.FileName = lblTituloPartida.Text;

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            ExportadorExcel exportador = new ExportadorExcel();

                            // Guardar en Excel
                            try
                            {
                                exportador.ExportToExcel(dgvDatosPartida, sfd.FileName);
                                MessageBox.Show("La partrida se ha guardado en un Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error: {ex.Message}");
                            }
                        }
                    }
                }
            }
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

                DialogResult eliminarPartida = MessageBox.Show($"¿Estas seguro de eliminar la partida: {numeroPartidaSeleccionada}?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        // Funcionalidad en los botones "Agregar Documentos"
        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            // Si se presiona "Abrir" en la ventana emergente
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Hacer una instancia y recopilar los parametros necesarios
                ParametrosDocumentos parametrosDocumentos = new ParametrosDocumentos()
                {
                    Nombre = Path.GetFileName(openFileDialog1.FileName),
                    Direccion = openFileDialog1.FileName,
                    Documento = File.ReadAllBytes(openFileDialog1.FileName),
                    NombreDocID = Convert.ToInt32(IdEventoPartida)
                };

                // Guardar la información
                try
                {
                    documentos.InsertDocuments(parametrosDocumentos);
                    MessageBox.Show("El documento se ha cargado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

                // Actualizar el DGView
                CargarDocumentosDGV(IdEventoPartida);
            }
        }
        private void btnVerDoc_Click(object sender, EventArgs e)
        {
            if (dgvDocumentosPartida.SelectedRows.Count > 0)
            {
                string idDocumento = dgvDocumentosPartida.SelectedRows[0].Cells["IdDocumento"].Value.ToString();

                // Abrir documento seleccionado
                try
                {
                    documentos.ViewDocument(idDocumento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
        private void btnEliminarDoc_Click(object sender, EventArgs e)
        {
            if (dgvDocumentosPartida.SelectedRows.Count > 0)
            {
                string idDocumento = dgvDocumentosPartida.SelectedRows[0].Cells["IdDocumento"].Value.ToString();
                string documentoSeleccionado = dgvDocumentosPartida.SelectedRows[0].Cells["Nombre"].Value.ToString();

                DialogResult eliminarPartida = MessageBox.Show($"¿Estas seguro de eliminar el documento: {documentoSeleccionado}?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (eliminarPartida == DialogResult.Yes)
                {
                    // Eliminar partida
                    try
                    {
                        documentos.DeleteDocument(idDocumento);
                        MessageBox.Show("Documento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                    // Actualizar las partidas despues de la eliminación
                    CargarDocumentosDGV(IdEventoPartida);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }


        // Clase para actualizar el DGV
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

            // Llenar los DGView
            CargarPartidasDGV(IdEventoPartida);
            CargarDocumentosDGV(IdEventoPartida);

            // Mostrar u ocultar img back
            if (!isShow)
            {
                pictureBack.Visible = false;
            }
        }


        // Cargar los DGview
        // DGView de las partidas
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
        // DGview de los documentos
        private void CargarDocumentosDGV(string IdEventoPartidaSeleccionada)
        {
            try
            {
                DataTable dtAllDeparture = documentos.GetSpecificDocument(IdEventoPartidaSeleccionada);
                dgvDocumentosPartida.DataSource = dtAllDeparture;

                FormUtilities.OcultarPrimeraColumna(dgvDocumentosPartida);
                dgvDocumentosPartida.Columns[2].Visible = false;
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
