using System;

namespace exercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
          
            Console.WriteLine("Por favor digite um número entre 1 e 20 ");
            String num1_lido;
            num1_lido = Console.ReadLine();
            

            Console.WriteLine("Por favor digite mais um número entre 10 e 30 ");
            String num2_lido;
            num2_lido = Console.ReadLine();

            num1 = Convert.ToInt32(num1_lido);
            num2 = Convert.ToInt32(num2_lido);
            double resultado = num1 - num2;

            Console.WriteLine("\n\nO resultado da soma destes dois números é igual a: " + resultado);

            if (resultado < 0)
            {
                Console.WriteLine("\n\nComo o resultado desta soma deu Negativo, vamos retirar o respetivo sinal, \nficando desta forma um número positivo, neste caso o nº: " + resultado * -1);
            }
        }
    }
}
