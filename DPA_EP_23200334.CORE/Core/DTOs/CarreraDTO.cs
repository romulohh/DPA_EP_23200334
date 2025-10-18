using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_EP_23200334.CORE.Core.DTOs
{
    public class CarreraDTO
    {
        public class CarreraListDTO
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = null!;
        }

        public class CarreraCreateDTO
        {
            public string Nombre { get; set; } = null!;
        }

        public class CarreraUpdateDTO
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = null!;
        }

        public class CarreraDeleteDTO
        {
            public int Id { get; set; }
        }
    }
}
