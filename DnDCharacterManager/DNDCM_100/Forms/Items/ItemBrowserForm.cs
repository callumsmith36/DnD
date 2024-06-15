/*********************************************************
 *  
 *  Name:       Items/ItemBrowserForm.cs
 *  
 *  Purpose:    Dialog for browsing/adding/deleting items
 *              from the database
 *  
 *  Author:     CS
 *  
 *  Created:    08/04/2024
 * 
 *********************************************************/

using DND.API;
using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class ItemBrowserForm : Form
    {
        private List<TableLayoutPanel> _itemTableList;
        private List<ItemBrowserCtrl> _selectedItems;
        private List<ItemBrowserCtrl> _searchResults;
        private string _currentSearch;
        private int _currentResultIndex;

        private enum SearchFilter
        {
            All, Weapons, Armour,
            Potions, Tools, Gear,
            WondrousItems, Other
        }


        //
        //  Constructor
        //
        public ItemBrowserForm(bool selector, InventoryObjectCollection? target = null)
        {
            InitializeComponent();
            _itemTableList = new List<TableLayoutPanel>();
            _selectedItems = new List<ItemBrowserCtrl>();
            _searchResults = new List<ItemBrowserCtrl>();
            _currentSearch = string.Empty;
            _currentResultIndex = 0;

            _itemTableList.Add(weaponTable);
            _itemTableList.Add(armourTable);
            _itemTableList.Add(potionTable);
            _itemTableList.Add(artisanToolTable);
            _itemTableList.Add(gamingToolTable);
            _itemTableList.Add(instrumentToolTable);
            _itemTableList.Add(otherToolTable);
            _itemTableList.Add(standardGearTable);
            _itemTableList.Add(packGearTable);
            _itemTableList.Add(kitGearTable);
            _itemTableList.Add(ammoGearTable);
            _itemTableList.Add(symbolGearTable);
            _itemTableList.Add(arcaneFociTable);
            _itemTableList.Add(druidicFociTable);
            _itemTableList.Add(wondrousTable);
            _itemTableList.Add(ringTable);
            _itemTableList.Add(rodTable);
            _itemTableList.Add(scrollTable);
            _itemTableList.Add(staffTable);
            _itemTableList.Add(wandTable);

            if (selector)
            {
                if (target != null && target is Container)
                {
                    Container? container = target as Container;
                    if (container != null)
                        addComboBox.Items.Add(container.Name);
                }
                else
                {
                    addComboBox.Items.Add("Main Inventory");
                    foreach (var container in Session.Player.Inventory.GetContainerList())
                    {
                        addComboBox.Items.Add(container.Name);
                    }
                }

                addComboBox.SelectedIndex = 0;
            }
            else
            {
                clearBtn.Enabled = false;
                clearBtn.Visible = false;
                addBtn.Enabled = false;
                addBtn.Visible = false;
                toLabel.Enabled = false;
                toLabel.Visible = false;
                addComboBox.Enabled = false;
                addComboBox.Visible = false;

                deleteBtn.Enabled = true;
                deleteBtn.Visible = true;
            }

            PopulateItems();
        }


        //
        //  CreateItemCtrl
        //
        private ItemBrowserCtrl CreateItemCtrl(InventoryObject item)
        {
            var itemCtrl = new ItemBrowserCtrl(item);
            itemCtrl.Click += ItemBrowserCtrl_OnClick;

            return itemCtrl;
        }

        //
        //  PopulateItems
        //
        private void PopulateItems()
        {
            // Populate weapons
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Weapon))
            {
                weaponTable.Controls.Add(CreateItemCtrl(item));
            }

            // Populate armour
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Armour))
            {
                armourTable.Controls.Add(CreateItemCtrl(item));
            }

            // Populate potions
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Potion))
            {
                potionTable.Controls.Add(CreateItemCtrl(item));
            }

            // Populate tools
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Tool))
            {
                Tool? tool = APIReadWrite.GetTool(item.Name);
                if (tool != null)
                {
                    switch (tool.ToolCategory)
                    {
                        case ToolCategory.Artisan:
                            artisanToolTable.Controls.Add(CreateItemCtrl(tool));
                            break;
                        case ToolCategory.Gaming:
                            gamingToolTable.Controls.Add(CreateItemCtrl(tool));
                            break;
                        case ToolCategory.Instrument:
                            instrumentToolTable.Controls.Add(CreateItemCtrl(tool));
                            break;
                        case ToolCategory.Other:
                            otherToolTable.Controls.Add(CreateItemCtrl(tool));
                            break;
                        default:
                            break;
                    }
                }
            }

            // Populate gear
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Gear))
            {
                Gear? gear = APIReadWrite.GetGear(item.Name);
                if (gear != null)
                {
                    switch (gear.GearCategory)
                    {
                        case GearCategory.Ammunition:
                            ammoGearTable.Controls.Add(CreateItemCtrl(gear));
                            break;
                        case GearCategory.ArcaneFoci:
                            arcaneFociTable.Controls.Add(CreateItemCtrl(gear));
                            break;
                        case GearCategory.DruidicFoci:
                            druidicFociTable.Controls.Add(CreateItemCtrl(gear));
                            break;
                        case GearCategory.EquipmentPack:
                            packGearTable.Controls.Add(CreateItemCtrl(gear));
                            break;
                        case GearCategory.HolySymbol:
                            symbolGearTable.Controls.Add(CreateItemCtrl(gear));
                            break;
                        case GearCategory.Kit:
                            kitGearTable.Controls.Add(CreateItemCtrl(gear));
                            break;
                        case GearCategory.Standard:
                            standardGearTable.Controls.Add(CreateItemCtrl(gear));
                            break;
                        default:
                            break;
                    }
                }
            }

            // Populate wondrous items
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Wondrous))
            {
                wondrousTable.Controls.Add(CreateItemCtrl(item));
            }

            // Populate rings
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Ring))
            {
                ringTable.Controls.Add(CreateItemCtrl(item));
            }

            // Populate rods
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Rod))
            {
                rodTable.Controls.Add(CreateItemCtrl(item));
            }

            // Populate scrolls
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Scroll))
            {
                scrollTable.Controls.Add(CreateItemCtrl(item));
            }

            // Populate staffs
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Staff))
            {
                staffTable.Controls.Add(CreateItemCtrl(item));
            }

            // Populate wands
            foreach (var item in APIReadWrite.GetItemsFromCategory(EquipmentCategory.Wand))
            {
                wandTable.Controls.Add(CreateItemCtrl(item));
            }
        }

        //
        //  Search
        //
        private void Search(string text)
        {
            if (_searchResults.Count > 0)
                _searchResults[_currentResultIndex].SetFocused(false);

            _searchResults.Clear();
            _currentSearch = searchTextBox.Text;
            _currentResultIndex = 0;

            if (text.Length > 0)
            {
                var filter = (SearchFilter)searchFilterComboBox.SelectedIndex;

                string search = text.ToLower();
                foreach (var table in _itemTableList)
                {
                    if (filter == SearchFilter.Weapons && table != weaponTable)
                        continue;

                    if (filter == SearchFilter.Armour && table != armourTable)
                        continue;

                    if (filter == SearchFilter.Potions && table != potionTable)
                        continue;

                    if (filter == SearchFilter.Tools)
                    {
                        if (table != artisanToolTable &&
                            table != gamingToolTable &&
                            table != instrumentToolTable &&
                            table != otherToolTable)
                        {
                            continue;
                        }
                    }

                    if (filter == SearchFilter.Gear)
                    {
                        if (table != standardGearTable &&
                            table != packGearTable &&
                            table != kitGearTable &&
                            table != ammoGearTable &&
                            table != symbolGearTable &&
                            table != arcaneFociTable &&
                            table != druidicFociTable)
                        {
                            continue;
                        }
                    }

                    if (filter == SearchFilter.WondrousItems && table != wondrousTable)
                        continue;

                    if (filter == SearchFilter.Other)
                    {
                        if (table != ringTable &&
                            table != rodTable &&
                            table != scrollTable &&
                            table != staffTable &&
                            table != wandTable)
                        {
                            continue;
                        }
                    }

                    foreach (var ctrl in table.Controls)
                    {
                        ItemBrowserCtrl? itemCtrl = (ItemBrowserCtrl?)ctrl;
                        if (itemCtrl != null && itemCtrl.GetItem().Name.ToLower().Contains(search))
                        {
                            _searchResults.Add(itemCtrl);
                        }
                    }
                }

                if (_searchResults.Count > 0)
                {
                    ShowItem(_searchResults[0]);
                }
                else
                {
                    MessageBox.Show(string.Format("'{0}' not found.", searchTextBox.Text));
                }
            }
        }

        //
        //  ShowItem
        //
        private void ShowItem(ItemBrowserCtrl ctrl)
        {
            var item = ctrl.GetItem();
            if (item.EquipmentCategory == EquipmentCategory.Tool)
            {
                Tool? tool = item as Tool;
                if (tool != null)
                    SelectTab(tool.ToolCategory);
            }
            else if (item.EquipmentCategory == EquipmentCategory.Gear)
            {
                Gear? gear = item as Gear;
                if (gear != null)
                    SelectTab(gear.GearCategory);
            }
            else
            {
                SelectTab(item.EquipmentCategory);
            }

            ctrl.SetFocused(true);
        }

        //
        //  SelectTab
        //
        private void SelectTab(EquipmentCategory category)
        {
            switch (category)
            {
                case EquipmentCategory.Weapon:
                    mainTabCtrl.SelectTab(weaponTab);
                    break;
                case EquipmentCategory.Armour:
                    mainTabCtrl.SelectTab(armourTab);
                    break;
                case EquipmentCategory.Potion:
                    mainTabCtrl.SelectTab(potionTab);
                    break;
                case EquipmentCategory.Tool:
                    mainTabCtrl.SelectTab(toolTab);
                    break;
                case EquipmentCategory.Gear:
                    mainTabCtrl.SelectTab(gearTab);
                    break;
                case EquipmentCategory.Wondrous:
                    mainTabCtrl.SelectTab(wondrousTab);
                    break;
                case EquipmentCategory.Ring:
                    mainTabCtrl.SelectTab(otherTab);
                    otherTabCtrl.SelectTab(ringTab);
                    break;
                case EquipmentCategory.Rod:
                    mainTabCtrl.SelectTab(otherTab);
                    otherTabCtrl.SelectTab(rodTab);
                    break;
                case EquipmentCategory.Scroll:
                    mainTabCtrl.SelectTab(otherTab);
                    otherTabCtrl.SelectTab(scrollTab);
                    break;
                case EquipmentCategory.Staff:
                    mainTabCtrl.SelectTab(otherTab);
                    otherTabCtrl.SelectTab(staffTab);
                    break;
                case EquipmentCategory.Wand:
                    mainTabCtrl.SelectTab(otherTab);
                    otherTabCtrl.SelectTab(wandTab);
                    break;
                default:
                    break;
            }
        }

        //
        //  SelectTab
        //
        private void SelectTab(ToolCategory category)
        {
            mainTabCtrl.SelectTab(toolTab);
            switch (category)
            {
                case ToolCategory.Artisan:
                    toolTabCtrl.SelectTab(artisanToolTab);
                    break;
                case ToolCategory.Gaming:
                    toolTabCtrl.SelectTab(gamingToolTab);
                    break;
                case ToolCategory.Instrument:
                    toolTabCtrl.SelectTab(instrumentToolTab);
                    break;
                case ToolCategory.Other:
                    toolTabCtrl.SelectTab(otherToolTab);
                    break;
                default:
                    break;
            }
        }

        //
        //  SelectTab
        //
        private void SelectTab(GearCategory category)
        {
            mainTabCtrl.SelectTab(gearTab);
            switch (category)
            {
                case GearCategory.Standard:
                    gearTabCtrl.SelectTab(standardGearTab);
                    break;
                case GearCategory.EquipmentPack:
                    gearTabCtrl.SelectTab(packGearTab);
                    break;
                case GearCategory.Kit:
                    gearTabCtrl.SelectTab(kitGearTab);
                    break;
                case GearCategory.Ammunition:
                    gearTabCtrl.SelectTab(ammoGearTab);
                    break;
                case GearCategory.HolySymbol:
                    gearTabCtrl.SelectTab(symbolGearTab);
                    break;
                case GearCategory.ArcaneFoci:
                    gearTabCtrl.SelectTab(fociGearTab);
                    fociTabCtrl.SelectTab(arcaneFociTab);
                    break;
                case GearCategory.DruidicFoci:
                    gearTabCtrl.SelectTab(fociGearTab);
                    fociTabCtrl.SelectTab(druidicFociTab);
                    break;
                default:
                    break;
            }
        }

        //
        //  ClearSelections
        //
        private void ClearSelections()
        {
            foreach (var ctrl in _selectedItems)
            {
                ctrl.SetSelected(false);
            }

            _selectedItems.Clear();
        }


        //
        //  ItemBrowserCtrl_OnClick
        //
        private void ItemBrowserCtrl_OnClick(object? sender, EventArgs e)
        {
            try
            {
                ItemBrowserCtrl? ctrl = (ItemBrowserCtrl?)sender;
                if (ctrl != null && ctrl.IsSelectable())
                {
                    if (ctrl.IsSelected())
                    {
                        ctrl.SetSelected(false);
                        _selectedItems.Remove(ctrl);
                    }
                    else
                    {
                        ctrl.SetSelected(true);
                        _selectedItems.Add(ctrl);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        //
        //  searchTextBox_KeyPress
        //
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search(searchTextBox.Text);
                e.Handled = true;
            }
        }

        //
        //  prevBtn_Click
        //
        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.ToLower() != _currentSearch.ToLower())
            {
                Search(searchTextBox.Text);
            }
            else
            {
                if (_searchResults.Count == 0 || _currentResultIndex < 0)
                    return;

                if (_currentResultIndex > 0)
                {
                    _searchResults[_currentResultIndex].SetFocused(false);
                    _currentResultIndex--;
                }

                ShowItem(_searchResults[_currentResultIndex]);
            }
        }

        //
        //  nextBtn_Click
        //
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.ToLower() != _currentSearch.ToLower())
            {
                Search(searchTextBox.Text);
            }
            else
            {
                if (_searchResults.Count == 0 || _currentResultIndex >= _searchResults.Count)
                    return;

                if (_currentResultIndex < _searchResults.Count - 1)
                {
                    _searchResults[_currentResultIndex].SetFocused(false);
                    _currentResultIndex++;
                }

                ShowItem(_searchResults[_currentResultIndex]);
            }
        }

        //
        //  clearBtn_Click
        //
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearSelections();
        }

        //
        //  addBtn_Click
        //
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (_selectedItems.Count == 0)
                return;

            InventoryObjectCollection? target = null;
            string message = string.Empty;
            int startCount = 0;

            if (addComboBox.Text == "Main Inventory")
            {
                target = Session.Player.Inventory;
                message = "The following items were successfully added to your inventory:\n\n";
            }
            else if (Session.Player.Inventory.TryGetContainer(addComboBox.Text, out var container))
            {
                if (container != null)
                {
                    target = container;
                    message = string.Format("The following items were successfully added to {0}:\n\n", container.Name);
                }
            }

            if (target != null)
            {
                startCount = target.Count;

                if (target is Container)
                {
                    foreach (var ctrl in _selectedItems)
                    {
                        if (ctrl.GetItem().IsContainer)
                        {
                            MessageBox.Show("Containers cannot be added to other containers.");
                            break;
                        }
                    }
                }

                foreach (var ctrl in _selectedItems)
                {
                    InventoryObject item = ctrl.GetItem();

                    if (item.IsContainer)
                    {
                        if (target is Container)
                            continue;

                        var form = new ContainerCreateForm(item);
                        if (form.ShowDialog() == DialogResult.Cancel)
                            continue;

                        Container? container = null;

                        if (item.EquipmentCategory == EquipmentCategory.Gear)
                        {
                            Gear? gear = item is Gear ? item as Gear : APIReadWrite.GetGear(item.Name);
                            if (gear != null && gear.GearCategory == GearCategory.EquipmentPack)
                            {
                                container = APIReadWrite.GetEquipmentPack(gear.Name);
                                if (container != null)
                                    container.Name = form.GetName();
                            }
                        }

                        if (container == null)
                            container = new Container(form.GetName(), item.Description, item);

                        if (container != null)
                        {
                            Session.Player.Inventory.AddContainer(container);
                            message += item.Name + "\n";
                        }
                    }
                    else
                    {
                        if (item.IsMagical)
                        {
                            MagicItem? magicItem = item is MagicItem ? item as MagicItem : APIReadWrite.GetMagicItem(item.Name);
                            if (magicItem != null)
                            {
                                if (magicItem.EquipmentCategory == EquipmentCategory.Potion)
                                    target.AddPotion(magicItem);
                                else
                                    target.AddMagicItem(magicItem);

                                message += magicItem.Name + "\n";
                            }
                        }
                        else
                        {
                            if (item.EquipmentCategory == EquipmentCategory.Weapon)
                            {
                                Weapon? weapon = item is Weapon ? item as Weapon : APIReadWrite.GetWeapon(item.Name);
                                if (weapon != null)
                                {
                                    target.AddWeapon(weapon);
                                    message += weapon.Name + "\n";
                                }
                            }
                            else if (item.EquipmentCategory == EquipmentCategory.Armour)
                            {
                                Armour? armour = item is Armour ? item as Armour : APIReadWrite.GetArmour(item.Name);
                                if (armour != null)
                                {
                                    target.AddArmour(armour);
                                    message += armour.Name + "\n";
                                }
                            }
                            else if (item.EquipmentCategory == EquipmentCategory.Tool)
                            {
                                Tool? tool = item is Tool ? item as Tool : APIReadWrite.GetTool(item.Name);
                                if (tool != null)
                                {
                                    target.AddTool(tool);
                                    message += tool.Name + "\n";
                                }
                            }
                            else if (item.EquipmentCategory == EquipmentCategory.Gear)
                            {
                                Gear? gear = item is Gear ? item as Gear : APIReadWrite.GetGear(item.Name);
                                if (gear != null)
                                {
                                    target.AddGeneralEquipment(gear);
                                    message += gear.Name + "\n";
                                }
                            }
                            else
                            {
                                Equipment? equipment = item is Equipment ? item as Equipment : APIReadWrite.GetEquipment(item.Name);
                                if (equipment != null)
                                {
                                    target.AddGeneralEquipment(equipment);
                                    message += equipment.Name + "\n";
                                }
                            }
                        }
                    }
                }

                if (target.Count > startCount)
                {
                    MessageBox.Show(message);
                }

                ClearSelections();
            }
            else
            {
                MessageBox.Show("Could not find the specified container. No items added.");
            }
        }

        //
        //  deleteBtn_Click
        //
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_selectedItems.Count == 0)
                return;

            string confirmMsg = "Are you sure you want to delete the following items?\n\n";
            foreach (var ctrl in _selectedItems)
            {
                var item = ctrl.GetItem();
                if (item != null)
                    confirmMsg += item.Name + "\n";
            }

            if (MessageBox.Show(confirmMsg, "D&D Character Manager", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<ItemBrowserCtrl> deletedItems = new List<ItemBrowserCtrl>();
                List<ItemBrowserCtrl> heldItems = new List<ItemBrowserCtrl>();

                foreach (var ctrl in _selectedItems)
                {
                    var item = ctrl.GetItem();
                    if (item != null)
                    {
                        if (Session.Player.Inventory.Contains(item))
                        {
                            heldItems.Add(ctrl);
                            continue;
                        }

                        APIReadWrite.DeleteItem(item);
                        deletedItems.Add(ctrl);
                    }
                }

                if (heldItems.Count > 0)
                {
                    string heldItemMsg = "You must remove the following items from your inventory before they can be deleted:\n\n";
                    foreach (var ctrl in heldItems)
                        heldItemMsg += ctrl.GetItem().Name + "\n";

                    MessageBox.Show(heldItemMsg, "D&D Character Manager");
                }

                string deletedMsg = "The following items have been removed from the database:\n\n";
                foreach (var ctrl in deletedItems)
                    deletedMsg += ctrl.GetItem().Name + "\n";

                MessageBox.Show(deletedMsg, "D&D Character Manager");

                ClearSelections();

                foreach (var ctrl in deletedItems)
                {
                    foreach (var table in _itemTableList)
                    {
                        if (table.Controls.Contains(ctrl))
                        {
                            table.Controls.Remove(ctrl);
                            break;
                        }
                    }
                }
            }
        }
    }
}
