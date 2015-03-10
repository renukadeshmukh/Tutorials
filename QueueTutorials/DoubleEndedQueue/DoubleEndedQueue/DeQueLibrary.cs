using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    public class DeQueLibrary
    {
        Node Start;
        Node End;

        public void InsetFront(int elem)
        {
            Node n = new Node(elem);
            if (Start == null)
            {
                Start = End = n;
            }
            else
            {
                n.Next = Start;
                Start.Previous = n;
                Start = Start.Previous;
            }
        }
        public void InsertLast(int elem)
        {
            Node n = new Node(elem);
            if (Start == null)
            {
                Start = End = n;
            }
            else
            {
                End.Next = n;
                n.Previous = End;
                End = End.Next;
            }

        }
        public int DeleteFront()
        {
            if (IsEmpty())
                return -1;
            else if (Start == End)
            {
                int val = Start.Value;
                Start = End = null;
                return val;
            }
            else
            {
                int val = Start.Value;

                Start = Start.Next;
                return val;
            }

        }
        public int DeleteLast()
        {
            if (IsEmpty())
                return -1;
            else if (Start == End)
            {
                int val = End.Value;
                Start = End = null;
                return val;
            }
            else
            {
                int val = End.Value;
                End = End.Previous;
                End.Next = null;
                return val;
            }
        }

        public int GetFront()
        {
            if (Start == null)
                return -1;
            else return Start.Value;
        }

        public int GetRear()
        {
            if (End == null)
                return -1;
            return End.Value;
        }

        public bool IsEmpty()
        {
            if (Start == null && End == null)
                return true;
            return false;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.Write("\nDeQue is Empty !!");
                return;
            }

            Node n = Start;
            Console.Write("\n The DeQue is :: ");
            while (n != null)
            {
                Console.Write(n.Value + " ");
                n = n.Next;
            }
        }

    }
}
