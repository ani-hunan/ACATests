using System;

namespace ACATests
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int i = r.Next(15, 85);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
