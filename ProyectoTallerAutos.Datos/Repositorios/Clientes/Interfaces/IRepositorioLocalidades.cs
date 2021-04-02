using ProyectoTallerAutos.Entidades.DTOs.Localidad;
using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Clientes.Interfaces
{
    public interface IRepositorioLocalidades
    {
        Localidad GetLocalidadesPorId(int id);
        List<LocalidadDto> GetLista();
        void Guardar(Localidad localidad);
        void Borrar(int id);
        bool Existe(Localidad localidad);
        bool EstaRelacionado(Localidad localidad);
    }
}
