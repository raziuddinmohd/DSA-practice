using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.SCALAR.Intermediate_DSA_1
{
    public class IntroductionToArrays
    {
        public int CountOfElementGreaterThanItself(List<int> A)
        {
            int maxVaue = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] > maxVaue) maxVaue = A[i];
            }
            int countOfMaxValue = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == maxVaue) countOfMaxValue++;
            }
            return A.Count - countOfMaxValue;
        }
        public int maxminSumOfArray(List<int> A)
        {
            int maxVaue = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] > maxVaue) maxVaue = A[i];
            }
            int minVaue = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] < minVaue) minVaue = A[i];
            }
            return maxVaue + minVaue;
        }
    }
}
