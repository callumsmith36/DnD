using DND;

namespace CharacterManager
{
    public class SpellBrowserCtrl : BrowserCtrl
    {
        private Spell _spell;


        public SpellBrowserCtrl(Spell spell, EventHandler? onClick = null, bool selectable = false)
            : base(onClick, selectable)
        {
            _spell = spell;
            SetName(spell.Name);
        }


        public Spell GetSpell()
        {
            return _spell;
        }


        protected override void infoBtn_Click(object sender, EventArgs e)
        {
            if (_spell != null)
            {
                SpellDetailsForm form = new SpellDetailsForm(_spell);
                form.ShowDialog();
            }
        }
    }
}
