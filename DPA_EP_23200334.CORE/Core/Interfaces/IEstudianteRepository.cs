using DPA_EP_23200334.CORE.Core.DTOs;

namespace DPA_EP_23200334.CORE.Core.Interfaces
{
    public interface IEstudianteRepository
    {
        Task<IEnumerable<EstudianteDTO.EstudianteListDTO>> GetEstudiantes();
    }
}