using System;
using System.Collections.Generic;

namespace FluxControl.Data.Model;

public partial class Saida
{
    public int Id { get; set; }

    public int ProdutoIdProduto { get; set; }

    public DateTime DataSaida { get; set; }

    public double PrecoSaida { get; set; }

    public int QuantidadeSaida { get; set; }

    public int LoteSaida { get; set; }

    public virtual Produto ProdutoIdProdutoNavigation { get; set; } = null!;
}
