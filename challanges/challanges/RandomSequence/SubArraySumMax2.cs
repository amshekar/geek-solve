using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class SubArraySumMax2
    {
        static int maxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }

        // Driver code
        public static void Main()
        {
            int[] a = { 4, -20, 4, 3, 2, -5, 10, -300 };
            Console.Write("Maximum contiguous sum is " +
                                    maxSubArraySum(a));
            Console.ReadLine();
        }
    }
}
