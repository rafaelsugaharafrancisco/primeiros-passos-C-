using System;

namespace appTeste.model
{
    abstract class Funcionario
    {
        protected string nome;
        protected double salario;

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }
        public abstract double CalcularComissao();
    }
}
