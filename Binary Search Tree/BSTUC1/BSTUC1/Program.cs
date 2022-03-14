using System;
using static BSTUC1.MapNode;

namespace BSTUC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BTS Operation");
            Console.WriteLine("1.Insertion.");
            
            int num = Convert.ToInt32(Console.ReadLine());
            BST<int> binarySearchTree = new BST<int>(56);
            switch (num)
            {
                case 1:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
