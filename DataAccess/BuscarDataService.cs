using MySql.Data.MySqlClient;
using System.Data;

namespace GobData
{
    public class BuscarDataService
    {
        private string connectionString;

        public BuscarDataService(string connectionString)
        {
            this.connectionString = connectionString;
        }


        // Metodo para mostrar todos los eventos que pertenezcan a una division y/o contengan una palabra en especifico
        public DataTable SearchSpecificEventName(string divisionSeleccionada, string textoBusqueda)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string queryConsulta;

                if(divisionSeleccionada != "Todos")
                {
                    queryConsulta = "SELECT * FROM NombreEvento WHERE Division = @divisionSeleccionada AND CONCAT(Mes, Dia, Estado, Convocante, Numero_Evento, Division) LIKE @textoBusqueda;";
                }
                else
                {
                    queryConsulta = "SELECT * FROM NombreEvento WHERE CONCAT(Mes, Dia, Estado, Convocante, Numero_Evento, Division) LIKE @textoBusqueda;";
                }

                try
                {
                    using (MySqlCommand comando = new MySqlCommand(queryConsulta, conexionBD))
                    {
                        if (divisionSeleccionada != "Todos")
                        {
                            comando.Parameters.AddWithValue("@divisionSeleccionada", divisionSeleccionada);
                        }
                        comando.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
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

        // Metodo para buscar una partida en especifico
        public DataTable SearchSpecificDeparture(string textoBusqueda, string idNombreEvento)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string queryConsulta = @"SELECT * FROM PartidasEvento WHERE NombrePartID = @idNombreEvento AND 
                                        CONCAT(N_Partida, Descripcion, Cant_Min, Cant_Max, Unidad_Medida, Se_Ofrece, Marca, Catalogo, Pais_Origen, Fabricante, Costo_Unitario, Moneda, Costo_Nacional, Porcentaje_Ganancia, Total_Unitario, NombrePartID) LIKE @textoBusqueda;";
                try
                {
                    using (MySqlCommand comando = new MySqlCommand(queryConsulta, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@idNombreEvento", idNombreEvento);
                        comando.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
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

    }
}
