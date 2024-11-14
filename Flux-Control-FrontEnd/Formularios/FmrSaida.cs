using FluxControl.Data.Model;
using FluxControl.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrSaida : Form
    {
        private EstoqueRepository estoqueRepository = new EstoqueRepository(new DbFluxControlContext());
        private SaidaRepository saidaRepository = new SaidaRepository(new DbFluxControlContext());
        private List<Estoque> produtosSelecionados = new List<Estoque>();
        private Estoque produtoAtualSelecionado;
        private double precoTotal = 0;

        public FmrSaida()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.Size = new System.Drawing.Size(1300, 800);
            CarregaGrid();
        }

        private void BtnEncerrar_Click(object sender, EventArgs e)
        {

            SalvarSaida();


            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            produtosSelecionados.Clear();
            precoTotal = 0;
            AtualizarPrecoTotal();
            CarregaGrid();
            this.Close();
        }

        private void CarregaGrid()
        {
            GrdEstoque.AutoGenerateColumns = false;
            GrdEstoque.Columns.Clear();

            DataGridViewTextBoxColumn colIdEstoque = new DataGridViewTextBoxColumn
            {
                HeaderText = "Id Estoque",
                DataPropertyName = "idEstoque"
            };
            GrdEstoque.Columns.Add(colIdEstoque);

            DataGridViewTextBoxColumn colNomeProduto = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nome do Produto",
                DataPropertyName = "NomeProduto"
            };
            GrdEstoque.Columns.Add(colNomeProduto);

            DataGridViewTextBoxColumn colDescricaoProduto = new DataGridViewTextBoxColumn
            {
                HeaderText = "Descrição Produto",
                DataPropertyName = "Descricao"
            };
            GrdEstoque.Columns.Add(colDescricaoProduto);

            DataGridViewTextBoxColumn colQuantidade = new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantidade",
                DataPropertyName = "QuantidadeEstoque"
            };
            GrdEstoque.Columns.Add(colQuantidade);

            DataGridViewTextBoxColumn colLote = new DataGridViewTextBoxColumn
            {
                HeaderText = "Lote",
                DataPropertyName = "LoteEstoque"
            };
            GrdEstoque.Columns.Add(colLote);

            DataGridViewTextBoxColumn colPrecoVenda = new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço Venda",
                DataPropertyName = "PrecoVendaEstoque"
            };
            GrdEstoque.Columns.Add(colPrecoVenda);

            DataGridViewTextBoxColumn colDataValidade = new DataGridViewTextBoxColumn
            {
                HeaderText = "Data de Validade",
                DataPropertyName = "DataValidadeEstoque",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            };
            GrdEstoque.Columns.Add(colDataValidade);

            DataGridViewButtonColumn colSelecionar = new DataGridViewButtonColumn
            {
                HeaderText = "Selecionar",
                Name = "BtnSelecionar",
                Text = "",
                UseColumnTextForButtonValue = true
            };
            GrdEstoque.Columns.Add(colSelecionar);

            GrdEstoque.DataSource = estoqueRepository.SelecionarTodos();
            GrdEstoque.CellClick += GrdEstoque_CellClick;
        }

        private void GrdEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != GrdEstoque.Columns["BtnSelecionar"].Index || e.RowIndex < 0)
                    return;

                var row = GrdEstoque.Rows[e.RowIndex];
                var idEstoque = row.Cells[0].Value as int?;

                if (!idEstoque.HasValue)
                {
                    MessageBox.Show("ID do estoque não encontrado.");
                    return;
                }

                // Carrega o produto atual selecionado para ser adicionado
                produtoAtualSelecionado = estoqueRepository.SelecionarPelaChave(idEstoque.Value);

                if (produtoAtualSelecionado == null)
                {
                    MessageBox.Show("Estoque não encontrado.");
                    return;
                }

                TxtProduto.Text = Convert.ToString(produtoAtualSelecionado.ProdutoIdProduto);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar processar o item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (produtoAtualSelecionado == null)
                {
                    MessageBox.Show("Nenhum produto selecionado.");
                    return;
                }

                int quantidadeSaida = Convert.ToInt32(TxtQuantidade.Text);
                produtoAtualSelecionado.QuantidadeEstoque = quantidadeSaida;

                //if (produtosSelecionados.Any(p => p.idEstoque == produtoAtualSelecionado.idEstoque))
                //{
                //    MessageBox.Show("Este produto já foi adicionado.");
                //    return;
                //}

                produtosSelecionados.Add(produtoAtualSelecionado);

                precoTotal += produtoAtualSelecionado.PrecoVendaEstoque * produtoAtualSelecionado.QuantidadeEstoque;
                AtualizarPrecoTotal();

                produtoAtualSelecionado = null; // Limpa o produto atual após adicionar
                TxtProduto.Clear();
                TxtQuantidade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar produto: {ex.Message}");
            }
        }

        private void AtualizarPrecoTotal()
        {
            TxtPrecoTotal.Text = $"Preço Total: {precoTotal:C}";
        }

        private void SalvarSaida()
        {
            try
            {
                StringBuilder produtosSaida = new StringBuilder("Saídas registradas:\n");

                foreach (var produto in produtosSelecionados)
                {
                    estoqueRepository.AtualizarQuantidade(produto.idEstoque, produto.QuantidadeEstoque);
                    saidaRepository.RegistrarSaida(produto.idEstoque, produto.QuantidadeEstoque, produto.PrecoVendaEstoque, produto.LoteEstoque);

                    produtosSaida.AppendLine($"{produto.ProdutoIdProduto} - Quantidade: {produto.QuantidadeEstoque}");
                }
                MessageBox.Show(produtosSaida.ToString(), "Registro de Saída");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar saida: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            produtosSelecionados.Clear();
            precoTotal = 0;
            AtualizarPrecoTotal();
            CarregaGrid();
        }

    }
}