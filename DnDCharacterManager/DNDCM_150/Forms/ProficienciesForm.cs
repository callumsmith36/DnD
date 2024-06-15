/*********************************************************
 *  
 *  Name:       ProficienciesForm.cs
 *  
 *  Purpose:    Dialog for setting saving throws and
 *              proficiencies
 *  
 *  Author:     CS
 *  
 *  Created:    27/04/2024
 * 
 *********************************************************/

using DND;
using DND.Types;

namespace CharacterManager
{
    public partial class ProficienciesForm : Form
    {
        public static Action? OnWeaponChanged;
        public static Action? OnArmourChanged;
        public static Action? OnLanguageChanged;
        public static Action? OnToolChanged;
        public static Action? OnVehicleChanged;


        //
        //  Constructor
        //
        public ProficienciesForm()
        {
            InitializeComponent();
            UpdateSavingThrowTab();

            var profList = Session.Player.GetSkillProficiencyList();
            var expertList = Session.Player.GetSkillExpertiseList();
            foreach (var ctrl in skillTab.Controls)
            {
                SkillProfCtrl? skillCtrl = ctrl as SkillProfCtrl;
                if (skillCtrl != null)
                {
                    if (profList.Contains(skillCtrl.Skill))
                        skillCtrl.IsProficient = true;

                    if (expertList.Contains(skillCtrl.Skill))
                        skillCtrl.IsExpert = true;
                }
            }

            var tools = Session.Player.GetToolProficiencyList();
            foreach (var tool in tools)
            {
                int index = (int)tool - 1;
                if (index < 0 || index >= toolCheckList.Items.Count)
                    continue;

                toolCheckList.SetItemChecked(index, true);
            }

            var weapons = Session.Player.GetWeaponProficiencyList();
            foreach (var weapon in weapons)
            {
                if (weapon == WeaponType.SimpleWeapons)
                {
                    weaponTypeCheckList.SetItemChecked(0, true);
                }
                else if (weapon == WeaponType.MartialWeapons)
                {
                    weaponTypeCheckList.SetItemChecked(1, true);
                }
                else
                {
                    int index = (int)weapon - 3;
                    if (index < 0 || index >= weaponCheckList.Items.Count)
                        continue;

                    weaponCheckList.SetItemChecked(index, true);
                }
            }

            var armourList = Session.Player.GetArmourProficiencyList();
            foreach (var armour in armourList)
            {
                switch (armour)
                {
                    case ArmourType.LightArmour: armourCheckList.SetItemChecked(0, true); break;
                    case ArmourType.MediumArmour: armourCheckList.SetItemChecked(1, true); break;
                    case ArmourType.HeavyArmour: armourCheckList.SetItemChecked(2, true); break;
                    case ArmourType.Shield: armourCheckList.SetItemChecked(3, true); break;
                    default:
                        break;
                }
            }

            var vehicles = Session.Player.GetVehicleProficiencyList();
            foreach (var vehicle in vehicles)
            {
                if (vehicle == Vehicle.Land)
                    vehicleCheckList.SetItemChecked(0, true);
                else if (vehicle == Vehicle.Water)
                    vehicleCheckList.SetItemChecked(1, true);
            }

            var languages = Session.Player.GetLanguageList();
            foreach (var language in languages)
            {
                int index = (int)language - 1;
                if (index < 0 || index >= languageCheckList.Items.Count)
                    continue;

                languageCheckList.SetItemChecked(index, true);
            }

            Session.Player.OnPrimaryClassChanged += UpdateSavingThrowTab;
        }


        //
        //  UpdateSavingThrowTab
        //
        private void UpdateSavingThrowTab()
        {
            Class? primary = Session.Player.GetPrimaryClass();
            if (primary != null)
            {
                primaryClassLabel.Text = primary.Name;

                strCheckBox.Enabled = !primary.SavingThrows.Contains(Ability.Strength);
                dexCheckBox.Enabled = !primary.SavingThrows.Contains(Ability.Dexterity);
                conCheckBox.Enabled = !primary.SavingThrows.Contains(Ability.Constitution);
                intCheckBox.Enabled = !primary.SavingThrows.Contains(Ability.Intelligence);
                wisCheckBox.Enabled = !primary.SavingThrows.Contains(Ability.Wisdom);
                chaCheckBox.Enabled = !primary.SavingThrows.Contains(Ability.Charisma);
            }
            else
            {
                primaryClassLabel.Text = string.Empty;
            }

            var savingThrows = Session.Player.GetSavingThrowList();
            strCheckBox.Checked = savingThrows.Contains(Ability.Strength);
            dexCheckBox.Checked = savingThrows.Contains(Ability.Dexterity);
            conCheckBox.Checked = savingThrows.Contains(Ability.Constitution);
            intCheckBox.Checked = savingThrows.Contains(Ability.Intelligence);
            wisCheckBox.Checked = savingThrows.Contains(Ability.Wisdom);
            chaCheckBox.Checked = savingThrows.Contains(Ability.Charisma);
        }


