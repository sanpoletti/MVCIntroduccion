using System;
using System.Collections.Generic;

namespace MVCIntroduccion.Models;

public partial class GestorBd
{
    public int Id { get; set; }

    public int Documento { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;
}
