/*********************************************************
 *  
 *  Name:       InventorySystem/Equipment.cs
 *  
 *  Purpose:    Class representing D&D equipment, plus
 *              various classes that derive from it which
 *              represent different equipment types.
 *  
 *  Author:     CS
 *  
 *  Created:    30/01/2024
 * 
 *********************************************************/

using DND.API;
using DND.Types;

namespace DND.InventorySystem
{
    /********************
        Equipment
    ********************/
    public class Equipment : InventoryObject
    {
        // Properties
        public float    Weight      { get; protected set; }
        public int      CostValue   { get; protected set; }
        public string   CostUnit    { get; protected set; }


        //
        //  Constructor
        //  (from custom data)
        //
        public Equipment(
            string name, EquipmentCategory category, float weight,
            int value, string unit, string[] desc,
            bool known = true
        )
            : base(name, "/custom/equipment", category, desc, false)
        {
            Weight = weight;
            CostValue = value;
            CostUnit = unit;

            if (!known)
                RemoveURL();
        }

        //
        //  Constructor
        //  (from APIReference)
        //
        public Equipment(APIEquipment obj) : base(obj)
        {
            Weight = obj.weight;
            CostValue = obj.cost.quantity;
            CostUnit = obj.cost.unit;

            Description = new string[obj.desc.Length];
            for (int i = 0; i < obj.desc.Length; i++)
                Description[i] = obj.desc[i];
        }

        //
        //  Copy Constructor
        //
        public Equipment(Equipment obj) : base(obj)
        {
            Weight = obj.Weight;
            CostValue = obj.CostValue;
            CostUnit = obj.CostUnit;
        }


        //
        //  ToAPIObject
        //
        public override APIEquipment ToAPIObject()
        {
            return new APIEquipment(Name, TypeMaps.EquipmentCategoryNames[EquipmentCategory], Weight, CostValue, CostUnit, Description);
        }
    }


    /********************
        Armour
    ********************/
    public class Armour : Equipment
    {
        // Properties
        public ArmourType   ArmourCategory      { get; private set; }
        public int          BaseAC              { get; private set; }
        public bool         DexBonus            { get; private set; }
        public int          MaxBonus            { get; private set; }
        public int          MinStrength         { get; private set; }
        public bool         StealthDisadvantage { get; private set; }


        //
        //  Constructor
        //  (from custom data)
        //
        public Armour(
            string name, ArmourType category, float weight,
            int baseAC, bool dexBonus, int maxBonus,
            int minStr, bool disadvantage, string[] desc,
            int value = 0, string unit = ""
        )
            : base(name, EquipmentCategory.Armour, weight, value, unit, desc)
        {
            ArmourCategory = category;
            BaseAC = baseAC;
            DexBonus = dexBonus;
            MaxBonus = maxBonus;
            MinStrength = minStr;
            StealthDisadvantage = disadvantage;
        }

        //
        //  Constructor
        //  (from APIReference)
        //
        public Armour(APIArmour obj) : base(obj)
        {
            switch (obj.armor_category.ToLower())
            {
                case "light": ArmourCategory = ArmourType.LightArmour; break;
                case "medium": ArmourCategory = ArmourType.MediumArmour; break;
                case "heavy": ArmourCategory = ArmourType.HeavyArmour; break;
                case "shield": ArmourCategory = ArmourType.Shield; break;
                default:
                    ArmourCategory = ArmourType.None;
                    break;
            }

            BaseAC = obj.armor_class.@base;
            DexBonus = obj.armor_class.dex_bonus;
            MaxBonus = obj.armor_class.max_bonus;
            MinStrength = obj.str_minimum;
            StealthDisadvantage = obj.stealth_disadvantage;
        }

        //
        //  Copy Constructor
        //
        public Armour(Armour armour) : base(armour)
        {
            ArmourCategory = armour.ArmourCategory;
            BaseAC = armour.BaseAC;
            DexBonus = armour.DexBonus;
            MaxBonus = armour.MaxBonus;
            MinStrength = armour.MinStrength;
            StealthDisadvantage = armour.StealthDisadvantage;
        }


