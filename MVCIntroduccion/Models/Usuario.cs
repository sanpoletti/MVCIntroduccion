using System;
using System.Collections.Generic;

namespace MVCIntroduccion.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Password { get; set; }
}
