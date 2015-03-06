using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        Node Top { get; set; }

        public void Push(int value) {
            Node n = new Node(value);
            if (Top == null)
                Top = n;
            else
            {
                n.Next = Top;
                Top = n;
            }
        }

        public Node Pop()
        {
            Node n = Top;
            if (IsEmpty())
                Console.WriteLine("Stack is empty !");
            else
            {
                Top = Top.Next;
            }
            return Top;
        }

        public int Peek()
        {
            int topVal = -1;
            if (IsEmpty())
                Console.WriteLine("Stack is empty !");
            else topVal = Top.Value;
            return topVal;
        }

        public bool IsEmpty()
        {
            if (Top == null)
                return true;
            else return false;
        }
    }
}
