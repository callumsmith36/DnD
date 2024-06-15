/*********************************************************
 *  
 *  Name:       Class.cs
 *  
 *  Purpose:    Class for handling a D&D class
 *  
 *  Author:     CS
 *  
 *  Created:    22/12/2023
 * 
 *********************************************************/

using DND.API;
using DND.Types;
using System.Text.Json;

namespace DND
{
    public class Class : DNDReference
    {
        // Properties
        public int              HitDie                  { get; private set; }
        public int              ProficiencyChoiceCount  { get; private set; }
        public List<Skill>      SkillProficiencyOptions { get; private set; }
        public List<Ability>    SavingThrows            { get; private set; }
        public List<ArmourType> ArmourProficiencies     { get; private set; }
        public List<WeaponType> WeaponProficiencies     { get; private set; }
        public List<ToolOrKit>  ToolProficiencies       { get; private set; }
        public List<string>     SpellList               { get; private set; }
        public Ability          SpellcastingAbility     { get; private set; }


        #region CONSTRUCTORS

        //
        //  Constructor
        //  (from custom data)
        //
        public Class(
            string name, int hitDie, int profCount,
            Skill[] skills, Ability[] saves, ArmourType[] armour,
            WeaponType[] weapons, ToolOrKit[] tools, Ability spellAbility = Ability.None,
            string[]? spells = null
        )
            : base(name, "/custom/classes")
        {
            int i;

            HitDie = hitDie;
            ProficiencyChoiceCount = profCount;

            SkillProficiencyOptions = new List<Skill>();
            for (i = 0; i < skills.Length; i++)
                SkillProficiencyOptions.Add(skills[i]);

            SavingThrows = new List<Ability>();
            for (i = 0; i < saves.Length; i++)
                SavingThrows.Add(saves[i]);

            ArmourProficiencies = new List<ArmourType>();
            for (i = 0; i < armour.Length; i++)
                ArmourProficiencies.Add(armour[i]);

            WeaponProficiencies = new List<WeaponType>();
            for (i = 0; i < weapons.Length; i++)
                WeaponProficiencies.Add(weapons[i]);

            ToolProficiencies = new List<ToolOrKit>();
            for (i = 0; i < tools.Length; i++)
                ToolProficiencies.Add(tools[i]);

            SpellList = new List<string>();
            if (spells != null)
            {
                for (i = 0; i < spells.Length; i++)
                    SpellList.Add(spells[i]);
            }

            SpellcastingAbility = spellAbility;
        }

        //
        //  Constructor
        //  (from API or file)
        //
        public Class(APIClass obj) : base(obj)
        {
            int i;

            HitDie = obj.hit_die;

            SavingThrows = new List<Ability>();
            for (i = 0; i < obj.saving_throws.Length; i++)
            {
                switch (obj.saving_throws[i].name)
                {
                    case "STR": SavingThrows.Add(Ability.Strength); break;
                    case "DEX": SavingThrows.Add(Ability.Dexterity); break;
                    case "CON": SavingThrows.Add(Ability.Constitution); break;
                    case "INT": SavingThrows.Add(Ability.Intelligence); break;
                    case "WIS": SavingThrows.Add(Ability.Wisdom); break;
                    case "CHA": SavingThrows.Add(Ability.Charisma); break;
                    default:
                        break;
                }
            }

            SkillProficiencyOptions = new List<Skill>();
            for (i = 0; i < obj.proficiency_choices.Length; i++)
            {
                if (obj.proficiency_choices[i].type == "proficiencies")
                {
                    var profOptStr = obj.proficiency_choices[i].desc;

                    foreach (var skill in TypeMaps.SkillNames.Keys)
                    {
                        if (profOptStr.Contains(TypeMaps.SkillNames[skill]))
                            SkillProficiencyOptions.Add(skill);
                    }

                    ProficiencyChoiceCount = obj.proficiency_choices[i].choose;
                }
            }

            ArmourProficiencies = new List<ArmourType>();
            WeaponProficiencies = new List<WeaponType>();
            ToolProficiencies = new List<ToolOrKit>();
            PopulateProficiencies(obj);

            SpellList = new List<string>();
            PopulateSpellList(obj);

            SpellcastingAbility = Ability.None;
            foreach (var ability in TypeMaps.AbilityNames.Keys)
            {
                if (obj.spellcasting.spellcasting_ability.name == TypeMaps.AbilityNames[ability])
                {
                    SpellcastingAbility = ability;
                    break;
                }
            }
        }

        //
        //  Copy Constructor
        //
        public Class(Class c) : base(c)
        {
            HitDie = c.HitDie;
            ProficiencyChoiceCount = c.ProficiencyChoiceCount;
            SpellcastingAbility = c.SpellcastingAbility;

            SkillProficiencyOptions = new List<Skill>();
            foreach (var skill in c.SkillProficiencyOptions)
                SkillProficiencyOptions.Add(skill);

            SavingThrows = new List<Ability>();
            foreach (var ability in c.SavingThrows)
                SavingThrows.Add(ability);

            ArmourProficiencies = new List<ArmourType>();
            foreach (var armour in c.ArmourProficiencies)
                ArmourProficiencies.Add(armour);

            WeaponProficiencies = new List<WeaponType>();
            foreach (var weapon in c.WeaponProficiencies)
                WeaponProficiencies.Add(weapon);

            ToolProficiencies = new List<ToolOrKit>();
            foreach (var tool in c.ToolProficiencies)
                ToolProficiencies.Add(tool);

            SpellList = new List<string>();
            foreach (var spell in c.SpellList)
                SpellList.Add(spell);
        }

