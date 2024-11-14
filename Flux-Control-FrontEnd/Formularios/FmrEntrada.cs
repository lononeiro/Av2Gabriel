﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluxControl.Data.Model;
using FluxControl.Data.Repositories;

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrEntrada : Form
    {
        public FmrEntrada()
        {
            InitializeComponent();
            CarregaComboBox();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(500, 500);
        }

        private void CarregaComboBox()
        {
            ComboBoxProdutos.Items.Clear();

            ProdutoRepository produtoRepository = new ProdutoRepository(new DbFluxControlContext());

            var produtos = produtoRepository.SelecionarTodos();
            ComboBoxProdutos.DataSource = produtos;
            ComboBoxProdutos.DisplayMember = "Nome";
            ComboBoxProdutos.ValueMember = "idProduto";
        }

        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmrEntrada_Load(object sender, EventArgs e)
        {
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (ComboBoxProdutos.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TxtDescricao.Text) ||
                string.IsNullOrWhiteSpace(TxtQuantidade.Text) || string.IsNullOrWhiteSpace(TxtPrecoCompra.Text) ||
                string.IsNullOrWhiteSpace(TxtPrecoVenda.Text) || string.IsNullOrWhiteSpace(TxtLote.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de dados numéricos
            if (!int.TryParse(TxtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("A quantidade deve ser um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(TxtPrecoCompra.Text, out decimal precoCompra) || !decimal.TryParse(TxtPrecoVenda.Text, out decimal precoVenda))
            {
                MessageBox.Show("Preços devem ser valores numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

            int produtoId = (int)ComboBoxProdutos.SelectedValue;
            Entrada entrada = new Entrada
            {
                ProdutoIdProduto = produtoId,
                QuantidadeEntrada = int.Parse(TxtQuantidade.Text),
                PrecoCompra = (double)precoCompra,
                PrecoVenda = (double)precoVenda,
                DataEntrada = DateTime.Now,
                Lote = int.Parse(TxtLote.Text)
            };

                EntradaRepository entradaRepository = new EntradaRepository(new DbFluxControlContext());
                EstoqueRepository estoqueRepository = new EstoqueRepository(new DbFluxControlContext());


                if (!int.TryParse(TxtLote.Text, out int lote))
                {
                    MessageBox.Show("O lote deve ser um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Estoque oEstoque = new Estoque
                {
                    ProdutoIdProduto = produtoId,
                    Descricao = TxtDescricao.Text,
                    PrecoVendaEstoque = (double)precoVenda,
                    QuantidadeEstoque = int.Parse(TxtQuantidade.Text),
                    LoteEstoque = int.Parse(TxtLote.Text),
                    DataValidadeEstoque = DtpDataValidade.Value

                };


                estoqueRepository.Incluir(oEstoque);
                entradaRepository.Incluir(entrada);

                LimparCampos();
                MessageBox.Show("Cadastro de entrada concluído", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar entrada: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            ComboBoxProdutos.SelectedIndex = -1;
            TxtDescricao.Clear();
            TxtQuantidade.Clear();
            TxtPrecoCompra.Clear();
            TxtPrecoVenda.Clear();
            TxtLote.Clear();  // Limpa o campo "Lote"
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}