using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTutorials
{
    public class TreeTraversal
    {
        public Node<int> RootCompleteTree { get; set; }
        public Node<int> RootFullTree { get; set; }
        public Node<int> RootTree { get; set; }

        public void CreateTree()
        {
            #region create complete binary tree
            RootCompleteTree = CreateCompleteBinaryTree();
            #endregion

            #region create full binary tree
            RootFullTree = CreateFullBinaryTree();
            #endregion

            #region create binary tree
            RootTree = CreateBinaryTree();
            #endregion
        }

        public Node<int> CreateCompleteBinaryTree()
        {
            Node<int> root = new Node<int>(4);
            root.Left = new Node<int>(5);
            root.Right = new Node<int>(6);
            root.Right.Left = new Node<int>(7);
            root.Right.Right = new Node<int>(8);

            return root;
        }

        public Node<int> CreateFullBinaryTree()
        {
            Node<int> root = new Node<int>(18);
            root.Left = new Node<int>(15);
            root.Left.Left = new Node<int>(40);
            root.Left.Right = new Node<int>(50);
            root.Left.Left.Left = new Node<int>(8);
            root.Left.Left.Right = new Node<int>(7);
            root.Left.Right.Left = new Node<int>(9);

            root.Right = new Node<int>(30);
            root.Right.Left = new Node<int>(100);
            root.Right.Right = new Node<int>(40);

            return root;
        }

        public Node<int> CreateBinaryTree()
        {
            Node<int> root = new Node<int>(18);
            root.Left = new Node<int>(15);
            root.Left.Left = new Node<int>(40);
            root.Left.Right = new Node<int>(50);
            root.Left.Left.Left = new Node<int>(8);
            //root.Left.Left.Right = new Node<int>(7);
            root.Left.Right.Left = new Node<int>(9);

            root.Right = new Node<int>(30);
            root.Right.Left = new Node<int>(100);
            //root.Right.Right = new Node<int>(40);

            return root;
        }
    }
}
