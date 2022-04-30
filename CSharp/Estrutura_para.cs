using System;
using System.Globalization;
namespace Estrutura_Para
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, i, x, soma;

            Console.Write(" Quantos numeros serao digitados? ");
            N = int.Parse(Console.ReadLine(), CI);

            soma = 0;
            for (  i = 1; i <  N; i++)
            {
                Console.Write(" Digite um numero: ");
                x = int.Parse(Console.ReadLine(),CI);
                soma = soma + x;
            }
            Console.WriteLine(" SOMA = " + soma.ToString("F1", CI));
        }
    }
}