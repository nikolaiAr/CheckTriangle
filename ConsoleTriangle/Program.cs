using System;
using LibCheckTriangle;

namespace ConsoleTriangle
{
    class Program
    {
        static void Main()
        {
            double a, b, c;
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            c = Double.Parse(Console.ReadLine());
            Console.WriteLine(Triangle.CheckType(a, b, c));
            Main();
            Console.ReadKey();
        }
    }
}
