using System;
using System.Collections.Generic;

namespace FluxControl.Data.Model;

public partial class TipoProduto
{
    public int IdTipoProduto { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
