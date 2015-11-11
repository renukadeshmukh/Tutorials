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
            Node<int> root = tt.CreateBinaryTree();
            int size = tl.SizeOfTree(root);
            Console.WriteLine("Size of tree is ::" + size);
            Console.ReadKey();
        }
    }
}
