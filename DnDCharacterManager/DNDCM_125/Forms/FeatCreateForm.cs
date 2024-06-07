using DND;

namespace CharacterManager
{
    public partial class FeatCreateForm : Form
    {
        private Feat? _feat;


        //
        //  Constructor
        //
        public FeatCreateForm()
        {
            InitializeComponent();
            _feat = null;

            sourceComboBox.SelectedIndex = 0;
            frequencyComboBox.SelectedIndex = 0;
        }

        //
        //  Constructor
        //
        public FeatCreateForm(Feat feat)
        {
            InitializeComponent();
            _feat = feat;

            nameTextBox.Text = feat.Name;

            sourceComboBox.SelectedIndex = (int)feat.Source - 1;
            sourceComboBox.Enabled = false;

            sourceNameTextBox.Text = feat.SourceName;
            if (feat.LimitedUse)
            {
                usesNumCtrl.Value = feat.MaxUses;
                frequencyComboBox.SelectedIndex = (int)feat.Frequency - 1;
            }
            else
            {
                limitedCheckBox.Checked = false;
            }

            List<string> tempLines = new List<string>();
            for (int i = 0; i < feat.Description.Length; i++)
            {
                tempLines.Add(feat.Description[i]);

                if (i < feat.Description.Length - 1)
                    tempLines.Add("\n");
            }

            descTextBox.Lines = tempLines.ToArray();
        }


        //
        //  GetFeat
        //
        public Feat? GetFeat()
        {
            return _feat;
        }


        //
        //  limitedCheckBox_CheckedChanged
        //
        private void limitedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            descLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            descTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            int newHeight = limitedCheckBox.Checked ? Height + usesNumCtrl.Height + 10 : Height - usesNumCtrl.Height - 10;

            usesLabel.Enabled = limitedCheckBox.Checked;
            usesLabel.Visible = limitedCheckBox.Checked;
            usesNumCtrl.Enabled = limitedCheckBox.Checked;
            usesNumCtrl.Visible = limitedCheckBox.Checked;
            perLabel.Enabled = limitedCheckBox.Checked;
            perLabel.Visible = limitedCheckBox.Checked;
            frequencyComboBox.Enabled = limitedCheckBox.Checked;
            frequencyComboBox.Visible = limitedCheckBox.Checked;

            Size = new Size(Width, newHeight);

            descLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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

            if (sourceNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Source name is required.", "D&D Character Manager");
                return;
            }

            if (_feat == null && Session.Player.GetFeat(name) != null)
            {
                MessageBox.Show("You already have a feat or trait with that index.", "D&D Character Manager");
                return;
            }

            if (sourceComboBox.SelectedIndex == -1)
                sourceComboBox.SelectedIndex = 0;

            if (frequencyComboBox.SelectedIndex == -1)
                frequencyComboBox.SelectedIndex = 0;

            Feat.FeatSource source;
            switch (sourceComboBox.Text.ToLower())
            {
                case "class":   source = Feat.FeatSource.Class; break;
                case "race":    source = Feat.FeatSource.Race;  break;
                case "other":   source = Feat.FeatSource.Other; break;
                default:
                    source = Feat.FeatSource.None;
                    break;
            }

            Feat.FeatFrequency frequency;
            switch (frequencyComboBox.Text.ToLower())
            {
                case "short rest":  frequency = Feat.FeatFrequency.ShortRest;   break;
                case "long rest":   frequency = Feat.FeatFrequency.LongRest;    break;
                case "daily":       frequency = Feat.FeatFrequency.Daily;       break;
                default:
                    frequency = Feat.FeatFrequency.None;
                    break;
            }

            int maxUses = (int)usesNumCtrl.Value;

            List<string> descLines = new List<string>();
            foreach (var line in descTextBox.Lines)
            {
                if (line.Length > 0)
                    descLines.Add(line);
            }

            if (_feat == null)
            {
                _feat = new Feat(
                    name,
                    descLines.ToArray(),
                    limitedCheckBox.Checked,
                    source,
                    sourceNameTextBox.Text,
                    frequency,
                    maxUses
                );
            }
            else
            {
                _feat.Name = name;
                _feat.Description = descLines.ToArray();
                _feat.LimitedUse = limitedCheckBox.Checked;
                _feat.Source = source;
                _feat.SourceName = sourceNameTextBox.Text;
                _feat.Frequency = frequency;
                _feat.MaxUses = maxUses;
                _feat.UsesRemaining = maxUses;
            }

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
