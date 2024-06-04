using DND.API;

namespace DND
{
    /**********************
        DNDReference
    **********************/
    public abstract class DNDReference
    {
        // Properties
        public string Name  { get; private set; }
        public string Index { get; private set; }
        public string URL   { get; private set; }


        //
        //  Constructor
        //
        public DNDReference()
        {
            Name = string.Empty;
            Index = string.Empty;
            URL = string.Empty;
        }

        //
        //  Constructor
        //
        public DNDReference(string name, string parentPath)
        {
            Name = name;
            Index = APIReadWrite.NameToIndex(name);

            if (!parentPath.StartsWith("/"))
                parentPath = "/" + parentPath;
            if (!parentPath.EndsWith("/"))
                parentPath += "/";

            URL = parentPath + Index;
        }

        //
        //  Constructor
        //
        public DNDReference(APIReference obj)
        {
            Name = obj.name;
            Index = obj.index;
            URL = obj.url;
        }

        //
        //  Copy Constructor
        //
        public DNDReference(DNDReference obj)
        {
            Name = obj.Name;
            Index = obj.Index;
            URL = obj.URL;
        }


        //
        //  RemoveURL
        //
        protected void RemoveURL()
        {
            URL = string.Empty;
        }


        //
        //  ToAPIObject
        //
        public abstract APIReference ToAPIObject();

        //
        //  == operator
        //
        public static bool operator ==(DNDReference? a, DNDReference? b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);

            return a.Equals(b);
        }

        //
        //  != operator
        //
        public static bool operator !=(DNDReference? a, DNDReference? b)
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

            if (obj is not DNDReference)
                return false;

