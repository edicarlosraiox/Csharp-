
using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Digite o valor 1");
        decimal valor1 = Console.Read();
        Console.WriteLine("Digite o valor 2;");
        decimal valor2 = Console.ReadLine();

        decimal media = (valor1+valor2)/2.0M;

        Console.WriteLine($"A média é:  {media}");
    }
}
