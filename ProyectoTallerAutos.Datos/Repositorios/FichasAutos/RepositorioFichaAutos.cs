using ProyectoTallerAutos.Datos.Repositorios.FichasAutos.Interfaces;
using ProyectoTallerAutos.Entidades.DTOs.Clientes;
using ProyectoTallerAutos.Entidades.DTOs.FichaAuto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProyectoTallerAutos.Datos.Repositorios.FichasAutos
{
    public class RepositorioFichaAutos : IRepositorioFichaAutos
    {
        private readonly SqlConnection _sqlConnection;
        public RepositorioFichaAutos(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public List<FichaAutoDto> GetLista()
        {
            List<FichaAutoDto> lista = new List<FichaAutoDto>();
            try
            {
                string cadenaComando = "SELECT f.FichaDeAutoId,c.Nombre,c.Apellido,c.NroDocumento,ma.NomMarca," +
                    "ti.Descripcion,m.NombreModelo,f.Patente FROM FichasDeAutos f " +
                    "INNER JOIN Clientes c ON f.ClienteId = c.ClienteId" +
                    " INNER JOIN Modelos m ON f.ModeloId = m.ModeloId " +
                    "INNER JOIN TiposDeVehiculos ti ON m.TipoDeVehiculoId = ti.TipoDeVehiculoId INNER JOIN MarcasDeAutos ma ON m.MarcaId = ma.MarcaId";
                SqlCommand comando = new SqlCommand(cadenaComando, _sqlConnection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    var fichaAutoDto = ConstruirFichaAutoDto(reader);
                    lista.Add(fichaAutoDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private FichaAutoDto ConstruirFichaAutoDto(SqlDataReader reader)
        {
            FichaAutoDto fichaAutoDto = new FichaAutoDto();
            fichaAutoDto.FichaDeAutoId = reader.GetInt32(0);
            fichaAutoDto.NombreCliente = reader.GetString(1);
            fichaAutoDto.ApellidoCliente = reader.GetString(2);
            fichaAutoDto.nroDoc = reader.GetString(3);
            fichaAutoDto.marca = reader.GetString(4);
            fichaAutoDto.tipoVehic = reader.GetString(5);
            fichaAutoDto.modelo = reader.GetString(6);
            fichaAutoDto.patente = reader.GetString(7);
            return fichaAutoDto;

        }
    }
}
