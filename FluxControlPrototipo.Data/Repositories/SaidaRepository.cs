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
    public class SaidaRepository : ISaidaRepository
    {

        private DbFluxControlContext db;

        public SaidaRepository(DbFluxControlContext context)
        {
            db = context;
        }

        public void RegistrarSaida(int idestoque, int quantidade, double precoUnitario, int lote)
        {
            // Localiza o produto no estoque pelo ID
            var produtoEstoque = db.Estoques.FirstOrDefault(p => p.idEstoque == idestoque);

            if (produtoEstoque != null && produtoEstoque.QuantidadeEstoque >= quantidade)
            {
                // Atualiza a quantidade no estoque
                produtoEstoque.QuantidadeEstoque -= quantidade;

                // Cria uma nova entrada de saída
                var novaSaida = new Saida
                {
                    ProdutoIdProduto = produtoEstoque.ProdutoIdProduto,
                    DataSaida = DateTime.Now,
                    PrecoSaida = precoUnitario * quantidade,
                    QuantidadeSaida = quantidade,
                    LoteSaida = lote,
                    
                };

                // Adiciona a nova saída ao banco de dados
                db.Saida.Add(novaSaida);

                // Salva as alterações no banco de dados
                db.SaveChanges();
            }
            else
            {
                // Exceção ou mensagem caso a quantidade em estoque seja insuficiente
                throw new InvalidOperationException("Quantidade insuficiente no estoque.");
            }
        }
        public Saida SelecionarPeloLote(int produtoId, int lote)
        {
            return db.Saida.FirstOrDefault(e => e.ProdutoIdProduto == produtoId && e.LoteSaida == lote);
        }
        public void Excluir(Saida oSaida)
        {
            db.Entry(oSaida).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Saida> SelecionarPorIntervaloDeTempo(DateTime dataInicio, DateTime dataFim)
        {
            return db.Saida
                     .Where(s => s.DataSaida >= dataInicio && s.DataSaida <= dataFim)
                     .ToList();
        }

    }
}