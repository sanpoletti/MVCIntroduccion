using System;
using System.Collections.Generic;

namespace MVCIntroduccion.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Telefono { get; set; }

    public DateTime? FechaNac { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Direccion { get; set; }

    public int? IsActive { get; set; }
}
