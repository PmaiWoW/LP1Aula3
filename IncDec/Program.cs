using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            //++ como sufixo:
            int a, b, c;
            a = 3;
            b = -6;
            c = b++ - a++;
            Console.WriteLine("C: {0}", c);
            Console.ReadKey();
        }
    }
}
