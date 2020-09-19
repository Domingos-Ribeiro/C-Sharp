using System;

namespace exercicio3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Programa que delimita a entrada de números.\n\n\n");

            Console.Write("Por favor digite um número entre 1 e 4: ");
            String numero_lido = Console.ReadLine();
            int numero = Convert.ToInt32(numero_lido);

            while (numero < 1 || numero > 4)
            {

            Console.Write("\nO número " + numero + " não está entre o 1 e o 4." + "\n\n");

            Console.Write("\nPor favor digite um novo número: ");
            numero_lido = Console.ReadLine();
            numero = Convert.ToInt32(numero_lido);
  
            }


            Console.Write("\n\nPARABÉNS!!! Conseguiu acertar, o número: " + numero + " está correto!"+"\n");
            Console.Write("\n\n\nObrigado por ter utilizado o programa." + "\n\n\n");

        }
    }
}
