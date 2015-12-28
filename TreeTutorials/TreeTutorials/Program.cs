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

            //A=1;B=2;C=3;D=4;E=5;F=6;
            string inorder = "425163";
            string preorder = "124536";
            Node<int> root = null;
            root = tl.BuildTreeFromInAndPre(inorder, preorder, root);

            tt.InorderTraversal(root);
           
            Console.ReadKey();
        }
    }
}
