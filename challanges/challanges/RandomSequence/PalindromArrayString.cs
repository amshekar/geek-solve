using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class PalindromArrayString
    {

        public static void Main(String[] args)
        {
            string[] array = { "anna", "hanah", "level" ,"shekar"};

            ArrayList palindRomelist = PalindromStrings(array);

            foreach (var item in palindRomelist)
            {
                Console.WriteLine("Palindrom Strings"+item);

            }
            
        }

        private static ArrayList PalindromStrings(string[] array)
        {
            ArrayList palindRomelist=new ArrayList();
            for (int i = 0; i < array.Length; i++)
            {
                if (isPalindrom(array[i]))
                {
                    palindRomelist.Add(array[i]);

                }

            }
            return palindRomelist;
        }

        private static bool isPalindrom(string inputString)
        {
            int l = 0; int h = inputString.Length - 1;
            while (h>1)
            {
                if (inputString[l++] != inputString[h--])
                {
                    return false;
                }

            }
           
            return true;
        }
    }
}
