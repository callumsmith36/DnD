using DND.API;
using DND.InventorySystem;
using DND.Types;

namespace DND
{
    public partial class PlayerCharacter
    {
        // Member variables
        private Dictionary<Ability, int>        _abilityScoreMap;
        private List<Class>                     _classList;
        private List<int>                       _levelList;
        private Dictionary<Class, int>          _hitDiceRemaining;
        private Dictionary<int, List<Spell>>    _preparedSpells;
        private int[]                           _spellSlotsMax;
        private int[]                           _spellSlotsLeft;
        private List<Ability>                   _savingThrows;
        private List<Skill>                     _skillProficiencies;
        private List<Skill>                     _skillExpertise;
        private List<ToolOrKit>                 _toolProficiencies;
        private List<ArmourType>                _armourProficiencies;
        private List<WeaponType>                _weaponProficiencies;
        private List<Vehicle>                   _vehicleProficiencies;
        private List<Language>                  _languages;
        private List<Feat>                      _feats;
        private List<Attack>                    _attacks;
        private List<InventoryObject>           _equippedItems;
        private List<InventoryObject>           _attunedItems;

        // Properties
        public string   Name                { get; set; }
        public string   Race                { get; set; }
        public string   Background          { get; set; }
        public string   Subclass            { get; set; }
        public string   Alignment           { get; set; }
        public int      MaxHP               { get; set; }
        public int      CurrentHP           { get; set; }
        public int      TempHP              { get; set; }
        public int      ArmourClass         { get; set; }
        public int      Initiative          { get; set; }
        public int      Speed               { get; set; }
        public int      ProficiencyBonus    { get; set; }
        public bool     HasInspiration      { get; set; }
        public bool     IsConcentrating     { get; set; }
        public string   ConcentratingOn     { get; set; }
        public string   SpellcastingClass   { get; set; }
        public Ability  SpellcastingAbility { get; set; }
        public string   ImageFile           { get; set; }
        public int      Age                 { get; set; }
        public string   Height              { get; set; }
        public string   Weight              { get; set; }
        public string[] Backstory           { get; set; }
        public string[] Allies              { get; set; }

        public bool[] DeathSaveSuccesses    { get; }
        public bool[] DeathSaveFailures     { get; }

        public Inventory Inventory { get; }

        public int Strength
        {
            get => _abilityScoreMap[Ability.Strength];
            set => _abilityScoreMap[Ability.Strength] = value;
        }
        public int Dexterity
        {
            get => _abilityScoreMap[Ability.Dexterity];
            set => _abilityScoreMap[Ability.Dexterity] = value;
        }
        public int Constitution
        {
            get => _abilityScoreMap[Ability.Constitution];
            set => _abilityScoreMap[Ability.Constitution] = value;
        }
        public int Intelligence
        {
            get => _abilityScoreMap[Ability.Intelligence];
            set => _abilityScoreMap[Ability.Intelligence] = value;
        }
        public int Wisdom
        {
            get => _abilityScoreMap[Ability.Wisdom];
            set => _abilityScoreMap[Ability.Wisdom] = value;
        }
        public int Charisma
        {
            get => _abilityScoreMap[Ability.Charisma];
            set => _abilityScoreMap[Ability.Charisma] = value;
        }


        // Events
        public Action? OnSpellCast;
        public Action? OnPreparedSpellsChanged;
        public Action? OnLongRest;
        public Action? OnShortRest;
        public Action? OnLevelChanged;
        public Action? OnFeatsChanged;
        public Action? OnClassChanged;
        public Action? OnPrimaryClassChanged;
        public Action? OnSavingThrowsChanged;
        public Action? OnSkillProficienciesChanged;
        public Action? OnToolProficienciesChanged;
        public Action? OnWeaponProficienciesChanged;
        public Action? OnArmourProficienciesChanged;
        public Action? OnVehicleProficienciesChanged;
        public Action? OnLanguagesChanged;


        #region CONSTRUCTORS

