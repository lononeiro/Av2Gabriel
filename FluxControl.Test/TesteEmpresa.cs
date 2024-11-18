using FluxControl.Data.Repositories;
using FluxControl.Data.Model;
using NUnit.Framework;
using System.Linq;

namespace FluxControl.Test
{
    public class TesteUsuario
    {
        UsuarioRepository usuarioRepository;

        [SetUp]
        public void Setup()
        {
            var db = new DbFluxControlContext();
            usuarioRepository = new UsuarioRepository(db);
        }

        [Test]
        public void IncluirUsuario()
        {
            Usuario usuario = new Usuario
            {
                Nome = "Usuario Teste",
                Email = "teste@fluxcontrol.com",
                Senha = "senha123",
                Admin = false
            };

            usuarioRepository.Incluir(usuario);
        }

        [Test]
        public void AlterarUsuario()
        {
            Usuario usuario = new Usuario
            {
                Nome = "Usuario Original",
                Email = "usuario@original.com",
                Senha = "senha123",
                Admin = false
            };

            usuarioRepository.Incluir(usuario);

            usuario.Nome = "Usuario Alterado";
            usuarioRepository.Alterar(usuario);
        }

        [Test]
        public void ExcluirUsuario()
        {
            Usuario usuario = new Usuario
            {
                Nome = "Usuario Excluir",
                Email = "excluir@fluxcontrol.com",
                Senha = "senha123",
                Admin = false
            };

            usuarioRepository.Incluir(usuario);
            usuarioRepository.Excluir(usuario);

        }

        [Test]
        public void SelecionarTodosUsuarios()
        {
            var usuarios = usuarioRepository.SelecionarTodos();
        }

        [Test]
        public void VerificaAdmin()
        {
            Usuario usuario = new Usuario
            {
                Nome = "Admin Teste",
                Email = "admin@fluxcontrol.com",
                Senha = "admin123",
                Admin = true
            };

            usuarioRepository.Incluir(usuario);

            var isAdmin = usuarioRepository.VerificaAdmin("Admin Teste");
        }

        [Test]
        public void VerificarCredenciais()
        {
            Usuario usuario = new Usuario
            {
                Nome = "Usuario Login",
                Email = "login@fluxcontrol.com",
                Senha = "senha123",
                Admin = false
            };

            usuarioRepository.Incluir(usuario);

            var credenciaisValidas = usuarioRepository.VerificarCredenciais("login@fluxcontrol.com", "senha123");

        }

        [Test]
        public void VerificarNomeExistente()
        {
            Usuario usuario = new Usuario
            {
                Nome = "Usuario Existente",
                Email = "existente@fluxcontrol.com",
                Senha = "senha123",
                Admin = false
            };

            usuarioRepository.Incluir(usuario);

            var nomeExistente = usuarioRepository.VerificarNome("existente@fluxcontrol.com");
        }

        [Test]
        public void ObterUsuarioPorEmail()
        {
            var usuarioPorEmail = usuarioRepository.ObterUsuarioPorEmail("d");
        }
    }
}
