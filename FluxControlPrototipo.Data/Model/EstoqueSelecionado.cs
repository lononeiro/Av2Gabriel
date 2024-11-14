using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Model
{
    public class EstoqueSelecionado
    {
        public int idEstoque {  get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProdutoEstoque { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal PrecoVendaProdutoEstoque { get; set; }
    }
}
