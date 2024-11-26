using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluxControl.Data.Model; // Certifique-se de que o namespace do modelo de dados esteja incluído
using FluxControl.Data.Repositories; // Inclua o namespace do repositório

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrCadastrarUsuario : Form
    {
        private bool incluir = true;
        private UsuarioRepository UsuarioRepository; // Declare o repositório de empresas

        public FmrCadastrarUsuario()
        {
            InitializeComponent();
            UsuarioRepository = new UsuarioRepository(new DbFluxControlContext());
        }

        private void FmrCadastrarUsuario_Load(object sender, EventArgs e)
        {
            if (UsuarioAtual.IsAdmin == false)
            {
                //BtnAlterarUsuarios.Enabled = false;
            }
        }

        private void LimpaControles()
        {
            TxtEmailEmpresa.Text = "";
            TxtSenhaEmpresa.Text = "";
            TxtNomeEmpresa.Text = "";
            TxtConfirmaSenhaEmpresa.Text = ""; // Limpe o campo de confirmação de senha
        }
        public bool admin;
        private void BtnCadastrar_Click(object sender, EventArgs e) // Renomeie o método
        {
            if (string.IsNullOrWhiteSpace(TxtEmailEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtNomeEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtSenhaEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtConfirmaSenhaEmpresa.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TxtSenhaEmpresa.Text != TxtConfirmaSenhaEmpresa.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (UsuarioRepository.VerificarNome(TxtNomeEmpresa.Text))
            {
                MessageBox.Show("Esse nome ja está cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario
            {
                Email = TxtEmailEmpresa.Text,
                Nome = TxtNomeEmpresa.Text,
                Senha = TxtSenhaEmpresa.Text,
                Admin = false

            };

            try
            {
                UsuarioRepository.Incluir(usuario); // Use o repositório para incluir a empresa
                MessageBox.Show("Usuario cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaControles();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Um erro ocorreu ao cadastrar o usuario: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrAlterarUsuarios oFmr = new FmrAlterarUsuarios();
            oFmr.Show();
        }
    }
}
