using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class SubArraySumMax2
    {
        static void maxSubArraySum(int[] a, int size)
        {
            int max_so_far = int.MinValue, max_ending_here = 0, start = 0, end = 0, s = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here += a[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    s = i + 1;
                }
            }
            Console.WriteLine("Maximum contiguous " +
                             "sum is " + max_so_far);
            Console.WriteLine("Starting index " +
                                          start);
            Console.WriteLine("Ending index " +
                                          end);
        }

        // Driver code
        public static void Main(string[] args)
        {
            int[] a = { 4, -20, 4, 3, 2, -5, 10, -300 };
            int n = a.Length;

            
            maxSubArraySum(a, n);
            Console.ReadLine();
        }
    }
}
