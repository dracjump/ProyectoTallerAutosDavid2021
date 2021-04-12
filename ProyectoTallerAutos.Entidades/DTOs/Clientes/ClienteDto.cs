namespace ProyectoTallerAutos.Entidades.DTOs.Clientes
{
    public class ClienteDto
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string Direccion { get; set; }
        public string nomLocalidad { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorrreoElectronico { get; set; }
    }
}
