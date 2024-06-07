using DND;
using DND.API;

namespace CharacterManager
{
    public partial class SpellCreateForm : Form
    {
        //
        //  Constructor
        //
        public SpellCreateForm()
        {
            InitializeComponent();

            foreach (var name in APIReadWrite.GetClassNameList())
                classCheckList.Items.Add(name);

            schoolComboBox.SelectedIndex = 0;
        }


        //
        //  okBtn_Click
        //
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Please enter a name for the spell.", "Create Spell");
                return;
            }

            if (APIReadWrite.GetSpell(name) != null)
            {
                MessageBox.Show("A spell already exists with that name.", "Create Spell");
                return;
            }

            int level = (int)levelNumCtrl.Value;

            string school = schoolComboBox.Text;
            string time = timeTextBox.Text;
            string range = rangeTextBox.Text;
            string duration = durationTextBox.Text;
            string mat = materialTextBox.Text;

            if (time.Length == 0)
            {
                MessageBox.Show("Please enter a casting time for the spell.", "Create Spell");
                return;
            }
            else if (range.Length == 0)
            {
                MessageBox.Show("Please enter a range for the spell.", "Create Spell");
                return;
            }
            else if (duration.Length == 0)
            {
                MessageBox.Show("Please enter a duration for the spell.", "Create Spell");
                return;
            }

            bool isConcentration = concentrationCheck.Checked;
            bool isRitual = ritualCheck.Checked;

            List<string> compList = new List<string>();
            if (verbalCheck.Checked)
                compList.Add("V");
            if (somaticCheck.Checked)
                compList.Add("S");
            if (materialCheck.Checked)
                compList.Add("M");

            string components = "";
            for (int i = 0; i < compList.Count; i++)
            {
                components += compList[i];
                if (i < compList.Count - 1)
                    components += ", ";
            }

            List<string> descLines = new List<string>();
            foreach (var line in descTextBox.Lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                    descLines.Add(line);
            }

            if (descLines.Count == 0)
            {
                MessageBox.Show("Please enter a description for the spell.", "Create Spell");
                return;
            }

            List<string> higherLvlLines = new List<string>();
            foreach (var line in higherLvlTextBox.Lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                    higherLvlLines.Add(line);
            }

            List<string> classes = new List<string>();
            foreach (var item in classCheckList.CheckedItems)
            {
                if (item != null)
                    classes.Add(item.ToString());
            }

            string[] subclasses = Array.Empty<string>();

            Spell spell = new Spell(
                level,
                name,
                range,
                time,
                duration,
                components,
                mat,
                school,
                isRitual,
                isConcentration,
                descLines.ToArray(),
                higherLvlLines.ToArray(),
                classes.ToArray(),
                subclasses
            );

            if (APIReadWrite.SaveCustomSpell(spell) == 0)
                MessageBox.Show(string.Format("New spell {0} created successfully.", name), "Create Spell");
            else
                MessageBox.Show(string.Format("Errors occurred during creation of {0}.", name), "Create Spell");

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
