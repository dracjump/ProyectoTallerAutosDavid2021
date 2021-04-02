using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Entidades.Entidades
{
    public class MarcaAuto: ICloneable//Hace una copia de la clase
    {
        public int MarcaId { get; set; }
        public string NomMarca { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone(); //MemberwiseClone, hace una copia superficial del objeto.
        }
    }
}