        //
        //  Constructor
        //  (new character)
        //
        public PlayerCharacter(string name = "", string race = "", string className = "")
        {
            Name = name;
            Race = race;
            Background = string.Empty;
            Subclass = string.Empty;
            Alignment = "Neutral";

            ArmourClass = 10;
            MaxHP = 0;
            TempHP = 0;
            CurrentHP = 0;
            ProficiencyBonus = 2;
            HasInspiration = false;

            IsConcentrating = false;
            ConcentratingOn = string.Empty;

            _savingThrows = new List<Ability>();
            _skillProficiencies = new List<Skill>();
            _skillExpertise = new List<Skill>();
            _toolProficiencies = new List<ToolOrKit>();
            _weaponProficiencies = new List<WeaponType>();
            _armourProficiencies = new List<ArmourType>();
            _vehicleProficiencies = new List<Vehicle>();
            _languages = new List<Language>();

            _feats = new List<Feat>();
            _attacks = new List<Attack>();

            DeathSaveSuccesses = [false, false, false];
            DeathSaveFailures = [false, false, false];

            _classList = new List<Class>();
            _levelList = new List<int>();

            _spellSlotsMax = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            _spellSlotsLeft = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            _abilityScoreMap = new Dictionary<Ability, int>
            {
                [Ability.Strength] = 10,
                [Ability.Dexterity] = 10,
                [Ability.Constitution] = 10,
                [Ability.Intelligence] = 10,
                [Ability.Wisdom] = 10,
                [Ability.Charisma] = 10
            };

            _preparedSpells = new Dictionary<int, List<Spell>>();
            for (int i = 0; i < 10; i++)
                _preparedSpells[i] = new List<Spell>();

            _hitDiceRemaining = new Dictionary<Class, int>();

            AddClass(className, 1);

            if (_classList.Count > 0)
                SpellcastingAbility = _classList[0].SpellcastingAbility;
            else
                SpellcastingAbility = Ability.None;

            if (SpellcastingAbility == Ability.None)
                SpellcastingClass = string.Empty;
            else
                SpellcastingClass = _classList[0].Name;

            Inventory = new Inventory();

            _equippedItems = new List<InventoryObject>();
            _attunedItems = new List<InventoryObject>();

            ImageFile = string.Empty;
            Age = 0;
            Height = string.Empty;
            Weight = string.Empty;
            Backstory = Array.Empty<string>();
            Allies = Array.Empty<string>();

            OnLevelChanged += UpdateProficiencyBonus;
            Inventory.OnItemRemoved += Inventory_OnItemRemoved;
        }

