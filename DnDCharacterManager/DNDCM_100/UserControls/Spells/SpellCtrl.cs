/*********************************************************
 *  
 *  Name:       UserControls/Spells/SpellCtrl.cs
 *  
 *  Purpose:    Displaying the character's active spells
 *  
 *  Author:     CS
 *  
 *  Created:    02/04/2024
 * 
 *********************************************************/

using DND;

namespace CharacterManager
{
    public partial class SpellCtrl : UserControl
    {
        private Spell? _spell;

        //
        //  Constructor
        //
        public SpellCtrl()
        {
            InitializeComponent();
        }

        //
        //  Constructor
        //
        public SpellCtrl(Spell spell)
        {
            InitializeComponent();

            _spell = spell;

            nameTextBox.Text = spell.Name;

            if (spell.IsConcentration)
            {
                concentrationLabel.Visible = true;
                conRitTable.Controls.Add(concentrationLabel);
            }

            if (spell.IsRitual)
            {
                ritualLabel.Visible = true;
                conRitTable.Controls.Add(ritualLabel);
            }
        }


        //
        //  castBtn_Click
        //
        private void castBtn_Click(object sender, EventArgs e)
        {
            int level = 0;
            int fail = 0;
            bool ritual = false;
            string message;

            if (_spell == null)
                return;

            if (_spell.IsRitual)
            {
                message = string.Format("Cast {0} as a ritual?", _spell.Name);

                DialogResult result = MessageBox.Show(message, "Cast Spell", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                    ritual = true;
            }

            // Check that sufficient spell slots are available
            if (!ritual && _spell.Level > 0)
            {
                if (_spell.HigherLevel.Length > 0)
                {
                    fail = 1;

                    // Check for available slots of all applicable levels
                    for (int i = _spell.Level; i <= 9; i++)
                    {
                        if (Session.Player.GetNumSpellSlotsRemaining(i) > 0)
                        {
                            fail = 0;
                            break;
                        }
                    }

                    if (fail != 0)
                        MessageBox.Show("Insufficient spell slots remaining.", "Cast Spell");
                }
                else
                {
                    if (Session.Player.GetNumSpellSlotsRemaining(_spell.Level) == 0)
                    {
                        MessageBox.Show(string.Format("No {0} spell slots remaining.", Spell.GetLevelString(_spell.Level)), "Cast Spell");
                        fail = 1;
                    }
                }
            }

            // Handle concentration
            if (fail == 0)
            {
                if (_spell.IsConcentration && Session.Player.IsConcentrating)
                {
                    message = string.Format(
                        "You are currently concentrating on {0}.\nProceed with casting {1}?",
                        Session.Player.ConcentratingOn,
                        _spell.Name
                    );

                    DialogResult result = MessageBox.Show(message, "Cast Spell", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                        fail = 1;
                }
            }

            // Handle higher level casting
            if (fail == 0 && !ritual && _spell.Level > 0)
            {
                if (_spell.HigherLevel.Length > 0)
                {
                    level = SpellCastForm.Show(_spell);
                    if (level < _spell.Level || level > 9)
                        fail = 1;
                }
                else
                {
                    level = _spell.Level;
                }
            }

            if (fail == 0)
            {
                if (ritual)
                {
                    message = string.Format("You cast {0} as a ritual.", _spell.Name);
                    MessageBox.Show(message, "Cast Spell");
                    Session.Player.CastSpell(_spell, true);
                }
                else
                {
                    if (level > 0)
                        message = string.Format("You cast {0} at {1}.", _spell.Name, Spell.GetLevelString(level));
                    else
                        message = string.Format("You cast {0}.", _spell.Name);

                    MessageBox.Show(message, "Cast Spell");
                    Session.Player.CastSpell(_spell, level);
                }
            }
        }

        //
        //  infoBtn_Click
        //
        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (_spell != null)
            {
                SpellDetailsForm form = new SpellDetailsForm(_spell);
                form.ShowDialog();
            }
        }
    }
}
