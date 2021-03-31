using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case int i when (i > 0 && i < 45): 
                    Console.WriteLine("number is in 0 -> 45 range");
                    break;
                case int i when (i > 45 && i < 90):
                    Console.WriteLine("number is in 45 -> 90 range");
                    break;
                case int i when (i > 0 && i < 45):
                    Console.WriteLine("number is in 90 -> 135 range");
                    break;
                default:
                    Console.WriteLine("number is in other range");
                    break;

            }
           
        }
    }
}
