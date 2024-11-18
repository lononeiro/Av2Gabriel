using FluxControl.Data.Repositories;
using FluxControl.Data.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace FluxControl.Test
{
    public class TesteSaida
    {
        private SaidaRepository _saidaRepository;
        private DbFluxControlContext _db;

        [SetUp]
        public void Setup()
        {
            var _db = new DbFluxControlContext();
            _saidaRepository = new SaidaRepository(_db);
        }

        [Test]
        public void RegistrarSaida()
        {
            _saidaRepository.RegistrarSaida(15, 1, 20.0, 3120312);

        }

        [Test]
        public void RegistrarSaida_QuantidadeInsuficiente()
        {
            Assert.Throws<InvalidOperationException>(() => _saidaRepository.RegistrarSaida(1, 150, 20.0, 102));
        }

        [Test]
        public void SelecionarPeloLote()
        {
            
            var saida = _saidaRepository.SelecionarPeloLote(1, 312);

        }

        [Test]
        public void ExcluirSaida()
        {

            Saida saida = _saidaRepository.SelecionarPeloLote(12, 3120312);
            _saidaRepository.Excluir(saida);
        }

        [Test]
        public void SelecionarPorIntervaloDeTempo()
        {
            var saidas = _saidaRepository.SelecionarPorIntervaloDeTempo(DateTime.Today.AddDays(-2), DateTime.Today);
        }
    }
}
