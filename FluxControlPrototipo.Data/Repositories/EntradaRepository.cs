using FluxControl.Data.Interface;
using FluxControl.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Repositories
{
    public class EntradaRepository : IEntradaRepository
    {
        private DbFluxControlContext db;

        public EntradaRepository(DbFluxControlContext context)
        {
            db = context;
        }

        public void Alterar(Entrada oEntrada)
        {
            db.Entry(oEntrada).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(Entrada oEntrada)
        {
            db.Entry(oEntrada).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Entrada oEntrada)
        {
            db.Entry(oEntrada).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            db.SaveChanges();
        }

        public void SelecionarPelaChave(string nome)
        {
            
        }

        public List<Entrada> SelecionarTodos()
        {
            return db.Entrada.ToList();
        }

        public Entrada SelecionarPeloLote(int produtoId, int lote)
        {
            return db.Entrada.FirstOrDefault(e => e.ProdutoIdProduto == produtoId && e.Lote == lote);
        }
    }
}
