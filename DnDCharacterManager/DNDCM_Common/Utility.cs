/*********************************************************
 *  
 *  Name:       Utility.cs
 *  
 *  Purpose:    Various general routines for
 *              processing/manipulating data
 *  
 *  Author:     CS
 *  
 *  Created:    07/01/2024
 * 
 *********************************************************/

namespace CharacterManager
{
    internal static class Utility
    {
        //
        //  CheckNumericInput
        //
        internal static void CheckNumericInput(bool allowDecimal, TextBox textBox, KeyPressEventArgs e, Action? OnEnter = null)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (OnEnter != null)
                    OnEnter();

                e.Handled = true;
            }
            else if (allowDecimal && e.KeyChar == '.')
            {
                if (textBox.Text.Contains("."))
                    e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //
        //  CheckModifierInput
        //
        internal static void CheckModifierInput(TextBox textBox, KeyPressEventArgs e, Action? OnEnter = null)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (OnEnter != null)
                    OnEnter();

                e.Handled = true;
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-')
            {
                // Only allow +/- as first character
                if (textBox.Text.Length > 0)
                    e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //
        //  StringToArray
        //
        internal static string[] StringToArray(string desc)
        {
            List<string> descList = new List<string>();
            string line = string.Empty;

            for (int i = 0; i <= desc.Length; i++)
            {
                if (i == desc.Length)
                {
                    if (line.Length > 0)
                        descList.Add(line);

                    break;
                }

                // At the end of each line, add the current line
                // to the list and reset for the next line
                if (desc[i] == '\n')
                {
                    if (line.Length > 0)
                    {
                        descList.Add(line);
                        line = string.Empty;
                    }

                    continue;
                }

                line += desc[i];
            }

            return descList.ToArray();
        }

        //
        //  StringArrayToTextBox
        //
        internal static void StringArrayToTextBox(string[] strings, TextBox textBox)
        {
            var lines = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                lines.Add(strings[i]);

                if (i < strings.Length - 1)
                    lines.Add("\n");
            }

            textBox.Lines = lines.ToArray();
        }

        //
        //  TextBoxToStringArray
        //
        internal static string[] TextBoxToStringArray(TextBox textBox)
        {
            List<string> lines = new List<string>();
            foreach (var line in textBox.Lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                    lines.Add(line);
            }

            return lines.ToArray();
        }
    }
}
