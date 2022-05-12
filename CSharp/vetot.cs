using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N = 2;
            string[] nomes = new string[N];
            double [] preco = new double[N];
            double[] quantidade = new double[N];
            double soma;

            for (int i = 0; i < N; i++) {
                Console.Write(" Informe o Nome do Objeto: ");
                nomes[i] = Console.ReadLine();
                Console.Write(" Informe o Preço do Objeto: ");
                preco[i] = double.Parse(Console.ReadLine());
                Console.Write(" Informe a Quantidade: ");
                quantidade[i] = double.Parse(Console.ReadLine());
            }


           
            
            Console.WriteLine();

            Console.WriteLine(" DADOS DOS OBJETOS");
            Console.WriteLine(" OBJETO:  " + nomes[]);
            Console.WriteLine(" PREÇO UNITÁRIO:   " + preco[]);
            Console.WriteLine(" QUANTIDADE VENDIDA " + quantidade.ToString);
            Console.WriteLine(" SOMA:" + soma[]);
        }

    }
}
