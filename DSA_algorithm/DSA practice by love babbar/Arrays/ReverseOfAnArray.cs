using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.DSA_practice_by_love_babbar.Arrays
{
    public class ReverseOfAnArray
    {
        //Input  : arr[] = {1, 2, 3}
        //Output : arr[] = {3, 2, 1}

        //Input :  arr[] = {4, 5, 1, 2}
        //Output : arr[] = {2, 1, 5, 4}

        public static int[] reverseOfAnArray(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = array.Length; i > 0; i--)
            {
                result[array.Length - i] = array[i - 1];
            }
            return result;
        }
    }
}