        //
        //  Constructor
        //  (load from file)
        //
        public PlayerCharacter(APIPlayerCharacter obj)
        {
            Name = obj.name;
            Race = obj.race;
            Background = obj.background;
            Subclass = obj.subclass;
            Alignment = obj.alignment;

            MaxHP = obj.max_hp;
            CurrentHP = obj.current_hp;
            TempHP = obj.temp_hp;
            ArmourClass = obj.armour_class;
            Initiative = obj.initiative;
            Speed = obj.speed;
            ProficiencyBonus = obj.proficiency_bonus;
            HasInspiration = obj.inspiration;

            DeathSaveSuccesses = [obj.death_save_successes[0], obj.death_save_successes[1], obj.death_save_successes[2]];
            DeathSaveFailures = [obj.death_save_failures[0], obj.death_save_failures[1], obj.death_save_failures[2]];

            ConcentratingOn = obj.concentration;
            IsConcentrating = obj.concentration.Length > 0;

            _savingThrows = new List<Ability>();
            foreach (var num in obj.saving_throws)
            {
                Ability ability = (Ability)num;
                if (ability != Ability.None)
                    AddSavingThrow(ability);
            }

            _skillProficiencies = new List<Skill>();
            foreach (var num in obj.skill_proficiencies)
            {
                Skill skill = (Skill)num;
                if (skill != Skill.None)
                    AddSkillProficiency(skill);
            }

            _skillExpertise = new List<Skill>();
            foreach (var num in obj.skill_expertise)
            {
                Skill skill = (Skill)num;
                if (skill != Skill.None)
                    AddSkillExpertise(skill);
            }

            _toolProficiencies = new List<ToolOrKit>();
            foreach (var num in obj.tool_proficiencies)
            {
                ToolOrKit tool = (ToolOrKit)num;
                if (tool != ToolOrKit.None)
                    AddToolProficiency(tool);
            }

            _weaponProficiencies = new List<WeaponType>();
            foreach (var num in obj.weapon_proficiencies)
            {
                WeaponType type = (WeaponType)num;
                if (type != WeaponType.None)
                    AddWeaponProficiency(type);
            }

            _armourProficiencies = new List<ArmourType>();
            foreach (var num in obj.armour_proficiencies)
            {
                ArmourType type = (ArmourType)num;
                if (type != ArmourType.None)
                    AddArmourProficiency(type);
            }

            _vehicleProficiencies = new List<Vehicle>();
            foreach (var num in obj.vehicle_proficiencies)
            {
                Vehicle vehicle = (Vehicle)num;
                if (vehicle != Vehicle.None)
                    AddVehicleProficiency(vehicle);
            }

            _languages = new List<Language>();
            foreach (var num in obj.languages)
            {
                Language language = (Language)num;
                if (language != Language.None)
                    AddLanguage(language);
            }

            _feats = new List<Feat>();
            foreach (var feat in obj.feats)
                AddFeat(new Feat(feat));

            _attacks = new List<Attack>();
            foreach (var attack in obj.attacks)
                AddAttack(new Attack(attack));

            _abilityScoreMap = new Dictionary<Ability, int>
            {
                [Ability.Strength] = obj.strength,
                [Ability.Dexterity] = obj.dexterity,
                [Ability.Constitution] = obj.constitution,
                [Ability.Intelligence] = obj.intelligence,
                [Ability.Wisdom] = obj.wisdom,
                [Ability.Charisma] = obj.charisma
            };

            _classList = new List<Class>();
            _levelList = new List<int>();
            _hitDiceRemaining = new Dictionary<Class, int>();
            for (int i = 0; i < obj.num_classes; i++)
            {
                AddClass(obj.class_names[i], obj.class_levels[i]);

                int hitDice = i < obj.hit_dice_remaining.Length ? obj.hit_dice_remaining[i] : obj.class_levels[i];
                SetHitDiceRemaining(obj.class_names[i], hitDice);
            }

            var c = GetPrimaryClass();
            if (c != null)
            {
                foreach (var ability in c.SavingThrows)
                    AddSavingThrow(ability);
            }

            _preparedSpells = new Dictionary<int, List<Spell>>();
            for (int i = 0; i < 10; i++)
                _preparedSpells[i] = new List<Spell>();

            foreach (var spellName in obj.prepared_spells)
                AddPreparedSpell(spellName);

            _spellSlotsMax = obj.max_spell_slots;
            _spellSlotsLeft = obj.remaining_spell_slots;

            SpellcastingClass = obj.spell_class;
            SpellcastingAbility = Ability.None;
            foreach (var ability in TypeMaps.AbilityNames.Keys)
            {
                if (obj.spell_ability.ToLower() == TypeMaps.AbilityNames[ability].ToLower())
                {
                    SpellcastingAbility = ability;
                    break;
                }
            }

            Inventory = new Inventory(obj.inventory);

            _equippedItems = new List<InventoryObject>();
            foreach (var name in obj.equipped)
            {
                if (Inventory.TryGetWeapon(name, out var weapon))
                    _equippedItems.Add(weapon);
                else if (Inventory.TryGetArmour(name, out var armour))
                    _equippedItems.Add(armour);
                else if (Inventory.TryGetMagicItem(name, out var item))
                    _equippedItems.Add(item);
            }

            _attunedItems = new List<InventoryObject>();
            foreach (var name in obj.attuned)
            {
                if (Inventory.TryGetMagicItem(name, out var item))
                    _attunedItems.Add(item);
            }

            ImageFile = obj.image;
            Age = obj.age;
            Height = obj.height;
            Weight = obj.weight;

            Backstory = new string[obj.backstory.Length];
            for (int i = 0; i < obj.backstory.Length; i++)
                Backstory[i] = obj.backstory[i];

            Allies = new string[obj.allies.Length];
            for (int i = 0; i < obj.allies.Length; i++)
                Allies[i] = obj.allies[i];

            OnLevelChanged += UpdateProficiencyBonus;
            Inventory.OnItemRemoved += Inventory_OnItemRemoved;
        }

