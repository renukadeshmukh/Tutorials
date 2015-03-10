using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingArray
{
    public class Queue
    {
        int Max = 5;
        int[] Array = { 0, 0, 0, 0, 0 };
        int Start;
        int End;
        int QueueSize = 0;

        public void Enqueue(int element)
        {
            if (!IsFull())
            {
                QueueSize++;
                End = (End + 1) % Max;
                Array[End] = element;

            }
            else Console.WriteLine("\nQueue is Full !!!! Cannot insert {0}", element);
        }

        public int Dequeue()
        {
            if (!IsEmpty())
            {
                QueueSize--;
                int val = Array[Start];
                Array[Start] = -1;
                Start = (Start + 1) % Max;
                return val;
            }
            else return -1;
        }

        public bool IsEmpty()
        {
            if (QueueSize == 0)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (QueueSize == Array.Length)
                return true;
            return false;
        }

        public void Display()
        {
            
            Console.Write("\nQueue is :: ");
            for (int i = 0; i < Max; i++)
            {
                Console.Write(Array[i] + " ");
            }
        }
    }
}