using ProyectoTallerAutos.Entidades.DTOs.Clientes;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Clientes.Interfaces
{
    public interface IRepositorioClientes
    {
        Cliente GetClientePorId(int id);
        List<ClienteDto> GetLista();
        void Guardar(Cliente cliente);
        void Borrar(int id);
        bool Existe(Cliente cliente);
        bool EstaRelacionado(Cliente cliente);
    }
}
