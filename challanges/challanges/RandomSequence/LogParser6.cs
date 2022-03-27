using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RandomSequence
{
    public class LogParser6
    {
        public static void Main(string[] args)
        {
            string logMessage = "• 12:00 1 1 200 Success • 12:00 1 2 500 Error • 12:00 1 3 200 Success • 12:00 1 2 200 Success • 12:00 1 5 200 Success • 12:01 2 1 500 Error • 12:01 1 2 500 Error • 12:01 1 5 500 Error";
            var splitted=logMessage.Split('•');
            ArrayList araylist = new ArrayList();
            foreach (var item in splitted)
            {
                if (item.Trim().Length>0)
                {
                    var itemSplit=item.Split(' ');
                    araylist.AddRange(itemSplit);

                }
              
            }

        }
    }
}
