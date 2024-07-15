using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloEquipamentos
{
    public class AdicionarEquipamentoException : Exception
    {
        private string resultado;

        public AdicionarEquipamentoException(string resultado)
        {
            this.resultado = resultado;
        }
    }
}
