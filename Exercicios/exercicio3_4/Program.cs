using System;

namespace exercicio3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador_21 = 0;
            int contador_50 = 0;
            int contagem_21 = 0;
            int contagem_50 = 0;

            Console.Write("Programa para memorizar a idade das pessoas.\nPara fechar, por favor digite: -99.\nNOTA: Não pode digitar o nº 21 nem o nº 50.\n\n");
            
            Console.Write("Por favor introduza a primeira idade: ");
            String numero_lido = Console.ReadLine();
            numero = Convert.ToInt32(numero_lido);

            String lista = numero_lido;
     
            while (numero != -99)
            {
                if (numero < 21 && numero > 0)
                {
                    contador_21 = numero;
                    contagem_21++;
                }

                if (numero > 50 )
                {
                    contador_50 = numero;
                    contagem_50++;
                }

                if (numero == 50) Console.WriteLine("Você sabe ler?.");
                if (numero > 150) Console.WriteLine("\nNão brinque comigo, até eu sei que não existem pessoas com " + numero + " anos de idade.\n");
                if (numero == 21) Console.WriteLine("Não pode digitar o nº 21.");


                Console.Write("Por favor introduza mais uma idade: ");
                numero_lido = Console.ReadLine();
                numero = Convert.ToInt32(numero_lido);
                lista = lista + ", " + numero_lido;
            }


            Console.Write("\n\nAs idades introduzidas foram as seguintes:\n " + lista + "\n\n");
            Console.Write("\nExistem: " + contagem_21 + " pessoas com menos de 21 anos." + "\n\n");
            Console.Write("\nExistem: " + contagem_50 + " pessoas com Mais de 50 anos." + "\n\n");
            Console.Write("\n\n\nMuito obrigado por ter usado o programa.\n\n");


        }
    }
}
