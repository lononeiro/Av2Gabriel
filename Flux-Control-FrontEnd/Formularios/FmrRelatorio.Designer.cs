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
            SuspendLayout();
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(12, 49);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(200, 23);
            dtpDataInicio.TabIndex = 4;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Location = new Point(230, 49);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(200, 23);
            dtpDataFim.TabIndex = 5;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Location = new Point(12, 78);
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
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Data inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 31);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Data final";
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(141, 78);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(110, 23);
            BtnSair.TabIndex = 9;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // FmrRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}