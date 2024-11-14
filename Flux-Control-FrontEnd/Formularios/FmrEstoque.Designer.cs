namespace Flux_Control_prototipo.Formularios
{
    partial class FmrEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GrdEstoque = new DataGridView();
            idEstoque = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnEmitirRelatorio = new Button();
            BtnRegistrarEntrada = new Button();
            BtnRegistrarSaida = new Button();
            label5 = new Label();
            label4 = new Label();
            TxtPrecoCompra = new TextBox();
            label2 = new Label();
            TxtQuantidade = new TextBox();
            label1 = new Label();
            TxtDescricao = new TextBox();
            TxtNome = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            BtnApagar = new Button();
            BtnAlterar = new Button();
            BtnCadastrarProduto = new Button();
            button1 = new Button();
            Produto = new DataGridViewTextBoxColumn();
            Selecionar = new DataGridViewButtonColumn();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdEstoque).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GrdEstoque
            // 
            GrdEstoque.AllowUserToAddRows = false;
            GrdEstoque.AllowUserToDeleteRows = false;
            GrdEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdEstoque.BackgroundColor = Color.FromArgb(240, 240, 216);
            GrdEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdEstoque.Columns.AddRange(new DataGridViewColumn[] { idEstoque });
            GrdEstoque.GridColor = Color.Black;
            GrdEstoque.Location = new Point(351, 12);
            GrdEstoque.Name = "GrdEstoque";
            GrdEstoque.Size = new Size(744, 551);
            GrdEstoque.TabIndex = 0;
            GrdEstoque.CellContentClick += GrdClick;
            // 
            // idEstoque
            // 
            idEstoque.HeaderText = "idEstoque";
            idEstoque.Name = "idEstoque";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // BtnEmitirRelatorio
            // 
            BtnEmitirRelatorio.BackColor = Color.Silver;
            BtnEmitirRelatorio.Cursor = Cursors.Hand;
            BtnEmitirRelatorio.FlatStyle = FlatStyle.Flat;
            BtnEmitirRelatorio.Location = new Point(179, 568);
            BtnEmitirRelatorio.Name = "BtnEmitirRelatorio";
            BtnEmitirRelatorio.Size = new Size(161, 40);
            BtnEmitirRelatorio.TabIndex = 2;
            BtnEmitirRelatorio.Text = "Emitir relatórios";
            BtnEmitirRelatorio.UseVisualStyleBackColor = false;
            // 
            // BtnRegistrarEntrada
            // 
            BtnRegistrarEntrada.BackColor = Color.Silver;
            BtnRegistrarEntrada.Cursor = Cursors.Hand;
            BtnRegistrarEntrada.FlatStyle = FlatStyle.Flat;
            BtnRegistrarEntrada.Location = new Point(7, 523);
            BtnRegistrarEntrada.Name = "BtnRegistrarEntrada";
            BtnRegistrarEntrada.Size = new Size(166, 40);
            BtnRegistrarEntrada.TabIndex = 3;
            BtnRegistrarEntrada.Text = "Registrar Entrada";
            BtnRegistrarEntrada.UseVisualStyleBackColor = false;
            BtnRegistrarEntrada.Click += BtnRegistrarEntrada_Click;
            // 
            // BtnRegistrarSaida
            // 
            BtnRegistrarSaida.BackColor = Color.Silver;
            BtnRegistrarSaida.Cursor = Cursors.Hand;
            BtnRegistrarSaida.FlatStyle = FlatStyle.Flat;
            BtnRegistrarSaida.Location = new Point(179, 523);
            BtnRegistrarSaida.Name = "BtnRegistrarSaida";
            BtnRegistrarSaida.Size = new Size(161, 40);
            BtnRegistrarSaida.TabIndex = 4;
            BtnRegistrarSaida.Text = "Registrar Saida";
            BtnRegistrarSaida.UseVisualStyleBackColor = false;
            BtnRegistrarSaida.Click += BtnRegistrarSaida_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 163);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 20;
            label5.Text = "Preço compra (R$)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 120);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 21;
            label4.Text = "Quantidade";
            // 
            // TxtPrecoCompra
            // 
            TxtPrecoCompra.Location = new Point(75, 210);
            TxtPrecoCompra.Name = "TxtPrecoCompra";
            TxtPrecoCompra.Size = new Size(122, 23);
            TxtPrecoCompra.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 76);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 22;
            label2.Text = "Descrição";
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Location = new Point(75, 170);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(122, 23);
            TxtQuantidade.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 17;
            label1.Text = "Nome";
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(75, 127);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(197, 23);
            TxtDescricao.TabIndex = 26;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(75, 83);
            TxtNome.Name = "TxtNome";
            TxtNome.ReadOnly = true;
            TxtNome.Size = new Size(122, 23);
            TxtNome.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(BtnApagar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(BtnAlterar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 415);
            panel1.TabIndex = 29;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(73, 311);
            button2.Name = "button2";
            button2.Size = new Size(101, 40);
            button2.TabIndex = 32;
            button2.Text = "Registrar Entrada";
            button2.UseVisualStyleBackColor = false;
            // 
            // BtnApagar
            // 
            BtnApagar.BackColor = Color.FromArgb(255, 128, 128);
            BtnApagar.Cursor = Cursors.Hand;
            BtnApagar.FlatStyle = FlatStyle.Flat;
            BtnApagar.Location = new Point(126, 259);
            BtnApagar.Name = "BtnApagar";
            BtnApagar.Size = new Size(101, 40);
            BtnApagar.TabIndex = 31;
            BtnApagar.Text = "Apagar";
            BtnApagar.UseVisualStyleBackColor = false;
            // 
            // BtnAlterar
            // 
            BtnAlterar.BackColor = Color.FromArgb(192, 255, 192);
            BtnAlterar.Cursor = Cursors.Hand;
            BtnAlterar.FlatStyle = FlatStyle.Flat;
            BtnAlterar.Location = new Point(18, 259);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(102, 40);
            BtnAlterar.TabIndex = 30;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = false;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnCadastrarProduto
            // 
            BtnCadastrarProduto.BackColor = Color.Silver;
            BtnCadastrarProduto.Cursor = Cursors.Hand;
            BtnCadastrarProduto.FlatStyle = FlatStyle.Flat;
            BtnCadastrarProduto.Location = new Point(7, 569);
            BtnCadastrarProduto.Name = "BtnCadastrarProduto";
            BtnCadastrarProduto.Size = new Size(166, 40);
            BtnCadastrarProduto.TabIndex = 30;
            BtnCadastrarProduto.Text = "Cadastrar produtos";
            BtnCadastrarProduto.UseVisualStyleBackColor = false;
            BtnCadastrarProduto.Click += BtnCadastrarProdutos_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(89, 466);
            button1.Name = "button1";
            button1.Size = new Size(161, 40);
            button1.TabIndex = 31;
            button1.Text = "Gerir Usuarios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnGerirUsuariosClick;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Selecionar
            // 
            Selecionar.HeaderText = "Selecionar";
            Selecionar.Name = "Selecionar";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.Location = new Point(967, 568);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 32;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FmrEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1107, 620);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(BtnCadastrarProduto);
            Controls.Add(TxtPrecoCompra);
            Controls.Add(TxtQuantidade);
            Controls.Add(TxtDescricao);
            Controls.Add(TxtNome);
            Controls.Add(BtnRegistrarEntrada);
            Controls.Add(BtnRegistrarSaida);
            Controls.Add(BtnEmitirRelatorio);
            Controls.Add(GrdEstoque);
            Controls.Add(panel1);
            Name = "FmrEstoque";
            Text = "Menu Produtos";
            Load += FmrGerenciarProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)GrdEstoque).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdEstoque;
        private Button BtnEmitirRelatorio;
        private Button BtnRegistrarEntrada;
        private Button BtnRegistrarSaida;
        private Label label5;
        private Label label4;
        private TextBox TxtPrecoCompra;
        private Label label2;
        private TextBox TxtQuantidade;
        private Label label1;
        private TextBox TxtDescricao;
        private TextBox TxtNome;
        private Panel panel1;
        private Button BtnApagar;
        private Button BtnAlterar;
        private DataGridViewTextBoxColumn Nome;
     //   private DataGridViewTextBoxColumn Descricao;
     //   private DataGridViewTextBoxColumn Quantidade;
     //   private DataGridViewTextBoxColumn PrecoCompra;
      //  private DataGridViewTextBoxColumn PrecoVenda;
    //    private DataGridViewButtonColumn Selecionar;
        private Button BtnCadastrarProduto;
        private Button button1;
        private DataGridViewTextBoxColumn Produto;
        //private DataGridViewTextBoxColumn Descricao;
        //private DataGridViewTextBoxColumn Quantidade;
        //private DataGridViewTextBoxColumn PrecoVenda;
        private DataGridViewButtonColumn Selecionar;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn idEstoque;
    }
}