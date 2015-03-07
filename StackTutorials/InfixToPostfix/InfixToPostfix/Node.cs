using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfixToPostfix
{
    public class Node
    {
        //public int Value { get; set; }
        private Node _next { get; set; }

        private string _value;

        public string Value
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


        public Node(string val)
        {
            Value = val;
            Next = null;
        }
    }
}
