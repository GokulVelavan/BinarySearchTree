using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; } 
        public BinarySearchTree<T> LeftTree { get; set; } 
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)  // constructor 
        {
            this.NodeData = nodeData; 
            this.LeftTree = null; 
            this.RightTree = null; 
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData; //creation of new node

            if ((currentNodeValue.CompareTo(item)) > 0) 
            {
                if (this.LeftTree == null) 
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                    this.LeftTree.Insert(item); //adding in left tree
            }
            else
            {
                if (this.RightTree == null) 
                {
                    this.RightTree = new BinarySearchTree<T>(item);
                }
                else
                    this.RightTree.Insert(item); //adding in right tree
            }
        }

        public void Display()//program to diplay the node data
        {
            if (this.LeftTree != null)
            {
                this.leftCount++; 
                this.LeftTree.Display(); 
            }
            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display(); 
            }
        }
    }
}
