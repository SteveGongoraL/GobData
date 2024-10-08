﻿using MySql.Data.MySqlClient;
using System.Data;

namespace GobData
{
    public class Partidas
    {
        private string connectionString;

        public Partidas(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Metodo para insertar los datos de la partida
        public void InsertPartida(ParametrosPartida parametrosPartida)
        {
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string consulta = @"INSERT INTO PartidasEvento
                            (N_Partida, Descripcion, Cant_Min, Cant_Max, Unidad_Medida, Se_Ofrece, Marca, Catalogo, Pais_Origen, Fabricante, Costo_Unitario, Moneda, Costo_Nacional, Porcentaje_Ganancia, Total_Unitario, NombrePartID)
                            VALUES
                            (@N_Partida, @Descripcion, @Cant_Min, @Cant_Max, @Unidad_Medida, @Se_Ofrece, @Marca, @Catalogo, @Pais_Origen, @Fabricante, @Costo_Unitario, @Moneda, @Costo_Nacional, @Porcentaje_Ganancia, @Total_Unitario, @NombrePartID);";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@N_Partida", parametrosPartida.NumeroPartida);
                    comando.Parameters.AddWithValue("@Descripcion", parametrosPartida.Descripcion);
                    comando.Parameters.AddWithValue("@Cant_Min", parametrosPartida.CantidadMinima);
                    comando.Parameters.AddWithValue("@Cant_Max", parametrosPartida.CantidadMaxima);
                    comando.Parameters.AddWithValue("@Unidad_Medida", parametrosPartida.UnidadMedida);
                    comando.Parameters.AddWithValue("@Se_Ofrece", parametrosPartida.SeOfrece);
                    comando.Parameters.AddWithValue("@Marca", parametrosPartida.Marca);
                    comando.Parameters.AddWithValue("@Catalogo", parametrosPartida.Catalogo);
                    comando.Parameters.AddWithValue("@Pais_Origen", parametrosPartida.PaisOrigen);
                    comando.Parameters.AddWithValue("@Fabricante", parametrosPartida.Fabricante);
                    comando.Parameters.AddWithValue("@Costo_Unitario", parametrosPartida.CostoUnitario);
                    comando.Parameters.AddWithValue("@Moneda", parametrosPartida.Moneda);
                    comando.Parameters.AddWithValue("@Costo_Nacional", parametrosPartida.CostoNacional);
                    comando.Parameters.AddWithValue("@Porcentaje_Ganancia", parametrosPartida.PorcentajeGanancia);
                    comando.Parameters.AddWithValue("@Total_Unitario", parametrosPartida.TotalUnitario);
                    comando.Parameters.AddWithValue("@NombrePartID", parametrosPartida.IdNombreEvento);

                    conexionBD.Open();
                    comando.ExecuteNonQuery();
                }
            }
            return;
        }

        // Metodo para seleccionar los datos de la partida
        public DataTable GetSpecificDeparture(string idEventoSeleccionado)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string queryConsulta = "SELECT * FROM PartidasEvento WHERE NombrePartID = @idEventoSeleccionado;";

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

        // Metodo para actualizar los datos de la partida
        public void UpdateDeparture(ParametrosPartida parametrosPartida)
        {
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string consulta = @"UPDATE PartidasEvento 
                                    SET N_Partida = @N_Partida, Descripcion = @Descripcion, Cant_Min = @Cant_Min, Cant_Max = @Cant_Max, Unidad_Medida = @Unidad_Medida, Se_Ofrece = @Se_Ofrece,  Marca = @Marca, Catalogo = @Catalogo, Pais_Origen = @Pais_Origen, Fabricante = @Fabricante, Costo_Unitario = @Costo_Unitario, Moneda = @Moneda, Costo_Nacional = @Costo_Nacional, Porcentaje_Ganancia = @Porcentaje_Ganancia, Total_Unitario = @Total_Unitario
                                    WHERE IdPartida = @IdPartida;";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@IdPartida", parametrosPartida.IdPartida);
                    comando.Parameters.AddWithValue("@N_Partida", parametrosPartida.NumeroPartida);
                    comando.Parameters.AddWithValue("@Descripcion", parametrosPartida.Descripcion);
                    comando.Parameters.AddWithValue("@Cant_Min", parametrosPartida.CantidadMinima);
                    comando.Parameters.AddWithValue("@Cant_Max", parametrosPartida.CantidadMaxima);
                    comando.Parameters.AddWithValue("@Unidad_Medida", parametrosPartida.UnidadMedida);
                    comando.Parameters.AddWithValue("@Se_Ofrece", parametrosPartida.SeOfrece);
                    comando.Parameters.AddWithValue("@Marca", parametrosPartida.Marca);
                    comando.Parameters.AddWithValue("@Catalogo", parametrosPartida.Catalogo);
                    comando.Parameters.AddWithValue("@Pais_Origen", parametrosPartida.PaisOrigen);
                    comando.Parameters.AddWithValue("@Fabricante", parametrosPartida.Fabricante);
                    comando.Parameters.AddWithValue("@Costo_Unitario", parametrosPartida.CostoUnitario);
                    comando.Parameters.AddWithValue("@Moneda", parametrosPartida.Moneda);
                    comando.Parameters.AddWithValue("@Costo_Nacional", parametrosPartida.CostoNacional);
                    comando.Parameters.AddWithValue("@Porcentaje_Ganancia", parametrosPartida.PorcentajeGanancia);
                    comando.Parameters.AddWithValue("@Total_Unitario", parametrosPartida.TotalUnitario);
                    comando.Parameters.AddWithValue("@NombrePartID", parametrosPartida.IdNombreEvento);

                    conexionBD.Open();
                    comando.ExecuteNonQuery();
                }
            }
            return;
        }

        // Metodo para eliminar una partida
        public void DeleteDeparture(string idPartidaSeleccionada)
        {
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string consulta = @"DELETE FROM PartidasEvento WHERE IdPartida = @idPartidaSeleccionada;";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@idPartidaSeleccionada", idPartidaSeleccionada);

                    conexionBD.Open();
                    comando.ExecuteNonQuery();
                }
            }
            return;
        }

    }
}
