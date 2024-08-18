using MySql.Data.MySqlClient;

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
    }
}
