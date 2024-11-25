using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Model
{
    public class ProdutoComDesconto
    {
        public Estoque Produto { get; set; }
        public double Desconto { get; set; }
    }

}
