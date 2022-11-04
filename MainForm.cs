using Mckinney_CourseProject_CEIS209.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mckinney_CourseProject_CEIS209
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            RegisterEvents();

        }
        private void addButton_Click()
        {
            List<TextBox> textBoxList = new List<TextBox> 
            { 
                titleText,
                artistText,
                genreText,
                yearText,
                urlText
            };
            var filteredStrings = textBoxList.Where(x => string.IsNullOrEmpty(x.Text)).Select(x => x.Name).ToList();
            bool containsEmptyStrings = filteredStrings.Count > 0;

            if (containsEmptyStrings)
            {
                var baseWord = filteredStrings[0].Split('T')[0];
                var field = char.ToUpper(baseWord.First()) + baseWord.Substring(1).ToLower();
                
                DialogResult result = MessageBox.Show($"The {field} Cannot be blank"); //TODO: Need a custom message box
                
                return;
            }

            StringBuilder sb = new StringBuilder(outputText.Text);
            string newLine = "\r\n";

            foreach (var item in textBoxList)
            {
                sb.Append(item.Text);
                sb.Append(newLine);

                if (item.Name == "titleText")
                {
                    songList.Items.Add(item.Text);
                }
            }
            sb.Append(newLine);

            outputText.Text = sb.ToString();

            foreach(var item in textBoxList)
            {
                item.Clear();
            }
        }
        private void showSongs_Click()
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

        /// <summary>
        /// Subscribes to the UI related events
        /// </summary>
        private void RegisterEvents()
        {
            EventUtils eventUtils  = new EventUtils();
            headerPanel.MouseDown  += new MouseEventHandler(eventUtils.headerPanel_MouseDown);
            headerLabel.MouseDown  += new MouseEventHandler(eventUtils.headerPanel_MouseDown);

            addButton.MouseEnter   += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.Themes[Schemas.RED]);
            addButton.MouseLeave   += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            addButton.Click        += (sender, e) => eventUtils.OnMouseClick(sender, e, addButton_Click);

            showSongs.MouseEnter   += (sender, e) => eventUtils.OnMouseEnter(sender, e, Schemas.Themes[Schemas.RED]); ;
            showSongs.MouseLeave   += (sender, e) => eventUtils.OnMouseLeave(sender, e, Schemas.Themes[Schemas.BLACK]);
            showSongs.Click        += (sender, e) => eventUtils.OnMouseClick(sender, e, showSongs_Click);

            minimizeBtn.MouseClick += new MouseEventHandler(eventUtils.minimizeBtn_Click);
            minimizeBtn.MouseEnter += (sender, e) => eventUtils.OnMouseEnter(sender, e,Color.Empty, Schemas.Images[Schemas.MINIMIZE_HIGHLIGHTED]);
            minimizeBtn.MouseLeave += (sender, e) => eventUtils.OnMouseLeave(sender, e,Color.Empty, Schemas.Images[Schemas.MINIMIZE]);

            closeButton.MouseClick += new MouseEventHandler(eventUtils.closeButton_Click);
            closeButton.MouseEnter += (sender, e) => eventUtils.OnMouseEnter(sender, e,Color.Empty, Schemas.Images[Schemas.CLOSE_HIGHLIGHTED]);
            closeButton.MouseLeave += (sender, e) => eventUtils.OnMouseLeave(sender, e, Color.Empty, Schemas.Images[Schemas.CLOSE]);
        }

    }
}
