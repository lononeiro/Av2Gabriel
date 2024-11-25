using FluxControl.Data.Model;
using FluxControl.Data.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrRelatorio : Form
    {
        public FmrRelatorio()
        {
            InitializeComponent();

            // Configurações para tela cheia
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += FmrRelatorio_Load; // Ajusta os layouts ao carregar a tela
        }

        private ProdutoRepository produtoRepository = new ProdutoRepository(new DbFluxControlContext());
        private EntradaRepository entradaRepository = new EntradaRepository(new DbFluxControlContext());
        private SaidaRepository saidaRepository = new SaidaRepository(new DbFluxControlContext());

        private void FmrRelatorio_Load(object sender, EventArgs e)
        {
            // Configurar os grids
            ConfigurarGrids();

            // Adicionar os grids no formulário
            this.Controls.Add(grdEntradas);
            this.Controls.Add(grdSaidas);
        }

        private DataGridView grdEntradas = new DataGridView();
        private DataGridView grdSaidas = new DataGridView();


        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            DateTime dataInicio = dtpDataInicio.Value;
            DateTime dataFim = dtpDataFim.Value;

            if (dataInicio > dataFim)
            {
                MessageBox.Show("A data de início deve ser menor ou igual à data de fim.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarregarRelatorio(dataInicio, dataFim);
        }

        private void CarregarRelatorio(DateTime dataInicio, DateTime dataFim)
        {
            // Verifica se "Todos os Produtos" está selecionado
            bool incluirTodosProdutos = CheckBoxTodosProdutos.Checked;

            // Lista de IDs de produtos selecionados
            var produtosSelecionados = ChecklistProdutos.CheckedItems
                .Cast<dynamic>() // Use o tipo apropriado, como Produto, se necessário
                .Select(p => (int)p.IdProduto)
                .ToList();

            // Obtenha entradas e saídas com base na seleção de produtos
            var entradas = entradaRepository.SelecionarPorIntervaloDeTempo(dataInicio, dataFim)
                .Where(e => incluirTodosProdutos || produtosSelecionados.Contains(e.ProdutoIdProduto))
                .ToList();

            var saidas = saidaRepository.SelecionarPorIntervaloDeTempo(dataInicio, dataFim)
                .Where(s => incluirTodosProdutos || produtosSelecionados.Contains(s.ProdutoIdProduto))
                .ToList();

            // Cálculo do lucro
            double lucroTotal = saidas.Sum(s => s.PrecoSaida) - entradas.Sum(e => e.PrecoCompra * e.QuantidadeEntrada);

            // Preço bruto (soma total de vendas)
            double precoBruto = saidas.Sum(s => s.PrecoSaida);

            // Produto mais vendido
            var produtoMaisVendido = saidas
                .GroupBy(s => s.ProdutoIdProduto)
                .OrderByDescending(g => g.Sum(s => s.QuantidadeSaida))
                .Select(g => new
                {
                    IdProduto = g.Key,
                    NomeProduto = produtoRepository.SelecionarNomePelaChave(g.Key),
                    QuantidadeVendida = g.Sum(s => s.QuantidadeSaida)
                })
                .FirstOrDefault();

            
            MessageBox.Show($"Lucro Total: {lucroTotal:C}\n" +
                            $"Preço Bruto Total: {precoBruto:C}\n" +
                            $"Produto Mais Vendido: {produtoMaisVendido?.NomeProduto} ({produtoMaisVendido?.QuantidadeVendida} unidades)",
                            "Análise do Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);


            TxtProdutoVendido.Text = produtoMaisVendido.NomeProduto;
            TxtQuantidadeVendida.Text = Convert.ToString(produtoMaisVendido.QuantidadeVendida);
            TxtValorBruto.Text = Convert.ToString(precoBruto.ToString());
            TxtValorLiquido.Text = Convert.ToString(lucroTotal.ToString());

            // Carregar os dados nos grids
            var entradasDisplay = entradas.Select(e => new
            {
                NomeProduto = produtoRepository.SelecionarNomePelaChave(e.ProdutoIdProduto),
                Lote = e.Lote,
                Data = e.DataEntrada,
                Quantidade = e.QuantidadeEntrada,
                PrecoTotal = e.PrecoCompra * e.QuantidadeEntrada,
            }).ToList();

            var saidasDisplay = saidas.Select(s => new
            {
                NomeProduto = produtoRepository.SelecionarNomePelaChave(s.ProdutoIdProduto),
                LoteSaida = s.LoteSaida,
                Data = s.DataSaida,
                Quantidade = s.QuantidadeSaida,
                PrecoUnitario = s.PrecoSaida / s.QuantidadeSaida,
                PrecoTotal = s.PrecoSaida,
            }).ToList();

            grdEntradas.DataSource = entradasDisplay;
            grdSaidas.DataSource = saidasDisplay;

            // Configurar os nomes das colunas para os grids
            grdEntradas.Columns["NomeProduto"].HeaderText = "Nome Produto";
            grdEntradas.Columns["Lote"].HeaderText = "Lote";
            grdEntradas.Columns["Data"].HeaderText = "Data";
            grdEntradas.Columns["Quantidade"].HeaderText = "Quantidade";
            grdEntradas.Columns["PrecoTotal"].HeaderText = "Preço Total";

            grdSaidas.Columns["NomeProduto"].HeaderText = "Nome Produto";
            grdSaidas.Columns["LoteSaida"].HeaderText = "Lote";
            grdSaidas.Columns["Data"].HeaderText = "Data";
            grdSaidas.Columns["Quantidade"].HeaderText = "Quantidade";
            grdSaidas.Columns["PrecoUnitario"].HeaderText = "Preço Unitário";
            grdSaidas.Columns["PrecoTotal"].HeaderText = "Preço Total";
        }
        private void ConfigurarGrids()
        {
            // Espaçamento e dimensões
            int espacoBorda = 20;
            int espacoEntreGrids = 10;
            int espacoSuperior = 130; // Aumentar o espaço superior para 100px

            // Largura e altura dos grids
            int larguraGrid = (this.ClientSize.Width - (3 * espacoBorda) - espacoEntreGrids) / 2;
            int alturaGrid = this.ClientSize.Height - (espacoSuperior + espacoBorda);

            // Configuração do grid de entradas
            grdEntradas.Location = new System.Drawing.Point(espacoBorda, espacoSuperior);
            grdEntradas.Size = new System.Drawing.Size(larguraGrid, alturaGrid);
            grdEntradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdEntradas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEntradas.ReadOnly = true;
            grdEntradas.BackgroundColor = Color.LightBlue; // Fundo azul claro
            grdEntradas.BorderStyle = BorderStyle.Fixed3D;

            // Configuração do grid de saídas
            grdSaidas.Location = new System.Drawing.Point(
                espacoBorda + larguraGrid + espacoEntreGrids,
                espacoSuperior
            );
            grdSaidas.Size = new System.Drawing.Size(larguraGrid, alturaGrid);
            grdSaidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSaidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSaidas.ReadOnly = true;
            grdSaidas.BackgroundColor = Color.LightCoral; // Fundo vermelho claro
            grdSaidas.BorderStyle = BorderStyle.Fixed3D;



            var produtos = produtoRepository.SelecionarTodos();

            ChecklistProdutos.DataSource = produtos;

            ChecklistProdutos.DisplayMember = "Nome";
            ChecklistProdutos.ValueMember = "IdProduto";

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBoxTodosProdutos_CheckedChanged(object sender, EventArgs e)
        {
            ChecklistProdutos.Enabled = !CheckBoxTodosProdutos.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
