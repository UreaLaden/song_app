using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Mckinney_CourseProject_CEIS209.Utilities;

namespace Mckinney_CourseProject_CEIS209
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Implementing the Windows USER component that creates and
        /// manipulates the standard elements of the WIndows UI
        /// </summary>
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three,int four);
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

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState |= FormWindowState.Minimized;
        }

        private void minimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            minimizeBtn.Image = Schemas.Images[Schemas.MINIMIZE_HIGHLIGHTED];
            
        }

        private void minimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.Image = Schemas.Images[Schemas.MINIMIZE];
            minimizeBtn.Size = new Size(55, 58);
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Schemas.Images[Schemas.CLOSE_HIGHLIGHTED];
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Schemas.Images[Schemas.CLOSE];
        }
    }
}
