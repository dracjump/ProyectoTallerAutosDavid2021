using ProyectoTallerAutos.Datos;
using ProyectoTallerAutos.Datos.Repositorios.Modelos;
using ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces;
using ProyectoTallerAutos.Entidades.DTOs.Modelos;
using ProyectoTallerAutos.Entidades.Entidades;
using ProyectoTallerAutos.Servicios.Servicios.Modelos.Interfaces;
using System;
using System.Collections.Generic;

namespace ProyectoTallerAutos.Servicios.Servicios.Modelos
{
    public class ServicioModelos : IServicioModelos
    {
        private IRepositorioModelos _repositorioModelos;
        //private RepositorioMarcas _repositorioMarcas;
        //private RepositorioTipoVehiculos _repositorioTipoVehiculos;
        private ConexionBd _conexion;
        public ServicioModelos()
        {

        }
        public void Borrar(Modelo modelo)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Modelo modelo)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Modelo modelo)
        {
            throw new NotImplementedException();
        }

        public List<ModeloDto> GetLista()
        {
            _conexion = new ConexionBd();
            _repositorioModelos = new RepositorioModelos(_conexion.AbrirConexion());
            var lista = _repositorioModelos.GetLista();
            _conexion.CerrarConexion();
            return lista;
        }

        public Modelo GetModeloPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Modelo marca)
        {
            throw new NotImplementedException();
        }
    }
}
