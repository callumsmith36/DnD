/*********************************************************
 *  
 *  Name:       Items/MagicItemDetailsForm.cs
 *  
 *  Purpose:    Dialog for displaying the details of a
 *              magic item
 *  
 *  Author:     CS
 *  
 *  Created:    07/04/2024
 * 
 *********************************************************/

using DND.InventorySystem;

namespace CharacterManager
{
    public partial class MagicItemDetailsForm : Form
    {
        //
        //  Constructor
        //
        public MagicItemDetailsForm(MagicItem item)
        {
            InitializeComponent();

            InventoryObjectSetup(item);

            typeLabel.Text = item.Rarity;

            if (item.Variants.Length > 0)
            {
                int tableHeight = variantTable.Height;
                foreach (var variant in item.Variants)
                {
                    Label variantLabel = new Label();
                    variantLabel.Font = new Font("Constantia", 10, FontStyle.Regular);
                    variantLabel.Size = new Size(Width - variantLabel.Location.X - 12, variantLabel.Height);
                    variantLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    variantLabel.Text = variant;

                    variantTable.Controls.Add(variantLabel);
                }

                // Remove the top anchors from the description label and text box before resizing the
                // form so that they get moved down rather than the text box being stretched
                descLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                descTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                Size = new Size(Width, Height + variantTable.Height - tableHeight);

                // Reset description anchors
                descLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
            else
            {
                Label variantLabel = new Label();
                variantLabel.Font = new Font("Constantia", 10, FontStyle.Regular);
                variantLabel.Size = new Size(Width - variantLabel.Location.X - 12, variantLabel.Height);
                variantLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                variantLabel.Text = "-";

                variantTable.Controls.Add(variantLabel);
            }

            MinimumSize = new Size(Width - 1, Height - 1);
        }


        //
        //  InventoryObjectSetup
        //
        private void InventoryObjectSetup(InventoryObject item)
        {
            nameTextBox.Text = item.Name;

            // Remove description components if not used
            if (item.Description.Length == 0)
            {
                Size = new Size(Width, Height - descLabel.Height - descTextBox.Height - 10);

                Controls.Remove(descLabel);
                Controls.Remove(descTextBox);
            }
            else
            {
                // Write description
                List<string> tempLines = new List<string>();
                for (int i = 0; i < item.Description.Length; i++)
                {
                    tempLines.Add(item.Description[i]);

                    if (i < item.Description.Length - 1)
                        tempLines.Add("\n");
                }

                descTextBox.Lines = tempLines.ToArray();
            }
        }
    }
}
