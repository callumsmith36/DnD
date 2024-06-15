/*********************************************************
 *  
 *  Name:       UserControls/SkillProfCtrl.cs
 *  
 *  Purpose:    Setting skill proficiencies
 *  
 *  Author:     CS
 *  
 *  Created:    27/04/2024
 * 
 *********************************************************/

using DND.Types;
using System.ComponentModel;

namespace CharacterManager
{
    public partial class SkillProfCtrl : UserControl
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

        public bool IsProficient
        {
            get
            {
                return profCheck.Checked;
            }
            set
            {
                profCheck.Checked = value;
            }
        }

        public bool IsExpert
        {
            get
            {
                return expertCheck.Enabled ? expertCheck.Checked : false;
            }
            set
            {
                if (expertCheck.Enabled)
                    expertCheck.Checked = value;
            }
        }


        public SkillProfCtrl()
        {
            InitializeComponent();
        }


        private void profCheck_CheckedChanged(object sender, EventArgs e)
        {
            expertCheck.Enabled = profCheck.Checked;

            if (profCheck.Checked)
            {
                Session.Player.AddSkillProficiency(_skill);
            }
            else
            {
                Session.Player.RemoveSkillProficiency(_skill);
                if (expertCheck.Checked)
                    expertCheck.Checked = false;
            }
        }

        private void expertCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (expertCheck.Checked)
                Session.Player.AddSkillExpertise(_skill);
            else
                Session.Player.RemoveSkillExpertise(_skill);
        }
    }
}
