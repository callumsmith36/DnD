/*********************************************************
 *  
 *  Name:       Spells/SpellDetailsForm.cs
 *  
 *  Purpose:    Dialog for displaying the details of a
 *              spell
 *  
 *  Author:     CS
 *  
 *  Created:    01/04/2024
 * 
 *********************************************************/

using DND;

namespace CharacterManager
{
    public partial class SpellDetailsForm : Form
    {
        public SpellDetailsForm(Spell spell)
        {
            InitializeComponent();

            string tempStr;

            nameTextBox.Text = spell.Name;

            // Write spell level and school
            if (spell.Level == 0)
            {
                levelSchoolLabel.Text = string.Format("{0} cantrip", spell.School);
            }
            else
            {
                tempStr = string.Format("{0} {1}", Spell.GetLevelString(spell.Level), spell.School.ToLower());
                if (spell.IsRitual)
                    tempStr += " (ritual)";

                levelSchoolLabel.Text = tempStr;
            }

            // Write casting time and range
            timeTextBox.Text = spell.CastingTime;
            rangeTextBox.Text = spell.Range;

            // Write components and material
            if (spell.Components.Contains('M'))
            {
                // Make start of material string lower case and remove full stop
                tempStr = char.ToLower(spell.Material[0]) + spell.Material.Substring(1);
                if (tempStr.EndsWith('.'))
                    tempStr = tempStr.Remove(tempStr.Length - 1);

                componentsTextBox.Text = string.Format("{0} ({1})", spell.Components, tempStr);
            }
            else
            {
                componentsTextBox.Text = spell.Components;
            }

            // Write duration
            if (spell.IsConcentration)
                durationTextBox.Text = string.Format("Concentration, {0}", spell.Duration.ToLower());
            else
                durationTextBox.Text = spell.Duration;

            // Write description
            Utility.StringArrayToTextBox(spell.Description, descTextBox);

            // Write 'at higher level' description
            if (spell.HigherLevel.Length > 0)
            {
                Utility.StringArrayToTextBox(spell.HigherLevel, higherLvlTextBox);
            }
            else
            {
                // Remove these components if the spell can't be cast at higher levels

                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                Size = new Size(Width, Height - higherLvlLabel.Height - higherLvlTextBox.Height - 10);
                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                Controls.Remove(higherLvlLabel);
                Controls.Remove(higherLvlTextBox);
            }

            Size textSize = TextRenderer.MeasureText(componentsTextBox.Text, componentsTextBox.Font);
            if (textSize.Width > componentsTextBox.Width)
            {
                // Increase the widths of the text box and the form by the
                // same amount to fit the full material description

                int diff = textSize.Width - componentsTextBox.Width;
                componentsTextBox.Width = textSize.Width;
                Size = new Size(Width + diff, Height);
            }

            MinimumSize = new Size(Width - 1, Height - 1);
        }
    }
}
