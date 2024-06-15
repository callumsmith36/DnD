/*********************************************************
 *  
 *  Name:       Items/EquipmentDetailsForm.cs
 *  
 *  Purpose:    Dialog for displaying the details of
 *              equipment
 *  
 *  Author:     CS
 *  
 *  Created:    07/04/2024
 * 
 *********************************************************/

using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class EquipmentDetailsForm : Form
    {
        //
        //  Constructor
        //
        public EquipmentDetailsForm(Equipment item)
        {
            InitializeComponent();
            InventoryObjectSetup(item);

            string typeStr = string.Empty;
            if (item is Tool)
            {
                Tool? tool = item as Tool;
                if (tool != null)
                    typeStr = TypeMaps.ToolCategoryNames[tool.ToolCategory];
            }
            else if (item is Gear)
            {
                Gear? gear = item as Gear;
                if (gear != null)
                    typeStr = TypeMaps.GearCategoryNames[gear.GearCategory];
            }
            else
            {
                typeStr = TypeMaps.EquipmentCategoryNames[item.EquipmentCategory];
            }

            if (typeStr.EndsWith('s'))
                typeStr = typeStr.Substring(0, typeStr.Length - 1);

            if (item.URL.Length > 0)
            {
                typeLabel.Text = typeStr;
                weightTextBox.Text = string.Format("{0} lbs", item.Weight);

                if (item.CostValue == 0)
                    costTextBox.Text = "Free";
                else
                    costTextBox.Text = string.Format("{0} {1}", item.CostValue, item.CostUnit);
            }
            else
            {
                // If the item has no URL, assume it is a temporary item
                typeLabel.Text = "Temporary Item";

                descLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                descTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                Controls.Remove(weightLabel);
                Controls.Remove(weightTextBox);
                Controls.Remove(costLabel);
                Controls.Remove(costTextBox);
                Size = new Size(Width, Height - weightLabel.Height - costLabel.Height - 10);
                descLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
