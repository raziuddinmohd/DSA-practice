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
            node.Next=this.Head;
            this.Head=node;

        }


    }
}
