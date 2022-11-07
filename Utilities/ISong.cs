using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mckinney_CourseProject_CEIS209.Utilities
{
    public class Song
    {
        public string title;
        public string artist;
        public string genre;
        public int year;
        public string url;

        public Song(string _title,string _artist, string _genre,int _year,string _url)
        {
            title = _title;
            artist = _artist;
            genre = _genre;
            year = _year;
            url = _url;
        }

        public Dictionary<string,string> GetSongDetails()
        {
            Dictionary<string,string> details = new Dictionary<string,string>();
            details.Add("title", title);
            details.Add("artist", artist);
            details.Add("genre", genre);
            details.Add("year", year.ToString());
            details.Add("url", url);

            return details;
        }
    }
}
