using System;

namespace appTeste.model
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public override double CalcularComissao()
        {
            return this.salario * 0.2;
        }
    }
}
