﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.SCALAR.Intermediate_DSA_2
{
    public class Hashing_1
    {
        //Given an integer array A of size N, find the first repeating element in it.
        //We need to find the element that occurs more than once and whose index of the first occurrence is the smallest.
        //If there is no repeating element, return -1.
        int solveHS(List<int> A)
        {
            Dictionary<int, int> numbersHM = new Dictionary<int, int>();
            int repeatedNumber = -1;
            bool found = false;
            for (int i = 0; i < A.Count; i++)
            {
                if (numbersHM.ContainsKey(A[i]))
                {
                    numbersHM[A[i]] = numbersHM[A[i]] + 1;
                }
                else
                {
                    numbersHM.Add(A[i], 1);
                }
            }
            for (int i = 0; i < A.Count; i++)
            {
                if (numbersHM[A[i]] > 1)
                {
                    repeatedNumber = A[i];
                    found = true;
                }
                if (found) break;
            }
            return repeatedNumber;
        }

        //List<int> data = new List<int>();
        //[10, 5, 3, 4, 3, 5, 6];
        //data.Add(10);
        //data.Add(5); data.Add(3); data.Add(4); data.Add(3); data.Add(5); data.Add(6);
        //solveHS(data);



        //Given two integer arrays, A and B of size N and M, respectively. Your task is to find all the common elements in both the array.
        //NOTE:
        //Each element in the result should appear as many times as it appears in both arrays.
        //The result can be in any order.
        List<int> returnCommonEle(List<int> A, List<int> B)
        {
            Dictionary<int, int> mergedArray = new Dictionary<int, int>();
            List<int> result = new List<int>();
            //aded all the element of the first list into merged dictionary - with increamented counter
            for (int i = 0; i < A.Count; i++)
            {
                if (mergedArray.ContainsKey(A[i]))
                {
                    mergedArray[A[i]] = mergedArray[A[i]] + 1;
                }
                else
                {
                    mergedArray.Add(A[i], 1);
                }
            }
            for (int i = 0; i < B.Count; i++)
            {
                if (mergedArray.ContainsKey(B[i]))
                {
                    if (mergedArray[B[i]] > 0)
                    {

                        mergedArray[B[i]] = mergedArray[B[i]] - 1;
                        result.Add(B[i]);
                    }
                }
                //this below add is not required as it will check the pair(Common) with in itself
                // else
                // {
                //     mergedArray.Add(B[i], 1);
                // }
            }
            return result;
        }

        /*
         Given an array A. You have some integers given in the array B.
         For the i-th number, find the frequency of B[i] in the array A and return a list containing all the frequencies.

        Problem Constraints
        1 <= |A| <= 105
        1 <= |B| <= 105
        1 <= A[i] <= 105
        1 <= B[i] <= 105

        Example Input
        Input 1:
        A = [1, 2, 1, 1]
        B = [1, 2]
        Input 2:
        A = [2, 5, 9, 2, 8]
        B = [3, 2]
        
        
        Example Output
        Output 1:
        [3, 1]
        Output 2:
        [0, 2]
         */
        public static List<int> getFrequencyOfB_ArrayElementsInA_Array(List<int> A, List<int> B)
        {
            Dictionary<int, int> frequencyHashMap = new Dictionary<int, int>();
            List<int> result = new List<int>();

            //step 1 : prepare hashmap of the array

            for (int i = 0; i < A.Count; i++)
            {
                if (frequencyHashMap.ContainsKey(A[i]))
                {
                    frequencyHashMap[A[i]] = frequencyHashMap[A[i]] + 1;
                }
                else
                {
                    frequencyHashMap.Add(A[i], 1);
                }
            }
            //step 2: loop throught the B array and check the exitance - if exist then assign the frequency and if not exist then assin 0

            for (int i = 0; i < B.Count; i++)
            {
                if (frequencyHashMap.ContainsKey(B[i])) result.Add(frequencyHashMap[B[i]]);
                else result.Add(0);
            }

            return result;
        }
        /*
         * the output
         * //List<int> A = new List<int> { 6 };
        //List<int> B = new List<int> { 1, 3, 10, 4, 9 };

        //List<int> A = new List<int> { 7, 6, 6, 3, 1, 5, 7 };
        //List<int> B = new List<int> { 2, 1, 7, 5, 8 };
        //var result= DSA_algorithm.SCALAR.Intermediate_DSA_2.Hashing_1.getFrequencyOfB_ArrayElementsInA_Array(A, B);
          */
    }
}
