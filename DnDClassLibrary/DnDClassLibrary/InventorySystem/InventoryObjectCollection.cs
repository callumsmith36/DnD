/*********************************************************
 *  
 *  Name:       InventorySystem/InventoryObjectCollection.cs
 *  
 *  Purpose:    Class for storing and manipulating a
 *              collection of D&D items (InventoryObjects)
 *  
 *  Author:     CS
 *  
 *  Created:    30/01/2024
 * 
 *********************************************************/

using DND.API;
using DND.Types;

namespace DND.InventorySystem
{
    public abstract class InventoryObjectCollection
    {
        // Member variables
        protected Dictionary<Equipment, int>    _general;
        protected Dictionary<Weapon, int>       _weapons;
        protected Dictionary<Armour, int>       _armour;
        protected Dictionary<Tool, int>         _tools;
        protected Dictionary<MagicItem, int>    _potions;
        protected Dictionary<MagicItem, int>    _magicItems;

        // Properties
        public int CP { get; set; }
        public int SP { get; set; }
        public int GP { get; set; }
        public int PP { get; set; }

        public virtual int Count
        {
            get
            {
                int count = 0;
                foreach (var value in _general.Values)
                    count += value;
                foreach (var value in _weapons.Values)
                    count += value;
                foreach (var value in _armour.Values)
                    count += value;
                foreach (var value in _tools.Values)
                    count += value;
                foreach (var value in _potions.Values)
                    count += value;
                foreach (var value in _magicItems.Values)
                    count += value;

                return count;
            }
        }

        // Events
        public Action? OnItemRemoved;


        //
        //  Constructor
        //
        public InventoryObjectCollection()
        {
            _general = new Dictionary<Equipment, int>();
            _weapons = new Dictionary<Weapon, int>();
            _armour = new Dictionary<Armour, int>();
            _tools = new Dictionary<Tool, int>();
            _potions = new Dictionary<MagicItem, int>();
            _magicItems = new Dictionary<MagicItem, int>();

            PP = GP = SP = CP = 0;
        }

        //
        //  Constructor
        //  (load from file)
        //
        public InventoryObjectCollection(APIItemCollection items)
        {
            CP = items.money[0];
            SP = items.money[1];
            GP = items.money[2];
            PP = items.money[3];

            string[] indexList = APIReadWrite.GetEquipmentIndexList();

            _general = new Dictionary<Equipment, int>();
            foreach (var apiItem in items.general)
            {
                Equipment? equipment = null;
                if (indexList.Contains(apiItem.item.index))
                    equipment = APIReadWrite.GetEquipment(apiItem.item.name);

                if (equipment == null)
                    equipment = new Equipment(apiItem.item.name, EquipmentCategory.None, 0, 0, "cp", apiItem.desc, false);

                _general.Add(equipment, apiItem.quantity);
            }

            _weapons = new Dictionary<Weapon, int>();
            foreach (var apiItem in items.weapons)
            {
                Weapon? weapon = null;
                if (indexList.Contains(apiItem.item.index))
                    weapon = APIReadWrite.GetWeapon(apiItem.item.name);

                if (weapon != null)
                    _weapons.Add(weapon, apiItem.quantity);
            }

            _armour = new Dictionary<Armour, int>();
            foreach (var apiItem in items.armour)
            {
                Armour? armour = null;
                if (indexList.Contains(apiItem.item.index))
                    armour = APIReadWrite.GetArmour(apiItem.item.name);

                if (armour != null)
                    _armour.Add(armour, apiItem.quantity);
            }

            _tools = new Dictionary<Tool, int>();
            foreach (var apiItem in items.tools)
            {
                Tool? tool = null;
                if (indexList.Contains(apiItem.item.index))
                    tool = APIReadWrite.GetTool(apiItem.item.name);

                if (tool != null)
                    _tools.Add(tool, apiItem.quantity);
            }

            indexList = APIReadWrite.GetMagicItemIndexList();

            _potions = new Dictionary<MagicItem, int>();
            foreach (var apiItem in items.potions)
            {
                MagicItem? potion = null;
                if (indexList.Contains(apiItem.item.index))
                    potion = APIReadWrite.GetMagicItem(apiItem.item.name);

                if (potion != null)
                    _potions.Add(potion, apiItem.quantity);
            }

            _magicItems = new Dictionary<MagicItem, int>();
            foreach (var apiItem in items.magic_items)
            {
                MagicItem? item = null;
                if (indexList.Contains(apiItem.item.index))
                    item = APIReadWrite.GetMagicItem(apiItem.item.name);

                if (item != null)
                    _magicItems.Add(item, apiItem.quantity);
            }
        }

