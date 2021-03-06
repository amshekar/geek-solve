using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class PalindromArrayString9
    {

        public static void Main(String[] args)
        {
            string[] array = { "anna", "hanah", "level" ,"shekar"};
            StringBuilder sb = new StringBuilder();

            ArrayList palindRomelist = PalindromStrings(array);

            foreach (string item in palindRomelist)
            {
               sb.Append(item+',');

            }
            Console.WriteLine("Palindrom Strings : {" + sb+"}");

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
