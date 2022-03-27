using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class PalindromString10
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please eneter a string to check Palindrom");
            var inputString = Console.ReadLine();
            bool isPalindrom= IsPalindrom(inputString);
            if (isPalindrom)
            Console.WriteLine(string.Format("the Given string {0} is Palindrom",inputString));
            else
            Console.WriteLine(string.Format("the Given string {0} is not Palindrom",inputString));


        }

        private static bool IsPalindrom(string inpustString)
        {
            int l = 0; int r = inpustString.Length-1;
            while (r > 1)
            {
                if (inpustString[l++] != inpustString[r--])
                    return false;

            }
            return true;

        }
    }

}
