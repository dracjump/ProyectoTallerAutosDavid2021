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
        List<Localidad> GetLista();
        void Guardar(Localidad localidad);
        void Borrar(Localidad localidad);
        bool Existe(Localidad localidad);
        bool EstaRelacionado(Localidad localidad);
    }
}
