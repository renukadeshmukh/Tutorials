using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(4);
            q.Display();
            q.Enqueue(5);
            q.Display();
            q.Enqueue(6);
            q.Display();
            q.Enqueue(7);
            q.Display();
            q.Enqueue(8);
            q.Display();
            q.Enqueue(9);
            q.Display();

            Console.WriteLine("\nDequeuing :: ",q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();

            Console.ReadKey();
        }
    }
}
