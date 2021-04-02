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
            try
            {
                string cadenaComando = "DELETE FROM MarcasDeAutos WHERE MarcaId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            };
        }

        public bool EstaRelacionado(MarcaAuto marca)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Modelos WHERE MarcaId=@id";
                var comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", marca.MarcaId);
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

        public bool Existe(MarcaAuto marca)
        {
            try
            {
                SqlCommand comando;
                if (marca.MarcaId == 0)
                {
                    string cadenaComando = "SELECT MarcaId,NomMarca FROM MarcasDeAutos WHERE NomMarca=@nombre";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", marca.NomMarca);
                }
                else
                {
                    string cadenaComando = "SELECT MarcaId,NomMarca FROM MarcasDeAutos WHERE NomMarca=@nombre AND MarcaId<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", marca.NomMarca);
                    comando.Parameters.AddWithValue("@id", marca.MarcaId);
                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
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
            if (marca.MarcaId == 0) //Si no extiste marca, entonces me va a agregar una.
            {//Nueva marca
                try
                {
                    string cadenaComando = "INSERT INTO MarcasDeAutos VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", marca.NomMarca);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    marca.MarcaId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
            else
            {//Editar marca
                string cadenaComando = "UPDATE MarcasDeAutos SET NomMarca=@nombre WHERE MarcaId=@id ";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@nombre", marca.NomMarca);
                comando.Parameters.AddWithValue("@id", marca.MarcaId);
                comando.ExecuteNonQuery();
            }
        }
    }
}
