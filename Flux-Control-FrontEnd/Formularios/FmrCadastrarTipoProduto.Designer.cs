﻿namespace Flux_Control_prototipo.Formularios
{
    partial class FmrCadastrarTipoProduto
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
            BtnFechar = new Button();
            BtnSalvar = new Button();
            TxtNome = new TextBox();
            label1 = new Label();
            GrdProdutos = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            BtnEditar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdProdutos).BeginInit();
            SuspendLayout();
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(335, 50);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(97, 33);
            BtnFechar.TabIndex = 10;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(232, 50);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 33);
            BtnSalvar.TabIndex = 9;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(41, 60);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(157, 23);
            TxtNome.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // GrdProdutos
            // 
            GrdProdutos.AllowUserToAddRows = false;
            GrdProdutos.AllowUserToDeleteRows = false;
            GrdProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdProdutos.BackgroundColor = Color.FromArgb(192, 255, 255);
            GrdProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdProdutos.Columns.AddRange(new DataGridViewColumn[] { Nome, BtnEditar, BtnExcluir });
            GrdProdutos.GridColor = Color.Black;
            GrdProdutos.Location = new Point(28, 89);
            GrdProdutos.Name = "GrdProdutos";
            GrdProdutos.Size = new Size(744, 320);
            GrdProdutos.TabIndex = 6;
            GrdProdutos.CellContentClick += GrdProdutos_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // BtnEditar
            // 
            BtnEditar.HeaderText = "Editar";
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Resizable = DataGridViewTriState.True;
            BtnEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Resizable = DataGridViewTriState.True;
            BtnExcluir.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FmrCadastrarTipoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtNome);
            Controls.Add(label1);
            Controls.Add(GrdProdutos);
            Name = "FmrCadastrarTipoProduto";
            Text = "Tipo de Produto";
           // Load += FmrCadastrarTipoProduto_Load;
            ((System.ComponentModel.ISupportInitialize)GrdProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFechar;
        private Button BtnSalvar;
        private TextBox TxtNome;
        private Label label1;
        private DataGridView GrdProdutos;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnEditar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}