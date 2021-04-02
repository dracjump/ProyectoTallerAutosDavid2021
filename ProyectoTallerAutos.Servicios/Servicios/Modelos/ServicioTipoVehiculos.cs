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
    public class ServicioTipoVehiculos : IServicioTipoVehiculos
    {
        private IRepositorioTipoVehiculos _repositorio;
        private ConexionBd _conexionBd;
        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoVehiculos(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoVehiculo tipo)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoVehiculos(_conexionBd.AbrirConexion());
                var estaRelacionado = _repositorio.EstaRelacionado(tipo);
                _conexionBd.CerrarConexion();
                return estaRelacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoVehiculo tipo)
        {
            _conexionBd = new ConexionBd();
            _repositorio = new RepositorioTipoVehiculos(_conexionBd.AbrirConexion());
            var existe = _repositorio.Existe(tipo);
            _conexionBd.CerrarConexion();
            return existe;
        }

        public List<TipoVehiculo> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoVehiculos(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public TipoVehiculo GetTipoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TipoVehiculo tipo)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoVehiculos(_conexionBd.AbrirConexion());
                _repositorio.Guardar(tipo);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
