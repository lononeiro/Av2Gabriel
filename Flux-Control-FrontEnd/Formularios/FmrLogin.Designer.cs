namespace Flux_Control_prototipo.Formularios
{
    partial class FmrLogin
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
            label1 = new Label();
            BtnLogin = new Button();
            TxtEmail = new TextBox();
            TxtSenha = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(42, 85);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.None;
            BtnLogin.BackColor = Color.FromArgb(180, 37, 41);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Popup;
            BtnLogin.ForeColor = Color.Transparent;
            BtnLogin.Location = new Point(42, 251);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(253, 31);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Logar";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TxtEmail
            // 
            TxtEmail.Anchor = AnchorStyles.None;
            TxtEmail.Cursor = Cursors.IBeam;
            TxtEmail.Location = new Point(42, 103);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(253, 23);
            TxtEmail.TabIndex = 2;
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // TxtSenha
            // 
            TxtSenha.Anchor = AnchorStyles.None;
            TxtSenha.Cursor = Cursors.IBeam;
            TxtSenha.Location = new Point(42, 168);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(253, 23);
            TxtSenha.TabIndex = 4;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(42, 150);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.MistyRose;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(235, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 358);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(BtnLogin);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TxtEmail);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(TxtSenha);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 358);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(180, 37, 41);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(235, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 44);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 4);
            label3.Name = "label3";
            label3.Size = new Size(95, 37);
            label3.TabIndex = 0;
            label3.Text = "LOGIN";
            // 
            // FmrLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(823, 434);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FmrLogin";
            Text = "Login";
            Load += FmrLogin_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnLogin;
        private TextBox TxtEmail;
        private TextBox TxtSenha;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
    }
}