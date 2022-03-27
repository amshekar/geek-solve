using System;
using System.Collections;
using System.Collections.Generic;

namespace RandomSequence
{
    public class RandomNumberSequence5
    {

		// Function to return the next random number
		static int getRandomNumber(ArrayList vector)
		{

			// Size of the vector
			int size = vector.Count;

			Random rand = new Random();

			// Make sure the number is within
			// the index range
			int index = (rand.Next() % size);

			// Get random number from the vector
			int randomNumber = (int)vector[index];

			// Remove the number from the vector
			vector[index] = (int)vector[size - 1];
			vector.Remove(vector[size - 1]);

			// Return the removed number
			return randomNumber;
		}

		// Function to generate n
		// non-repeating random numbers
		public static void generateRandom(int num)
		{
			ArrayList arrayList = new ArrayList(num);

			// Fill the vector with the values
			// 1, 2, 3, ..., n
			for (int i = 0; i < num; i++)
				arrayList.Add(i + 1);

			// While vector has elements get a
			// random number from the vector
			// and print it
			while (arrayList.Count > 0)
			{
				Console.WriteLine(getRandomNumber(arrayList) + " ");
			}
			
		}

		// Driver code
		public static void Main(string[] args)
		{
			Console.WriteLine("please enter the number");
			int number=int.Parse(Console.ReadLine());
			Console.WriteLine("Generating random numbers:");
			generateRandom(number);
			Console.ReadLine();
		}
	}
}
