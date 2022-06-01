using System;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearch<int> binarySearch = new BinarySearch<int>(56);
            binarySearch.AddNode(30);
            binarySearch.AddNode(70);
            binarySearch.AddNode(22);
            binarySearch.AddNode(40);
            binarySearch.AddNode(60);
            binarySearch.AddNode(95);
            binarySearch.AddNode(11);
            binarySearch.AddNode(65);
            binarySearch.AddNode(3);
            binarySearch.AddNode(16);
            binarySearch.AddNode(67);
            binarySearch.AddNode(63);
            binarySearch.Display();
            Console.WriteLine("\n");
            binarySearch.Getsize();
            binarySearch.Search(63, binarySearch);
            //binarySearch.Search(62, binarySearch);

        }
    }

}
