using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class WeaponDetailsForm : Form
    {
        //
        //  Constructor
        //
        public WeaponDetailsForm(Weapon weapon)
        {
            InitializeComponent();

            InventoryObjectSetup(weapon);
            EquipmentSetup(weapon);

            string categoryStr = string.Empty;
            if (weapon.WeaponCategory == WeaponType.SimpleWeapons)
                categoryStr = "Simple";
            else if (weapon.WeaponCategory == WeaponType.MartialWeapons)
                categoryStr = "Martial";

            if (categoryStr.Length > 0)
                typeLabel.Text = categoryStr + " " + weapon.RangeString;
            else
                typeLabel.Text += weapon.RangeString;

            weightTextBox.Text = string.Format("{0} lbs", weapon.Weight);
            costTextBox.Text = string.Format("{0} {1}", weapon.CostValue, weapon.CostUnit);

            damageTextBox.Text = weapon.DamageDicePrimary + " " + weapon.DamageType.ToLower();

            string rangeStr = weapon.Range.Normal.ToString();
            if (weapon.Range.Long > 0)
                rangeStr += " / " + weapon.Range.Long.ToString();

            rangeTextBox.Text = rangeStr;

            int tableHeight = propTable.Height;
            foreach (var prop in weapon.Properties)
            {
                Label propLabel = new Label();
                propLabel.Font = new Font(weightLabel.Font, FontStyle.Regular);
                propLabel.Size = new Size(Width - propLabel.Location.X - 12, propLabel.Height);
                propLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                switch (prop)
                {
                    case WeaponProperty.Ammunition: propLabel.Text = "Ammunition";  break;
                    case WeaponProperty.Finesse:    propLabel.Text = "Finesse";     break;
                    case WeaponProperty.Light:      propLabel.Text = "Light";       break;
                    case WeaponProperty.Heavy:      propLabel.Text = "Heavy";       break;
                    case WeaponProperty.Loading:    propLabel.Text = "Loading";     break;
                    case WeaponProperty.Monk:       propLabel.Text = "Monk";        break;
                    case WeaponProperty.Range:      propLabel.Text = "Range";       break;
                    case WeaponProperty.Reach:      propLabel.Text = "Reach";       break;
                    case WeaponProperty.Special:    propLabel.Text = "Special";     break;
                    case WeaponProperty.TwoHanded:  propLabel.Text = "Two-handed";  break;
                    case WeaponProperty.Thrown:
                        propLabel.Text = string.Format("Thrown (range {0}/{1})", weapon.ThrownRange.Normal, weapon.ThrownRange.Long);
                        break;
                    case WeaponProperty.Versatile:
                        propLabel.Text = string.Format("Versatile ({0})", weapon.DamageDiceSecondary);
                        break;
                    default:
                        continue;
                }

                propTable.Controls.Add(propLabel);
            }

            // Remove the top anchors from the description label and text box before resizing the
            // form so that they get moved down rather than the text box being stretched
            descLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            descTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Size = new Size(Width, Height + propTable.Height - tableHeight);

            // Reset the anchors
            descLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Remove special components if not used
            if (weapon.Special.Length == 0)
            {
                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                Size = new Size(Width, Height - specialLabel.Height - specialTextBox.Height - 10);
                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                Controls.Remove(specialLabel);
                Controls.Remove(specialTextBox);
            }
            else
            {
                // Write special
                List<string> tempLines = new List<string>();
                for (int i = 0; i < weapon.Special.Length; i++)
                {
                    tempLines.Add(weapon.Special[i]);

                    if (i < weapon.Special.Length - 1)
                        tempLines.Add("\n");
                }

                specialTextBox.Lines = tempLines.ToArray();

                if (!Controls.Contains(descTextBox))
                {
                    Size = new Size(Width, Height - 10);
                    specialLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    specialTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    Size = new Size(Width + 10, Height + 20);
                }    
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
