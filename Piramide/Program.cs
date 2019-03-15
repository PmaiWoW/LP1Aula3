using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            string nInput;
            int nLinhas, nEspaços, nAsteriscos;

            //pedir ao utilizador o nº de linhas
            Console.WriteLine("How many rows will the pyramid have?");
            nInput = Console.ReadLine();

            //converter o nº de linhas para int
            nLinhas = Convert.ToInt32(nInput);

            //for loop, até ao nº de linhas dado pelo utilizador
            for(int i = 0; i < nLinhas; i++)
            {
                //determinar quantos espaços antes dos astericos
                nEspaços = nLinhas - i - 1;

                //loop p/ fazer print espaços de acordo c/ o cálculo
                for (int j = 0; j < nEspaços; j++)
                {
                    Console.Write(" ");
                }
                
                //determinar quantos asteriscos
                nAsteriscos = i * 2 + 1;

                //loop p/ fazer print espaços de acordo c/ o cálculo
                for (int j = 0; j < nAsteriscos; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();// ou Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
