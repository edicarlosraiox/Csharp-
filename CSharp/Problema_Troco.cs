using System;
using System.Globalization;

namespace Problema_Troco
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double troco, dinheiro,preco;
            int quantidade;

            Console.Write(" Preço unitario do prduto: ");
            preco = double.Parse(Console.ReadLine(),CI);
            Console.Write(" Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine(),CI);
            Console.Write(" Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(),CI);

            troco = dinheiro - (quantidade * preco);

            Console.WriteLine();
            Console.WriteLine(" DADOS ");
            Console.WriteLine(" Preço: " + preco.ToString("F2",CI));
            Console.WriteLine(" Quantidade: " + quantidade);
            Console.WriteLine(" Dinheiro " + dinheiro.ToString("F2", CI));
            Console.WriteLine(" Troco: " + troco.ToString("F2", CI));
        }
    }
}