        //
        //  Copy Constructor
        //
        public PlayerCharacter(PlayerCharacter pc)
        {
            Name = pc.Name;
            Race = pc.Race;
            Background = pc.Background;
            Subclass = pc.Subclass;
            Alignment = pc.Alignment;
            MaxHP = pc.MaxHP;
            CurrentHP = pc.CurrentHP;
            TempHP = pc.TempHP;
            ArmourClass = pc.ArmourClass;
            Initiative = pc.Initiative;
            Speed = pc.Speed;
            ProficiencyBonus = pc.ProficiencyBonus;
            HasInspiration = pc.HasInspiration;

            DeathSaveSuccesses = [pc.DeathSaveSuccesses[0], pc.DeathSaveSuccesses[1], pc.DeathSaveSuccesses[2]];
            DeathSaveFailures = [pc.DeathSaveFailures[0], pc.DeathSaveFailures[1], pc.DeathSaveFailures[2]];

            _abilityScoreMap = new Dictionary<Ability, int>();
            Strength = pc.Strength;
            Dexterity = pc.Dexterity;
            Constitution = pc.Constitution;
            Intelligence = pc.Intelligence;
            Wisdom = pc.Wisdom;
            Charisma = pc.Charisma;

            _classList = new List<Class>();
            _levelList = new List<int>();
            _hitDiceRemaining = new Dictionary<Class, int>();

            foreach (var pcClass in pc.GetClassList())
            {
                Class thisClass = new Class(pcClass);
                _classList.Add(thisClass);
                _levelList.Add(pc.GetClassLevel(pcClass.Name));
                _hitDiceRemaining[thisClass] = pc._hitDiceRemaining[pcClass];
            }

            _savingThrows = new List<Ability>();
            foreach(var ability in pc._savingThrows)
                AddSavingThrow(ability);

            _skillProficiencies = new List<Skill>();
            foreach (var skill in pc._skillProficiencies)
                AddSkillProficiency(skill);

            _skillExpertise = new List<Skill>();
            foreach (var skill in pc._skillExpertise)
                AddSkillExpertise(skill);

            _toolProficiencies = new List<ToolOrKit>();
            foreach (var skill in pc._toolProficiencies)
                AddToolProficiency(skill);

            _weaponProficiencies = new List<WeaponType>();
            foreach (var skill in pc._weaponProficiencies)
                AddWeaponProficiency(skill);

            _armourProficiencies = new List<ArmourType>();
            foreach (var skill in pc._armourProficiencies)
                AddArmourProficiency(skill);

            _vehicleProficiencies = new List<Vehicle>();
            foreach (var skill in pc._vehicleProficiencies)
                AddVehicleProficiency(skill);

            _languages = new List<Language>();
            foreach (var skill in pc._languages)
                AddLanguage(skill);

            _feats = new List<Feat>();
            foreach (var feat in pc._feats)
                AddFeat(new Feat(feat));

            _attacks = new List<Attack>();
            foreach (var attack in pc._attacks)
                AddAttack(new Attack(attack));

            _preparedSpells = new Dictionary<int, List<Spell>>();
            for (int i = 0; i <= 9; i++)
            {
                _preparedSpells[i] = new List<Spell>();
                foreach (var spell in pc.GetPreparedSpells(i))
                    _preparedSpells[i].Add(new Spell(spell));
            }

            _spellSlotsMax = new int[9];
            for (int i = 1; i <= 9; i++)
                SetNumSpellSlotsMax(i, pc.GetNumSpellSlotsMax(i));

            _spellSlotsLeft = new int[9];
            for (int i = 1; i <= 9; i++)
                SetNumSpellSlotsRemaining(i, pc.GetNumSpellSlotsRemaining(i));

            IsConcentrating = pc.IsConcentrating;
            ConcentratingOn = pc.ConcentratingOn;
            SpellcastingClass = pc.SpellcastingClass;
            SpellcastingAbility = pc.SpellcastingAbility;

            Inventory = new Inventory(pc.Inventory);

            _equippedItems = new List<InventoryObject>();
            foreach (var item in pc._equippedItems)
            {
                if (Inventory.TryGetWeapon(item.Name, out var weapon))
                    _equippedItems.Add(weapon);
                else if (Inventory.TryGetArmour(item.Name, out var armour))
                    _equippedItems.Add(armour);
                else if (Inventory.TryGetMagicItem(item.Name, out var magicItem))
                    _equippedItems.Add(magicItem);
            }

            _attunedItems = new List<InventoryObject>();
            foreach (var item in pc._attunedItems)
            {
                if (Inventory.TryGetMagicItem(item.Name, out var magicItem))
                    _attunedItems.Add(magicItem);
            }

            ImageFile = pc.ImageFile;
            Age = pc.Age;
            Height = pc.Height;
            Weight = pc.Weight;

            Backstory = new string[pc.Backstory.Length];
            for (int i = 0; i < pc.Backstory.Length; i++)
                Backstory[i] = pc.Backstory[i];

            Allies = new string[pc.Allies.Length];
            for (int i = 0; i < pc.Allies.Length; i++)
                Allies[i] = pc.Allies[i];

            OnLevelChanged += UpdateProficiencyBonus;
            Inventory.OnItemRemoved += Inventory_OnItemRemoved;
        }

        #endregion // CONSTRUCTORS


        #region ABILITIES / SKILLS / FEATS

        //
        //  GetAbilityModifier
        //
        public static int GetAbilityModifier(int score)
        {
            int mod = (score - 10) / 2;
            if (score < 10 && (score % 2) != 0)
                mod--;

            return mod;
        }

        //
        //  GetAbilityModifier
        //
        public int GetAbilityModifier(Ability ability)
        {
            return ability == Ability.None ? 0 : GetAbilityModifier(_abilityScoreMap[ability]);
        }

