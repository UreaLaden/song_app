using IronXL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mckinney_CourseProject_CEIS209.Utilities
{
    public static class GenericUtils
    {
        /// <summary>
        /// Checks textBox input fields to determine if any are non empty. 
        /// Displays Message box if an empty input field is found
        /// </summary>
        /// <param name="textBoxList"></param>
        /// <returns>False if any fiels are empty.</returns>
        public static bool ValidateInput(List<object> textBoxList)
        {
            var filteredStrings = textBoxList
                .Where(x =>
                {
                    if (x.GetType() == typeof(TextBox))
                    {
                        var item = x as TextBox;
                        return string.IsNullOrEmpty(item.Text);
                    }
                    else
                    {
                        var item = x as ComboBox;
                        return string.IsNullOrEmpty(item.SelectedItem != null ? item.SelectedItem.ToString() : item.Text);
                    }
                })
                .Select(x => 
                {
                    if (x.GetType() == typeof(TextBox))
                    {
                        var item = x as TextBox;
                        return item.Name;
                    }
                    else
                    {
                        var item = x as ComboBox;
                        return item.Name;
                    }
                }).ToList();

            bool containsEmptyStrings = filteredStrings.Count > 0;

            if (containsEmptyStrings)
            {
                var baseWord = filteredStrings[0].Split('T')[0];
                var field = char.ToUpper(baseWord.First()) + baseWord.Substring(1).ToLower();

                NoteBox.Show($"The {field} Cannot be blank");

                return false;
            }
            var year = textBoxList.Where(x => {
                if(x.GetType() == typeof(TextBox))
                {
                    var item = x as TextBox;
                    return item.Name == "yearText";
                }
                return false;
                }).Select(x =>
                {
                    if(x.GetType() == typeof(TextBox))
                    {
                        var item = x as TextBox;
                        return item.Text;
                    }
                    return null;
                }).ToList();
            try
            {

                bool yearInValidFormat = int.Parse(year[0]).GetType() == typeof(int);
            }
            catch (FormatException)
            {
                NoteBox.Show("Invalid Year Input");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Return the index of the given title from the ListBox.
        /// This assumes the song is within the list of songs.
        /// </summary>
        /// <param name="songList"></param>
        /// <param name="songTitle"></param>
        /// <returns></returns>
        public static int GetSongIndex(ListBox songList,string songTitle)
        {
            return songList.Items.IndexOf(songTitle);
        }

        public static bool SongInList(ListBox songList,string songTitle)
        {
            return songList.Items.Contains(songTitle);
        }

        /// <summary>
        /// Display Song data for the Selected Song
        /// </summary>
        /// <param name="outputText"></param>
        /// <param name="titleArr"></param>
        /// <param name="artistArr"></param>
        /// <param name="genreArr"></param>
        /// <param name="urlArr"></param>
        /// <param name="songIdx"></param>
        public static void DisplaySongData( TextBox outputText, Song song )
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string newLine = "\r\n";

            sb.Append(song.title);
            sb.Append(newLine);
            sb.Append(song.artist);
            sb.Append(newLine);
            sb.Append(song.genre);
            sb.Append(newLine);
            sb.Append(song.year);
            sb.Append(newLine);
            sb.Append(song.url);
            sb.Append(newLine);
            
            sb.Append(newLine);
            outputText.Text = sb.ToString();
        }
        public static void ClearTextBoxItems(List<object> textBoxList)
        {
            foreach (var item in textBoxList)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    var currItem = item as TextBox;
                    currItem.Clear();
                }
                else
                {
                    var currItem = item as ComboBox;
                    currItem.Text = currItem.Items[1].ToString();
                }
            }
        }

        public static Song GenerateSongDetails( string songTitle, Song[] songList)
        {
            var song = songList
                        .ToList()
                        .FirstOrDefault(x => x != null && x.title == songTitle);
            return song;
        }

        public static List<Song> LoadSongs()
        {
            List<Song> songs = new List<Song>();
            var pathToFile = Path.Combine(Schemas.ROOT, "public", "data\\songs.xlsx");
            WorkBook workbook = WorkBook.Load(pathToFile);
            WorkSheet sheet = workbook.WorkSheets.First();
            var range = sheet.GetNamedRanges();
            var cols = sheet.Rows;
            foreach(var item in sheet.Rows)
            {
                var currentRow = int.Parse(item.RangeAddressAsString.Split(':')[0][1].ToString());
                string title = String.Empty;
                string artist = String.Empty;
                string genre = String.Empty;
                string url = String.Empty;
                int year = -1;
                foreach(var cell in item.Columns)
                {
                    var currentCol = cell.RangeAddressAsString.Split(':')[0][0].ToString();
                   if(currentRow > 1)
                   {
                        switch (currentCol)
                        {
                            case "A":
                                title = cell.Value.ToString();
                                break;
                            case "B":
                                artist = cell.Value.ToString();
                                break;
                            case "C":
                                genre = cell.Value.ToString();
                                break;
                            case "D":
                                year = int.Parse(cell.Value.ToString());
                                break;
                            case "E":
                                url = cell.Value.ToString();
                                break;
                        }
                    }
                }
                if (currentRow <= 1) continue;
                var song = new Song(title, artist, genre, year, url);
                songs.Add(song);
            }
            return songs;
        }
    }

}
