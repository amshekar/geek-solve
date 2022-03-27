using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RandomSequence
{
    // You have an array of numbers of random order. Print out the numbers in an ascending order. Or print out the numbers but remove duplicates.
    public class SortArray8
    {


        public static void Main(string[] args)
        {
            int[] arr = { 10, 5, 8, 9, 3, 1, 3, 5, 6 };
            SortArrayOrder(arr, "des", false);
        }

        private static void SortArrayOrder(int[] arr, string sortOrder, bool inbuilt)
        {
            int[] sortedArray;
            int temp;
            if (inbuilt)
            {

                sortedArray = sortOrder == "asc" ? arr.OrderBy(x => x).Distinct().ToArray() : arr.OrderByDescending(x => x).Distinct().ToArray();
                Console.WriteLine("Sorted the array in" + sortOrder + " Order");
                foreach (var item in sortedArray)
                {
                    Console.WriteLine(item);

                }
                Console.ReadLine();

            }
            else
            {
                if (sortOrder == "asc")
                {



                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] > arr[j])
                            {
                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }

                        }

                    }
                }
                else
                {


                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] < arr[j])
                            {
                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;

                            }
                        }

                    }
                }
                Console.WriteLine("Sorted the array in" + sortOrder + " Order");
                foreach (var item in arr)
                {
                    Console.WriteLine(item);

                }
                Console.ReadLine();

            }

        }
    }
}
