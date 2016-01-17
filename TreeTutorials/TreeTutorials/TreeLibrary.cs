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
            if (root == null)
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

        /*
         * Given a binary tree, print out all of its root-to-leaf paths one per line
         */
        public void PrintRootToLeafPaths(Node<int> root, string path)
        {
            if (root.Left == null && root.Right == null)
            {
                Console.WriteLine(path.Trim() + " " + root.Value);
            }
            else
            {
                path = path + " " + root.Value;
                PrintRootToLeafPaths(root.Left, path);
                PrintRootToLeafPaths(root.Right, path);
            }
        }

        /*
         * A node is a leaf node if both left and right child nodes of it are NULL
         */
        public int NumberOfLeafNodes(Node<int> root)
        {
            if (root == null)
                return 0;
            else if (root.Left == null && root.Right == null)
                return 1;
            else return (NumberOfLeafNodes(root.Left) + NumberOfLeafNodes(root.Right));
        }

        public bool CheckChildrenSumProperty(Node<int> root)
        {
            if (root == null || (root.Left == null && root.Right == null))
                return true;
            int leftVal = root.Left == null ? 0 : root.Left.Value;
            int rightVal = root.Right == null ? 0 : root.Right.Value;
            if (root.Value == leftVal + rightVal)
            {
                return CheckChildrenSumProperty(root.Left) && CheckChildrenSumProperty(root.Right);
            }
            else
                return false;
        }

        public void BalanceChildrenSumProperty(Node<int> root)
        {
            if (root == null || (root.Left == null && root.Right == null))
                return;
            BalanceChildrenSumProperty(root.Left);
            BalanceChildrenSumProperty(root.Right);

            int leftVal = root.Left == null ? 0 : root.Left.Value;
            int rightVal = root.Right == null ? 0 : root.Right.Value;
            int diff = root.Value - (leftVal + rightVal);
            if (diff == 0)
            {
                return;
            }
            else if (diff < 0)
            {
                root.Value = root.Value - diff;
            }
            else
            {
                if (root.Left != null)
                {
                    root.Left.Value += diff;
                    BalanceChildrenSumProperty(root.Left);
                }
                else
                {
                    root.Right.Value += diff;
                    BalanceChildrenSumProperty(root.Right);
                }

            }

        }

        /*
         * The diameter of a tree (sometimes called the width) is the 
         * number of nodes on the longest path between two leaves in the tree.
         */
        public int GetDiameterofBinaryTree(Node<int> root)
        {
            if (root == null)
                return 0;
            int left = GetDiameterofBinaryTree(root.Left);
            int right = GetDiameterofBinaryTree(root.Right);
            int max = Math.Max( left , right); 
            return max = Math.Max(max , MaxHeightOfTree(root.Left) + MaxHeightOfTree(root.Right) +1 );
        }

        /*
         * To check if a tree is height-balanced, get the height of left 
         * and right subtrees. Return true if difference between heights is 
         * not more than 1 and left and right subtrees are balanced, otherwise 
         * return false.
         */
        public bool CheckBalancedBinaryTree(Node<int> root)
        {
            if (root == null)
                return true;
            int leftHt = MaxHeightOfTree(root.Left);
            int rightHt = MaxHeightOfTree(root.Right);
            int diff = leftHt - rightHt;
            if (diff > -2 && diff < 2)
            {
                return CheckBalancedBinaryTree(root.Left) && CheckBalancedBinaryTree(root.Right);
            }
            else return false;
        }

        private bool HasPathSum(Node<int> root, int sum, int calculatedSum)
        {
            if (root == null)
            {
                if (calculatedSum == sum)
                    return true;
                return false;
            }
            calculatedSum += root.Value;
            return HasPathSum(root.Left, sum, calculatedSum) || HasPathSum(root.Right, sum, calculatedSum);
        }

        /*
         * Given a binary tree and a number, return true if the tree has 
         * a root-to-leaf path such that adding up all the values along 
         * the path equals the given number. Return false if no such path 
         * can be found.
         */
        public bool HasPathSum(Node<int> root, int sum)
        {
            if (root == null && sum == 0)
                return true;
            else
                return HasPathSum(root, sum, 0);
        }

        public Node<int> BuildTreeFromInAndPre(string inorder, string preorder, Node<int> root)
        {
            if (preorder.Length > 0)
            {
                char n = preorder[0];
                int node = Int32.Parse(n.ToString());
                root = new Node<int>(node);
                preorder = preorder.Substring(1);

                string inleft = string.Empty, inright = string.Empty;
                bool flag = false;
                Dictionary<char, int> ignoreDict = new Dictionary<char, int>();
                for (int i = 0; i < inorder.Length; i++)
                {
                    if (inorder[i] == n)
                    {
                        flag = true;
                        continue;
                    }

                    if (flag == false)
                    {
                        inleft = string.Concat(inleft, inorder[i]);
                        ignoreDict.Add(inorder[i], 0);
                    }
                    else
                        inright = string.Concat(inright, inorder[i]);
                    
                }
                string preleft = string.Empty, preright = string.Empty;
                for (int i = 0; i < preorder.Length; i++)
                {
                    if(ignoreDict.ContainsKey(preorder[i]))
                        preleft = string.Concat(preleft, preorder[i]);
                    else
                        preright = string.Concat(preright, preorder[i]);
                }

                root.Left = BuildTreeFromInAndPre(inleft, preleft, root.Left);
                root.Right = BuildTreeFromInAndPre(inright, preright, root.Right);
            }
            return root;
        }

        /*
         *To create Double tree of the given tree, create a new duplicate for each node, and insert 
         *the duplicate as the left child of the original node
         */
        public void DoubleTree(Node<int> root)
        {
            if (root != null)
            {
                Node<int> newNode = new Node<int>(root.Value);
                newNode.Left = root.Left;
                root.Left = newNode;
                DoubleTree(root.Left.Left);
                DoubleTree(root.Right);
            }
            
        }

        /*
        A tree can be folded if left and right subtrees of the tree are structure wise mirror image 
        of each other. An empty tree is considered as foldable.
        */
        public bool IsFoldable(Node<int> root)
        {
            if (root == null)
                return true;
            else return IsFoldable(root.Left, root.Right);
        }

        private bool IsFoldable(Node<int> root1, Node<int> root2)
        {
            if (root1 == null && root2 == null)
                return true;
            else if (root1 == null && root2 != null)
                return false;
            else if (root1 != null && root2 == null)
                return false;
            else return (IsFoldable(root1.Left, root2.Right) && IsFoldable(root1.Right, root2.Left));

        }
    }
}
