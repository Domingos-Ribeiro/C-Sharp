using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor_1;
            float valor_2;
            float resultado_somar;
            float resultado_subtrair;
            float resultado_dividir;
            float resultado_multiplicar;

            Console.WriteLine("Por favor introduza um número de 1 a 100: ");
            String frase_lida1;
            frase_lida1 = Console.ReadLine();

            Console.WriteLine("Por favor introduza um número de 1 a 20: ");
            String frase_lida2;
            frase_lida2 = Console.ReadLine();

            valor_1 = Convert.ToInt32(frase_lida1);
            valor_2 = Convert.ToInt32(frase_lida2);

            resultado_somar = valor_1 + valor_2;
            resultado_subtrair = valor_1 - valor_2;
            resultado_dividir = valor_1 / valor_2;
            resultado_multiplicar = valor_1 * valor_2;

            Console.WriteLine("\nO resultado da Soma dos numeros que digitou é : " + (resultado_somar) + "\n" +
               "O resultado da Subtração é : " + (resultado_subtrair) + "\n" +
               "O resultado da Divisão é : " + (resultado_dividir) + "\n" +
               "O resultado da Multiplicação é : " + (resultado_multiplicar) + "\n\n\n");

            Console.WriteLine("Obrigado por ter usado o programa. \n \nPara sair, pressione qualquer tecla.\n\n\n");

            
        }
    }
}
