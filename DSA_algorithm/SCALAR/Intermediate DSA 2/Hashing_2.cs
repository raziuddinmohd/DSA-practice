using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.SCALAR.Intermediate_DSA_2
{
    public class Hashing_2
    {
        #region Q2 :check pair sum
        /*
       Problem Description
       Given an Array of integers B, and a target sum A.
       Check if there exists a pair (i,j) such that Bi + Bj = A and i!=j.


       Problem Constraints
       1<= Length of array B <= 103
       0<= Bi <=109
       0<= A <=109


       Input Format
       First argument A is the Target sum, and second argument is the array B


       Output Format
       Return an integer value 1 if there exists such pair, else return 0.


       Example Input
       Input 1:

       A = 8   
       B = [3, 5, 1, 2, 1, 2]
       Input 2:

       A = 21   
       B = [9, 10, 7, 10, 9, 1, 5, 1, 5]


       Example Output
       Output 1:

       1
       Output 2:

       0
        */

        public static int CheckPairSum(int A, List<int> B)
        {
            Dictionary<int, int> frequencyHashMap = new Dictionary<int, int>();
            //step 1 : prepare hashmap of the array

            for (int i = 0; i < B.Count; i++)
            {
                if (frequencyHashMap.ContainsKey(B[i]))
                {
                    frequencyHashMap[B[i]] = frequencyHashMap[B[i]] + 1;
                }
                else
                {
                    frequencyHashMap.Add(B[i], 1);
                }
            }
            int a, b = 0;
            for (int i = 0; i < B.Count; i++)
            {
                a = B[i]; b = A - a;
                if (a != b && frequencyHashMap.ContainsKey(b)) return 1;
                else if (a == b && frequencyHashMap[b] > 2) return 1;
            }
            return 0;
        }

        #endregion

        #region Q3. Distinct Numbers in Window
        /*
            Problem Description
            You are given an array of N integers, A1, A2 ,..., AN and an integer B. Return the of count of distinct numbers in all windows of size B.

            Formally, return an array of size N-B+1 where i'th element in this array contains number of distinct elements in sequence Ai, Ai+1 ,..., Ai+B-1.

            NOTE: if B > N, return an empty array.



            Problem Constraints
            1 <= N <= 106

            1 <= A[i] <= 109


            Input Format
            First argument is an integer array A
            Second argument is an integer B.



            Output Format
            Return an integer array.



            Example Input
            Input 1:

             A = [1, 2, 1, 3, 4, 3]
             B = 3
            Input 2:

             A = [1, 1, 2, 2]
             B = 1


            Example Output
            Output 1:

             [2, 3, 3, 2]
            Output 2:

             [1, 1, 1, 1]


            Example Explanation
            Explanation 1:

             A=[1, 2, 1, 3, 4, 3] and B = 3
             All windows of size B are
             [1, 2, 1]
             [2, 1, 3]
             [1, 3, 4]
             [3, 4, 3]
             So, we return an array [2, 3, 3, 2].
            Explanation 2:

             Window size is 1, so the output array is [1, 1, 1, 1].


         */
        public static List<int> distinctNumbers(List<int> A, int B)
        {
            List<int> res = new List<int>();
            //NOTE: if B > N, return an empty array.
            if (B > A.Count) return res;
            Dictionary<int, int> frequencyHashMap = new Dictionary<int, int>();

            //step 1 : prepare hashmap of the array

            for (int i = 0; i < B; i++)
            {
                if (frequencyHashMap.ContainsKey(A[i]))
                {
                    frequencyHashMap[A[i]] = frequencyHashMap[A[i]] + 1;
                }
                else
                {
                    frequencyHashMap.Add(A[i], 1);
                }
                //this step im forget

            }

            res.Add(frequencyHashMap.Count);
            //if the size of the array and window are same then.
            if (A.Count == B)
            {
                return res;
            }
            for (int i = 1; i < A.Count - B + 1; i++)
            {
                //der is no need to check this condition as the element will be available 100%
                //if (frequencyHashMap.ContainsKey(A[B -1]))
                //{
                if (frequencyHashMap[A[i - 1]] > 1)
                {
                    frequencyHashMap[A[i - 1]] = frequencyHashMap[A[i - 1]] - 1;
                }
                else
                //this if conditoin is also not required
                //if (frequencyHashMap[A[B -1]] == 1)
                {
                    frequencyHashMap.Remove(A[i - 1]);
                }
                //}
                if (frequencyHashMap.ContainsKey(A[i + B - 1]))
                {
                    frequencyHashMap[A[i + B - 1]] = frequencyHashMap[A[i + B - 1]] + 1;
                }
                else
                {
                    frequencyHashMap.Add(A[i + B - 1], 1);
                }
                res.Add(frequencyHashMap.Count);
            }
            //foreach (KeyValuePair<int, int> entry in frequencyHashMap)
            //{
            //    if (entry.Value == 1) res.Add(entry.Key);
            //    // do something with entry.Value or entry.Key
            //}
            return res;
        }
        #endregion
    }
}
