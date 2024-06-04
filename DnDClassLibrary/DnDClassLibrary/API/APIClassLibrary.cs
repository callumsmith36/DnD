namespace DND.API
{
    /********************************
        APIReference
    ********************************/
    public class APIReference
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }

        // Constructor
        public APIReference()
        {
            index = string.Empty;
            name = string.Empty;
            url = string.Empty;
        }

        // Constructor
        public APIReference(string index, string name, string url)
        {
            this.index = index;
            this.name = name;
            this.url = url;
        }

        // Constructor
        public APIReference(string inputName, string parentPath)
        {
            name = inputName;
            index = APIReadWrite.NameToIndex(name);

            if (!parentPath.StartsWith("/"))
                parentPath = "/" + parentPath;
            if (!parentPath.EndsWith("/"))
                parentPath += "/";

            url = parentPath + index;
        }
    }

    /********************************
        APIReferenceList
    ********************************/
    public class APIReferenceList
    {
        public int count { get; set; }
        public APIReference[] results { get; set; }

        // Constructor
        public APIReferenceList()
        {
            count = 0;
            results = Array.Empty<APIReference>();
        }
    }

    /********************************
        APIArmour
    ********************************/
    public class APIArmour : APIEquipment
    {
        public string armor_category { get; set; }
        public APIArmourClass armor_class { get; set; }
        public int str_minimum { get; set; }
        public bool stealth_disadvantage { get; set; }

        // Constructor
        public APIArmour() : base()
        {
            armor_category = string.Empty;
            armor_class = new APIArmourClass();
            str_minimum = 0;
            stealth_disadvantage = false;
        }

        // Constructor
        public APIArmour(
            string name, string category, int baseAC,
            bool dexBonus, int maxBonus, int minStr,
            bool disadvantage, float weight, int value,
            string unit, string[] desc
        )
            : base(name, "Armor", weight, value, unit, desc)
        {
            armor_category = category;
            armor_class = new APIArmourClass(baseAC, dexBonus, maxBonus);
            str_minimum = minStr;
            stealth_disadvantage = disadvantage;
        }

        /********************************
            APIArmourClass
        ********************************/
        public class APIArmourClass
        {
            public int @base { get; set; }
            public bool dex_bonus { get; set; }
            public int max_bonus { get; set; }

            // Constructor
            public APIArmourClass()
            {
                @base = 0;
                dex_bonus = false;
                max_bonus = 0;
            }

            // Constructor
            public APIArmourClass(int baseAC, bool dexBonus, int maxBonus)
            {
                @base = baseAC;
                dex_bonus = dexBonus;
                max_bonus = maxBonus;
            }
        }
    }

    /********************************
        APIAttack
    ********************************/
    public class APIAttack
    {
        public string name { get; set; }
        public string index { get; set; }
        public int type { get; set; }
        public bool spell_attack { get; set; }
        public int bonus_ability { get; set; }
        public int weapon_bonus { get; set; }
        public bool proficiency { get; set; }
        public string damage_dice { get; set; }
        public int damage_ability { get; set; }
        public int damage_bonus { get; set; }

        // Constructor
        public APIAttack()
        {
            name = string.Empty;
            index = string.Empty;
            type = 0;
            spell_attack = false;
            bonus_ability = 0;
            weapon_bonus = 0;
            proficiency = false;
            damage_dice = string.Empty;
            damage_ability = 0;
            damage_bonus = 0;
        }

        // Constructor
        public APIAttack(string name, string index, int type,
            bool spell, int ability, int weapon,
            bool proficient, string dmgDice, int dmgAbility,
            int dmgBonus)
        {
            this.name = name;
            this.index = index;
            this.type = type;
            spell_attack = spell;
            bonus_ability = ability;
            weapon_bonus = weapon;
            proficiency = proficient;
            damage_dice = dmgDice;
            damage_ability = dmgAbility;
            damage_bonus = dmgBonus;
        }
    }

    /********************************
        APIChoice
    ********************************/
    public class APIChoice
    {
        public string desc { get; set; }
        public string type { get; set; }
        public int choose { get; set; }
        public APIOptionSet from { get; set; }

        // Constructor
        public APIChoice()
        {
            desc = string.Empty;
            type = string.Empty;
            choose = 0;
            from = new APIOptionSet();
        }

        /********************************
            APIOptionSet
        ********************************/
        public class APIOptionSet
        {
            public string option_set_type { get; set; }
            public APIOption[] options { get; set; }

            // Constructor
            public APIOptionSet()
            {
                option_set_type = string.Empty;
                options = Array.Empty<APIOption>();
            }

            /********************************
                APIOption
            ********************************/
            public class APIOption
            {
                public string option_type { get; set; }
                public APIReference item { get; set; }

                // Constructor
                public APIOption()
                {
                    option_type = string.Empty;
                    item = new APIReference();
                }
            }
        }
    }

    /********************************
        APIClass
    ********************************/
    public class APIClass : APIReference
    {
        public int hit_die { get; set; }
        public APIReference[] proficiencies { get; set; }
        public APIReference[] saving_throws { get; set; }
        public APIChoice[] proficiency_choices { get; set; }
        public string spells { get; set; }
        public APISpellcasting spellcasting { get; set; }

        // Constructor
        public APIClass() : base()
        {
            Initialise();
        }

        // Constructor
        public APIClass(string name) : base(name, "/custom/classes")
        {
            Initialise();
        }

        // Initialise
        private void Initialise()
        {
            hit_die = 0;
            proficiencies = Array.Empty<APIReference>();
            saving_throws = Array.Empty<APIReference>();
            proficiency_choices = Array.Empty<APIChoice>();
            spells = string.Empty;
            spellcasting = new APISpellcasting();
        }

        /********************************
            APISpellcasting
        ********************************/
        public class APISpellcasting
        {
            public int level { get; set; }
            public APIReference spellcasting_ability { get; set; }
            public APISpellcastingInfo[] info { get; set; }

            // Constructor
            public APISpellcasting()
            {
                level = 0;
                spellcasting_ability = new APIReference();
                info = Array.Empty<APISpellcastingInfo>();
            }

            /********************************
                APISpellcastingInfo
            ********************************/
            public class APISpellcastingInfo
            {
                public string name { get; set; }
                public string[] desc { get; set; }

                // Constructor
                public APISpellcastingInfo()
                {
                    name = string.Empty;
                    desc = Array.Empty<string>();
                }
            }
        }
    }

    /********************************
        APIContainer
    ********************************/
    public class APIContainer : APIItemCollection
    {
        public string name { get; set; }
        public string index { get; set; }
        public string[] desc { get; set; }
        public APIReference base_item { get; set; }

        // Constructor
        public APIContainer() : base()
        {
            name = string.Empty;
            index = string.Empty;
            desc = Array.Empty<string>();
            base_item = new APIReference();
        }

        // Constructor
        public APIContainer(string name, string[] desc, int cp, int sp, int gp, int pp, APIReference? item = null)
            : base(cp, sp, gp, pp)
        {
            this.name = name;
            index = APIReadWrite.NameToIndex(name);

            this.desc = new string[desc.Length];
            for (int i = 0; i < desc.Length; i++)
                this.desc[i] = desc[i];

            base_item = item != null ? item : new APIReference();
        }
    }

    /********************************
        APIDamage
    ********************************/
    public class APIDamage
    {
        public string damage_dice { get; set; }
        public APIReference damage_type { get; set; }

        // Constructor
        public APIDamage()
        {
            damage_dice = string.Empty;
            damage_type = new APIReference();
        }

        // Constructor
        public APIDamage(string dice, string type)
        {
            damage_dice = dice;
            damage_type = new APIReference(type, "/api/damage-types");
        }
    }

    /********************************
        APIEquipment
    ********************************/
    public class APIEquipment : APIReference
    {
        public APIReference equipment_category { get; set; }
        public float weight { get; set; }
        public APIQuantity cost { get; set; }
        public string[] desc { get; set; }

        // Constructor
        public APIEquipment() : base()
        {
            equipment_category = new APIReference();
            weight = 0;
            cost = new APIQuantity();
            desc = Array.Empty<string>();
        }

        // Constructor
        public APIEquipment(string name, string category, float weight, int value, string unit, string[] desc)
            : base(name, "/custom/equipment")
        {
            equipment_category = new APIReference(category, "/api/equipment-categories");
            this.weight = weight;
            cost = new APIQuantity(value, unit);

            this.desc = new string[desc.Length];
            for (int i = 0; i < desc.Length; i++)
                this.desc[i] = desc[i];
        }
    }

    /********************************
        APIEquipmentCategory
    ********************************/
    public class APIEquipmentCategory : APIReference
    {
        public APIReference[] equipment { get; set; }

        // Constructor
        public APIEquipmentCategory() : base()
        {
            equipment = Array.Empty<APIReference>();
        }
    }

    /********************************
        APIEquipmentPack
    ********************************/
    public class APIEquipmentPack : APIGear
    {
        public APIItem[] contents { get; set; }

        // Constructor
        public APIEquipmentPack() : base()
        {
            contents = Array.Empty<APIItem>();
        }

        // Constructor
        public APIEquipmentPack(string name, int value, string unit, string[] desc)
            : base(name, "Equipment Packs", 0, value, unit, desc)
        {
            contents = Array.Empty<APIItem>();
        }
    }

    /********************************
        APIFeat
    ********************************/
    public class APIFeat
    {
        public string name { get; set; }
        public string index { get; set; }
        public string[] desc { get; set; }
        public bool limited { get; set; }
        public string source { get; set; }
        public string source_name { get; set; }
        public string frequency { get; set; }
        public int max_uses { get; set; }
        public int uses_left { get; set; }

        // Constructor
        public APIFeat()
        {
            name = string.Empty;
            index = string.Empty;
            desc = Array.Empty<string>();
            limited = false;
            source = string.Empty;
            source_name = string.Empty;
            frequency = string.Empty;
            max_uses = 0;
            uses_left = 0;
        }

        // Constructor
        public APIFeat(
            string name, string index, string[] desc,
            bool limited, string source, string source_name,
            string freq, int max, int remaining)
        {
            this.name = name;
            this.index = index;

            this.desc = new string[desc.Length];
            for (int i = 0; i < desc.Length; i++)
                this.desc[i] = desc[i];

            this.limited = limited;
            this.source = source;
            this.source_name = source_name;
            frequency = freq;
            max_uses = max;
            uses_left = remaining;
        }
    }

    /********************************
        APIGear
    ********************************/
    public class APIGear : APIEquipment
    {
        public APIReference gear_category { get; set; }
        public int quantity { get; set; }

        // Constructor
        public APIGear() : base()
        {
            gear_category = new APIReference();
            quantity = 1;
        }

        // Constructor
        public APIGear(
            string name, string category, float weight,
            int value, string unit, string[] desc,
            int qty = 1
        )
            : base(name, "Adventuring Gear", weight, value, unit, desc)
        {
            gear_category = new APIReference(category, "/api/equipment-categories");
            quantity = qty;
        }
    }

    /********************************
        APIInventory
    ********************************/
    public class APIInventory : APIItemCollection
    {
        public APIContainer[] containers { get; set; }

        // Constructor
        public APIInventory() : base()
        {
            containers = Array.Empty<APIContainer>();
        }

        // Constructor
        public APIInventory(int cp, int sp, int gp, int pp)
            : base(cp, sp, gp, pp)
        {
            containers = Array.Empty<APIContainer>();
        }
    }

    /********************************
        APIItem
    ********************************/
    public class APIItem
    {
        public APIReference item { get; set; }
        public int quantity { get; set; }
        public string[] desc { get; set; }

        // Constructor
        public APIItem()
        {
            item = new APIReference();
            quantity = 0;
            desc = Array.Empty<string>();
        }

        // Constructor
        public APIItem(string index, string name, string url, int quantity, string[]? desc = null)
        {
            item = new APIReference(index, name, url);
            this.quantity = quantity;

            if (desc != null && desc.Length > 0)
            {
                this.desc = new string[desc.Length];
                for (int i = 0; i < desc.Length; i++)
                    this.desc[i] = desc[i];
            }
            else
            {
                this.desc = Array.Empty<string>();
            }
        }
    }

    /********************************
        APIItemCollection
    ********************************/
    public class APIItemCollection
    {
        public int[] money { get; set; }
        public APIItem[] general { get; set; }
        public APIItem[] weapons { get; set; }
        public APIItem[] armour { get; set; }
        public APIItem[] tools { get; set; }
        public APIItem[] potions { get; set; }
        public APIItem[] magic_items { get; set; }

        // Constructor
        public APIItemCollection()
        {
            money = [0, 0, 0, 0];
            weapons = Array.Empty<APIItem>();
            armour = Array.Empty<APIItem>();
            potions = Array.Empty<APIItem>();
            magic_items = Array.Empty<APIItem>();
            tools = Array.Empty<APIItem>();
            general = Array.Empty<APIItem>();
        }

        // Constructor
        public APIItemCollection(int cp, int sp, int gp, int pp)
            : this()
        {
            money = [cp, sp, gp, pp];
        }
    }

    /********************************
        APIMagicItem
    ********************************/
    public class APIMagicItem : APIReference
    {
        public APIReference equipment_category { get; set; }
        public APIRarity rarity { get; set; }
        public APIReference[] variants { get; set; }
        public bool variant { get; set; }
        public bool attunement { get; set; }
        public string[] desc { get; set; }

        // Constructor
        public APIMagicItem() : base()
        {
            equipment_category = new APIReference();
            rarity = new APIRarity();
            variants = Array.Empty<APIReference>();
            variant = false;
            attunement = false;
            desc = Array.Empty<string>();
        }

        // Constructor
        public APIMagicItem(
            string name, string category, string rarity,
            bool attunement, string[] desc, bool variant = false,
            string[]? variants = null
        )
            : base(name, "/custom/magic-items")
        {
            equipment_category = new APIReference(category, "/api/equipment-categories");
            this.rarity = new APIRarity(rarity);
            this.attunement = attunement;

            this.desc = new string[desc.Length];
            for (int i = 0; i < desc.Length; i++)
                this.desc[i] = desc[i];

            this.variant = variant;

            if (variants != null)
            {
                this.variants = new APIReference[variants.Length];
                for (int i = 0; i < variants.Length; i++)
                    this.variants[i] = new APIReference(variants[i], "/custom/magic-items");
            }
            else
            {
                this.variants = Array.Empty<APIReference>();
            }
        }

        /********************************
            APIRarity
        ********************************/
        public class APIRarity
        {
            public string name { get; set; }

            // Constructor
            public APIRarity()
            {
                name = string.Empty;
            }

            // Constructor
            public APIRarity(string name)
            {
                this.name = name;
            }
        }
    }

    /********************************
        APIQuantity
    ********************************/
    public class APIQuantity
    {
        public int quantity { get; set; }
        public string unit { get; set; }

        // Constructor
        public APIQuantity()
        {
            quantity = 0;
            unit = string.Empty;
        }

        // Constructor
        public APIQuantity(int quantity, string unit)
        {
            this.quantity = quantity;
            this.unit = unit;
        }
    }

    /********************************
        APIRace
    ********************************/
    public class APIRace : APIReference
    {
        public int speed { get; set; }
        public string size { get; set; }
        public AbilityBonusesObject[] ability_bonuses { get; set; }
        public APIReference[] starting_proficiencies { get; set; }
        public APIReference[] languages { get; set; }
        public APIReference[] traits { get; set; }
        public APIReference[] subraces { get; set; }
        public APIChoice starting_proficiency_options { get; set; }

        // Constructor
        public APIRace() : base()
        {
            Initialise();
        }

        // Constructor
        public APIRace(string name) : base(name, "/custom/races")
        {
            Initialise();
        }

        // Initialise
        private void Initialise()
        {
            speed = 0;
            size = string.Empty;
            ability_bonuses = Array.Empty<AbilityBonusesObject>();
            starting_proficiencies = Array.Empty<APIReference>();
            languages = Array.Empty<APIReference>();
            traits = Array.Empty<APIReference>();
            subraces = Array.Empty<APIReference>();
            starting_proficiency_options = new APIChoice();
        }

        /********************************
            AbilityBonusesObject
        ********************************/
        public class AbilityBonusesObject
        {
            public int bonus { get; set; }
            public APIReference ability_score { get; set; }

            // Constructor
            public AbilityBonusesObject()
            {
                bonus = 0;
                ability_score = new APIReference();
            }
        }
    }

    /********************************
        APISpell
    ********************************/
    public class APISpell : APIReference
    {
        public int level { get; set; }
        public string range { get; set; }
        public string material { get; set; }
        public string duration { get; set; }
        public string casting_time { get; set; }
        public string[] desc { get; set; }
        public string[] higher_level { get; set; }
        public string[] components { get; set; }
        public bool ritual { get; set; }
        public bool concentration { get; set; }
        public APIReference school { get; set; }
        public APIReference[] classes { get; set; }
        public APIReference[] subclasses { get; set; }

        // Constructor
        public APISpell() : base()
        {
            Initialise();
        }

        // Constructor
        public APISpell(string name) : base(name, "/custom/spells")
        {
            Initialise();
        }

        // Initialise
        private void Initialise()
        {
            level = 0;
            range = string.Empty;
            material = string.Empty;
            duration = string.Empty;
            casting_time = string.Empty;
            desc = Array.Empty<string>();
            higher_level = Array.Empty<string>();
            components = Array.Empty<string>();
            ritual = false;
            concentration = false;
            school = new APIReference();
            classes = Array.Empty<APIReference>();
            subclasses = Array.Empty<APIReference>();
        }
    }

    /********************************
        APISpellList
    ********************************/
    public class APISpellList
    {
        public int count { get; set; }
        public APISpellReference[] results { get; set; }

        // Constructor
        public APISpellList()
        {
            count = 0;
            results = Array.Empty<APISpellReference>();
        }
    }

    /********************************
        APISpellReference
    ********************************/
    public class APISpellReference : APIReference
    {
        public int level { get; set; }

        // Constructor
        public APISpellReference() : base()
        {
            level = 0;
        }

        // Constructor
        public APISpellReference(string index, string name, string url, int lvl)
            : base(index, name, url)
        {
            level = lvl;
        }
    }

    /********************************
        APITool
    ********************************/
    public class APITool : APIEquipment
    {
        public string tool_category { get; set; }

        // Constructor
        public APITool() : base()
        {
            tool_category = string.Empty;
        }

        // Constructor
        public APITool(string name, string category, float weight, int value, string unit, string[] desc)
            : base(name, "Tools", weight, value, unit, desc)
        {
            tool_category = category;
        }
    }

    /********************************
        APIWeapon
    ********************************/
    public class APIWeapon : APIEquipment
    {
        public string weapon_category { get; set; }
        public string weapon_range { get; set; }
        public string category_range { get; set; }
        public APIDamage damage { get; set; }
        public APIDamage two_handed_damage { get; set; }
        public APIRange range { get; set; }
        public APIRange throw_range { get; set; }
        public string[] special { get; set; }
        public APIReference[] properties { get; set; }

        // Constructor
        public APIWeapon() : base()
        {
            weapon_category = string.Empty;
            weapon_range = string.Empty;
            category_range = string.Empty;
            damage = new APIDamage();
            two_handed_damage = new APIDamage();
            range = new APIRange();
            throw_range = new APIRange();
            special = Array.Empty<string>();
            properties = Array.Empty<APIReference>();
        }

        // Constructor
        public APIWeapon(
            string name, string category, string range,
            string dice1H, string dice2H, string type,
            int normalRange, int longRange, int normalThrowRange,
            int longThrowRange, float weight, int value,
            string unit, string[] desc, string[]? props = null,
            string[]? special = null
        )
            : base(name, "Weapon", weight, value, unit, desc)
        {
            weapon_category = category;
            weapon_range = range;
            category_range = category + " " + range;
            damage = new APIDamage(dice1H, type);
            two_handed_damage = new APIDamage(dice2H, type);
            this.range = new APIRange(normalRange, longRange);
            throw_range = new APIRange(normalThrowRange, longThrowRange);

            if (props != null && props.Length > 0)
            {
                properties = new APIReference[props.Length];
                for (int i = 0; i < props.Length; i++)
                    properties[i] = new APIReference(props[i], "/api/weapon-properties");
            }
            else
            {
                properties = Array.Empty<APIReference>();
            }

            if (special != null && special.Length > 0)
            {
                this.special = new string[special.Length];
                for (int i = 0; i < special.Length; i++)
                    this.special[i] = special[i];
            }
            else
            {
                this.special = Array.Empty<string>();
            }
        }

        /********************************
            APIRange
        ********************************/
        public class APIRange
        {
            public int normal { get; set; }
            public int @long { get; set; }

            // Constructor
            public APIRange()
            {
                normal = 0;
                @long = 0;
            }

            // Constructor
            public APIRange(int normalRange, int longRange)
            {
                normal = normalRange;
                @long = longRange;
            }
        }
    }

    /********************************
        APIPlayerCharacter
    ********************************/
    public class APIPlayerCharacter
    {
        public string name { get; set; }
        public string race { get; set; }
        public string background { get; set; }
        public string subclass { get; set; }
        public string alignment { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public int max_hp { get; set; }
        public int current_hp { get; set; }
        public int temp_hp { get; set; }
        public int armour_class { get; set; }
        public int initiative { get; set; }
        public int speed { get; set; }
        public int proficiency_bonus { get; set; }
        public bool inspiration { get; set; }
        public int num_classes { get; set; }
        public string[] class_names { get; set; }
        public int[] class_levels { get; set; }
        public int[] hit_dice_remaining { get; set; }
        public int[] max_spell_slots { get; set; }
        public int[] remaining_spell_slots { get; set; }
        public string[] prepared_spells { get; set; }
        public string spell_class { get; set; }
        public string spell_ability { get; set; }
        public string concentration { get; set; }
        public int[] skill_proficiencies { get; set; }
        public int[] skill_expertise { get; set; }
        public int[] tool_proficiencies { get; set; }
        public int[] weapon_proficiencies { get; set; }
        public int[] armour_proficiencies { get; set; }
        public int[] vehicle_proficiencies { get; set; }
        public int[] languages { get; set; }
        public APIFeat[] feats { get; set; }
        public APIAttack[] attacks { get; set; }
        public bool[] death_save_successes { get; set; }
        public bool[] death_save_failures { get; set; }
        public APIInventory inventory { get; set; }
        public string[] equipped { get; set; }
        public string[] attuned { get; set; }
        public string image { get; set; }
        public int age { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string[] backstory { get; set; }
        public string[] allies { get; set; }

        // Constructor
        public APIPlayerCharacter() : base()
        {
            name = string.Empty;
            race = string.Empty;
            background = string.Empty;
            subclass = string.Empty;
            alignment = string.Empty;

            max_hp = 0;
            current_hp = 0;
            temp_hp = 0;
            armour_class = 0;
            initiative = 0;
            speed = 0;
            proficiency_bonus = 0;
            inspiration = false;

            strength = dexterity = constitution = intelligence = wisdom = charisma = 0;

            num_classes = 0;
            class_names = Array.Empty<string>();
            class_levels = Array.Empty<int>();
            hit_dice_remaining = Array.Empty<int>();

            max_spell_slots = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            remaining_spell_slots = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            prepared_spells = Array.Empty<string>();
            spell_class = string.Empty;
            spell_ability = string.Empty;
            concentration = string.Empty;

            skill_proficiencies = Array.Empty<int>();
            skill_expertise = Array.Empty<int>();
            tool_proficiencies = Array.Empty<int>();
            weapon_proficiencies = Array.Empty<int>();
            armour_proficiencies = Array.Empty<int>();
            vehicle_proficiencies = Array.Empty<int>();
            languages = Array.Empty<int>();

            feats = Array.Empty<APIFeat>();
            attacks = Array.Empty<APIAttack>();

            death_save_successes = [false, false, false];
            death_save_failures = [false, false, false];

            inventory = new APIInventory();
            equipped = Array.Empty<string>();
            attuned = Array.Empty<string>();

            image = string.Empty;
            age = 0;
            height = string.Empty;
            weight = string.Empty;
            backstory = Array.Empty<string>();
            allies = Array.Empty<string>();
        }
    }
}
