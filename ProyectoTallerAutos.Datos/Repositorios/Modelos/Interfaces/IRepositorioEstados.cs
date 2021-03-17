using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces
{
    public interface IRepositorioEstados
    {
        Estado GetEstadoPorId(int id);
        List<Estado> GetLista();
        void Guardar(Estado estado);
        void Borrar(int id);
        bool Existe(Estado estado);
        bool EstaRelacionado(Estado estado);
    }
}
