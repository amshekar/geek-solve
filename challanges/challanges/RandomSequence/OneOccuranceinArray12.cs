using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class OneOccuranceinArray12
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 11, 11, 1, 9, 3 ,9,6,3,9,7};
            PrintOccuranceOnceElement(arr);
            Console.ReadLine();
        }

        private static void PrintOccuranceOnceElement(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {

                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else
                {
                    map.Add(arr[i], 1);
                }
            }
            foreach (var item in map)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine("Element that appears only once in an array"+item.Key);

                }
                else if (item.Value == 2)
                {
                    Console.WriteLine("Element that appears twice in an array" + item.Key);
                }

            }
        }
    }
}
