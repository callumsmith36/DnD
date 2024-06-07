using DND.Types;
using System.ComponentModel;

namespace CharacterManager
{
    public partial class SavingThrowCtrl : UserControl
    {
        private Ability _ability = Ability.None;

        [Browsable(true)]
        [DefaultValue("None")]
        [Category("Design")]
        [Description("The ability associated with the control.")]
        public Ability Ability
        {
            get
            {
                return _ability;
            }
            set
            {
                _ability = value;
                abilityNameLabel.Text = TypeMaps.AbilityNames[_ability];
            }
        }


        //
        //  Constructor
        //
        public SavingThrowCtrl()
        {
            InitializeComponent();
        }


        //
        //  UpdateModifier
        //
        public void UpdateModifier()
        {
            int mod = Session.Player.GetSavingThrowModifier(_ability);
            modTextBox.Text = mod > 0 ? "+" + mod.ToString() : mod.ToString();
        }
    }
}
