using DND.Types;

namespace DND
{
    partial class PlayerCharacter
    {
        //
        //  AddProficiency
        //
        private void AddProficiency<T>(T prof, List<T> list, Action? OnAdded = null)
            where T : struct, Enum
        {
            if (!list.Contains(prof))
            {
                list.Add(prof);
                OnAdded?.Invoke();
            }
        }

        //
        //  RemoveProficiency
        //
        private bool RemoveProficiency<T>(T prof, List<T> list, Action? OnRemoved = null)
            where T : struct, Enum
        {
            if (list.Remove(prof) == true)
            {
                OnRemoved?.Invoke();
                return true;
            }

            return false;
        }

        //
        //  GetSavingThrowList
        //
        public Ability[] GetSavingThrowList()
        {
            return _savingThrows.ToArray();
        }

        //
        //  AddSavingThrow
        //
        public void AddSavingThrow(Ability ability)
        {
            if (ability != Ability.None)
                AddProficiency(ability, _savingThrows, OnSavingThrowsChanged);
        }

        //
        //  RemoveSavingThrow
        //
        public bool RemoveSavingThrow(Ability ability)
        {
            return RemoveProficiency(ability, _savingThrows, OnSavingThrowsChanged);
        }

        //
        //  GetSkillProficiencyList
        //
        public Skill[] GetSkillProficiencyList()
        {
            return _skillProficiencies.ToArray();
        }

        //
        //  AddSkillProficiency
        //
        public void AddSkillProficiency(Skill skill)
        {
            if (skill != Skill.None)
                AddProficiency(skill, _skillProficiencies, OnSkillProficienciesChanged);
        }

        //
        //  RemoveSkillProficiency
        //
        public bool RemoveSkillProficiency(Skill skill)
        {
            return RemoveProficiency(skill, _skillProficiencies, OnSkillProficienciesChanged);
        }

        //
        //  GetSkillExpertiseList
        //
        public Skill[] GetSkillExpertiseList()
        {
            return _skillExpertise.ToArray();
        }

        //
        //  AddSkillExpertise
        //
        public void AddSkillExpertise(Skill skill)
        {
            if (skill != Skill.None && _skillProficiencies.Contains(skill) == true)
                AddProficiency(skill, _skillExpertise, OnSkillProficienciesChanged);
        }

        //
        //  RemoveSkillExpertise
        //
        public bool RemoveSkillExpertise(Skill skill)
        {
            return RemoveProficiency(skill, _skillExpertise, OnSkillProficienciesChanged);
        }

        //
        //  GetToolProficiencyList
        //
        public ToolOrKit[] GetToolProficiencyList()
        {
            return _toolProficiencies.ToArray();
        }

        //
        //  AddToolProficiency
        //
        public void AddToolProficiency(ToolOrKit tool)
        {
            if (tool != ToolOrKit.None)
                AddProficiency(tool, _toolProficiencies, OnToolProficienciesChanged);
        }

        //
        //  RemoveToolProficiency
        //
        public bool RemoveToolProficiency(ToolOrKit tool)
        {
            return RemoveProficiency(tool, _toolProficiencies, OnToolProficienciesChanged);
        }

        //
        //  GetWeaponProficiencyList
        //
        public WeaponType[] GetWeaponProficiencyList()
        {
            return _weaponProficiencies.ToArray();
        }

        //
        //  AddWeaponProficiency
        //
        public void AddWeaponProficiency(WeaponType weapon)
        {
            if (weapon != WeaponType.None)
                AddProficiency(weapon, _weaponProficiencies, OnWeaponProficienciesChanged);
        }

        //
        //  RemoveWeaponProficiency
        //
        public bool RemoveWeaponProficiency(WeaponType weapon)
        {
            return RemoveProficiency(weapon, _weaponProficiencies, OnWeaponProficienciesChanged);
        }

        //
        //  GetArmourProficiencyList
        //
        public ArmourType[] GetArmourProficiencyList()
        {
            return _armourProficiencies.ToArray();
        }

        //
        //  AddArmourProficiency
        //
        public void AddArmourProficiency(ArmourType armour)
        {
            if (armour != ArmourType.None)
                AddProficiency(armour, _armourProficiencies, OnArmourProficienciesChanged);
        }

        //
        //  RemoveArmourProficiency
        //
        public bool RemoveArmourProficiency(ArmourType armour)
        {
            return RemoveProficiency(armour, _armourProficiencies, OnArmourProficienciesChanged);
        }

        //
        //  GetVehicleProficiencyList
        //
        public Vehicle[] GetVehicleProficiencyList()
        {
            return _vehicleProficiencies.ToArray();
        }

        //
        //  AddVehicleProficiency
        //
        public void AddVehicleProficiency(Vehicle vehicle)
        {
            if (vehicle != Vehicle.None)
                AddProficiency(vehicle, _vehicleProficiencies, OnVehicleProficienciesChanged);
        }

        //
        //  RemoveVehicleProficiency
        //
        public bool RemoveVehicleProficiency(Vehicle vehicle)
        {
            return RemoveProficiency(vehicle, _vehicleProficiencies, OnVehicleProficienciesChanged);
        }

        //
        //  GetLanguageList
        //
        public Language[] GetLanguageList()
        {
            return _languages.ToArray();
        }

        //
        //  AddLanguage
        //
        public void AddLanguage(Language language)
        {
            if (language != Language.None)
                AddProficiency(language, _languages, OnLanguagesChanged);
        }

        //
        //  RemoveLanguage
        //
        public bool RemoveLanguage(Language language)
        {
            return RemoveProficiency(language, _languages, OnLanguagesChanged);
        }
    }
}
