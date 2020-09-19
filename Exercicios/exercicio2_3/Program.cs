using System;

namespace exercicio2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int maior = 0;

            Console.WriteLine("Programa que define qual o maior valor digitado?\n\n");


            Console.WriteLine("Digite um número\n");
            numero = Convert.ToInt32(Console.ReadLine());
            //Se o número digitado for maior que zero, fica armazenado na variável "maior".
            if (numero > maior)
            {
                maior = numero;
            }

            Console.WriteLine("\n\nDigite mais um número.\n");
            numero = Convert.ToInt32(Console.ReadLine());
            //Se o segundo número digitado for maior que o anterior, é substituido.
            //Caso contrário, o número que está na variável "maior" não é alterado.
            if (numero > maior)
            {
                maior = numero;
            }

            Console.WriteLine("\n\n\nO maior valor digitado foi o nº: " + maior + "\n\n\n\n");

        }
    }
}