        //
        //  GetSkillModifier
        //
        public int GetSkillModifier(Skill skill)
        {
            if (skill == Skill.None)
                return 0;

            int score = _abilityScoreMap[TypeMaps.SkillAbilities[skill]];
            int mod = GetAbilityModifier(score);

            if (_skillProficiencies.Contains(skill))
                mod += ProficiencyBonus;
            if (_skillExpertise.Contains(skill))
                mod += ProficiencyBonus;

            return mod;
        }

        //
        //  GetSavingThrowModifier
        //
        public int GetSavingThrowModifier(Ability ability)
        {
            if (ability == Ability.None)
                return 0;

            int mod = GetAbilityModifier(_abilityScoreMap[ability]);

            /*var primaryClass = GetPrimaryClass();
            if (primaryClass != null && primaryClass.SavingThrows.Contains(ability))
                mod += ProficiencyBonus;*/

            if (_savingThrows.Contains(ability))
                mod += ProficiencyBonus;

            return mod;
        }

        //
        //  SetAbilityScore
        //
        public void SetAbilityScore(Ability ability, int score)
        {
            if (ability != Ability.None)
                _abilityScoreMap[ability] = score;
        }

        //
        //  GetFeat
        //
        public Feat? GetFeat(string name)
        {
            string index = APIReadWrite.NameToIndex(name);
            foreach (var feat in _feats)
            {
                if (feat.Index == index)
                    return feat;
            }

            return null;
        }

        //
        //  GetFeatList
        //
        public Feat[] GetFeatList(bool sorted = false)
        {
            if (!sorted)
                return _feats.ToArray();

            List<Feat> sortedList = new List<Feat>();
            int i;

            foreach (var feat in _feats)
            {
                for (i = 0; i < sortedList.Count; i++)
                {
                    if (string.Compare(feat.SourceName, sortedList[i].SourceName) == -1)
                        break;

                    if (string.Compare(feat.SourceName, sortedList[i].SourceName) == 0 && string.Compare(feat.Name, sortedList[i].Name) == -1)
                        break;
                }

                if (i < sortedList.Count)
                    sortedList.Insert(i, feat);
                else
                    sortedList.Add(feat);
            }

            return sortedList.ToArray();
        }

        //
        //  AddFeat
        //
        public void AddFeat(Feat feat)
        {
            if (_feats.Contains(feat) == false)
            {
                _feats.Add(feat);
                OnFeatsChanged?.Invoke();
            }
        }

        //
        //  RemoveFeat
        //
        public bool RemoveFeat(string name)
        {
            string index = APIReadWrite.NameToIndex(name);
            foreach (var feat in _feats)
            {
                if (feat.Index == index)
                    return _feats.Remove(feat);
            }

            OnFeatsChanged?.Invoke();
            return false;
        }

        //
        //  GetAttack
        //
        public Attack? GetAttack(string name)
        {
            string index = APIReadWrite.NameToIndex(name);
            foreach (var atk in _attacks)
            {
                if (atk.Index == index)
                    return atk;
            }

            return null;
        }

        //
        //  GetAttackList
        //
        public Attack[] GetAttackList()
        {
            return _attacks.ToArray();
        }

        //
        //  AddAttack
        //
        public void AddAttack(Attack atk)
        {
            if (_attacks.Contains(atk) == false)
            {
                _attacks.Add(atk);
            }
        }

        //
        //  RemoveAttack
        //
        public bool RemoveAttack(string name)
        {
            string index = APIReadWrite.NameToIndex(name);
            foreach (var atk in _attacks)
            {
                if (atk.Index == index)
                    return _attacks.Remove(atk);
            }

            return false;
        }

        #endregion // ABILITIES / SKILLS / FEATS


        #region RESTING

        //
        //  ReplenishHitDice
        //
        private void ReplenishHitDice()
        {
            // Replenish half the total hit dice, prioritising
            // classes with the highest value hit die

            int i;

            int totalLvl = GetTotalLevel();
            if (totalLvl == 0)
                return;

            int hitDiceIncrease = totalLvl / 2;
            if (totalLvl % 2 != 0)
                hitDiceIncrease++;

            List<Class> ordered = new List<Class>();
            foreach (var c in _classList)
            {
                for (i = 0; i < ordered.Count; i++)
                {
                    if (ordered[i].HitDie < c.HitDie)
                        break;
                }

                if (i < ordered.Count)
                    ordered.Insert(i, c);
                else
                    ordered.Add(c);
            }

            i = 0;
            while (hitDiceIncrease > 0)
            {
                if (i >= ordered.Count)
                    break;

                if (_hitDiceRemaining.ContainsKey(ordered[i]))
                {
                    while (GetHitDiceRemaining(ordered[i].Name) < GetClassLevel(ordered[i].Name))
                    {
                        _hitDiceRemaining[ordered[i]]++;
                        hitDiceIncrease--;
                        if (hitDiceIncrease == 0)
                            break;
                    }
                }

                i++;
            }
        }

