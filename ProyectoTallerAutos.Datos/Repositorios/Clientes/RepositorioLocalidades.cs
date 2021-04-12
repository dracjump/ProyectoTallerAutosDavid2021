using ProyectoTallerAutos.Datos.Repositorios.Clientes.Interfaces;
using ProyectoTallerAutos.Entidades.DTOs.Localidad;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Clientes
{
    public class RepositorioLocalidades : IRepositorioLocalidades
    {
        private readonly SqlConnection _sqlConnection;
        private readonly IRepositorioProvincias repositorioProvincias;
        //private SqlConnection sqlConnection;
        //private readonly IRepositorioProvincias repositorioProvincias;

        //public RepositorioLocalidades(SqlConnection sqlConnection, RepositorioProvincias repositorioProvincias)
        //{
        //    _sqlConnection = sqlConnection;
        //    _repositorioProvincias = repositorioProvincias;
        //}

        public RepositorioLocalidades(SqlConnection sqlConnection)
        {
            this._sqlConnection = sqlConnection;//this.sqlConnection = sqlConnection;
        }

        public RepositorioLocalidades(SqlConnection sqlConnection, IRepositorioProvincias repositorioProvincias)
        {
            _sqlConnection = sqlConnection;
            this.repositorioProvincias = repositorioProvincias;
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM Localidades WHERE LocalidadId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            };
        }


        public bool Existe(Localidad localidad)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;
                if (localidad.LocalidadId == 0)
                {
                    string cadenaComando = "SELECT LocalidadId,NombreLocalidad, ProvinciaId FROM Localidades WHERE NombreLocalidad=@nombre and ProvinciaId=@provinciaId";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@provinciaId", localidad.provincia.ProvinciaId);
                }
                else
                {
                    string cadenaComando = "SELECT LocalidadId,NombreLocalidad, ProvinciaId FROM Localidades WHERE NombreLocalidad=@nombre and ProvinciaId=@provinciaId and LocalidadId<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@provinciaId", localidad.provincia.ProvinciaId);
                    comando.Parameters.AddWithValue("@id", localidad.LocalidadId);
                }
                reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<LocalidadDto> GetLista()
        {
            List<LocalidadDto> lista = new List<LocalidadDto>();
            try
            {

                string cadenaComando = "select LocalidadId, NombreLocalidad,NombreProvincia FROM Localidades l " +
                    "INNER JOIN Provincias p on L.ProvinciaId=P.ProvinciaId";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var localidadDto = ConstruirLocalidadDto(reader);
                    lista.Add(localidadDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception("Error al leer las ciudadees");
            }
        }

        public Localidad GetLocalidadesPorId(int id)
        {
            Localidad localidad = null;
            try
            {
                string cadenaComando = "select LocalidadId, NombreLocalidad, ProvinciaId  FROM Localidades WHERE LocalidadId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    localidad = ConstruirLocalidad(reader);

                }
                reader.Close();
                return localidad;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        private LocalidadDto ConstruirLocalidadDto(SqlDataReader reader)
        {
            return new LocalidadDto
            {
                LocalidadId = reader.GetInt32(0),
                NombreLocalidad = reader.GetString(1),
                Nomprovincia = reader.GetString(2)

            };
        }


        private Localidad ConstruirLocalidad(SqlDataReader reader)
        {
            Localidad localidad = new Localidad();
            localidad.LocalidadId = reader.GetInt32(0);
            localidad.NombreLocalidad = reader.GetString(1);
            localidad.provincia = repositorioProvincias.GetProvinciaPorId(reader.GetInt32(2));
            return localidad;
        }

        public void Guardar(Localidad localidad)
        {
            if (localidad.LocalidadId == 0) //Si no extiste Localidad, entonces me va a agregar una.
            {//Nueva Localidad
                try
                {
                    string cadenaComando = "INSERT INTO Localidades VALUES(@nombre, @provinciaId)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@provinciaId", localidad.provincia.ProvinciaId);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";//Posible error🙄
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    localidad.LocalidadId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
            else
            {//Editar Localidad
                string cadenaComando = "UPDATE Localidades SET NombreLocalidad=@nombre,ProvinciaId=@ProvId WHERE LocalidadId=@id ";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@nombre", localidad.NombreLocalidad);
                comando.Parameters.AddWithValue("@ProvId", localidad.provincia.ProvinciaId);
                comando.Parameters.AddWithValue("@id", localidad.LocalidadId);

                comando.ExecuteNonQuery();
            }
        }

        public bool EstaRelacionado(Localidad localidad)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Localidades WHERE ProvinciaId=@id";//"SELECT COUNT(*) FROM Clientes WHERE LocalidadId=@id";
                var comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", localidad.provincia.ProvinciaId);//("@id", localidad.provincia.ProvinciaId);//localidad.LocalidadId
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
    }
}
