using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RandomSequence
{
    public class LogCount6
    {
        public static void Main(string[] args)
        {
            string logMessage =
                                @" 12:00 1 1 200 Success
                                 12:00 1 2 500 Error
                                 12:00 1 3 200 Success
                                 12:00 1 2 200 Success
                                 12:00 1 5 200 Success
                                 12:01 2 1 500 Error
                                 12:01 1 2 500 Error
                                 12:01 1 5 500 Error";
            var splitString = logMessage.Split('\n');
            IList<LogMessage> list = new List<LogMessage>();
            foreach (var item in splitString)
            {
                var log = new LogMessage(item.Trim());
                list.Add(log);

            }
            var filteredMessages = list.Where(log => Convert.ToInt32(log.statuscode) > 200).Select(log => new { log.channelnum, log.slotnumber }).Distinct().ToArray();
            foreach (var item in filteredMessages)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }

    public class LogMessage
    {
        public LogMessage(string item)
        {
            if (item.Length > 0)
            {
                var result = item.Split(' ');
                logTime = result[0];
                channelnum = result[1];
                slotnumber = result[2];
                statuscode = result[3];
                description = result[4];

            }



        }
        public string logTime { get; set; }
        public string channelnum { get; set; }
        public string slotnumber { get; set; }
        public string statuscode { get; set; }
        public string description { get; set; }
    }
}