        //
        //  ReplenishFeats
        //
        private void ReplenishFeats(Feat.FeatFrequency restType)
        {
            bool invoke = false;
            foreach (var feat in _feats)
            {
                if (((int)feat.Frequency & (int)restType) > 0 && feat.UsesRemaining < feat.MaxUses)
                {
                    feat.UsesRemaining = feat.MaxUses;
                    invoke = true;
                }
            }

            if (invoke)
                OnFeatsChanged?.Invoke();
        }

        //
        //  LongRest
        //
        public void LongRest()
        {
            CurrentHP = MaxHP;
            TempHP = 0;

            for (int i = 0; i < 9; i++)
                _spellSlotsLeft[i] = _spellSlotsMax[i];

            IsConcentrating = false;
            ConcentratingOn = string.Empty;

            ReplenishHitDice();
            ReplenishFeats(Feat.FeatFrequency.LongRest | Feat.FeatFrequency.ShortRest);

            OnLongRest?.Invoke();
        }

        //
        //  ShortRest
        //
        public void ShortRest()
        {
            ReplenishFeats(Feat.FeatFrequency.ShortRest);

            OnShortRest?.Invoke();
        }

        #endregion // RESTING


        //
        //  ToAPIObject
        //
        public APIPlayerCharacter ToAPIObject()
        {
            int i;

            APIPlayerCharacter pc = new APIPlayerCharacter();
            pc.name = Name;
            pc.race = Race;
            pc.background = Background;
            pc.subclass = Subclass;
            pc.alignment = Alignment;
            pc.max_hp = MaxHP;
            pc.current_hp = CurrentHP;
            pc.temp_hp = TempHP;
            pc.armour_class = ArmourClass;
            pc.initiative = Initiative;
            pc.speed = Speed;
            pc.proficiency_bonus = ProficiencyBonus;
            pc.strength = Strength;
            pc.inspiration = HasInspiration;
            pc.dexterity = Dexterity;
            pc.constitution = Constitution;
            pc.intelligence = Intelligence;
            pc.wisdom = Wisdom;
            pc.charisma = Charisma;

            pc.death_save_successes = new bool[DeathSaveSuccesses.Length];
            for (i = 0; i < DeathSaveSuccesses.Length; i++)
                pc.death_save_successes[i] = DeathSaveSuccesses[i];

            pc.death_save_failures = new bool[DeathSaveFailures.Length];
            for (i = 0; i < DeathSaveFailures.Length; i++)
                pc.death_save_failures[i] = DeathSaveFailures[i];

            pc.num_classes = _classList.Count;
            pc.class_names = new string[pc.num_classes];
            pc.class_levels = new int[pc.num_classes];
            pc.hit_dice_remaining = new int[pc.num_classes];
            for (i = 0; i < pc.num_classes; i++)
            {
                pc.class_names[i] = _classList[i].Name;
                pc.class_levels[i] = _levelList[i];
                pc.hit_dice_remaining[i] = GetHitDiceRemaining(_classList[i].Name);
            }

            List<string> spells = new List<string>();
            for (i = 0; i < 10; i++)
            {
                foreach (var spell in _preparedSpells[i])
                    spells.Add(spell.Name);
            }

            pc.prepared_spells = spells.ToArray();
            pc.spell_ability = TypeMaps.AbilityNames[SpellcastingAbility];
            pc.concentration = ConcentratingOn;

            pc.max_spell_slots = new int[_spellSlotsMax.Length];
            for (i = 0; i < _spellSlotsMax.Length; i++)
                pc.max_spell_slots[i] = _spellSlotsMax[i];

            pc.remaining_spell_slots = new int[_spellSlotsLeft.Length];
            for (i = 0; i < _spellSlotsLeft.Length; i++)
                pc.remaining_spell_slots[i] = _spellSlotsLeft[i];

            pc.spell_class = SpellcastingClass;
            pc.spell_ability = TypeMaps.AbilityNames[SpellcastingAbility];

            pc.saving_throws = new int[_savingThrows.Count];
            for (i = 0; i < _savingThrows.Count; i++)
                pc.saving_throws[i] = (int)_savingThrows[i];

            pc.skill_proficiencies = new int[_skillProficiencies.Count];
            for (i = 0; i < _skillProficiencies.Count; i++)
                pc.skill_proficiencies[i] = (int)_skillProficiencies[i];

            pc.skill_expertise = new int[_skillExpertise.Count];
            for (i = 0; i < _skillExpertise.Count; i++)
                pc.skill_expertise[i] = (int)_skillExpertise[i];

            pc.tool_proficiencies = new int[_toolProficiencies.Count];
            for (i = 0; i < _toolProficiencies.Count; i++)
                pc.tool_proficiencies[i] = (int)_toolProficiencies[i];

            pc.weapon_proficiencies = new int[_weaponProficiencies.Count];
            for (i = 0; i < _weaponProficiencies.Count; i++)
                pc.weapon_proficiencies[i] = (int)_weaponProficiencies[i];

            pc.armour_proficiencies = new int[_armourProficiencies.Count];
            for (i = 0; i < _armourProficiencies.Count; i++)
                pc.armour_proficiencies[i] = (int)_armourProficiencies[i];

            pc.vehicle_proficiencies = new int[_vehicleProficiencies.Count];
            for (i = 0; i < _vehicleProficiencies.Count; i++)
                pc.vehicle_proficiencies[i] = (int)_vehicleProficiencies[i];

            pc.languages = new int[_languages.Count];
            for (i = 0; i < _languages.Count; i++)
                pc.languages[i] = (int)_languages[i];

            pc.feats = new APIFeat[_feats.Count];
            for (i = 0; i < _feats.Count; i++)
                pc.feats[i] = _feats[i].ToAPIObject();

            pc.attacks = new APIAttack[_attacks.Count];
            for (i = 0; i < _attacks.Count; i++)
                pc.attacks[i] = _attacks[i].ToAPIObject();

            pc.inventory = Inventory.ToAPIObject();

            pc.equipped = new string[_equippedItems.Count];
            for (i = 0; i < _equippedItems.Count; i++)
                pc.equipped[i] = _equippedItems[i].Name;

            pc.attuned = new string[_attunedItems.Count];
            for (i = 0; i < _attunedItems.Count; i++)
                pc.attuned[i] = _attunedItems[i].Name;

            pc.image = ImageFile;
            pc.age = Age;
            pc.height = Height;
            pc.weight = Weight;

            pc.backstory = new string[Backstory.Length];
            for (i = 0; i < Backstory.Length; i++)
                pc.backstory[i] = Backstory[i];

            pc.allies = new string[Allies.Length];
            for (i = 0; i < Allies.Length; i++)
                pc.allies[i] = Allies[i];

            return pc;
        }

