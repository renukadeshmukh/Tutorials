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
            int QueueSizeToKeep = 5;
            Queue q = new Queue(QueueSizeToKeep);
            for (int i = 1; i <= QueueSizeToKeep; i++) { 
                q.Enqueue(i);
                q.Display();
            }

            Console.WriteLine("\nDequeuing :: ",q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();
            Console.WriteLine("\nDequeuing :: ", q.Dequeue());
            q.Display();
            q.Enqueue(15);
            q.Display();

            for (int i = 1; i <= QueueSizeToKeep; i++)
            {
                q.Enqueue(i+10);
                q.Display();
            }


            Console.ReadKey();

        }
    }
}
