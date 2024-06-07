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
                    case ArmourType.LightArmour:    armourCheckList.SetItemChecked(0, true); break;
                    case ArmourType.MediumArmour:   armourCheckList.SetItemChecked(1, true); break;
                    case ArmourType.HeavyArmour:    armourCheckList.SetItemChecked(2, true); break;
                    case ArmourType.Shield:         armourCheckList.SetItemChecked(3, true); break;
                    default:
                        break;
                }
            }

            var vehicles = Session.Player.GetVehicleProficiencyList();
            foreach(var vehicle in vehicles)
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

                strCheckBox.Checked = primary.SavingThrows.Contains(Ability.Strength);
                dexCheckBox.Checked = primary.SavingThrows.Contains(Ability.Dexterity);
                conCheckBox.Checked = primary.SavingThrows.Contains(Ability.Constitution);
                intCheckBox.Checked = primary.SavingThrows.Contains(Ability.Intelligence);
                wisCheckBox.Checked = primary.SavingThrows.Contains(Ability.Wisdom);
                chaCheckBox.Checked = primary.SavingThrows.Contains(Ability.Charisma);
            }
            else
            {
                primaryClassLabel.Text = string.Empty;

                strCheckBox.Checked = false;
                dexCheckBox.Checked = false;
                conCheckBox.Checked = false;
                intCheckBox.Checked = false;
                wisCheckBox.Checked = false;
                chaCheckBox.Checked = false;
            }
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
                case 0: type = ArmourType.LightArmour;  break;
                case 1: type = ArmourType.MediumArmour; break;
                case 2: type = ArmourType.HeavyArmour;  break;
                case 3: type = ArmourType.Shield;       break;
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
    }
}
