using DND.API;
using DND.Types;

namespace DND
{
    partial class PlayerCharacter
    {
        //
        //  GetSpellcastingModifier
        //
        public int GetSpellcastingModifier()
        {
            if (SpellcastingAbility == Ability.None)
                return 0;
            else
                return GetAbilityModifier(_abilityScoreMap[SpellcastingAbility]) + ProficiencyBonus;
        }

        //
        //  GetSpellcastingModifier
        //
        public int GetSpellcastingModifier(string className)
        {
            int mod = 0;
            Ability ability;

            var c = GetClass(className);
            if (c != null)
            {
                ability = c.SpellcastingAbility;
                mod = GetAbilityModifier(_abilityScoreMap[ability]) + ProficiencyBonus;
            }

            return mod;
        }

        //
        //  GetSpellSaveDC
        //
        public int GetSpellSaveDC()
        {
            return 8 + GetSpellcastingModifier();
        }

        //
        //  GetSpellSaveDC
        //
        public int GetSpellSaveDC(string className)
        {
            return 8 + GetSpellcastingModifier(className);
        }

        //
        //  GetNumSpellSlotsRemaining
        //
        public int GetNumSpellSlotsRemaining(int level)
        {
            if (level == 0)
                return 1;

            if (level < 1 || level > 9)
                return 0;

            return _spellSlotsLeft[level - 1];
        }

        //
        //  SetNumSpellSlotsRemaining
        //
        public void SetNumSpellSlotsRemaining(int level, int n)
        {
            if (level < 1 || level > 9)
                return;

            if (n < 0 || n > _spellSlotsMax[level - 1])
                return;

            _spellSlotsLeft[level - 1] = n;
        }

        //
        //  GetNumSpellSlotsMax
        //
        public int GetNumSpellSlotsMax(int level)
        {
            if (level < 1 || level > 9)
                return 0;

            return _spellSlotsMax[level - 1];
        }

        //
        //  SetNumSpellSlotsMax
        //
        public void SetNumSpellSlotsMax(int level, int n)
        {
            if (level < 1 || level > 9 || n < 0)
                return;

            _spellSlotsMax[level - 1] = n;
        }

        //
        //  GetHighestSpellLevel
        //
        public int GetHighestSpellLevel()
        {
            int level = 0;

            for (int i = 8; i >= 0; i--)
            {
                if (_spellSlotsMax[i] > 0)
                {
                    level = i + 1;
                    break;
                }
            }

            return level;
        }

        //
        //  GetPreparedSpells
        //
        public Spell[] GetPreparedSpells(int level)
        {
            return _preparedSpells[level].ToArray();
        }

        //
        //  AddPreparedSpell
        //
        public bool AddPreparedSpell(Spell spell)
        {
            if (spell == null)
                return false;

            foreach (var s in _preparedSpells[spell.Level])
            {
                if (s.Index == spell.Index)
                    return false;
            }

            _preparedSpells[spell.Level].Add(spell);
            OnPreparedSpellsChanged?.Invoke();
            return true;
        }

        //
        //  AddPreparedSpell
        //
        public bool AddPreparedSpell(string name)
        {
            Spell? spell;
            if ((spell = APIReadWrite.GetSpell(name)) != null)
                return AddPreparedSpell(spell);

            return false;
        }

        //
        //  RemovePreparedSpell
        //
        public bool RemovePreparedSpell(int level, string name)
        {
            bool result = false;

            if (level >= 0 && level <= 9)
            {
                string index = APIReadWrite.NameToIndex(name);
                foreach (var spell in _preparedSpells[level])
                {
                    if (spell.Index == index)
                    {
                        result = _preparedSpells[level].Remove(spell);
                        OnPreparedSpellsChanged?.Invoke();
                        break;
                    }
                }
            }

            return result;
        }

        //
        //  ClearPreparedSpells
        //
        public void ClearPreparedSpells(int level)
        {
            if (level >= 0 && level <= 9)
            {
                _preparedSpells[level].Clear();
                OnPreparedSpellsChanged?.Invoke();
            }
        }

        //
        //  ChangePreparedSpells
        //
        public void ChangePreparedSpells(Spell[] spells)
        {
            for (int i = 0; i < 10; i++)
                _preparedSpells[i].Clear();

            foreach (var spell in spells)
            {
                if (spell != null)
                    _preparedSpells[spell.Level].Add(spell);
            }

            OnPreparedSpellsChanged?.Invoke();
        }

        //
        //  CastSpell
        //
        public int CastSpell(Spell spell, bool ritual = false)
        {
            if (spell == null || spell.Level < 0 || spell.Level > 9)
                return 1;

            if (!ritual)
            {
                if (spell.Level > 0)
                {
                    if (_spellSlotsLeft[spell.Level - 1] == 0)
                        return 1;

                    _spellSlotsLeft[spell.Level - 1]--;
                }
            }

            if (spell.IsConcentration)
            {
                IsConcentrating = true;
                ConcentratingOn = spell.Name;
            }

            OnSpellCast?.Invoke();
            return 0;
        }

        //
        //  CastSpell
        //
        public int CastSpell(Spell spell, int level)
        {
            if (spell == null)
                return 1;

            if (level > 0 && _spellSlotsLeft[level - 1] == 0)
                return 1;

            if (spell.Level != level)
            {
                if (spell == null || level < 0 || level > 9)
                    return 1;

                if (level > spell.Level && spell.HigherLevel.Length == 0)
                    return 1;
            }

            if (spell.IsConcentration)
            {
                IsConcentrating = true;
                ConcentratingOn = spell.Name;
            }

            if (level > 0)
                _spellSlotsLeft[level - 1]--;

            OnSpellCast?.Invoke();
            return 0;
        }
    }
}
