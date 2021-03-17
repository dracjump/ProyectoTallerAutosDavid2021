using ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos
{
    public class RepositorioTipoVehiculos : IRepositorioTipoVehiculos
    {
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(TipoVehiculo tipo)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TipoVehiculo tipo)
        {
            throw new NotImplementedException();
        }

        public List<TipoVehiculo> GetLista()
        {
            throw new NotImplementedException();
        }

        public TipoVehiculo GetTipoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TipoVehiculo tipo)
        {
            throw new NotImplementedException();
        }
    }
}
