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
            panel1 = new Panel();
            BtnGerirUsuario = new Button();
            BtnCadastrarProduto = new Button();
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
            GrdEstoque.BackgroundColor = Color.WhiteSmoke;
            GrdEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdEstoque.Columns.AddRange(new DataGridViewColumn[] { idEstoque });
            GrdEstoque.GridColor = Color.Black;
            GrdEstoque.Location = new Point(267, 43);
            GrdEstoque.Name = "GrdEstoque";
            GrdEstoque.Size = new Size(828, 551);
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
            BtnEmitirRelatorio.BackColor = Color.White;
            BtnEmitirRelatorio.Cursor = Cursors.Hand;
            BtnEmitirRelatorio.FlatStyle = FlatStyle.Flat;
            BtnEmitirRelatorio.Location = new Point(62, 353);
            BtnEmitirRelatorio.Name = "BtnEmitirRelatorio";
            BtnEmitirRelatorio.Size = new Size(142, 40);
            BtnEmitirRelatorio.TabIndex = 2;
            BtnEmitirRelatorio.Text = "Emitir relatórios";
            BtnEmitirRelatorio.UseVisualStyleBackColor = false;
            BtnEmitirRelatorio.Click += BtnRelatorio_CLick;
            // 
            // BtnRegistrarEntrada
            // 
            BtnRegistrarEntrada.BackColor = Color.White;
            BtnRegistrarEntrada.Cursor = Cursors.Hand;
            BtnRegistrarEntrada.FlatStyle = FlatStyle.Flat;
            BtnRegistrarEntrada.Location = new Point(62, 189);
            BtnRegistrarEntrada.Name = "BtnRegistrarEntrada";
            BtnRegistrarEntrada.Size = new Size(142, 40);
            BtnRegistrarEntrada.TabIndex = 3;
            BtnRegistrarEntrada.Text = "Registrar Entrada";
            BtnRegistrarEntrada.UseVisualStyleBackColor = false;
            BtnRegistrarEntrada.Click += BtnRegistrarEntrada_Click;
            // 
            // BtnRegistrarSaida
            // 
            BtnRegistrarSaida.BackColor = Color.White;
            BtnRegistrarSaida.Cursor = Cursors.Hand;
            BtnRegistrarSaida.FlatStyle = FlatStyle.Flat;
            BtnRegistrarSaida.Location = new Point(62, 268);
            BtnRegistrarSaida.Name = "BtnRegistrarSaida";
            BtnRegistrarSaida.Size = new Size(142, 40);
            BtnRegistrarSaida.TabIndex = 4;
            BtnRegistrarSaida.Text = "Registrar Saída";
            BtnRegistrarSaida.UseVisualStyleBackColor = false;
            BtnRegistrarSaida.Click += BtnRegistrarSaida_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(180, 37, 41);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnGerirUsuario);
            panel1.Controls.Add(BtnEmitirRelatorio);
            panel1.Controls.Add(BtnCadastrarProduto);
            panel1.Controls.Add(BtnRegistrarEntrada);
            panel1.Controls.Add(BtnRegistrarSaida);
            panel1.Location = new Point(-4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 641);
            panel1.TabIndex = 29;
            // 
            // BtnGerirUsuario
            // 
            BtnGerirUsuario.BackColor = Color.White;
            BtnGerirUsuario.Cursor = Cursors.Hand;
            BtnGerirUsuario.FlatStyle = FlatStyle.Flat;
            BtnGerirUsuario.Location = new Point(62, 436);
            BtnGerirUsuario.Name = "BtnGerirUsuario";
            BtnGerirUsuario.Size = new Size(142, 40);
            BtnGerirUsuario.TabIndex = 31;
            BtnGerirUsuario.Text = "Gerir Usuários";
            BtnGerirUsuario.UseVisualStyleBackColor = false;
            BtnGerirUsuario.Click += BtnGerirUsuariosClick;
            // 
            // BtnCadastrarProduto
            // 
            BtnCadastrarProduto.BackColor = Color.White;
            BtnCadastrarProduto.Cursor = Cursors.Hand;
            BtnCadastrarProduto.FlatStyle = FlatStyle.Flat;
            BtnCadastrarProduto.Location = new Point(62, 108);
            BtnCadastrarProduto.Name = "BtnCadastrarProduto";
            BtnCadastrarProduto.Size = new Size(142, 40);
            BtnCadastrarProduto.TabIndex = 30;
            BtnCadastrarProduto.Text = "Cadastrar produtos";
            BtnCadastrarProduto.UseVisualStyleBackColor = false;
            BtnCadastrarProduto.Click += BtnCadastrarProdutos_Click;
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
            button3.BackColor = Color.FromArgb(241, 229, 228);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(308, 14);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 32;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FmrEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 233, 238);
            ClientSize = new Size(1107, 620);
            Controls.Add(button3);
            Controls.Add(GrdEstoque);
            Controls.Add(panel1);
            Name = "FmrEstoque";
            Text = "Menu produtos";
            Load += FmrGerenciarProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)GrdEstoque).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GrdEstoque;
        private Button BtnEmitirRelatorio;
        private Button BtnRegistrarEntrada;
        private Button BtnRegistrarSaida;
        private Panel panel1;
        private DataGridViewTextBoxColumn Nome;
     //   private DataGridViewTextBoxColumn Descricao;
     //   private DataGridViewTextBoxColumn Quantidade;
     //   private DataGridViewTextBoxColumn PrecoCompra;
      //  private DataGridViewTextBoxColumn PrecoVenda;
    //    private DataGridViewButtonColumn Selecionar;
        private Button BtnCadastrarProduto;
        private Button BtnGerirUsuario;
        private DataGridViewTextBoxColumn Produto;
        //private DataGridViewTextBoxColumn Descricao;
        //private DataGridViewTextBoxColumn Quantidade;
        //private DataGridViewTextBoxColumn PrecoVenda;
        private DataGridViewButtonColumn Selecionar;
        private Button button3;
        private DataGridViewTextBoxColumn idEstoque;
    }
}