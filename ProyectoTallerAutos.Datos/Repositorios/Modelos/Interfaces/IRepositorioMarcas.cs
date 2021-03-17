using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Datos.Repositorios.Modelos.Interfaces
{
    public interface IRepositorioMarcas
    {
        MarcaAuto GetMarcaPorId(int id);
        List<MarcaAuto> GetLista();
        void Guardar(MarcaAuto marca);
        void Borrar(int id);
        bool Existe(MarcaAuto marca);
        bool EstaRelacionado(MarcaAuto marca);
    }
}
