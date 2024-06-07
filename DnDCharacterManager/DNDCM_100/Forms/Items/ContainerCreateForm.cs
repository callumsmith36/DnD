using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class ContainerCreateForm : Form
    {
        public ContainerCreateForm(InventoryObject item)
        {
            InitializeComponent();

            baseNameTextBox.Text = item.Name;

            int n = 1;
            string nameStr = item.Name;
            while (Session.Player.Inventory.TryGetContainer(nameStr, out var container) == true)
            {
                nameStr = string.Format("{0} ({1})", item.Name, n++);
            }

            nameTextBox.Text = nameStr;

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
            else if (item is Equipment)
            {
                Equipment? equipment = item as Equipment;
                if (equipment != null)
                    typeStr = TypeMaps.EquipmentCategoryNames[equipment.EquipmentCategory];
            }
            else if (item is MagicItem)
            {
                MagicItem? magicItem = item as MagicItem;
                if (magicItem != null)
                    typeStr = magicItem.Rarity;
            }

            if (typeStr.EndsWith('s'))
                typeStr = typeStr.Substring(0, typeStr.Length - 1);

            typeLabel.Text = typeStr;
        }


        public string GetName()
        {
            return nameTextBox.Text;
        }


        private void okBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (Session.Player.Inventory.TryGetContainer(nameTextBox.Text, out var container) == true)
            {
                MessageBox.Show("A container with that index already exists in your inventory.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
