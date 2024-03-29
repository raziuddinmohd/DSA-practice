﻿using DSA_algorithm.LinkedList;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
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
                Console.WriteLine(" ");
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

        //Q4.Delete in Linked List
        //Problem Description
        //You are given the head of a linked list A and an integer B.Delete the B-th node from the linked list.

        //Note : Follow 0-based indexing for the node numbering.



        //Problem Constraints
        //1 <= size of linked list <= 105
        //1 <= value of nodes <= 109
        //0 <= B<size of linked list



        //Input Format
        //The first argument A is the head of a linked list.

        //The second arguement B is an integer.



        //Output Format
        //Return the head of the linked list after deletion



        //Example Input
        //Input 1:
        //A = 1 -> 2 -> 3
        //B = 1
        //Input 2:
        //A = 4 -> 3 -> 2 -> 1
        //B = 0


        //Example Output
        //Output 1:
        //1 -> 3
        //Output 2:
        //3 -> 2 -> 1


        //Example Explanation
        //For Input 1:
        //The linked list after deletion is 1 -> 3.
        //For Input 2:
        //The linked list after deletion is 3 -> 2 -> 1.
        public ListNode DeleteAtPosition(ListNode A, int B)
        {
            if (B == 0)
            {
                return A.next;
            }

            ListNode currNode = A;
            ListNode temp;
            int counter = 0;
            while (currNode != null)
            {
                if (counter == B - 1)
                {
                    //last node case
                    //if (currNode.next.next == null)
                    //{
                    //    currNode.next = null;
                    //    return A;
                    //    //break;
                    //}
                    //if (currNode.next.next && currNode.next.next.next==null)
                    //{
                    //    //other than last node


                    //}
                    if (currNode != null && currNode.next != null && currNode.next.next != null)
                    {
                        currNode.next = currNode.next.next;
                    }
                    else
                    {
                        currNode.next = null;
                    }
                }
                counter++;
                currNode = currNode.next;
            }
            return A;
        }

        public int CompareLL(ListNode A, ListNode B)
        {
            ListNode firstLL = A;
            ListNode secondLL = B;
            int firstLL_length = 0;
            int secondLL_length = 0;
            while (firstLL.next != null)
            {
                firstLL = firstLL.next;
                firstLL_length++;
            }
            while (secondLL.next != null)
            {
                secondLL = secondLL.next;
                secondLL_length++;
            }
            if (firstLL_length != secondLL_length) return 0;
            firstLL = A;
            secondLL = B;
            while (firstLL.next != null && secondLL.next != null)
            {
                if (firstLL.val == secondLL.val)
                {
                    firstLL = firstLL.next;
                    secondLL = secondLL.next;
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }
        public static List<long> rangeSum(List<int> A, List<List<int>> B)
        {
            //List<int> pSum = new List<int>();
            List<long> pSum = new List<long>(); //when we create sum of two maximum int numner it could be long 

            List<long> resultArray = new List<long>();
            pSum.Add(A[0]);
            for (int i = 1; i < A.Count; i++)
            {
                pSum.Add(pSum[i - 1] + A[i]);
            }
            int queryindex = 0;
            int leftHandIndex = -1;
            int rightHandIndex = -1;
            while (queryindex < B.Count)
            {
                leftHandIndex = B[queryindex][0];
                rightHandIndex = B[queryindex][1];
                if (leftHandIndex == 0)
                {
                    resultArray.Add(pSum[rightHandIndex]);
                }
                else
                {
                    resultArray.Add(pSum[rightHandIndex] - pSum[leftHandIndex - 1]);
                }
                // }

                //}

                queryindex++;

            }
            return resultArray;
        }
    }
  
}
