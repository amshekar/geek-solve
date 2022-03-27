using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequence
{
    public class SearchSustringReturnIndex
    {

        public static void Main(string[] args)
        {
            string sentence = "ThingSpace gives you all the tools to prototype, test, connect and manage your IoT devices on Verizon's secure and reliable network.";
            //string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Enter search  string");
            var serachString = Console.ReadLine();
            Console.WriteLine("Enter Replace  string");
            var replaceString= Console.ReadLine();

            SearchWordReturnIndex(sentence, serachString, replaceString);

        }

        private static void SearchWordReturnIndex(string sentence, string serachString, string replaceString)
        {
            int index=sentence.IndexOf(serachString);
            string modifiedString=sentence.Replace(serachString, replaceString);
            Console.WriteLine(String.Format("search String Index : {0} Updated string as Follows : {1}",index,modifiedString));
            Console.ReadLine();
        }
    }
}
