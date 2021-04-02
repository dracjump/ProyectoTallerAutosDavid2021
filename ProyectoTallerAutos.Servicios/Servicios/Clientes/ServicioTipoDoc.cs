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
    public class ServicioTipoDoc : IServicioTipoDoc
    {
        private IRepositorioTipoDoc _repositorio;
        private ConexionBd _conexionBd;

        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoDoc(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoDocumento tipoDocumento)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoDoc(_conexionBd.AbrirConexion());
                var estaRelacionado = _repositorio.EstaRelacionado(tipoDocumento);
                _conexionBd.CerrarConexion();
                return estaRelacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(TipoDocumento tipoDocumento)
        {
            _conexionBd = new ConexionBd();
            _repositorio = new RepositorioTipoDoc(_conexionBd.AbrirConexion());
            var existe = _repositorio.Existe(tipoDocumento);
            _conexionBd.CerrarConexion();
            return existe;
        }

        public List<TipoDocumento> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoDoc(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public TipoDocumento GetTipoDocumentosPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TipoDocumento tipoDocumento)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioTipoDoc(_conexionBd.AbrirConexion());
                _repositorio.Guardar(tipoDocumento);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
