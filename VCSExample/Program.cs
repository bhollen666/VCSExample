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
            Console.WriteLine("Here's a value: {0}", FooA(2));
            Console.WriteLine("");
        }
        static public int FooA(int aInput)
        {
            int value = 0;
            value = aInput * 2;
            return value;
        }
    }
}
