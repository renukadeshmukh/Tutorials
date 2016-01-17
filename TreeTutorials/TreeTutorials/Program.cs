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


            Node<int> root = new Node<int>(10);
            root.Left = new Node<int>(7);
            root.Right = new Node<int>(15);
            root.Left.Left = new Node<int>(9);
            root.Right.Left = new Node<int>(11);

            bool res = tl.IsFoldable(root);
            Console.WriteLine(  res);
            Console.ReadKey();
        }
    }
}
