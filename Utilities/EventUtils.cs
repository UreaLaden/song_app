using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

        /// <summary>
        /// Lets us drag the dialog box around by holding down the moust button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var control = (sender as Control).TopLevelControl;
            ReleaseCapture();
            SendMessage(control.Handle, 0x112, 0xf012, 0);

        }
        /// <summary>
        /// For normal buttons change color on mouse over. For others replaces the button image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="color"></param>
        /// <param name="image"></param>
        /// <param name="isUtilityButton"></param>
        public void OnMouseEnter(object sender, EventArgs e, Color color,Image image =null,bool isUtilityButton = false)
        {
            Button button = (Button)sender;
            if (color != null)
            {
                button.BackColor = color;
                button.Font = new Font(button.Font.FontFamily, isUtilityButton ? 10 : 32);
            }
            if(image != null)
            {
                button.Image = image;
            }
        }

        /// <summary>
        /// For normal buttons change color on mouseover. For all others replace the button image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="color"></param>
        /// <param name="image"></param>
        /// <param name="isUtilityButton"></param>
        public void OnMouseLeave(object sender, EventArgs e, Color color,Image image=null,bool isUtilityButton = false)
        {
            Button button = (Button)sender;
            if(color != Color.Empty)
            {
                button.ForeColor = color;
                button.BackColor = Schemas.Themes[Schemas.BLUE];
                button.Font = new Font(button.Font.FontFamily, isUtilityButton ? 8 : 16);
            }
            if(image != null)
            {
                button.Image = image;
                button.BackColor = Schemas.Themes[Schemas.BLACK];
            }
        }

        /// <summary>
        /// Execute callback function on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="callback"></param>
        public void OnMouseClick(object sender, EventArgs e, Action callback)
        {
            callback();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Minimize the dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void minimizeBtn_Click(object sender, EventArgs e)
        {
            Form form = (sender as Control).FindForm();
            form.WindowState = FormWindowState.Minimized;
        }
     
    }
}
