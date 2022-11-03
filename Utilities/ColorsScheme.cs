using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Mckinney_CourseProject_CEIS209.Utilities
{
    public static class Schemas
    {
        public static string CLOSE = "Close", CLOSE_HIGHLIGHTED = "Close_highlighted";
        public static string MINIMIZE = "Minimize", MINIMIZE_HIGHLIGHTED = "Minimize-Highlighted";
        public static string BLACK = "Black",RED="Red",BLUE="Blue",YELLOW="Yellow",WHITE="White";

        public static Dictionary<string, Color> Themes = new Dictionary<string, Color>()
        {
           {BLACK,  Color.FromArgb(35,31,32) },
           {RED , Color.FromArgb(187,68,48)},
           {BLUE , Color.FromArgb(131,163,199)},
           { YELLOW , Color.FromArgb(243,223,162)},
           {WHITE, Color.FromArgb(239,230,221)}
        };

        public static Dictionary<string, Image> Images = new Dictionary<string, Image>()
        {
            {CLOSE,Image.FromFile("D:\\Devry\\CEIS209\\Mckinney_CourseProject_CEIS209\\public\\styles\\icons8-close-window-50.png")},
            {CLOSE_HIGHLIGHTED,Image.FromFile("D:\\Devry\\CEIS209\\Mckinney_CourseProject_CEIS209\\public\\styles\\icons8-close-window-50_highlighted.png")},
            {MINIMIZE,Image.FromFile("D:\\Devry\\CEIS209\\Mckinney_CourseProject_CEIS209\\public\\styles\\icons8-subtract-50.png")},
            {MINIMIZE_HIGHLIGHTED,Image.FromFile("D:\\Devry\\CEIS209\\Mckinney_CourseProject_CEIS209\\public\\styles\\icons8-subtract-50_highlighted.png")}
        };
    }
}
