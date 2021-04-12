using ProyectoTallerAutos.Datos.Repositorios.Clientes.Interfaces;
using ProyectoTallerAutos.Entidades.DTOs.Clientes;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Clientes
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly SqlConnection _sqlConnection;
        public RepositorioClientes(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClientePorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClienteDto> GetLista()
        {
            List<ClienteDto> lista = new List<ClienteDto>();
            try
            {
                string cadenaComando = "SELECT c.ClienteId,c.Nombre,c.Apellido,c.NroDocumento,c.Direccion," +
                    " l.NombreLocalidad,c.TelefonoFijo,c.TelefonoMovil,C.CorreoElectronico " +
                    "FROM Clientes c INNER JOIN Localidades l ON c.LocalidadId = l.LocalidadId";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var clienteDto = ConstruirClienteDto(reader);
                    lista.Add(clienteDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private ClienteDto ConstruirClienteDto(SqlDataReader reader)
        {
            ClienteDto clienteDto = new ClienteDto();
            clienteDto.ClienteId = reader.GetInt32(0);
            clienteDto.Nombre = reader.GetString(1);
            clienteDto.Apellido = reader.GetString(2);
            clienteDto.NroDocumento = reader.GetString(3);
            clienteDto.Direccion = reader.GetString(4);
            clienteDto.nomLocalidad = reader.GetString(5);
            clienteDto.TelefonoFijo = reader[6] != DBNull.Value ? reader.GetString(6) : null;
            clienteDto.TelefonoMovil = reader.GetString(7);
            clienteDto.CorrreoElectronico = reader[8] != DBNull.Value ? reader.GetString(8) : null;
            return clienteDto;
        }

        public void Guardar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
