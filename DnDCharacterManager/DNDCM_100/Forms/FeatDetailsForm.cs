/*********************************************************
 *  
 *  Name:       FeatDetailsForm.cs
 *  
 *  Purpose:    Dialog for displaying the details of a feat
 *  
 *  Author:     CS
 *  
 *  Created:    22/04/2024
 * 
 *********************************************************/

using DND;

namespace CharacterManager
{
    public partial class FeatDetailsForm : Form
    {
        public FeatDetailsForm(Feat feat)
        {
            InitializeComponent();

            nameTextBox.Text = feat.Name;

            string sourceStr;
            switch (feat.Source)
            {
                case Feat.FeatSource.Class: sourceStr = "Class: ";  break;
                case Feat.FeatSource.Race:  sourceStr = "Race: ";   break;
                default:
                    sourceStr = string.Empty;
                    break;
            }

            sourceStr += feat.SourceName;
            sourceLabel.Text = sourceStr;

            string usesStr;
            if (feat.LimitedUse)
            {
                usesStr = string.Format("{0} per ", feat.MaxUses);
                switch (feat.Frequency)
                {
                    case Feat.FeatFrequency.ShortRest:  usesStr += "short rest";    break;
                    case Feat.FeatFrequency.LongRest:   usesStr += "long rest";     break;
                    case Feat.FeatFrequency.Daily:      usesStr += "day";           break;
                    default:
                        break;
                }
            }
            else
            {
                usesStr = "-";
            }

            usesTextBox.Text = usesStr;

            // Write description
            List<string> tempLines = new List<string>();
            for (int i = 0; i < feat.Description.Length; i++)
            {
                tempLines.Add(feat.Description[i]);

                if (i < feat.Description.Length - 1)
                    tempLines.Add("\n");
            }

            descTextBox.Lines = tempLines.ToArray();
        }
    }
}
