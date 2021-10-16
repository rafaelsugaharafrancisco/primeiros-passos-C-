using System;

namespace Classe.Pessoa
{
	public class Pessoa
	{
		protected string nome;
		protected int anoNascimento;
		private int idade;

		public Pessoa(string nome, int anoNascimento)
		{
			this.nome = nome;
			this.anoNascimento = anoNascimento;
		}

		public int ObterIdade()
		{
			this.idade = this.CalcularIdade(this.anoNascimento);

			return this.idade;
		}

		private int CalcularIdade(int anoNascimento)
		{
			return DateTime.Today.Year - anoNascimento;
		}
	}
}
