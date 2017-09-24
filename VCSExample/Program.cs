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
            Console.WriteLine("Half of 0.25 is {0}", HalfIt(0.25));
            Console.WriteLine("Tripling 0.333 is {0}", TripleIt(0.333));
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
        static public double TripleIt(double aInput)
        {
            double value = 0;
            value = aInput * 3.00;
            return value;
        }
    }
}
