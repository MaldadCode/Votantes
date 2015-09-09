namespace _1Main.Modelo
{
    public class Votante
    {
        public string CodigoProvincia { get; set; } //5
        public string Provincia { get; set; } //50
        public decimal Circunscripcion { get; set; } //11
        public string CodigoMunicipio { get; set; } //5
        public string Municipio { get; set; } //50
        public string NombreCI { get; set; } //100
        public string Centro { get; set; } //70
        public string DireccionCentro { get; set; } //70
        public string SectorCentro { get; set; } //70
        public string Mesa { get; set; } //5
        public string Cedula { get; set; } //11
        public string Nombre { get; set; } //50
        public string PrimerApellido { get; set; } //50
        public string SegundoApellido { get; set; } //50
        public string Sexo { get; set; } //1
        public int Orden { get; set; } //4
    }
}
