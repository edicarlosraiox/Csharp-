using System;


namespace raiz_quadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            

            

            int x;

            Console.WriteLine("Digite um numero:");
            x = int.Parse(Console.ReadLine());

            double raiz_quadrada = Math.Sqrt(x);
            Console.WriteLine("Resultado: " + raiz_quadrada);
        }
        
    }
    
}
