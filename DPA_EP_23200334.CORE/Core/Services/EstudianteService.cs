using DPA_EP_23200334.CORE.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DPA_EP_23200334.CORE.Core.DTOs.EstudianteDTO;

namespace DPA_EP_23200334.CORE.Core.Services
{
    public class EstudianteService
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EstudianteService(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        public async Task<IEnumerable<EstudianteListDTO>> EstudianteListDTO()
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
    }
}
