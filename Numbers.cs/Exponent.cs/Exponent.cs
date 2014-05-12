using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent.cs
{
    class Exponent
    {
        public static void Square(int a)
        {
            a = a * a;
            Console.WriteLine("The number squared: {0}",a);
        }
        public static void Cube(int b)
        {
            b = b * b * b;
            Console.WriteLine("The number cubed: {0}",b);
        }
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            s = Convert.ToInt32(input);
            Square(s);
            Cube(s);
            
            
        }
    }
}
