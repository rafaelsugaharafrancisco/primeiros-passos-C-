using System;

namespace appTeste.model
{
    class Vendedor : Funcionario
    {
        public Vendedor(string nome, double salario) : base(nome, salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public override double CalcularComissao()
        {
            return this.salario * 0.05;
        }
    }
}
