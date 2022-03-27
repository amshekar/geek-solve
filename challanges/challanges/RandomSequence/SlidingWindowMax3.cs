using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class SlidingWindowMax3
    {
        // Method to find the maximum for
        // each and every contiguous subarray
        // of size k.
        static void PrintMaxofEachSlidingWindow(int[] arr, int arraySize, int slidingWindowSize)
        {
            int j, max;

            for (int i = 0; i <= arraySize - slidingWindowSize; i++)
            {

                max = arr[i];

                for (j = 1; j < slidingWindowSize; j++)
                {
                    if (arr[i + j] > max)
                        max = arr[i + j];
                }
                Console.Write(max + " ");
            }
        }

        // Driver method
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 5, -5, 4, 6, 7, 3, -10, -3, 8, 1 };
            int slidingWindowSize = 5;
            PrintMaxofEachSlidingWindow(arr, arr.Length, slidingWindowSize);
            Console.Read();
        }
    }
}
