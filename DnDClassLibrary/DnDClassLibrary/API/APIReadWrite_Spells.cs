using System.Text.Json;

namespace DND.API
{
    public static partial class APIReadWrite
    {
        //
        //  AddSpellToAPISpellList
        //
        private static bool AddSpellToAPISpellList(APISpell spell, APISpellList spellListObj)
        {
            List<APISpellReference> spellList = spellListObj.results.ToList();
            APISpellReference newSpellRef = new APISpellReference(spell.index, spell.name, spell.url, spell.level);

            int i;
            bool alreadyExists = false;
            for (i = 0; i < spellList.Count; i++)
            {
                if (spell.index == spellList[i].index)
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
            {
                for (i = 0; i < spellList.Count; i++)
                {
                    if (spell.level < spellList[i].level ||
                        (spell.level == spellList[i].level && string.Compare(spell.name, spellList[i].name) == -1))
                    {
                        break;
                    }
                }

                if (i < spellList.Count)
                    spellList.Insert(i, newSpellRef);
                else
                    spellList.Add(newSpellRef);

                spellListObj.results = spellList.ToArray();
                spellListObj.count = spellList.Count;

                return true;
            }

            return false;
        }

        //
        //  AddSpellToAPISpellList
        //
        private static bool AddSpellToAPISpellList(APISpell spell, string listFilePath)
        {
            var jsonStr = GetJsonStringFromFile(listFilePath);
            var spellListObj = jsonStr != null ? JsonSerializer.Deserialize<APISpellList>(jsonStr) : null;
            if (spellListObj == null)
                return false;

            if (AddSpellToAPISpellList(spell, spellListObj) == true)
            {
                try
                {
                    jsonStr = JsonSerializer.Serialize(spellListObj);
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
        //  RemoveSpellFromAPISpellList
        //
        private static bool RemoveSpellFromAPISpellList(Spell spell, string listFilePath)
        {
            var listFileJson = GetJsonStringFromFile(listFilePath);
            var spellListObj = listFileJson != null ? JsonSerializer.Deserialize<APISpellList>(listFileJson) : null;
            if (spellListObj == null)
                return false;

            List<APISpellReference> newList = new List<APISpellReference>();
            foreach (var item in spellListObj.results)
            {
                if (item.index != spell.Index)
                    newList.Add(item);
            }

            if (newList.Count != spellListObj.count)
            {
                spellListObj.results = newList.ToArray();
                spellListObj.count = newList.Count;

                try
                {
                    var newJsonStr = JsonSerializer.Serialize(spellListObj);
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
        //  CheckSpellExists
        //
        public static bool CheckSpellExists(string name)
        {
            return CheckObjectExists(name, "spells");
        }

        //
        //  GetSpell
        //
        public static Spell? GetSpell(string name)
        {
            Spell? spell = null;

            string filePath = GetObjectFilePath(name, "spells");
            if (filePath.Length > 0)
            {
                var jsonStr = GetJsonStringFromFile(filePath);
                var spellObj = jsonStr != null ? JsonSerializer.Deserialize<APISpell>(jsonStr) : null;
                if (spellObj != null)
                    spell = new Spell(spellObj);
            }

            return spell;
        }

        //
        //  GetAllSpells
        //
        public static Spell[] GetAllSpells()
        {
            List<Spell> spells = new List<Spell>();

            var spellDir = RootPath + "\\api\\spells";
            var spellListFile = spellDir + ".json";
            var spellListStr = GetJsonStringFromFile(spellListFile);

            var obj = spellListStr != null ? JsonSerializer.Deserialize<APIReferenceList>(spellListStr) : null;
            if (obj != null)
            {
                foreach (var result in obj.results)
                {
                    var spellFile = spellDir + "\\" + result.index + ".json";
                    var spellStr = GetJsonStringFromFile(spellFile);
                    var spellObj = spellStr != null ? JsonSerializer.Deserialize<APISpell>(spellStr) : null;
                    if (spellObj != null)
                        spells.Add(new Spell(spellObj));
                }
            }

            spellDir = spellDir.Replace("api", "custom");
            spellListFile = spellListFile.Replace("api", "custom");
            spellListStr = GetJsonStringFromFile(spellListFile);

            obj = spellListStr != null ? JsonSerializer.Deserialize<APIReferenceList>(spellListStr) : null;
            if (obj != null)
            {
                foreach (var result in obj.results)
                {
                    var spellFile = spellDir + "\\" + result.index + ".json";
                    var spellStr = GetJsonStringFromFile(spellFile);
                    var spellObj = spellStr != null ? JsonSerializer.Deserialize<APISpell>(spellStr) : null;
                    if (spellObj != null)
                    {
                        var spell = new Spell(spellObj);

                        int i;
                        for (i = 0; i < spells.Count; i++)
                        {
                            if (string.Compare(spell.Name, spells[i].Name) == -1)
                                break;
                        }

                        if (i < spells.Count)
                            spells.Insert(i, spell);
                        else
                            spells.Add(spell);
                    }
                }
            }

            return spells.ToArray();
        }

        //
        //  SaveCustomSpell
        //
        public static int SaveCustomSpell(Spell spell)
        {
            APISpell spellObj = spell.ToAPIObject();

            int errors = SaveCustomObject<APISpell>(spellObj);
            if (errors == 0)
            {
                Class? c;
                string? listFile;

                // Add spell to the necessary class spell lists
                foreach (var className in spell.Classes)
                {
                    if ((c = GetClass(className)) != null)
                    {
                        listFile = RootPath + "\\api\\classes\\" + c.Index + "\\spells.json";
                        if (!File.Exists(listFile))
                        {
                            listFile = listFile.Replace("\\api\\", "\\custom\\");
                            if (!File.Exists(listFile))
                                continue;
                        }

                        AddSpellToAPISpellList(spellObj, listFile);
                    }
                }
            }

            return errors;
        }

        //
        //  DeleteSpell
        //
        public static bool DeleteSpell(Spell spell)
        {
            string listFilePath;

            var spellFilePath = RootPath + spell.URL + ".json";

            try
            {
                if (File.Exists(spellFilePath))
                    File.Delete(spellFilePath);
            }
            catch (Exception)
            {
                return false;
            }

            // Remove spell from general spell list
            listFilePath = spellFilePath.Remove(spellFilePath.LastIndexOf('/')) + ".json";
            RemoveSpellFromAPISpellList(spell, listFilePath);

            // Remove spell from any relevant class spell lists.
            // Only do this if it is a custom spell being deleted since
            // if an SRD spell reference is removed from a custom class
            // and then the SRD data is restored, there would be no way
            // of knowing that the spell should be added back into that
            // class's spell list.
            if (spell.URL.Contains("/custom/"))
            {
                foreach (var className in spell.Classes)
                {
                    var c = GetClass(className);
                    if (c != null)
                    {
                        listFilePath = RootPath + c.URL + "/spells.json";
                        RemoveSpellFromAPISpellList(spell, listFilePath);
                    }
                }
            }

            return true;
        }

        //
        //  DeleteSpell
        //
        public static bool DeleteSpell(string spellName)
        {
            var spell = GetSpell(spellName);
            if (spell != null)
                return DeleteSpell(spell);

            return false;
        }
    }
}
