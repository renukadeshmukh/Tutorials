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
            Assert.AreEqual(false, equal);
        }

        [TestMethod]
        public void MaxHeightofTreeTest()
        {
            Node<int> root = tt.CreateBinaryTree();
            int height = tl.MaxHeightOfTree(root);
            //Console.WriteLine("Size of tree is ::" + size);
            Assert.AreEqual(4, height);
        }
    }
}
