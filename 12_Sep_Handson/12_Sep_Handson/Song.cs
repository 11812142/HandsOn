using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Sep_Handson
{
    [Developer("New Album", SongName   = "Love in the air")]
    public class Song
    {
        [Developer("Name of the song", SongName = "Fitoor")]
        public string SongName { get; set; }

        [Developer("Language of the song", Language = "Hindi")]
        public string Language { get; set; }

        [Developer("Lyrics", Lyrics = "abc")]

        public string Lyrics { get; set; }

        
        public Song(string sname)
        {
            SongName = sname;
            
        }
    }
}
