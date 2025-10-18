using DPA_EP_23200334.CORE.Core.Entities;
using DPA_EP_23200334.CORE.Core.Interfaces;
using DPA_EP_23200334.CORE.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPA_EP_23200334.CORE.Core.DTOs;
using static DPA_EP_23200334.CORE.Core.DTOs.EstudianteDTO;


namespace DPA_EP_23200334.CORE.Infrastructure.Repositories
{
    public class EstudianteRepository : IEstudianteRepository
    {

        private readonly UniversidadContext _context;

        public EstudianteRepository(UniversidadContext context)
        {
            _context = context;
        }

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
                estudianteDTO.Nombres = estudiante.Nombres;
                estudianteDTO.Paterno = estudiante.Paterno;
                estudianteDTO.Materno = estudiante.Materno;
                estudianteDTO.FechaNacimiento = (DateTime)estudiante.FechaNacimiento;
                estudianteDTO.Correo = estudiante.Correo;
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
                Nombres = estudiante.Nombres
            };
            return estudianteDTO;
        }
        public async Task<int> Create(Estudiante estudiante)
        {
            await _context.Estudiante.AddAsync(estudiante);
            await _context.SaveChangesAsync();

            return estudiante.Id;
        }
        public async Task<Estudiante> Update(Estudiante estudiante)
        {
            _context.Estudiante.Update(estudiante);
            await _context.SaveChangesAsync();
            return estudiante;
        }
    }
}
