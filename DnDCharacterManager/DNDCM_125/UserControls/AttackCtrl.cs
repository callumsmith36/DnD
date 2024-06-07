using DND;
using DND.Types;

namespace CharacterManager
{
    public partial class AttackCtrl : UserControl
    {
        private Attack _attack;

        public EventHandler? OnRemoved;


        //
        //  Constructor
        //
        public AttackCtrl()
        {
            InitializeComponent();
        }

        //
        //  Constructor
        //
        public AttackCtrl(Attack atk)
        {
            InitializeComponent();
            _attack = atk;

            nameLabel.Text = atk.Name;
            UpdateInfo();
        }


        //
        //  GetAttack
        //
        public Attack GetAttack()
        {
            return _attack;
        }
        
        //
        //  UpdateInfo
        //
        public void UpdateInfo()
        {
            if (_attack.Type == Attack.AttackType.SavingThrow)
            {
                attackLabel.Text = "DC" + Session.Player.GetSpellSaveDC().ToString();
            }
            else
            {
                int atkBonus;
                if (_attack.IsSpellAttack)
                {
                    atkBonus = Session.Player.GetSpellcastingModifier();
                }
                else
                {
                    atkBonus = Session.Player.GetAbilityModifier(_attack.Ability) + _attack.WeaponBonus;
                    if (_attack.Proficiency)
                        atkBonus += Session.Player.ProficiencyBonus;
                }

                attackLabel.Text = (atkBonus >= 0 ? "+" : "") + atkBonus.ToString();
            }

            int dmgBonus = Session.Player.GetAbilityModifier(_attack.DamageAbility) + _attack.DamageBonus;
            dmgLabel.Text = _attack.DamageDice;
            if (dmgBonus != 0)
                dmgLabel.Text += (dmgBonus > 0 ? " + " : " - ") + Math.Abs(dmgBonus).ToString();
        }


        //
        //  removeIcon_Click
        //
        private void removeIcon_Click(object sender, EventArgs e)
        {
            Session.Player.RemoveAttack(_attack.Name);
            OnRemoved?.Invoke(this, EventArgs.Empty);
        }
    }
}
