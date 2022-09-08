using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_algorithm.MethodCalls.DSA_practice_by_love_babbar.Arrays.Patterns
{
    public class Patterns
    {
        //1
        //2 3
        //3 4 5
        //4 5 6 7
        //5 6 7 8 9
        public static void printPattern1(int numberOfRow)
        {
            for (int i = 1; i <= numberOfRow; i++)
            {
                int temp = i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(temp + " ");
                    temp++;
                }
                Console.WriteLine();
            }
        }
        //the same above pattern but with out temp valriabel by using just i and J variables
        //1
        //2 3
        //3 4 5
        //4 5 6 7
        //5 6 7 8 9
        public static void printPattern1_2(int numberOfRow)
        {
            for (int i = 1; i <= numberOfRow; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + j - 1 + " ");
                }
                Console.WriteLine();
            }
        }
        //1
        //2 2
        //3 3 3
        //4 4 4 4
        //5 5 5 5 5
        //6 6 6 6 6 6
        public static void printPattern2(int numberOfRows)
        {
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        //1
        //2 3
        //4 5 6
        //7 8 9 10
        //11 12 13 14 15
        //16 17 18 19 20 21
        public static void printPattern3(int numberOfRows)
        {
            int counter = 1;
            for (int i = 1; i <= numberOfRows; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }
        //1
        //2 1
        //3 2 1
        //4 3 2 1
        //5 4 3 2 1
        //6 5 4 3 2 1
        //7 6 5 4 3 2 1
        public static void pattern4(int numberOfRows)
        {
            for (int i = 1; i <= numberOfRows; i++)
            {
                //dont create variabel until it is required....
                //int temp = i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i - j + 1 + " ");
                    //Console.Write(temp + " ");
                    //temp--;
                }
                Console.WriteLine();
            }
        }
        //1 2 3
        //2 3 4
        //3 4 5
        //4 5 6
        //5 6 7
        public static void patter5(int numberOfRows)
        {
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(i + j - 1 + " ");

                }
                Console.WriteLine();
            }
        }
        //A
        //B B
        //C C C
        //D D D D
        //E E E E E
        //F F F F F F
        //G G G G G G G
        //H H H H H H H H
        //I I I I I I I I I
        public static void pattern6(int numberOfRows)
        {
            //char a = (char)('A' + 1);
            char a = 'A';
            //for(int i = 1; i <= numberOfRows; i++)
            //{

            //}
            //Console.WriteLine((char)(a + 1));
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(a + i - 1) + " ");
                }
                Console.WriteLine();
            }
        }
        //A
        //B C
        //C D E
        //D E F G
        //E F G H I
        //F G H I J K
        //G H I J K L M
        //H I J K L M N O
        //I J K L M N O P Q
        public static void pattern7(int numberOfRows)
        {
            char a = 'A';
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(a + i + j - 2) + " ");
                }
                Console.WriteLine();
            }
        }

        //10
        //10 9
        //10 9 8
        //10 9 8 7
        //10 9 8 7 6
        public static void pattern8(int numberOfRows)
        {
            for (int i = 1; i <= numberOfRows; i++)
            {
                int value = numberOfRows;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(value + " ");
                    value--;
                }
                Console.WriteLine();
            }
        }
        //4
        //3 4
        //2 3 4
        //1 2 3 4
        public static void pattern9(int numberOfRows)
        {
            for (int i = 1; i <= numberOfRows; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(numberOfRows - i + j + " ");
                }
                Console.WriteLine();
            }
        }
        //   *
        //  **
        // ***
        //****

        public static void pattern10(int numberOfRows)
        {
            for (int i = 1; i <= numberOfRows; i++)
            {

                for (int j = 1; j <= numberOfRows; j++)
                {
                    if (j >= (numberOfRows - i + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
