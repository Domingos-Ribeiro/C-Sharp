using System;

namespace exercicio2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;


            Console.Write("Por favor digite um número: ");
            String num1_lido = Console.ReadLine();
            num1 = Convert.ToInt32(num1_lido);

            if (num1 % 5 == 0)
            {
                Console.WriteLine("\n\nO número " + num1 + "  é Multiplo de 5");
            }
            else
            {
                Console.WriteLine("\n\nO número " + num1 + " Não é Multiplo de 5");
            }

        }
    }
}
