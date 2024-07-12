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
        private List<UsuarioModel> Usuarios { get; set; }

        public RepositorioUsuario()
        {
            Usuarios = new List<UsuarioModel>();
            Semear();
        }

        private void Semear()
        {
            Usuarios.Add(new UsuarioModel
            {
                Login = "admin",
                Senha = "admin",
                IsAdmin = true
            });
        }

        public UsuarioModel EncontreUsuarioPorLogin(string login)
        {
            for (int i = 0; i < Usuarios.Count; i++)
            {
                UsuarioModel u = Usuarios[i];
                if (u.Login == login)
                {
                    return u;
                }
             
            }
            return null;
            // return Usuarios.Find(u => u.Login == login);
        }

        public List<UsuarioModel> ObterUsuarios()
        {
            return Usuarios;
        } 
    }

    
}
