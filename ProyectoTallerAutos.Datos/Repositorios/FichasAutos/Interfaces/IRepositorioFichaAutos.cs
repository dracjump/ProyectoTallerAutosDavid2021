using ProyectoTallerAutos.Entidades.DTOs.Clientes;
using ProyectoTallerAutos.Entidades.DTOs.FichaAuto;
using System.Collections.Generic;

namespace ProyectoTallerAutos.Datos.Repositorios.FichasAutos.Interfaces
{
    public interface IRepositorioFichaAutos
    {
        //Cliente GetClientePorId(int id);
        List<FichaAutoDto> GetLista();
        //void Guardar(Cliente cliente);
        //void Borrar(int id);
        //bool Existe(Cliente cliente);
        //bool EstaRelacionado(Cliente cliente);
    }
}
