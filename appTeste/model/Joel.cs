using System;
using Classe.Pessoa;

namespace appTeste.model
{
    public class Joel : Pessoa
    {
        public Joel(string nome, int anoNascimento) : base(nome, anoNascimento)
        {
            this.nome = nome;
            this.anoNascimento = anoNascimento;
        }
    }
}
