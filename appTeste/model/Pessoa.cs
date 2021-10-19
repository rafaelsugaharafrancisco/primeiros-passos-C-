using System;

namespace Classe.Pessoa
{
	public class Pessoa
	{
		protected string _nome;
		protected int _anoNascimento;
		private int _idade;

		public Pessoa(string nome, int anoNascimento)
		{
			this._nome = nome;
			this._anoNascimento = anoNascimento;
		}

		public string Nome
        {
			get => _nome;
			set => _nome = value;
        }
		public int AnoNascimento
        {
			get => _anoNascimento;
			set => _anoNascimento = value;
        }
		public int ObterIdade()
		{
			this._idade = this.CalcularIdade();

			return this._idade;
		}

		private int CalcularIdade()
		{
			return DateTime.Today.Year - this._anoNascimento;
		}
	}
}
