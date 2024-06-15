/*********************************************************
 *  
 *  Name:       Classes/ClassCreateForm.cs
 *  
 *  Purpose:    Dialog for creating a custom class
 *  
 *  Author:     CS
 *  
 *  Created:    01/04/2024
 * 
 *********************************************************/

using DND;
using DND.API;
using DND.Types;

namespace CharacterManager
{
    public partial class ClassCreateForm : Form
    {
        private List<Spell> _spellList;


        //
        //  Constructor
        //
        public ClassCreateForm()
        {
            InitializeComponent();
            EnableSpellcasting(false);

            _spellList = new List<Spell>();

            hitDiceComboBox.SelectedIndex = 0;
        }


        //
        //  EnableSpellcasting
        //
        private void EnableSpellcasting(bool enable)
        {
            int h = spellLabel.Height + spellAbilityComboBox.Height;

            if (spellcasterCheck.Checked)
                Size = new Size(Width, Height + h);
            else
                Size = new Size(Width, Height - h);

            spellLabel.Enabled = enable;
            spellLabel.Visible = enable;
            spellAbilityLabel.Enabled = enable;
            spellAbilityLabel.Visible = enable;
            spellAbilityComboBox.Enabled = enable;
            spellAbilityComboBox.Visible = enable;
            //spellListLabel.Enabled = enable;
            //spellListLabel.Visible = enable;
            //spellListComboBox.Enabled = enable;
            //spellListComboBox.Visible = enable;
            spellListBtn.Enabled = enable;
            spellListBtn.Visible = enable;

            spellAbilityComboBox.SelectedIndex = 3;
            spellListComboBox.SelectedIndex = spellListComboBox.Items.Count - 1;
        }

        //
        //  spellcasterCheck_CheckedChanged
        //
        private void spellcasterCheck_CheckedChanged(object sender, EventArgs e)
        {
            EnableSpellcasting(spellcasterCheck.Checked);
        }

        //
        //  spellListBtn_Click
        //
        private void spellListBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (var form = new SpellBrowserForm(BrowserType.Select, _spellList.ToArray()))
            {
                Cursor = Cursors.Default;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    foreach (var spell in form.GetSelectedSpells())
                        _spellList.Add(spell);

                    spellListComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    spellListComboBox.Text = "Custom";
                }
            }
        }

        //
        //  okBtn_Click
        //
        private void okBtn_Click(object sender, EventArgs e)
        {
            int i;
            int hitDie;
            int choose;
            string name;
            Skill[] skills;
            Ability[] saves;
            ArmourType[] armour;
            WeaponType[] weapons;
            ToolOrKit[] tools;
            string[]? spells;
            Ability spellAbility;

            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Class name required.", "Create Class");
                return;
            }

            if (APIReadWrite.GetClass(nameTextBox.Text) != null)
            {
                MessageBox.Show("A class already exists with that name.", "Create Class");
                return;
            }

            Cursor = Cursors.WaitCursor;

            name = nameTextBox.Text;

            if (hitDiceComboBox.Text == "d4")
                hitDie = 4;
            else if (hitDiceComboBox.Text == "d6")
                hitDie = 6;
            else if (hitDiceComboBox.Text == "d8")
                hitDie = 8;
            else if (hitDiceComboBox.Text == "d10")
                hitDie = 10;
            else if (hitDiceComboBox.Text == "d12")
                hitDie = 12;
            else if (hitDiceComboBox.Text == "d20")
                hitDie = 20;
            else
                hitDie = 0;

            choose = (int)skillChooseNumCtrl.Value;

            skills = new Skill[skillCheckList.CheckedIndices.Count];
            for (i = 0; i < skillCheckList.CheckedIndices.Count; i++)
            {
                Skill skill = (Skill)(skillCheckList.CheckedIndices[i] + 1);
                if (TypeMaps.SkillNames.Keys.Contains(skill))
                    skills[i] = skill;
            }

            saves = new Ability[savingThrowCheckList.CheckedIndices.Count];
            for (i = 0; i < savingThrowCheckList.CheckedIndices.Count; i++)
            {
                Ability ability = (Ability)(savingThrowCheckList.CheckedIndices[i] + 1);
                if (TypeMaps.AbilityNames.Keys.Contains(ability))
                    saves[i] = ability;
            }

            armour = new ArmourType[armourCheckList.CheckedIndices.Count];
            for (i = 0; i < armourCheckList.CheckedIndices.Count; i++)
            {
                switch (armourCheckList.CheckedIndices[i])
                {
                    case 0:
                        armour[i] = ArmourType.LightArmour;
                        break;
                    case 1:
                        armour[i] = ArmourType.MediumArmour;
                        break;
                    case 2:
                        armour[i] = ArmourType.HeavyArmour;
                        break;
                    case 3:
                        armour[i] = ArmourType.Shield;
                        break;
                    default:
                        armour[i] = ArmourType.None;
                        break;
                }
            }

            weapons = new WeaponType[weaponTypeCheckList.CheckedIndices.Count + weaponCheckList.CheckedIndices.Count];

            i = 0;
            foreach (int index in weaponTypeCheckList.CheckedIndices)
            {
                switch (index)
                {
                    case 0:
                        weapons[i] = WeaponType.SimpleWeapons;
                        break;
                    case 1:
                        weapons[i] = WeaponType.MartialWeapons;
                        break;
                    default:
                        weapons[i] = WeaponType.None;
                        break;
                }

                i++;
            }

            foreach (int index in weaponCheckList.CheckedIndices)
            {
                WeaponType weapon = (WeaponType)(index + 3);
                if (TypeMaps.WeaponCategoryNames.Keys.Contains(weapon))
                    weapons[i] = weapon;

                i++;
            }

            tools = new ToolOrKit[toolCheckList.CheckedIndices.Count];
            for (i = 0; i < toolCheckList.CheckedIndices.Count; i++)
            {
                ToolOrKit tool = (ToolOrKit)(toolCheckList.CheckedIndices[i] + 1);
                if (TypeMaps.ToolNames.Keys.Contains(tool))
                    tools[i] = tool;
            }

            spellAbility = Ability.None;
            spells = null;
            if (spellcasterCheck.Checked)
            {
                /*if (spellListComboBox.Text == "Custom")
                {
                    spells = _spellList.ToArray();
                }
                else
                {
                    var tempClass = APIReadWrite.GetClass(spellListComboBox.Text);
                    if (tempClass != null)
                        spells = tempClass.SpellList.ToArray();
                }

                foreach (var ability in TypeMaps.AbilityNames.Keys)
                {
                    if (spellAbilityComboBox.Text == TypeMaps.AbilityNames[ability])
                    {
                        spellAbility = ability;
                        break;
                    }
                }*/

                spells = new string[_spellList.Count];
                for (i = 0; i < _spellList.Count; i++)
                    spells[i] = _spellList[i].Name;

                spellAbility = TypeMaps.GetValueFromName(spellAbilityComboBox.Text, TypeMaps.AbilityNames);
            }

            Class newClass = new Class(name, hitDie, choose, skills, saves, armour, weapons, tools, spellAbility, spells);
            int errors = APIReadWrite.SaveCustomClass(newClass);

            Cursor = Cursors.Default;

            string msg;
            if (errors == 0)
                msg = string.Format("{0} created successfully", name);
            else
                msg = string.Format("Errors occurred in creating {0}", name);

            MessageBox.Show(msg, "D&D Character Manager");

            DialogResult = DialogResult.OK;
            Close();
        }

        //
        //  cancelBtn_Click
        //
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
