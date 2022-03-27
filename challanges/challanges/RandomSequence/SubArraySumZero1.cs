using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    // C# program to print all subarrays
    // in the array which has sum 0
    using System;
    using System.Collections.Generic;



    public class SubArraySumZero1
    {
        // Function to print all subarrays
        // in the array which has sum 0
        static List<Pair> findSubArrays(int[] arr, int n)
        {
            // create an empty map
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            // create an empty vector of pairs to store
            // subarray starting and ending index
            List<Pair> outt = new List<Pair>();

            // Maintains sum of elements so far
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                // add current element to sum
                sum += arr[i];

                // if sum is 0, we found a subarray starting
                // from index 0 and ending at index i
                if (sum == 0)
                    outt.Add(new Pair(0, i));
                List<int> al = new List<int>();

                // If sum already exists in the map there exists
                // at-least one subarray ending at index i with
                // 0 sum
                if (map.ContainsKey(sum))
                {
                    // map[sum] stores starting index
                    // of all subarrays
                    al = map[sum];
                    for (int it = 0; it < al.Count; it++)
                    {
                        outt.Add(new Pair(al[it] + 1, i));
                    }
                }
                al.Add(i);
                if (map.ContainsKey(sum))
                    map[sum] = al;
                else
                    map.Add(sum, al);
            }
            return outt;
        }

        // Utility function to print all subarrays with sum 0
        static void print(List<Pair> outt)
        {
            for (int i = 0; i < outt.Count; i++)
            {
                Pair p = outt[i];
                Console.WriteLine("Subarray found from Index " +
                                   p.first + " to " + p.second);
            }
        }

        // Driver code
        public static void Main(String[] args)
        {
            int[] arr = { -4, -20, 2, 2, 8, 3, -5, 10, -300, 6, 8 };
            int n = arr.Length;

            List<Pair> outt = findSubArrays(arr, n);

            // if we did not find any subarray with 0 sum,
            // then subarray does not exists
            if (outt.Count == 0)
                Console.WriteLine("No subarray exists");
            else
                print(outt);
        }
    }
    // User defined pair class
    class Pair
    {
        public int first, second;
        public Pair(int a, int b)
        {
            first = a;
            second = b;
        }
    }

    
}
