using FluxControl.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxControl.Data.Model;

namespace FluxControl.Data.Interface
{
    public interface IEstoqueRepository
    {
        public List<dynamic> SelecionarTodos();
        void Incluir(Estoque estoque);
        public EstoqueSelecionado? SelecionarPelaChave(int id);
        void alterar(Estoque estoque);

        public Estoque? SelecionarPeloNome(string nomeProduto);
        void Excluir(Estoque estoque);
        void SelecionarProdutoPeloLote(int lote);
        void AtualizarQuantidade(int idProduto, int quantidade);
    }
}
