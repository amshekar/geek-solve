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
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            SearchWordReturnIndex();

        }

        private static void SearchWordReturnIndex()
        {
            throw new NotImplementedException();
        }
    }
}
