using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            string s, cString;
            char c;

            //pedir e guardar input do utilizador
            Console.WriteLine("Input a string (phrase), please:");
            s = Console.ReadLine();

            //pedir ao utilizador o carácter a remover
            Console.WriteLine("Input a a char to remove:");
            cString = Console.ReadLine();

            //converter string em char
            c = cString[0];

            //ciclo for p/ percorrer a string e verificar os carácteres da 
            //string e adicioná-los ao array
            foreach(char cInString in s)
            {
                if (cInString != c)
                {
                    Console.Write(cInString);
                }
            }

            Console.ReadKey();
        }
    }
}
