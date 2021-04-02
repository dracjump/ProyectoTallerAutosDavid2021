using ProyectoTallerAutos.Datos;
using ProyectoTallerAutos.Datos.Repositorios.Clientes;
using ProyectoTallerAutos.Datos.Repositorios.Clientes.Interfaces;
using ProyectoTallerAutos.Entidades.DTOs.Localidad;
using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Clientes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Servicios.Servicios.Clientes
{
    public class ServicioLocalidades : IServicioLocalidades
    {
        private  IRepositorioLocalidades _repositorio;
        private IRepositorioProvincias _repositorioProvincias;
        private  ConexionBd _conexionBd;
        public ServicioLocalidades()
        {

        }

        public void Borrar(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                _repositorio.Borrar(id);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public bool EstaRelacionado(Localidad localidad)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                var estaRelacionado = _repositorio.EstaRelacionado(localidad);
                _conexionBd.CerrarConexion();
                return estaRelacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Localidad localidad)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                var existe = _repositorio.Existe(localidad);
                _conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw; throw new Exception(e.Message);
            }
        }

        public List<LocalidadDto> GetLista()
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                var lista = _repositorio.GetLista();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public Localidad GetLocalidadesPorId(int id)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorioProvincias = new RepositorioProvincias(_conexionBd.AbrirConexion());
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion(),_repositorioProvincias);
                var localidad = _repositorio.GetLocalidadesPorId(id);
                _conexionBd.CerrarConexion();
                return localidad;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Guardar(Localidad localidad)
        {
            try
            {
                _conexionBd = new ConexionBd();
                _repositorio = new RepositorioLocalidades(_conexionBd.AbrirConexion());
                _repositorio.Guardar(localidad);
                _conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
