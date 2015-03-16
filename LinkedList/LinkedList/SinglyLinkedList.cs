using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SinglyLinkedList
    {
        Node Head { get; set; }

        public Node InsertToSLLAtEnd(int value)
        {
            Console.Write("Inserting Node at end ....");
            Node newNode = new Node(value);

            if (Head == null)
                Head = newNode;
            else
            {
                Node temp = Head;
                while (temp.getNext() != null)
                    temp = temp.getNext();
                temp.setNext(newNode);
            }
            //PrintSLL(Head);
            return Head;
        }

        public Node InsertToSLLAtBegin(int value)
        {
            Console.Write("Inserting Node at begin ....");
            Node newNode = new Node(value);

            if (Head == null)
                Head = newNode;
            else
            {
                newNode.setNext(Head);
                Head = newNode;
            }
            //PrintSLL(Head);
            return Head;
        }

        public Node InsertToSLLAtIndex(int value, int index)
        {
            Console.WriteLine("Inserting at given index ....");
            Node newNode = new Node(value);
            Node temp = Head;
            int count = 0;
            if (Head == null)
                return null;
            else
            {
                while (true)
                {
                    if (index == 1)
                        InsertToSLLAtBegin(value);
                    else if (temp.getNext() == null)
                    {
                        Console.WriteLine("Array Index Out of Bounds !!");
                        break;
                    }
                    else if (count != index - 1)
                    {
                        count++;
                        temp = temp.getNext();
                    }
                    else
                    {
                        //Node temp1 = temp.getNext();
                        newNode.setNext(temp.getNext());
                        temp.setNext(newNode);
                        //temp = temp.getNext();
                        //temp.setNext(temp1);
                        break;
                    }

                }
            }
            return Head;
        }

        public Node ReverseSLL()
        {
            Console.WriteLine("Reversing the list.... ");
            Node temp = new Node(Head.getValue());
            if (Head == null)
                return null;
            else
            {
                while (Head.getNext() != null)
                {
                    Head = Head.getNext();
                    Node prev = new Node(Head.getValue());
                    prev.setNext(temp);
                   // prev.setValue();
                    temp = prev;
                    
                }
                Head = temp;
            }
            return Head;
        }

        public Node ReverseSLLWithRecursion(Node Head) {
            Node temp = null;
            if (Head.getNext() == null)
                return Head;
            else {
               
                temp = ReverseSLLWithRecursion(Head.getNext());
                temp.setNext(Head);
                return temp;
            }
        
        }

        public void PrintSLL(Node Head)
        {

            Node temp = Head;
            while (true)
            {
                if (Head == null)
                    Console.Write("List is Empty !!!");
                else if (temp.getNext() != null)
                {
                    Console.Write(temp.getValue() + "-->");
                    temp = temp.getNext();
                }
                else
                {
                    Console.Write(temp.getValue());
                    break;
                }
            }
        }

        public void CreateSLL()
        {
            InsertToSLLAtEnd(5);
            PrintSLL(Head);
            Console.WriteLine("\n");

            InsertToSLLAtEnd(6);
            PrintSLL(Head);
            Console.WriteLine("\n");

            InsertToSLLAtEnd(7);
            PrintSLL(Head);
            Console.WriteLine("\n");

            //InsertToSLLAtEnd(7);
            //PrintSLL(Head);
            //Console.WriteLine("\n");

            InsertToSLLAtEnd(6);
            PrintSLL(Head);
            Console.WriteLine("\n");

            InsertToSLLAtEnd(5);
            PrintSLL(Head);
            Console.WriteLine("\n");

            //InsertToSLLAtIndex(16, 4);
            //PrintSLL(Head);
            //Console.WriteLine("\n");

            //InsertToSLLAtBegin(11);
            //PrintSLL(Head);
            //Console.WriteLine("\n");

        }

        public int GetMiddleElement()
        {
            if (Head == null)
                return -1;

            Node n1 = Head;
            Node n2 = Head;

            while (n2.getNext() != null && n2.getNext().getNext() != null)
            {
                n1 = n1.getNext();
                n2 = n2.getNext().getNext();
            }

            return n1.getValue();
        }

        public int GetNthFromEnd(int n)
        {
            if (Head == null)
                return -1;

            Node n1 = Head;
            Node n2 = Head;

            int cnt = 1;
            while (n1.getNext() != null && cnt != n) {
                n1 = n1.getNext();
                cnt++;
            }
            if (n1.getNext() == null && cnt != n)
                return -1;

            while(n1.getNext() != null)
            {
                n1 = n1.getNext();
                n2 = n2.getNext();
            }
            return n2.getValue();
        }

        public bool IsSLLPalindrome() {
            if (Head == null)
                return false;

            Node n1 = Head;
            Node n2 = Head;
            SinglyLinkedList n3 = new SinglyLinkedList();

            while (n2.getNext() != null && n2.getNext().getNext() != null)
            {
                n3.InsertToSLLAtBegin(n1.getValue());
                n1 = n1.getNext();
                n2 = n2.getNext().getNext();
            }
           
            if (n2.getNext() != null && n2.getNext().getNext() == null)
                n3.InsertToSLLAtBegin(n1.getValue());
            
            n1 = n1.getNext();
            while (n1!= null && n3.Head != null)
            {
                if (n3.Head.getValue() != n1.getValue())
                    return false;
                n3.Head = n3.Head.getNext();
                n1 = n1.getNext();
            }
            return true;
        }

    }
}
