using FluxControl.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Interface
{
    public interface IEntradaRepository
    {
        void Incluir(Entrada oEntrada);
        void Excluir(Entrada oEntrada);
        void Alterar(Entrada oEntrada);
        List<Entrada> SelecionarTodos();
        void SelecionarPelaChave(string nome);

        public Entrada SelecionarPeloLote(int produtoId, int lote);

        public List<Entrada> SelecionarPorIntervaloDeTempo(DateTime dataInicio, DateTime dataFim);
    }
}
