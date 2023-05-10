using System;
using System.Collections.Generic;

namespace MVCIntroduccion.Models;

public partial class Credenciale
{
    public string? Id { get; set; }

    public string? Secret { get; set; }

    public string? Usuario { get; set; }

    public string? AccessToken { get; set; }

    public string? RefreshToken { get; set; }
}
