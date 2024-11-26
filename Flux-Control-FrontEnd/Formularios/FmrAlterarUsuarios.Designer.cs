namespace Flux_Control_prototipo.Formularios
{
    partial class FmrAlterarUsuarios
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
            GrdUsuarios = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            BtnEditar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            TxtEmail = new TextBox();
            label2 = new Label();
            CheckBoxAdmin = new CheckBox();
            TxtSenha = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)GrdUsuarios).BeginInit();
            SuspendLayout();
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.FromArgb(185, 3, 15);
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.ForeColor = Color.White;
            BtnFechar.Location = new Point(617, 50);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(97, 33);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(185, 3, 15);
            BtnSalvar.FlatStyle = FlatStyle.Flat;
            BtnSalvar.ForeColor = Color.White;
            BtnSalvar.Location = new Point(617, 11);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 33);
            BtnSalvar.TabIndex = 14;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(41, 60);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(157, 23);
            TxtNome.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome";
            // 
            // GrdUsuarios
            // 
            GrdUsuarios.AllowUserToAddRows = false;
            GrdUsuarios.AllowUserToDeleteRows = false;
            GrdUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdUsuarios.BackgroundColor = Color.FromArgb(224, 224, 224);
            GrdUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdUsuarios.Columns.AddRange(new DataGridViewColumn[] { Nome, BtnEditar, BtnExcluir });
            GrdUsuarios.GridColor = Color.Black;
            GrdUsuarios.Location = new Point(28, 89);
            GrdUsuarios.Name = "GrdUsuarios";
            GrdUsuarios.ReadOnly = true;
            GrdUsuarios.Size = new Size(744, 320);
            GrdUsuarios.TabIndex = 11;
            GrdUsuarios.CellContentClick += GrdUsuarios_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // BtnEditar
            // 
            BtnEditar.HeaderText = "Editar";
            BtnEditar.Name = "BtnEditar";
            BtnEditar.ReadOnly = true;
            BtnEditar.Resizable = DataGridViewTriState.True;
            BtnEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.ReadOnly = true;
            BtnExcluir.Resizable = DataGridViewTriState.True;
            BtnExcluir.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(204, 60);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(157, 23);
            TxtEmail.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 42);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 16;
            label2.Text = "Senha";
            // 
            // CheckBoxAdmin
            // 
            CheckBoxAdmin.AutoSize = true;
            CheckBoxAdmin.Location = new Point(530, 64);
            CheckBoxAdmin.Name = "CheckBoxAdmin";
            CheckBoxAdmin.Size = new Size(62, 19);
            CheckBoxAdmin.TabIndex = 18;
            CheckBoxAdmin.Text = "Admin";
            CheckBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(367, 60);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(157, 23);
            TxtSenha.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 42);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // FmrAlterarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtSenha);
            Controls.Add(label3);
            Controls.Add(CheckBoxAdmin);
            Controls.Add(TxtEmail);
            Controls.Add(label2);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtNome);
            Controls.Add(label1);
            Controls.Add(GrdUsuarios);
            Name = "FmrAlterarUsuarios";
            Text = "Alterar Usuarios";
            ((System.ComponentModel.ISupportInitialize)GrdUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFechar;
        private Button BtnSalvar;
        private TextBox TxtNome;
        private Label label1;
        private DataGridView GrdUsuarios;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnEditar;
        private DataGridViewButtonColumn BtnExcluir;
        private TextBox TxtEmail;
        private Label label2;
        private CheckBox CheckBoxAdmin;
        private TextBox TxtSenha;
        private Label label3;
    }
}