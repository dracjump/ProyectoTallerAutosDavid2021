using ProyectoTallerAutos.Datos;
using ProyectoTallerAutos.Datos.Repositorios.FichasAutos;
using ProyectoTallerAutos.Datos.Repositorios.FichasAutos.Interfaces;
using ProyectoTallerAutos.Entidades.DTOs.FichaAuto;
using ProyectoTallerAutos.Servicios.Servicios.FichasAutos.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProyectoTallerAutos.Servicios.Servicios.FichasAutos
{
    public class ServicioFichaAutos : IServicioFichaAutos
    {
        private IRepositorioFichaAutos _repositorio;
        private ConexionBd _conexion;
        public ServicioFichaAutos()
        {

        }
        public List<FichaAutoDto> GetLista()
        {
            _conexion = new ConexionBd();
            _repositorio = new RepositorioFichaAutos(_conexion.AbrirConexion());
            var lista = _repositorio.GetLista();
            _conexion.CerrarConexion();
            return lista;
        }
    }
}
