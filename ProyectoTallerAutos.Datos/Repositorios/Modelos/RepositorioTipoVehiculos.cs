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
    public class RepositorioTipoVehiculos : IRepositorioTipoVehiculos
    {
        private readonly SqlConnection _sqlConnection;
        public RepositorioTipoVehiculos(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM TiposDeVehiculos WHERE TipoDeVehiculoId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            };
        }

        public bool EstaRelacionado(TipoVehiculo tipo)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Modelos WHERE TipoDeVehiculoId=@id";
                var comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", tipo.TipoVehiculoId);
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

        public bool Existe(TipoVehiculo tipo)
        {
            try
            {
                SqlCommand comando;
                if (tipo.TipoVehiculoId == 0)
                {
                    string cadenaComando = "SELECT TipoDeVehiculoId,Descripcion FROM TiposDeVehiculos WHERE Descripcion=@nombre";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tipo.Descripcion);
                }
                else
                {
                    string cadenaComando = "SELECT TipoDeVehiculoId,Descripcion FROM TiposDeVehiculos WHERE Descripcion=@nombre AND TipoDeVehiculoId<>@id ";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tipo.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipo.TipoVehiculoId);
                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
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
            if (tipo.TipoVehiculoId == 0) //Si no extiste TIpo, entonces me va a agregar uno.
            {//Nuevo Tipo
                try
                {
                    string cadenaComando = "INSERT INTO TiposDeVehiculos VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tipo.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    tipo.TipoVehiculoId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
            else
            {//Editar Tipo
                string cadenaComando = "UPDATE TiposDeVehiculos SET Descripcion=@nombre WHERE TipoDeVehiculoId=@id ";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@nombre", tipo.Descripcion);
                comando.Parameters.AddWithValue("@id", tipo.TipoVehiculoId);
                comando.ExecuteNonQuery();
            }
        }
    }
}
