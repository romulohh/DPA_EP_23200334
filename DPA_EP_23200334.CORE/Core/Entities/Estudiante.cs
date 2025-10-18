using System;
using System.Collections.Generic;

namespace DPA_EP_23200334.CORE.Core.Entities;

public partial class Estudiante
{
    public int Id { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? Nombres { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Correo { get; set; }

    public int? CarreraId { get; set; }

    public virtual Carrera? Carrera { get; set; }
}
