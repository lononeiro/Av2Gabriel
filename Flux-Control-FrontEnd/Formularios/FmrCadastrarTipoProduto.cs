using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FluxControl.Data.Repositories;
using FluxControl.Data.Model;

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrCadastrarTipoProduto : Form
    {
        private bool _Incluir = true;
        private TipoProduto oProdutoSelecionado = null;
        private TipoProdutoRepository produtoTipoRepository = new TipoProdutoRepository(new DbFluxControlContext());
        ProdutoRepository produtoRepository = new ProdutoRepository(new DbFluxControlContext());

        public FmrCadastrarTipoProduto()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ProdutoExiste(string nomeProdutoTipo)
        {
            try
            {
                List<TipoProduto> produtos = produtoTipoRepository.SelecionarTodos();
                return produtos.Any(p => p.Nome.Equals(nomeProdutoTipo, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar se o produto existe: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retorna false em caso de erro
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNome.Text))
                {
                    MessageBox.Show("Por favor, insira o nome do tipo de produto.");
                    return;
                }


                if (_Incluir)
                {
                if (ProdutoExiste(TxtNome.Text))
                {
                    MessageBox.Show("Já existe um tipo de produto com esse nome. Por favor, escolha outro nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                    TipoProduto novoProdutoTipo = new TipoProduto { Nome = TxtNome.Text };
                    produtoTipoRepository.Incluir(novoProdutoTipo);
                }
                else
                {
                    oProdutoSelecionado.Nome = TxtNome.Text;
                    produtoTipoRepository.Alterar(oProdutoSelecionado);
                    _Incluir = true;
                }

                LimparControles();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o tipo de produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                GrdProdutos.AutoGenerateColumns = false;
                GrdProdutos.Columns.Clear();
                GrdProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn();
                colNome.HeaderText = "Nome Tipo";
                colNome.DataPropertyName = "Nome";
                GrdProdutos.Columns.Add(colNome);

                DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
                colEditar.HeaderText = "Editar";
                colEditar.Name = "BtnEditar";
                GrdProdutos.Columns.Add(colEditar);

                DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn();
                colExcluir.HeaderText = "Excluir";
                colExcluir.Name = "BtnExcluir";
                GrdProdutos.Columns.Add(colExcluir);

                GrdProdutos.DataSource = produtoTipoRepository.SelecionarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a grade de produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparControles()
        {
            TxtNome.Text = "";
            oProdutoSelecionado = null;
        }

        private void GrdProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                if (e.RowIndex >= 0)
                {
                    TipoProduto produtoSelecionado = GrdProdutos.Rows[e.RowIndex].DataBoundItem as TipoProduto;

                    if (produtoSelecionado != null)
                    {
                        if (GrdProdutos.Columns[e.ColumnIndex].Name == "BtnEditar")
                        {
                            TxtNome.Text = produtoSelecionado.Nome;
                            oProdutoSelecionado = produtoSelecionado;
                            _Incluir = false;
                        }
                        else if (GrdProdutos.Columns[e.ColumnIndex].Name == "BtnExcluir")
                        {
                            if (MessageBox.Show("Deseja realmente excluir este tipo de produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                            try
                            {
                                var tipoproduto = produtoRepository.SelecionarTodos();
                                var possuiProdutoComTipo = tipoproduto.Any(p => p.TipoProdutoIdTipoProduto == produtoSelecionado.IdTipoProduto);
                                if (!possuiProdutoComTipo)
                                {

                                    produtoSelecionado.IdTipoProduto = produtoSelecionado.IdTipoProduto;
                                    produtoTipoRepository.Excluir(produtoSelecionado);
                                    CarregarGrid();
                                }
                                else
                                {
                                    MessageBox.Show("Não é possivel excluir pois ele está associado a um produto cadastrado");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Erro ao processar a ação na grade de produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        }
                    }
                }
            }
        }

    }



