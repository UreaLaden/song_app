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

        public static Song GenerateSongDetails( string songTitle, List<Song> songList)
        {
            var song = songList
                        .FirstOrDefault(x => x != null && x.title == songTitle);
            return song;
        }

        public static List<Song> LoadSongs()
        {
            List<Song> songs = new List<Song>();
            var pathToFile = Path.Combine(Schemas.ROOT, "public", "data\\songs.xlsx");
            WorkBook workbook;
            WorkSheet sheet;
            try
            {
                workbook = WorkBook.Load(pathToFile);
                sheet = workbook.WorkSheets.First();
            }
            catch (IOException)
            {
                NoteBox.Show("Please close\nthe spreadsheet.");
                return null;
            }

            var lastRow = sheet.Rows.Last();
            var startingColumn = sheet.RangeAddressAsString.Split(':')[0].ToString();
            var lastColumn = lastRow.RangeAddressAsString.Split(':')[1].ToString();

            var startingColChar = (int)Convert.ToChar(startingColumn[0]);
            var lastColChar = (int)Convert.ToChar(lastColumn[0]);
            var lastRowNum = int.Parse(String.Concat(lastColumn.Where(x => Char.IsDigit(x))));
            
            for (int row = 2; row <= lastRowNum;row++)
            {
                Song song = new Song();
                Queue<string> q = new Queue<string>();
                q.Enqueue("title");
                q.Enqueue("artist");
                q.Enqueue("genre");
                q.Enqueue("year");
                q.Enqueue("url");
                for(int col = startingColChar; col <= lastColChar; col++)
                {
                    var column = Convert.ToChar(col).ToString();
                    var cell = $"{column}{row}";
                    var target = q.Dequeue();
                    song.RetrieveAndUpdateProperty(target, sheet[cell].Value.ToString());
                }
                songs.Add(song);
            }

            return songs;
        }
        public static void StoreSongs(List<Song> songsToStore)
        {
            var pathToFile = Schemas.OUTPUT_DIR;
            
            WorkBook workbook = WorkBook.Load(pathToFile);
            WorkSheet sheet = workbook.WorkSheets.First();

            var lastRow = sheet.Rows.Last();
            var startingColumn = lastRow.RangeAddressAsString.Split(':')[0].ToString();
            var lastColumn = lastRow.RangeAddressAsString.Split(':')[1].ToString();
            
            var startingColChar = (int)Convert.ToChar(startingColumn[0]);
            var lastColChar = (int)Convert.ToChar(lastColumn[0]);
            var lastRowNum = int.Parse(String.Concat(lastColumn.Where(x => Char.IsDigit(x))));
            
            Queue<Song> songs = new Queue<Song>();
            foreach (Song song in songsToStore)
            {
                songs.Enqueue(song);
            }

            for (int row = lastRowNum + 1; row <= lastRowNum + songsToStore.Count(); row++)
            {

                if (songs.Count <= 0 ) continue;
                var song = songs.Dequeue();

                for (int col = startingColChar; col <= lastColChar; col++)
                {
                    var column = Convert.ToChar(col).ToString();
                    var cell = $"{column}{row}";
                    switch (column)
                    {
                        case "A":
                            sheet[cell].Value = song.title;
                            break;
                        case "B":
                            sheet[cell].Value = song.artist;
                            break;
                        case "C":
                            sheet[cell].Value = song.genre;
                            break;
                        case "D":
                            sheet[cell].Value = song.year;
                            break;
                        case "E":
                            sheet[cell].Value = song.url;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(cell);
                }
            }
            workbook.Save();
        }
    }

}
