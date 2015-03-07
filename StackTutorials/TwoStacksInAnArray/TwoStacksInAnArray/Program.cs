using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStacksInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoStacks ts = new TwoStacks();
            int n1 = ts.Pop1();
            int n2 = ts.Pop2();

            ts.Push1(1);
            ts.DisplayArray();
            ts.Push1(2);
            ts.DisplayArray();

            ts.Push2(8);
            ts.DisplayArray();
            ts.Push2(9);
            ts.DisplayArray();

            ts.Push1(3);
            ts.DisplayArray();
            ts.Push2(7);
            ts.DisplayArray();

            ts.Push1(4);
            ts.DisplayArray();
            ts.Push1(5);
            ts.DisplayArray();
            ts.Push1(6);
            ts.DisplayArray();

            ts.Push1(10);
            ts.DisplayArray();
            ts.Push1(11);
            ts.DisplayArray();
            ts.Push2(12);
            ts.DisplayArray();


            Console.WriteLine(ts.Pop1());
            ts.DisplayArray();
            Console.WriteLine(ts.Pop1());
            ts.DisplayArray();
            Console.WriteLine(ts.Pop2());
            ts.DisplayArray();
            Console.WriteLine(ts.Pop2());
            ts.DisplayArray();
            Console.WriteLine(ts.Pop2());
            ts.DisplayArray();
            Console.WriteLine(ts.Pop2());
            ts.DisplayArray();
            Console.WriteLine(ts.Pop2());
            ts.DisplayArray();

            ts.Push2(12);
            ts.DisplayArray();



            Console.ReadKey();
        }
    }
}
