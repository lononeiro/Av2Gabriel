using FluxControl.Data.Repositories;
using FluxControl.Data.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace FluxControl.Test
{
    public class TesteEstoque
    {
        private EstoqueRepository _estoqueRepository;
        

        [SetUp]
        public void Setup()
        {
             var _db = new DbFluxControlContext();
            _estoqueRepository = new EstoqueRepository(_db);

        }

        [Test]
        public void IncluirEstoque()
        {
            var novoEstoque = new Estoque
            {
                ProdutoIdProduto = 1,
                Descricao = "Novo Estoque",
                PrecoVendaEstoque = 60,
                QuantidadeEstoque = 200,
                LoteEstoque = 123,   
                DataValidadeEstoque = DateTime.Today.AddMonths(2),
            };

            _estoqueRepository.Incluir(novoEstoque);
        }

        [Test]
        public void SelecionarTodosEstoques()
        {
            var estoques = _estoqueRepository.SelecionarTodos();
        }

        [Test]
        public void SelecionarEstoquePelaChave()
        {
            var estoque = _estoqueRepository.SelecionarPelaChave(21);
        }

        [Test]
        public void AlterarEstoque()
        {
            Estoque estoque = _estoqueRepository.SelecionarPelaChave(21);

            estoque.Descricao = "Descrição Alterada";
            _estoqueRepository.alterar(estoque);

        }

        [Test]
        public void ExcluirEstoque()
        {
           
            Estoque estoque = _estoqueRepository.SelecionarPelaChave(23);
            _estoqueRepository.Excluir(estoque);

        }

        [Test]
        public void SelecionarProdutoPeloLote()
        {
            _estoqueRepository.SelecionarProdutoPeloLote(312);
        }

        [Test]
        public void AtualizarQuantidadeEstoque()
        {
            Estoque estoque = _estoqueRepository.SelecionarPelaChave(21);

            estoque.QuantidadeEstoque += 50;
            _estoqueRepository.alterar(estoque);
        }
    }
}
