/*********************************************************
 *  
 *  Name:       UserControls/Inventory/InventoryContainerCtrl.cs
 *  
 *  Purpose:    Represents an container in the ItemBrowser
 *  
 *  Author:     CS
 *  
 *  Created:    02/04/2024
 * 
 *********************************************************/

using DND.InventorySystem;

namespace CharacterManager
{
    public partial class InventoryContainerCtrl : UserControl
    {
        // Member variables
        private Container _container;

        // Events
        public EventHandler? OnContainerRemoved;


        //
        //  Constructor
        //
        public InventoryContainerCtrl()
        {
            InitializeComponent();
            _container = new Container("Empty Container", Array.Empty<string>());
        }

        //
        //  Constructor
        //
        public InventoryContainerCtrl(Container container)
        {
            InitializeComponent();
            _container = container;

            nameLabel.Text = container.Name;
        }


        //
        //  GetContainer
        //
        public Container GetContainer()
        {
            return _container;
        }

        //
        //  openBtn_Click
        //
        private void openBtn_Click(object sender, EventArgs e)
        {
            var form = new InventoryForm(_container);
            form.ShowDialog();
        }

        //
        //  removeBtn_Click
        //
        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (_container == null)
                return;

            DialogResult result = MessageBox.Show(
                string.Format("Are you sure you want to remove {0} and all its contents?", _container.Name),
                "Inventory",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No)
                return;

            Session.Player.Inventory.RemoveContainer(_container.Name);
            OnContainerRemoved?.Invoke(this, EventArgs.Empty);
        }

        //
        //  infoBtn_Click
        //
        private void infoBtn_Click(object sender, EventArgs e)
        {
            var item = _container.BaseItem;
            if (item == null)
                return;

            Equipment? equipment = null;
            Weapon? weapon = null;
            Armour? armour = null;
            Tool? tool = null;
            Gear? gear = null;
            MagicItem? magicItem = null;

            if (item is Equipment)
            {
                if (item is Weapon)
                    weapon = item as Weapon;
                else if (item is Armour)
                    armour = item as Armour;
                else if (item is Tool)
                    tool = item as Tool;
                else if (item is Gear)
                    gear = item as Gear;
                else
                    equipment = item as Equipment;
            }
            else if (item is MagicItem)
            {
                magicItem = item as MagicItem;
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
    }
}
