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
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(TipoDocumento tipoDocumento)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TipoDocumento tipoDocumento)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
