using System;

namespace exercicio2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos kilometros foram percorridos: ");
            String kilometros_percorridos = Console.ReadLine();
            double kilometros = Convert.ToDouble(kilometros_percorridos);

            Console.Write("\nQual foi a duração da viagem em minutos: ");
            String minutos = Console.ReadLine();
            double dur_minutos = Convert.ToDouble(minutos);

            double horas = Convert.ToDouble(minutos) / 60.0;
            double velocidade_media = kilometros / horas;

            Console.Write("\n\nDurante esta viagem, fez uma média de " + velocidade_media.ToString("F") + " kilometros por hora.\n\n\n\n");
        }
    }
}
