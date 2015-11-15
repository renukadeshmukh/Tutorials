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
            root.Left.Right.Left = new Node<int>(6);
            root.Left.Right.Right = new Node<int>(7);

            root.Right = new Node<int>(3);
            root.Right.Right = new Node<int>(8);
            root.Right.Right.Right = new Node<int>(9);
            root.Right.Right.Right.Left = new Node<int>(10);
            root.Right.Right.Right.Right = new Node<int>(11);
            root.Right.Right.Right.Left.Left = new Node<int>(12);
            root.Right.Right.Right.Left.Right = new Node<int>(13);



            tt.LevelorderTraversalNewLine(root);
            int diam = tl.GetDiameterofBinaryTree(root);
            Console.WriteLine("\n" + diam);
            Console.ReadKey();
        }
    }
}
