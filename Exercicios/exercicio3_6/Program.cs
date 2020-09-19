using System;

namespace exercicio3_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //int cofre = 0;
            //int numero = 0;
            //Console.WriteLine("Programa para efetuar a leitura dos números Pares." +
            //    "\nPara conhecer o resultado, digite um n.º Negativo qualquer.\n\n");
            //Console.Write("Por favor introduza um número: ");
            //String numero_lido = Console.ReadLine();
            //numero = Convert.ToInt32(numero_lido);
            //cofre = numero;
            //string num_pares;
            //        // string lista;
            //        // int negativo = 0;
            //int par = 0;
            //while (numero >= 0)
            //{
            //    if (numero % 2 == 0)
            //    {
            //        par = numero;
            //    }
            //    num_pares = Convert.ToString(par);
            //    string lista = num_pares;
            //    Console.Write("Por favor introduza mais um número: ");
            //    numero_lido = Console.ReadLine();
            //    numero = Convert.ToInt32(numero_lido);
            //    lista = lista + ", " + num_pares;
            //}
            //Console.Write("\n\nOs números Pares são: " + lista + "\n\n");
            ////Console.Write("Destes, o menor número é o: " + menor + "\n");
            ////Console.Write("e o Maior número é o: " + maior + "\n\n\n");
            ////Console.Write("A soma de todos os números Positivos é: " + (cofre - negativo) + "\n\nO nº " + negativo + " foi excluido da soma porque o seu propósito é fechar o programa." + "\n\n");
            ////Console.Write("\nDestes, o número negativo é o: " + negativo + "\n");
            //Console.Write("\nMuito obrigado por ter usado o programa.\n\n\n");


            int cofre = 0;
            int numero = 0;
            int par = 0;

            Console.WriteLine("Programa para efetuar a leitura dos números Pares." +
                "\nPara conhecer o resultado, digite um n.º Negativo qualquer.\n\n");

            Console.Write("Por favor introduza um número: ");
            String numero_lido = Console.ReadLine();
            numero = Convert.ToInt32(numero_lido);

            string lista = "";
            string num_pares;

            while (numero >= 0)
            {
                if (numero % 2 == 0)
                {
                    par = numero;
                num_pares = Convert.ToString(par);
                lista = lista + ", " + num_pares;
                }

                Console.Write("Por favor introduza mais um número: ");
                numero_lido = Console.ReadLine();
                numero = Convert.ToInt32(numero_lido);
                
            }

            Console.Write("\n\nOs números pares que foram introduzidos são os seguintes:\n" + lista + "\n\n");
         


        }
    }
}
