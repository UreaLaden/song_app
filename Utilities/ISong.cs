using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        public Song(string _title = "Title",string _artist = "Artist", string _genre = "Genre",int _year = -1,string _url = "URL")
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

        public string RetrieveAndUpdateProperty(string propertyName,string value )
        {
           
            switch (propertyName)
            {
                case "title":
                    this.title = value;
                    return propertyName;
                case "artist":
                    this.artist = value;
                    return propertyName;
                case "genre":
                    this.genre = value;
                    return propertyName;
                case "year":
                    try
                    {
                        this.year = int.Parse(value);
                        return propertyName;
                    }
                    catch (Exception)
                    {
                        return "";
                    }
                case "url":
                    this.url = value;
                    return propertyName;
                default:
                    return String.Empty;
            }
        }
    }
}
