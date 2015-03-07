using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfixToPostfix
{
    public class StackLibrary
    {
        Node Top { get; set; }

        public void Push(string value)
        {
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
            return n;
        }

        public string Peek()
        {

            if (IsEmpty())
                return null;
            return Top.Value ;

        }

        public bool IsEmpty()
        {
            if (Top == null)
                return true;
            else return false;
        }

        
    }
}
