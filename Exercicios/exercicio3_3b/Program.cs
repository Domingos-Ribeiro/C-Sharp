using System;

namespace exercicio3_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa, que efetue a leitura de valores positivos inteiros 
            //até que seja introduzido um valor negativo.
            //No final, deve ser apresentado o maior e o menor valor.

            Console.WriteLine("Programa para guardar números.");
            Console.WriteLine("Para terminar digite um número negativo\n\n\n");

            int tamanho = 10;
            int[] valores = new int[tamanho];
            int pos = 0;

            int numero = 0;

            while (numero >= 0 && pos < tamanho)
            {
                //lê do teclado
                Console.Write("Introduza um valor: ");
                String frase_lida = Console.ReadLine();
                numero = Convert.ToInt32(frase_lida);
                //guarda no array
                valores[pos] = numero;
                //posição seguinte
                pos++;
            }
            
            int maior = 0;
            int menor = 0;

            if (tamanho > 0)
            {
                maior = valores[0];
                menor = valores[0];

                pos = 0;
                while (pos < tamanho && valores[pos] >= 0)
                {
                    if (valores[pos] > maior)
                    {
                        maior = valores[pos];
                    }
                    if (valores[pos] < menor)
                    {
                        menor = valores[pos];
                    }
                    Console.WriteLine("Maior valor: " + pos + "\nMenor valor: " + valores[pos]);
                    pos++;
                }

                
            }
            
        }
    }
}
