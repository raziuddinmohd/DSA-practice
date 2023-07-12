using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.SCALAR.Intermediate_DSA_2
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int x) { this.val = x; this.next = null; }
    }
    public class LinkedListProbs
    {
        /*
         * Q1. Print Linked List
            Problem Description
            You are given A which is the head of a linked list. Print the linked list in space separated manner.
            
            Note : The last node value must also be succeeded by a space and after printing the entire list you should print a new line
            
            
            
            Problem Constraints
            1 <= size of linked list <= 105
            
            1 <= value of nodes <= 109
            
            
            
            Input Format
            The first argument A is the head of a linked list.
            
            
            Output Format
            You dont need to return anything
            
            
            Example Input
            Input 1:
            A = 1 -> 2 -> 3
            Input 2:
            A = 4 -> 3 -> 2 -> 1
            
            
            Example Output
            Output 1:
            1 2 3
            Output 2:
            4 3 2 1
         */
        public static void PrintLL(ListNode A)
        {
            ListNode curNode = A;
            while (curNode != null)
            {
                Console.Write(curNode.val+" ");
                curNode = curNode.next!=null? curNode.next:null;
            }
        }
        /*
         * Q2. Search in Linked List
         * Problem Description
            You are given the head of a linked list A and an integer B, check if there is any node which contains this value B.
            
            Return 1 if such a node is present else return 0.
            
            
            
            Problem Constraints
            1 <= size of linked list <= 105
            1 <= value of nodes <= 109
            1 <= B <= 109
            
            
            
            Input Format
            The first argument A is the head of a linked list.
            
            The second arguement B is an integer.
            
            
            
            Output Format
            Return 1 if such a node is present otherwise return 0.
            
            
            Example Input
            Input 1:
            A = 1 -> 2 -> 3
            B = 4
            Input 2:
            A = 4 -> 3 -> 2 -> 1
            B = 4
            
            
            Example Output
            Output 1:
            0
            Output 2:
            1
         */
        public static int SearchLL(ListNode A,int B)
        {
            ListNode curNode = A;
            bool found = false;
            while (curNode != null)
            {
                if(curNode.val==B)
                {
                    found = true;
                }
                if (found) break;
                curNode = curNode.next;
            }
            return found ? 1 : 0;
        }
    }
}
