using System;

namespace exercicio2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Programa que determina se um número é múltiplo de 5.\n\n\n");

            Console.Write("Introduza um número por favor: ");
            String frase_lida = Console.ReadLine();
            double numero = Convert.ToDouble(frase_lida);

            if (numero % 5 == 0)
            {
                Console.WriteLine("O número é multiplo de 5.\n\n\n");
            }
            else
            {
                Console.WriteLine("O número não é multiplo de 5.\n\n\n");
            }
        }
    }
}
