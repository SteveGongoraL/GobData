using MySql.Data.MySqlClient;

namespace GobData
{
    public class NombreEvento
    {
        private string connectionString;

        public NombreEvento(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Los parametros vienen del modelo "ParametrosNombreEvento"
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
    }
}
