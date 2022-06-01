using System;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearch<int> binarySearchTree = new BinarySearch<int>(56);
            binarySearchTree.AddNode(30);
            binarySearchTree.AddNode(70);
            binarySearchTree.AddNode(22);
            binarySearchTree.AddNode(40);
            binarySearchTree.AddNode(60);
            binarySearchTree.AddNode(95);
            binarySearchTree.AddNode(11);
            binarySearchTree.AddNode(65);
            binarySearchTree.AddNode(3);
            binarySearchTree.AddNode(16);
            binarySearchTree.AddNode(67);
            binarySearchTree.AddNode(63);
            binarySearchTree.Display();
            Console.WriteLine("\n");
            binarySearchTree.Getsize();
        }
    }
    
}
