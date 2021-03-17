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
    public class RepositorioEstados : IRepositorioEstados
    {
        private readonly SqlConnection _sqlConnection;
        public RepositorioEstados(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Estado estado)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Estado estado)
        {
            throw new NotImplementedException();
        }

        public Estado GetEstadoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estado> GetLista()
        {
            List<Estado> lista = new List<Estado>();
            try
            {
                string cadenaComando = "select EstadoId, Descripcion from Estados";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estado estado = ConstruirEstado(reader);
                    lista.Add(estado);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Estado ConstruirEstado(SqlDataReader reader)
        {
            return new Estado
            {
                EstadoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),

            };
        }

        public void Guardar(Estado estado)
        {
            throw new NotImplementedException();
        }
    }
}
