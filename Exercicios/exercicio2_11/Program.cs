using System;

namespace exercicio2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Programa que determina se um n.º é divisível por 10, 5, 2, ou nenhum deles.\n\n\n");

            Console.Write("Introduza um n.º por favor: ");
            String frase_lida = Console.ReadLine();
            double numero = Convert.ToDouble(frase_lida);

            if (numero % 10 == 0 || numero % 5 == 0 || numero % 2 == 0)
            {
                if (numero % 10 == 0)
                {
                    Console.WriteLine("O número é divisivel por 10.");
                }
                if (numero % 5 == 0)
                {
                    Console.WriteLine("O número é divisivel por 5.");
                }
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é divisivel por 2.");
                }
            }
            else
            {
                Console.WriteLine("O número que digitou não é divisivel por 2, 5 ou 10.");
            }
        }
    }
}
