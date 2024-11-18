using FluxControl.Data.Repositories;
using FluxControl.Data.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace FluxControl.Test
{
    public class TesteEntrada
    {
        EntradaRepository entradaRepository;

        [SetUp]
        public void Setup()
        {
            var db = new DbFluxControlContext();
            entradaRepository = new EntradaRepository(db);
        }

        [Test]
        public void IncluirEntrada()
        {
            Entrada entrada = new Entrada
            {
                ProdutoIdProduto = 1,
                QuantidadeEntrada = 10,
                PrecoCompra = 100.0,
                DataEntrada = DateTime.Now,
                Lote = 123,
                DescricaoEntrada = "descrição"
            };

            entradaRepository.Incluir(entrada);
        }

        [Test]
        public void AlterarEntrada()
        {
            Entrada entrada = new Entrada
            {
                ProdutoIdProduto = 1,
                QuantidadeEntrada = 10,
                PrecoCompra = 100.0,
                DataEntrada = DateTime.Now,
                Lote = 124,
                DescricaoEntrada = "descrição"
            };

            entradaRepository.Incluir(entrada);

            entrada.QuantidadeEntrada = 20;
            entradaRepository.Alterar(entrada);
        }

        [Test]
        public void ExcluirEntrada()
        {
            Entrada entrada = new Entrada
            {
                ProdutoIdProduto = 1,
                QuantidadeEntrada = 10,
                PrecoCompra = 100.0,
                DataEntrada = DateTime.Now,
                Lote = 125,
                DescricaoEntrada = "descricao"
            };

            entradaRepository.Incluir(entrada);
            entradaRepository.Excluir(entrada);
        }

        [Test]
        public void SelecionarTodosEntradas()
        {;
          var entradas =  entradaRepository.SelecionarTodos();
        }

        [Test]
        public void SelecionarPeloLote()
        {
            var entradaPeloLote = entradaRepository.SelecionarPeloLote(1, 124);
        }

        [Test]
        public void SelecionarPorIntervaloDeTempo()
        {
            DateTime hoje = DateTime.Today;
            var entradasIntervalo = entradaRepository.SelecionarPorIntervaloDeTempo(hoje.AddDays(-2), hoje.AddDays(1));

        }
    }
}
