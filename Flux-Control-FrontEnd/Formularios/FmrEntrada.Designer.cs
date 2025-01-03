﻿namespace Flux_Control_prototipo.Formularios
{
    partial class FmrEntrada
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
            label3 = new Label();
            panel2 = new Panel();
            TxtDescricao = new TextBox();
            label1 = new Label();
            TxtQuantidade = new TextBox();
            label2 = new Label();
            TxtPrecoCompra = new TextBox();
            label4 = new Label();
            TxtPrecoVenda = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Salvar = new Button();
            BtnEncerrar = new Button();
            ComboBoxProdutos = new ComboBox();
            TxtLote = new TextBox();
            label7 = new Label();
            label8 = new Label();
            DtpDataValidade = new DateTimePicker();
            label9 = new Label();
            dtpDataEntrada = new DateTimePicker();
            CheckBoxAgora = new CheckBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 2);
            label3.Name = "label3";
            label3.Size = new Size(273, 37);
            label3.TabIndex = 2;
            label3.Text = "REGISTRAR ENTRADA";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(185, 3, 15);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 44);
            panel2.TabIndex = 9;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(94, 73);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(197, 23);
            TxtDescricao.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 11);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Location = new Point(118, 116);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(142, 23);
            TxtQuantidade.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 55);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Descrição";
            // 
            // TxtPrecoCompra
            // 
            TxtPrecoCompra.Location = new Point(94, 201);
            TxtPrecoCompra.Name = "TxtPrecoCompra";
            TxtPrecoCompra.Size = new Size(185, 23);
            TxtPrecoCompra.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 98);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 11;
            label4.Text = "Quantidade";
            // 
            // TxtPrecoVenda
            // 
            TxtPrecoVenda.Location = new Point(94, 251);
            TxtPrecoVenda.Name = "TxtPrecoVenda";
            TxtPrecoVenda.Size = new Size(185, 23);
            TxtPrecoVenda.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 183);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 11;
            label5.Text = "Preço compra unidade (R$)";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 233);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 11;
            label6.Text = "Preço venda unidade (R$)";
            // 
            // Salvar
            // 
            Salvar.BackColor = Color.FromArgb(185, 3, 15);
            Salvar.Cursor = Cursors.Hand;
            Salvar.FlatStyle = FlatStyle.Flat;
            Salvar.ForeColor = Color.WhiteSmoke;
            Salvar.Location = new Point(91, 413);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(86, 37);
            Salvar.TabIndex = 13;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += BtnSalvar_Click;
            // 
            // BtnEncerrar
            // 
            BtnEncerrar.BackColor = Color.FromArgb(185, 3, 15);
            BtnEncerrar.Cursor = Cursors.Hand;
            BtnEncerrar.FlatStyle = FlatStyle.Flat;
            BtnEncerrar.ForeColor = Color.White;
            BtnEncerrar.Location = new Point(193, 413);
            BtnEncerrar.Name = "BtnEncerrar";
            BtnEncerrar.Size = new Size(86, 37);
            BtnEncerrar.TabIndex = 14;
            BtnEncerrar.Text = "Encerrar";
            BtnEncerrar.UseVisualStyleBackColor = false;
            BtnEncerrar.Click += BtnEncerrar_Click;
            // 
            // ComboBoxProdutos
            // 
            ComboBoxProdutos.FormattingEnabled = true;
            ComboBoxProdutos.Location = new Point(118, 29);
            ComboBoxProdutos.Name = "ComboBoxProdutos";
            ComboBoxProdutos.Size = new Size(154, 23);
            ComboBoxProdutos.TabIndex = 17;
            // 
            // TxtLote
            // 
            TxtLote.Location = new Point(143, 157);
            TxtLote.Name = "TxtLote";
            TxtLote.Size = new Size(93, 23);
            TxtLote.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 139);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 18;
            label7.Text = "Lote";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(142, 277);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 12;
            label8.Text = "Data de Validade";
            // 
            // DtpDataValidade
            // 
            DtpDataValidade.Location = new Point(91, 295);
            DtpDataValidade.Name = "DtpDataValidade";
            DtpDataValidade.Size = new Size(200, 23);
            DtpDataValidade.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(142, 328);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 21;
            label9.Text = "Data de entrada";
            // 
            // dtpDataEntrada
            // 
            dtpDataEntrada.Location = new Point(94, 382);
            dtpDataEntrada.Name = "dtpDataEntrada";
            dtpDataEntrada.Size = new Size(200, 23);
            dtpDataEntrada.TabIndex = 22;
            // 
            // CheckBoxAgora
            // 
            CheckBoxAgora.AutoSize = true;
            CheckBoxAgora.Location = new Point(94, 357);
            CheckBoxAgora.Name = "CheckBoxAgora";
            CheckBoxAgora.Size = new Size(58, 19);
            CheckBoxAgora.TabIndex = 24;
            CheckBoxAgora.Text = "Agora";
            CheckBoxAgora.UseVisualStyleBackColor = true;
            CheckBoxAgora.CheckedChanged += CheckBoxAgora_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CheckBoxAgora);
            panel1.Controls.Add(dtpDataEntrada);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(DtpDataValidade);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(TxtLote);
            panel1.Controls.Add(ComboBoxProdutos);
            panel1.Controls.Add(BtnEncerrar);
            panel1.Controls.Add(Salvar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TxtPrecoVenda);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxtPrecoCompra);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtQuantidade);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TxtDescricao);
            panel1.Location = new Point(34, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 488);
            panel1.TabIndex = 10;
            // 
            // FmrEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 233, 238);
            ClientSize = new Size(431, 573);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FmrEntrada";
            Text = "Registrar entrada";
            Load += FmrEntrada_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Panel panel2;
        private TextBox TxtDescricao;
        private Label label1;
        private TextBox TxtQuantidade;
        private Label label2;
        private TextBox TxtPrecoCompra;
        private Label label4;
        private TextBox TxtPrecoVenda;
        private Label label5;
        private Label label6;
        private Button Salvar;
        private Button BtnEncerrar;
        private ComboBox ComboBoxProdutos;
        private TextBox TxtLote;
        private Label label7;
        private Label label8;
        private DateTimePicker DtpDataValidade;
        private Label label9;
        private DateTimePicker dtpDataEntrada;
        private CheckBox CheckBoxAgora;
        private Panel panel1;
    }
}