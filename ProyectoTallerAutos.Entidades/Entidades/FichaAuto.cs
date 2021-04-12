namespace ProyectoTallerAutos.Entidades.Entidades
{
    public class FichaAuto
    {
        public int FichaDeAutoId { get; set; }
        public Cliente Cliente { get; set; }
        public Modelo modelo { get; set; }
        public string patente { get; set; }
    }
}
