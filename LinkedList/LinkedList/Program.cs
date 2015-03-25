using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //TrySLL();
            TryCLL();
            Console.ReadKey();

        }

        public static void TryCLL()
        {
            CircularLinkedList cll = new CircularLinkedList();
            cll.CreateCLL();
        }

        public static void TrySLL()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.CreateSLL();

            //int midElement = sll.GetMiddleElement();
            //Console.WriteLine("Middle Element is :: {0}", midElement);

            //int lastNth = sll.GetNthFromEnd(4);
            //Console.WriteLine("Last 4th Element is :: {0}", lastNth);

            //int lastNth1 = sll.GetNthFromEnd(8);
            //Console.WriteLine("Last 8th Element is :: {0}", lastNth1);

            //int lastNth2 = sll.GetNthFromEnd(10);
            //Console.WriteLine("Last 10th Element is :: {0}", lastNth2);

            //bool isPalin = sll.IsSLLPalindrome();
            //Console.WriteLine("\nIs the list palindrome :: {0}", isPalin);

            //sll.ReversePrint();

            //sll.RemoveDuplicatesFromLinkedList();
            //sll.PairwiseSwap();

            //sll.IntersectionOfSortedLinkedList();

            // sll.ReverseInGroupsOfGivenSize(3);

            //sll.DeleteSmallerNodesOnLeft();

            //sll.UnionAndIntersection();
            sll.AddTwoNumbers();
            
        }
    }
}
