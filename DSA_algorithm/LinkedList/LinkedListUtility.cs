using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.LinkedList
{
    public class LinkedListUtility
    {
        public Node? Head = null;
        public LinkedListUtility()
        {
            this.Head = new Node();
            this.Head.Next = null;

        }
        public void InsertFirst(int data)
        {
            Node node = new Node();
            node.Data = data;
            node.Next = this.Head;
            this.Head = node;

        }

        public Node DeleteFirst()
        {
            if (Head?.Next != null)
            {
                Node temp = Head.Next;
                Head = temp;
                return temp;

            }
            return new Node();// here I need to send some message , that there is not element in the link list
        }

        public void DisplayData()
        {
            Console.WriteLine("printing the list items");
            Node currentNode = this.Head!;
            //here if we check the condition currentNode.Next!=null then the last element would be missed.
            while (currentNode != null)
            {
                currentNode.Display();
                currentNode = currentNode.Next;
            }
        }
        public void InsertLast(int data)
        {
            Node currentNode = this.Head;
            while (currentNode?.Next != null)
            {
                currentNode = currentNode.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;
            currentNode.Next = newNode;
        }

        public void DeleteLast()
        {
            Node currentNode = this.Head;
            while (currentNode?.Next?.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = null;
        }

    }
}
