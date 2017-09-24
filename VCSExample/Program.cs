using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's a value: {0}", DoubleIt(2));
            Console.WriteLine("Here's a half value: {0}", HalfIt(3.14159));
            Console.WriteLine("");
        }
        static public double DoubleIt(double aInput)
        {
            double value = 0;
            value = aInput * 2.00;
            return value;
        }
        static public double HalfIt(double aInput)
        {
            double value = 0;
            value = aInput / 2.00;
            return value;
        }
    }
}