        //
        //  Copy Constructor
        //
        public InventoryObjectCollection(InventoryObjectCollection inv)
        {
            CP = inv.CP;
            SP = inv.SP;
            GP = inv.GP;
            PP = inv.PP;

            _general = new Dictionary<Equipment, int>();
            foreach (var key in inv._general.Keys)
                _general.Add(new Equipment(key), inv._general[key]);

            _weapons = new Dictionary<Weapon, int>();
            foreach (var key in inv._weapons.Keys)
                _weapons.Add(new Weapon(key), inv._weapons[key]);

            _armour = new Dictionary<Armour, int>();
            foreach (var key in inv._armour.Keys)
                _armour.Add(new Armour(key), inv._armour[key]);

            _tools = new Dictionary<Tool, int>();
            foreach (var key in inv._tools.Keys)
                _tools.Add(new Tool(key), inv._tools[key]);

            _potions = new Dictionary<MagicItem, int>();
            foreach (var key in inv._potions.Keys)
                _potions.Add(new MagicItem(key), inv._potions[key]);

            _magicItems = new Dictionary<MagicItem, int>();
            foreach (var key in inv._magicItems.Keys)
                _magicItems.Add(new MagicItem(key), inv._magicItems[key]);
        }


        //
        //  Contains
        //
        public virtual bool Contains(InventoryObject item)
        {
            if (_general.Keys.Contains(item))
                return true;
            if (_weapons.Keys.Contains(item))
                return true;
            if (_armour.Keys.Contains(item))
                return true;
            if (_tools.Keys.Contains(item))
                return true;
            if (_potions.Keys.Contains(item))
                return true;
            if (_magicItems.Keys.Contains(item))
                return true;

            return false;
        }


        #region BASE METHODS

        //
        //  AddItem
        //
        private void AddItem<T>(T item, Dictionary<T, int> itemList, int quantity = 1)
            where T : InventoryObject
        {
            if (item == null)
                return;

            if (itemList.ContainsKey(item))
                itemList[item] += quantity;
            else
                itemList.Add(item, quantity);
        }

        //
        //  RemoveItem
        //
        private bool RemoveItem<T>(T item, Dictionary<T, int> itemList, bool all = false)
            where T : InventoryObject
        {
            bool result = false;

            if (all)
            {
                result = itemList.Remove(item);
            }
            else if (itemList.ContainsKey(item))
            {
                if (itemList[item] > 1)
                {
                    itemList[item]--;
                    result = true;
                }
                else
                {
                    result = itemList.Remove(item);
                }
            }

            if (result == true)
                OnItemRemoved?.Invoke();

            return result;
        }

        //
        //  RemoveItem
        //
        private bool RemoveItem<T>(string name, Dictionary<T, int> itemList, bool all = false)
            where T : InventoryObject
        {
            string index = APIReadWrite.NameToIndex(name);
            foreach (var item in itemList.Keys)
            {
                if (item.Index == index)
                    return RemoveItem(item, itemList, all);
            }

            return false;
        }

        //
        //  TryGetItem
        //
        private bool TryGetItem<T>(string name, Dictionary<T, int> itemList, out T? result)
            where T : InventoryObject
        {
            string index = APIReadWrite.NameToIndex(name);
            foreach (var item in itemList.Keys)
            {
                if (item.Index == index)
                {
                    result = item;
                    return true;
                }
            }

            result = null;
            return false;
        }

        //
        //  GetItemList
        //
        private T[] GetItemList<T>(Dictionary<T, int> itemList, bool alphabetical = false)
            where T : InventoryObject
        {
            if (!alphabetical || itemList.Count == 0)
                return itemList.Keys.ToArray();

            int i;

            var list = itemList.Keys.ToList();
            var sorted = new List<T>();

            foreach (var item in list)
            {
                for (i = 0; i < sorted.Count; i++)
                {
                    if (string.Compare(item.Name, sorted[i].Name) == -1)
                        break;
                }

                if (i < sorted.Count)
                    sorted.Insert(i, item);
                else
                    sorted.Add(item);
            }

            return sorted.ToArray();
        }

        #endregion // BASE METHODS


        #region QUANTITY

        //
        //  GetQuantity (Equipment)
        //
        public int GetQuantity(Equipment item)
        {
            return item != null && _general.ContainsKey(item) ? _general[item] : 0;
        }

