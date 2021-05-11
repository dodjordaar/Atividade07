using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade07
{
    public class Carro
    {
        public string nome;
        public int ano;
        public string marca;
        public string paisOrigem;

        public Carro(string nome, int ano, string marca, string paisOrigem)
        {
            this.nome=nome;
            this.ano=ano;
            this.marca=marca;
            this.paisOrigem=paisOrigem;
        }
    }
}