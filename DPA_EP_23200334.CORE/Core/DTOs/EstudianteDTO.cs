using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_EP_23200334.CORE.Core.DTOs
{
    public class EstudianteDTO
    {
        public class EstudianteListDTO
        {
            public int IdEstudiante { get; set; }
            public string Nombres { get; set; } = string.Empty;
            public string Paterno { get; set; } = string.Empty;
            public string Materno { get; set; } = string.Empty;
            public DateTime FechaNacimiento { get; set; }
            public string Email { get; set; } = string.Empty;
        }
        public class EstudianteCreateDTO
        {
            public string Nombres { get; set; } = string.Empty;
            public string Apellido { get; set; } = string.Empty;
            public DateTime FechaNacimiento { get; set; }
            public string Email { get; set; } = string.Empty;
            public int CarreraId { get; set; }
        }
        public class EstudianteUpdateDTO
        {
            public int IdEstudiante { get; set; }
            public string Nombres { get; set; } = string.Empty;
            public string Apellido { get; set; } = string.Empty;
            public DateTime FechaNacimiento { get; set; }
            public string Email { get; set; } = string.Empty;
            public int CarreraId { get; set; }
        }
        public class EstudianteDeleteDTO
        {
            public int IdEstudiante { get; set; }
        }
    }
}
