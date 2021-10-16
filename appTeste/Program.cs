using System;
using Classe.Pessoa;
using appTeste.model;
using appTeste.TipoOut;

namespace appTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Rafael";
            int anoNascimento = 1984;

            Pessoa rafael = new Pessoa(nome, anoNascimento);
            Console.WriteLine($"A idade do {nome} é {rafael.ObterIdade()}");

            nome = "Joel";
            anoNascimento = 1961;

            Joel joel = new Joel(nome, anoNascimento);
            Console.WriteLine($"A idade do {nome} é {joel.ObterIdade()}");

            int i = 1, j = 2;
            Referencia.InverterSemRef(i, j);
            Console.WriteLine($"i = {i} e j = {j} método Inverter sem referência");

            Referencia.InverterComRef(ref i, ref j);
            Console.WriteLine($"i = {i} e j = {j} método Inverter com referência");

            const int x = 10;
            const int y = 3;
            Out tipoOut = new Out();
            tipoOut.Dividir(x, y, out int res, out int resto);
            Console.WriteLine($"{x} divido por {y}. O resultado é {res} e o resto da divisão é {resto}");

            Gerente gerente = new Gerente("Rafael", 100);
            Console.WriteLine($"A comissão do gerente é R$ {gerente.CalcularComissao()}");

            Vendedor vendedor = new Vendedor("Fulano", 50);
            Console.WriteLine($"A comissão do vendedor é R$ {vendedor.CalcularComissao()}");
        }
    }
}
