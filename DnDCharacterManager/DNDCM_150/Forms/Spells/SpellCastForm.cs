/*********************************************************
 *  
 *  Name:       Spells/SpellCastForm.cs
 *  
 *  Purpose:    Dialog for selecting the level at which
 *              to cast a spell
 *  
 *  Author:     CS
 *  
 *  Created:    01/04/2024
 * 
 *********************************************************/

using DND;

namespace CharacterManager
{
    public partial class SpellCastForm : Form
    {
        public SpellCastForm()
        {
            InitializeComponent();
        }

        public SpellCastForm(Spell spell)
        {
            if (spell.Level == 0)
                return;

            InitializeComponent();

            levelCtrl.Value = spell.Level;
            levelCtrl.Minimum = spell.Level;
            levelCtrl.Maximum = Session.Player.GetHighestSpellLevel();
        }

        public int GetLevel()
        {
            return (int)levelCtrl.Value;
        }

        public static int Show(Spell spell)
        {
            SpellCastForm form = new SpellCastForm(spell);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
                return form.GetLevel();

            return 0;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int level = (int)levelCtrl.Value;
            if (Session.Player.GetNumSpellSlotsRemaining(level) == 0)
            {
                MessageBox.Show(string.Format("No {0} spell slots remaining.", Spell.GetLevelString(level)), "Cast Spell");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
