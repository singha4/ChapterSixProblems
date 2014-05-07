using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToYards.cs
{
    class InchesToYards
    {
        public static void Yards(int a)
        {

            int feet = a / 12;
            int yards = feet / 3;
            feet = feet % 3;
            int inch = a % 12;
            Console.WriteLine("{0} yards {1} feet {2} inches", yards, feet, inch);
        }
        static void Main(string[] args)
        {
            int inches = 67;
            Yards(inches);
        }
    }
}
