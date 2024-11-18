using FluxControl.Data.Repositories;
using FluxControl.Data.Model;
using NUnit.Framework;

namespace FluxControl.Test
{
    public class TesteProduto
    {
        ProdutoRepository produtoRepository;

        [SetUp]
        public void Setup()
        {
            var db = new DbFluxControlContext();
            produtoRepository = new ProdutoRepository(db);
        }

        [Test]
        public void IncluirProduto()
        {
            Produto produto = new Produto
            {
                Nome = "Produto Teste",
                TipoProdutoIdTipoProduto = 1
            };

            produtoRepository.Incluir(produto);
        }

        [Test]
        public void AlterarProduto()
        {
            // Criar e incluir um produto para alterar
            Produto produto = new Produto
            {
                Nome = "Produto Original",
                TipoProdutoIdTipoProduto = 1
            };
            produtoRepository.Incluir(produto);

            // Alterar o produto
            produto.Nome = "Produto Alterado";
            produtoRepository.Alterar(produto);
        }

        [Test]
        public void ExcluirProduto()
        {
            // Criar e incluir um produto para excluir
            Produto produto = new Produto
            {
                Nome = "Produto Excluir",
                TipoProdutoIdTipoProduto = 1
            };
            produtoRepository.Incluir(produto);
            produtoRepository.Excluir(produto);

        }

        [Test]
        public void SelecionarTodosProdutos()
        {
            var produtos = produtoRepository.SelecionarTodos();
        }

        [Test]
        public void SelecionarProdutoPelaChave()
        {
            // Criar e incluir um produto para selecionar
            Produto produto = new Produto
            {
                Nome = "Produto Chave",
                TipoProdutoIdTipoProduto = 1
            };
            produtoRepository.Incluir(produto);

            var produtoSelecionado = produtoRepository.SelecionarPelaChave(produto.IdProduto);
            Assert.IsNotNull(produtoSelecionado, "O produto não foi encontrado pela chave.");
            Assert.AreEqual("Produto Chave", produtoSelecionado.NomeProduto);
        }

        [Test]
        public void SelecionarProdutoPeloNome()
        {
            // Criar e incluir um produto para selecionar pelo nome
            Produto produto = new Produto
            {
                Nome = "Produto Nome2",
                TipoProdutoIdTipoProduto = 1
            };
            produtoRepository.Incluir(produto);
        }

        [Test]
        public void SelecionarNomePelaChave()
        {
            // Criar e incluir um produto para selecionar o nome pela chave
            Produto produto = new Produto
            {
                Nome = "Produto Chave Nome",
                TipoProdutoIdTipoProduto = 1
            };
            produtoRepository.Incluir(produto);

            var nomeProduto = produtoRepository.SelecionarNomePelaChave(produto.IdProduto);
            Assert.AreEqual("Produto Chave Nome", nomeProduto, "O nome do produto não foi retornado corretamente pela chave.");
        }
    }
}
