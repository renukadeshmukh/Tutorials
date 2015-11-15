﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeTraversal tt = new TreeTraversal();
            TreeLibrary tl = new TreeLibrary();
            Node<int> root = tt.CreateBinaryTree();
            tt.SpiralTraversal(root);
            tl.BalanceChildrenSumProperty(root);
            tt.SpiralTraversal(root);
            Console.ReadKey();
        }
    }
}