        //
        //  toolCheckList_ItemCheck
        //
        private void toolCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ToolOrKit tool = (ToolOrKit)(e.Index + 1);
            if (e.NewValue == CheckState.Checked)
                Session.Player.AddToolProficiency(tool);
            else
                Session.Player.RemoveToolProficiency(tool);

            OnToolChanged?.Invoke();
        }

        //
        //  weaponTypeCheckList_ItemCheck
        //
        private void weaponTypeCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            WeaponType type = (WeaponType)(e.Index + 1);
            if (e.NewValue == CheckState.Checked)
                Session.Player.AddWeaponProficiency(type);
            else
                Session.Player.RemoveWeaponProficiency(type);

            OnWeaponChanged?.Invoke();
        }

        //
        //  weaponCheckList_ItemCheck
        //
        private void weaponCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            WeaponType type = (WeaponType)(e.Index + 3);
            if (e.NewValue == CheckState.Checked)
                Session.Player.AddWeaponProficiency(type);
            else
                Session.Player.RemoveWeaponProficiency(type);

            OnWeaponChanged?.Invoke();
        }

        //
        //  armourCheckList_ItemCheck
        //
        private void armourCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ArmourType type;
            switch (e.Index)
            {
                case 0: type = ArmourType.LightArmour; break;
                case 1: type = ArmourType.MediumArmour; break;
                case 2: type = ArmourType.HeavyArmour; break;
                case 3: type = ArmourType.Shield; break;
                default:
                    type = ArmourType.None;
                    break;
            }

            if (type != ArmourType.None)
            {
                if (e.NewValue == CheckState.Checked)
                    Session.Player.AddArmourProficiency(type);
                else
                    Session.Player.RemoveArmourProficiency(type);

                OnArmourChanged?.Invoke();
            }
        }

        //
        //  languageCheckList_ItemCheck
        //
        private void languageCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Language language = (Language)(e.Index + 1);
            if (e.NewValue == CheckState.Checked)
                Session.Player.AddLanguage(language);
            else
                Session.Player.RemoveLanguage(language);

            OnLanguageChanged?.Invoke();
        }

        //
        //  vehicleCheckList_ItemCheck
        //
        private void vehicleCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Vehicle vehicle;
            if (e.Index == 0)
                vehicle = Vehicle.Land;
            else if (e.Index == 1)
                vehicle = Vehicle.Water;
            else
                vehicle = Vehicle.None;

            if (e.NewValue == CheckState.Checked)
                Session.Player.AddVehicleProficiency(vehicle);
            else
                Session.Player.RemoveVehicleProficiency(vehicle);

            OnVehicleChanged?.Invoke();
        }

        //
        //  strCheckBox_CheckedChanged
        //
        private void strCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (strCheckBox.Checked)
                Session.Player.AddSavingThrow(Ability.Strength);
            else
                Session.Player.RemoveSavingThrow(Ability.Strength);
        }

        //
        //  dexCheckBox_CheckedChanged
        //
        private void dexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dexCheckBox.Checked)
                Session.Player.AddSavingThrow(Ability.Dexterity);
            else
                Session.Player.RemoveSavingThrow(Ability.Dexterity);
        }

        //
        //  conCheckBox_CheckedChanged
        //
        private void conCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (conCheckBox.Checked)
                Session.Player.AddSavingThrow(Ability.Constitution);
            else
                Session.Player.RemoveSavingThrow(Ability.Constitution);
        }

        //
        //  intCheckBox_CheckedChanged
        //
        private void intCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (intCheckBox.Checked)
                Session.Player.AddSavingThrow(Ability.Intelligence);
            else
                Session.Player.RemoveSavingThrow(Ability.Intelligence);
        }

        //
        //  wisCheckBox_CheckedChanged
        //
        private void wisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wisCheckBox.Checked)
                Session.Player.AddSavingThrow(Ability.Wisdom);
            else
                Session.Player.RemoveSavingThrow(Ability.Wisdom);
        }

        //
        //  chaCheckBox_CheckedChanged
        //
        private void chaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chaCheckBox.Checked)
                Session.Player.AddSavingThrow(Ability.Charisma);
            else
                Session.Player.RemoveSavingThrow(Ability.Charisma);
        }
    }
}
