using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloAutenticacao
{
    public class AutenticadorController
    {
        private readonly RepositorioUsuario RepositorioUsuario;
        public AutenticadorController()
        {
            RepositorioUsuario = new RepositorioUsuario();
        }

        public bool Autenticar(string login, string senha)
        {
            UsuarioModel? usuario = RepositorioUsuario.EncontreUsuarioPorLogin(login);

            if (usuario != null && usuario.Senha.Equals(senha))
            {
                return true;
            }

            return false;
        }
    }
}
