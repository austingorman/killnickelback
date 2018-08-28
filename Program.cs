using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> GoodSongs = new List<(string, string)>();
            HashSet<(string artist, string song)> allSongs = new HashSet<(string, string)>()
            {
                ("Nickelback", "How You Remind Me"),
                ("Nickelback", "Photograph"),
                ("Nickelback", "Rockstar"),
                ("Black Moth Super Rainbow", "Twin of Myself"),
                ("Khruangbin", "Rules"),
                ("Skatt Bros", "Walk The Night"),
                ("Jon Hopkins", "Emerald Rush")
            };

            foreach (var song in allSongs)
            {
                if (song.artist != "Nickelback")
                {
                    GoodSongs.Add(song);
                }
            }
            foreach (var song in GoodSongs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
