using ProyectoTallerAutos.Datos.Repositorios.Clientes.Interfaces;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Clientes
{
    public class RepositorioTipoDoc : IRepositorioTipoDoc
    {
        private readonly SqlConnection _sqlConnection;
        public RepositorioTipoDoc(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void Borrar(int id)
        {
            try
            {
                string cadenaComando = "DELETE FROM TiposDeDocumentos WHERE TipoDeDocumentoId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            };
        }

        public bool EstaRelacionado(TipoDocumento tipoDocumento)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Clientes WHERE TipoDeDocumentoId=@id";
                var comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@id", tipoDocumento.TipoDeDocumentoId);
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

        public bool Existe(TipoDocumento tipoDocumento)
        {
            try
            {
                SqlCommand comando;
                if (tipoDocumento.TipoDeDocumentoId == 0)
                {
                    string cadenaComando = "SELECT TipoDeDocumentoId,Descripcion FROM TiposDeDocumentos WHERE Descripcion=@nombre";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tipoDocumento.Descripcion);
                }
                else
                {
                    string cadenaComando = "SELECT TipoDeDocumentoId,Descripcion FROM TiposDeDocumentos WHERE Descripcion=@nombre AND TipoDeDocumentoId<>@id";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tipoDocumento.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipoDocumento.TipoDeDocumentoId);
                }
                SqlDataReader reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<TipoDocumento> GetLista()
        {
            List<TipoDocumento> lista = new List<TipoDocumento>();
            try
            {

                string cadenaComando = "select TipoDeDocumentoId, Descripcion from TiposDeDocumentos";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TipoDocumento tipoDocumento = ConstruirTipoDoc(reader);
                    lista.Add(tipoDocumento);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private TipoDocumento ConstruirTipoDoc(SqlDataReader reader)
        {
            return new TipoDocumento
            {
                TipoDeDocumentoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),

            };
        }

        public TipoDocumento GetTipoDocumentosPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(TipoDocumento tipoDocumento)
        {
            if (tipoDocumento.TipoDeDocumentoId == 0) //Si no extiste tipoDoc, entonces me va a agregar uno.
            {//Nuevo tipoDoc
                try
                {
                    string cadenaComando = "INSERT INTO TiposDeDocumentos VALUES(@nombre)";
                    SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                    comando.Parameters.AddWithValue("@nombre", tipoDocumento.Descripcion);
                    comando.ExecuteNonQuery();
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, _sqlConnection);
                    tipoDocumento.TipoDeDocumentoId = (int)(decimal)comando.ExecuteScalar();
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
            else
            {//Editar tipoDoc
                string cadenaComando = "UPDATE TiposDeDocumentos SET Descripcion=@nombre WHERE TipoDeDocumentoId=@id ";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                comando.Parameters.AddWithValue("@nombre", tipoDocumento.Descripcion);
                comando.Parameters.AddWithValue("@id", tipoDocumento.TipoDeDocumentoId);
                comando.ExecuteNonQuery();
            }
        }
    }
}
