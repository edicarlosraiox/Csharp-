using System;
using System.Globalization;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, altura, comprimento, perimetro, area, diagonal;

            Console.Write(" Digite a base do retngulo :");
            largura = double.Parse(Console.ReadLine( ), CI);
            Console.Write(" Digite a altura do retâgulo :");
            altura = double.Parse(Console.ReadLine( ), CI);

            area = largura * altura;
            perimetro = 2 * (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine(" Area = " + area.ToString("F4"), CI);
            Console.WriteLine(" Perimetro = " + perimetro.ToString("F4"), CI);
            Console.WriteLine(" Diagonal = " + diagonal.ToString("F4"), CI);


        }
    }
}
