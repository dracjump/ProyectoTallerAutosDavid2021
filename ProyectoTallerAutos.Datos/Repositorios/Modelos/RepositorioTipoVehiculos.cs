﻿using ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos
{
    public class RepositorioTipoVehiculos : IRepositorioTipoVehiculos
    {
        private readonly SqlConnection _sqlConnection;
        public RepositorioTipoVehiculos(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
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
            List<TipoVehiculo> lista = new List<TipoVehiculo>();
            try
            {

                string cadenaComando = "select TipoDeVehiculoId, Descripcion from TiposDeVehiculos";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TipoVehiculo tipo = ConstruirTipoVehiculo(reader);
                    lista.Add(tipo);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private TipoVehiculo ConstruirTipoVehiculo(SqlDataReader reader)
        {
            return new TipoVehiculo
            {
                TipoVehiculoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),

            };
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
