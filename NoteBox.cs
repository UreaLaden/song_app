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
    /// <summary>
    /// Custom MessageBox Implementation
    /// </summary>
    public partial class NoteBox : Form
    {
        public static NoteBox noteBox;
        public static string buttonId;
        public NoteBox()
        {
            InitializeComponent();
        }
        public static string Show(string messageText)
        {
            noteBox = new NoteBox();
            noteBox.noteBoxText.Text = messageText;
            //noteBox.pictureBoxImg.Size = new Size(128,128);
            noteBox.ShowDialog();
            return buttonId;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            noteBox.Dispose();
        }
    }
}
