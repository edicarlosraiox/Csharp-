using System;

namespace Condição
{ 
class Program
{
    static void Main(string[] args)
    {
        int hora;

        Console.Write(" Digite uma hora do dia: ");
        hora = int.Parse(Console.ReadLine());

            if (hora < 12) 
        {
            Console.WriteLine(" Bom Dia!");
        }

        else if (hora > 18) 
        {
            Console.WriteLine(" Boa Noite!");
        }

        else
        {
            Console.WriteLine(" Boa Tarde !");
        }
        
      }

   }
}
 

   

      
  





