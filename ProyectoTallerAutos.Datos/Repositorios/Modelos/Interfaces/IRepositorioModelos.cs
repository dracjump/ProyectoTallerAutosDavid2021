using ProyectoTallerAutos.Entidades.DTOs.Modelos;
using ProyectoTallerAutos.Entidades.Entidades;
using System.Collections.Generic;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces
{
    public interface IRepositorioModelos
    {
        Modelo GetModeloPorId(int id);
        List<ModeloDto> GetLista();
        void Guardar(Modelo marca);
        void Borrar(Modelo modelo);
        bool Existe(Modelo modelo);
        bool EstaRelacionado(Modelo modelo);
    }
}
