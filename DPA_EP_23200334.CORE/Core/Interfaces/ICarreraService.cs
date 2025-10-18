using DPA_EP_23200334.CORE.Core.DTOs;
using static DPA_EP_23200334.CORE.Core.DTOs.CarreraDTO;

namespace DPA_EP_23200334.CORE.Core.Interfaces
{
    public interface ICarreraService
    {
        Task<int> Create(CarreraCreateDTO carreraCreateDTO);
        Task<IEnumerable<CarreraListDTO>> CarreraListDTO();
        Task<CarreraListDTO> GetCarreraById(int id);
    }
}