using System;

namespace exercicio2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                double valor_1;
                double valor_2;
                double resultado_somar;
                double resultado_subtrair;
                double resultado_dividir;
                double resultado_multiplicar;

                Console.WriteLine("Programa desenhado para calcular as operações desejadas.\n\n");

                Console.WriteLine("Por favor introduza um número e pressione a tecla Enter: \n");
                String frase_lida1;
                frase_lida1 = Console.ReadLine();

                Console.WriteLine("\nDigite mais um número: \n");
                String frase_lida2;
                frase_lida2 = Console.ReadLine();

                valor_1 = Convert.ToDouble(frase_lida1);
                valor_2 = Convert.ToDouble(frase_lida2);

                Console.WriteLine("\nPara os números que introduziu, temos as seguintes operações disponiveis:");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicar");


                Console.WriteLine("\nVeja em cima a operação que deseja efetuar, \nselecionando o número correspondente do lado esquerdo. \nPressione Enter para efetuar o cálculo.\n");
                String escolha;
                escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    resultado_somar = valor_1 + valor_2;
                    Console.WriteLine("\n\n\nO resultado da Soma é: " + resultado_somar);
                }
                if (escolha == "2")
                {
                    resultado_subtrair = valor_1 - valor_2;
                    Console.WriteLine("\n\n\nO resultado da Subtração é: " + resultado_subtrair);
                }
                if (escolha == "3")
                {
                    resultado_dividir = valor_1 / valor_2;
                    Console.WriteLine("\n\nO resultado da Divisão é : " + resultado_dividir);
                }
                if (escolha == "4")
                {
                    resultado_multiplicar = valor_1 * valor_2;
                    Console.WriteLine("\n\n\nO resultado da Multiplicação é : " + resultado_multiplicar);
                }


                Console.WriteLine("\nObrigado por ter usado o programa.\nFeche em cima a janela e volte sempre.");
                Console.ReadKey();
            }

        }
    }
}
