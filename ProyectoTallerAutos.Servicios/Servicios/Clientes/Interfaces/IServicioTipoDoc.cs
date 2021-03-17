using ProyectoTallerAutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTallerAutos.Servicios.Servicios.Clientes.Interfaces
{
    public interface IServicioTipoDoc
    {
        TipoDocumento GetTipoDocumentosPorId(int id);
        List<TipoDocumento> GetLista();
        void Guardar(TipoDocumento tipoDocumento);
        void Borrar(int id);
        bool Existe(TipoDocumento tipoDocumento);
        bool EstaRelacionado(TipoDocumento tipoDocumento);
    }
}