        //
        //  SetQuantity (Equipment)
        //
        public void SetQuantity(Equipment item, int quantity)
        {
            if (quantity < 0)
                return;

            if (_general.ContainsKey(item))
            {
                if (quantity == 0)
                    RemoveGeneralEquipment(item, true);
                else
                    _general[item] = quantity;
            }
        }

        //
        //  GetQuantity (Weapon)
        //
        public int GetQuantity(Weapon weapon)
        {
            return weapon != null && _weapons.ContainsKey(weapon) ? _weapons[weapon] : 0;
        }

        //
        //  SetQuantity (Weapon)
        //
        public void SetQuantity(Weapon weapon, int quantity)
        {
            if (quantity < 0)
                return;

            if (_weapons.ContainsKey(weapon))
            {
                if (quantity == 0)
                    RemoveWeapon(weapon, true);
                else
                    _weapons[weapon] = quantity;
            }
        }

        //
        //  GetQuantity (Armour)
        //
        public int GetQuantity(Armour armour)
        {
            return armour != null && _armour.ContainsKey(armour) ? _armour[armour] : 0;
        }

        //
        //  SetQuantity (Armour)
        //
        public void SetQuantity(Armour armour, int quantity)
        {
            if (quantity < 0)
                return;

            if (_armour.ContainsKey(armour))
            {
                if (quantity == 0)
                    RemoveArmour(armour, true);
                else
                    _armour[armour] = quantity;
            }
        }

        //
        //  GetQuantity (Tool)
        //
        public int GetQuantity(Tool tool)
        {
            return tool != null && _tools.ContainsKey(tool) ? _tools[tool] : 0;
        }

        //
        //  SetQuantity (Tool)
        //
        public void SetQuantity(Tool tool, int quantity)
        {
            if (quantity < 0)
                return;

            if (_tools.ContainsKey(tool))
            {
                if (quantity == 0)
                    RemoveTool(tool, true);
                else
                    _tools[tool] = quantity;
            }
        }

        //
        //  GetQuantity (MagicItem)
        //
        public int GetQuantity(MagicItem item)
        {
            if (_potions.ContainsKey(item))
                return _potions[item];

            if (_magicItems.ContainsKey(item))
                return _magicItems[item];

            return 0;
        }

        //
        //  SetQuantity (MagicItem)
        //
        public void SetQuantity(MagicItem item, int quantity)
        {
            if (quantity < 0)
                return;

            if (_potions.ContainsKey(item))
            {
                if (quantity == 0)
                    RemovePotion(item, true);
                else
                    _potions[item] = quantity;
            }
            else if (_magicItems.ContainsKey(item))
            {
                if (quantity == 0)
                    RemoveMagicItem(item, true);
                else
                    _magicItems[item] = quantity;
            }
        }

        #endregion // QUANTITY


        #region GENERAL

        //
        //  AddGeneralEquipment
        //
        public void AddGeneralEquipment(Equipment item, int quantity = 1)
        {
            AddItem(item, _general, quantity);
        }

        //
        //  RemoveGeneralEquipment
        //  (object)
        //
        public bool RemoveGeneralEquipment(Equipment item, bool all = false)
        {
            return RemoveItem(item, _general, all);
        }

        //
        //  RemoveGeneralEquipment
        //  (name)
        //
        public bool RemoveGeneralEquipment(string name, bool all = false)
        {
            return RemoveItem(name, _general, all);
        }

        //
        //  TryGetGeneralEquipment
        //
        public bool TryGetGeneralEquipment(string name, out Equipment? item)
        {
            return TryGetItem(name, _general, out item);
        }

        //
        //  GetGeneralEquipmentList
        //
        public Equipment[] GetGeneralEquipmentList(bool alphabetical = false)
        {
            return GetItemList(_general, alphabetical);
        }

        #endregion // GENERAL


        #region WEAPONS

        //
        //  AddWeapon
        //
        public void AddWeapon(Weapon weapon, int quantity = 1)
        {
            AddItem(weapon, _weapons, quantity);
        }

        //
        //  RemoveWeapon
        //  (object)
        //
        public bool RemoveWeapon(Weapon weapon, bool all = false)
        {
            return RemoveItem(weapon, _weapons, all);
        }

        //
        //  RemoveWeapon
        //  (name)
        //
        public bool RemoveWeapon(string name, bool all = false)
        {
            return RemoveItem(name, _weapons, all);
        }

        //
        //  TryGetWeapon
        //
        public bool TryGetWeapon(string name, out Weapon? weapon)
        {
            return TryGetItem(name, _weapons, out weapon);
        }

        //
        //  GetWeaponList
        //
        public Weapon[] GetWeaponList(bool alphabetical = false)
        {
            return GetItemList(_weapons, alphabetical);
        }

