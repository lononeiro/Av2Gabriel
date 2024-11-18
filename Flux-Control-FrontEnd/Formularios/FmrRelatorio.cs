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
            // Obtenha as entradas e saídas no intervalo de datas
            var entradas = entradaRepository.SelecionarPorIntervaloDeTempo(dataInicio, dataFim);
            var saidas = saidaRepository.SelecionarPorIntervaloDeTempo(dataInicio, dataFim);

            // Mapeie para um formato exibível nos grids
            var entradasDisplay = entradas.Select(e => new
            {
                NomeProduto = produtoRepository.SelecionarNomePelaChave(e.ProdutoIdProduto), // Assumindo que existe uma relação com Produto
                Lote = e.Lote,
                Data = e.DataEntrada,
                Quantidade = e.QuantidadeEntrada,
                PrecoTotal = e.PrecoCompra * e.QuantidadeEntrada,
            }).ToList();

            var saidasDisplay = saidas.Select(s => new
            {
                NomeProduto = produtoRepository.SelecionarNomePelaChave(s.ProdutoIdProduto), // Assumindo que existe uma relação com Produto
                LoteSaida = s.LoteSaida,
                Data = s.DataSaida,
                Quantidade = s.QuantidadeSaida,
                PrecoUnitario = s.PrecoSaida / s.QuantidadeSaida,
                PrecoTotal = s.PrecoSaida,
            }).ToList();

            // Carregar os dados nos grids
            grdEntradas.DataSource = entradasDisplay;
            grdSaidas.DataSource = saidasDisplay;

            // Configurar os nomes das colunas para os grids de entrada
            grdEntradas.Columns["NomeProduto"].HeaderText = "Nome Produto";
            grdEntradas.Columns["Lote"].HeaderText = "Lote";
            grdEntradas.Columns["Data"].HeaderText = "Data";
            grdEntradas.Columns["Quantidade"].HeaderText = "Quantidade";
            grdEntradas.Columns["PrecoTotal"].HeaderText = "Preço Total";

            // Configurar os nomes das colunas para os grids de saída
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
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
