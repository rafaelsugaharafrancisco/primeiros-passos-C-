using System;
using Classe.Pessoa;
using appTeste.model;
using appTeste.TipoOut;
using appTeste.Structs;
using appTeste.Enum;

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

            // A classe Joel é uma classe que herda de Pessoa
            Joel joel = new Joel(nome, anoNascimento);
            Console.WriteLine($"A idade do {nome} é {joel.ObterIdade()}");

            // Métodos estáticos
            int i = 1, j = 2;
            Referencia.InverterSemRef(i, j);
            Console.WriteLine($"i = {i} e j = {j} método Inverter sem referência");

            Referencia.InverterComRef(ref i, ref j);
            Console.WriteLine($"i = {i} e j = {j} método Inverter com referência");

            // utilizando referência tipo out
            const int x = 10;
            const int y = 3;
            Out tipoOut = new Out();
            tipoOut.Dividir(x, y, out int res, out int resto);
            Console.WriteLine($"{x} divido por {y}. O resultado é {res} e o resto da divisão é {resto}");

            // As classes Gerente e Vendedor herdam da classe Funcionário, que é uma classe abstrata e 
            // tem um método abstrato chamado CalcularComissao()
            Gerente gerente = new Gerente("Rafael", 100);
            Console.WriteLine($"A comissão do gerente é R$ {gerente.CalcularComissao()}");

            Vendedor vendedor = new Vendedor("Fulano", 50);
            Console.WriteLine($"A comissão do vendedor é R$ {vendedor.CalcularComissao()}");

            // Structs não são como as classes, mas a diferença que ela é do tipo valor. Não é do tipo referência.
            // As Structs usam as stacks temporárias. Utilizadas para pequenas estruturas de dados.
            Caneta caneta = new Caneta("azul", "bic");
            Console.WriteLine($"{caneta.corDaTinta} , {caneta.marca}");

            // interface
            MontBlanc relogio = new MontBlanc();
            Console.WriteLine($"Hora no momento da invocação do método assinado: { relogio.MostrarHora() }");

            //Enum
            Cores cor = Cores.Preta;

            if ( cor == Cores.Preta)
            {
                Console.WriteLine($"A cor é {Cores.Preta}");
            } else
            {
                Console.WriteLine("Outra cor");
            }

        }
    }
}
