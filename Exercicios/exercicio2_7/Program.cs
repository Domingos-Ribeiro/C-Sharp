using System;

namespace exercicio2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Consumo médio de um automóvel por cada 100km: ");
            string frase_lida = Console.ReadLine();
            double consumo_100 = Convert.ToDouble(frase_lida);

            Console.Write("O tamanho do tanque de combustivel: ");
            frase_lida = Console.ReadLine();
            int tamanho_deposito = Convert.ToInt32(frase_lida);

            Console.Write("O preço do litro em euros: ");
            frase_lida = Console.ReadLine();
            double preco_litro = Convert.ToDouble(frase_lida);

            Console.Write("Kilometros a percorrer na viagem: ");
            frase_lida = Console.ReadLine();
            double kilometros_percurso = Convert.ToInt32(frase_lida);



            double litros_gastos = kilometros_percurso * (consumo_100 / 100);
            double valor_gasto = litros_gastos * preco_litro;
            double numero_paregens = Math.Floor(litros_gastos  / tamanho_deposito);
            double kilometros_percorridos_deposito = tamanho_deposito * 100 / consumo_100;

            Console.WriteLine("\n\nCombustivel gasto: " + litros_gastos);
            Console.WriteLine("\nDeverá efetuar " + numero_paregens + " Paragens");
            Console.WriteLine("\nCada depósito dá para fazer " + kilometros_percorridos_deposito + " Km");
            Console.WriteLine("\nValor gasto: " + valor_gasto + " Euros");

        }
    }
}
