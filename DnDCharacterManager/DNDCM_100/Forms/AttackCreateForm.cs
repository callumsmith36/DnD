/*********************************************************
 *  
 *  Name:       AttackCreateForm.cs
 *  
 *  Purpose:    Dialog for adding an attack
 *  
 *  Author:     CS
 *  
 *  Created:    06/05/2024
 * 
 *********************************************************/

using DND;
using DND.Types;

namespace CharacterManager
{
    public partial class AttackCreateForm : Form
    {
        private readonly int _spellHeight;
        private readonly int _weaponHeight;

        private Attack? _attack;


        //
        //  Constructor
        //
        public AttackCreateForm()
        {
            InitializeComponent();
            _attack = null;

            _weaponHeight = Height;
            _spellHeight = Height - weaponAtkPanel.Height;

            savePanel.Enabled = false;
            savePanel.Visible = false;

            MinimumSize = new Size(Width, _spellHeight);
            MaximumSize = new Size(Width, _weaponHeight);

            saveAbilityComboBox.SelectedIndex = 0;
            weaponAbilityComboBox.SelectedIndex = 0;
            dmgDiceComboBox.SelectedIndex = 0;
            dmgAbilityComboBox.SelectedIndex = 0;
        }


        //
        //  GetAttack
        //
        public Attack? GetAttack()
        {
            return _attack;
        }


        //
        //  atkRollRadioBtn_CheckedChanged
        //
        private void atkRollRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (atkRollRadioBtn.Checked)
            {
                bonusLabel.Text = "Bonus";
                atkRollPanel.Enabled = true;
                atkRollPanel.Visible = true;
                Size = new Size(Width, weaponRadioBtn.Checked ? _weaponHeight : _spellHeight);

            }
            else
            {
                atkRollPanel.Enabled = false;
                atkRollPanel.Visible = false;
            }
        }

        //
        //  saveRadioBtn_CheckedChanged
        //
        private void saveRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (saveRadioBtn.Checked)
            {
                bonusLabel.Text = "Save";
                savePanel.Enabled = true;
                savePanel.Visible = true;
                Size = new Size(Width, _spellHeight);
            }
            else
            {
                savePanel.Enabled = false;
                savePanel.Visible = false;
            }
        }

        //
        //  weaponRadioBtn_CheckedChanged
        //
        private void weaponRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (weaponRadioBtn.Checked)
            {
                weaponAtkPanel.Enabled = true;
                weaponAtkPanel.Visible = true;
                Size = new Size(Width, _weaponHeight);
            }
            else
            {
                weaponAtkPanel.Enabled = false;
                weaponAtkPanel.Visible = false;
            }
        }

        //
        //  spellRadioBtn_CheckedChanged
        //
        private void spellRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (spellRadioBtn.Checked)
            {
                Size = new Size(Width, _spellHeight);
            }
        }

        //
        //  okBtn_Click
        //
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Name is required.", "D&D Character Manager");
                return;
            }

            if (Session.Player.GetAttack(name) != null)
            {
                MessageBox.Show("You already have an attack saved with that index.", "D&D Character Manager");
                return;
            }

            var type = atkRollRadioBtn.Checked ? Attack.AttackType.AttackRoll : Attack.AttackType.SavingThrow;
            bool isSpellAttack = atkRollRadioBtn.Checked && spellRadioBtn.Checked;

            Ability ability;
            int weaponBonus = 0;
            bool proficiency = true;
            string dmgDice;
            Ability dmgAbility;
            int dmgBonus;

            if (isSpellAttack)
            {
                ability = Session.Player.SpellcastingAbility;
            }
            else if (saveRadioBtn.Checked)
            {
                ability = (Ability)(saveAbilityComboBox.SelectedIndex + 1);
            }
            else
            {
                ability = (Ability)(weaponAbilityComboBox.SelectedIndex + 1);
                weaponBonus = (int)weaponBonusNumCtrl.Value;
                proficiency = weaponProfCheckBox.Checked;
            }

            dmgDice = dmgDiceNumCtrl.Value.ToString() + dmgDiceComboBox.Text;
            dmgAbility = (Ability)dmgAbilityComboBox.SelectedIndex;
            dmgBonus = (int)dmgModNumCtrl.Value;

            _attack = new Attack(
                name,
                type,
                isSpellAttack,
                ability,
                weaponBonus,
                proficiency,
                dmgDice,
                dmgAbility,
                dmgBonus
            );

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
