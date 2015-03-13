using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
            Next = null;
        }
    }
}
