namespace Flux_Control_prototipo.Formularios
{
    partial class FmrCadastrarUsuario
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
            TxtSenhaEmpresa = new TextBox();
            label2 = new Label();
            TxtEmailEmpresa = new TextBox();
            BtnLogin = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            TxtNomeEmpresa = new TextBox();
            TxtConfirmaSenhaEmpresa = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(180, 37, 41);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(217, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 44);
            panel2.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(150, 37);
            label3.TabIndex = 0;
            label3.Text = "CADASTRO";
            // 
            // TxtSenhaEmpresa
            // 
            TxtSenhaEmpresa.Anchor = AnchorStyles.None;
            TxtSenhaEmpresa.Cursor = Cursors.IBeam;
            TxtSenhaEmpresa.Location = new Point(42, 204);
            TxtSenhaEmpresa.Name = "TxtSenhaEmpresa";
            TxtSenhaEmpresa.Size = new Size(253, 23);
            TxtSenhaEmpresa.TabIndex = 13;
            TxtSenhaEmpresa.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(42, 186);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "Senha";
            // 
            // TxtEmailEmpresa
            // 
            TxtEmailEmpresa.Anchor = AnchorStyles.None;
            TxtEmailEmpresa.Cursor = Cursors.IBeam;
            TxtEmailEmpresa.Location = new Point(260, 123);
            TxtEmailEmpresa.Name = "TxtEmailEmpresa";
            TxtEmailEmpresa.Size = new Size(253, 23);
            TxtEmailEmpresa.TabIndex = 11;
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.None;
            BtnLogin.BackColor = Color.FromArgb(180, 37, 41);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Popup;
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(42, 312);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(253, 31);
            BtnLogin.TabIndex = 10;
            BtnLogin.Text = "Cadastrar";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnCadastrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(263, 105);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TxtNomeEmpresa);
            panel1.Controls.Add(TxtConfirmaSenhaEmpresa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtSenhaEmpresa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BtnLogin);
            panel1.Location = new Point(217, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 392);
            panel1.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(42, 126);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 20;
            label5.Text = "Nome";
            // 
            // TxtNomeEmpresa
            // 
            TxtNomeEmpresa.Anchor = AnchorStyles.None;
            TxtNomeEmpresa.Cursor = Cursors.IBeam;
            TxtNomeEmpresa.Location = new Point(42, 144);
            TxtNomeEmpresa.Name = "TxtNomeEmpresa";
            TxtNomeEmpresa.Size = new Size(253, 23);
            TxtNomeEmpresa.TabIndex = 21;
            // 
            // TxtConfirmaSenhaEmpresa
            // 
            TxtConfirmaSenhaEmpresa.Anchor = AnchorStyles.None;
            TxtConfirmaSenhaEmpresa.Cursor = Cursors.IBeam;
            TxtConfirmaSenhaEmpresa.Location = new Point(42, 248);
            TxtConfirmaSenhaEmpresa.Name = "TxtConfirmaSenhaEmpresa";
            TxtConfirmaSenhaEmpresa.Size = new Size(253, 23);
            TxtConfirmaSenhaEmpresa.TabIndex = 19;
            TxtConfirmaSenhaEmpresa.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(42, 230);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 18;
            label4.Text = "Confirme a senha";
            // 
            // FmrCadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(TxtEmailEmpresa);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FmrCadastrarUsuario";
            Text = "Cadastrar usuário";
            Load += FmrCadastrarUsuario_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion




        private Panel panel2;
        private Label label3;
        private TextBox TxtSenhaEmpresa;
        private Label label2;
        private TextBox TxtEmailEmpresa;
        private Button BtnLogin;
        private Label label1;
        private Panel panel1;
        private TextBox TxtConfirmaSenhaEmpresa;
        private Label label4;
        private Label label5;
        private TextBox TxtNomeEmpresa;
    }

}
