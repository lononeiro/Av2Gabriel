using FluxControl.Data.Repositories;
using FluxControl.Data.Model;
using NUnit.Framework;
using System.Linq;
using Microsoft.Identity.Client;

namespace FluxControl.Test
{
    public class TesteTipoProduto
    {
        TipoProdutoRepository tipoProdutoRepository;

        [SetUp]
        public void Setup()
        {
            var db = new DbFluxControlContext();
            tipoProdutoRepository = new TipoProdutoRepository(db);
        }

        [Test]
        public void IncluirTipoProduto()
        {
            TipoProduto tipoProduto = new TipoProduto
            {
                Nome = "Tipo Produto Teste"
            };

            tipoProdutoRepository.Incluir(tipoProduto);
        }

        [Test]
        public void AlterarTipoProduto()
        {
            // Criar e incluir um tipo de produto para alterar
            TipoProduto tipoProduto = new TipoProduto
            {
                Nome = "Tipo Produto Original"
            };
            tipoProdutoRepository.Incluir(tipoProduto);

            // Alterar o tipo de produto
            tipoProduto.Nome = "Tipo Produto Alterado";
            tipoProdutoRepository.Alterar(tipoProduto);
        }

        [Test]
        public void ExcluirTipoProduto()
        {
            // Criar e incluir um tipo de produto para excluir
            TipoProduto tipoProduto = new TipoProduto
            {
                Nome = "Tipo Produto Excluir"
            };
            tipoProdutoRepository.Incluir(tipoProduto);

            // Excluir o tipo de produto
            tipoProdutoRepository.Excluir(tipoProduto);
        }

        [Test]
        public void SelecionarTodosTiposProdutos()
        {
            // Adicionar alguns tipos de produtos
            tipoProdutoRepository.Incluir(new TipoProduto { Nome = "Tipo Produto 1" });
            tipoProdutoRepository.Incluir(new TipoProduto { Nome = "Tipo Produto 2" });

        }

        [Test]
        public void SelecionarTipoProdutoPelaChave()
        {
            tipoProdutoRepository.SelecionarPelaChave(1);
        }
    }
}
