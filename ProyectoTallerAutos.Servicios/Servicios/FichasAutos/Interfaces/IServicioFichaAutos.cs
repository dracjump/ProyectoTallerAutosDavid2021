using ProyectoTallerAutos.Entidades.DTOs.FichaAuto;
using System.Collections.Generic;

namespace ProyectoTallerAutos.Servicios.Servicios.FichasAutos.Interfaces
{
    public interface IServicioFichaAutos
    {
        List<FichaAutoDto> GetLista();
    }
}
