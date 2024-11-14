using System;
using System.Collections.Generic;

namespace FluxControl.Data.Model;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public bool Admin { get; set; }
}
