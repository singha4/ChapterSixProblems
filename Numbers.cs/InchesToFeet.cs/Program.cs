using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet.cs
{
    class Program
    {
        public static void Inches(int a)
        {
            int feet = a / 12;
            int inch = a % 12;
            Console.WriteLine("{0} feet {1} inches", feet, inch);
        }
        static void Main(string[] args)
        {
            int inches = 67;
            Inches(inches);
        }
    }
}
