using Mckinney_CourseProject_CEIS209.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mckinney_CourseProject_CEIS209
{
    public partial class MainForm : Form
    {
        string[] titleArr   = new string[5];
        string[] artistArr  = new string[5];
        string[] genreArr   = new string[5];
        string[] urlArr     = new string[5];
        int[]    yearArr    = new int[5];
        int      maxSongs   = 5;
        int      songCount  = 0;
        public MainForm()
        {
            InitializeComponent();
            
            RegisterEvents();

        }
        private void AddButton_Click()
        {
            List<TextBox> textBoxList = new List<TextBox> 
            { 
                titleText,
                artistText,
                genreText,
                yearText,
                urlText
            };
           
            bool isValidInput = GenericUtils.ValidateInput(textBoxList);
            if (!isValidInput) return;

            StringBuilder sb = new StringBuilder(outputText.Text);
            string newLine = "\r\n";

            foreach (var item in textBoxList)
            {
                sb.Append(item.Text);
                sb.Append(newLine);
                
                if(songCount >= maxSongs)
                {
                    NoteBox.Show($"You have reached\n your {maxSongs} song limit");
                    return;
                }
                switch (item.Name)
                {
                    case "titleText":
                        songList.Items.Add(item.Text);
                        titleArr[songCount] = item.Text;
                        break;
                    case "artistText":
                        artistArr[songCount] = item.Text;
                        break;
                    case "genreText":
                        genreArr[songCount] = item.Text;
                        break;
                    case "urlText":
                        urlArr[songCount] = item.Text;
                        break;
                }
            }
            songCount++;
            sb.Append(newLine);

            outputText.Text = sb.ToString();

            foreach(var item in textBoxList)
            {
                item.Clear();
            }
        }
        private void ShowSongs_Click()
        {
            outputText.Clear();

            StringBuilder sb = new StringBuilder(String.Empty);
            string newLine = "\r\n";

            foreach(var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(newLine);
            }
            outputText.Text = sb.ToString();
        }
        private void RegisterEvents()
        {
            EventUtils eventUtils  = new EventUtils();
            headerPanel.MouseDown  += new MouseEventHandler(eventUtils.headerPanel_MouseDown);
            headerLabel.MouseDown  += new MouseEventHandler(eventUtils.headerPanel_MouseDown);

            addButton.MouseEnter   += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.Themes[Schemas.RED]);
            addButton.MouseLeave   += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            addButton.Click        += (sender, e) => eventUtils.OnMouseClick(sender, e, AddButton_Click);

            showSongs.MouseEnter   += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.Themes[Schemas.RED]); ;
            showSongs.MouseLeave   += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            showSongs.Click        += (sender, e) => eventUtils.OnMouseClick(sender, e, ShowSongs_Click);

            minimizeBtn.MouseClick += new MouseEventHandler(eventUtils.minimizeBtn_Click);
            minimizeBtn.MouseEnter += (sender, e) => eventUtils.OnMouseEnter(sender, e,Color.Empty, Schemas.Images[Schemas.MINIMIZE_HIGHLIGHTED]);
            minimizeBtn.MouseLeave += (sender, e) => eventUtils.OnMouseLeave(sender, e,Color.Empty, Schemas.Images[Schemas.MINIMIZE]);

            closeButton.MouseClick += new MouseEventHandler(eventUtils.closeButton_Click);
            closeButton.MouseEnter += (sender, e) => eventUtils.OnMouseEnter(sender, e,Color.Empty, Schemas.Images[Schemas.CLOSE_HIGHLIGHTED]);
            closeButton.MouseLeave += (sender, e) => eventUtils.OnMouseLeave(sender, e, Color.Empty, Schemas.Images[Schemas.CLOSE]);
        }

    }
}
