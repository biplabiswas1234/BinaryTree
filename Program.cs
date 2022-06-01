using System;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearch<int> binarySearch = new BinarySearch<int>(56);
            binarySearch.AddNode(30);
            binarySearch.AddNode(70);
            binarySearch.Display();

        }
    }
    
}