            var other = obj as DNDReference;
            return this.Index == other.Index;
        }

        //
        //  GetHashCode
        //
        public override int GetHashCode()
        {
            return Index.GetHashCode();
        }
    }


    /****************************

        Namespace: Types

    ****************************/
    namespace Types
    {
        public enum Skill
        {
            None,
            Acrobatics, AnimalHandling, Arcana,
            Athletics, Deception, History,
            Insight, Intimidation, Investigation,
            Medicine, Nature, Perception,
            Performance, Persuasion, Religion,
            SleightOfHand, Stealth, Survival
        }

        public enum Ability
        {
            None,
            Strength, Dexterity, Constitution,
            Intelligence, Wisdom, Charisma
        }

        public enum EquipmentCategory
        {
            None,
            Armour, Gear, MountOrVehicle,
            Potion, Ring, Rod,
            Scroll, Staff, Tool,
            Wand, Weapon, Wondrous
        }

        public enum ToolCategory
        {
            None,
            Artisan, Gaming, Instrument,
            Other
        }

        public enum GearCategory
        {
            None,
            Ammunition, ArcaneFoci, DruidicFoci,
            EquipmentPack, HolySymbol, Kit,
            Standard
        }

        public enum ToolOrKit
        {
            None,
            Alchemist, Artisan, Brewer,
            Calligrapher, Carpenter, Cartographer,
            Cobbler, Cook, Disguise,
            Forgery, Glassblower, Herbalist,
            Jeweler, Leatherworker, Mason,
            Navigator, Painter, Poisoner,
            Potter, Smith, Thief,
            Tinker, Weaver, Woodcarver
        }

        public enum Language
        {
            None,
            Abyssal, Celestial, Common,
            DeepSpeech, Draconic, Dwarvish,
            Elvish, Giant, Gnomish,
            Goblin, Halfing, Infernal,
            Orc, Primordial, Sylvan,
            Undercommon
        }

        public enum ArmourType
        {
            None,
            All, Breastplate, ChainMail,
            ChainShirt, HalfPlate, HeavyArmour,
            Hide, Leather, LightArmour,
            MediumArmour, Padded, Plate,
            RingMail, ScaleMail, Shield,
            Splint, StuddedLeather
        }

        public enum WeaponType
        {
            None,
            SimpleWeapons, MartialWeapons,
            Battleaxe, Blowgun, Club,
            CrossbowHeavy, CrossbowLight, Dagger,
            Darts, Flail, Glaive, Greataxe,
            Greatclub, Greatsword, Halberd,
            HandCrossbow, Handaxe, Javelin, Lance,
            LightHammer, Longbow, Longsword,
            Mace, Maul, Morningstar,
            Net, Pike, Quarterstaff,
            Rapier, Scimitar, Shortbow,
            Shortsword, Sickle, Sling,
            Spear, Trident, WarPick,
            Warhammer, Whip
        }

        public enum WeaponProperty
        {
            None,
            Ammunition, Finesse, Heavy,
            Light, Loading, Monk,
            Range, Reach, Special,
            Thrown, TwoHanded, Versatile
        }

        public enum Vehicle
        {
            None,
            Land, Water
        }

        public enum Instrument
        {
            None,
            Bagpipes, Drum, Flute,
            Horn, Lute, Lyre,
            PanFLute, Shawm, Viol
        }

        /**********************
            TypeMaps
        **********************/
        public static class TypeMaps
        {
            public static readonly
                Dictionary<Skill, Ability> SkillAbilities = new Dictionary<Skill, Ability>()
            {
                { Skill.None,           Ability.None },
                { Skill.Acrobatics,     Ability.Dexterity },
                { Skill.AnimalHandling, Ability.Wisdom },
                { Skill.Arcana,         Ability.Intelligence },
                { Skill.Athletics,      Ability.Strength },
                { Skill.Deception,      Ability.Charisma },
                { Skill.History,        Ability.Intelligence },
                { Skill.Insight,        Ability.Wisdom },
                { Skill.Intimidation,   Ability.Charisma },
                { Skill.Investigation,  Ability.Intelligence },
                { Skill.Medicine,       Ability.Wisdom },
                { Skill.Nature,         Ability.Intelligence },
                { Skill.Perception,     Ability.Wisdom },
                { Skill.Performance,    Ability.Charisma },
                { Skill.Persuasion,     Ability.Charisma },
                { Skill.Religion,       Ability.Intelligence },
                { Skill.SleightOfHand,  Ability.Dexterity },
                { Skill.Stealth,        Ability.Dexterity },
                { Skill.Survival,       Ability.Wisdom }
            };

            public static readonly
                Dictionary<Skill, string> SkillNames = new Dictionary<Skill, string>()
            {
                { Skill.None,           string.Empty },
                { Skill.Acrobatics,     "Acrobatics" },
                { Skill.AnimalHandling, "Animal Handling" },
                { Skill.Arcana,         "Arcana" },
                { Skill.Athletics,      "Athletics" },
                { Skill.Deception,      "Deception" },
                { Skill.History,        "History" },
                { Skill.Insight,        "Insight" },
                { Skill.Intimidation,   "Intimidation" },
                { Skill.Investigation,  "Investigation" },
                { Skill.Medicine,       "Medicine" },
                { Skill.Nature,         "Nature" },
                { Skill.Perception,     "Perception" },
                { Skill.Performance,    "Performance" },
                { Skill.Persuasion,     "Persuasion" },
                { Skill.Religion,       "Religion" },
                { Skill.SleightOfHand,  "Sleight of Hand" },
                { Skill.Stealth,        "Stealth" },
                { Skill.Survival,       "Survival" }
            };

            public static readonly
                Dictionary<Ability, string> AbilityNames = new Dictionary<Ability, string>()
            {
                { Ability.None,           string.Empty },
                { Ability.Strength,       "STR" },
                { Ability.Dexterity,      "DEX" },
                { Ability.Constitution,   "CON" },
                { Ability.Intelligence,   "INT" },
                { Ability.Wisdom,         "WIS" },
                { Ability.Charisma,       "CHA" }
            };

            public static readonly
                Dictionary<EquipmentCategory, string> EquipmentCategoryNames = new Dictionary<EquipmentCategory, string>()
            {
                { EquipmentCategory.None,           string.Empty },
                { EquipmentCategory.Armour,         "Armor" },
                { EquipmentCategory.Gear,           "Adventuring Gear" },
                { EquipmentCategory.MountOrVehicle, "Mounts and Vehicles" },
                { EquipmentCategory.Potion,         "Potion" },
                { EquipmentCategory.Ring,           "Ring" },
                { EquipmentCategory.Rod,            "Rod" },
                { EquipmentCategory.Scroll,         "Scroll" },
                { EquipmentCategory.Staff,          "Staff" },
                { EquipmentCategory.Tool,           "Tools" },
                { EquipmentCategory.Wand,           "Wand" },
                { EquipmentCategory.Weapon,         "Weapon" },
                { EquipmentCategory.Wondrous,       "Wondrous Items" }
            };

            public static readonly
                Dictionary<ToolCategory, string> ToolCategoryNames = new Dictionary<ToolCategory, string>()
            {
                { ToolCategory.None,        string.Empty },
                { ToolCategory.Artisan,     "Artisan's Tools" },
                { ToolCategory.Gaming,      "Gaming Sets" },
                { ToolCategory.Instrument,  "Musical Instrument" },
                { ToolCategory.Other,       "Other Tools" }
            };

            public static readonly
                Dictionary<GearCategory, string> GearCategoryNames = new Dictionary<GearCategory, string>()
            {
                { GearCategory.None,            string.Empty },
                { GearCategory.Ammunition,      "Ammunition" },
                { GearCategory.ArcaneFoci,      "Arcane Foci" },
                { GearCategory.DruidicFoci,     "Druidic Foci" },
                { GearCategory.EquipmentPack,   "Equipment Packs" },
                { GearCategory.HolySymbol,      "Holy Symbols" },
                { GearCategory.Kit,             "Kits" },
                { GearCategory.Standard,        "Standard Gear" }
            };

            public static readonly
                Dictionary<ToolOrKit, string> ToolNames = new Dictionary<ToolOrKit, string>()
            {
                { ToolOrKit.None,           string.Empty },
                { ToolOrKit.Alchemist,      "Alchemist's Supplies" },
                { ToolOrKit.Artisan,        "Artisan's Tools" },
                { ToolOrKit.Brewer,         "Brewer's Supplies" },
                { ToolOrKit.Calligrapher,   "Calligrapher's Supplies" },
                { ToolOrKit.Carpenter,      "Carpenter's Tools" },
                { ToolOrKit.Cartographer,   "Cartographer's Tools" },
                { ToolOrKit.Cobbler,        "Cobbler's Tools" },
                { ToolOrKit.Cook,           "Cook's utensils" },
                { ToolOrKit.Disguise,       "Disguise Kit" },
                { ToolOrKit.Forgery,        "Forgery Kit" },
                { ToolOrKit.Glassblower,    "Glassblower's Tools" },
                { ToolOrKit.Herbalist,      "Herbalism Kit" },
                { ToolOrKit.Jeweler,        "Jeweler's Tools" },
                { ToolOrKit.Leatherworker,  "Leatherworker's Tools" },
                { ToolOrKit.Mason,          "Mason's Tools" },
                { ToolOrKit.Navigator,      "Navigator's Tools" },
                { ToolOrKit.Painter,        "Painter's Supplies" },
                { ToolOrKit.Poisoner,       "Poisoner's Kit" },
                { ToolOrKit.Potter,         "Potter's Tools" },
                { ToolOrKit.Smith,          "Smith's Tools" },
                { ToolOrKit.Thief,          "Thieves' Tools" },
                { ToolOrKit.Tinker,         "Tinker's Tools" },
                { ToolOrKit.Weaver,         "Weaver's Tools" },
                { ToolOrKit.Woodcarver,     "Woodcarver's Tools" }
            };

            public static readonly
                Dictionary<Language, string> LanguageNames = new Dictionary<Language, string>()
            {
                { Language.None,        string.Empty },
                { Language.Abyssal,     "Abyssal" },
                { Language.Celestial,   "Celestial" },
                { Language.Common,      "Common" },
                { Language.DeepSpeech,  "Deep Speech" },
                { Language.Draconic,    "Draconic" },
                { Language.Dwarvish,    "Dwarvish" },
                { Language.Elvish,      "Elvish" },
                { Language.Giant,       "Giant" },
                { Language.Gnomish,     "Gnomish" },
                { Language.Goblin,      "Goblin" },
                { Language.Halfing,     "Halfling" },
                { Language.Infernal,    "Infernal" },
                { Language.Orc,         "Orc" },
                { Language.Primordial,  "Primordial" },
                { Language.Sylvan,      "Sylvan" },
                { Language.Undercommon, "Undercommon" }
            };

            public static readonly
                Dictionary<ArmourType, string> ArmourCategoryNames = new Dictionary<ArmourType, string>()
            {
                { ArmourType.None,              string.Empty },
                { ArmourType.Breastplate,       "Breastplate" },
                { ArmourType.ChainMail,         "Chain Mail" },
                { ArmourType.ChainShirt,        "Chain Shirt" },
                { ArmourType.HalfPlate,         "Half Plate Armor" },
                { ArmourType.HeavyArmour,       "Heavy Armor" },
                { ArmourType.Hide,              "Hide Armor" },
                { ArmourType.Leather,           "Leather Armor" },
                { ArmourType.LightArmour,       "Light Armor" },
                { ArmourType.MediumArmour,      "Medium Armor" },
                { ArmourType.Padded,            "Padded Armor" },
                { ArmourType.Plate,             "Plate Armor" },
                { ArmourType.RingMail,          "Ring Mail" },
                { ArmourType.ScaleMail,         "Scale Mail" },
                { ArmourType.Shield,            "Shields" },
                { ArmourType.Splint,            "Splint Armor" },
                { ArmourType.StuddedLeather,    "Studded Leather Armor" }
            };

            public static readonly
                Dictionary<WeaponType, string> WeaponCategoryNames = new Dictionary<WeaponType, string>()
            {
                { WeaponType.None,              string.Empty },
                { WeaponType.SimpleWeapons,     "Simple Weapons" },
                { WeaponType.MartialWeapons,    "Martial Weapons" },
                { WeaponType.Battleaxe,         "Battleaxes" },
                { WeaponType.Blowgun,           "Blowguns" },
                { WeaponType.Club,              "Clubs" },
                { WeaponType.CrossbowHeavy,     "Crossbows, heavy" },
                { WeaponType.CrossbowLight,     "Crossbows, light" },
                { WeaponType.Dagger,            "Daggers" },
                { WeaponType.Darts,             "Darts" },
                { WeaponType.Flail,             "Flails" },
                { WeaponType.Glaive,            "Glaives" },
                { WeaponType.Greataxe,          "Greataxes" },
                { WeaponType.Greatclub,         "Greatclubs" },
                { WeaponType.Greatsword,        "Greatswords" },
                { WeaponType.Halberd,           "Halberds" },
                { WeaponType.HandCrossbow,      "Hand crossbows" },
                { WeaponType.Handaxe,           "Handaxes" },
                { WeaponType.Javelin,           "Javelins" },
                { WeaponType.Lance,             "Lances" },
                { WeaponType.LightHammer,       "Light hammers" },
                { WeaponType.Longbow,           "Longbows" },
                { WeaponType.Longsword,         "Longswords" },
                { WeaponType.Mace,              "Maces" },
                { WeaponType.Maul,              "Mauls" },
                { WeaponType.Morningstar,       "Nets" },
                { WeaponType.Net,               "Morningstars" },
                { WeaponType.Pike,              "Pikes" },
                { WeaponType.Quarterstaff,      "Quarterstaffs" },
                { WeaponType.Rapier,            "Rapiers" },
                { WeaponType.Scimitar,          "Scimitars" },
                { WeaponType.Shortbow,          "Shortbows" },
                { WeaponType.Shortsword,        "Shortswords" },
                { WeaponType.Sickle,            "Sickles" },
                { WeaponType.Sling,             "Slings" },
                { WeaponType.Spear,             "Spears" },
                { WeaponType.Trident,           "Tridents" },
                { WeaponType.WarPick,           "War picks" },
                { WeaponType.Warhammer,         "Warhammer" },
                { WeaponType.Whip,              "Whips" }
            };

            public static readonly
                Dictionary<WeaponType, string> WeaponNames = new Dictionary<WeaponType, string>()
            {
                { WeaponType.None,              string.Empty },
                { WeaponType.SimpleWeapons,     string.Empty },
                { WeaponType.MartialWeapons,    string.Empty },
                { WeaponType.Battleaxe,         "Battleaxe" },
                { WeaponType.Blowgun,           "Blowgun" },
                { WeaponType.Club,              "Club" },
                { WeaponType.CrossbowHeavy,     "Crossbow, heavy" },
                { WeaponType.CrossbowLight,     "Crossbow, light" },
                { WeaponType.Dagger,            "Dagger" },
                { WeaponType.Darts,             "Dart" },
                { WeaponType.Flail,             "Flail" },
                { WeaponType.Glaive,            "Glaive" },
                { WeaponType.Greataxe,          "Greataxe" },
                { WeaponType.Greatclub,         "Greatclub" },
                { WeaponType.Greatsword,        "Greatsword" },
                { WeaponType.Halberd,           "Halberd" },
                { WeaponType.HandCrossbow,      "Crossbow, hand" },
                { WeaponType.Handaxe,           "Handaxe" },
                { WeaponType.Javelin,           "Javelin" },
                { WeaponType.Lance,             "Lance" },
                { WeaponType.LightHammer,       "Light hammer" },
                { WeaponType.Longbow,           "Longbow" },
                { WeaponType.Longsword,         "Longsword" },
                { WeaponType.Mace,              "Mace" },
                { WeaponType.Maul,              "Maul" },
                { WeaponType.Morningstar,       "Net" },
                { WeaponType.Net,               "Morningstar" },
                { WeaponType.Pike,              "Pike" },
                { WeaponType.Quarterstaff,      "Quarterstaff" },
                { WeaponType.Rapier,            "Rapier" },
                { WeaponType.Scimitar,          "Scimitar" },
                { WeaponType.Shortbow,          "Shortbow" },
                { WeaponType.Shortsword,        "Shortsword" },
                { WeaponType.Sickle,            "Sickle" },
                { WeaponType.Sling,             "Sling" },
                { WeaponType.Spear,             "Spear" },
                { WeaponType.Trident,           "Trident" },
                { WeaponType.WarPick,           "War pick" },
                { WeaponType.Warhammer,         "Warhammer" },
                { WeaponType.Whip,              "Whip" }
            };

            public static readonly
                Dictionary<WeaponProperty, string> WeaponPropertyNames = new Dictionary<WeaponProperty, string>()
            {
                { WeaponProperty.None,          string.Empty },
                { WeaponProperty.Ammunition,    "Ammunition" },
                { WeaponProperty.Finesse,       "Finesse" },
                { WeaponProperty.Heavy,         "Heavy" },
                { WeaponProperty.Light,         "Light" },
                { WeaponProperty.Loading,       "Loading" },
                { WeaponProperty.Monk,          "Monk" },
                { WeaponProperty.Range,         "Range" },
                { WeaponProperty.Reach,         "Reach" },
                { WeaponProperty.Special,       "Special" },
                { WeaponProperty.Thrown,        "Thrown" },
                { WeaponProperty.TwoHanded,     "Two-Handed" },
                { WeaponProperty.Versatile,     "Versatile" }
            };

            public static readonly
                Dictionary<Vehicle, string> VehicleNames = new Dictionary<Vehicle, string>()
            {
                { Vehicle.None,     string.Empty },
                { Vehicle.Land,     "Land Vehicles" },
                { Vehicle.Water,    "Waterborne Vehicles" }
            };

            public static readonly
                Dictionary<Instrument, string> InstrumentNames = new Dictionary<Instrument, string>()
            {
                { Instrument.None,      string.Empty },
                { Instrument.Bagpipes,  "Bagpipes" },
                { Instrument.Drum,      "Drum" },
                { Instrument.Flute,     "Flute" },
                { Instrument.Horn,      "Horn" },
                { Instrument.Lute,      "Lute" },
                { Instrument.Lyre,      "Lyre" },
                { Instrument.PanFLute,  "Pan flute" },
                { Instrument.Shawm,     "Shawm" },
                { Instrument.Viol,      "Viol" }
            };


            //
            //  GetValueFromName
            //
            public static T GetValueFromName<T>(string name, Dictionary<T, string> typeMap)
                where T : struct, Enum
            {
                name = APIReadWrite.NameToIndex(name);
                foreach (var key in typeMap.Keys)
                {
                    if (APIReadWrite.NameToIndex(typeMap[key]) == name)
                        return key;
                }

                // Check either plural or non-plural
                if (name.EndsWith('s'))
                    name = name.Remove(name.Length - 1);
                else
                    name += "s";

                foreach (var key in typeMap.Keys)
                {
                    if (APIReadWrite.NameToIndex(typeMap[key]) == name)
                        return key;
                }

                return default;
            }
        }
    }
}
