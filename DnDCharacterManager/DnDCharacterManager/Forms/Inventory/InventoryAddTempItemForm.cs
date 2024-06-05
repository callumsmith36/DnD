using DND.API;
using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class InventoryAddTempItemForm : Form
    {
        private Equipment? _item;


        public InventoryAddTempItemForm()
        {
            InitializeComponent();
            _item = null;
        }


        public Equipment? GetItem()
        {
            return _item;
        }


        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (APIReadWrite.CheckEquipmentExists(name) || APIReadWrite.CheckMagicItemExists(name))
            {
                MessageBox.Show("An item already exists with that index.", "D&D Character Manager");
                return;
            }

            List<string> descLines = new List<string>();
            foreach (var line in descTextBox.Lines)
            {
                if (line.Length > 0)
                    descLines.Add(line);
            }

            _item = new Equipment(name, EquipmentCategory.None, 0f, 0, "", descLines.ToArray(), false);

            if (Session.Player.Inventory.Contains(_item))
            {
                MessageBox.Show("Your inventory already contains an item with that index.", "D&D Character Manager");
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
