using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            //++ como sufixo:
            int a, b, c;
            a = -3;
            b = 6;
            c = a++ + b++;
            Console.WriteLine("Sufixo ++ :\na = -3 b = 6\nc = {0}", c);

            //-- como prefixo
            a = 7;
            b = -2;
            c = --a + --b;
            Console.WriteLine("\nPrefixo -- :\na = 7 b = -2\nc = {0}", c);

            Console.ReadKey();
        }
    }
}
