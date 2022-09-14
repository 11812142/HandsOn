using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SEP_HANDSON
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class DeveloperAttribute : Attribute
    {

        public DeveloperAttribute(string songname)
        {

            this.SongName = songname;
            //this.Language = language;
            //this.Lyrics = lyrics;

        }

        public string SongName { get; set; }
        public string Language { get; set; }
        public string Lyrics { get; set; }
    }
}
