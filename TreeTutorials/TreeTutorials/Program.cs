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
            Console.WriteLine("Inorder Tree Traversal :: ");
            tt.InorderTraversal(root);

            tl.MirrorATree(root);
            Console.WriteLine("Inorder Mirror Tree Traversal :: ");
            tt.InorderTraversal(root);
            Console.ReadKey();
        }
    }
}
