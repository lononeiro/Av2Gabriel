using FluxControl.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Interface
{
    public interface IUsuarioRepository
    {
        void Incluir(Usuario oEmpresa);
        void Excluir(Usuario oEmpresa);
        void Alterar(Usuario oEmpresa);
        List<Usuario> SelecionarTodos();
        bool VerificarCredenciais(string nomeUsuario, string senha);
        bool VerificarNome(string nomeUsuario);
    }
}

