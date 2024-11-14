using System;
using System.Collections.Generic;

namespace FluxControl.Data.Model;

public partial class Estoque
{
    public int idEstoque { get; set; }

    public int ProdutoIdProduto { get; set; }

    public string Descricao { get; set; } = null!;

    public double PrecoVendaEstoque { get; set; }

    public int QuantidadeEstoque { get; set; }

    public int LoteEstoque { get; set; }
    public DateTime DataValidadeEstoque { get; set; }

    public virtual Produto ProdutoIdProdutoNavigation { get; set; } = null!;
}