        #endregion // WEAPONS


        #region ARMOUR

        //
        //  AddArmour
        //
        public void AddArmour(Armour armour, int quantity = 1)
        {
            AddItem(armour, _armour, quantity);
        }

        //
        //  RemoveArmour
        //  (object)
        //
        public bool RemoveArmour(Armour armour, bool all = false)
        {
            return RemoveItem(armour, _armour, all);
        }

        //
        //  RemoveArmour
        //  (name)
        //
        public bool RemoveArmour(string name, bool all = false)
        {
            return RemoveItem(name, _armour, all);
        }

        //
        //  TryGetArmour
        //
        public bool TryGetArmour(string name, out Armour? armour)
        {
            return TryGetItem(name, _armour, out armour);
        }

        //
        //  GetArmourList
        //
        public Armour[] GetArmourList(bool alphabetical = false)
        {
            return GetItemList(_armour, alphabetical);
        }

        #endregion // ARMOUR


        #region TOOLS

        //
        //  AddTool
        //
        public void AddTool(Tool tool, int quantity = 1)
        {
            AddItem(tool, _tools, quantity);
        }

        //
        //  RemoveTool
        //  (object)
        //
        public bool RemoveTool(Tool tool, bool all = false)
        {
            return RemoveItem(tool, _tools, all);
        }

        //
        //  RemoveTool
        //  (name)
        //
        public bool RemoveTool(string name, bool all = false)
        {
            return RemoveItem(name, _tools, all);
        }

        //
        //  TryGetTool
        //
        public bool TryGetTool(string name, out Tool? tool)
        {
            return TryGetItem(name, _tools, out tool);
        }

        //
        //  GetToolList
        //
        public Tool[] GetToolList(bool alphabetical = false)
        {
            return GetItemList(_tools, alphabetical);
        }

        #endregion // TOOLS


        #region POTIONS

        //
        //  AddPotion
        //
        public void AddPotion(MagicItem potion, int quantity = 1)
        {
            AddItem(potion, _potions, quantity);
        }

        //
        //  RemovePotion
        //  (object)
        //
        public bool RemovePotion(MagicItem potion, bool all = false)
        {
            return RemoveItem(potion, _potions, all);
        }

        //
        //  RemovePotion
        //  (name)
        //
        public bool RemovePotion(string name, bool all = false)
        {
            return RemoveItem(name, _potions, all);
        }

        //
        //  TryGetPotion
        //
        public bool TryGetPotion(string name, out MagicItem? potion)
        {
            return TryGetItem(name, _potions, out potion);
        }

        //
        //  GetPotionList
        //
        public MagicItem[] GetPotionList(bool alphabetical = false)
        {
            return GetItemList(_potions, alphabetical);
        }

        #endregion // POTIONS


        #region MAGIC ITEMS

        //
        //  AddMagicItem
        //
        public void AddMagicItem(MagicItem item, int quantity = 1)
        {
            AddItem(item, _magicItems, quantity);
        }

        //
        //  RemoveMagicItem
        //  (object)
        //
        public bool RemoveMagicItem(MagicItem item, bool all = false)
        {
            return RemoveItem(item, _magicItems, all);
        }

        //
        //  RemoveMagicItem
        //  (name)
        //
        public bool RemoveMagicItem(string name, bool all = false)
        {
            return RemoveItem(name, _magicItems, all);
        }

        //
        //  TryGetMagicItem
        //
        public bool TryGetMagicItem(string name, out MagicItem? item)
        {
            return TryGetItem(name, _magicItems, out item);
        }

        //
        //  GetMagicItemList
        //
        public MagicItem[] GetMagicItemList(bool alphabetical = false)
        {
            return GetItemList(_magicItems, alphabetical);
        }

        #endregion // MAGIC ITEMS


        //
        //  ToAPIObject
        //
        public abstract APIItemCollection ToAPIObject();


