using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse4.cs
{
    class Reverse4
    {
        public static void Reverse(int a, int b, int c, int d)
        {
            Console.WriteLine("Reversed: {0}, {1}, {2}, {3}", a, b, c, d);
        }
        static void Main(string[] args)
        {
            int firstInt = 10, secondInt = 20, thirdInt = 30, fourthInt = 40;
            Console.WriteLine("In Order: {0}, {1}, {2} {3}", firstInt, secondInt, thirdInt, fourthInt);
            Reverse(fourthInt, thirdInt, secondInt, firstInt);

        }
    }
}
