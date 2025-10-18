using System;
using System.Collections.Generic;

namespace DPA_EP_23200334.CORE.Core.Entities;

public partial class Carrera
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Estudiante> Estudiante { get; set; } = new List<Estudiante>();
}
