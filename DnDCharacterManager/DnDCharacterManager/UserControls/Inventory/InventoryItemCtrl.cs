using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class InventoryItemCtrl : UserControl
    {
        // Member variables
        private InventoryObject _item;
        private int _quantity;

        // Events
        public EventHandler? OnItemEquipped;
        public EventHandler? OnItemAttuned;
        public EventHandler? OnItemRemoved;


        //
        //  Constructor
        //
        public InventoryItemCtrl()
        {
            InitializeComponent();
            _item = new Equipment("null", EquipmentCategory.None, 0, 0, "", Array.Empty<string>());
        }

        //
        //  Constructor
        //
        public InventoryItemCtrl(InventoryObject obj, int qty, bool inContainer = false)
        {
            InitializeComponent();

            _item = obj;

            nameLabel.Text = obj.Name;
            if (TextRenderer.MeasureText(nameLabel.Text, nameLabel.Font).Width > nameLabel.MaximumSize.Width)
            {
                while (TextRenderer.MeasureText(nameLabel.Text, nameLabel.Font).Width > nameLabel.MaximumSize.Width)
                {
                    nameLabel.Font = new Font(nameLabel.Font.Name, nameLabel.Font.Size - 1.0f, FontStyle.Regular);
                }

                nameLabel.Location = new Point(nameLabel.Location.X, (Size.Height / 2) - (nameLabel.Height / 2));
            }

            _quantity = qty;
            qtyNumCtrl.Value = qty;

            if (!inContainer)
            {
                if (_item is Weapon || _item is Armour)
                {
                    equipCheckBox.Enabled = true;
                    equipCheckBox.Visible = true;
                    equipCheckBox.Checked = Session.Player.IsEquipped(_item);
                    nameLabel.Location = new Point(nameLabel.Location.X, 3);
                }
                else if (_item is MagicItem)
                {
                    var magicItem = _item as MagicItem;
                    if (magicItem != null && magicItem.EquipmentCategory != EquipmentCategory.Potion)
                    {
                        equipCheckBox.Enabled = true;
                        equipCheckBox.Visible = true;
                        equipCheckBox.Checked = Session.Player.IsEquipped(_item);
                        nameLabel.Location = new Point(nameLabel.Location.X, 3);

                        if (magicItem.Attunement)
                        {
                            attuneCheckBox.Enabled = true;
                            attuneCheckBox.Visible = true;
                            attuneCheckBox.Checked = Session.Player.IsAttuned(_item);
                        }
                    }
                }
            }

            qtyNumCtrl.MouseWheel += qtyNumCtrl_MouseWheel;
        }


        //
        //  GetItem
        //
        public InventoryObject GetItem()
        {
            return _item;
        }

        //
        //  IsEquipped
        //
        public bool IsEquipped()
        {
            if (equipCheckBox.Enabled)
                return equipCheckBox.Checked;

            return false;
        }

        //
        //  IsAttuned
        //
        public bool IsAttuned()
        {
            if (attuneCheckBox.Enabled)
                return attuneCheckBox.Checked;

            return false;
        }


        //
        //  infoBtn_Click
        //
        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (_item == null)
                return;

            Equipment? equipment = null;
            Weapon? weapon = null;
            Armour? armour = null;
            Tool? tool = null;
            Gear? gear = null;
            MagicItem? magicItem = null;

            if (_item is Equipment)
            {
                if (_item is Weapon)
                    weapon = _item as Weapon;
                else if (_item is Armour)
                    armour = _item as Armour;
                else if (_item is Tool)
                    tool = _item as Tool;
                else if (_item is Gear)
                    gear = _item as Gear;
                else
                    equipment = _item as Equipment;
            }
            else if (_item is MagicItem)
            {
                magicItem = _item as MagicItem;
            }

            Form? form = null;
            if (weapon != null)
                form = new WeaponDetailsForm(weapon);
            else if (armour != null)
                form = new ArmourDetailsForm(armour);
            else if (tool != null)
                form = new EquipmentDetailsForm(tool);
            else if (gear != null)
                form = new EquipmentDetailsForm(gear);
            else if (equipment != null)
                form = new EquipmentDetailsForm(equipment);
            else if (magicItem != null)
                form = new MagicItemDetailsForm(magicItem);

            if (form != null)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
        }

        //
        //  qtyNumCtrl_ValueChanged
        //
        private void qtyNumCtrl_ValueChanged(object sender, EventArgs e)
        {
            if (_item == null)
                return;

            DialogResult result = DialogResult.Yes;
            if ((int)qtyNumCtrl.Value == 0)
            {
                result = MessageBox.Show(
                    string.Format("Are you sure you want to remove {0}?", _item.Name),
                    "Inventory",
                    MessageBoxButtons.YesNo
                );
            }

            if (result == DialogResult.No)
            {
                qtyNumCtrl.Value = _quantity;
                return;
            }

            _quantity = (int)qtyNumCtrl.Value;

            if (_quantity == 0)
            {
                OnItemRemoved?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (_item is Equipment)
                {
                    if (_item is Weapon)
                        Session.Player.Inventory.SetQuantity(_item as Weapon, _quantity);
                    else if (_item is Armour)
                        Session.Player.Inventory.SetQuantity(_item as Armour, _quantity);
                    else if (_item is Tool)
                        Session.Player.Inventory.SetQuantity(_item as Tool, _quantity);
                    else if (_item is Gear)
                        Session.Player.Inventory.SetQuantity(_item as Gear, _quantity);
                    else
                        Session.Player.Inventory.SetQuantity(_item as Equipment, _quantity);
                }
                else if (_item is MagicItem)
                {
                    Session.Player.Inventory.SetQuantity(_item as MagicItem, _quantity);
                }
            }
        }

        //
        //  qtyNumCtrl_MouseWheel
        //
        private void qtyNumCtrl_MouseWheel(object? sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        //
        //  equipCheckBox_CheckedChanged
        //
        private void equipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OnItemEquipped?.Invoke(this, EventArgs.Empty);
        }

        //
        //  attuneCheckBox_CheckedChanged
        //
        private void attuneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OnItemAttuned?.Invoke(this, EventArgs.Empty);
        }
    }
}
