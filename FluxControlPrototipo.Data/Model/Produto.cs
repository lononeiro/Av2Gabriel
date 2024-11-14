using System;
using System.Collections.Generic;

namespace FluxControl.Data.Model;

public partial class Produto
{
    public int IdProduto { get; set; }

    public int TipoProdutoIdTipoProduto { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual ICollection<Estoque> Estoques { get; set; } = new List<Estoque>();

    public virtual ICollection<Saida> Saida { get; set; } = new List<Saida>();

    public virtual TipoProduto TipoProdutoIdTipoProdutoNavigation { get; set; } = null!;
}
