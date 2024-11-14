using FluxControl.Data.Model;
using FluxControl.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrEstoque : Form
    {
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }

        ProdutoRepository produtoRepository = new ProdutoRepository(new DbFluxControlContext());
        EstoqueRepository estoqueRepository = new EstoqueRepository(new DbFluxControlContext());
        EntradaRepository entradaRepository = new EntradaRepository(new DbFluxControlContext());
        SaidaRepository saidaRepository = new SaidaRepository(new DbFluxControlContext());

        private Estoque estoqueSelecionado;
        bool _incluir = true;

        public FmrEstoque()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnGerirUsuariosClick(object sender, EventArgs e)
        {
            FmrCadastrarUsuario oFmr = new FmrCadastrarUsuario();
            oFmr.Show();
        }


        private void CarregaGrid()
        {
            GrdEstoque.AutoGenerateColumns = false;
            GrdEstoque.Columns.Clear();

            // Nome do Produto

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

            // Descrição Produto
            DataGridViewTextBoxColumn colDescricaoProduto = new DataGridViewTextBoxColumn
            {
                HeaderText = "Descrição Produto",
                DataPropertyName = "Descricao"
            };
            GrdEstoque.Columns.Add(colDescricaoProduto);

            // Quantidade
            DataGridViewTextBoxColumn colQuantidade = new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantidade",
                DataPropertyName = "QuantidadeEstoque"
            };
            GrdEstoque.Columns.Add(colQuantidade);

            // Lote
            DataGridViewTextBoxColumn colLote = new DataGridViewTextBoxColumn
            {
                HeaderText = "Lote",
                DataPropertyName = "LoteEstoque"
            };
            GrdEstoque.Columns.Add(colLote);

            // Preço Venda
            DataGridViewTextBoxColumn colPrecoVenda = new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço Venda",
                DataPropertyName = "PrecoVendaEstoque"
            };
            GrdEstoque.Columns.Add(colPrecoVenda);

            // Data de Validade
            DataGridViewTextBoxColumn colDataValidade = new DataGridViewTextBoxColumn
            {
                HeaderText = "Data de Validade",
                DataPropertyName = "DataValidadeEstoque",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } // Formato de data
            };
            GrdEstoque.Columns.Add(colDataValidade);

            // Botão Editar
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Name = "BtnEditar",
                Text = "",
                UseColumnTextForButtonValue = true
            };
            GrdEstoque.Columns.Add(colEditar);

            // Botão Excluir
            DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn
            {
                HeaderText = "Excluir",
                Name = "BtnExcluir",
                Text = "",
                UseColumnTextForButtonValue = true
            };
            GrdEstoque.Columns.Add(colExcluir);

            // Atualizar a fonte de dados
            GrdEstoque.DataSource = estoqueRepository.SelecionarTodos();
        }


        private void BtnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            FmrEntrada oFmr = new FmrEntrada();
            oFmr.Show();
            BtnRegistrarEntrada.Enabled = false;
            oFmr.FormClosed += (s, args) => BtnRegistrarEntrada.Enabled = true;
            this.FormClosed += (s, args) => oFmr.Close();
        }

        private void FmrGerenciarProdutos_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void GrdClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var item = GrdEstoque.Rows[e.RowIndex].DataBoundItem;
                    if (item == null)
                    {
                        MessageBox.Show("O item selecionado é nulo.");
                        return;
                    }

                    // Use um tipo anônimo, então não pode ser convertido diretamente para Estoque
                    dynamic estoqueSelecionado = item;

                    if (estoqueSelecionado != null)
                    {
                        if (GrdEstoque.Columns[e.ColumnIndex].Name == "BtnEditar")
                        {
                            // Carregar os dados do produto selecionado para os campos de edição
                            TxtDescricao.Text = estoqueSelecionado.DescricaoProdutoEstoque;
                            TxtQuantidade.Text = estoqueSelecionado.QuantidadeEstoque.ToString();
                            TxtPrecoCompra.Text = estoqueSelecionado.PrecoVendaProdutoEstoque.ToString();

                            // Obtenha o estoque selecionado através da chave (IdEstoque)
                            var produto = estoqueRepository.SelecionarPelaChave(estoqueSelecionado.IdEstoque);
                            if (produto != null)
                            {
                                this.estoqueSelecionado = produto;
                                _incluir = false; // Defina a flag de inclusão para false
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado.");
                            }
                        }
                        if (GrdEstoque.Columns[e.ColumnIndex].Name == "BtnExcluir")
                        {
                            // Confirmar a exclusão
                            if (MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var row = GrdEstoque.Rows[e.RowIndex];
                                var idEstoque = row.Cells[0].Value;
                                int id = Convert.ToInt32(idEstoque);
                               
                                //Estoque estoqueprontopraexcluir = estoqueRepository.SelecionarPelaChave(estoque.idEstoque);
                                Estoque estoque = estoqueRepository.SelecionarPelaChave(id);
                                if (estoque != null)
                                {
                                    var entrada = entradaRepository.SelecionarPeloLote(estoque.ProdutoIdProduto, estoque.LoteEstoque);
                                    var saida = saidaRepository.SelecionarPeloLote(estoque.ProdutoIdProduto, estoque.LoteEstoque);

                                    if (saida != null)
                                    {
                                        saidaRepository.Excluir(saida);
                                    }
                                    estoqueRepository.Excluir(estoque);
                                    entradaRepository.Excluir(entrada);

                                    MessageBox.Show("Produto excluído com sucesso.");
                                    CarregaGrid();
                                }
                                else
                                {
                                    MessageBox.Show("Produto não encontrado para exclusão.");
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            // Validar o ID do produto carregado
            if (estoqueSelecionado == null)
            {
                MessageBox.Show("Nenhum produto selecionado para alterar.");
                return;
            }

            //// Atualizar o objeto estoqueSelecionado com os valores dos campos
            //estoqueSelecionado.DescricaoProdutoEstoque = TxtDescricao.Text;
            //estoqueSelecionado.QuantidadeEstoque = int.Parse(TxtQuantidade.Text);
            //estoqueSelecionado.PrecoVendaProdutoEstoque = decimal.Parse(TxtPrecoCompra.Text);

            // Chama o método de alteração para salvar as mudanças
            estoqueRepository.alterar(estoqueSelecionado); // Use estoqueRepository ao invés de produtoRepository

            MessageBox.Show("Produto alterado com sucesso!");

            // Atualizar o DataGridView
            CarregaGrid();
        }
        //dsadsadasdas
        private void button3_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void BtnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            FmrCadastrarProdutos Ofmr = new FmrCadastrarProdutos();
            Ofmr.Show();
        }

        private void BtnRegistrarSaida_Click(object sender, EventArgs e)
        {
            FmrSaida oFmr = new FmrSaida();
            oFmr.Show();
        }
    }
}