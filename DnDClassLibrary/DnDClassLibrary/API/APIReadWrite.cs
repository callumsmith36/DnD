using RestSharp;
using System.Text.Json;

namespace DND.API
{
    public static partial class APIReadWrite
    {
        public static readonly
            string RootPath = GetDataFolder();
        public static readonly
            string RootURL = "https://www.dnd5eapi.co";


        //
        //  NameToIndex
        //
        public static string NameToIndex(string name)
        {
            name = name.Trim();

            string[] charsToRemove = { ",", "'", "+", "(", ")", ":" };
            foreach (var c in charsToRemove)
                name = name.Replace(c, "");

            return name.ToLower()
                .Replace(' ', '-')
                .Replace('_', '-')
                .Replace('/', '-')
                .Replace('\\', '-');
        }

        //
        //  GetDataFolder
        //
        private static string GetDataFolder()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var parentDir = currentDir != null ? Directory.GetParent(currentDir)?.ToString() : null;

            return parentDir != null ? Path.Combine(parentDir, "data") : string.Empty;
        }

        //
        //  GetJsonStringFromAPI
        //
        public static string? GetJsonStringFromAPI(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.Get(request);
            var jsonStr = response.Content?.ToString();

            return jsonStr;
        }

        //
        //  GetJsonStringFromFile
        //
        public static string? GetJsonStringFromFile(string path)
        {
            if (!path.EndsWith(".json"))
                path += ".json";

            if (File.Exists(path))
                return File.ReadAllText(path);

            return null;
        }

        //
        //  RetrieveAllSRDData
        //
        public static int RetrieveAllSRDData()
        {
            int errors = 0;

            if (Directory.Exists(RootPath))
            {
                errors += RetrieveSRDClasses();
                errors += RetrieveSRDSpells();
                errors += RetrieveSRDRaces();
                errors += RetrieveSRDEquipment();
                errors += RetrieveSRDMagicItems();
                errors += RetrieveSRDEquipmentCategories();
            }
            else
            {
                errors++;
            }

            return errors;
        }

        //
        //  RetrieveSRDClasses
        //
        public static int RetrieveSRDClasses()
        {
            int errors = 0;

            if (Directory.Exists(RootPath))
            {
                errors += FileSetupAPI("classes");

                // Add custom spells back into the necessary class spell lists
                var jsonStr = GetJsonStringFromFile(RootPath + "\\custom\\spells.json");
                var customSpellList = jsonStr != null ? JsonSerializer.Deserialize<APISpellList>(jsonStr) : null;
                if (customSpellList != null)
                {
                    // Traverse list of custom spells
                    foreach (var spellRef in customSpellList.results)
                    {
                        jsonStr = GetJsonStringFromFile(RootPath + spellRef.url + ".json");

                        var spellObj = jsonStr != null ? JsonSerializer.Deserialize<APISpell>(jsonStr) : null;
                        if (spellObj == null)
                            continue;

                        // Traverse the classes referenced by this spell
                        foreach (var classRef in spellObj.classes)
                        {
                            if (classRef.url.Contains("/custom/"))
                                continue;

                            var spellListFile = string.Format("{0}\\api\\classes\\{1}\\spells.json", RootPath, classRef.index);
                            if (AddSpellToAPISpellList(spellObj, spellListFile) == false)
                                errors++;
                        }
                    }
                }
                else
                {
                    errors++;
                }
            }
            else
            {
                errors++;
            }

            return errors;
        }

