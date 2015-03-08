using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergableStack
{
    public class Stack
    {
        Node Top { get; set; }
        Node Bottom { get; set; }

        public void Push(int value) {
            Node n = new Node(value);
            if (Top == null)
            {
                Top = n;
                Bottom = n;
            }
            else
            {
                n.Next = Top;
                Top = n;
            }
        }

        public Node Pop()
        {
            
            if (IsEmpty())
                return null;
            else
            {
                Node n = Top;
                Top = Top.Next;
                return n;
            }
            
        }

        public int Peek()
        {

            if (IsEmpty())
                return -1;
            else return Top.Value;
            
        }

        public bool IsEmpty()
        {
            if (Top == null)
                return true;
            else return false;
        }

        public void Begin() {
           
            Push(10);
            Push(9);
            Push(8);
            
            
            
        }

        public void Display()
        {
            while (Peek() != -1)
                Console.WriteLine(Pop().Value);
        }

        public Stack MergeStacks(Stack s1, Stack s2)
        {
            if (!s1.IsEmpty() && !s2.IsEmpty()) {
                s1.Bottom.Next = s2.Top;
                return s1;
            }
            else if (!s1.IsEmpty())
                return s1;
            else return s2;
        }
        
    }
}
