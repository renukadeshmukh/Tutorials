﻿using System;
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

        public void PreorderTraversal()
        {
            PreorderTraversal(RootCompleteTree);
            PreorderTraversal(RootFullTree);
            PreorderTraversal(RootTree);
        }

        public void PreorderTraversal(Node<int> root)
        {
            if (root == null)
                return;
            else
            {
                Console.WriteLine(root.Value);
                PreorderTraversal(root.Left);
                PreorderTraversal(root.Right);
            }
        }

        public void InorderTraversal()
        {
            InorderTraversal(RootCompleteTree);
            InorderTraversal(RootFullTree);
            InorderTraversal(RootTree);
        }

        public void InorderTraversal(Node<int> root)
        {

            if (root == null)
                return;
            else
            {
                InorderTraversal(root.Left);
                Console.WriteLine(root.Value);
                InorderTraversal(root.Right);
            }
        }

        public void PostorderTraversal()
        {
            PostorderTraversal(RootCompleteTree);
            PostorderTraversal(RootFullTree);
            PostorderTraversal(RootTree);
        }

        public void PostorderTraversal(Node<int> root)
        {
            if (root == null)
                return;
            else
            {
                PostorderTraversal(root.Left);
                PostorderTraversal(root.Right);
                Console.WriteLine(root.Value);
            }
        }

        /*
         * Level order traversal of a tree is breadth first traversal for the tree
         */
        public void LevelorderTraversal(Node<int> root)
        {
            if (root == null)
                return;
            Queue<Node<int>> queue = new Queue<Node<int>>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Node<int> elem = queue.Dequeue();

                if (elem != null)
                {
                    Console.Write(" " + elem.Value);
                    queue.Enqueue(elem.Left);
                    queue.Enqueue(elem.Right);
                    
                }
                
            }
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
            root.Left.Left.Right = new Node<int>(7);
            //root.Left.Right.Left = new Node<int>(9);

            root.Right = new Node<int>(30);
            root.Right.Left = new Node<int>(100);
            root.Right.Right = new Node<int>(40);

            return root;
        }

    }
}
