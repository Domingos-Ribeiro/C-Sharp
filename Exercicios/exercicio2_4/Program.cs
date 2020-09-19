using Microsoft.VisualBasic;
using System;

namespace exercicio2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            ;
            int maior = 0;

            Console.WriteLine("Programa que define qual o maior dos 3 valores digitados?\n\n");


            Console.WriteLine("Digite o primeiro número\n");
            numero = Convert.ToInt32(Console.ReadLine());
            //Se o número digitado for maior que zero, fica armazenado na variável "maior".
            if (numero > maior)
            {
                maior = numero;
            }

            Console.WriteLine("\n\nDigite o segundo número.\n");
            numero = Convert.ToInt32(Console.ReadLine());
            //Se o segundo número digitado for maior que o anterior, é substituido.
            //Caso contrário, o número que está na variável "maior" não é alterado.
            if (numero > maior)
            {
                maior = numero;
            }

            Console.WriteLine("\n\nDigite o terceiro número.\n");
            numero = Convert.ToInt32(Console.ReadLine());
            //Se o segundo número digitado for maior que o anterior, é substituido.
            //Caso contrário, o número que está na variável "maior" não é alterado.
            if (numero > maior)
            {
                maior = numero;
            }

            Console.WriteLine("\n\nO maior valor digitado foi o nº: " + maior + "\n\n\n\n");

            Console.Write("Feche a consola no X vermelho (Canto superior direito).");
            Console.ReadKey();
            
            return;
            
            
        }
    }
}
