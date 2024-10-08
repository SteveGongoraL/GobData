﻿using MySql.Data.MySqlClient;
using System.Data;

namespace GobData
{
    public class NombreEvento
    {
        private string connectionString;

        public NombreEvento(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Metodo para insertar la informacion del evento
        // Los parametros vienen del objeto "ParametrosNombreEvento"
        public int InsertEventName(ParametrosNombreEvento parametrosNombreEvento)
        {
            int insertedId = 0;

            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string consulta = "INSERT INTO NombreEvento(Mes, Dia, Estado, Convocante, Numero_Evento, Division) VALUES (@Mes, @Dia, @Estado, @Convocante, @Numero_Evento, @Division);";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@Mes", parametrosNombreEvento.Mes);
                    comando.Parameters.AddWithValue("@Dia", parametrosNombreEvento.Dia);
                    comando.Parameters.AddWithValue("@Estado", parametrosNombreEvento.Estado);
                    comando.Parameters.AddWithValue("@Convocante", parametrosNombreEvento.Convocante);
                    comando.Parameters.AddWithValue("@Numero_Evento", parametrosNombreEvento.NumeroEvento);
                    comando.Parameters.AddWithValue("@Division", parametrosNombreEvento.Division);

                    conexionBD.Open();
                    comando.ExecuteNonQuery();
                    insertedId = (int)comando.LastInsertedId;
                }
            }
            return insertedId;
        }

        // Metodo para mostrar o filtrar todos los eventos
        public DataTable GetSpecificEventName(string divisionSeleccionada)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string queryConsulta;

                if (divisionSeleccionada != "Todos")
                {
                    queryConsulta = "SELECT * FROM NombreEvento WHERE Division = @divisionSeleccionada;";
                }
                else
                {
                    queryConsulta = "SELECT * FROM NombreEvento;";
                }

                try
                {
                    using (MySqlCommand comando = new MySqlCommand(queryConsulta, conexionBD))
                    {
                        if (divisionSeleccionada != "Todos")
                        {
                            comando.Parameters.Add("@divisionSeleccionada", MySqlDbType.VarChar).Value = divisionSeleccionada;
                        }
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
