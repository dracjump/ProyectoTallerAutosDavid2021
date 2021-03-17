using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Clientes.Interfaces
{
   public interface IRepositorioProvincias
    {
        Provincia GetProvinciaPorId(int id);
        List<Provincia> GetLista();
        void Guardar(Provincia provincia);
        void Borrar(int id);
        bool Existe(Provincia provincia);
        bool EstaRelacionado(Provincia provincia);
    }
}
