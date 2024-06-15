/*********************************************************
 *  
 *  Name:       API/APIReadWrite_Items.cs
 *  
 *  Purpose:    Methods regarding D&D items for the
 *              APIReadWrite class
 *  
 *  Author:     CS
 *  
 *  Created:    14/04/2024
 * 
 *********************************************************/

using DND.InventorySystem;
using DND.Types;
using System.Text.Json;

namespace DND.API
{
    public static partial class APIReadWrite
    {
        //
        //  AddItemToAPIEquipmentCategory
        //
        private static bool AddItemToAPIEquipmentCategory(APIReference obj, string listFilePath)
        {
            var jsonStr = GetJsonStringFromFile(listFilePath);
            var categoryObj = jsonStr != null ? JsonSerializer.Deserialize<APIEquipmentCategory>(jsonStr) : null;
            if (categoryObj == null)
                return false;

            List<APIReference> itemList = categoryObj.equipment.ToList();

            int i;
            bool alreadyExists = false;
            for (i = 0; i < itemList.Count; i++)
            {
                // Ensures that all magic items come after all equipment in the list
                if (obj.url.Contains("/magic-items/") && !itemList[i].url.Contains("/magic-items/"))
                    continue;

                if (string.Compare(obj.name, itemList[i].name) == -1)
                    break;

                if (obj.index == itemList[i].index)
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
            {
                if (i < itemList.Count)
                    itemList.Insert(i, obj);
                else
                    itemList.Add(obj);

                categoryObj.equipment = itemList.ToArray();
                jsonStr = JsonSerializer.Serialize(categoryObj);

                try
                {
                    File.WriteAllText(listFilePath, jsonStr);
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }

        //
        //  RemoveItemFromAPIEquipmentCategory
        //
        private static bool RemoveItemFromAPIEquipmentCategory(InventoryObject item, string listFilePath)
        {
            var listFileJson = GetJsonStringFromFile(listFilePath);
            var categoryObj = listFileJson != null ? JsonSerializer.Deserialize<APIEquipmentCategory>(listFileJson) : null;
            if (categoryObj == null)
                return false;

            List<APIReference> newList = new List<APIReference>();

            foreach (var obj in categoryObj.equipment)
            {
                if (obj.index != item.Index)
                    newList.Add(obj);
            }

            if (newList.Count != categoryObj.equipment.Length)
            {
                categoryObj.equipment = newList.ToArray();

                try
                {
                    var newJsonStr = JsonSerializer.Serialize(categoryObj);
                    File.WriteAllText(listFilePath, newJsonStr);
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }

        //
        //  SaveCustomItem
        //
        private static int SaveCustomItem<dndType, apiType>(dndType item)
            where dndType : InventoryObject
            where apiType : APIReference
        {
            var obj = item.ToAPIObject();
            if (obj is not apiType)
                return 1;

            var apiObj = obj as apiType;
            if (apiObj == null)
                return 1;

            int errors = SaveCustomObject<apiType>(apiObj);
            if (errors == 0)
            {
                string listFile = string.Format("{0}\\api\\equipment-categories\\{1}.json", RootPath, NameToIndex(TypeMaps.EquipmentCategoryNames[item.EquipmentCategory]));
                APIReference newObj = new APIReference(item.Index, item.Name, item.URL);

                if (AddItemToAPIEquipmentCategory(newObj, listFile) == false)
                    errors++;
            }

            if (errors > 0)
            {
                var itemFile = item.URL + ".json";
                try
                {
                    if (File.Exists(itemFile))
                        File.Delete(itemFile);
                }
                catch (Exception) { }
            }

            return errors;
        }

        //
        //  SaveCustomMagicItem
        //
        public static int SaveCustomMagicItem(MagicItem item)
        {
            return SaveCustomItem<MagicItem, APIMagicItem>(item);
        }

        //
        //  SaveCustomWeapon
        //
        public static int SaveCustomWeapon(Weapon weapon)
        {
            return SaveCustomItem<Weapon, APIWeapon>(weapon);
        }

        //
        //  SaveCustomArmour
        //
        public static int SaveCustomArmour(Armour armour)
        {
            return SaveCustomItem<Armour, APIArmour>(armour);
        }

        //
        //  CheckEquipmentExists
        //
        public static bool CheckEquipmentExists(string name)
        {
            return CheckObjectExists(name, "equipment");
        }

        //
        //  CheckMagicItemExists
        //
        public static bool CheckMagicItemExists(string name)
        {
            return CheckObjectExists(name, "magic-items");
        }

        //
        //  GetEquipmentIndexList
        //
        public static string[] GetEquipmentIndexList()
        {
            return GetObjectNameOrIndexList("equipment", 1);
        }

        //
        //  GetMagicItemIndexList
        //
        public static string[] GetMagicItemIndexList()
        {
            return GetObjectNameOrIndexList("magic-items", 1);
        }

        //
        //  GetEquipment
        //
        public static Equipment? GetEquipment(string name)
        {
            Equipment? item = null;

            string filePath = GetObjectFilePath(name, "equipment");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIEquipment>(jsonStr) : null;
                if (itemObj != null)
                    item = new Equipment(itemObj);
            }

            return item;
        }

        //
        //  GetMagicItem
        //
        public static MagicItem? GetMagicItem(string name)
        {
            MagicItem? item = null;

            string filePath = GetObjectFilePath(name, "magic-items");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIMagicItem>(jsonStr) : null;
                if (itemObj != null)
                    item = new MagicItem(itemObj);
            }

            return item;
        }

        //
        //  GetWeapon
        //
        public static Weapon? GetWeapon(string name)
        {
            Weapon? weapon = null;

            string filePath = GetObjectFilePath(name, "equipment");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIWeapon>(jsonStr) : null;
                if (itemObj != null)
                {
                    if (itemObj.equipment_category.index == "weapon")
                        weapon = new Weapon(itemObj);
                }
            }

            return weapon;
        }

        //
        //  GetArmour
        //
        public static Armour? GetArmour(string name)
        {
            Armour? armour = null;

            string filePath = GetObjectFilePath(name, "equipment");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIArmour>(jsonStr) : null;
                if (itemObj != null)
                {
                    if (itemObj.equipment_category.index == "armor")
                        armour = new Armour(itemObj);
                }
            }

            return armour;
        }

        //
        //  GetGear
        //
        public static Gear? GetGear(string name)
        {
            Gear? gear = null;

            string filePath = GetObjectFilePath(name, "equipment");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIGear>(jsonStr) : null;
                if (itemObj != null)
                    gear = new Gear(itemObj);
            }

            return gear;
        }

