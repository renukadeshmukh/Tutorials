using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingArray
{
    public class Queue
    {
        int MaxSize;
        int[] Array;
        int Start;
        int End;
        int QueueSize;

        public Queue(int size)
        {
            MaxSize = size;
            Array = new int[MaxSize];
            Start = End = -1;
            QueueSize = 0;
        }

        public void Enqueue(int element)
        {
            if (!IsFull())
            {
                if (Start == -1)
                    Start++;
                QueueSize++;
                End = (End + 1) % MaxSize;
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
                Start = (Start + 1) % MaxSize;
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
            if (QueueSize == MaxSize)
                return true;
            return false;
        }

        public void Display()
        {
            
            Console.Write("\nQueue is :: ");
            for (int i = 0; i < MaxSize; i++)
            {
                Console.Write(Array[i] + " ");
            }
        }
    }
}