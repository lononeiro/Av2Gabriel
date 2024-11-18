using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Model
{
    public class UsuarioAtual
    {
        // Armazena se o usuário é admin ou não
        public static bool IsAdmin { get; set; }

        // Armazena o Id do usuário
        public static int UsuarioId { get; set; }
    }
}
