using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Model
{
    public class EstoqueView
    {
        public int IdEstoque { get; set; }
        public int EmpresaIdEmpresa { get; set; }
        public string DescricaoProdutoEstoque { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal PrecoVendaProdutoEstoque { get; set; }
        public string NomeProduto { get; set; }
    }
}
