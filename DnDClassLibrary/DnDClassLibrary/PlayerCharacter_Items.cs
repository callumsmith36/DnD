using DND.InventorySystem;

namespace DND
{
    partial class PlayerCharacter
    {
        //
        //  EquipOrAttune
        //
        private bool EquipOrAttune(InventoryObject item, List<InventoryObject> list)
        {
            if (list.Contains(item))
                return false;

            if (Inventory.TryGetWeapon(item.Name, out var weapon))
                list.Add(weapon);
            else if (Inventory.TryGetArmour(item.Name, out var armour))
                list.Add(armour);
            else if (Inventory.TryGetMagicItem(item.Name, out var magicItem))
                list.Add(magicItem);
            else
                return false;

            return true;
        }

        //
        //  UnequipOrUnattune
        //
        private bool UnequipOrUnattune(InventoryObject item, List<InventoryObject> list)
        {
            foreach (var obj in list)
            {
                if (obj.Index == item.Index)
                    return list.Remove(obj);
            }

            return false;
        }

        //
        //  IsEquippedOrAttuned
        //
        private bool IsEquippedOrAttuned(InventoryObject item, List<InventoryObject> list)
        {
            foreach (var obj in list)
            {
                if (obj.Index == item.Index)
                    return true;
            }

            return false;
        }

        //
        //  GetEquippedOrAttunedItems
        //
        private InventoryObject[] GetEquippedOrAttunedItems(List<InventoryObject> list)
        {
            List<InventoryObject> output = new List<InventoryObject>();

            int i;

            foreach (var item in list)
            {
                for (i = 0; i < output.Count; i++)
                {
                    if (string.Compare(item.Name, output[i].Name) == -1)
                        break;
                }

                if (i < output.Count)
                    output.Insert(i, item);
                else
                    output.Add(item);
            }

            return output.ToArray();
        }

        //
        //  UpdateEquippedOrAttunedItems
        //
        private void UpdateEquippedOrAttunedItems(List<InventoryObject> list)
        {
            foreach (var item in list)
            {
                if (Inventory.TryGetWeapon(item.Name, out var weapon))
                    continue;
                else if (Inventory.TryGetArmour(item.Name, out var armour))
                    continue;
                else if (Inventory.TryGetMagicItem(item.Name, out var magicItem))
                    continue;

                UnequipOrUnattune(item, list);
            }
        }

        //
        //  EquipItem
        //
        public bool EquipItem(InventoryObject item)
        {
            return EquipOrAttune(item, _equippedItems);
        }

        //
        //  UnequipItem
        //
        public bool UnequipItem(InventoryObject item)
        {
            return UnequipOrUnattune(item, _equippedItems);
        }

        //
        //  UnequipItem
        //
        public bool IsEquipped(InventoryObject item)
        {
            return IsEquippedOrAttuned(item, _equippedItems);
        }

        //
        //  GetEquippedItems
        //
        public InventoryObject[] GetEquippedItems()
        {
            return GetEquippedOrAttunedItems(_equippedItems);
        }

        //
        //  AttuneItem
        //
        public bool AttuneItem(InventoryObject item)
        {
            return EquipOrAttune(item, _attunedItems);
        }

        //
        //  UnattuneItem
        //
        public bool UnattuneItem(InventoryObject item)
        {
            return UnequipOrUnattune(item, _attunedItems);
        }

        //
        //  IsAttuned
        //
        public bool IsAttuned(InventoryObject item)
        {
            return IsEquippedOrAttuned(item, _attunedItems);
        }

        //
        //  GetAttunedItems
        //
        public InventoryObject[] GetAttunedItems()
        {
            return GetEquippedOrAttunedItems(_attunedItems);
        }

        //
        //  Inventory_OnItemRemoved
        //
        private void Inventory_OnItemRemoved()
        {
            UpdateEquippedOrAttunedItems(_equippedItems);
            UpdateEquippedOrAttunedItems(_attunedItems);
        }
    }
}