        //
        //  RetrieveSRDSpells
        //
        public static int RetrieveSRDSpells()
        {
            int errors = 0;

            if (Directory.Exists(RootPath))
            {
                errors += FileSetupAPI("spells");

                // Add custom classes back into the necessary spell class lists
                var jsonStr = GetJsonStringFromFile(RootPath + "\\custom\\classes.json");
                var customClassList = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
                if (customClassList != null)
                {
                    // Traverse list of custom classes
                    foreach (var classRef in customClassList.results)
                    {
                        jsonStr = GetJsonStringFromFile(RootPath + classRef.url + ".json");

                        var classObj = jsonStr != null ? JsonSerializer.Deserialize<APIClass>(jsonStr) : null;
                        if (classObj == null)
                            continue;

                        if (classObj.spells.Length == 0)
                            continue;

                        jsonStr = GetJsonStringFromFile(RootPath + classObj.spells + "\\spells.json");
                        var spellList = jsonStr != null ? JsonSerializer.Deserialize<APISpellList>(jsonStr) : null;
                        if (spellList == null)
                            continue;

                        // Traverse this class's spell list
                        foreach (var spellRef in spellList.results)
                        {
                            var spellFile = RootPath + spellRef.url + ".json";

                            if (spellFile.Contains("/custom/"))
                                continue;

                            jsonStr = GetJsonStringFromFile(spellFile);
                            var spellObj = jsonStr != null ? JsonSerializer.Deserialize<APISpell>(jsonStr) : null;
                            if (spellObj == null)
                                continue;

                            List<APIReference> classList = spellObj.classes.ToList();

                            int i;
                            bool alreadyExists = false;
                            for (i = 0; i < classList.Count; i++)
                            {
                                if (string.Compare(classRef.name, classList[i].name) == -1)
                                    break;

                                if (classRef.index == classList[i].index)
                                {
                                    alreadyExists = true;
                                    break;
                                }
                            }

                            if (!alreadyExists)
                            {
                                // Add the class reference to the spell's class list

                                if (i < classList.Count)
                                    classList.Insert(i, classRef);
                                else
                                    classList.Add(classRef);

                                spellObj.classes = classList.ToArray();
                                jsonStr = JsonSerializer.Serialize(spellObj);

                                try
                                {
                                    File.WriteAllText(spellFile, jsonStr);
                                }
                                catch (Exception)
                                {
                                    errors++;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                errors++;
            }

            return errors;
        }

        //
        //  RetrieveSRDRaces
        //
        public static int RetrieveSRDRaces()
        {
            return Directory.Exists(RootPath) ? FileSetupAPI("races") : 1;
        }

        //
        //  RetrieveSRDEquipment
        //
        public static int RetrieveSRDEquipment()
        {
            return Directory.Exists(RootPath) ? FileSetupAPI("equipment") : 1;
        }

        //
        //  RetrieveSRDMagicItems
        //
        public static int RetrieveSRDMagicItems()
        {
            return Directory.Exists(RootPath) ? FileSetupAPI("magic-items") : 1;
        }

        //
        //  RetrieveSRDEquipmentCategories
        //
        public static int RetrieveSRDEquipmentCategories()
        {
            int errors = 0;

            if (Directory.Exists(RootPath))
            {
                errors += FileSetupAPI("equipment-categories");

                // Add custom equipment back into the necessary equipment category
                var itemListFile = RootPath + "\\custom\\equipment.json";
                var jsonStr = GetJsonStringFromFile(itemListFile);
                var customItemList = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
                if (customItemList != null)
                {
                    // Traverse list of custom equipment
                    foreach (var itemRef in customItemList.results)
                    {
                        jsonStr = GetJsonStringFromFile(RootPath + itemRef.url + ".json");
                        var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIEquipment>(jsonStr) : null;
                        if (itemObj == null)
                            continue;

                        var listFile = RootPath + "\\api\\equipment-categories\\" + itemObj.equipment_category.index + ".json";
                        if (AddItemToAPIEquipmentCategory(itemObj, listFile) == false)
                            errors++;
                    }
                }
                else
                {
                    errors++;
                }

                // Add custom magic items back into the necessary equipment category
                itemListFile = RootPath + "\\custom\\magic-items.json";
                jsonStr = GetJsonStringFromFile(itemListFile);
                customItemList = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
                if (customItemList != null)
                {
                    // Traverse list of custom magic items
                    foreach (var itemRef in customItemList.results)
                    {
                        jsonStr = GetJsonStringFromFile(RootPath + itemRef.url + ".json");
                        var itemObj = jsonStr != null ? JsonSerializer.Deserialize<APIMagicItem>(jsonStr) : null;
                        if (itemObj == null)
                            continue;

                        var listFile = RootPath + "\\api\\equipment-categories\\" + itemObj.equipment_category.index + ".json";
                        if (AddItemToAPIEquipmentCategory(itemObj, listFile) == false)
                            errors++;
                    }
                }
                else
                {
                    errors++;
                }
            }
            else
            {
                errors++;
            }

            return errors;
        }

        //
        //  CustomFileStructureSetup
        //
        public static int CustomFileStructureSetup()
        {
            int errors = 0;

            if (Directory.Exists(RootPath))
            {
                errors += FileSetupCustom("classes");
                errors += FileSetupCustom("spells");
                errors += FileSetupCustom("races");
                errors += FileSetupCustom("magic-items");
                errors += FileSetupCustom("equipment");
            }
            else
            {
                errors++;
            }

            return errors;
        }

        //
        //  FileSetupAPI
        //
        private static int FileSetupAPI(string category)
        {
            int i;
            int errors = 0;
            string dirPath;
            string filePath;
            string? jsonStr;

            category = NameToIndex(category);
            dirPath = RootPath + "\\api\\" + category;

            try
            {
                // Create top-level folder (e.g. ...\api\classes)
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

                if (Directory.Exists(dirPath))
                {
                    filePath = RootPath + "\\api\\" + category + ".json";
                    jsonStr = GetJsonStringFromAPI(RootURL + "/api/" + category);

                    // Create top-level file (e.g. ...\api\classes.json)
                    if (jsonStr != null)
                        File.WriteAllText(filePath, jsonStr);

                    if (File.Exists(filePath))
                    {
                        var obj = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
                        if (obj != null)
                        {
                            // Create files within the top-level folder (e.g. ...\api\classes\rogue.json)
                            for (i = 0; i < obj.count; i++)
                            {
                                filePath = RootPath + obj.results[i].url + ".json";

                                jsonStr = GetJsonStringFromAPI(RootURL + obj.results[i].url);
                                if (jsonStr != null)
                                    File.WriteAllText(filePath, jsonStr);

                                // Create spell list files
                                if (category == "classes")
                                {
                                    var classFolder = RootPath + obj.results[i].url;

                                    if (!Directory.Exists(classFolder))
                                        Directory.CreateDirectory(classFolder);

                                    if (Directory.Exists(classFolder))
                                    {
                                        filePath = classFolder + "\\spells.json";

                                        jsonStr = GetJsonStringFromAPI(RootURL + obj.results[i].url + "\\spells");
                                        if (jsonStr != null)
                                            File.WriteAllText(filePath, jsonStr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                errors++;
            }

            return errors;
        }

        //
        //  FileSetupCustom
        //
        private static int FileSetupCustom(string category)
        {
            int errors = 0;

            var jsonStr = JsonSerializer.Serialize(new APIReferenceList());

            category = category.ToLower();
            string dirPath = RootPath + "\\custom\\" + category;
            string filePath = dirPath + ".json";

            try
            {
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

                if (Directory.Exists(dirPath) && !File.Exists(filePath))
                    File.WriteAllText(filePath, jsonStr);
            }
            catch (Exception)
            {
                errors++;
            }

            return errors;
        }

        //
        //  GetObjectNameOrIndexList
        //
        private static string[] GetObjectNameOrIndexList(string listFileName, int nameOrIndex)
        {
            // nameOrIndex:  0 -> name, 1 -> index

            List<string> results = new List<string>();

            if (!listFileName.EndsWith(".json"))
                listFileName += ".json";

            var listFile = RootPath + "\\api\\" + listFileName;
            var jsonStr = GetJsonStringFromFile(listFile);

            var apiList = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
            if (apiList != null)
            {
                foreach (var obj in apiList.results)
                {
                    if (nameOrIndex == 0)
                        results.Add(obj.name);
                    else if (nameOrIndex == 1)
                        results.Add(obj.index);
                }
            }

            listFile = listFile.Replace("\\api\\", "\\custom\\");
            jsonStr = GetJsonStringFromFile(listFile);

            var customList = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
            if (customList != null)
            {
                foreach (var obj in customList.results)
                {
                    if (nameOrIndex == 0)
                        results.Add(obj.name);
                    else if (nameOrIndex == 1)
                        results.Add(obj.index);
                }
            }

            results.Sort();
            return results.ToArray();
        }

        //
        //  GetObjectFilePath
        //
        private static string GetObjectFilePath(string name, string listFileName)
        {
            string objFilePath = string.Empty;
            string objDirPath = RootPath + "\\api\\" + listFileName;
            string index = NameToIndex(name);

            // Search API directory
            var jsonStr = GetJsonStringFromFile(objDirPath + ".json");
            var obj = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
            if (obj != null)
            {
                foreach (var result in obj.results)
                {
                    if (NameToIndex(result.name) == index)
                    {
                        objFilePath = objDirPath + "\\" + result.index + ".json";
                        break;
                    }
                }
            }

            // If not found, search custom directory
            if (objFilePath.Length == 0)
            {
                objDirPath = RootPath + "\\custom\\" + listFileName;
                jsonStr = GetJsonStringFromFile(objDirPath + ".json");
                obj = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
                if (obj != null)
                {
                    foreach (var result in obj.results)
                    {
                        if (NameToIndex(result.name) == index)
                        {
                            objFilePath = objDirPath + "\\" + result.index + ".json";
                            break;
                        }
                    }
                }
            }

            return objFilePath;
        }

        //
        //  CheckObjectExists
        //
        private static bool CheckObjectExists(string name, string listFileName)
        {
            bool exists = false;
            string index = NameToIndex(name);

            if (!listFileName.EndsWith(".json"))
                listFileName += ".json";

            // Check API directory
            var listFile = RootPath + "\\api\\" + listFileName;
            var jsonStr = GetJsonStringFromFile(listFile);
            var objList = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
            if (objList != null)
            {
                foreach (var item in objList.results)
                {
                    if (NameToIndex(item.name) == index)
                    {
                        exists = true;
                        break;
                    }
                }
            }

            if (!exists)
            {
                // Check custom directory
                listFile = listFile.Replace("\\api\\", "\\custom\\");
                jsonStr = GetJsonStringFromFile(listFile);
                objList = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
                if (objList != null)
                {
                    foreach (var item in objList.results)
                    {
                        if (NameToIndex(item.name) == index)
                        {
                            exists = true;
                            break;
                        }
                    }
                }
            }

            return exists;
        }

        //
        //  SaveCustomObject
        //
        private static int SaveCustomObject<T>(T obj)
            where T : APIReference
        {
            // 0  -> success
            // 1  -> directory does not exist
            // 2  -> failed to serialise - object not saved
            // 3  -> failed to add new entry to corresponding list
            // -1 -> exception thrown

            try
            {
                string objPath = obj.url.Replace("api/", "custom/");
                string dirPath = objPath.Remove(objPath.LastIndexOf("/"));
                string listFile = RootPath + dirPath + ".json";

                if (!Directory.Exists(RootPath + dirPath))
                    Directory.CreateDirectory(RootPath + dirPath);

                if (!Directory.Exists(RootPath + dirPath))
                    return 1;

                string? filePath = RootPath + objPath + ".json";
                string? jsonStr = JsonSerializer.Serialize(obj);
                if (jsonStr == null)
                    return 2;

                File.WriteAllText(filePath, jsonStr);

                if (AddObjectToAPIReferenceList(obj, listFile) == false)
                    return 3;
            }
            catch (Exception ex)
            {
                return -1;
            }

            return 0;
        }

        //
        //  AddObjectToAPIReferenceList
        //
        private static bool AddObjectToAPIReferenceList<T>(T obj, string listFilePath)
            where T : APIReference
        {
            if (obj is APISpell)
            {
                APISpell? spell = obj as APISpell;
                if (spell != null)
                    return AddSpellToAPISpellList(spell, listFilePath);
            }

            var jsonStr = GetJsonStringFromFile(listFilePath);
            var listObj = jsonStr != null ? JsonSerializer.Deserialize<APIReferenceList>(jsonStr) : null;
            if (listObj == null)
                return false;

            List<APIReference> itemList = listObj.results.ToList();

            int i;
            bool alreadyExists = false;
            for (i = 0; i < itemList.Count; i++)
            {
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

                listObj.results = itemList.ToArray();
                listObj.count = itemList.Count;

                try
                {
                    jsonStr = JsonSerializer.Serialize(listObj);
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
        //  RemoveObjectFromAPIReferenceList
        //
        private static void RemoveObjectFromAPIReferenceList<T>(T obj, string listFilePath)
            where T : DNDReference
        {
            if (obj is Spell)
            {
                Spell? spell = obj as Spell;
                if (spell != null)
                {
                    RemoveSpellFromAPISpellList(spell, listFilePath);
                    return;
                }
            }

            var listFileJson = GetJsonStringFromFile(listFilePath);
            var listObj = listFileJson != null ? JsonSerializer.Deserialize<APIReferenceList>(listFileJson) : null;
            if (listObj != null)
            {
                List<APIReference> newList = new List<APIReference>();
                foreach (var item in listObj.results)
                {
                    if (item.index != obj.Index)
                        newList.Add(item);
                }

                if (newList.Count != listObj.count)
                {
                    listObj.results = newList.ToArray();
                    listObj.count = newList.Count;

                    try
                    {
                        var newJsonStr = JsonSerializer.Serialize(listObj);
                        File.WriteAllText(listFilePath, newJsonStr);
                    }
                    catch (Exception) { }
                }
            }
        }
    }
}
