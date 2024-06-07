using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class ArmourDetailsForm : Form
    {
        //
        //  Constructor
        //
        public ArmourDetailsForm(Armour armour)
        {
            InitializeComponent();

            InventoryObjectSetup(armour);
            EquipmentSetup(armour);

            typeLabel.Text = TypeMaps.ArmourCategoryNames[armour.ArmourCategory];

            string acStr = armour.BaseAC.ToString();
            if (armour.DexBonus)
                acStr += " + Dex";
            if (armour.MaxBonus > 0)
                acStr += string.Format(" (max {0})", armour.MaxBonus);

            acTextBox.Text = acStr;

            minStrTextBox.Text = armour.MinStrength > 0 ? armour.MinStrength.ToString() : "-";
            stealthTextBox.Text = armour.StealthDisadvantage ? "Disadvantage" : "-";

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

        //
        //  EquipmentSetup
        //
        private void EquipmentSetup(Equipment item)
        {
            typeLabel.Text = string.Empty;
            weightTextBox.Text = string.Format("{0} lbs", item.Weight);

            if (item.CostValue == 0)
                costTextBox.Text = "Free";
            else
                costTextBox.Text = string.Format("{0} {1}", item.CostValue, item.CostUnit);
        }
    }
}
