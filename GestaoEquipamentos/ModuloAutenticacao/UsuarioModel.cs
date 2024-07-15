using GestaoEquipamentos.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloAutenticacao
{
    public class UsuarioModel : BaseModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool IsAdmin { get; set; }

        public override string Validar()
        {
            string error = string.Empty;
            if(string.IsNullOrEmpty(Login) && string.IsNullOrEmpty(Senha) )
            {
                return error += "Login ou senha incorretos!";
            }

            return error;
        }
    }
}
