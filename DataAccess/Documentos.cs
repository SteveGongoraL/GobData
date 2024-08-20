using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace GobData
{
    public class Documentos
    {
        private string connectionString;

        public Documentos(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Metodo para insertar los documentos de la partida
        public void InsertDocuments(ParametrosDocumentos parametrosDocumentos)
        {
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string queryConsulta = @"INSERT INTO DocumentosEvento
                            (Nombre, Direccion, Documento, NombreDocID)
                            VALUES
                            (@Nombre, @Direccion, @Documento, @NombreDocID);";

                using (MySqlCommand comando = new MySqlCommand(queryConsulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@Nombre", parametrosDocumentos.Nombre);
                    comando.Parameters.AddWithValue("@Direccion", parametrosDocumentos.Direccion);
                    comando.Parameters.AddWithValue("@Documento", parametrosDocumentos.Documento);
                    comando.Parameters.AddWithValue("@NombreDocID", parametrosDocumentos.NombreDocID);

                    conexionBD.Open();
                    comando.ExecuteNonQuery();
                }
            }
            return;
        }

        // Metodo seleccionar los documentos
        public DataTable GetSpecificDocument(string idEventoSeleccionado)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string queryConsulta = "SELECT IdDocumento, Nombre, Direccion FROM DocumentosEvento WHERE NombreDocID = @idEventoSeleccionado;";

                try
                {
                    using (MySqlCommand comando = new MySqlCommand(queryConsulta, conexionBD))
                    {
                        comando.Parameters.Add("@idEventoSeleccionado", MySqlDbType.VarChar).Value = idEventoSeleccionado;
                        conexionBD.Open();
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Manejo de excepciones específicas de MySQL
                    throw new Exception("Error al cargar datos desde MySQL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Manejo de otras excepciones
                    throw new Exception("Error al cargar datos: " + ex.Message);
                }
            }
            return dataTable;
        }

        // Metodo eliminar un documento
        public void DeleteDocument(string idDocumentoSeleccionado)
        {
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string queryConsulta = @"DELETE FROM DocumentosEvento WHERE IdDocumento = @idDocumentoSeleccionado;";

                using (MySqlCommand comando = new MySqlCommand(queryConsulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@idDocumentoSeleccionado", idDocumentoSeleccionado);

                    conexionBD.Open();
                    comando.ExecuteNonQuery();
                }
            }
            return;
        }

        // Metodo para ver el documento
        public void ViewDocument(string idDocumentoSeleccionado)
        {
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string queryConsulta = @"SELECT Nombre, Documento FROM DocumentosEvento WHERE IdDocumento = @idDocumentoSeleccionado;";

                using (MySqlCommand comando = new MySqlCommand(queryConsulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@idDocumentoSeleccionado", idDocumentoSeleccionado);
                    conexionBD.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lee el nombre y el documento
                            string nombreArchivo = reader["Nombre"].ToString();
                            byte[] documentoByte = (byte[])reader["Documento"];

                            // Ruta temporal del archivo
                            string rutaTemporal = Path.Combine(Path.GetTempPath(), nombreArchivo);

                            // Guardar el archivo en la ruta temporal
                            File.WriteAllBytes(rutaTemporal, documentoByte);

                            //Abrir el archivo con la aplicación predeterminada
                            Process.Start(new ProcessStartInfo(rutaTemporal) { UseShellExecute = true });
                        }
                        else
                        {
                            MessageBox.Show("Archivo no encontrado en la base de datos.");
                        }
                    }
                }
            }
            return;
        }

    }
}
