using System;
using System.Numerics;

namespace TestConsol
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine(Plus(a, b));
        }

        private static int Plus(int a, int b)
        {
            return a + b;
        }
        private static int Minus(int x, int y)
        {
            return x - y;
        }
    }
}
