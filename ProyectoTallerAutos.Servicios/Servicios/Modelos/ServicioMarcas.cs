using ProyectoTallerAutos.Datos;
using ProyectoTallerAutos.Datos.Repositorios.Modelos;
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
        private RepositorioMarcas _repositorio;
        private ConexionBd _conexionBd;
        public ServicioMarcas()
        {
            _conexionBd = new ConexionBd();
        }
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(MarcaAuto marca)
        {
            throw new NotImplementedException();
        }

        public bool Existe(MarcaAuto marca)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
