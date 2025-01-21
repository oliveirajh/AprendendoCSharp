using System;
using System.Globalization;

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bom dia!"); // Inclui quebra de linha
            //Console.Write("Boa tarde!"); // Não inclui quebra de linha

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo.ToString("F2")); // Formatação de casas decimais
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Faz com que o numero flutuante siga o padrão global

            System.Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome,idade, saldo.ToString("F2", CultureInfo.InvariantCulture)); //Placeholder

            System.Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais"); //Interpolação
        }
    }
}