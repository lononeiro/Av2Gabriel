using FluxControl.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Interface
{
    public interface ITipoDeProdutoRepository
    {
        void Incluir(TipoProduto oTipo);
        void Excluir(TipoProduto oTipo);
        void Alterar(TipoProduto oTipo);
        List<TipoProduto> SelecionarTodos();
    }
}
