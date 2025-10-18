using DPA_EP_23200334.CORE.Core.Entities;
using DPA_EP_23200334.CORE.Core.Interfaces;
using DPA_EP_23200334.CORE.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DPA_EP_23200334.CORE.Core.DTOs.EstudianteDTO;

namespace DPA_EP_23200334.CORE.Infrastructure.Repositories
{
    public class EstudianteRepository : IEstudianteRepository
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EstudianteRepository(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }
        public async Task<IEnumerable<EstudianteListDTO>> GetEstudiantes()
        {
            var estudiantes = await _estudianteRepository.GetEstudiantes();
            var estudiantesDTO = new List<EstudianteListDTO>();

            foreach (var estudiante in estudiantes)
            {
                var estudianteDTO = new EstudianteListDTO();
                estudianteDTO.Nombre = estudiante.Nombre;
                estudiantesDTO.Add(estudianteDTO);
            }
            return estudiantesDTO;
        }
        public async Task<EstudianteListDTO> GetEstudianteById(int id)
        {
            var estudiante = await _estudianteRepository.GetEstudianteById(id);
            if (estudiante == null)
            {
                return null;
            }
            var estudianteDTO = new EstudianteListDTO
            {
                Nombre = estudiante.Nombre
            };
            return estudianteDTO;
        }
        public async Task<int> Create(EstudianteCreateDTO estudianteCreateDTO)
        {
            var estudiante = new Estudiante();
            estudiante.Nombres = estudianteCreateDTO.Nombres;
            estudiante.Paterno = estudianteCreateDTO.Paterno;
            estudiante.Materno = estudianteCreateDTO.Materno;

            await _estudianteRepository.AddEstudiante(estudiante);
            return estudiante.Id;
        }
    }
}
