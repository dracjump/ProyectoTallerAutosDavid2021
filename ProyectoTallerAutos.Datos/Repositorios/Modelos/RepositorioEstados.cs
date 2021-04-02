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
            try
            {
                string cadenaComando = "DELETE FROM Estados WHERE EstadoId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            };
        }

        public bool EstaRelacionado(Estado estado)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM FichasdeAutos WHERE EstadoId=@id";
                var comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", estado.EstadoId);
                int cantidadRegistros = (int)comando.ExecuteScalar();
                if (cantidadRegistros > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Estado estado)
        {
            try
            {
                SqlCommand comando;
                if (estado.EstadoId == 0)
                {
                    string cadenaComando = "SELECT EstadoId,Descripcion FROM Estados WHERE Descripcion=@nombre";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", estado.Descripcion);
                }
                else
                {
                    string cadenaComando = "SELECT EstadoId,Descripcion FROM Estados WHERE Descripcion=@nombre AND EstadoId<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", estado.Descripcion);
                    comando.Parameters.AddWithValue("@id", estado.EstadoId);
                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
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
            if (estado.EstadoId == 0) //Si no extiste estado, entonces me va a agregar uno.
            {//Nueva marca
                try
                {
                    string cadenaComando = "INSERT INTO Estados VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", estado.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    estado.EstadoId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
            else
            {//Editar Estado
                string cadenaComando = "UPDATE Estados SET Descripcion=@nombre WHERE EstadoId=@id ";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@nombre", estado.Descripcion);
                comando.Parameters.AddWithValue("@id", estado.EstadoId);
                comando.ExecuteNonQuery();
            };
        }
    }
}
