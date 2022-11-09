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

        public static string BLACK = "Black",RED="Red",BLUE="Blue",YELLOW="Yellow",WHITE="White", CHARTREUSE_WEB="ChartreuseWeb";
        public static string APPLE_GREEN = "Apple_Green", UA_RED = "UA_Red", LIGHT_GREEN = "LightGreen";
        public static string AMETHYST = "amethyst", GUNMETAL = "GunMetal", YALE_BLUE = "YaleBlue", MALACHITE = "Malachite";

        public static string ROOT = Path.GetFullPath("./").Split(new string[] { "bin" }, StringSplitOptions.None)[0];
        public static string IMG_PATH = Path.Combine(ROOT, "public", "styles");
        public static string OUTPUT_DIR = Path.Combine(Schemas.ROOT, "public", "data\\songs.xlsx");
         
        public static Dictionary<string, Color> Themes = new Dictionary<string, Color>()
        {
           {BLACK,  Color.FromArgb(35,31,32)},
           {BLUE , Color.FromArgb(126, 189, 194)},
           {WHITE, Color.FromArgb(239,230,221)},
           {RED , Color.FromArgb(187,68,48)},
           {YELLOW , Color.FromArgb(255,177,0)},
           {APPLE_GREEN,Color.FromArgb(124,181,24)},
           {UA_RED,Color.FromArgb(224,26,79)},
           {LIGHT_GREEN,Color.FromArgb(172, 243, 157)},
           {AMETHYST,Color.FromArgb(144, 103, 198)},
           {GUNMETAL,Color.FromArgb(36, 47, 64)},
           {YALE_BLUE,Color.FromArgb(8, 75, 131)},
           {MALACHITE,Color.FromArgb(4, 231, 98)},
           {CHARTREUSE_WEB,Color.FromArgb(137, 252, 0)}
        };

        public static Dictionary<string, Image> Images = new Dictionary<string, Image>()
        {
            {CLOSE,Image.FromFile(Path.Combine(IMG_PATH,"icons8-close-window-50.png"))},
            {CLOSE_HIGHLIGHTED,Image.FromFile(Path.Combine(IMG_PATH,"icons8-close-window-50_highlighted.png"))},
            {MINIMIZE,Image.FromFile(Path.Combine(IMG_PATH,"icons8-subtract-50.png"))},
            {MINIMIZE_HIGHLIGHTED,Image.FromFile(Path.Combine(IMG_PATH,"icons8-subtract-50_highlighted.png"))}
        };

        /// <summary>
        /// Returns a random color from our collection
        /// </summary>
        /// <returns></returns>
        public static Color GetRandomColor()
        {
            var choices = Themes.Keys.ToList();
            var filteredChoices = choices
                .Select(x => x)
                .Where(x=> x != BLACK && x != BLUE && x != WHITE)  //We don't want Black,White or Blue
                .ToList();
            var random = new Random();
            var index = random.Next(0, filteredChoices.Count);
            return Themes[filteredChoices[index]];
        }
    }
}
