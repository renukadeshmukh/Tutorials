using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTutorials
{
    public class TreeLibrary
    {
        //Size of a tree is the number of elements present in the tree.
        public int SizeOfTree(Node<int> root)
        {
            if (root == null)
                return 0;
            else
                return 1 + SizeOfTree(root.Left) + SizeOfTree(root.Right);
        }

        /*
         Two trees are identical when they have same data and arrangement of data is also same.

         To identify if two trees are identical, we need to traverse both trees simultaneously, 
         and while traversing we need to compare data and children of the trees.
         */
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

        /*
         * Recursively calculate height of left and right subtrees of a node and assign height to the 
         * node as max of the heights of two children plus 1. 
         */
        public int MaxHeightOfTree(Node<int> root)
        {
            if(root == null)
                return 0;
            else 
                return 1 + Math.Max(MaxHeightOfTree(root.Left), MaxHeightOfTree(root.Right));
        }


        public void DeleteTree(Node<int> root)
        {
            root = null;
        }

        /*
         * Mirror of a Tree: Mirror of a Binary Tree T is another Binary Tree M(T) with left and right 
         * children of all non-leaf nodes interchanged.
         */
        public Node<int> MirrorATree(Node<int> root)
        {
            if (root == null)
                return null;
            else
            {
                Node<int> leftsubtree = root.Left;
                root.Left = MirrorATree(root.Right);
                root.Right = MirrorATree(leftsubtree);
            }
            return root;
        }
    }
}
