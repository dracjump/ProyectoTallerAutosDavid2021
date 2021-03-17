﻿using ProyectoTallerAutos.Datos;
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
            throw new NotImplementedException();
        }
    }
}
