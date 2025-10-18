using DPA_EP_23200334.CORE.Core.Entities;

namespace DPA_EP_23200334.CORE.Core.Interfaces
{
    public interface ICarrerarepository
    {
        Task AddCarrera(Carrera carrera);
        Task DeleteCarrera(int id);
        Task<Carrera> GetCarreraById(int id);
        Task<IEnumerable<Carrera>> GetCarreras();
        Task UpdateCarrera(Carrera carrera);
    }
}