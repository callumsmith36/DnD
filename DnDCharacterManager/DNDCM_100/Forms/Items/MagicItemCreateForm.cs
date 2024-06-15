/*********************************************************
 *  
 *  Name:       Items/MagicItemCreateForm.cs
 *  
 *  Purpose:    Dialog for creating a magic item
 *  
 *  Author:     CS
 *  
 *  Created:    20/04/2024
 * 
 *********************************************************/

using DND.API;
using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class MagicItemCreateForm : Form
    {
        private MagicItem? _item;


        public MagicItemCreateForm()
        {
            InitializeComponent();

            categoryComboBox.SelectedIndex = 0;
            rarityComboBox.SelectedIndex = 0;
        }


        //
        //  GetItem
        //
        public MagicItem? GetItem()
        {
            return _item;
        }


        //
        //  okBtn_Click
        //
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Name is required.", "D&D Character Manager");
                return;
            }

            if (APIReadWrite.CheckEquipmentExists(name) || APIReadWrite.CheckMagicItemExists(name))
            {
                MessageBox.Show("An item already exists with that index.", "D&D Character Manager");
                return;
            }

            EquipmentCategory category;
            switch (categoryComboBox.Text.ToLower())
            {
                case "weapon":          category = EquipmentCategory.Weapon;    break;
                case "armour":          category = EquipmentCategory.Armour;    break;
                case "potion":          category = EquipmentCategory.Potion;    break;
                case "ring":            category = EquipmentCategory.Ring;      break;
                case "rod":             category = EquipmentCategory.Rod;       break;
                case "scroll":          category = EquipmentCategory.Scroll;    break;
                case "staff":           category = EquipmentCategory.Staff;     break;
                case "wand":            category = EquipmentCategory.Wand;      break;
                case "wondrous item":   category = EquipmentCategory.Wondrous;  break;
                default:
                    category = EquipmentCategory.None;
                    break;
            }

            List<string> variants = new List<string>();
            foreach (var line in variantsTextBox.Lines)
            {
                if (line.Length > 0)
                    variants.Add(line);
            }

            List<string> descLines = new List<string>();
            foreach (var line in descTextBox.Lines)
            {
                if (line.Length > 0)
                    descLines.Add(line);
            }

            _item = new MagicItem(
                name,
                category,
                rarityComboBox.Text,
                descLines.ToArray(),
                attunementCheckBox.Checked,
                isVariantCheckBox.Checked,
                variants.ToArray()
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        //
        //  cancelBtn_Click
        //
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
