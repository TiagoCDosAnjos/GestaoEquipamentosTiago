using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloAutenticacao
{
    public class UsuarioModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool IsAdmin { get; set; }
    }
}
