using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPA_EP_23200334.CORE.Core.DTOs;
using DPA_EP_23200334.CORE.Core.Entities;
using DPA_EP_23200334.CORE.Core.Interfaces;
using static DPA_EP_23200334.CORE.Core.DTOs.CarreraDTO;

namespace DPA_EP_23200334.CORE.Core.Services
{
    public class CarreraService
    {
        private readonly ICarrerarepository _carreraRepository;
        public CarreraService(ICarrerarepository carreraRepository)
        {
            _carreraRepository = carreraRepository;
        }

        public async Task<IEnumerable<CarreraListDTO>> GetCarreras()
        {
            var carreras = await _carreraRepository.GetCarreras();
            var carrerasDTO = new List<CarreraListDTO>();

            foreach (var carrera in carreras)
            {
                var carreraDTO = new CarreraListDTO();
                carreraDTO.Id = carrera.Id;
                carreraDTO.Nombre = carrera.Nombre;

                carrerasDTO.Add(carreraDTO);
            }
            return carrerasDTO;
        }


        public async Task<CarreraListDTO> GetCarreraById(int id)
        {
            var carrera = await _carreraRepository.GetCarreraById(id);
            if (carrera == null)
            {
                return null;
            }
            var carreraDTO = new CarreraListDTO
            {
                Id = carrera.Id,
                Nombre = carrera.Nombre
            };
            return carreraDTO;
        }
        public async Task<int> Create(CarreraCreateDTO carreraCreateDTO)
        {
            var carrera = new Carrera
            {
                Nombre = carreraCreateDTO.Nombre
            };
            await _carreraRepository.AddCarrera(carrera);
            return carrera.Id;
        }

        public async Task<CarreraListDTO> Update(int id, CarreraCreateDTO carreraCreateDTO)
        {
            var carrera = await _carreraRepository.GetCarreraById(id);
            if (carrera == null)
            {
                return null;
            }
            carrera.Nombre = carreraCreateDTO.Nombre;
            await _carreraRepository.UpdateCarrera(carrera);
            var carreraDTO = new CarreraListDTO
            {
                Id = carrera.Id,
                Nombre = carrera.Nombre
            };
            return carreraDTO;
        }
        public async Task<bool> Delete(int id)
        {
            var carrera = await _carreraRepository.GetCarreraById(id);
            if (carrera == null)
            {
                return false;
            }
            await _carreraRepository.DeleteCarrera(id);
            return true;
        }
    }
}
