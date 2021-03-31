using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 5, r = 4;
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            if (r < Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2)))
            {
                Console.WriteLine("Point is outside circle");
            }
            else if (r > Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2)))
            
            {
                Console.WriteLine("Point is inside circle");
            }
            else
            { 
                Console.WriteLine("Point is on the circle");
            }
           
                Console.ReadKey();
        }
    }
}
