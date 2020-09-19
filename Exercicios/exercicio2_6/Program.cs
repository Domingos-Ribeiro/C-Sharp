using System;

namespace exercicio2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sem_IVA;
            double com_IVA;
            
            //A linha em baixo devia funcionar mas não funciona ???
            //double IVA = (100 + 23) / 100;
            double IVA = 1.23;

            Console.Write("Programa para calcular quanto paga de IVA num determinado produto.\n\n\n\n");
            Console.Write("Por favor digite o valor que pagou por um produto não alimentar: ");
            
            string valor_digitado;
            valor_digitado = Console.ReadLine();
            //A linha em baixo transforma o ponto que o utilizador possa colocar em virgula.
            valor_digitado = valor_digitado.ToString().Replace('.', ',');

            com_IVA = Convert.ToDouble(valor_digitado);

            sem_IVA = com_IVA / IVA;
            double preco = (com_IVA - sem_IVA);
            //ToString("F") Reduz as casas decimais para apenas duas.
            Console.WriteLine("\nO preço do produto que digitou sem o IVA é: " + sem_IVA.ToString("F") + " Euros\n\n");
            Console.WriteLine("Ou seja, só nesse produto o Estado recebe: " + preco.ToString("F")+ " Euros\n\n\n\n\n");

            //Nota: tentei utilizar o simbolo do euro (€) mas aparece apenas um ponto de interrogação.
        }
    }
}