        #endregion // CONSTRUCTORS


        //
        //  PopulateProficiencies
        //
        private void PopulateProficiencies(APIClass obj)
        {
            foreach (var item in obj.proficiencies)
            {
                bool found = false;
                var name = item.name.ToLower();

                ArmourType armour = TypeMaps.GetValueFromName(name, TypeMaps.ArmourCategoryNames);
                if (armour != default)
                {
                    ArmourProficiencies.Add(armour);
                    found = true;
                }

                if (!found)
                {
                    WeaponType weapon = TypeMaps.GetValueFromName(name, TypeMaps.WeaponCategoryNames);
                    if (armour != default)
                    {
                        WeaponProficiencies.Add(weapon);
                        found = true;
                    }
                }

                if (!found)
                {
                    ToolOrKit tool = TypeMaps.GetValueFromName(name, TypeMaps.ToolNames);
                    if (tool != default)
                        ToolProficiencies.Add(tool);
                }
            }
        }

        //
        //  PopulateSpellList
        //
        private int PopulateSpellList(APIClass obj)
        {
            int errors = 0;

            var spellListStr = APIReadWrite.GetJsonStringFromFile(APIReadWrite.RootPath + obj.spells);

            try
            {
                var apiSpellList = spellListStr != null ? JsonSerializer.Deserialize<APIReferenceList>(spellListStr) : null;
                if (apiSpellList != null)
                {
                    for (int i = 0; i < apiSpellList.count; i++)
                    {
                        var spellDataStr = APIReadWrite.GetJsonStringFromFile(APIReadWrite.RootPath + apiSpellList.results[i].url);

                        try
                        {
                            var spellData = spellDataStr != null ? JsonSerializer.Deserialize<APISpell>(spellDataStr) : null;
                            if (spellData != null)
                                SpellList.Add(spellData.name);
                        }
                        catch (Exception)
                        {
                            errors++;
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
        //  ToAPIObject
        //
        public override APIClass ToAPIObject()
        {
            APIClass obj = new APIClass(Name);

            obj.hit_die = HitDie;

            var skillChoice = new APIChoice();

            skillChoice.from.option_set_type = "options_array";
            skillChoice.from.options = new APIChoice.APIOptionSet.APIOption[SkillProficiencyOptions.Count];

            var skillChoiceDesc = string.Format("Choose {0} from ", ProficiencyChoiceCount);
            for (int i = 0; i < SkillProficiencyOptions.Count; i++)
            {
                var skillName = TypeMaps.SkillNames[SkillProficiencyOptions[i]];

                skillChoiceDesc += skillName;
                if (i < SkillProficiencyOptions.Count - 1)
                    skillChoiceDesc += ", ";

                var apiOption = new APIChoice.APIOptionSet.APIOption();
                apiOption.option_type = "reference";
                apiOption.item = new APIReference();
                apiOption.item.name = "Skill: " + skillName;
                apiOption.item.index = string.Format("skill-{0}", skillName.ToLower()).Replace(' ', '-');
                apiOption.item.url = "/api/proficiencies/" + apiOption.item.index;

                skillChoice.from.options[i] = apiOption;
            }

            skillChoice.desc = skillChoiceDesc;
            skillChoice.choose = ProficiencyChoiceCount;
            skillChoice.type = "proficiencies";

            obj.proficiency_choices = new APIChoice[1];
            obj.proficiency_choices[0] = skillChoice;

            var profList = new List<APIReference>();
            var profURL = "/api/proficiencies/";

            var saveList = new List<APIReference>();
            var abilityURL = "/api/ability-scores/";

            foreach (var armour in ArmourProficiencies)
            {
                if (armour != ArmourType.None)
                    profList.Add(new APIReference(TypeMaps.ArmourCategoryNames[armour], profURL));
            }

            foreach (var weapon in WeaponProficiencies)
            {
                if (weapon != WeaponType.None)
                    profList.Add(new APIReference(TypeMaps.WeaponCategoryNames[weapon], profURL));
            }

            foreach (var ability in SavingThrows)
            {
                var saveObj = new APIReference();
                saveObj.name = "Saving Throw: " + TypeMaps.AbilityNames[ability];
                saveObj.index = "saving-throw-" + TypeMaps.AbilityNames[ability].ToLower();
                saveObj.url = profURL + saveObj.index;

                profList.Add(saveObj);

                saveList.Add(new APIReference(TypeMaps.AbilityNames[ability], abilityURL));
            }

            foreach (var tool in ToolProficiencies)
            {
                if (tool != ToolOrKit.None)
                    profList.Add(new APIReference(TypeMaps.ToolNames[tool], profURL));
            }

            obj.proficiencies = profList.ToArray();
            obj.saving_throws = saveList.ToArray();

            obj.spells = obj.url + "/spells";

            if (SpellcastingAbility != Ability.None)
                obj.spellcasting.spellcasting_ability = new APIReference(TypeMaps.AbilityNames[SpellcastingAbility], abilityURL);

            return obj;
        }
    }
}
