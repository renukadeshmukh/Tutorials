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
            s.Begin();
          



            //Reverse
            Stack s1 = new Stack();
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            s1.Push(5);
            
            Stack s2 = new Stack();

            Stack rev = s1.Reverse(s2);
            rev.DisplayStack();

            Console.ReadKey();

        }
    }
}
