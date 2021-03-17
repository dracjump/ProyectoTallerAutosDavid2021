using ProyectoTallerAutos.Datos;
using ProyectoTallerAutos.Datos.Repositorios.Clientes;
using ProyectoTallerAutos.Datos.Repositorios.Clientes.Interfaces;
using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Clientes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Servicios.Servicios.Clientes
{
    public class ServicioProvincias : IServicioProvincias
    {
        private IRepositorioProvincias _repositorio;
        private ConexionBd _conexionBd;

        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Provincia provincia)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Provincia provincia)
        {
            throw new NotImplementedException();
        }

        public List<Provincia> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioProvincias(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexionBd.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public Provincia GetProvinciaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Provincia provincia)
        {
            throw new NotImplementedException();
        }
    }
}
