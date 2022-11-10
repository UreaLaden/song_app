using Mckinney_CourseProject_CEIS209.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Mckinney_CourseProject_CEIS209
{
    public partial class MainForm : Form
    {
        List<Song> songs = new List<Song>();
        int      maxSongs   = 5;
        public MainForm()
        {
            //Autoplay on load
            Environment.SetEnvironmentVariable("WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS", "--autoplay-policy=no-user-gesture-required");
            InitializeComponent();
            genreText.SelectedItem = genreText.Items[1].ToString();
            RegisterEvents();
        }
        private void AddButton_Click()
        {
            List<object> textBoxList = new List<object>
            {
                titleText,
                artistText,
                genreText,
                yearText,
                urlText
            };

            bool isValidInput = GenericUtils.ValidateInput(textBoxList);
            
            if (!isValidInput) return;

            if (songList.Items.Count >= maxSongs)
            {
                NoteBox.Show($"You have reached\n your {maxSongs} song limit");
                return;
            }

            StringBuilder sb;
            string newLine;
            Song song;
            GenerateSongData(textBoxList, out sb, out newLine, out song);
            var containsSong = songs.Contains(song);
            if (!containsSong)
            {
                songs.Add(song);
            }

            sb.Append(newLine);
            outputText.Text = "";
            outputText.Text = sb.ToString();

            GenericUtils.ClearTextBoxItems(textBoxList);
        }

        private void GenerateSongData(List<object> textBoxList, out StringBuilder sb, out string newLine, out Song song)
        {
            sb = new StringBuilder(outputText.Text);
            newLine = "\r\n";
            string title = "";
            string artist = "";
            string genre = "";
            int year = -1;
            string url = "";
            foreach (var item in textBoxList)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    var currentItem = item as TextBox;
                    sb.Append(currentItem.Text);
                }
                else
                {
                    var currentItem = item as ComboBox;
                    sb.Append(currentItem.SelectedItem != null ? currentItem.SelectedItem.ToString() : currentItem.Text);
                }
                sb.Append(newLine);

                if (item.GetType() == typeof(TextBox))
                {
                    var currentItem = item as TextBox;
                    switch (currentItem.Name)
                    {
                        case "titleText":
                            songList.Items.Add(currentItem.Text);
                            title = currentItem.Text;
                            break;
                        case "artistText":
                            artist = currentItem.Text;
                            break;
                        case "yearText":
                            year = int.Parse(currentItem.Text);
                            break;
                        case "urlText":
                            url = currentItem.Text;
                            break;
                    }
                }
                else //Genre is the only ComboBox
                {
                    var currentItem = item as ComboBox;
                    genre = currentItem.SelectedItem != null ? currentItem.SelectedItem.ToString() : currentItem.Text;
                }
            }

            song = new Song(title, artist, genre, year, url);
        }

        private void ShowAllSongs_Click()
        {
            outputText.Clear();

            foreach(var item in songList.Items)
            {
                var song = GenericUtils.GenerateSongDetails(item.ToString(),songs);
                GenericUtils.DisplaySongData(outputText, song);               
            }
        }

        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = songList.SelectedItem.ToString();

            var song = GenericUtils.GenerateSongDetails(title, songs);
            
            outputText.Clear();

            GenericUtils.DisplaySongData(outputText, song);

        }

        public void StoreSongDataClicked()
        {
            var currentSongs = songList.Items;
            var songs = GenericUtils.LoadSongs();
            List<Song >songsToStore = new List<Song>();
            foreach(var song in currentSongs)
            {
                var s = song.ToString();
                var songStored = songs.Where(x => x.title == s).ToList().Count() > 0;
                if (!songStored)
                {
                    songsToStore.Add(GenericUtils.GenerateSongDetails(s, this.songs));
                }
            }
            GenericUtils.StoreSongs(songsToStore);
        }
    
        private void FindButton_Click()
        {
            if (GenericUtils.SongInList(songList, titleText.Text))
            {
                int idx = GenericUtils.GetSongIndex(songList, titleText.Text);
                songList.SetSelected(idx, true);

                outputText.Clear();

                var song = GenericUtils.GenerateSongDetails(titleText.Text, songs);
                GenericUtils.DisplaySongData(outputText, song);
            }
        }

        private void ClearButton_Click()
        {
            List<object> textBoxList = new List<object>
            {
                titleText,
                artistText,
                genreText,
                yearText,
                urlText
            };
            outputText.Clear();
            GenericUtils.ClearTextBoxItems(textBoxList);
        }

        private void PlayButton_Click()
        {
            outputText.Clear();
            string title = songList.SelectedItem.ToString();
            var song = GenericUtils.GenerateSongDetails(title,songs);
            string url = song.url;
            webViewDisplay.CoreWebView2.Navigate(url);

            GenericUtils.DisplaySongData(outputText,song);
        }
        private void loadSongsBtn_Click(object sender, EventArgs e)
        {
            //Display Dialog option for songs to load
            SongLoader.ShowItemLoader(maxSongs);
            var selectedSongs = SongLoader.GetSelectedSongs();
            for(int i=0;i< selectedSongs.Count;i++)
            {
                if (songList.Items.Count >= maxSongs)
                {
                    NoteBox.Show($"You have reached\n your {maxSongs} song limit");
                    break;
                }
                var title = selectedSongs[i].title;
                songList.Items.Add(title);

                songs.Add(new Song(title, selectedSongs[i].artist, selectedSongs[i].genre, selectedSongs[i].year, selectedSongs[i].url));
            }
            ShowAllSongs_Click();
        }
      
        /// <summary>
        /// Custom Event Handlers for Specific UI elements
        /// This is preferred since making changes from 
        /// design UI Events results in a crash and is a bit tedious
        /// </summary>
        private void RegisterEvents()
        {
            EventUtils eventUtils   = new EventUtils();
            headerPanel.MouseDown   += new MouseEventHandler(eventUtils.headerPanel_MouseDown);
            headerLabel.MouseDown   += new MouseEventHandler(eventUtils.headerPanel_MouseDown);

            addButton.MouseEnter    += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.GetRandomColor());
            addButton.MouseLeave    += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            addButton.Click         += (sender, e) => eventUtils.OnMouseClick(sender, e, AddButton_Click);

            showSongs.MouseEnter    += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.GetRandomColor());
            showSongs.MouseLeave    += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            showSongs.Click         += (sender, e) => eventUtils.OnMouseClick(sender, e, ShowAllSongs_Click);

            clearButton.MouseEnter  += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.GetRandomColor());
            clearButton.MouseLeave  += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            clearButton.Click       += (sender, e) => eventUtils.OnMouseClick(sender, e, ClearButton_Click);

            loadSongsBtn.MouseEnter += (sender,e) => eventUtils.OnMouseEnter(sender,e,Schemas.GetRandomColor(),null,true);
            loadSongsBtn.MouseLeave += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK], null, true);

            storeSongsBtn.Click += (sender, e) => eventUtils.OnMouseClick(sender, e, StoreSongDataClicked);
            storeSongsBtn.MouseEnter += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.GetRandomColor(), null, true);
            storeSongsBtn.MouseLeave += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK], null, true);

            findButton.MouseEnter   += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.GetRandomColor());
            findButton.MouseLeave   += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            findButton.Click        += (sender, e) => eventUtils.OnMouseClick(sender, e, FindButton_Click);

            playButton.MouseEnter   += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.Themes[Schemas.CHARTREUSE_WEB]);
            playButton.MouseLeave   += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            playButton.Click        += (sender, e) => eventUtils.OnMouseClick(sender, e, PlayButton_Click);

            minimizeBtn.MouseClick  += new MouseEventHandler(eventUtils.minimizeBtn_Click);
            minimizeBtn.MouseEnter  += (sender, e) => eventUtils.OnMouseEnter(sender, e,Color.Empty, Schemas.Images[Schemas.MINIMIZE_HIGHLIGHTED]);
            minimizeBtn.MouseLeave  += (sender, e) => eventUtils.OnMouseLeave(sender, e,Color.Empty, Schemas.Images[Schemas.MINIMIZE]);

            closeButton.MouseClick  += new MouseEventHandler(eventUtils.closeButton_Click);
            closeButton.MouseEnter  += (sender, e) => eventUtils.OnMouseEnter(sender, e,Color.Empty, Schemas.Images[Schemas.CLOSE_HIGHLIGHTED]);
            closeButton.MouseLeave  += (sender, e) => eventUtils.OnMouseLeave(sender, e, Color.Empty, Schemas.Images[Schemas.CLOSE]);
        }

    }
}
