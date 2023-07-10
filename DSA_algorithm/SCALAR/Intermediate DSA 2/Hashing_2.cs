using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.SCALAR.Intermediate_DSA_2
{
    public class Hashing_2
    {
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
    }
}
