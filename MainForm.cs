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
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_NCPAINT = 0x85;
            if(m.Msg == WM_NCPAINT)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.FillRectangle(Brushes.Red, new Rectangle(0, 0, 4800, 30));
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }
            }
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
                MessageBox.Show($"The {field} Cannot be blank");
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
