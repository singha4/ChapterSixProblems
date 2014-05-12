using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram.cs
{
    class Monogram
    {
        public static void DisplayMonogram(char a, char b, char c)
        {
            Console.Write("**");
            Console.Write(a + "." + b + "." + c);

            Console.WriteLine("**");
        }
        static void Main(string[] args)
        {
            char myF = 'A', myM = 'B', myL = 'S', friendF = 'K', friendM = 'A', friendL = 'E';
            DisplayMonogram(myF, myM, myL);
            DisplayMonogram(friendF, friendM, friendL);
        }
    }
}
