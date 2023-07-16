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
                Console.WriteLine(curNode.val + " ");
                curNode = curNode.next;
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
        public static int SearchLL(ListNode A, int B)
        {
            ListNode curNode = A;
            bool found = false;
            while (curNode != null)
            {
                if (curNode.val == B)
                {
                    found = true;
                }
                if (found) break;
                curNode = curNode.next;
            }
            return found ? 1 : 0;
        }
        /*
         Q3. Insert in Linked List
        Problem Description
        You are given A which is the head of a linked list. Also given is the value B and position C. Complete the function that should insert a new node with the said value at the given position.
        
        Notes:
        
        In case the position is more than length of linked list, simply insert the new node at the tail only.
        In case the pos is 0, simply insert the new node at head only.
        Follow 0-based indexing for the node numbering.
        
        
        Problem Constraints
        1 <= size of linked list <= 105
        
        1 <= value of nodes <= 109
        
        1 <= B <= 109
        
        0 <= C <= 105
        
        
        
        Input Format
        The first argument A is the head of a linked list.
        
        The second argument B is an integer which denotes the value of the new node
        
        The third argument C is an integer which denotes the position of the new node
        
        
        
        Output Format
        Return the head of the linked list
        
        
        Example Input
        Input 1:
        A = 1 -> 2
        B = 3
        C = 0
        Input 2:
        A = 1 -> 2
        B = 3
        C = 1
        
        
        Example Output
        Output 1:
        3 -> 1 -> 2
        Output 2:
        1 -> 3 -> 2

         */
        public ListNode InsertAtPosition(ListNode A, int B, int C)
        {
            ListNode currNode = A;
            int counter = 0;
            ListNode newNode = new ListNode(B);
            //insert at first position
            if (C == 0)
            {
                newNode.next = currNode;
                /*if inserted at 0th index then new node will be the head*/
                return newNode;
            }
            bool inserted = false;
            ListNode tempNode;
            while (currNode != null)
            {
                if (counter == C - 1)
                {
                    tempNode = currNode.next;
                    currNode.next = newNode;
                    newNode.next = tempNode;
                    inserted = true;

                    /*
                     * this code will not work(you can recall reference/address concept)
                     * when we assign the currNode, it will store the address of the current node
                     * when you change the next of the currNode then both i.e tempNode and currNode
                     * next value will be same
                     tempNode = currNode;
                    currNode.next = newNode;
                    newNode.next = tempNode.next;
                    inserted = true;
                     */
                }
                else if (currNode.next == null)
                {
                    currNode.next = newNode; 
                    inserted = true;
                }
                else
                {
                    currNode = currNode.next;
                    counter++;
                }
                if (inserted) break;

            }

            return A;
        }
    }
}
