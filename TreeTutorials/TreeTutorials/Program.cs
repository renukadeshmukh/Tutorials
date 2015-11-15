using System;
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

            Node<int> root = new Node<int>(1);
            root.Left = new Node<int>(2);
            root.Left.Left = new Node<int>(4);
            root.Left.Right = new Node<int>(5);
            
            root.Right = new Node<int>(3);
            root.Right.Right = new Node<int>(8);
            root.Right.Left = new Node<int>(8);
            root.Right.Right.Right = new Node<int>(9);
            

            tt.LevelorderTraversalNewLine(root);
            bool flag = tl.CheckBalancedBinaryTree(root);
            Console.WriteLine("\n" + flag);
            Console.ReadKey();
        }
    }
}
