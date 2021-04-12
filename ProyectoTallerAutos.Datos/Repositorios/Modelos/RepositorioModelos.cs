using ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces;
using ProyectoTallerAutos.Entidades.DTOs.Modelos;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos
{
    public class RepositorioModelos : IRepositorioModelos
    {
        private readonly SqlConnection _sqlconnection;
        //private readonly IRepositorioMarcas _repositorioMarcas;
        //private readonly IRepositorioTipoVehiculos _repositorioTipoVehiculos;
        public RepositorioModelos(SqlConnection sqlConnection)
        {
            _sqlconnection = sqlConnection;
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
            List<ModeloDto> lista = new List<ModeloDto>();
            try
            {
                string cadenaComando = "SELECT m.ModeloId,ma.NomMarca,t.Descripcion,m.NombreModelo FROM Modelos m INNER JOIN MarcasDeAutos ma ON m.MarcaId = ma.MarcaId INNER JOIN TiposDeVehiculos t ON m.TipoDeVehiculoId = t.TipoDeVehiculoId ";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlconnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var modeloDto = ConstruirModeloDto(reader);
                    lista.Add(modeloDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private ModeloDto ConstruirModeloDto(SqlDataReader reader)
        {
            ModeloDto modeloDto = new ModeloDto();
            modeloDto.ModeloId = reader.GetInt32(0);
            modeloDto.marcaAuto = reader.GetString(1); ;
            modeloDto.tipoVehiculo = reader.GetString(2);
            modeloDto.nomModelo = reader.GetString(3);
            return modeloDto;
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
