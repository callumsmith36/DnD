using DND;
using DND.Types;
using System.ComponentModel;

namespace CharacterManager
{
    public partial class AbilityCtrl : UserControl
    {
        // Member variables
        private Ability _ability = Ability.None;
        private TextBox _modTextBox;
        private TextBox _scoreTextBox;
        private bool _modUpper;

        // Properties
        [Browsable(true)]
        [DefaultValue("None")]
        [Category("Design")]
        [Description("The ability associated with the control.")]
        public Ability Ability { get => _ability; set => _ability = value; }

        public static EventHandler? OnAnyScoreChanged;


        //
        //  Constructor
        //
        public AbilityCtrl()
        {
            InitializeComponent();

            _scoreTextBox = lowerTextBox;
            _modTextBox = upperTextBox;
            _modUpper = true;
        }


        //
        //  SetScore
        //
        public void SetScore(int score)
        {
            _scoreTextBox.Text = score.ToString();
            HandleScoreChange();
        }

        //
        //  SwapScoreAndMod
        //
        public void SwapScoreAndMod()
        {
            string upperText = upperTextBox.Text;
            string lowerText = lowerTextBox.Text;

            upperTextBox.Text = lowerText;
            lowerTextBox.Text = upperText;

            if (_modUpper)
            {
                lowerTextBox.Leave -= scoreTextBox_Leave;
                lowerTextBox.KeyPress -= scoreTextBox_KeyPress;
                lowerTextBox.ReadOnly = true;

                upperTextBox.Leave += scoreTextBox_Leave;
                upperTextBox.KeyPress += scoreTextBox_KeyPress;
                upperTextBox.ReadOnly = false;

                _modTextBox = lowerTextBox;
                _scoreTextBox = upperTextBox;

                _modUpper = false;
            }
            else
            {
                lowerTextBox.Leave += scoreTextBox_Leave;
                lowerTextBox.KeyPress += scoreTextBox_KeyPress;
                lowerTextBox.ReadOnly = false;

                upperTextBox.Leave -= scoreTextBox_Leave;
                upperTextBox.KeyPress -= scoreTextBox_KeyPress;
                upperTextBox.ReadOnly = true;

                _modTextBox = upperTextBox;
                _scoreTextBox = lowerTextBox;

                _modUpper = true;
            }
        }


        //
        //  HandleScoreChange
        //
        private void HandleScoreChange()
        {
            try
            {
                if (_scoreTextBox.Text.Length == 0)
                    _scoreTextBox.Text = "10";

                if (int.TryParse(_scoreTextBox.Text, out var score) == true)
                {
                    Session.Player.SetAbilityScore(_ability, score);

                    var mod = PlayerCharacter.GetAbilityModifier(score);
                    _modTextBox.Text = mod > 0 ? "+" + mod.ToString() : mod.ToString();

                    OnAnyScoreChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception) { }
        }


        /*  EVENT HANDLERS  */

        //
        //  scoreTextBox_Leave
        //
        private void scoreTextBox_Leave(object? sender, EventArgs e)
        {
            HandleScoreChange();
        }

        //
        //  scoreTextBox_KeyPress
        //
        private void scoreTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
                Utility.CheckNumericInput(false, textBox, e, HandleScoreChange);
        }

        //
        //  AbilityCtrl_BackColorChanged
        //
        private void AbilityCtrl_BackColorChanged(object? sender, EventArgs e)
        {
            upperTextBox.BackColor = BackColor;
            lowerTextBox.BackColor = BackColor;
        }

        //
        //  AbilityCtrl_ForeColorChanged
        //
        private void AbilityCtrl_ForeColorChanged(object? sender, EventArgs e)
        {
            upperTextBox.ForeColor = ForeColor;
            lowerTextBox.ForeColor = ForeColor;
        }

        //
        //  AbilityCtrl_Resize
        //
        private void AbilityCtrl_Resize(object sender, EventArgs e)
        {
            var x = (Size.Width / 2f) - (lowerTextBox.Size.Width / 2f);
            lowerTextBox.Location = new Point((int)x, lowerTextBox.Location.Y);
        }
    }
}
