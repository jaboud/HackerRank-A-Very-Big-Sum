using System;

namespace HackerRank_A_Very_Big_Sum
{
    class Program
    {
        //A static method using the long data type using arrays.
        static long AVeryBigSum(long[] ar)
        {
            //Variable called sum and preset the default value at 0.
            long sum = 0;
            //For loop when you add the first line of input. For example on hackerrank, if we input "5" as the first line
            //then we will have to calculate 5 long sums which will be incremented at the end and add them all up and returning the answer.  
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
