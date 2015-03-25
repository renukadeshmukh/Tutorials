using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CircularLinkedList
    {
        public Node Head { get; set; }

        public void InsertInCLLAtEnd(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
                Head.setNext(Head);
            }
            else
            {
                Node cur = Head;
                while (cur.getNext() != Head)
                {
                    cur = cur.getNext();
                }
                cur.setNext(new Node(val));
                cur = cur.getNext();
                cur.setNext(Head);
            }
            PrintCLL(Head);
        }

        public void CreateCLL()
        {
            for (int i = 0; i < 5; i++)
            {
                InsertInCLLAtEnd(i + 1);
            }

            PrintCLL(Head);
        }

        public void PrintCLL(Node Head)
        {
            if (Head == null)
            {
                Console.WriteLine("Circular Linked List is empty !!!");
                return;
            }

            Node n = Head;
            Console.Write("\nCLL Is : {0}-->", n.getValue());

            n = n.getNext();
            while (n != Head)
            {
                Console.Write("{0}-->", n.getValue());
                n = n.getNext();
            }

            Console.Write(Head.getValue());
        }
    }
}
