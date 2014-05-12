using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse3.cs
{
    class Reverse3
    {
        public static void Reverse(int a, int b, int c)
        {
            Console.WriteLine("Reversed: {0}, {1}, {2}", a, b, c);
        }
        static void Main(string[] args)
        {
            int firstInt = 10, middleInt = 20, lastInt = 30;
            Console.WriteLine("In Order: {0}, {1}, {2}", firstInt, middleInt, lastInt);
            Reverse(lastInt, middleInt, firstInt);

        }
    }
}
