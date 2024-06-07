﻿namespace CharacterManager
{
    partial class SpellSlotNumCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            levelLabel = new Label();
            numSlotsCtrl = new NumericUpDown();
            slash = new Label();
            maxSlotsTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numSlotsCtrl).BeginInit();
            SuspendLayout();
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Font = new Font("Constantia", 10F);
            levelLabel.Location = new Point(0, 0);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(57, 17);
            levelLabel.TabIndex = 7;
            levelLabel.Text = "1st-level";
            // 
            // numSlotsCtrl
            // 
            numSlotsCtrl.BackColor = Color.WhiteSmoke;
            numSlotsCtrl.BorderStyle = BorderStyle.FixedSingle;
            numSlotsCtrl.Font = new Font("Constantia", 14F);
            numSlotsCtrl.Location = new Point(3, 23);
            numSlotsCtrl.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numSlotsCtrl.Name = "numSlotsCtrl";
            numSlotsCtrl.Size = new Size(58, 30);
            numSlotsCtrl.TabIndex = 4;
            numSlotsCtrl.TextAlign = HorizontalAlignment.Center;
            numSlotsCtrl.ValueChanged += numSlotsCtrl_ValueChanged;
            // 
            // slash
            // 
            slash.AutoSize = true;
            slash.Font = new Font("Constantia", 20F);
            slash.Location = new Point(60, 19);
            slash.Name = "slash";
            slash.Size = new Size(26, 33);
            slash.TabIndex = 5;
            slash.Text = "/";
            // 
            // maxSlotsTextBox
            // 
            maxSlotsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maxSlotsTextBox.BackColor = SystemColors.Window;
            maxSlotsTextBox.BorderStyle = BorderStyle.None;
            maxSlotsTextBox.Font = new Font("Constantia", 14F);
            maxSlotsTextBox.Location = new Point(83, 25);
            maxSlotsTextBox.MaxLength = 2;
            maxSlotsTextBox.Name = "maxSlotsTextBox";
            maxSlotsTextBox.Size = new Size(23, 23);
            maxSlotsTextBox.TabIndex = 8;
            maxSlotsTextBox.Text = "0";
            maxSlotsTextBox.KeyPress += maxSlotsTextBox_KeyPress;
            maxSlotsTextBox.Leave += maxSlotsTextBox_Leave;
            // 
            // SpellSlotNumCtrl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Window;
            Controls.Add(maxSlotsTextBox);
            Controls.Add(levelLabel);
            Controls.Add(numSlotsCtrl);
            Controls.Add(slash);
            MinimumSize = new Size(113, 58);
            Name = "SpellSlotNumCtrl";
            Size = new Size(113, 58);
            ((System.ComponentModel.ISupportInitialize)numSlotsCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label levelLabel;
        private NumericUpDown numSlotsCtrl;
        private Label slash;
        private TextBox maxSlotsTextBox;
    }
}
