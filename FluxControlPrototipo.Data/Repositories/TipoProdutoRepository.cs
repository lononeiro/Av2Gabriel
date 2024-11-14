using FluxControl.Data.Interface;
using FluxControl.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Repositories
{
    public class TipoProdutoRepository : ITipoDeProdutoRepository
    {
        private DbFluxControlContext db;

        public TipoProdutoRepository(DbFluxControlContext context)
        {
            db = context;
        }

        public void Alterar(TipoProduto tipoProduto)
        {
            db.Entry(tipoProduto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(TipoProduto tipoProduto)
        {
            db.Entry(tipoProduto).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(TipoProduto tipoProduto)
        {
            db.Add(tipoProduto);
            db.SaveChanges();
        }

        public List<TipoProduto> SelecionarTodos()
        {
            return db.TipoProdutos.OrderBy(tp => tp.Nome).ToList();
        }


        public void SelecionarPelaChave(int chave)
        {

        }
    }
}
