using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(GetSquare(42));
        }

        private static void Print(object v)
        {
            Console.WriteLine(v);
        }

        private static int GetSquare(int v)
        {
            return (int)Math.Pow(v, 2);
        }
    }
}
