using DND.API;
using DND.InventorySystem;
using DND.Types;

namespace CharacterManager
{
    public partial class ArmourCreateForm : Form
    {
        private Armour? _armour;


        public ArmourCreateForm()
        {
            InitializeComponent();

            costUnitComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndex = 0;
        }


        public Armour? GetArmour()
        {
            return _armour;
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
            int baseAC = 0;
            int maxBonus = 0;
            int minStr = 0;

            float weight = 0f;

            string name;
            string costUnit;
            string category;

            bool dexBonus = false;
            bool disadvantage = false;

            name = nameTextBox.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Name is required.", "D&D Character Manager");
                return;
            }

            if (acTextBox.Text.Length == 0)
            {
                MessageBox.Show("Base AC field is required.", "D&D Character Manager");
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

            if (weightTextBox.Text.Length > 0)
                float.TryParse(weightTextBox.Text, out weight);

            int.TryParse(acTextBox.Text, out baseAC);

            dexBonus = dexCheckBox.Checked;
            maxBonus = maxBonusCheckBox.Checked ? (int)maxBonusNumCtrl.Value : 0;
            minStr = minStrCheckBox.Checked ? (int)minStrNumCtrl.Value : 0;
            disadvantage = stealthCheckBox.Checked;

            List<string> descLines = new List<string>();
            foreach (var line in descTextBox.Lines)
            {
                if (line.Length > 0)
                    descLines.Add(line);
            }

            ArmourType type;
            switch (categoryComboBox.Text.ToLower())
            {
                case "light":   type = ArmourType.LightArmour;  break;
                case "medium":  type = ArmourType.MediumArmour; break;
                case "heavy":   type = ArmourType.HeavyArmour;  break;
                case "shield":  type = ArmourType.Shield;       break;
                default:
                    type = ArmourType.None;
                    break;
            }

            _armour = new Armour(
                name,
                type,
                weight,
                baseAC,
                dexBonus,
                maxBonus,
                minStr,
                disadvantage,
                descLines.ToArray(),
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
