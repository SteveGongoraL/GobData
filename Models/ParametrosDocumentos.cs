namespace GobData
{
    // Objeto para almacenar las propiedades de un Documento
    public class ParametrosDocumentos
    {
        // Propiedades del objeto
        public string Nombre{ get; set; }
        public string Direccion { get; set; }
        public byte[] Documento { get; set; }
        public int NombreDocID { get; set; }
    }
}
