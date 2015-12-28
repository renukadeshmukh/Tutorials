using System;
using TreeTutorials;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeTutorials.Test
{
    [TestClass]
    public class TreeTraversalTest
    {
        TreeTraversal tt = new TreeTraversal();
        TreeLibrary tl = new TreeLibrary();

        [TestMethod]
        public void PreorderTraversalTest()
        {
            tt.PreorderTraversal();
        }

        [TestMethod]
        public void PostorderTraversalTest()
        {
            tt.PostorderTraversal();
        }

        [TestMethod]
        public void InorderTraversalTest()
        {
            tt.InorderTraversal();
        }

        [TestMethod]
        public void GetTreeSizeTest()
        {
            Node<int> root = tt.CreateBinaryTree();
            int size = tl.SizeOfTree(root);
            Console.WriteLine("Size of tree is ::" + size);
            Assert.AreEqual(10, size);
        }

        [TestMethod]
        public void EqualTreeTestForSameTree()
        {
            Node<int> root1 = tt.CreateBinaryTree();
            Node<int> root2 = tt.CreateBinaryTree();
            bool equal = tl.AreTreesEqual(root1, root2);
            //Console.WriteLine("Size of tree is ::" + size);
            Assert.AreEqual(true , equal);
        }

        [TestMethod]
        public void EqualTreeTestForDifferentTree()
        {
            Node<int> root1 = tt.CreateBinaryTree();
            Node<int> root2 = tt.CreateFullBinaryTree();
            bool equal = tl.AreTreesEqual(root1, root2);
            //Console.WriteLine("Size of tree is ::" + size);
            Assert.AreEqual(true, equal);
        }

        [TestMethod]
        public void MaxHeightofTreeTest()
        {
            Node<int> root = tt.CreateBinaryTree();
            int height = tl.MaxHeightOfTree(root);
            //Console.WriteLine("Size of tree is ::" + size);
            Assert.AreEqual(4, height);
        }

        [TestMethod]
        public void NumOfLeafNodesTest()
        {
            Node<int> root = tt.CreateBinaryTree();
            int num = tl.NumberOfLeafNodes(root);
            //Console.WriteLine("Size of tree is ::" + size);
            Assert.AreEqual(5, num);
        }

        [TestMethod]
        public void ChildrenCheckSumTest()
        {
            Node<int> root = new Node<int>(10);
            root.Left = new Node<int>(8);
            root.Left.Left = new Node<int>(3);
            root.Left.Right = new Node<int>(5);
            
            root.Right = new Node<int>(2);
            root.Right.Left = new Node<int>(2);

            bool check = tl.CheckChildrenSumProperty(root);
            Assert.IsTrue(check);
            
        }

        [TestMethod]
        public void ChildrenCheckSumFailTest()
        {
            Node<int> root = new Node<int>(10);
            root.Left = new Node<int>(8);
            root.Left.Left = new Node<int>(3);
            root.Left.Right = new Node<int>(5);

            root.Right = new Node<int>(2);
            root.Right.Left = new Node<int>(2);
            root.Right.Right = new Node<int>(2);

            bool check = tl.CheckChildrenSumProperty(root);
            Assert.IsFalse(check);

        }

        [TestMethod]
        public void HasPathSumTest()
        {
            Node<int> root = new Node<int>(10);
            root.Left = new Node<int>(8);
            root.Left.Left = new Node<int>(3);
            root.Left.Right = new Node<int>(5);

            root.Right = new Node<int>(2);
            root.Right.Left = new Node<int>(2);
            
            bool check = tl.HasPathSum(root, 21);
            Assert.IsTrue(check);

            check = tl.HasPathSum(root, 20);
            Assert.IsFalse(check);

        }
    }
}
