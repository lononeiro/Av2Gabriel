using System;
using System.Windows.Forms;
using FluxControl.Data.Model;
using FluxControl.Data.Repositories; 

namespace Flux_Control_prototipo.Formularios
{
    public partial class FmrLogin : Form
    {
        private UsuarioRepository usuarioRepository;
        private FmrCadastrarUsuario oFmr;

        public bool admin;

        public FmrLogin()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            usuarioRepository = new UsuarioRepository(new DbFluxControlContext());
        }





        private void abrirformulario()
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            string senha = TxtSenha.Text;

            // Use o repositório para verificar as credenciais
            if (usuarioRepository.VerificarCredenciais(email, senha))
            {
                // Obter o usuário e definir permissões globais
                var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

                UsuarioAtual.IsAdmin = usuarioRepository.VerificaAdmin(usuario.Nome);
                UsuarioAtual.UsuarioId = usuario.IdUsuario;

                TxtEmail.Clear();
                TxtSenha.Clear();
                this.Hide();

                // Abrir a tela de estoque
                FmrEstoque oFmr = new FmrEstoque();

                // Gerenciar o evento de fechamento da tela de estoque
                oFmr.FormClosed += (s, args) =>
                {
                    // Ao fechar a tela de estoque, mostra novamente a tela de login
                    this.Show();
                    TxtEmail.Focus(); // Focar no campo de email para facilitar o próximo login
                };

                // Exibe a tela de estoque
                oFmr.ShowDialog();

            }
            else
            {
                // Exibir mensagem de erro
                MessageBox.Show("Email ou senha inválidos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEmail.Focus();
            }
        }


        public void ResgatarIdEmpresa()
        {
            // Implementar lógica para resgatar o ID da empresa, se necessário
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void FmrLogin_Load(object sender, EventArgs e)
        {
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FmrCadastrarUsuario ofmr = new FmrCadastrarUsuario();
            ofmr.Show();
        }
    }
}
