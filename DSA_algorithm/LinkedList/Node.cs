using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public void Display()
        {
            Console.WriteLine(this.Data);
        }
    }
}
