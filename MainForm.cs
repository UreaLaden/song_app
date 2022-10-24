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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string newLine = "\r\n";

            sb.Append(titleText.Text);
            sb.Append(newLine);
            sb.Append(artistText.Text);
            sb.Append(newLine);
            sb.Append(genreText.Text);
            sb.Append(newLine);
            sb.Append(yearText.Text);
            sb.Append(newLine);
            sb.Append(urlText.Text);
            sb.Append(newLine);
            sb.Append(newLine);

            outputText.Text = sb.ToString();

            titleText.Clear();
            artistText.Clear();
            genreText.Clear();
            yearText.Clear();
            urlText.Clear();
        }
    }
}
