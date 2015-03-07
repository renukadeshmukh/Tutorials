using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node
    {
        //public int Value { get; set; }
        private Node _next { get; set; }

        private int _value;

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public Node Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }
        
        
        public Node(int val)
        {
            Value = val;
            Next = null;
        }
    }
}
