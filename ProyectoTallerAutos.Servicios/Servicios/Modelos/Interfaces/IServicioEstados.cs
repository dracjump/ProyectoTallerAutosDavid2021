using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Servicios.Servicios.Modelos.Interfaces
{
    public interface IServicioEstados
    {
        Estado GetEstadoPorId(int id);
        List<Estado> GetLista();
        void Guardar(Estado estado);
        void Borrar(int id);
        bool Existe(Estado estado);
        bool EstaRelacionado(Estado estado);
    }
}
