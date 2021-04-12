namespace ProyectoTallerAutos.Entidades.Entidades
{
    public class Modelo
    {
        public int ModeloId { get; set; }
        public MarcaAuto marcaAuto { get; set; }
        public TipoVehiculo tipoVehiculo { get; set; }
        public string nomModelo { get; set; }
    }
}
