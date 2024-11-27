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
        private ProdutoRepository produtoRepository = new ProdutoRepository(new DbFluxControlContext());
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

        private bool VerificaQuantidade(int id, int quantidade)
        {
            Estoque estoque = estoqueRepository.SelecionarPelaChave(id);

            return estoque.QuantidadeEstoque >= quantidade;
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

                produtoAtualSelecionado = estoqueRepository.SelecionarPelaChave(idEstoque.Value);

                if (produtoAtualSelecionado == null)
                {
                    MessageBox.Show("Estoque não encontrado.");
                    return;
                }

                string nomeProduto = produtoRepository.SelecionarNomePelaChave(produtoAtualSelecionado.ProdutoIdProduto);
                TxtProduto.Text = nomeProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar processar o item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void BtnAdicionar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (produtoAtualSelecionado == null)
        //        {
        //            MessageBox.Show("Nenhum produto selecionado.");
        //            return;
        //        }

        //        int quantidadeSaida = Convert.ToInt32(TxtQuantidade.Text);
        //        if (VerificaQuantidade(produtoAtualSelecionado.idEstoque, quantidadeSaida))
        //        {
        //            double desconto = 0;

        //            if (!string.IsNullOrEmpty(TxtDesconto.Text))
        //            {
        //                desconto = Convert.ToDouble(TxtDesconto.Text);
        //                if (desconto < 0 || desconto > 100)
        //                {
        //                    MessageBox.Show("O desconto deve estar entre 0 e 100%.");
        //                    return;
        //                }
        //            }

        //            produtoAtualSelecionado.QuantidadeEstoque = quantidadeSaida;

        //            produtosSelecionados.Add(produtoAtualSelecionado);

        //            precoTotal += produtoAtualSelecionado.PrecoVendaEstoque * (1 - desconto / 100) * quantidadeSaida;
        //            AtualizarPrecoTotal();

        //            produtoAtualSelecionado = null;
        //            TxtProduto.Clear();
        //            TxtQuantidade.Clear();
        //            TxtDesconto.Clear();
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Erro ao adicionar produto: Quantidade insuficiente no estoque.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Erro ao adicionar produto: {ex.Message}");
        //    }
        //}


        private List<ProdutoComDesconto> produtosSelecionadosComDesconto = new List<ProdutoComDesconto>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (produtoAtualSelecionado == null)
                {
                    MessageBox.Show("Nenhum produto selecionado.");
                    return;
                }

                // Obter a quantidade informada na TextBox
                if (!int.TryParse(TxtQuantidade.Text, out int quantidadeSaida) || quantidadeSaida <= 0)
                {
                    MessageBox.Show("Por favor, insira uma quantidade válida.");
                    return;
                }

                // Validar se há estoque suficiente
                if (!VerificaQuantidade(produtoAtualSelecionado.idEstoque, quantidadeSaida))
                {
                    MessageBox.Show("Quantidade insuficiente no estoque.");
                    return;
                }

                // Obter o desconto informado
                double desconto = 0;
                if (!string.IsNullOrEmpty(TxtDesconto.Text))
                {
                    if (!double.TryParse(TxtDesconto.Text, out desconto) || desconto < 0 || desconto > 100)
                    {
                        MessageBox.Show("O desconto deve estar entre 0 e 100%.");
                        return;
                    }
                }

                // Criar um objeto com os dados informados
                var produtoComDesconto = new ProdutoComDesconto
                {
                    Produto = produtoAtualSelecionado,
                    QuantidadeSaida = quantidadeSaida, // Armazena a quantidade de saída
                    Desconto = desconto
                };

                // Adicionar o produto à lista
                produtosSelecionadosComDesconto.Add(produtoComDesconto);

                // Atualizar o preço total considerando o desconto
                double precoComDesconto = produtoAtualSelecionado.PrecoVendaEstoque * (1 - desconto / 100);
                precoTotal += precoComDesconto * quantidadeSaida;
                AtualizarPrecoTotal();

                // Limpar campos após adicionar
                produtoAtualSelecionado = null;
                TxtProduto.Clear();
                TxtQuantidade.Clear();
                TxtDesconto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar produto: {ex.Message}");
            }
        }
        //private void SalvarSaida()
        //{
        //    var desconto = Convert.ToInt64(TxtDesconto.Text);
        //    try
        //    {
        //        StringBuilder produtosSaida = new StringBuilder("Saídas registradas:\n");

        //        foreach (var produto in produtosSelecionados)
        //        {
        //            string nomeProduto = produtoRepository.SelecionarNomePelaChave(produto.ProdutoIdProduto);

        //            saidaRepository.RegistrarSaida(produto.idEstoque, produto.QuantidadeEstoque, produto.PrecoVendaEstoque, produto.LoteEstoque, (double)desconto);
        //            produtosSaida.AppendLine($"{nomeProduto} - Quantidade: {produto.QuantidadeEstoque} - Desconto: {TxtDesconto.Text}%");
        //        }

        //        MessageBox.Show(produtosSaida.ToString(), "Registro de Saída");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Erro ao registrar saída: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    produtosSelecionados.Clear();
        //    precoTotal = 0;
        //    AtualizarPrecoTotal();
        //    CarregaGrid();
        //}

        private void SalvarSaida()
        {
            try
            {
                StringBuilder produtosSaida = new StringBuilder("Saídas registradas:\n");

                foreach (var item in produtosSelecionadosComDesconto)
                {
                    string nomeProduto = produtoRepository.SelecionarNomePelaChave(item.Produto.ProdutoIdProduto);
                    var produtoEstoque = estoqueRepository.SelecionarPelaChave(item.Produto.idEstoque);

                    if (produtoEstoque == null)
                    {
                        MessageBox.Show($"Produto com ID {item.Produto.idEstoque} não encontrado no estoque.");
                        continue;
                    }

                    // Atualizar a quantidade de estoque no banco
                    produtoEstoque.QuantidadeEstoque -= item.QuantidadeSaida;

                    // Registrar a saída no banco de dados
                    saidaRepository.RegistrarSaida(
                        produtoEstoque.idEstoque,
                        item.QuantidadeSaida, // Usa a quantidade de saída informada
                        produtoEstoque.PrecoVendaEstoque,
                        produtoEstoque.LoteEstoque,
                        item.Desconto
                    );

                    if ( produtoEstoque.QuantidadeEstoque == 0)
                    {
                        MessageBox.Show($"Produto: {produtoRepository.SelecionarNomePelaChave(produtoEstoque.ProdutoIdProduto)} esgotou.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        estoqueRepository.Excluir(produtoEstoque);
                    }

                    produtosSaida.AppendLine(
                        $"{nomeProduto} - Quantidade: {item.QuantidadeSaida} - " +
                        $"Preço Original: {produtoEstoque.PrecoVendaEstoque:C} - " +
                        $"Desconto: {item.Desconto:F2}%"
                    );
                }

                MessageBox.Show(produtosSaida.ToString(), "Registro de Saída");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar saída: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            produtosSelecionadosComDesconto.Clear();
            precoTotal = 0;
            AtualizarPrecoTotal();
            CarregaGrid();
        }
        private void AtualizarPrecoTotal()
        {
            TxtPrecoTotal.Text = $"Preço Total: {precoTotal:C}";
        }
    }
}
