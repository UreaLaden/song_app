using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mckinney_CourseProject_CEIS209.Utilities
{
    public static class GenericUtils
    {
        /// <summary>
        /// Checks textBox input fields to determine if any are non empty. 
        /// Displays Message box if an empty input field is found
        /// </summary>
        /// <param name="textBoxList"></param>
        /// <returns>False if any fiels are empty.</returns>
        public static bool ValidateInput(List<TextBox> textBoxList)
        {
            var filteredStrings = textBoxList.Where(x => string.IsNullOrEmpty(x.Text)).Select(x => x.Name).ToList();
            bool containsEmptyStrings = filteredStrings.Count > 0;

            if (containsEmptyStrings)
            {
                var baseWord = filteredStrings[0].Split('T')[0];
                var field = char.ToUpper(baseWord.First()) + baseWord.Substring(1).ToLower();

                NoteBox.Show($"The {field} Cannot be blank");

                return false;
            }
            return true;
        }
    }
}
