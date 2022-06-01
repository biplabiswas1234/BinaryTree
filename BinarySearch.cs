using System;
using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using System.Threading.Tasks;
namespace BinarySearchTree
{

        public class BinarySearch<K> where K : IComparable
        {
            public K NodeData;
            public BinarySearch<K> Left;
            public BinarySearch<K> Right;
            public BinarySearch(K Nodedata)
            {
                this.NodeData = Nodedata;
                this.Left = null;
                this.Right = null;
            }
            int LeftCount = 0;
            int RightCount = 0;
            public void AddNode(K item)
            {
                K CurrentNode = NodeData;   //56
                if (item.CompareTo(CurrentNode) < 0)
                {
                    if (this.Left == null)
                    {
                        Left = new BinarySearch<K>(item);
                    }
                    else
                    {
                        Left.AddNode(item);
                    }
                    LeftCount++;
                }
                else
                {
                    if (this.Right == null)
                    {
                        Right = new BinarySearch<K>(item);
                    }
                    else
                    {
                        Right.AddNode(item);
                    }
                    RightCount++;
                }
            }
            public void Getsize()
            {
                Console.WriteLine("Size of the Binary Tree :" + (LeftCount + RightCount + 1));
            }
            public void Display()
            {
                if (this.Left != null)
                {
                    Left.Display();
                }
                Console.Write("  ");
                Console.Write(this.NodeData);
                Console.Write("  ");
                if (this.Right != null)
                {
                    Right.Display();
                }
            }
        }
    }