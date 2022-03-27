using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomSequence
{
    public class PlayList4
    {
        public static void Main(string[] args)
        {
            List<SongsLibrary> libraryTollywood = new List<SongsLibrary>();
            libraryTollywood.Add(new SongsLibrary() { Name=  "1 Song"});
            libraryTollywood.Add(new SongsLibrary() { Name = "2 Song" });
            libraryTollywood.Add(new SongsLibrary() { Name = "3 Song" });
            libraryTollywood.Add(new SongsLibrary() { Name = "4 Song" });
            libraryTollywood.Add(new SongsLibrary() { Name = "5 Song" });
            libraryTollywood.Add(new SongsLibrary() { Name = "6 Song" });
            libraryTollywood.Add(new SongsLibrary() { Name = "7 Song" });
            libraryTollywood.Add(new SongsLibrary() { Name = "8 Song" });
            libraryTollywood.Add(new SongsLibrary() { Name = "9 Song" });
            libraryTollywood.Add(new SongsLibrary() { Name = "10 Song" });
            var rand=new Random();

            var randomList = libraryTollywood.OrderBy(item => rand.Next()).ToList();
            foreach (var item in randomList)
            {
                Console.WriteLine(item.Name);
            }



        }
        
    }

    public class SongsLibrary
    {
        public string Name { get; set; }

    }
}
