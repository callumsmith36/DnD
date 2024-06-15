/*********************************************************
 *  
 *  Name:       InventorySystem/Container.cs
 *  
 *  Purpose:    Class for storing InventoryObjects. It
 *              can reference an InventoryObject if it
 *              represents an item (such as a backpack or
 *              chest).
 *  
 *  Author:     CS
 *  
 *  Created:    22/03/2024
 * 
 *********************************************************/

using DND.API;
using DND.Types;

namespace DND.InventorySystem
{
    public class Container : InventoryObjectCollection
    {
        // Member variables
        private string _name;

        // Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                Index = APIReadWrite.NameToIndex(value);
            }
        }

        public string           Index       { get; private set; }
        public string[]         Description { get; set; }
        public InventoryObject? BaseItem    { get; private set; }


        //
        //  Constructor
        //  (new empty container)
        //
        public Container(string name, string[] desc, InventoryObject? baseItem = null) : base()
        {
            _name = name;
            Index = APIReadWrite.NameToIndex(name);
            Description = new string[desc.Length];
            for (int i = 0; i < desc.Length; i++)
                Description[i] = desc[i];

            BaseItem = baseItem;
        }

        //
        //  Constructor
        //  (from APIItemCollection)
        //
        public Container(APIContainer obj) : base(obj)
        {
            _name = obj.name;
            Index = obj.index;
            Description = new string[obj.desc.Length];
            for (int i = 0; i < obj.desc.Length; i++)
                Description[i] = obj.desc[i];

            Equipment? equipment = APIReadWrite.GetEquipment(Name);
            if (equipment != null)
            {
                switch (equipment.EquipmentCategory)
                {
                    case EquipmentCategory.Armour: BaseItem = APIReadWrite.GetArmour(Name); break;
                    case EquipmentCategory.Weapon: BaseItem = APIReadWrite.GetWeapon(Name); break;
                    case EquipmentCategory.Gear: BaseItem = APIReadWrite.GetGear(Name); break;
                    case EquipmentCategory.Tool: BaseItem = APIReadWrite.GetTool(Name); break;
                    default:
                        BaseItem = equipment;
                        break;
                }
            }
            else
            {
                MagicItem? magicItem = APIReadWrite.GetMagicItem(Name);
                if (magicItem != null)
                    BaseItem = magicItem;
            }
        }

        //
        //  Constructor
        //  (from APIEquipmentPack)
        //
        public Container(APIEquipmentPack obj) : base()
        {
            _name = obj.name;
            Index = obj.index;
            Description = new string[obj.desc.Length];
            for (int i = 0; i < obj.desc.Length; i++)
                Description[i] = obj.desc[i];

            BaseItem = APIReadWrite.GetGear(Name);

            string[] equipmentList = APIReadWrite.GetEquipmentIndexList();
            string[] magicList = APIReadWrite.GetMagicItemIndexList();

            foreach (var apiItem in obj.contents)
            {
                if (equipmentList.Contains(apiItem.item.index))
                {
                    Equipment? equipment = APIReadWrite.GetEquipment(apiItem.item.name);
                    if (equipment != null)
                    {
                        AddGeneralEquipment(equipment, apiItem.quantity);
                        continue;
                    }

                    Weapon? weapon = APIReadWrite.GetWeapon(apiItem.item.name);
                    if (weapon != null)
                    {
                        AddWeapon(weapon, apiItem.quantity);
                        continue;
                    }

                    Armour? armour = APIReadWrite.GetArmour(apiItem.item.name);
                    if (armour != null)
                    {
                        AddArmour(armour, apiItem.quantity);
                        continue;
                    }

                    Tool? tool = APIReadWrite.GetTool(apiItem.item.name);
                    if (tool != null)
                    {
                        AddTool(tool, apiItem.quantity);
                        continue;
                    }
                }

                if (magicList.Contains(apiItem.item.index))
                {
                    MagicItem? item = APIReadWrite.GetMagicItem(apiItem.item.name);
                    if (item != null)
                    {
                        if (item.EquipmentCategory == EquipmentCategory.Potion)
                            AddPotion(item, apiItem.quantity);
                        else
                            AddMagicItem(item, apiItem.quantity);
                    }
                }
            }
        }

        //
        //  Copy Constructor
        //
        public Container(Container other) : base(other)
        {
            _name = other.Name;
            Index = other.Index;
            Description = new string[other.Description.Length];
            for (int i = 0; i < other.Description.Length; i++)
                Description[i] = other.Description[i];

            BaseItem = other.BaseItem;
        }


        //
        //  ToAPIObject
        //
        public override APIContainer ToAPIObject()
        {
            int i;

            var apiRef = BaseItem != null ? new APIReference(BaseItem.Index, BaseItem.Name, BaseItem.URL) : null;
            var obj = new APIContainer(Name, Description, CP, SP, GP, PP, apiRef);

            string[] indexList = APIReadWrite.GetEquipmentIndexList();

            var misc = GetGeneralEquipmentList(true);
            obj.general = new APIItem[misc.Length];
            for (i = 0; i < misc.Length; i++)
            {
                var desc = indexList.Contains(misc[i].Index) ? null : misc[i].Description;
                obj.general[i] = new APIItem(misc[i].Index, misc[i].Name, misc[i].URL, GetQuantity(misc[i]), desc);
            }

            var weapons = GetWeaponList(true);
            obj.weapons = new APIItem[weapons.Length];
            for (i = 0; i < weapons.Length; i++)
            {
                var desc = indexList.Contains(weapons[i].Index) ? null : weapons[i].Description;
                obj.weapons[i] = new APIItem(weapons[i].Index, weapons[i].Name, weapons[i].URL, GetQuantity(weapons[i]), desc);
            }

            var armour = GetArmourList(true);
            obj.armour = new APIItem[armour.Length];
            for (i = 0; i < armour.Length; i++)
            {
                var desc = indexList.Contains(armour[i].Index) ? null : armour[i].Description;
                obj.armour[i] = new APIItem(armour[i].Index, armour[i].Name, armour[i].URL, GetQuantity(armour[i]), desc);
            }

            var tools = GetToolList(true);
            obj.tools = new APIItem[tools.Length];
            for (i = 0; i < tools.Length; i++)
            {
                var desc = indexList.Contains(tools[i].Index) ? null : tools[i].Description;
                obj.tools[i] = new APIItem(tools[i].Index, tools[i].Name, tools[i].URL, GetQuantity(tools[i]), desc);
            }

            indexList = APIReadWrite.GetMagicItemIndexList();

            var potions = GetPotionList(true);
            obj.potions = new APIItem[potions.Length];
            for (i = 0; i < potions.Length; i++)
            {
                var desc = indexList.Contains(potions[i].Index) ? null : potions[i].Description;
                obj.potions[i] = new APIItem(potions[i].Index, potions[i].Name, potions[i].URL, GetQuantity(potions[i]), desc);
            }

            var magicItems = GetMagicItemList(true);
            obj.magic_items = new APIItem[magicItems.Length];
            for (i = 0; i < magicItems.Length; i++)
            {
                var desc = indexList.Contains(magicItems[i].Index) ? null : magicItems[i].Description;
                obj.magic_items[i] = new APIItem(magicItems[i].Index, magicItems[i].Name, magicItems[i].URL, GetQuantity(magicItems[i]), desc);
            }

            return obj;
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

            if (obj is not Container)
                return false;

            var other = obj as Container;

            var equal =
                this.Name == other.Name &&
                this.Index == other.Index &&
                this.Description.Length == other.Description.Length;

            if (equal)
            {
                for (int i = 0; i < Description.Length; i++)
                {
                    if (this.Description[i] != other.Description[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            if (equal)
                equal = CompareContents(other);

            return equal;
        }

        //
        //  GetHashCode
        //
        public override int GetHashCode()
        {
            return Index.GetHashCode();
        }
    }
}
