using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade07
{
    class Banco
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        public static bool CriarUsuario(string login, string senha)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.login.Equals(login)) return false;
            }
            usuarios.Add(new Usuario(login, senha));
            return true;
        }
        public static Usuario RealizarLogin(string login, string senha)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.verificarSenha(login, senha)) return u;
            }
            return null;
        }
    }
}
