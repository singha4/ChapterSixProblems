using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram.cs
{
    class Monogram
    {
        public static void DisplayMonogram(string a)
        {
            Console.Write("**");
            Console.Write(a);

            Console.Write("**");
        }
        static void Main(string[] args)
        {
            string myF = "A", myM = "B", myL = "S", friendF = "K", friendM = "A", friendL = "E";
            DisplayMonogram(myF + "." + myM + "." + myL + ".");
            DisplayMonogram(friendF + friendM + friendL);
        }
    }
}
