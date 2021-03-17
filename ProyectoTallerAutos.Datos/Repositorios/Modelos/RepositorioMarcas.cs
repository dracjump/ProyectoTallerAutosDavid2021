using ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos
{
    public class RepositorioMarcas : IRepositorioMarcas
    {
        private readonly SqlConnection _sqlConnection;
        public RepositorioMarcas(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
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
            List<MarcaAuto> lista = new List<MarcaAuto>();
            try
            {

                string cadenaComando = "select MarcaId, NomMarca from MarcasDeAutos";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    MarcaAuto marca = ConstruirMarcaAuto(reader);
                    lista.Add(marca);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private MarcaAuto ConstruirMarcaAuto(SqlDataReader reader)
        {
            return new MarcaAuto
            {
                MarcaId = reader.GetInt32(0),
                NomMarca = reader.GetString(1),

            };
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
