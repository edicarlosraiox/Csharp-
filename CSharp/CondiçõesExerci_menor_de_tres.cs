using System;
using System.Globalization;  

namespace Menor_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b, c, menor;

            Console.Write(" Primeiro Valor:");
            a = int.Parse(Console.ReadLine(), CI);
            Console.Write(" Segundo valor: ");
            b = int.Parse(Console.ReadLine(), CI);
            Console.Write(" Terceiro valor:  ");
            c = int.Parse(Console.ReadLine(), CI);

            if (a < b && a < c) {
                menor = a;
            }
            else if(b < c) {
                menor = b;
            }
            else{
                menor = c;
            }
            Console.WriteLine(" Menor = " + menor);
        }
    }
}
