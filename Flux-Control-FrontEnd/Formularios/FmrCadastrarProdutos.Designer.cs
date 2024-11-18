namespace Flux_Control_prototipo.Formularios
{
    partial class FmrCadastrarProdutos
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
            GrdProdutos = new DataGridView();
            label1 = new Label();
            TxtNome = new TextBox();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            button1 = new Button();
            cmbTipoProduto = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)GrdProdutos).BeginInit();
            SuspendLayout();
            // 
            // GrdProdutos
            // 
            GrdProdutos.AllowUserToAddRows = false;
            GrdProdutos.AllowUserToDeleteRows = false;
            GrdProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdProdutos.BackgroundColor = Color.FromArgb(192, 255, 255);
            GrdProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdProdutos.GridColor = Color.Black;
            GrdProdutos.Location = new Point(34, 92);
            GrdProdutos.Name = "GrdProdutos";
            GrdProdutos.Size = new Size(744, 320);
            GrdProdutos.TabIndex = 1;
            GrdProdutos.CellContentClick += GrdProdutos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 45);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(47, 63);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(157, 23);
            TxtNome.TabIndex = 3;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(368, 57);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 33);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(471, 57);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(97, 33);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(684, 53);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar Tipo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbTipoProduto
            // 
            cmbTipoProduto.FormattingEnabled = true;
            cmbTipoProduto.Location = new Point(223, 63);
            cmbTipoProduto.Name = "cmbTipoProduto";
            cmbTipoProduto.Size = new Size(121, 23);
            cmbTipoProduto.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(684, 12);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 8;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RecarregaClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 45);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 9;
            label2.Text = "Tipo Produto";
            // 
            // FmrCadastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(cmbTipoProduto);
            Controls.Add(button1);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtNome);
            Controls.Add(label1);
            Controls.Add(GrdProdutos);
            Name = "FmrCadastrarProdutos";
            Text = "Cadastrar produto";
            Load += FmrCadastrarProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)GrdProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdProdutos;
        private Label label1;
        private TextBox TxtNome;
        private Button BtnSalvar;
        private Button BtnFechar;
        private Button button1;
        private ComboBox cmbTipoProduto;
        private Button button2;
        private Label label2;
    }
}