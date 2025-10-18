using DPA_EP_23200334.CORE.Core.DTOs;
using DPA_EP_23200334.CORE.Core.Entities;
using static DPA_EP_23200334.CORE.Core.DTOs.EstudianteDTO;

namespace DPA_EP_23200334.CORE.Core.Interfaces
{
    public interface IEstudianteRepository
    {
        Task<int> Create(Estudiante estudiante);
        Task<EstudianteListDTO> GetEstudianteById(int id);
        Task<IEnumerable<EstudianteListDTO>> GetEstudiantes();
        Task<Estudiante> Update(Estudiante estudiante);
        //IEnumerable<Estudiante> GetAll();
    }
}