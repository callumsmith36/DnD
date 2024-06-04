using DND.API;
using DND.Types;

namespace DND
{
    public class Attack : IEquatable<Attack>
    {
        public enum AttackType
        {
            None,
            AttackRoll, SavingThrow
        }

        // Properties
        public string       Name            { get; }
        public string       Index           { get; }
        public AttackType   Type            { get; }
        public Ability      Ability         { get; }
        public bool         IsSpellAttack   { get; }
        public int          WeaponBonus     { get; }
        public bool         Proficiency     { get; }
        public string       DamageDice      { get; }
        public Ability      DamageAbility   { get; }
        public int          DamageBonus     { get; }


        //
        //  Constructor
        //  (from custom data)
        //
        public Attack(string name, AttackType type, bool isSpellAttack,
            Ability ability, int weaponBonus, bool proficient,
            string dmgDice, Ability dmgAbility, int dmgBonus)
        {
            Name = name;
            Index = APIReadWrite.NameToIndex(name);
            Type = type;
            IsSpellAttack = isSpellAttack;
            Ability = ability;
            WeaponBonus = weaponBonus;
            Proficiency = proficient;
            DamageDice = dmgDice;
            DamageAbility = dmgAbility;
            DamageBonus = dmgBonus;
        }

        //
        //  Constructor
        //  (from APIAttack)
        //
        public Attack(APIAttack attack)
        {
            Name = attack.name;
            Index = attack.index;
            Type = (AttackType)attack.type;
            IsSpellAttack = attack.spell_attack;
            Ability = (Ability)attack.bonus_ability;
            WeaponBonus = attack.weapon_bonus;
            Proficiency = attack.proficiency;
            DamageDice = attack.damage_dice;
            DamageAbility = (Ability)attack.damage_ability;
            DamageBonus = attack.damage_bonus;
        }

        //
        //  Copy Constructor
        //
        public Attack(Attack other)
        {
            Name = other.Name;
            Index = other.Index;
            Type = other.Type;
            IsSpellAttack = other.IsSpellAttack;
            Ability = other.Ability;
            WeaponBonus = other.WeaponBonus;
            Proficiency = other.Proficiency;
            DamageDice = other.DamageDice;
            DamageAbility = other.DamageAbility;
            DamageBonus = other.DamageBonus;
        }


        //
        //  ToAPIObject
        //
        public APIAttack ToAPIObject()
        {
            return new APIAttack(
                Name, Index, (int)Type,
                IsSpellAttack, (int)Ability, WeaponBonus,
                Proficiency, DamageDice, (int)DamageAbility,
                DamageBonus
            );
        }


        //
        //  == operator
        //
        public static bool operator ==(Attack? a, Attack? b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);

            return a.Equals(b);
        }

        //
        //  != operator
        //
        public static bool operator !=(Attack? a, Attack? b)
        {
            return !(a == b);
        }

        //
        //  Equals
        //
        public bool Equals(Attack? other)
        {
            if (ReferenceEquals(this, other))
                return true;

            if (ReferenceEquals(other, null))
                return false;

            return
                Name == other.Name &&
                Index == other.Index &&
                Type == other.Type &&
                IsSpellAttack == other.IsSpellAttack &&
                Ability == other.Ability &&
                WeaponBonus == other.WeaponBonus &&
                Proficiency == other.Proficiency &&
                DamageDice == other.DamageDice &&
                DamageAbility == other.DamageAbility &&
                DamageBonus == other.DamageBonus;
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

            if (obj is not Attack)
                return false;

            return Equals(obj as Attack);
        }

        //
        //  GetHashCode
        //
        public override int GetHashCode()
        {
            return Index.GetHashCode();
        }
    }
}
