using System;
using System.Net.Http;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;


namespace exercicio3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cofre = 0;
            int numero = 0;

            Console.WriteLine("Programa para efetuar a leitura de n.º Positivos Inteiros." +
                "\nPara conhecer o resultado, digite um n.º Negativo qualquer.\n\n");

            Console.Write("Por favor introduza um número: ");
            String numero_lido = Console.ReadLine();
            numero = Convert.ToInt32(numero_lido);

            cofre = numero;
            string lista = numero_lido;
            int menor = 500;
            int maior = 0;
            int negativo = 0;

            while (numero >= 0)
            {
                if (numero > maior) maior = numero;
                if (numero < menor) menor = numero;

                Console.Write("Por favor introduza mais um número: ");
                numero_lido = Console.ReadLine();
                numero = Convert.ToInt32(numero_lido);
                lista = lista + ", " + numero_lido;

                cofre = cofre + numero;
            }
                if (numero < 0)
                {
                    negativo = numero;
                }
 
            Console.Write("\n\nOs números que foram introduzidos são os seguintes: " + lista + "\n\n");
            Console.Write("Destes, o menor número é o: " + menor + "\n");
            Console.Write("e o Maior número é o: " + maior + "\n\n\n");
            Console.Write("A soma de todos os números Positivos é: " + (cofre - negativo) + "\n\nO nº " + negativo + " foi excluido da soma porque o seu propósito é fechar o programa." + "\n\n");
            
            //Console.Write("\nDestes, o número negativo é o: " + negativo + "\n");
            Console.Write("\nMuito obrigado por ter usado o programa.\n\n\n");

        }
    }
}
