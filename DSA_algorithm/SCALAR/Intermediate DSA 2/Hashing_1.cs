using System;
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

        #region get frequency of B element in As array
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
        #endregion

        #region return  if array contains a subarray with sum equal to 0 else return 0
        /*
         * https://www.scaler.com/academy/mentee-dashboard/class/45629/assignment/problems/4202?navref=cl_tt_nv
         Given an array of integers A, find and return whether the given array contains a non-empty subarray with a sum equal to 0.

         If the given array contains a sub-array with sum zero return 1, else return 0.

        Input Format
        The only argument given is the integer array A.



        Output Format
        Return whether the given array contains a subarray with a sum equal to 0
        Example Input
        Input 1:
        
         A = [1, 2, 3, 4, 5]
        Input 2:
        
         A = [4, -1, 1]
        
        
        Example Output
        Output 1:
        
         0
        Output 2:
        
         1
         */
        public static int checkIfSubArrayWithSumZeroExist(List<int> A)
        {
            int[] prefixSum = new int[A.Count];
            //step 1: create a prefix sum array 
            prefixSum[0] = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i];
            }
            //step 2: if the prefix array is having any 0 then we need to return 1 
            Dictionary<int, int> sumWithZero = new Dictionary<int, int>();
            for (int i = 0; i < prefixSum.Length; i++)
            {
                if (prefixSum[i] == 0) return 1;
                if ((sumWithZero.ContainsKey(prefixSum[i]))) return 1;
                else sumWithZero.Add(prefixSum[i], 1);
            }
            return 0;
        }
        //output
        //var item = new List<int> { -1, 1 };
        //var res = DSA_algorithm.SCALAR.Intermediate_DSA_2.Hashing_1.checkIfSubArrayWithSumZeroExist(item);
        #endregion

        #region return count of  unique number of elements in an array
        /*
         Problem Description
        Given an array A of N integers, return the number of unique elements in the array.
        
        
        Problem Constraints
        1 <= N <= 105
        1 <= A[i] <= 109
        
        Input Format
        First argument A is an array of integers.
        
        
        Output Format
        Return an integer.
        
        
        Example Input
        Input 1:
        A = [3, 4, 3, 6, 6]
        Input 2:
        A = [3, 3, 3, 9, 0, 1, 0]
        
        
        Example Output
        Output 1:
        3
        Output 2:
        4
         */

        public static int countOfUniqueInArray(List<int> A)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < A.Count; i++)
            {
                set.Add(A[i]);
            }

            return set.Count;
        }
        #endregion
    }
}
