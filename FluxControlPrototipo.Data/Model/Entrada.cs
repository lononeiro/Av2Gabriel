using System;
using System.Collections.Generic;

namespace FluxControl.Data.Model;

public partial class Entrada
{
    public int IdEntradaProduto { get; set; }

    public int ProdutoIdProduto { get; set; }

    public DateTime DataEntrada { get; set; }

    public double PrecoCompra { get; set; }

    public int QuantidadeEntrada { get; set; }
    public int Lote { get; set; }
    public double PrecoVenda { get; set; }

    public virtual Produto ProdutoIdProdutoNavigation { get; set; } = null!;
}
