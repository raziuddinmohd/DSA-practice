// See https://aka.ms/new-console-template for more information
using DSA_algorithm.DSA_practice_by_love_babbar.Arrays;
using DSA_algorithm.LinkedList;
using DSA_algorithm.MethodCalls.DSA_practice_by_love_babbar.Arrays.Patterns;
using System.Collections.Generic;

//List<int> param = new List<int> { 1, 2, 1, 3, 4, 3 };
//var res = DSA_algorithm.SCALAR.Intermediate_DSA_2.Hashing_2.distinctNumbers(param, 3);

List<int> param1RangeSum = new List<int> { 7, 3, 1, 5, 5, 5, 1, 2, 4, 5 };
List<List<int>> param2RangeSum = new List<List<int>> { new List<int> { 6, 9 }, new List<int> { 2, 9 }, new List<int> { 2, 4 }, new List<int> { 0, 9 } };
List<long> reslut = DSA_algorithm.SCALAR.Intermediate_DSA_2.LinkedListProbs.rangeSum(param1RangeSum, param2RangeSum);
Console.WriteLine("Hello, World!");
