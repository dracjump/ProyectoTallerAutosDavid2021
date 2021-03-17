using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces
{
   public interface IRepositorioTipoVehiculos
    {
        TipoVehiculo GetTipoPorId(int id);
        List<TipoVehiculo> GetLista();
        void Guardar(TipoVehiculo tipo);
        void Borrar(int id);
        bool Existe(TipoVehiculo tipo);
        bool EstaRelacionado(TipoVehiculo tipo);
    }
}
