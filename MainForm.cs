using Mckinney_CourseProject_CEIS209.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Mckinney_CourseProject_CEIS209
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            #region UI Configuration
            
            EventUtils eventUtils = new EventUtils();
            headerPanel.MouseDown += new MouseEventHandler(eventUtils.headerPanel_MouseDown);
            headerLabel.MouseDown += new MouseEventHandler(eventUtils.headerPanel_MouseDown);

            addButton.MouseEnter += new EventHandler(eventUtils.addButton_MouseEnter);
            addButton.MouseLeave += new EventHandler(eventUtils.addButton_MouseLeave);

            showSongs.MouseEnter += new EventHandler(eventUtils.showAllButton_MouseEnter);
            showSongs.MouseLeave += new EventHandler(eventUtils.showAllButton_MouseLeave);

            minimizeBtn.MouseClick += new MouseEventHandler(eventUtils.minimizeBtn_Click);
            minimizeBtn.MouseEnter += new EventHandler(eventUtils.minimizeBtn_MouseEnter);
            minimizeBtn.MouseLeave += new EventHandler(eventUtils.minimizeBtn_MouseLeave);

            closeButton.MouseClick += new MouseEventHandler(eventUtils.closeButton_Click);
            closeButton.MouseEnter += new EventHandler(eventUtils.closeButton_MouseEnter);
            closeButton.MouseLeave += new EventHandler(eventUtils.closeButton_MouseLeave);
       
        #endregion

        }
        private void addButton_Click(object sender, EventArgs e)
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
                
                DialogResult result = MessageBox.Show($"The {field} Cannot be blank");
                
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

        private void showSongs_Click(object sender, EventArgs e)
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



    }
}