        //
        //  == operator
        //
        public static bool operator ==(PlayerCharacter? a, PlayerCharacter? b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);

            return a.Equals(b);
        }

        //
        //  != operator
        //
        public static bool operator !=(PlayerCharacter? a, PlayerCharacter? b)
        {
            return !(a == b);
        }

        //
        //  AreEnumListsEqual
        //
        private bool AreEnumListsEqual<T>(IEnumerable<T> listA, IEnumerable<T> listB)
            where T : struct, Enum
        {
            if (listA.Count() != listB.Count())
                return false;

            if (listA.Count() == 0 && listB.Count() == 0)
                return true;

            foreach (var objA in listA)
            {
                if (!listB.Contains(objA))
                    return false;
            }

            return true;
        }

        //
        //  AreObjectListsEqual
        //
        private bool AreObjectListsEqual<T>(IEnumerable<T> listA, IEnumerable<T> listB)
            where T : IEquatable<T>
        {
            if (listA.Count() != listB.Count())
                return false;

            if (listA.Count() == 0 && listB.Count() == 0)
                return true;

            bool equal = false;
            foreach (var objA in listA)
            {
                equal = false;
                foreach (var objB in listB)
                {
                    if (objA.Equals(objB))
                    {
                        equal = true;
                        break;
                    }
                }

                if (!equal)
                    break;
            }

            return equal;
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

            if (obj is not PlayerCharacter)
                return false;

            var other = obj as PlayerCharacter;

            bool equal =
                Name == other.Name &&
                Race == other.Race &&
                Background == other.Background &&
                Subclass == other.Subclass &&
                Alignment == other.Alignment &&
                MaxHP == other.MaxHP &&
                CurrentHP == other.CurrentHP &&
                TempHP == other.TempHP &&
                ArmourClass == other.ArmourClass &&
                Initiative == other.Initiative &&
                Speed == other.Speed &&
                ProficiencyBonus == other.ProficiencyBonus &&
                HasInspiration == other.HasInspiration &&
                SpellcastingClass == other.SpellcastingClass &&
                SpellcastingAbility == other.SpellcastingAbility &&
                _feats.Count == other._feats.Count &&
                _attacks.Count == other._attacks.Count &&
                Strength == other.Strength &&
                Dexterity == other.Dexterity &&
                Constitution == other.Constitution &&
                Intelligence == other.Intelligence &&
                Wisdom == other.Wisdom &&
                Charisma == other.Charisma &&
                GetClassList().Length == other.GetClassList().Length &&
                _equippedItems.Count == other._equippedItems.Count &&
                _attunedItems.Count == other._attunedItems.Count &&
                ImageFile.Equals(other.ImageFile, StringComparison.OrdinalIgnoreCase) &&
                Age == other.Age &&
                Height == other.Height &&
                Weight == other.Weight &&
                Backstory.Length == other.Backstory.Length &&
                Allies.Length == other.Allies.Length;

            // Check concentration is equal
            if (equal)
            {
                if (IsConcentrating == !(other.IsConcentrating) ||
                    ConcentratingOn != other.ConcentratingOn)
                {
                    equal = false;
                }
            }

            // Check death saves are equal
            if (equal)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (DeathSaveSuccesses[i] != other.DeathSaveSuccesses[i] ||
                        DeathSaveFailures[i] != other.DeathSaveFailures[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            // Check proficiency lists are equal
            if (equal)
            {
                equal =
                    AreEnumListsEqual(_savingThrows, other._savingThrows) &&
                    AreEnumListsEqual(_skillProficiencies, other._skillProficiencies) &&
                    AreEnumListsEqual(_skillExpertise, other._skillExpertise) &&
                    AreEnumListsEqual(_toolProficiencies, other._toolProficiencies) &&
                    AreEnumListsEqual(_weaponProficiencies, other._weaponProficiencies) &&
                    AreEnumListsEqual(_armourProficiencies, other._armourProficiencies) &&
                    AreEnumListsEqual(_vehicleProficiencies, other._vehicleProficiencies) &&
                    AreEnumListsEqual(_languages, other._languages);
            }

            // Check feat lists are equal
            if (equal)
                equal = AreObjectListsEqual(_feats, other._feats);

            // Check attack lists are equal
            if (equal)
                equal = AreObjectListsEqual(_attacks, other._attacks);

            // Check classes, levels, and hit dice are equal
            if (equal)
            {
                foreach (var thisClass in GetClassList())
                {
                    equal = false;
                    foreach (var otherClass in other.GetClassList())
                    {
                        if (otherClass.Index == thisClass.Index &&
                            GetClassLevel(thisClass.Name) == other.GetClassLevel(otherClass.Name) &&
                            GetHitDiceRemaining(thisClass.Name) == other.GetHitDiceRemaining(otherClass.Name))
                        {
                            equal = true;
                            break;
                        }
                    }

                    if (!equal)
                        break;
                }
            }

            // Check spell slots are equal
            if (equal)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (GetNumSpellSlotsMax(i) != other.GetNumSpellSlotsMax(i) ||
                        GetNumSpellSlotsRemaining(i) != other.GetNumSpellSlotsRemaining(i))
                    {
                        equal = false;
                        break;
                    }
                }
            }

            // Check spell lists are equal
            if (equal)
            {
                for (int i = 0; i <= 9; i++)
                {
                    var thisSpellList = GetPreparedSpells(i);
                    var otherSpellList = other.GetPreparedSpells(i);

                    if (thisSpellList.Length != otherSpellList.Length)
                    {
                        equal = false;
                        break;
                    }

                    foreach (var thisSpell in thisSpellList)
                    {
                        equal = false;

                        foreach (var otherSpell in otherSpellList)
                        {
                            if (otherSpell.Name.ToLower() == thisSpell.Name.ToLower())
                            {
                                equal = true;
                                break;
                            }
                        }

                        if (!equal)
                            break;
                    }
                }
            }

            if (equal)
                equal = Inventory.Equals(other.Inventory);

            if (equal)
            {
                foreach (var item in _equippedItems)
                {
                    if (!other.IsEquipped(item))
                    {
                        equal = false;
                        break;
                    }
                }
            }

            if (equal)
            {
                foreach (var item in _attunedItems)
                {
                    if (!other.IsAttuned(item))
                    {
                        equal = false;
                        break;
                    }
                }
            }

            if (equal)
            {
                for (int i = 0; i < Backstory.Length; i++)
                {
                    if (Backstory[i] != other.Backstory[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            if (equal)
            {
                for (int i = 0; i < Allies.Length; i++)
                {
                    if (Allies[i] != other.Allies[i])
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
