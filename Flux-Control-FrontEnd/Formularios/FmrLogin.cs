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
            this.WindowState = FormWindowState.Maximized;
            usuarioRepository = new UsuarioRepository(new DbFluxControlContext());
        }





        private void FmrLogin_Load(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            string senha = TxtSenha.Text;

            // Use o repositório para verificar as credenciais
            if (usuarioRepository.VerificarCredenciais(email, senha))
            {
                FmrEstoque oFmr = new FmrEstoque();
                TxtEmail.Clear();
                TxtSenha.Clear();
                this.Hide();
                oFmr.Show();

                
                var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

                UsuarioAtual.IsAdmin = usuarioRepository.VerificaAdmin(usuario.Nome);
                UsuarioAtual.UsuarioId = usuario.IdUsuario;

                oFmr.FormClosed += (s, args) => this.Show();

                if (usuarioRepository.VerificaAdmin(TxtEmail.Text))
                {
                    admin = true;
                }

            }
            else
            {
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
    }
}
