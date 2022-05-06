using System;
using System.Globalization;
namespace Pagamento
{
    class program
    {
        static void Main(String[]argr)
        {
           CultureInfo CI = CultureInfo.InvariantCulture;      

            String nome;
            double valor,pagamento;
            int hora;

            Console.Write(" Nome: ");
            nome = Console.ReadLine();
            Console.Write(" Valor por hora: ");
            valor = double.Parse(Console.ReadLine(),CI);
            Console.Write(" Horas trabalhadas: ");
            hora = int.Parse(Console.ReadLine());

            pagamento = valor * hora;

            Console.WriteLine(" O Pagamento para " + nome + " deve ser de " + pagamento.ToString("F2",CI));

        }
    }
}