        //
        //  GetTool
        //
        public static Tool? GetTool(string name)
        {
            Tool? tool = null;

            string filePath = GetObjectFilePath(name, "equipment");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APITool>(jsonStr) : null;
                if (itemObj != null)
                    tool = new Tool(itemObj);
            }

            return tool;
        }

        //
        //  GetEquipmentPack
        //
        public static Container? GetEquipmentPack(string name)
        {
            Container? pack = null;

            string filePath = GetObjectFilePath(name, "equipment");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIEquipmentPack>(jsonStr) : null;
                if (itemObj != null)
                {
                    if (itemObj.gear_category.index == "equipment-packs")
                        pack = new Container(itemObj);
                }
            }

            return pack;
        }

        //
        //  GetItemsFromCategory
        //
        public static InventoryObject[] GetItemsFromCategory(EquipmentCategory category)
        {
            List<InventoryObject> items = new List<InventoryObject>();

            if (category == EquipmentCategory.None)
                return items.ToArray();

            string categoryStr = NameToIndex(TypeMaps.EquipmentCategoryNames[category]);
            string listFile = RootPath + "\\api\\equipment-categories\\" + categoryStr + ".json";

            var jsonStr = GetJsonStringFromFile(listFile);
            var listObj = jsonStr != null ? JsonSerializer.Deserialize<APIEquipmentCategory>(jsonStr) : null;
            if (listObj != null)
            {
                foreach (var itemRef in listObj.equipment)
                {
                    var itemFile = RootPath + itemRef.url + ".json";
                    jsonStr = GetJsonStringFromFile(itemFile);

                    if (itemRef.url.Contains("equipment"))
                    {
                        var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIEquipment>(jsonStr) : null;
                        if (itemObj != null)
                            items.Add(new Equipment(itemObj));
                    }
                    else if (itemRef.url.Contains("magic-items"))
                    {
                        var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIMagicItem>(jsonStr) : null;
                        if (itemObj != null)
                            items.Add(new MagicItem(itemObj));
                    }
                }
            }

            return items.ToArray();
        }

        //
        //  DeleteItem
        //
        public static bool DeleteItem(InventoryObject item)
        {
            string itemFile = string.Format("{0}\\{1}.json", RootPath, item.URL);

            try
            {
                if (File.Exists(itemFile))
                    File.Delete(itemFile);
            }
            catch (Exception)
            {
                return false;
            }

            // Remove spell from item list
            string listFile = itemFile.Remove(itemFile.LastIndexOf('/')) + ".json";
            RemoveObjectFromAPIReferenceList(item, listFile);

            string categoryFile = string.Format("{0}\\api\\equipment-categories\\{1}.json", RootPath, NameToIndex(TypeMaps.EquipmentCategoryNames[item.EquipmentCategory]));
            RemoveItemFromAPIEquipmentCategory(item, categoryFile);

            return true;
        }
    }
}
