namespace GobData
{
    // Objeto para almacenar las propiedades de una Partida
    public class ParametrosPartida
    {
        // Propiedades del objeto ParametrosPartida
        public int IdPartida { get; set; }
        public int NumeroPartida { get; set; }
        public string Descripcion { get; set; }
        public int CantidadMinima { get; set; }
        public int CantidadMaxima { get; set; }
        public string UnidadMedida { get; set; }
        public string SeOfrece { get; set; }
        public string Marca { get; set; }
        public string Catalogo { get; set; }
        public string PaisOrigen { get; set; }
        public string Fabricante { get; set; }
        public decimal CostoUnitario { get; set; }
        public string Moneda { get; set; }
        public decimal CostoNacional { get; set; }
        public decimal PorcentajeGanancia { get; set; }
        public decimal TotalUnitario { get; set; }
        public int IdNombreEvento { get; set; }
    }
}
