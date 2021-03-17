using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Servicios.Servicios.Modelos.Interfaces
{
    public interface IServicioModelos
    {
        Modelo GetModeloPorId(int id);
        List<Modelo> GetLista();
        void Guardar(Modelo marca);
        void Borrar(Modelo modelo);
        bool Existe(Modelo modelo);
        bool EstaRelacionado(Modelo modelo);
    }
}
