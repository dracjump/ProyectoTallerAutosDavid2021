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
    public class ServicioMarcas : IServicioMarcas
    {
        private IRepositorioMarcas _repositorio;
        private ConexionBd _conexionBd;
        public ServicioMarcas()
        {
            _conexionBd = new ConexionBd();
        }
        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioMarcas(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(MarcaAuto marca)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioMarcas(_conexionBd.AbrirConexion());
                var estaRelacionado = _repositorio.EstaRelacionado(marca);
                _conexionBd.CerrarConexion();
                return estaRelacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(MarcaAuto marca)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioMarcas(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(marca);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public List<MarcaAuto> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioMarcas(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public MarcaAuto GetMarcaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(MarcaAuto marca)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioMarcas(_conexionBd.AbrirConexion());
                _repositorio.Guardar(marca);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
