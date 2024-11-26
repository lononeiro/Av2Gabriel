namespace Flux_Control_prototipo.Formularios
{
    partial class FmrRelatorio
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
            dtpDataInicio = new DateTimePicker();
            dtpDataFim = new DateTimePicker();
            BtnConsultar = new Button();
            label1 = new Label();
            label2 = new Label();
            BtnSair = new Button();
            CheckBoxTodosProdutos = new CheckBox();
            ChecklistProdutos = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtValorLiquido = new TextBox();
            TxtValorBruto = new TextBox();
            TxtQuantidadeVendida = new TextBox();
            TxtProdutoVendido = new TextBox();
            SuspendLayout();
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(79, 12);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(200, 23);
            dtpDataInicio.TabIndex = 4;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Location = new Point(79, 56);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(200, 23);
            dtpDataFim.TabIndex = 5;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Location = new Point(12, 101);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(110, 23);
            BtnConsultar.TabIndex = 6;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = true;
            BtnConsultar.Click += BtnGerarRelatorio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Data inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Data final";
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(128, 101);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(110, 23);
            BtnSair.TabIndex = 9;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // CheckBoxTodosProdutos
            // 
            CheckBoxTodosProdutos.AutoSize = true;
            CheckBoxTodosProdutos.Location = new Point(304, 8);
            CheckBoxTodosProdutos.Name = "CheckBoxTodosProdutos";
            CheckBoxTodosProdutos.Size = new Size(108, 19);
            CheckBoxTodosProdutos.TabIndex = 10;
            CheckBoxTodosProdutos.Text = "Todos produtos";
            CheckBoxTodosProdutos.UseVisualStyleBackColor = true;
            CheckBoxTodosProdutos.CheckedChanged += CheckBoxTodosProdutos_CheckedChanged;
            // 
            // ChecklistProdutos
            // 
            ChecklistProdutos.FormattingEnabled = true;
            ChecklistProdutos.Location = new Point(304, 30);
            ChecklistProdutos.Name = "ChecklistProdutos";
            ChecklistProdutos.Size = new Size(120, 94);
            ChecklistProdutos.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 12);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 13;
            label3.Text = "Produto mais vendido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 12);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 14;
            label4.Text = "Valor bruto";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 74);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 15;
            label5.Text = "Valor liquido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(607, 71);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 16;
            label6.Text = "Quantidade vendida";
            // 
            // TxtValorLiquido
            // 
            TxtValorLiquido.Enabled = false;
            TxtValorLiquido.Location = new Point(445, 89);
            TxtValorLiquido.Name = "TxtValorLiquido";
            TxtValorLiquido.Size = new Size(140, 23);
            TxtValorLiquido.TabIndex = 17;
            // 
            // TxtValorBruto
            // 
            TxtValorBruto.Enabled = false;
            TxtValorBruto.Location = new Point(445, 30);
            TxtValorBruto.Name = "TxtValorBruto";
            TxtValorBruto.Size = new Size(140, 23);
            TxtValorBruto.TabIndex = 18;
            // 
            // TxtQuantidadeVendida
            // 
            TxtQuantidadeVendida.Enabled = false;
            TxtQuantidadeVendida.Location = new Point(607, 89);
            TxtQuantidadeVendida.Name = "TxtQuantidadeVendida";
            TxtQuantidadeVendida.Size = new Size(142, 23);
            TxtQuantidadeVendida.TabIndex = 19;
            // 
            // TxtProdutoVendido
            // 
            TxtProdutoVendido.Enabled = false;
            TxtProdutoVendido.Location = new Point(607, 30);
            TxtProdutoVendido.Name = "TxtProdutoVendido";
            TxtProdutoVendido.Size = new Size(142, 23);
            TxtProdutoVendido.TabIndex = 20;
            // 
            // FmrRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 450);
            Controls.Add(TxtProdutoVendido);
            Controls.Add(TxtQuantidadeVendida);
            Controls.Add(TxtValorBruto);
            Controls.Add(TxtValorLiquido);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ChecklistProdutos);
            Controls.Add(CheckBoxTodosProdutos);
            Controls.Add(BtnSair);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnConsultar);
            Controls.Add(dtpDataFim);
            Controls.Add(dtpDataInicio);
            Name = "FmrRelatorio";
            Text = "Relatórios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpDataInicio;
        private DateTimePicker dtpDataFim;
        private Button BtnConsultar;
        private Label label1;
        private Label label2;
        private Button BtnSair;
        private CheckBox CheckBoxTodosProdutos;
        private CheckedListBox ChecklistProdutos;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtValorLiquido;
        private TextBox TxtValorBruto;
        private TextBox TxtQuantidadeVendida;
        private TextBox TxtProdutoVendido;
    }
}