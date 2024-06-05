using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class InventoryForm : Form
    {
        private static readonly string
            _generalDesc = "General equipment that does not fit into the other categories. Here, you can also add temporary custom items that exist only in your inventory and are not added to the database.";
        private static readonly string
            _weaponDesc = "Non-magical weapons.";
        private static readonly string
            _armourDesc = "Non-magical armour.";
        private static readonly string
            _magicDesc = "Magical items (excluding potions).";
        private static readonly string
            _potionDesc = "All potions.";
        private static readonly string
            _toolDesc = "All tools and kits.";
        private static readonly string
            _packDesc = "Equipment packs, bags, and other containers. Add an item marked with the corresponding keyword to create an empty container for storing other items.";

        private InventoryObjectCollection _itemCollection;


        //
        //  Constructor
        //
        public InventoryForm(InventoryObjectCollection? items = null)
        {
            InitializeComponent();

            _itemCollection = items != null ? items : Session.Player.Inventory;

            categoryDescTextBox.Text = _generalDesc;

            if (items == Session.Player.Inventory && Session.Player.Name.Length > 0)
            {
                Text = string.Format("{0}'s Inventory", Session.Player.Name);
            }
            else if (items is Container)
            {
                Container? container = items as Container;
                if (container != null)
                    Text = container.Name;

                invTabCtrl.TabPages.Remove(containerTab);

                invTabCtrl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                Size = new Size(Width, Height - categoryDescGroup.Height);
                Controls.Remove(categoryDescGroup);
                invTabCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }

            cpCtrl.Value = _itemCollection.CP;
            spCtrl.Value = _itemCollection.SP;
            gpCtrl.Value = _itemCollection.GP;
            ppCtrl.Value = _itemCollection.PP;

            PopulateItemTables();
        }


        //
        //  CreateInventoryItemCtrl
        //
        private InventoryItemCtrl CreateInventoryItemCtrl(InventoryObject obj, int qty, bool isContainer = false)
        {
            InventoryItemCtrl ctrl = new InventoryItemCtrl(obj, qty, isContainer);
            ctrl.OnItemEquipped += InventoryItemCtrl_OnItemEquipped;
            ctrl.OnItemAttuned += InventoryItemCtrl_OnItemAttuned;
            ctrl.OnItemRemoved += InventoryItemCtrl_OnItemRemoved;

            return ctrl;
        }

        //
        //  PopulateItemTables
        //
        private void PopulateItemTables()
        {
            InventoryItemCtrl itemCtrl;
            List<Equipment> toolsKits = new List<Equipment>();
            bool isContainer = _itemCollection is Container;

            generalTable.Visible = false;
            weaponTable.Visible = false;
            armourTable.Visible = false;
            magicTable.Visible = false;
            potionTable.Visible = false;
            toolTable.Visible = false;

            // Populate general table
            foreach (var item in _itemCollection.GetGeneralEquipmentList(true))
            {
                if (item is Gear)
                {
                    Gear? gear = item as Gear;
                    if (gear != null)
                    {
                        if (gear.GearCategory == GearCategory.Kit)
                        {
                            toolsKits.Add(gear);
                        }
                        else
                        {
                            itemCtrl = CreateInventoryItemCtrl(gear, _itemCollection.GetQuantity(gear), isContainer);
                            generalTable.Controls.Add(itemCtrl);
                        }
                    }
                }
                else
                {
                    itemCtrl = CreateInventoryItemCtrl(item, _itemCollection.GetQuantity(item), isContainer);
                    generalTable.Controls.Add(itemCtrl);
                }
            }

            // Populate weapon table
            foreach (var weapon in _itemCollection.GetWeaponList(true))
            {
                itemCtrl = CreateInventoryItemCtrl(weapon, _itemCollection.GetQuantity(weapon), isContainer);
                weaponTable.Controls.Add(itemCtrl);
            }

            // Populate armour table
            foreach (var armour in _itemCollection.GetArmourList(true))
            {
                itemCtrl = CreateInventoryItemCtrl(armour, _itemCollection.GetQuantity(armour), isContainer);
                armourTable.Controls.Add(itemCtrl);
            }

            // Populate magic item table
            foreach (var item in _itemCollection.GetMagicItemList(true))
            {
                itemCtrl = CreateInventoryItemCtrl(item, _itemCollection.GetQuantity(item), isContainer);
                magicTable.Controls.Add(itemCtrl);
            }

            // Populate potion table
            foreach (var potion in _itemCollection.GetPotionList(true))
            {
                itemCtrl = CreateInventoryItemCtrl(potion, _itemCollection.GetQuantity(potion), isContainer);
                potionTable.Controls.Add(itemCtrl);
            }

            // Populate tool table
            foreach (var item in _itemCollection.GetToolList())
            {
                int i;

                for (i = 0; i < toolsKits.Count; i++)
                {
                    if (string.Compare(item.Name, toolsKits[i].Name) == -1)
                        break;
                }

                if (i < toolsKits.Count)
                    toolsKits.Insert(i, item);
                else
                    toolsKits.Add(item);
            }

            foreach (var item in toolsKits)
            {
                int quantity = item is Tool ? _itemCollection.GetQuantity(item as Tool) : _itemCollection.GetQuantity(item);

                itemCtrl = CreateInventoryItemCtrl(item, quantity, isContainer);
                toolTable.Controls.Add(itemCtrl);
            }

            if (_itemCollection == Session.Player.Inventory)
            {
                containerTable.Visible = false;

                // Populate pack table
                foreach (var container in Session.Player.Inventory.GetContainerList())
                {
                    var ctrl = new InventoryContainerCtrl(container);
                    ctrl.OnContainerRemoved += InventoryContainerCtrl_OnContainerRemoved;
                    containerTable.Controls.Add(ctrl);
                }

                containerTable.Visible = true;
            }

            generalTable.Visible = true;
            weaponTable.Visible = true;
            armourTable.Visible = true;
            magicTable.Visible = true;
            potionTable.Visible = true;
            toolTable.Visible = true;
        }

        //
        //  addBtn_Click
        //
        private void addBtn_Click(object sender, EventArgs e)
        {
            int startCount = _itemCollection.Count;

            var prompt = new InventoryAddItemPrompt();

            if (_itemCollection is Inventory)
                prompt.ShowDialog();

            if (_itemCollection is not Inventory || prompt.Option == 1)
            {
                Cursor = Cursors.WaitCursor;
                var form = new ItemBrowserForm(true, _itemCollection);
                Cursor = Cursors.Default;
                form.ShowDialog();
            }
            else if (prompt.Option == 2)
            {
                var form = new InventoryAddTempItemForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var item = form.GetItem();
                    if (item != null)
                        Session.Player.Inventory.AddGeneralEquipment(item);
                }
            }

            if (_itemCollection.Count > startCount)
            {
                generalTable.Controls.Clear();
                weaponTable.Controls.Clear();
                armourTable.Controls.Clear();
                magicTable.Controls.Clear();
                potionTable.Controls.Clear();
                toolTable.Controls.Clear();
                containerTable.Controls.Clear();

                PopulateItemTables();
            }
        }

        //
        //  showEquippedBtn_Click
        //
        private void showEquippedBtn_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (var item in Session.Player.GetEquippedItems())
                message += item.Name + "\n";

            MessageBox.Show(message, "Equipped Items");
        }

        //
        //  showAttunedBtn_Click
        //
        private void showAttunedBtn_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (var item in Session.Player.GetAttunedItems())
                message += item.Name + "\n";

            MessageBox.Show(message, "Attuned Items");
        }

        //
        //  invTabCtrl_SelectedIndexChanged
        //
        private void invTabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (invTabCtrl.SelectedIndex)
            {
                case 0: categoryDescTextBox.Text = _generalDesc; break;
                case 1: categoryDescTextBox.Text = _weaponDesc; break;
                case 2: categoryDescTextBox.Text = _armourDesc; break;
                case 3: categoryDescTextBox.Text = _magicDesc; break;
                case 4: categoryDescTextBox.Text = _potionDesc; break;
                case 5: categoryDescTextBox.Text = _toolDesc; break;
                case 6: categoryDescTextBox.Text = _packDesc; break;
                default:
                    break;
            }
        }

        //
        //  cpCtrl_ValueChanged
        //
        private void cpCtrl_ValueChanged(object sender, EventArgs e)
        {
            _itemCollection.CP = (int)cpCtrl.Value;
        }

        //
        //  spCtrl_ValueChanged
        //
        private void spCtrl_ValueChanged(object sender, EventArgs e)
        {
            _itemCollection.SP = (int)spCtrl.Value;
        }

        //
        //  gpCtrl_ValueChanged
        //
        private void gpCtrl_ValueChanged(object sender, EventArgs e)
        {
            _itemCollection.GP = (int)gpCtrl.Value;
        }

        //
        //  ppCtrl_ValueChanged
        //
        private void ppCtrl_ValueChanged(object sender, EventArgs e)
        {
            _itemCollection.PP = (int)ppCtrl.Value;
        }


        //
        //  InventoryItemCtrl_OnItemEquipped
        //
        private void InventoryItemCtrl_OnItemEquipped(object? sender, EventArgs e)
        {
            if (sender == null || sender is not InventoryItemCtrl)
                return;

            var ctrl = sender as InventoryItemCtrl;
            if (ctrl == null)
                return;

            var item = ctrl.GetItem();
            if (item == null)
                return;

            if (ctrl.IsEquipped())
                Session.Player.EquipItem(item);
            else
                Session.Player.UnequipItem(item);
        }

        //
        //  InventoryItemCtrl_OnItemAttuned
        //
        private void InventoryItemCtrl_OnItemAttuned(object? sender, EventArgs e)
        {
            if (sender == null || sender is not InventoryItemCtrl)
                return;

            var ctrl = sender as InventoryItemCtrl;
            if (ctrl == null)
                return;

            var item = ctrl.GetItem();
            if (item == null)
                return;

            if (ctrl.IsAttuned())
                Session.Player.AttuneItem(item);
            else
                Session.Player.UnattuneItem(item);
        }

        //
        //  InventoryItemCtrl_OnItemRemoved
        //
        private void InventoryItemCtrl_OnItemRemoved(object? sender, EventArgs e)
        {
            if (sender == null || sender is not InventoryItemCtrl)
                return;

            var ctrl = sender as InventoryItemCtrl;
            if (ctrl == null)
                return;

            var item = ctrl.GetItem();
            if (item == null)
                return;

            Equipment? equipment = null;
            Weapon? weapon = null;
            Armour? armour = null;
            Tool? tool = null;
            MagicItem? magicItem = null;

            if (item is Equipment)
            {
                if (item is Weapon)
                    weapon = item as Weapon;
                else if (item is Armour)
                    armour = item as Armour;
                else if (item is Tool)
                    tool = item as Tool;
                else
                    equipment = item as Equipment;
            }
            else if (item is MagicItem)
            {
                magicItem = item as MagicItem;
            }

            if (equipment != null)
                _itemCollection.SetQuantity(equipment, 0);
            else if (weapon != null)
                _itemCollection.SetQuantity(weapon, 0);
            else if (armour != null)
                _itemCollection.SetQuantity(armour, 0);
            else if (tool != null)
                _itemCollection.SetQuantity(tool, 0);
            else if (magicItem != null)
                _itemCollection.SetQuantity(magicItem, 0);

            if (generalTable.Controls.Contains(ctrl))
            {
                generalTable.Controls.Remove(ctrl);
                generalTable.Update();
            }
            else if (weaponTable.Controls.Contains(ctrl))
            {
                weaponTable.Controls.Remove(ctrl);
                weaponTable.Update();
            }
            else if (armourTable.Controls.Contains(ctrl))
            {
                armourTable.Controls.Remove(ctrl);
                armourTable.Update();
            }
            else if (magicTable.Controls.Contains(ctrl))
            {
                magicTable.Controls.Remove(ctrl);
                magicTable.Update();
            }
            else if (potionTable.Controls.Contains(ctrl))
            {
                potionTable.Controls.Remove(ctrl);
                potionTable.Update();
            }
            else if (toolTable.Controls.Contains(ctrl))
            {
                toolTable.Controls.Remove(ctrl);
                toolTable.Update();
            }
        }

        //
        //  InventoryContainerCtrl_OnItemRemoved
        //
        private void InventoryContainerCtrl_OnContainerRemoved(object? sender, EventArgs e)
        {
            if (sender == null || sender is not InventoryContainerCtrl)
                return;

            var ctrl = sender as InventoryContainerCtrl;
            if (ctrl == null)
                return;

            containerTable.Controls.Remove(ctrl);
            containerTable.Update();
        }
    }
}
