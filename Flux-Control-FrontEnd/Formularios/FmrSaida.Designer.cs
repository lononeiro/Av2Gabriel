namespace Flux_Control_prototipo.Formularios
{
    partial class FmrSaida
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
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            TxtProduto = new TextBox();
            TxtPrecoTotal = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            TxtQuantidade = new TextBox();
            BtnAdicionar = new Button();
            BtnEncerrar = new Button();
            label7 = new Label();
            BtnCancelar = new Button();
            GrdEstoque = new DataGridView();
            idEstoque = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdEstoque).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(185, 3, 15);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(1, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1190, 44);
            panel2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 2);
            label3.Name = "label3";
            label3.Size = new Size(230, 37);
            label3.TabIndex = 2;
            label3.Text = "REGISTRAR SAIDA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 36);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 13;
            label1.Text = "Produto:";
            // 
            // TxtProduto
            // 
            TxtProduto.Cursor = Cursors.No;
            TxtProduto.Enabled = false;
            TxtProduto.Location = new Point(61, 54);
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(157, 23);
            TxtProduto.TabIndex = 14;
            // 
            // TxtPrecoTotal
            // 
            TxtPrecoTotal.Cursor = Cursors.IBeam;
            TxtPrecoTotal.Enabled = false;
            TxtPrecoTotal.Location = new Point(90, 495);
            TxtPrecoTotal.Name = "TxtPrecoTotal";
            TxtPrecoTotal.Size = new Size(272, 23);
            TxtPrecoTotal.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 390);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 17;
            label4.Text = "PREÇO TOTAL (R$)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 163, 168);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtQuantidade);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxtProduto);
            panel1.Location = new Point(82, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 438);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 244);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 23;
            label2.Text = "Quantidade";
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Cursor = Cursors.IBeam;
            TxtQuantidade.Location = new Point(3, 262);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(108, 23);
            TxtQuantidade.TabIndex = 24;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.BackColor = Color.LightGreen;
            BtnAdicionar.Cursor = Cursors.Hand;
            BtnAdicionar.FlatStyle = FlatStyle.Flat;
            BtnAdicionar.Location = new Point(78, 580);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(141, 66);
            BtnAdicionar.TabIndex = 24;
            BtnAdicionar.Text = "Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = false;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // BtnEncerrar
            // 
            BtnEncerrar.BackColor = Color.Tomato;
            BtnEncerrar.Cursor = Cursors.Hand;
            BtnEncerrar.FlatStyle = FlatStyle.Flat;
            BtnEncerrar.Location = new Point(225, 578);
            BtnEncerrar.Name = "BtnEncerrar";
            BtnEncerrar.Size = new Size(141, 66);
            BtnEncerrar.TabIndex = 25;
            BtnEncerrar.Text = "Encerrar";
            BtnEncerrar.UseVisualStyleBackColor = false;
            BtnEncerrar.Click += BtnEncerrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(445, 64);
            label7.Name = "label7";
            label7.Size = new Size(274, 37);
            label7.TabIndex = 27;
            label7.Text = "PRODUTOS ESTOQUE";
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = SystemColors.AppWorkspace;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Location = new Point(151, 660);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(141, 25);
            BtnCancelar.TabIndex = 29;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // GrdEstoque
            // 
            GrdEstoque.AllowUserToAddRows = false;
            GrdEstoque.AllowUserToDeleteRows = false;
            GrdEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdEstoque.BackgroundColor = Color.White;
            GrdEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdEstoque.Columns.AddRange(new DataGridViewColumn[] { idEstoque });
            GrdEstoque.GridColor = Color.Black;
            GrdEstoque.Location = new Point(436, 104);
            GrdEstoque.Name = "GrdEstoque";
            GrdEstoque.Size = new Size(744, 551);
            GrdEstoque.TabIndex = 30;
            GrdEstoque.CellContentClick += GrdEstoque_CellClick;
            // 
            // idEstoque
            // 
            idEstoque.HeaderText = "idEstoque";
            idEstoque.Name = "idEstoque";
            // 
            // FmrSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1192, 728);
            Controls.Add(GrdEstoque);
            Controls.Add(BtnCancelar);
            Controls.Add(label7);
            Controls.Add(BtnEncerrar);
            Controls.Add(BtnAdicionar);
            Controls.Add(TxtPrecoTotal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FmrSaida";
            Text = "Gerenciar Saida";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GrdEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label3;
        private Label label1;
        private TextBox TxtProduto;
        private TextBox TxtPrecoTotal;
        private Label label4;
        private Panel panel1;
        private Label label2;
        private TextBox TxtQuantidade;
        private Button BtnAdicionar;
        private Button BtnEncerrar;
        private Label label7;
        private Button BtnCancelar;
        private DataGridView GrdEstoque;
        private DataGridViewTextBoxColumn idEstoque;
    }
}