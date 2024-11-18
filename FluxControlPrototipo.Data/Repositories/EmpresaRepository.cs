using System.Collections.Generic;
using FluxControl.Data.Interface;
using FluxControl.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace FluxControl.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private DbFluxControlContext db;

        public UsuarioRepository(DbFluxControlContext context)
        {
            db = context;
        }

        public void Alterar(Usuario oUsuario)
        {
            db.Entry(oUsuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public bool VerificaAdmin(string nome)
        {
            
            return db.Usuarios.Any(u => u.Nome == nome && u.Admin == true);
        }

        public void Excluir(Usuario oUsuario)
        {
            db.Entry(oUsuario).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Incluir(Usuario oUsuario)
        {
            db.Add(oUsuario);
            db.SaveChanges();
        }

        public List<Usuario> SelecionarTodos()
        {
            return db.Usuarios.OrderBy(e => e.Nome).ToList();
        }

        public bool VerificarCredenciais(string nomeUsuario, string senha)
        {

            return db.Usuarios.Any(e => e.Email == nomeUsuario && e.Senha == senha);
        }
        public bool VerificarNome(string nome)
        {
            return db.Usuarios.Any(e => e.Email == nome);
        }
        public Usuario ObterUsuarioPorEmail(string email)
        {
            return db.Usuarios.SingleOrDefault(u => u.Email == email);
        }
    }
}
