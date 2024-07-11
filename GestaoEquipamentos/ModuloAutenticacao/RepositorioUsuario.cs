using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloAutenticacao
{
    //Faz o CRUD
    public class RepositorioUsuario
    {
      private List<UsuarioModel> Usuarios {  get; set; }

        public RepositorioUsuario()
        {
            Usuarios = new List<UsuarioModel>();
            Semear();
        }

        private void Semear()
        {
            Usuarios.Add(new UsuarioModel { Login = "admin", Senha = "admin" });
        }

        public UsuarioModel EncontreUsuarioPorLogin(string login)
        {
            return Usuarios.Find(u => u.Login == login);
        }
    }
}