        //
        //  ToAPIObject
        //
        public override APIArmour ToAPIObject()
        {
            string category;
            switch (ArmourCategory)
            {
                case ArmourType.LightArmour: category = "Light"; break;
                case ArmourType.MediumArmour: category = "Medium"; break;
                case ArmourType.HeavyArmour: category = "Heavy"; break;
                case ArmourType.Shield: category = "Shield"; break;
                default:
                    category = TypeMaps.ArmourCategoryNames[ArmourCategory];
                    break;
            }

            return new APIArmour(
                Name, category, BaseAC,
                DexBonus, MaxBonus, MinStrength,
                StealthDisadvantage, Weight, CostValue,
                CostUnit, Description
            );
        }
    }


    /********************
        Weapon
    ********************/
    public class Weapon : Equipment
    {
        // Properties
        public WeaponType           WeaponCategory      { get; private set; }
        public string               RangeString         { get; private set; }
        public WeaponRange          Range               { get; private set; }
        public WeaponRange          ThrownRange         { get; private set; }
        public string               DamageDicePrimary   { get; private set; }
        public string               DamageDiceSecondary { get; private set; }
        public string               DamageType          { get; private set; }
        public string[]             Special             { get; private set; }
        public List<WeaponProperty> Properties          { get; private set; }


        //
        //  Constructor
        //  (from custom data)
        //
        public Weapon(
            string name, WeaponType category, float weight,
            string rangeStr, WeaponRange range, WeaponRange thrownRange,
            string dice1, string dice2, string damType,
            string[] desc, string[] special, WeaponProperty[] props,
            int value = 0, string unit = ""
        )
            : base(name, EquipmentCategory.Weapon, weight, value, unit, desc)
        {
            WeaponCategory = category;
            RangeString = rangeStr;
            Range = range;
            ThrownRange = thrownRange;
            DamageDicePrimary = dice1;
            DamageDiceSecondary = dice2;
            DamageType = damType;

            Special = new string[special.Length];
            for (int i = 0; special.Length > i; i++)
                Special[i] = special[i];

            Properties = new List<WeaponProperty>();
            for (int i = 0; i < props.Length; i++)
                Properties.Add(props[i]);
        }

        //
        //  Constructor
        //  (from APIReference)
        //
        public Weapon(APIWeapon obj) : base(obj)
        {
            RangeString = obj.weapon_range;
            Range = new WeaponRange(obj.range.normal, obj.range.@long);
            ThrownRange = new WeaponRange(obj.throw_range.normal, obj.throw_range.@long);
            DamageDicePrimary = obj.damage.damage_dice;
            DamageDiceSecondary = obj.two_handed_damage.damage_dice;
            DamageType = obj.damage.damage_type.name;

            if (obj.weapon_category.ToLower() == "simple")
                WeaponCategory = WeaponType.SimpleWeapons;
            else if (obj.weapon_category.ToLower() == "martial")
                WeaponCategory = WeaponType.MartialWeapons;
            else
                WeaponCategory = WeaponType.None;

            Special = new string[obj.special.Length];
            for (int i = 0; obj.special.Length > i; i++)
                Special[i] = obj.special[i];

            Properties = new List<WeaponProperty>();
            for (int i = 0; i < obj.properties.Length; i++)
            {
                WeaponProperty prop = TypeMaps.GetValueFromName(obj.properties[i].name, TypeMaps.WeaponPropertyNames);
                if (prop != default)
                    Properties.Add(prop);
            }
        }

