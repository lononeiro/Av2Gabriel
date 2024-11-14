using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxControl.Data.Interface
{
    public interface ISaidaRepository
    {
        void RegistrarSaida(int idestoque, int quantidade, double precoUnitario, int lote);
    }
}
