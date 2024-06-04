using DND.API;

namespace DND.InventorySystem
{
    public class Inventory : InventoryObjectCollection
    {
        // Member variables
        private List<Container> _containers;

        // Properties
        public override int Count
        {
            get
            {
                return base.Count + _containers.Count;
            }
        }


        //
        //  Constructor
        //
        public Inventory()
        {
            _general = new Dictionary<Equipment, int>();
            _weapons = new Dictionary<Weapon, int>();
            _armour = new Dictionary<Armour, int>();
            _tools = new Dictionary<Tool, int>();
            _potions = new Dictionary<MagicItem, int>();
            _magicItems = new Dictionary<MagicItem, int>();
            _containers = new List<Container>();

            PP = GP = SP = CP = 0;
        }

        //
        //  Constructor
        //  (load from file)
        //
        public Inventory(APIInventory inv) : base(inv)
        {
            _containers = new List<Container>();
            foreach (var obj in inv.containers)
                _containers.Add(new Container(obj));
        }

        //
        //  Copy Constructor
        //
        public Inventory(Inventory inv) : base(inv)
        {
            _containers = new List<Container>();
            foreach (var container in inv.GetContainerList())
                _containers.Add(new Container(container));
        }


        //
        //  Contains
        //
        public override bool Contains(InventoryObject item)
        {
            if (base.Contains(item))
                return true;

            foreach (var container in _containers)
            {
                if (container.Contains(item))
                    return true;
            }

            return false;
        }


        #region CONTAINERS

        //
        //  AddContainer
        //
        public bool AddContainer(Container container)
        {
            if (_containers.Contains(container))
                return false;

            int i;

            for (i = 0; i < _containers.Count; i++)
            {
                if (string.Compare(container.Index, _containers[i].Index) == -1)
                    break;
            }

            if (i < _containers.Count)
                _containers.Insert(i, container);
            else
                _containers.Add(container);

            return true;
        }

        //
        //  RemoveContainer
        //
        public bool RemoveContainer(Container container)
        {
            return _containers.Remove(container);
        }

        //
        //  RemoveContainer
        //
        public bool RemoveContainer(string name)
        {
            name = APIReadWrite.NameToIndex(name);
            foreach (var container in _containers)
            {
                if (APIReadWrite.NameToIndex(container.Name) == name)
                {
                    return _containers.Remove(container);
                }
            }

            return false;
        }

        //
        //  TryGetContainer
        //
        public bool TryGetContainer(string name, out Container? container)
        {
            string index = APIReadWrite.NameToIndex(name);
            foreach (var item in _containers)
            {
                if (item.Index == index)
                {
                    container = item;
                    return true;
                }
            }

            container = null;
            return false;
        }

        //
        //  GetContainerList
        //
        public Container[] GetContainerList()
        {
            return _containers.ToArray();
        }

        #endregion // CONTAINERS


        //
        //  ToAPIObject
        //
        public override APIInventory ToAPIObject()
        {
            int i;

            var obj = new APIInventory(CP, SP, GP, PP);

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

            obj.containers = new APIContainer[_containers.Count];
            for (i = 0; i < _containers.Count; i++)
                obj.containers[i] = _containers[i].ToAPIObject();

            return obj;
        }


        //
        //  == operator
        //
        public static bool operator ==(Inventory? a, Inventory? b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);

            return a.Equals(b);
        }

        //
        //  != operator
        //
        public static bool operator !=(Inventory? a, Inventory? b)
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

            if (obj is not Inventory)
                return false;

            var other = obj as Inventory;
            if (other == null)
                return false;

            if (CompareContents(other) == false)
                return false;

            var equal = this._containers.Count == other._containers.Count;

            if (equal)
            {
                for (int i = 0; i < this._containers.Count; i++)
                {
                    bool foundInOther = false;
                    for (int j = 0; j < other._containers.Count; j++)
                    {
                        if (this._containers[i] == other._containers[j])
                        {
                            foundInOther = true;
                            break;
                        }
                    }

                    if (!foundInOther)
                    {
                        equal = false;
                        break;
                    }
                }
            }

            return equal;
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
