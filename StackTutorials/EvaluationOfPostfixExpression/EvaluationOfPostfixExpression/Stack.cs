using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfPostfixExpression
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
            return n;
        }

        public void Peek()
        {
            
            if (IsEmpty())
                Console.WriteLine("Stack is empty !");
            else Console.WriteLine(Top.Value); ;
            
        }

        public bool IsEmpty()
        {
            if (Top == null)
                return true;
            else return false;
        }

        public void Begin() {
           
            Push(10);
            Peek();
            Push(9);
            Peek();
            Push(8);
            Peek();
            
            Pop();
            Peek();
            Pop();
            Peek();
            Pop();
            Peek();
            Pop();
            
        }
    }
}
