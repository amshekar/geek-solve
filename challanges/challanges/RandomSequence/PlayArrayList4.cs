using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class PlayArrayList4
    {
        public static void Main(string[] args)
        {
            string[] originalLibrary = { "bird-song", "frog-song", "cat-song", "Goat-song", "lion-song" ,"tiger-song","elephant-song"};
            string[] shufflelibrary = PlaySongs(originalLibrary, "shuffle");
            Console.WriteLine("Original Library:{0}", string.Join(",", originalLibrary));
            Console.WriteLine("Shuffle Library:{0}",string.Join(",",shufflelibrary));
            Console.ReadLine();

        }

        private static string[] PlaySongs(string[] songArray, string v)
        {
            string[] targetArray= (string[])songArray.Clone();
            int songCount= targetArray.Length;
            Random rnd=new Random();
            //for (int i = songCount-1; i >0; i--) //o(n)
            for (int i = 0; i < songCount; i++) //O(n2)
            {
                int r=rnd.Next(songCount - i);
                string temp= targetArray[i];
                targetArray[i]= targetArray[r];
                targetArray[r]=temp;                
            }
            return targetArray;
        }
    }
}
