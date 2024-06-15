/*********************************************************
 *  
 *  Name:       UserControls/ItemBrowserCtrl.cs
 *  
 *  Purpose:    Represents an item in the ItemBrowser
 *  
 *  Author:     CS
 *  
 *  Created:    06/04/2024
 * 
 *********************************************************/

using DND.API;
using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public class ItemBrowserCtrl : BrowserCtrl
    {
        private InventoryObject _item;


        //
        //  Constructor
        //
        public ItemBrowserCtrl(InventoryObject item, EventHandler? onClick = null, bool selected = true)
            : base(onClick, selected)
        {
            _item = item;
            SetName(item.Name);
            if (item.IsContainer)
            {
                SetTag("Container");
                SetTagVisible();
            }
        }


        //
        //  GetItem
        //
        public InventoryObject GetItem()
        {
            return _item;
        }

        //
        //  infoBtn_Click
        //
        protected override void infoBtn_Click(object sender, EventArgs e)
        {
            if (_item != null)
            {
                if (_item.IsMagical)
                {
                    MagicItem? item = _item is MagicItem ? _item as MagicItem : APIReadWrite.GetMagicItem(_item.Name);
                    if (item != null)
                    {
                        var form = new MagicItemDetailsForm(item);
                        form.ShowDialog();
                    }
                }
                else
                {
                    if (_item.EquipmentCategory == EquipmentCategory.Weapon)
                    {
                        Weapon? weapon = _item is Weapon ? _item as Weapon : APIReadWrite.GetWeapon(_item.Name);
                        if (weapon != null)
                        {
                            var form = new WeaponDetailsForm(weapon);
                            form.ShowDialog();
                        }
                    }
                    else if (_item.EquipmentCategory == EquipmentCategory.Armour)
                    {
                        Armour? armour = _item is Armour ? _item as Armour : APIReadWrite.GetArmour(_item.Name);
                        if (armour != null)
                        {
                            var form = new ArmourDetailsForm(armour);
                            form.ShowDialog();
                        }
                    }
                    else if (_item.EquipmentCategory == EquipmentCategory.Tool)
                    {
                        Tool? tool = _item is Tool ? _item as Tool : APIReadWrite.GetTool(_item.Name);
                        if (tool != null)
                        {
                            var form = new EquipmentDetailsForm(tool);
                            form.ShowDialog();
                        }
                    }
                    else if (_item.EquipmentCategory == EquipmentCategory.Gear)
                    {
                        Gear? gear = _item is Gear ? _item as Gear : APIReadWrite.GetGear(_item.Name);
                        if (gear != null)
                        {
                            var form = new EquipmentDetailsForm(gear);
                            form.ShowDialog();
                        }
                    }
                    else
                    {
                        Equipment? item = _item is Equipment ? _item as Equipment : APIReadWrite.GetEquipment(_item.Name);
                        if (item != null)
                        {
                            var form = new EquipmentDetailsForm(item);
                            form.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
