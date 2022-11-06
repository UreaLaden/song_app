using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Mckinney_CourseProject_CEIS209.Utilities
{
    public static class Schemas
    {
        public static string CLOSE = "Close", CLOSE_HIGHLIGHTED = "Close_highlighted";
        public static string MINIMIZE = "Minimize", MINIMIZE_HIGHLIGHTED = "Minimize-Highlighted";
        public static string BLACK = "Black",RED="Red",BLUE="Blue",YELLOW="Yellow",WHITE="White";
        public static string ROOT = Path.GetFullPath("./").Split(new string[] { "bin" }, StringSplitOptions.None)[0];
        public static string IMG_PATH = Path.Combine(ROOT, "public", "styles");
         
        public static Dictionary<string, Color> Themes = new Dictionary<string, Color>()
        {
           {BLACK,  Color.FromArgb(35,31,32) },
           {RED , Color.FromArgb(187,68,48)},
           {BLUE , Color.FromArgb(131,163,199)},
           { YELLOW , Color.FromArgb(255,117,0)},
            {WHITE, Color.FromArgb(239,230,221)}
        };

        public static Dictionary<string, Image> Images = new Dictionary<string, Image>()
        {
            {CLOSE,Image.FromFile(Path.Combine(IMG_PATH,"icons8-close-window-50.png"))},
            {CLOSE_HIGHLIGHTED,Image.FromFile(Path.Combine(IMG_PATH,"icons8-close-window-50_highlighted.png"))},
            {MINIMIZE,Image.FromFile(Path.Combine(IMG_PATH,"icons8-subtract-50.png"))},
            {MINIMIZE_HIGHLIGHTED,Image.FromFile(Path.Combine(IMG_PATH,"icons8-subtract-50_highlighted.png"))}
        };
    }
}
