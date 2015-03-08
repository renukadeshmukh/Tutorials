using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergableStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(3);
            s.Push(4);
            s.Push(5);

            Console.WriteLine("Pop from S (Expected 5): " + s.Pop().Value);

            Stack s1 = new Stack();
            s1.Push(7);
            s1.Push(8);
            s1.Push(9);
            s1.Push(10);
            Console.WriteLine("Pop from S1 (Expected 10): " + s1.Pop().Value);

            Stack s2 = s1.MergeStacks(s, s1);
            Console.WriteLine("Merging Stacks (Expected 3 4 9 8 7) : ");
            s2.Display();
            Console.ReadKey();

        }
    }
}
