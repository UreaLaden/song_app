using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Mckinney_CourseProject_CEIS209.Utilities
{
    public class EventUtils
    {
        /// <summary>
        /// Implementing the Windows USER component that creates and
        /// manipulates the standard elements of the WIndows UI
        /// </summary>

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        public void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var control = (sender as Control).TopLevelControl;
            ReleaseCapture();
            SendMessage(control.Handle, 0x112, 0xf012, 0);

        }
        public void OnMouseEnter(object sender, EventArgs e, Color color,Image image =null)
        {
            Button button = (Button)sender;
            if (color != null)
            {
                button.ForeColor = color;
                button.Font = new Font(button.Font.FontFamily, 32);
            }
            if(image != null)
            {
                button.Image = image;
            }
        }

        public void OnMouseLeave(object sender, EventArgs e, Color color,Image image=null)
        {
            Button button = (Button)sender;
            if(color != null)
            {
                button.ForeColor = color;
                button.Font = new Font(button.Font.FontFamily, 16);
            }
            if(image != null)
            {
                button.Image = image;
            }
        }

        public void OnMouseClick(object sender, EventArgs e, Action callback)
        {
            callback();
        }

        public void addButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.ForeColor = Schemas.Themes[Schemas.BLACK];
            button.Font = new System.Drawing.Font(button.Font.FontFamily, 16);
        }

        public void showAllButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Schemas.Themes[Schemas.BLACK];
        }


        public void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void minimizeBtn_Click(object sender, EventArgs e)
        {
            Form form = (sender as Control).FindForm();
            form.WindowState = FormWindowState.Minimized;
        }
        public void minimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Schemas.Images[Schemas.MINIMIZE_HIGHLIGHTED];

        }
        public void minimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Schemas.Images[Schemas.MINIMIZE];
        }
        public void closeButton_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Schemas.Images[Schemas.CLOSE_HIGHLIGHTED];
        }
        public void closeButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Schemas.Images[Schemas.CLOSE];
        }

    }
}
