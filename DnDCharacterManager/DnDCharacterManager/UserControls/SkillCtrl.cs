using DND.Types;
using System.ComponentModel;

namespace CharacterManager
{
    public partial class SkillCtrl : UserControl
    {
        private Skill _skill = Skill.None;

        [Browsable(true)]
        [DefaultValue("None")]
        [Category("Design")]
        [Description("The skill associated with the control.")]
        public Skill Skill
        {
            get
            {
                return _skill;
            }
            set
            {
                _skill = value;
                skillNameLabel.Text = TypeMaps.SkillNames[_skill];
            }
        }


        //
        //  Constructor
        //
        public SkillCtrl()
        {
            InitializeComponent();
        }


        //
        //  UpdateModifier
        //
        public void UpdateModifier()
        {
            int mod = Session.Player.GetSkillModifier(_skill);
            skillModTextBox.Text = mod > 0 ? "+" + mod.ToString() : mod.ToString();
        }
    }
}
