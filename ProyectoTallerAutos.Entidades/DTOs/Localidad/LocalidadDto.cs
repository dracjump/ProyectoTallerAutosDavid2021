using System;

namespace ProyectoTallerAutos.Entidades.DTOs.Localidad
{
    public class LocalidadDto:ICloneable
    {
        public int LocalidadId { get; set; }
        public string NombreLocalidad { get; set; }
        public string Nomprovincia { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
