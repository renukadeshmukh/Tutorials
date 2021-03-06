﻿using System;
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
            //Console.Write("Inserting Node at end ....");
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
            //Console.Write("Inserting Node at begin ....");
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

        public Node ReverseSLLWithRecursion(Node Head)
        {
            Node temp = null;
            if (Head.getNext() == null)
                return Head;
            else
            {

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
            for (int i = 0; i < 4; i++)
            {
                InsertToSLLAtEnd(i);
                InsertToSLLAtEnd(i + 5);
            }
            PrintSLL(Head);

            //InsertToSLLAtIndex(11, 4);
            //PrintSLL(Head);
            //Console.WriteLine("\n");

            //InsertToSLLAtEnd(5);
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
            while (n1.getNext() != null && cnt != n)
            {
                n1 = n1.getNext();
                cnt++;
            }
            if (n1.getNext() == null && cnt != n)
                return -1;

            while (n1.getNext() != null)
            {
                n1 = n1.getNext();
                n2 = n2.getNext();
            }
            return n2.getValue();
        }

        public bool IsSLLPalindrome()
        {
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
            while (n1 != null && n3.Head != null)
            {
                if (n3.Head.getValue() != n1.getValue())
                    return false;
                n3.Head = n3.Head.getNext();
                n1 = n1.getNext();
            }
            return true;
        }

        public void ReversePrint()
        {
            Console.Write("\n\nRecursive Reverse is :: ");
            RecursiveReversePrint(Head);
            Console.Write("null");

        }

        public void RecursiveReversePrint(Node n)
        {
            if (n == null)
                return;
            else
            {
                RecursiveReversePrint(n.getNext());
                Console.Write(n.getValue() + "-->");
            }
        }

        public void RemoveDuplicatesFromLinkedList()
        {
            Dictionary<int, int> Values = new Dictionary<int, int>();
            //if linked list is empty
            if (Head == null)
            {
                Console.WriteLine("LinkedList is Empty !!");
                return;
            }

            Node nextN = Head;
            Node n = null;

            while (nextN != null)
            {
                if (Values.ContainsKey(nextN.getValue()))
                    n.setNext(nextN.getNext());
                else
                {
                    Values[nextN.getValue()] = nextN.getValue();
                    n = nextN;
                }
                nextN = nextN.getNext();
            }

            Console.WriteLine("\nAfter removing duplicates :: ");
            PrintSLL(Head);
        }

        public void PairwiseSwap()
        {
            if (Head == null)
            {
                Console.WriteLine("LinkedList is empty !!");
                return;
            }

            Node cur = Head;
            if (cur.getNext() == null)
                Console.WriteLine("Pairwise Swapped List is :: {0}", cur.getValue());

            while (cur != null && cur.getNext() != null)
            {
                int val = cur.getValue();
                cur.setValue(cur.getNext().getValue());
                cur.getNext().setValue(val);

                cur = cur.getNext().getNext();

            }

            Console.WriteLine("\n Pairwise Swapped List is :: ");
            PrintSLL(Head);
        }

        public void IntersectionOfSortedLinkedList()
        {
            var sll1 = new SinglyLinkedList();
            sll1.Head = null;
            var sll2 = new SinglyLinkedList();
            sll2.Head = null;

            for (int i = 0; i < 10; i++)
            {
                sll1.InsertToSLLAtEnd(i);
                sll2.InsertToSLLAtEnd(i * 2);
            }

            sll2.InsertToSLLAtEnd(45);
            Console.WriteLine("\n First Linked List :: ");
            sll1.PrintSLL(sll1.Head);
            Console.WriteLine("\n Second Linked List :: ");
            sll2.PrintSLL(sll2.Head);
            IntersectionOfSortedLinkedList(sll1.Head, sll2.Head);
        }

        private void IntersectionOfSortedLinkedList(Node Head1, Node Head2)
        {

            if (Head1 != null || Head2 != null)
            {
                Console.WriteLine("\n One of the given lists is empty");
                return;
            }

            SinglyLinkedList sll = new SinglyLinkedList();
            sll.Head = null;

            while (Head1 != null && Head2 != null)
            {
                if (Head1.getValue() == Head2.getValue())
                {
                    sll.InsertToSLLAtEnd(Head1.getValue());
                    Head1 = Head1.getNext();
                    Head2 = Head2.getNext();
                }
                else if (Head1.getValue() < Head2.getValue())
                    Head1 = Head1.getNext();
                else
                    Head2 = Head2.getNext();
            }
            Console.WriteLine("\n Intersection of Linked List :: ");
            PrintSLL(sll.Head);
        }

        public void ReverseInGroupsOfGivenSize(int k)
        {
            if (Head == null)
            {
                Console.WriteLine("\n Linked lists is empty");
                return;
            }

            SinglyLinkedList worker = new SinglyLinkedList() { Head = null };
            worker.Head = new Node(Head.getValue());
            SinglyLinkedList master = null;

            Node n = Head.getNext();
            Node lastNode = null;
            int cnt = 1;
            while (n != null)
            {
                if (cnt == k)
                {
                    if (master == null)
                    {
                        master = worker;
                        lastNode = master.Head;
                    }
                    else
                    {
                        lastNode.setNext(worker.Head);
                    }
                    cnt = 1;
                    worker = new SinglyLinkedList() { Head = null };
                    worker.Head = new Node(n.getValue());
                    while (lastNode.getNext() != null)
                        lastNode = lastNode.getNext();
                }
                else
                {
                    worker.InsertToSLLAtBegin(n.getValue());
                    cnt++;
                }
                n = n.getNext();
            }
            lastNode.setNext(worker.Head);
            Console.WriteLine("\nReverse in Groups of size {0} is :: ", k);
            PrintSLL(master.Head);

        }

        public void DeleteSmallerNodesOnLeft()
        {
            if (Head == null)
                Console.WriteLine("LinkedList is Empty !!");

            Node cur = Head;
            Node prev = null;
            Node next = cur.getNext();

            while (next != null)
            {
                if (cur.getValue() < next.getValue())
                {
                    if (cur == Head)
                        Head = next;
                    else
                        prev.setNext(next);
                }
                else
                {
                    prev = cur;
                }
                cur = next;
                next = cur.getNext();
            }

            Console.WriteLine("\n");
            PrintSLL(Head);

        }

        public void AddTwoReversedNumbers()
        {
            SinglyLinkedList sll1 = new SinglyLinkedList();
            sll1.InsertToSLLAtEnd(7);
            sll1.InsertToSLLAtEnd(5);
            sll1.InsertToSLLAtEnd(9);
            sll1.InsertToSLLAtEnd(4);
            sll1.InsertToSLLAtEnd(6);

            SinglyLinkedList sll2 = new SinglyLinkedList();
            sll2.InsertToSLLAtEnd(8);
            sll2.InsertToSLLAtEnd(4);

            AddTwoReversedNumbers(sll1, sll2);

        }

        private void AddTwoReversedNumbers(SinglyLinkedList sll1, SinglyLinkedList sll2)
        {

            Node n1 = sll1.Head;
            Node n2 = sll2.Head;
            SinglyLinkedList resultList = new SinglyLinkedList();
            int carryOver = 0;
            while (n1 != null && n2 != null)
            {
                int sum = n1.getValue() + n2.getValue() + carryOver;
                carryOver = sum / 10;
                sum = sum % 10;
                if (resultList.Head == null)
                    resultList.Head = new Node(sum);
                else resultList.InsertToSLLAtEnd(sum);
                n1 = n1.getNext();
                n2 = n2.getNext();
            }
            while (n1 != null)
            {
                int sum = n1.getValue() + carryOver;
                carryOver = sum / 10;
                sum = sum % 10;
                resultList.InsertToSLLAtEnd(sum);

                n1 = n1.getNext();
            }
            while (n2 != null)
            {
                int sum = n2.getValue() + carryOver;
                carryOver = sum / 10;
                sum = sum % 10;
                resultList.InsertToSLLAtEnd(sum);
                n2 = n2.getNext();

            }
            Console.WriteLine("\nSummed LinkedList is :: ");
            PrintSLL(resultList.Head);

        }

        public void UnionAndIntersection()
        {
            SinglyLinkedList sll1 = new SinglyLinkedList();
            sll1.InsertToSLLAtEnd(10);
            sll1.InsertToSLLAtEnd(15);
            sll1.InsertToSLLAtEnd(4);
            sll1.InsertToSLLAtEnd(20);
            Console.WriteLine("\nSLL1 is :: ");
            PrintSLL(sll1.Head);

            SinglyLinkedList sll2 = new SinglyLinkedList();
            sll2.InsertToSLLAtEnd(8);
            sll2.InsertToSLLAtEnd(4);
            sll2.InsertToSLLAtEnd(2);
            sll2.InsertToSLLAtEnd(10);
            Console.WriteLine("\nSLL2 is :: ");
            PrintSLL(sll2.Head);

            UnionAndIntersection(sll1, sll2);

        }

        private void UnionAndIntersection(SinglyLinkedList sll1, SinglyLinkedList sll2)
        {
            Node n1 = sll1.Head;
            Node n2 = sll2.Head;
            SinglyLinkedList unionList = new SinglyLinkedList();
            SinglyLinkedList intersectionList = new SinglyLinkedList();
            List<int> positions = new List<int>();

            while (n1 != null)
            {
                int val = n1.getValue();
                unionList.InsertToSLLAtEnd(val);

                int pos = 0;
                while (n2 != null)
                {
                    pos++;
                    if (val == n2.getValue())
                    {
                        intersectionList.InsertToSLLAtEnd(val);
                        positions.Add(pos);
                        break;
                    }
                    n2 = n2.getNext();
                }

                n2 = sll2.Head;
                n1 = n1.getNext();
            }

            n2 = sll2.Head;
            int pos1 = 0;
            while (n2 != null)
            {
                pos1++;
                if (!positions.Contains(pos1))
                {
                    unionList.InsertToSLLAtEnd(n2.getValue());
                }
                n2 = n2.getNext();
            }

            Console.WriteLine("\n Union List :: ");
            PrintSLL(unionList.Head);

            Console.WriteLine("\n Intersection List :: ");
            PrintSLL(intersectionList.Head);

        }

        public void AddTwoNumbers()
        {
            SinglyLinkedList sll1 = new SinglyLinkedList();
            sll1.InsertToSLLAtEnd(7);
            sll1.InsertToSLLAtEnd(5);
            sll1.InsertToSLLAtEnd(9);
            sll1.InsertToSLLAtEnd(4);
            sll1.InsertToSLLAtEnd(6);

            SinglyLinkedList sll2 = new SinglyLinkedList();
            sll2.InsertToSLLAtEnd(8);
            sll2.InsertToSLLAtEnd(4);
            //sll2.InsertToSLLAtEnd(2);

            AddTwoNumbers(sll1, sll2);
        }

        public void AddTwoNumbers(SinglyLinkedList sll1, SinglyLinkedList sll2)
        {
            SinglyLinkedList resultList = new SinglyLinkedList();

            Stack<int> num1Stack = new Stack<int>();
            num1Stack.Push(-1);
            Stack<int> num2Stack = new Stack<int>();
            num2Stack.Push(-1);
            Node n1 = sll1.Head;
            Node n2 = sll2.Head;

            while (n1 != null)
            {
                num1Stack.Push(n1.getValue());
                n1 = n1.getNext();
            }

            while (n2 != null)
            {
                num2Stack.Push(n2.getValue());
                n2 = n2.getNext();
            }

            int carryOver = 0;

            while (num1Stack.Peek() != -1 && num2Stack.Peek() != -1)
            {
                int sum = num1Stack.Pop() + num2Stack.Pop() + carryOver;
                carryOver = sum / 10;
                sum = sum % 10;
                resultList.InsertToSLLAtBegin(sum);
            }

            if (num1Stack.Peek() != -1)
            {

                while (num1Stack.Peek() != -1)
                {
                    int sum = num1Stack.Pop() + carryOver;
                    carryOver = sum / 10;
                    sum = sum % 10;
                    resultList.InsertToSLLAtBegin(sum);
                }
            }
            else if (num2Stack.Peek() != -1)
            {
                while (num2Stack.Peek() != -1)
                {
                    int sum = num2Stack.Pop() + carryOver;
                    carryOver = sum / 10;
                    sum = sum % 10;
                    resultList.InsertToSLLAtBegin(sum);
                }
            }
            if (carryOver != 0)
                resultList.InsertToSLLAtBegin(carryOver);
            Console.WriteLine("\nSum is :: ");
            PrintSLL(resultList.Head);
        }
    }
}
