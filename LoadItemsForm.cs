using Mckinney_CourseProject_CEIS209.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mckinney_CourseProject_CEIS209
{
    public partial class SongLoader : Form
    {
        public static List<Song> storedSongs = new List<Song>();
        public static SongLoader songLoader;
        private static int _maxSongs = 5;
        private static List<Song> selectedSongs = new List<Song>();
        public SongLoader()
        {
            InitializeComponent();
        }

        public static List<Song> GetSelectedSongs() => selectedSongs;

        /// <summary>
        /// Renders dialog box displaying songs available for loading
        /// </summary>
        /// <param name="maxSongs">Maximum songs allowed to load</param>
        public static void ShowItemLoader(ListBox songList,int maxSongs = 5)
        {
            _maxSongs = maxSongs;
            storedSongs = GenericUtils.LoadSongs();
            if (storedSongs == null) return;
            songLoader = new SongLoader();
            songLoader.titleText.Text = $"Select songs for import. ({maxSongs - songList.Items.Count}) Remaining";
            foreach(var song in storedSongs)
            {
                if (!songList.Items.Contains(song.title))
                {
                    songLoader.checkedListBox.Items.Add(song.title);
                }
            }
            songLoader.ShowDialog();

        }

        private void loadItemsButton_Click(object sender, EventArgs e)
        {
            selectedSongs = storedSongs
                                .Select(x => x)
                                .Where(x => checkedListBox.CheckedItems.Contains(x.title))
                                .Take(_maxSongs)
                                .ToList();

            songLoader.Dispose();
        }
    }
}
