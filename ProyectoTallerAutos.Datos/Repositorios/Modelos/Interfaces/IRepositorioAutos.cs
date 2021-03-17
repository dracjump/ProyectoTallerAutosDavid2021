using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces
{
    public interface IRepositorioAutos
    {
        Modelo GetModeloPorId(int id);
        List<Modelo> GetLista();
        void Guardar(Modelo marca);
        void Borrar(Modelo modelo);
        bool Existe(Modelo modelo);
        bool EstaRelacionado(Modelo modelo);
    }
}