        //
        //  CompareContents
        //
        protected bool CompareContents(InventoryObjectCollection other)
        {
            var equal = this.CP == other.CP && this.SP == other.SP && this.GP == other.GP && this.PP == other.PP;

            bool CheckItemListsEqual<T>(T[] thisList, T[] otherList)
                where T : InventoryObject
            {
                if (thisList.Length != otherList.Length)
                    return false;

                foreach (var thisItem in thisList)
                {
                    if (!otherList.Contains(thisItem))
                        return false;

                    /*if (thisItem is Weapon)
                    {
                        if (other.TryGetWeapon(thisItem.Name, out var weapon, out var quantity))
                        {
                            if (quantity != GetQuantity(thisItem as Weapon))
                                return false;
                        }
                    }
                    else if (thisItem is Armour)
                    {
                        if (other.TryGetArmour(thisItem.Name, out var armour, out var quantity))
                        {
                            if (quantity != GetQuantity(thisItem as Armour))
                                return false;
                        }
                    }
                    else if (thisItem is MagicItem)
                    {
                        if (other.TryGetPotion(thisItem.Name, out var potion, out var pQuantity))
                        {
                            if (pQuantity != GetQuantity(thisItem as MagicItem))
                                return false;
                        }
                        else if (other.TryGetMagicItem(thisItem.Name, out var magicItem, out var mQuantity))
                        {
                            if (mQuantity != GetQuantity(thisItem as MagicItem))
                                return false;
                        }
                    }
                    else if (thisItem is Item)
                    {
                        if (other.TryGetTool(thisItem.Name, out var tool, out var tQuantity))
                        {
                            if (tQuantity != GetQuantity(thisItem as Item))
                                return false;
                        }
                        else if (other.TryGetMiscellaneous(thisItem.Name, out var misc, out var mQuantity))
                        {
                            if (mQuantity != GetQuantity(thisItem as Item))
                                return false;
                        }
                    }*/
                }

                return true;
            }

            if (equal)
            {
                // Check general

                var thisMiscList = GetGeneralEquipmentList();
                var otherMiscList = other.GetGeneralEquipmentList();

                if (equal = CheckItemListsEqual(thisMiscList, otherMiscList))
                {
                    foreach (var item in thisMiscList)
                    {
                        if (GetQuantity(item) != other.GetQuantity(item))
                        {
                            equal = false;
                            break;
                        }
                    }
                }
            }

            if (equal)
            {
                // Check weapons

                var thisWeaponList = GetWeaponList();
                var otherWeaponList = other.GetWeaponList();

                if (equal = CheckItemListsEqual(thisWeaponList, otherWeaponList))
                {
                    foreach (var weapon in thisWeaponList)
                    {
                        if (GetQuantity(weapon) != other.GetQuantity(weapon))
                        {
                            equal = false;
                            break;
                        }
                    }
                }
            }

            if (equal)
            {
                // Check armour

                var thisArmourList = GetArmourList();
                var otherArmourList = other.GetArmourList();

                if (equal = CheckItemListsEqual(thisArmourList, otherArmourList))
                {
                    foreach (var armour in thisArmourList)
                    {
                        if (GetQuantity(armour) != other.GetQuantity(armour))
                        {
                            equal = false;
                            break;
                        }
                    }
                }
            }

            if (equal)
            {
                // Check tools

                var thisToolList = GetToolList();
                var otherToolList = other.GetToolList();

                if (equal = CheckItemListsEqual(thisToolList, otherToolList))
                {
                    foreach (var tool in thisToolList)
                    {
                        if (GetQuantity(tool) != other.GetQuantity(tool))
                        {
                            equal = false;
                            break;
                        }
                    }
                }
            }

            if (equal)
            {
                // Check potions

                var thisPotionList = GetPotionList();
                var otherPotionList = other.GetPotionList();

                if (equal = CheckItemListsEqual(thisPotionList, otherPotionList))
                {
                    foreach (var potion in thisPotionList)
                    {
                        if (GetQuantity(potion) != other.GetQuantity(potion))
                        {
                            equal = false;
                            break;
                        }
                    }
                }
            }

            if (equal)
            {
                // Check magic items

                var thisMagicItemList = GetMagicItemList();
                var otherMagicItemList = other.GetMagicItemList();

                if (equal = CheckItemListsEqual(thisMagicItemList, otherMagicItemList))
                {
                    foreach (var item in thisMagicItemList)
                    {
                        if (GetQuantity(item) != other.GetQuantity(item))
                        {
                            equal = false;
                            break;
                        }
                    }
                }
            }

            return equal;
        }

        //
        //  == operator
        //
        public static bool operator ==(InventoryObjectCollection? a, InventoryObjectCollection? b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);

            return a.Equals(b);
        }

        //
        //  != operator
        //
        public static bool operator !=(InventoryObjectCollection? a, InventoryObjectCollection? b)
        {
            return !(a == b);
        }

        //
        //  Equals
        //
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (ReferenceEquals(obj, null))
                return false;

            if (obj is not InventoryObjectCollection)
                return false;

            var other = obj as InventoryObjectCollection;
            if (other == null)
                return false;

            return CompareContents(other);
        }

        //
        //  GetHashCode
        //
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
