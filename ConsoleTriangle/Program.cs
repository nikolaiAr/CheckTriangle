using System;
using LibCheckTriangle;

namespace ConsoleTriangle
{
    class Program
    {
        static void Main()
        {
            double a, b, c;
            Console.WriteLine("Input the sides of the triangle to find out type");
            Console.WriteLine("Help: enter values one by one (each of new line), use symbol \",\" for demicals");
            while (!Double.TryParse(Console.ReadLine(), out a)|(a <= 0))
                Console.WriteLine("Incorrect value. Please, try again");
            while (!Double.TryParse(Console.ReadLine(), out b)|(b <= 0))
                Console.WriteLine("Incorrect value. Please, try again");
            while (!Double.TryParse(Console.ReadLine(), out c)|(c <= 0))
                Console.WriteLine("Incorrect value. Please, try again");
            Console.WriteLine("Values have been entered: {0}  {1}  {2}", a, b, c);
            Console.WriteLine("Type: " + Triangle.CheckType(a, b, c) + '\n');
            Main();
        }
    }
}
