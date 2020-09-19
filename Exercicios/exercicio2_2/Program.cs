using System;
using System.IO.Pipes;

namespace exercicio2_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Imprime a data atual com o formato pretendido
            DateTime hoje = DateTime.Today;
            string data_Atual = hoje.ToString("dd/MM/yyyy");
            Console.WriteLine("Data atual: " + data_Atual);


            int idade;
            int idade_certa = 18;
           
            

            Console.WriteLine("\n\nOlá, quer saber se já é adulto ou adulta?");
            Console.WriteLine("\nPor favor digite a sua idade atual: ");
            string idade_digitada;
            idade_digitada = Console.ReadLine();

            idade = Convert.ToInt32(idade_digitada);
            int anos = idade_certa - idade;

            //18 ou mais anos
            if (idade > 17)
            
            {
                Console.WriteLine("\n\nInfelizmente já é adulto(a).\nE não poderá fazer nada para reverter a situação... Lamento!");
            }

            //17 anos ou menos
           else
            
                Console.WriteLine("\n\nParabéns, ainda não és maior de idade. \n" +
                    "Mas serás adulto daqui a " + anos + " anos.\nAproveita o tempo que tens, estuda e diverte-te bastante. \n\n\n");
            
        }
    }
}
