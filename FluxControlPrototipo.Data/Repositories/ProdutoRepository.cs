using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluxControl.Data.Interface;
using FluxControl.Data.Model;
using Microsoft.EntityFrameworkCore;
namespace FluxControl.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private DbFluxControlContext db;

        public ProdutoRepository(DbFluxControlContext context)
        {
            db = context;
        }


        public void Alterar(Produto oProduto)
        {
            db.Entry(oProduto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();   
        }

        public void Excluir(Produto oProduto)
        {
            db.Entry(oProduto).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Produto oProduto)
        {
            db.Add(oProduto);
            db.SaveChanges();
        }

        public List<Produto> SelecionarCombobox()
        {
            return db.Produtos.ToList();
        }


        public IEnumerable<Produto> SelecionarTodos()
        {

            return db.Produtos.ToList();
        }


        public ProdutoSelecionado? SelecionarPelaChave(int chave)
        {
            var produtoSelecionado = (from produto in db.Produtos
                                      join tipoProduto in db.TipoProdutos on produto.TipoProdutoIdTipoProduto equals tipoProduto.IdTipoProduto
                                      where produto.IdProduto == chave
                                      select new ProdutoSelecionado
                                      {
                                          IdProduto = produto.IdProduto,
                                          NomeProduto = produto.Nome,
                                          NomeTipoProduto = tipoProduto.Nome
                                      })
                                      .FirstOrDefault();

            return produtoSelecionado;
        }

        // Consulta por Nome
        public ProdutoSelecionado? SelecionarPeloNome(string nomeProduto)
        {
            var produtoSelecionado = (from produto in db.Produtos
                                      join tipoProduto in db.TipoProdutos on produto.TipoProdutoIdTipoProduto equals tipoProduto.IdTipoProduto
                                      where produto.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase)
                                      select new ProdutoSelecionado
                                      {
                                          IdProduto = produto.IdProduto,
                                          NomeProduto = produto.Nome,
                                          NomeTipoProduto = tipoProduto.Nome
                                      })
                                      .FirstOrDefault();

            return produtoSelecionado;
        }
    }
}
