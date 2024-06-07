using DND;
using System.ComponentModel;

namespace CharacterManager
{
    public partial class SpellSlotNumCtrl : UserControl
    {
        // Member variables
        private int _level;

        // Properties
        [Category("Behavior")]
        [Description("The spell level associated with the control. Must be between 1 and 9.")]
        public int SpellLevel
        {
            get
            {
                return _level;
            }
            set
            {
                if (value < 1)
                    _level = 1;
                else if (value > 9)
                    _level = 9;
                else
                    _level = value;

                levelLabel.Text = Spell.GetLevelString(_level);
            }
        }


        //
        //  Constructor
        //
        public SpellSlotNumCtrl()
        {
            InitializeComponent();

            _level = 1;
        }


        //
        //  SetRemaining
        //
        public void SetRemaining(int n)
        {
            numSlotsCtrl.Value = n;
        }

        //
        //  SetMax
        //
        public void SetMax(int n)
        {
            maxSlotsTextBox.Text = n.ToString();
            numSlotsCtrl.Maximum = n;
        }

        //
        //  UpdateValues
        //
        public void UpdateValues()
        {
            SetMax(Session.Player.GetNumSpellSlotsMax(_level));
            SetRemaining(Session.Player.GetNumSpellSlotsRemaining(_level));
        }

        //
        //  OnMaxChanged
        //
        private void OnMaxChanged()
        {
            if (maxSlotsTextBox.Text.Length == 0)
                maxSlotsTextBox.Text = "0";

            if (Int32.TryParse(maxSlotsTextBox.Text, out var n) == true)
            {
                Session.Player.SetNumSpellSlotsMax(_level, n);
                numSlotsCtrl.Maximum = n;
            }
        }


        // EVENT HANDLERS

        //
        //  numSlotsCtrl_ValueChanged
        //
        private void numSlotsCtrl_ValueChanged(object sender, EventArgs e)
        {
            Session.Player.SetNumSpellSlotsRemaining(_level, (int)numSlotsCtrl.Value);
        }

        //
        //  maxSlotsTextBox_Leave
        //
        private void maxSlotsTextBox_Leave(object sender, EventArgs e)
        {
            OnMaxChanged();
        }

        //
        //  maxSlotsTextBox_KeyPress
        //
        private void maxSlotsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
                Utility.CheckNumericInput(false, textBox, e, OnMaxChanged);
        }
    }
}
