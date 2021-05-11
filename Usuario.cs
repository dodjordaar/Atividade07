using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade07
{
    public class Usuario
    {
        public string login;
        public string senha;
        public List<Carro> modeloCarro;
        public List<Carro> Peças;

        public Usuario(string login,string senha)
        {
            this.login=login;
            this.senha=senha;
            this.modeloCarro=new List<Carro>();
            this.Peças=new List<Carro>();
        }

        public bool verificarSenha(string login,string senha)
        {
            if (this.login.Equals(login) && this.senha.Equals(senha))
            {
                return true;
            }
            return false;
        }


    }
}