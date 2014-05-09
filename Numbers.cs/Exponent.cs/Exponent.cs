using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent.cs
{
    class Exponent
    {
        public static void Square(string a)
        {
            int s;
            s = Convert.ToInt32(a);
            s = s * s;
            Console.WriteLine("The number squared: {0}",s);
        }
        public static void Cube(string b)
        {
            int c;
            c = Convert.ToInt32(b);
            c = c * c * c;
            Console.WriteLine("The number cubed: {0}",c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            Square(input);
            Cube(input);
            
            
        }
    }
}
