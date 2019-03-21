using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            int xDim, yDim;
            float val, soma, media;

            //pedir ao utilizador a dimensão X do array
            Console.WriteLine("Insere a dimensão X do array");
            xDim = Convert.ToInt32(Console.ReadLine());
            //pedir ao utilizador a dimensão Y do array
            Console.WriteLine("Insere a dimensão Y do array");
            yDim = Convert.ToInt32(Console.ReadLine());

            //Declarar e criar um array bidimensional de floats
            float[,] FloatBiDim = new float[yDim, xDim];

            //criar cada um array bidimensional com as dimensões dadas e
            //percorrer o array, posição a posição, pedindo o valor de cada uma
            for(int i = 0; i < FloatBiDim.GetLength(0); i++)
            {
                for(int j = 0; j < FloatBiDim.GetLength(1); j++)
                {
                    //pedir o valor de cada posição percorrida pelo array ao
                    //utilizador, convertendo o input para float
                    Console.WriteLine($"Insere o valor da posição [{i}, {j}]");
                    val = Convert.ToSingle(Console.ReadLine());
                    FloatBiDim[i, j] = val;
                }
                Console.WriteLine();
            }
            
            //mostrar array inserido ao utilizador através do método GetLength
            for(int i = 0; i < FloatBiDim.GetLength(0); i++)
            {
                for(int j = 0; j < FloatBiDim.GetLength(1); j++)
                {
                    Console.Write(FloatBiDim[i, j] + " ");
                }
                Console.WriteLine(); //linhas separadas por nova linha
            }

            //percorrer o array, somar os valores das posições em cada em
            //cada linha e fazer a média dos valores das mesmas
            for(int i = 0; i < FloatBiDim.GetLength(0); i++)
            {
                //repôr o valor da soma para 0
                soma = 0;
                for (int j = 0; j < FloatBiDim.GetLength(1); j++)
                {
                    //somar cada valor percorrido na linha
                    soma += FloatBiDim[i, j];
                }

                //calcular a média da linha atual, usando a soma da mesma
                media = soma / FloatBiDim.GetLength(1);
                //fazer print da soma e média das linhas em string interpolada
                Console.WriteLine($"\nSoma da linha {i+1}: {soma}" +
                    $"\nMédia da linha {i+1}: {media}");
            }

            Console.ReadKey();
        }
    }
}
