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
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Estado estado)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                var estaRelacionado = _repositorio.EstaRelacionado(estado);
                _conexionBd.CerrarConexion();
                return estaRelacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Estado estado)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(estado);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
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
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioEstados(_conexionBd.AbrirConexion());
                _repositorio.Guardar(estado);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
