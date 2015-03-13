using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class QueueLibrary
    {
        Node Start;
        Node End;

        public void Enqueue(int element)
        {
            if (Start == null)
            {
                Start = new Node(element);
                End = Start;
            }
            else
            {
                End.Next = new Node(element);
                End = End.Next;
            }
        }

        public int Dequeue()
        {
            int val = -1;
            if (Start == null)
                return val;
            if (Start == End)
            {
                val = Start.Value;
                Start = End = null;
                return val;
            }
            else
            {
                val = Start.Value;
                Start = Start.Next;
                return val;
            }
        }

        public bool IsEmpty()
        {
            if (Start == null)
                return true;
            else return false;
        }

        public void Display()
        {
            if (Start == null)
                Console.WriteLine("Queue is Empty !!");
            else
            {
                Node n = Start;
                Console.WriteLine();
                while (n != null)
                {
                    Console.Write(n.Value + " ");
                    n = n.Next;
                }
                Console.WriteLine();
            }
        }
    }
}

