using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BST");
            BinarySearchTree<int> obj1 = new BinarySearchTree<int>(56);
            obj1.Insert(56);
            obj1.Insert(30);
            obj1.Insert(70);
            obj1.Insert(22);
            obj1.Insert(40);
            obj1.Insert(11);
            obj1.Insert(3);
            obj1.Insert(16);
            obj1.Insert(60);
            obj1.Insert(95);
            obj1.Insert(65);
            obj1.Insert(63);
            obj1.Insert(67);
            obj1.Display();
            obj1.GetSize();
            Console.ReadLine();
        }
    }
}
