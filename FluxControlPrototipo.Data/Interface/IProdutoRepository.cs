using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxControl.Data.Model;

namespace FluxControl.Data.Interface
{
    public interface IProdutoRepository
    {
        void Incluir(Produto oProduto);
        void Excluir(Produto oProduto);
        void Alterar(Produto oProduto);
        public IEnumerable<Produto> SelecionarTodos();
        public ProdutoSelecionado? SelecionarPelaChave(int chave);

        public List<Produto> SelecionarCombobox();

        public ProdutoSelecionado? SelecionarPeloNome(string nomeProduto);
    }
}
