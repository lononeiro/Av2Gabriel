using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FluxControl.Data.Repositories;
using ProdutoRepo = FluxControl.Data.Model.Produto;
using FluxControl.Data.Model;

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrCadastrarProdutos : Form
    {
        private bool _Incluir = true;
        private ProdutoRepo oProdutoSelecionado = null;
        private ProdutoRepository produtoRepository = new ProdutoRepository(new DbFluxControlContext());

        public FmrCadastrarProdutos()
        {
            InitializeComponent();
            CarregarGrid();
            CarregaComboBox();
        }
        private TipoProdutoRepository tipoProdutoRepository = new TipoProdutoRepository(new DbFluxControlContext());

        private void CarregaComboBox()
        {
            var tiposProduto = tipoProdutoRepository.SelecionarTodos();
            cmbTipoProduto.DataSource = tiposProduto;
            cmbTipoProduto.DisplayMember = "Nome";    // Propriedade Nome de TipoProduto
            cmbTipoProduto.ValueMember = "IdTipoProduto"; // Propriedade ID de TipoProduto
        }


        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ProdutoExiste(string nomeProduto)
        {
            var produtos = produtoRepository.SelecionarTodos(); // agora List<dynamic>
            return produtos.Any(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                MessageBox.Show("Por favor, insira o nome do produto.");
                return;
            }


            if (_Incluir)
            {
                try
                {
                    if (ProdutoExiste(TxtNome.Text))
                    {
                        MessageBox.Show("Já existe um produto com esse nome. Por favor, escolha outro nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ProdutoRepo novoProduto = new ProdutoRepo
                    {

                        Nome = TxtNome.Text,
                        TipoProdutoIdTipoProduto = Convert.ToInt32(cmbTipoProduto.SelectedValue)
                    };
                    produtoRepository.Incluir(novoProduto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar o produto: {ex.Message}");
                }

            }
            else
            {
                oProdutoSelecionado.Nome = TxtNome.Text;
                oProdutoSelecionado.TipoProdutoIdTipoProduto = Convert.ToInt32(cmbTipoProduto.SelectedValue);
                produtoRepository.Alterar(oProdutoSelecionado);
                _Incluir = true;
            }

            LimparControles();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            // Carregar a lista de produtos com tipos usando os métodos de seleção


            // Configurar a grid para não gerar colunas automaticamente
            GrdProdutos.AutoGenerateColumns = false;
            GrdProdutos.Columns.Clear();
            GrdProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adicionar coluna para o nome do produto
            DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn();
            colNome.HeaderText = "Nome do Produto";
            colNome.DataPropertyName = "Nome";
            GrdProdutos.Columns.Add(colNome);

            // Adicionar coluna para o nome do tipo de produto
            DataGridViewTextBoxColumn colTipoNome = new DataGridViewTextBoxColumn();
            colTipoNome.HeaderText = "Tipo de Produto";
            colTipoNome.DataPropertyName = "TipoProdutoNome"; // Nome da propriedade que foi criada na consulta LINQ
            GrdProdutos.Columns.Add(colTipoNome);

            // Adicionar coluna para o botão de editar
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.HeaderText = "Editar";
            colEditar.Name = "BtnEditar";
            GrdProdutos.Columns.Add(colEditar);

            // Adicionar coluna para o botão de excluir
            DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn();
            colExcluir.HeaderText = "Excluir";
            colExcluir.Name = "BtnExcluir";
            GrdProdutos.Columns.Add(colExcluir);

            // Atribuir os dados à grade

            var produtosComTipos = from p in produtoRepository.SelecionarTodos()
                                   join t in tipoProdutoRepository.SelecionarTodos()
                                   on p.TipoProdutoIdTipoProduto equals t.IdTipoProduto // Verifique se os nomes das propriedades estão corretos
                                   select new
                                   {
                                       p.Nome,
                                       TipoProdutoNome = t.Nome, // Nome do Tipo de Produto
                                   };

            var listaProdutos = produtosComTipos.ToList();
            GrdProdutos.DataSource = listaProdutos;
        }


        private void LimparControles()
        {
            TxtNome.Text = "";
            oProdutoSelecionado = null;
        }

        private void GrdProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var item = GrdProdutos.Rows[e.RowIndex].DataBoundItem;
                    if (item == null)
                    {
                        MessageBox.Show("O item selecionado é nulo.");
                        return;
                    }

                    // Use um tipo anônimo, então não pode ser convertido diretamente para ProdutoRepo
                    dynamic produtoSelecionado = item;

                    if (produtoSelecionado != null)
                    {
                        if (GrdProdutos.Columns[e.ColumnIndex].Name == "BtnEditar")
                        {
                            TxtNome.Text = produtoSelecionado.Nome;
                            
                            // Aqui você obtém o produto selecionado pelo nome
                            oProdutoSelecionado = produtoRepository.SelecionarTodos().FirstOrDefault(p => p.Nome == produtoSelecionado.Nome);
                            _Incluir = false;
                        }
                        else if (GrdProdutos.Columns[e.ColumnIndex].Name == "BtnExcluir")
                        {
                            // Confirmar a exclusão
                            if (MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // Recupera o ID do tipo do produto pelo nome do tipo de produto
                                var tipoProduto = tipoProdutoRepository.SelecionarTodos()
                                                  .FirstOrDefault(t => t.Nome == produtoSelecionado.TipoProdutoNome);

                                if (tipoProduto != null)
                                {
                                    // Procura o produto específico com o ID do tipo de produto
                                    var produtoParaExcluir = produtoRepository.SelecionarTodos().FirstOrDefault(p => p.Nome == produtoSelecionado.Nome && p.TipoProdutoIdTipoProduto == tipoProduto.IdTipoProduto);

                                    if (produtoParaExcluir != null)
                                    {
                                        produtoRepository.Excluir(produtoParaExcluir);
                                        CarregarGrid();
                                        MessageBox.Show("Produto excluído com sucesso.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Produto não encontrado para exclusão.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Tipo de produto não encontrado.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar processar o item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 


        private void FmrCadastrarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrCadastrarTipoProduto oFmr = new FmrCadastrarTipoProduto();
            oFmr.Show();
        }

        private void RecarregaClick(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregaComboBox();
        }
    }
}

