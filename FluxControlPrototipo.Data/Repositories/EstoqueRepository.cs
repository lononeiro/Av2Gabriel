using FluxControl.Data.Interface;
using FluxControl.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Repositories

{
    public class EstoqueRepository : IEstoqueRepository
    {
        private DbFluxControlContext db;

        public EstoqueRepository(DbFluxControlContext context)
        {
            db = context;
        }
        public void Incluir(Estoque estoque)
        {
            db.Entry(estoque).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            db.SaveChanges();
        }

        public List<dynamic> SelecionarTodos()
        {
            var resultado = from estoque in db.Estoques
                            join produto in db.Produtos on estoque.ProdutoIdProduto equals produto.IdProduto
                            select new
                            {
                                estoque.idEstoque,
                                estoque.Descricao,
                                estoque.QuantidadeEstoque,
                                estoque.PrecoVendaEstoque,
                                
                                estoque.DataValidadeEstoque,
                                estoque.LoteEstoque,
                                NomeProduto = produto.Nome
                            };

            return resultado.ToList<dynamic>();
        }

        public Estoque? SelecionarPelaChave(int idEstoque)
        {
            var produtoSelecionado = db.Estoques
                .Where(e => e.idEstoque == idEstoque)
                .FirstOrDefault();

            return produtoSelecionado;
        }

        public void alterar(Estoque estoque)
        {
            db.Entry(estoque).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public EstoqueSelecionado? SelecionarPeloNome(string nomeProduto)
        {
            var estoqueSelecionado = (from estoque in db.Estoques
                                      join produto in db.Produtos on estoque.ProdutoIdProduto equals produto.IdProduto
                                      where produto.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase)
                                      select new EstoqueSelecionado
                                      {
                                          NomeProduto = produto.Nome,
                                          DescricaoProdutoEstoque = estoque.Descricao,
                                          QuantidadeEstoque = (int)estoque.QuantidadeEstoque,
                                          PrecoVendaProdutoEstoque = (decimal)estoque.PrecoVendaEstoque
                                      })
                                       .FirstOrDefault();

            return estoqueSelecionado;
        }

        public void Excluir(Estoque estoque)
        {
            db.Entry(estoque).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        EstoqueSelecionado? IEstoqueRepository.SelecionarPelaChave(int id)
        {
            throw new NotImplementedException();
        }

        Estoque? IEstoqueRepository.SelecionarPeloNome(string nomeProduto)
        {
            throw new NotImplementedException();
        }
        
        public void SelecionarProdutoPeloLote(int lote)
        {
            var produtoSelecionado = db.Estoques
                .Where(e => e.LoteEstoque == lote)  // Filtra pelo lote especificado
                .Select(e => new
                {
                })
                .FirstOrDefault();
        }

        public Estoque SelecionarProdutoPelaChave(int id)
        {
            return db.Estoques.FirstOrDefault(e => e.ProdutoIdProduto == id);

        }

        public void AtualizarQuantidade(int idProduto, int quantidade)
        {

            //var produto = SelecionarProdutoPeloLote(produto);

            //if (produto == null)
            //    throw new Exception("Produto não encontrado.");

            //produto.Quantidade += quantidade; 

            //// Salva as alterações no banco de dados
            //db.SaveChanges();
        }
    }
}
