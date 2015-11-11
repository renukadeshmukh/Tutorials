using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTutorials
{
    public class TreeLibrary
    {
        public int SizeOfTree(Node<int> root)
        {
            if (root == null)
                return 0;
            else
                return 1 + SizeOfTree(root.Left) + SizeOfTree(root.Right);
        }

        public bool AreTreesEqual(Node<int> root1, Node<int> root2)
        {
            if (root1 == null && root2 == null)
                return true;
            else if ((root1 == null && root2 != null) || (root2 == null && root1 != null))
                return false;
            else if (root1.Value != root2.Value)
                return false;
            else
                return (AreTreesEqual(root1.Left, root2.Left) && AreTreesEqual(root1.Right, root2.Right));
        }

        public int MaxHeightOfTree(Node<int> root)
        {

        }
    }
}
