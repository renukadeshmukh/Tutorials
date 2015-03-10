using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Display();
            Console.Write("Enqueuing -->");
            q.Enqueue(2);
            q.Display();
            Console.Write("Enqueuing -->");
            q.Enqueue(3);
            q.Display();
            Console.Write("Enqueuing -->");
            q.Enqueue(4);
            q.Display(); 
            Console.Write("Enqueuing -->");
            q.Enqueue(5);
            q.Display();


            
            Console.WriteLine("Dequeuing element :: {0}", q.Dequeue());
            Console.WriteLine("Dequeuing element :: {0}", q.Dequeue());
            Console.WriteLine("Dequeuing element :: {0}", q.Dequeue());
            Console.WriteLine("Dequeuing element :: {0}", q.Dequeue());
            Console.WriteLine("Dequeuing element :: {0}", q.Dequeue());
            Console.WriteLine("Dequeuing element :: {0}", q.Dequeue());

            Console.ReadKey();
        }
    }
}
