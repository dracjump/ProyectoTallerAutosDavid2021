using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Servicios.Servicios.Clientes.Interfaces
{
    public interface IServicioProvincias
    {
        Provincia GetProvinciaPorId(int id);
        List<Provincia> GetLista();
        void Guardar(Provincia provincia);
        void Borrar(int id);
        bool Existe(Provincia provincia);
        bool EstaRelacionado(Provincia provincia);
    }
}
