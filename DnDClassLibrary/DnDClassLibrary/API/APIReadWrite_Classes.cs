using System.Text.Json;

namespace DND.API
{
    public static partial class APIReadWrite
    {
        //
        //  CheckClassExists
        //
        public static bool CheckClassExists(string name)
        {
            return CheckObjectExists(name, "classes");
        }

        //
        //  GetClass
        //
        public static Class? GetClass(string name)
        {
            Class? c = null;

            string filePath = GetObjectFilePath(name, "classes");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var classObj = jsonStr != null ? JsonSerializer.Deserialize<APIClass>(jsonStr) : null;
                if (classObj != null)
                    c = new Class(classObj);
            }

            return c;
        }

        //
        //  GetClassNameList
        //
        public static string[] GetClassNameList()
        {
            return GetObjectNameOrIndexList("classes", 0);
        }

        //
        //  GetClassSpellList
        //
        public static Spell[] GetClassSpellList(string className)
        {
            List<Spell> spells = new List<Spell>();

            var c = GetClass(className);
            if (c != null)
            {
                foreach (var spellName in c.SpellList)
                {
                    Spell? spell = GetSpell(spellName);
                    if (spell != null)
                        spells.Add(spell);
                }
            }

            return spells.ToArray();
        }

        //
        //  SaveCustomClass
        //
        public static int SaveCustomClass(Class c)
        {
            APIClass classObj = c.ToAPIObject();

            int errors = SaveCustomObject<APIClass>(classObj);
            if (errors == 0)
            {
                string? jsonStr;
                string? filePath;

                List<Spell> spells = new List<Spell>();

                APISpellList spellList = new APISpellList();
                foreach (var spellName in c.SpellList)
                {
                    var spell = GetSpell(spellName);
                    if (spell == null)
                        continue;

                    spells.Add(spell);
                    AddSpellToAPISpellList(spell.ToAPIObject(), spellList);
                }

                try
                {
                    string classDir = (RootPath + c.URL).Replace('/', '\\');
                    if (!Directory.Exists(classDir))
                        Directory.CreateDirectory(classDir);

                    filePath = Path.Combine(classDir, "spells.json");
                    jsonStr = JsonSerializer.Serialize(spellList);
                    File.WriteAllText(filePath, jsonStr);
                }
                catch (Exception)
                {
                    return 1;
                }

                // Add class reference to each spell
                foreach (var spell in spells)
                {
                    filePath = string.Format("{0}\\{1}.json", RootPath, spell.URL.Replace('/', '\\'));
                    jsonStr = GetJsonStringFromFile(filePath);

                    var spellObj = jsonStr != null ? JsonSerializer.Deserialize<APISpell>(jsonStr) : null;
                    if (spellObj == null)
                        continue;

                    int i;
                    bool alreadyExists = false;
                    List<APIReference> classList = spellObj.classes.ToList();

                    for (i = 0; i < classList.Count; i++)
                    {
                        if (c.Index == classList[i].index)
                        {
                            alreadyExists = true;
                            break;
                        }

                        if (string.Compare(c.Index, classList[i].index) == -1)
                            break;
                    }

                    if (!alreadyExists)
                    {
                        if (i < classList.Count)
                            classList.Insert(i, classObj);
                        else
                            classList.Add(classObj);

                        spellObj.classes = classList.ToArray();
                        jsonStr = JsonSerializer.Serialize(spellObj);
                        File.WriteAllText(filePath, jsonStr);
                    }
                }
            }

            return errors;
        }

        //
        //  DeleteClass
        //
        public static bool DeleteClass(Class c)
        {
            string listFilePath;

            var classDirPath = (RootPath + c.URL).Replace('/', '\\');
            var classFilePath = classDirPath + ".json";

            try
            {
                if (File.Exists(classFilePath))
                    File.Delete(classFilePath);

                if (Directory.Exists(classDirPath))
                    Directory.Delete(classDirPath, true);
            }
            catch (Exception)
            {
                return false;
            }

            // Remove class from classes.json
            listFilePath = classFilePath.Remove(classFilePath.LastIndexOf('\\')) + ".json";
            RemoveObjectFromAPIReferenceList<Class>(c, listFilePath);

            // Remove class from any spells that reference it.
            // Only do this if it is a custom class being deleted, as
            // removing references to an SRD class could have annoying
            // ramifications if the SRD data is then restored since there
            // would be no way of knowing which custom spells should
            // reference it.
            if (c.URL.Contains("/custom/"))
            {
                for (int i = 0; i < 2; i++)
                {
                    APISpell? spellObj;

                    var spellListFile = RootPath;
                    spellListFile += i == 0 ? "\\api\\spells.json" : "\\custom\\spells.json";

                    var jsonStr = GetJsonStringFromFile(spellListFile);
                    var spellListObj = jsonStr != null ? JsonSerializer.Deserialize<APISpellList>(jsonStr) : null;
                    if (spellListObj != null)
                    {
                        foreach (var spellRef in spellListObj.results)
                        {
                            var spellFile = RootPath + spellRef.url + ".json";

                            jsonStr = GetJsonStringFromFile(spellFile);
                            spellObj = jsonStr != null ? JsonSerializer.Deserialize<APISpell>(jsonStr) : null;
                            if (spellObj == null)
                                continue;

                            List<APIReference> newClassRefList = new List<APIReference>();
                            foreach (var classRef in spellObj.classes)
                            {
                                if (classRef.index != c.Index)
                                    newClassRefList.Add(classRef);
                            }

                            if (newClassRefList.Count != spellObj.classes.Length)
                            {
                                spellObj.classes = newClassRefList.ToArray();
                                jsonStr = JsonSerializer.Serialize(spellObj);
                                File.WriteAllText(spellFile, jsonStr);
                            }
                        }
                    }
                }
            }

            return true;
        }

        //
        //  DeleteClass
        //
        public static bool DeleteClass(string className)
        {
            var c = GetClass(className);
            if (c != null)
                return DeleteClass(c);

            return false;
        }
    }
}
