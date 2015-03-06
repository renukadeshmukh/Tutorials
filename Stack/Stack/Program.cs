using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(10);
            Console.WriteLine(s.Peek());
            s.Push(9);
            Console.WriteLine(s.Peek());
            s.Push(8);
            Console.WriteLine(s.Peek());

            s.Pop();
            Console.WriteLine(s.Peek());
            s.Pop();
            Console.WriteLine(s.Peek());
            s.Pop();
            Console.WriteLine(s.Peek());
            s.Pop();
            Console.ReadLine();
        }
    }
}
