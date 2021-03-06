namespace ProyectoTallerAutos.Entidades.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Direccion { get; set; }
        public Localidad Localidad { get; set; }
        public Provincia provincia { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorrreoElectronico { get; set; }
    }
}
