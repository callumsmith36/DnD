using DND.API;
using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class WeaponCreateForm : Form
    {
        private List<WeaponProperty>    _selectedProps;
        private Weapon?                 _weapon;


        //
        //  Constructor
        //
        public WeaponCreateForm()
        {
            InitializeComponent();
            _selectedProps = new List<WeaponProperty>();
            _weapon = null;

            costUnitComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndex = 0;
            rangeComboBox.SelectedIndex = 0;
            dmgDicePrimaryComboBox.SelectedIndex = 0;
            dmgDiceSecondaryComboBox.SelectedIndex = 0;
            dmgTypeComboBox.SelectedIndex = 0;

            EnableSpecial(false);
        }


        //
        //  EnableSpecial
        //
        private void EnableSpecial(bool enable = true)
        {
            int heightDiff = specialLabel.Height + specialTextBox.Height + 10;

            if (enable == true && !specialTextBox.Enabled)
            {
                specialLabel.Enabled = true;
                specialLabel.Visible = true;
                specialTextBox.Enabled = true;
                specialTextBox.Visible = true;

                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                Size = new Size(Width, Height + heightDiff);
                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height + heightDiff);
            }
            else if (enable == false && specialTextBox.Enabled)
            {
                specialLabel.Enabled = false;
                specialLabel.Visible = false;
                specialTextBox.Enabled = false;
                specialTextBox.Visible = false;

                MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height - heightDiff);

                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                Size = new Size(Width, Height - heightDiff);
                descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
        }
        
        //
        //  GetWeapon
        //
        public Weapon? GetWeapon()
        {
            return _weapon;
        }


        //
        //  rangeComboBox_SelectedIndexChanged
        //
        private void rangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rangeComboBox.Text.ToLower() == "melee")
            {
                slash1.Enabled = false;
                slash1.Visible = false;
                rangeLongTextBox.Enabled = false;
                rangeLongTextBox.Visible = false;
            }
            else if (rangeComboBox.Text.ToLower() == "ranged")
            {
                slash1.Enabled = true;
                slash1.Visible = true;
                rangeLongTextBox.Enabled = true;
                rangeLongTextBox.Visible = true;
            }
        }

        //
        //  propCheckList_ItemCheck
        //
        private void propCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            WeaponProperty prop = (WeaponProperty)(e.Index + 1);
            bool isChecked = e.NewValue == CheckState.Checked;

            if (isChecked)
                _selectedProps.Add(prop);
            else
                _selectedProps.Remove(prop);

            if (prop == WeaponProperty.Thrown)
            {
                thrownLabel.Enabled = isChecked;
                thrownLabel.Visible = isChecked;
                thrownNormalTextBox.Enabled = isChecked;
                thrownNormalTextBox.Visible = isChecked;
                slash2.Enabled = isChecked;
                slash2.Visible = isChecked;
                thrownLongTextBox.Enabled = isChecked;
                thrownLongTextBox.Visible = isChecked;
            }
            else if (prop == WeaponProperty.Versatile)
            {
                dmgDice2Label.Enabled = isChecked;
                dmgDice2Label.Visible = isChecked;
                dmgNumSecondaryTextBox.Enabled = isChecked;
                dmgNumSecondaryTextBox.Visible = isChecked;
                dmgDiceSecondaryComboBox.Enabled = isChecked;
                dmgDiceSecondaryComboBox.Visible = isChecked;
            }
            else if (prop == WeaponProperty.Special)
            {
                EnableSpecial(isChecked);
            }
        }

        //
        //  textBox_CheckIntegerInput
        //
        private void textBox_CheckIntegerInput(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
                Utility.CheckNumericInput(false, textBox, e);
        }

        //
        //  textBox_CheckDecimalInput
        //
        private void textBox_CheckDecimalInput(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
                Utility.CheckNumericInput(true, textBox, e);
        }

        //
        //  okBtn_Click
        //
        private void okBtn_Click(object sender, EventArgs e)
        {
            int costValue = 0;
            int dmgNumPrimary = 0;
            int dmgNumSecondary = 0;
            int rangeNormal = 0;
            int rangeLong = 0;
            int thrownNormal = 0;
            int thrownLong = 0;

            float weight = 0f;

            string name;
            string costUnit;
            string categoryStr;
            string rangeStr;
            string dmgType;
            string dmgDicePrimary;
            string dmgDiceSecondary;

            name = nameTextBox.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Name is required.", "D&D Character Manager");
                return;
            }

            if (dmgNumPrimaryTextBox.Text.Length == 0)
            {
                MessageBox.Show("Damage dice field is required.", "D&D Character Manager");
                return;
            }

            if (dmgNumSecondaryTextBox.Enabled && dmgNumSecondaryTextBox.Text.Length == 0)
            {
                MessageBox.Show("Versatile damage dice field is required.", "D&D Character Manager");
                return;
            }

            if (rangeNormalTextBox.Text.Length == 0)
            {
                MessageBox.Show("Normal range field is required.", "D&D Character Manager");
                return;
            }

            if (rangeLongTextBox.Enabled && rangeLongTextBox.Text.Length == 0)
            {
                MessageBox.Show("Long range field is required.", "D&D Character Manager");
                return;
            }

            if (thrownNormalTextBox.Enabled && thrownNormalTextBox.Text.Length == 0)
            {
                MessageBox.Show("Normal thrown range field is required.", "D&D Character Manager");
                return;
            }

            if (thrownLongTextBox.Enabled && thrownLongTextBox.Text.Length == 0)
            {
                MessageBox.Show("Long thrown range field is required.", "D&D Character Manager");
                return;
            }

            if (APIReadWrite.CheckEquipmentExists(name) || APIReadWrite.CheckMagicItemExists(name))
            {
                MessageBox.Show("An item already exists with that index.", "D&D Character Manager");
                return;
            }

            if (costUnitComboBox.SelectedIndex == -1)
                costUnitComboBox.SelectedIndex = 0;

            costUnit = costUnitComboBox.SelectedItem.ToString();

            if (categoryComboBox.SelectedIndex == -1)
                categoryComboBox.SelectedIndex = 0;

            categoryStr = categoryComboBox.SelectedItem.ToString();

            if (rangeComboBox.SelectedIndex == -1)
                rangeComboBox.SelectedIndex = 0;

            rangeStr = rangeComboBox.SelectedItem.ToString();

            if (dmgTypeComboBox.SelectedIndex == -1)
                dmgTypeComboBox.SelectedIndex = 0;

            dmgType = dmgTypeComboBox.SelectedItem.ToString();

            if (dmgDicePrimaryComboBox.SelectedIndex == -1)
                dmgDicePrimaryComboBox.SelectedIndex = 0;

            dmgDicePrimary = dmgDicePrimaryComboBox.SelectedItem.ToString();

            if (dmgDiceSecondaryComboBox.Enabled)
            {
                if (dmgDiceSecondaryComboBox.SelectedIndex == -1)
                    dmgDiceSecondaryComboBox.SelectedIndex = 0;

                dmgDiceSecondary = dmgDiceSecondaryComboBox.SelectedItem.ToString();
            }
            else
            {
                dmgDiceSecondary = string.Empty;
            }

            if (costValueTextBox.Text.Length > 0)
                int.TryParse(costValueTextBox.Text, out costValue);

            if (weightTextBox.Text.Length > 0)
                float.TryParse(weightTextBox.Text, out weight);

            int.TryParse(dmgNumPrimaryTextBox.Text, out dmgNumPrimary);

            if (dmgNumSecondaryTextBox.Enabled)
                int.TryParse(dmgNumSecondaryTextBox.Text, out dmgNumSecondary);

            int.TryParse(rangeNormalTextBox.Text, out rangeNormal);

            if (rangeLongTextBox.Enabled)
                int.TryParse(rangeLongTextBox.Text, out rangeLong);

            if (thrownNormalTextBox.Enabled)
                int.TryParse(thrownNormalTextBox.Text, out thrownNormal);

            if (thrownLongTextBox.Enabled)
                int.TryParse(thrownLongTextBox.Text, out thrownLong);

            List<string> descLines = new List<string>();
            foreach (var line in descTextBox.Lines)
            {
                if (line.Length > 0)
                    descLines.Add(line);
            }

            List<string> specialLines = new List<string>();
            if (specialTextBox.Enabled)
            {
                foreach (var line in specialTextBox.Lines)
                {
                    if (line.Length > 0)
                        specialLines.Add(line);
                }
            }

            WeaponType type = (WeaponType)(categoryComboBox.SelectedIndex + 1);

            Weapon.WeaponRange range = new Weapon.WeaponRange(rangeNormal, rangeLong);
            Weapon.WeaponRange thrownRange = new Weapon.WeaponRange(thrownNormal, thrownLong);

            string dmgPrimary = string.Format("{0}{1}", dmgNumPrimary, dmgDicePrimary);
            string dmgSecondary = dmgDiceSecondaryComboBox.Enabled ? string.Format("{0}{1}", dmgNumSecondary, dmgDiceSecondary) : string.Empty;

            _weapon = new Weapon(
                name,
                type,
                weight,
                rangeStr,
                range,
                thrownRange,
                dmgPrimary,
                dmgSecondary,
                dmgType,
                descLines.ToArray(),
                specialLines.ToArray(),
                _selectedProps.ToArray(),
                costValue,
                costUnit
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
