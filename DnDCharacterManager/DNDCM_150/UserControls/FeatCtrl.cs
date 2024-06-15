/*********************************************************
 *  
 *  Name:       UserControls/FeatCtrl.cs
 *  
 *  Purpose:    Displaying and tracking feats
 *  
 *  Author:     CS
 *  
 *  Created:    21/04/2024
 * 
 *********************************************************/

using DND;

namespace CharacterManager
{
    public partial class FeatCtrl : UserControl
    {
        private static ContextMenuStrip?    _menuStrip;
        private static FeatCtrl?            _targetCtrl;

        private Feat _feat;

        public EventHandler? OnRemoved;


        public FeatCtrl()
        {
            InitializeComponent();
        }

        public FeatCtrl(Feat feat)
        {
            InitializeComponent();
            if (_menuStrip == null)
            {
                _menuStrip = new ContextMenuStrip();
                _menuStrip.Items.Add("Details").Click += ShowDetails;
                _menuStrip.Items.Add("Edit").Click += Edit;
                _menuStrip.Items.Add("Remove").Click += Remove;
            }

            _feat = feat;
            UpdateInfo();

            usesLeftNumCtrl.MouseWheel += usesLeftNumCtrl_MouseWheel;
        }


        //
        //  GetFeat
        //
        public Feat GetFeat()
        {
            return _feat;
        }

        //
        //  UpdateInfo
        //
        public void UpdateInfo()
        {
            nameLabel.Text = _feat.Name;
            sourceLabel.Text = _feat.SourceName;

            maxUsesTextBox.Enabled = _feat.LimitedUse;
            maxUsesTextBox.Visible = _feat.LimitedUse;
            usesLeftNumCtrl.Enabled = _feat.LimitedUse;
            usesLeftNumCtrl.Visible = _feat.LimitedUse;
            slash.Enabled = _feat.LimitedUse;
            slash.Visible = _feat.LimitedUse;

            if (_feat.LimitedUse)
            {
                maxUsesTextBox.Text = _feat.MaxUses.ToString();
                usesLeftNumCtrl.Maximum = _feat.MaxUses;
                usesLeftNumCtrl.Value = _feat.UsesRemaining > _feat.MaxUses ? _feat.MaxUses : _feat.UsesRemaining;
            }
        }
        
        //
        //  ShowDetails
        //
        private void ShowDetails(object? sender, EventArgs e)
        {
            if (_targetCtrl != null)
            {
                var form = new FeatDetailsForm(_targetCtrl._feat);
                form.ShowDialog();

                _targetCtrl = null;
            }
        }

        //
        //  Edit
        //
        private void Edit(object? sender, EventArgs e)
        {
            if (_targetCtrl != null)
            {
                var form = new FeatCreateForm(_targetCtrl._feat);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _targetCtrl.UpdateInfo();
                }

                _targetCtrl = null;
            }
        }

        //
        //  Remove
        //
        private void Remove(object? sender, EventArgs e)
        {
            if (_targetCtrl != null)
            {
                string message = string.Format("Are you sure you want to remove {0}?", _targetCtrl._feat.Name);
                if (MessageBox.Show(message, "D&D Character Manager", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    OnRemoved?.Invoke(_targetCtrl, EventArgs.Empty);

                _targetCtrl = null;
            }
        }


        //
        //  usesLeftNumCtrl_ValueChanged
        //
        private void usesLeftNumCtrl_ValueChanged(object sender, EventArgs e)
        {
            _feat.UsesRemaining = (int)usesLeftNumCtrl.Value;
        }

        //
        //  usesLeftNumCtrl_MouseWheel
        //
        private void usesLeftNumCtrl_MouseWheel(object? sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        //
        //  FeatCtrl_MouseClick
        //
        private void FeatCtrl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            _targetCtrl = this;
            _menuStrip?.Show(this, e.Location);
        }
    }
}
