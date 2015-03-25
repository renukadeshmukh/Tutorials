﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTutorials
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Left { get; set; }

        public Node(T val)
        {
            Value = val;
            Right = null;
            Left = null;
        }
    
    }
}