        //
        //  Copy Constructor
        //
        public Weapon(Weapon weapon) : base(weapon)
        {
            WeaponCategory = weapon.WeaponCategory;
            RangeString = weapon.RangeString;
            Range = weapon.Range;
            ThrownRange = weapon.ThrownRange;
            DamageDicePrimary = weapon.DamageDicePrimary;
            DamageDiceSecondary = weapon.DamageDiceSecondary;
            DamageType = weapon.DamageType;

            Special = new string[weapon.Special.Length];
            for (int i = 0; weapon.Special.Length > i; i++)
                Special[i] = weapon.Special[i];

            Properties = new List<WeaponProperty>();
            foreach (var prop in weapon.Properties)
                Properties.Add(prop);
        }


        //
        //  ToAPIObject
        //
        public override APIWeapon ToAPIObject()
        {
            string category;
            if (WeaponCategory == WeaponType.SimpleWeapons)
                category = "Simple";
            else if (WeaponCategory == WeaponType.MartialWeapons)
                category = "Martial";
            else
                category = string.Empty;

            var props = new string[Properties.Count];
            for (int i = 0; i < Properties.Count; i++)
                props[i] = TypeMaps.WeaponPropertyNames[Properties[i]];

            return new APIWeapon(
                Name, category, RangeString,
                DamageDicePrimary, DamageDiceSecondary, DamageType,
                Range.Normal, Range.Long, ThrownRange.Normal,
                ThrownRange.Long, Weight, CostValue,
                CostUnit, Description, props,
                Special
            );
        }


        /********************
            WeaponRange
        ********************/
        public struct WeaponRange
        {
            public int Normal { get; private set; }
            public int Long { get; private set; }

            public WeaponRange(int normalRange = 0, int longRange = 0)
            {
                Normal = normalRange;
                Long = longRange;
            }
        }
    }


    /********************
        Tool
    ********************/
    public class Tool : Equipment
    {
        // Properties
        public ToolCategory ToolCategory { get; set; }


        //
        //  Constructor
        //  (from custom data)
        //
        public Tool(
            string name, ToolCategory category, int weight,
            string[] desc, int value = 0, string unit = ""
        )
            : base(name, EquipmentCategory.Tool, weight, value, unit, desc)
        {
            ToolCategory = category;
        }

        //
        //  Constructor
        //  (from APIReference)
        //
        public Tool(APITool obj) : base(obj)
        {
            ToolCategory = TypeMaps.GetValueFromName(obj.tool_category, TypeMaps.ToolCategoryNames);
        }

        //
        //  Copy Constructor
        //
        public Tool(Tool tool) : base(tool)
        {
            ToolCategory = tool.ToolCategory;
        }


        //
        //  ToAPIObject
        //
        public override APITool ToAPIObject()
        {
            return new APITool(Name, TypeMaps.ToolCategoryNames[ToolCategory], Weight, CostValue, CostUnit, Description);
        }
    }


    /********************
        Gear
    ********************/
    public class Gear : Equipment
    {
        // Properties
        public GearCategory GearCategory { get; set; }


        //
        //  Constructor
        //  (from custom data)
        //
        public Gear(
            string name, GearCategory category, int weight,
            string[] desc, int value = 0, string unit = ""
        )
            : base(name, EquipmentCategory.Gear, weight, value, unit, desc)
        {
            GearCategory = category;
            if (GearCategory == GearCategory.EquipmentPack)
                IsContainer = true;
        }

        //
        //  Constructor
        //  (from APIReference)
        //
        public Gear(APIGear obj) : base(obj)
        {
            GearCategory = TypeMaps.GetValueFromName(obj.gear_category.name, TypeMaps.GearCategoryNames);
            if (GearCategory == GearCategory.EquipmentPack)
                IsContainer = true;
        }

        //
        //  Copy Constructor
        //
        public Gear(Gear gear) : base(gear)
        {
            GearCategory = gear.GearCategory;
        }


        //
        //  ToAPIObject
        //
        public override APIGear ToAPIObject()
        {
            return new APIGear(Name, TypeMaps.GearCategoryNames[GearCategory], Weight, CostValue, CostUnit, Description);
        }
    }
}
