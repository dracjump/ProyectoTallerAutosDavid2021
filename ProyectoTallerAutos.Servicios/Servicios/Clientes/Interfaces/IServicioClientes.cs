using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Servicios.Servicios.Clientes.Interfaces
{
    public interface IServicioClientes
    {
        Cliente GetClientePorId(int id);
        List<Cliente> GetLista();
        void Guardar(Cliente cliente);
        void Borrar(int id);
        bool Existe(Cliente cliente);
        bool EstaRelacionado(Cliente cliente);
    }
}
