using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal static class CadastroUsuarios
    {
        private static Usuario[] usuarios = 
        {
            new Usuario(){Nome = "Matheus", Senha = "abc123"},
            new Usuario(){Nome = "Angela", Senha = "123abc"},
            new Usuario(){Nome = "Eliezer", Senha = "abcd"}
        };
        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado 
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach ( Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
