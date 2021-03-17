using ProyectoTallerAutos.Datos;
using ProyectoTallerAutos.Datos.Repositorios.Modelos;
using ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces;
using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Servicios.Servicios.Modelos
{
    public class ServicioEstados : IServicioEstados
    {
        private IRepositorioEstados _repositorio;
        private ConexionBd _conexionBd;
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Estado estado)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Estado estado)
        {
            throw new NotImplementedException();
        }

        public Estado GetEstadoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estado> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(Estado estado)
        {
            throw new NotImplementedException();
        }
    }
}
