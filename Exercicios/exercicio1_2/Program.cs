using System;

namespace exercicio1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            String frase_lida_1 = Console.ReadLine();
            int numero1 = Convert.ToInt32(frase_lida_1);

            Console.Write("Digite mais um número: ");
            String frase_lida_2 = Console.ReadLine();
            int numero2 = Convert.ToInt32(frase_lida_2);

            int resultado_final = numero1 + numero2;
            Console.WriteLine("O resultado final da soma dos números que digitou é: " + resultado_final);
        }
    }
}
