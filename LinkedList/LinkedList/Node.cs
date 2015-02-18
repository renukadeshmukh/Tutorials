using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        int Value;
        Node Next;

        public Node(int val)
        {
            Value = val;
            Next = null;
        }

        public int getValue()
        { return Value; }


        public void setValue(int val)
        { Value = val; }

        public Node getNext()
        { return Next; }

        public void setNext(Node next)
        { Next = next; }

    }
}
