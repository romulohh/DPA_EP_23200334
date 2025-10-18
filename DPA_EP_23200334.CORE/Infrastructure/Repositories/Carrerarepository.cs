using DPA_EP_23200334.CORE.Core.Entities;
using DPA_EP_23200334.CORE.Core.Interfaces;
using DPA_EP_23200334.CORE.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_EP_23200334.CORE.Infrastructure.Repositories
{
    public class Carrerarepository : ICarrerarepository
    {
        private readonly UniversidadContext _context;
        public Carrerarepository(UniversidadContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Carrera>> GetCarreras()
        {
            var carreras = await _context.Carrera.ToListAsync();
            return _context.Carrera.ToList();
        }
        public async Task<Carrera> GetCarreraById(int id)
        {
            var carrera = await _context.Carrera.FindAsync(id);
            return carrera!;
        }

        public async Task AddCarrera(Carrera carrera)
        {
            _context.Carrera.Add(carrera);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCarrera(Carrera carrera)
        {
            _context.Carrera.Update(carrera);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCarrera(int id)
        {
            var carrera = await _context.Carrera.FindAsync(id);
            if (carrera != null)
            {
                _context.Carrera.Remove(carrera);
                await _context.SaveChangesAsync();
            }
        }
    }
}
