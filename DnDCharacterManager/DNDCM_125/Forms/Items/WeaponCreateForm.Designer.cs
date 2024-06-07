namespace CharacterManager
{
    partial class WeaponCreateForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            rangeComboBox = new ComboBox();
            dmgDicePrimaryComboBox = new ComboBox();
            dmgDiceLabel = new Label();
            dmgTypeLabel = new Label();
            dmgDice2Label = new Label();
            dmgDiceSecondaryComboBox = new ComboBox();
            dmgTypeComboBox = new ComboBox();
            dmgNumSecondaryTextBox = new TextBox();
            dmgNumPrimaryTextBox = new TextBox();
            rangeLabel = new Label();
            rangeNormalTextBox = new TextBox();
            slash1 = new Label();
            rangeLongTextBox = new TextBox();
            thrownLabel = new Label();
            thrownLongTextBox = new TextBox();
            thrownNormalTextBox = new TextBox();
            slash2 = new Label();
            costLabel = new Label();
            costValueTextBox = new TextBox();
            costUnitComboBox = new ComboBox();
            weightLabel = new Label();
            weightTextBox = new TextBox();
            lbsLabel = new Label();
            propCheckList = new CheckedListBox();
            propLabel = new Label();
            descTextBox = new TextBox();
            descLabel = new Label();
            cancelBtn = new Button();
            okBtn = new Button();
            ftLabel = new Label();
            specialLabel = new Label();
            specialTextBox = new TextBox();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Constantia", 14F);
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Item Name";
            nameTextBox.Size = new Size(488, 36);
            nameTextBox.TabIndex = 45;
            nameTextBox.TabStop = false;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            categoryLabel.Location = new Point(12, 143);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(81, 21);
            categoryLabel.TabIndex = 52;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Constantia", 10F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Simple", "Martial" });
            categoryComboBox.Location = new Point(135, 140);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(91, 29);
            categoryComboBox.TabIndex = 51;
            // 
            // rangeComboBox
            // 
            rangeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rangeComboBox.Font = new Font("Constantia", 10F);
            rangeComboBox.FormattingEnabled = true;
            rangeComboBox.Items.AddRange(new object[] { "Melee", "Ranged" });
            rangeComboBox.Location = new Point(232, 140);
            rangeComboBox.Name = "rangeComboBox";
            rangeComboBox.Size = new Size(91, 29);
            rangeComboBox.TabIndex = 53;
            rangeComboBox.SelectedIndexChanged += rangeComboBox_SelectedIndexChanged;
            // 
            // dmgDicePrimaryComboBox
            // 
            dmgDicePrimaryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dmgDicePrimaryComboBox.Font = new Font("Constantia", 10F);
            dmgDicePrimaryComboBox.FormattingEnabled = true;
            dmgDicePrimaryComboBox.Items.AddRange(new object[] { "d4", "d6", "d8", "d10", "d12", "d20" });
            dmgDicePrimaryComboBox.Location = new Point(192, 181);
            dmgDicePrimaryComboBox.Name = "dmgDicePrimaryComboBox";
            dmgDicePrimaryComboBox.Size = new Size(73, 29);
            dmgDicePrimaryComboBox.TabIndex = 55;
            // 
            // dmgDiceLabel
            // 
            dmgDiceLabel.AutoSize = true;
            dmgDiceLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dmgDiceLabel.Location = new Point(12, 184);
            dmgDiceLabel.Name = "dmgDiceLabel";
            dmgDiceLabel.Size = new Size(115, 21);
            dmgDiceLabel.TabIndex = 54;
            dmgDiceLabel.Text = "Damage Dice";
            // 
            // dmgTypeLabel
            // 
            dmgTypeLabel.AutoSize = true;
            dmgTypeLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dmgTypeLabel.Location = new Point(12, 225);
            dmgTypeLabel.Name = "dmgTypeLabel";
            dmgTypeLabel.Size = new Size(117, 21);
            dmgTypeLabel.TabIndex = 57;
            dmgTypeLabel.Text = "Damage Type";
            // 
            // dmgDice2Label
            // 
            dmgDice2Label.AutoSize = true;
            dmgDice2Label.Enabled = false;
            dmgDice2Label.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dmgDice2Label.Location = new Point(281, 184);
            dmgDice2Label.Name = "dmgDice2Label";
            dmgDice2Label.Size = new Size(81, 21);
            dmgDice2Label.TabIndex = 58;
            dmgDice2Label.Text = "Versatile";
            dmgDice2Label.Visible = false;
            // 
            // dmgDiceSecondaryComboBox
            // 
            dmgDiceSecondaryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dmgDiceSecondaryComboBox.Enabled = false;
            dmgDiceSecondaryComboBox.Font = new Font("Constantia", 10F);
            dmgDiceSecondaryComboBox.FormattingEnabled = true;
            dmgDiceSecondaryComboBox.Items.AddRange(new object[] { "d4", "d6", "d8", "d10", "d12", "d20" });
            dmgDiceSecondaryComboBox.Location = new Point(425, 181);
            dmgDiceSecondaryComboBox.Name = "dmgDiceSecondaryComboBox";
            dmgDiceSecondaryComboBox.Size = new Size(73, 29);
            dmgDiceSecondaryComboBox.TabIndex = 60;
            dmgDiceSecondaryComboBox.Visible = false;
            // 
            // dmgTypeComboBox
            // 
            dmgTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dmgTypeComboBox.Font = new Font("Constantia", 10F);
            dmgTypeComboBox.FormattingEnabled = true;
            dmgTypeComboBox.Items.AddRange(new object[] { "Bludgeoning", "Piercing", "Slashing" });
            dmgTypeComboBox.Location = new Point(135, 222);
            dmgTypeComboBox.Name = "dmgTypeComboBox";
            dmgTypeComboBox.Size = new Size(130, 29);
            dmgTypeComboBox.TabIndex = 61;
            // 
            // dmgNumSecondaryTextBox
            // 
            dmgNumSecondaryTextBox.Enabled = false;
            dmgNumSecondaryTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dmgNumSecondaryTextBox.Location = new Point(368, 181);
            dmgNumSecondaryTextBox.MaxLength = 1;
            dmgNumSecondaryTextBox.Multiline = true;
            dmgNumSecondaryTextBox.Name = "dmgNumSecondaryTextBox";
            dmgNumSecondaryTextBox.Size = new Size(51, 29);
            dmgNumSecondaryTextBox.TabIndex = 62;
            dmgNumSecondaryTextBox.Text = "1";
            dmgNumSecondaryTextBox.TextAlign = HorizontalAlignment.Center;
            dmgNumSecondaryTextBox.Visible = false;
            dmgNumSecondaryTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // dmgNumPrimaryTextBox
            // 
            dmgNumPrimaryTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dmgNumPrimaryTextBox.Location = new Point(135, 181);
            dmgNumPrimaryTextBox.MaxLength = 1;
            dmgNumPrimaryTextBox.Multiline = true;
            dmgNumPrimaryTextBox.Name = "dmgNumPrimaryTextBox";
            dmgNumPrimaryTextBox.Size = new Size(51, 29);
            dmgNumPrimaryTextBox.TabIndex = 63;
            dmgNumPrimaryTextBox.Text = "1";
            dmgNumPrimaryTextBox.TextAlign = HorizontalAlignment.Center;
            dmgNumPrimaryTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rangeLabel.Location = new Point(12, 266);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(60, 21);
            rangeLabel.TabIndex = 64;
            rangeLabel.Text = "Range";
            // 
            // rangeNormalTextBox
            // 
            rangeNormalTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rangeNormalTextBox.Location = new Point(135, 263);
            rangeNormalTextBox.MaxLength = 4;
            rangeNormalTextBox.Multiline = true;
            rangeNormalTextBox.Name = "rangeNormalTextBox";
            rangeNormalTextBox.Size = new Size(51, 29);
            rangeNormalTextBox.TabIndex = 65;
            rangeNormalTextBox.Text = "0";
            rangeNormalTextBox.TextAlign = HorizontalAlignment.Center;
            rangeNormalTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // slash1
            // 
            slash1.AutoSize = true;
            slash1.Enabled = false;
            slash1.Font = new Font("Constantia", 16F);
            slash1.Location = new Point(188, 260);
            slash1.Name = "slash1";
            slash1.Size = new Size(26, 33);
            slash1.TabIndex = 66;
            slash1.Text = "/";
            slash1.Visible = false;
            // 
            // rangeLongTextBox
            // 
            rangeLongTextBox.Enabled = false;
            rangeLongTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rangeLongTextBox.Location = new Point(214, 263);
            rangeLongTextBox.MaxLength = 4;
            rangeLongTextBox.Multiline = true;
            rangeLongTextBox.Name = "rangeLongTextBox";
            rangeLongTextBox.Size = new Size(51, 29);
            rangeLongTextBox.TabIndex = 67;
            rangeLongTextBox.Text = "0";
            rangeLongTextBox.TextAlign = HorizontalAlignment.Center;
            rangeLongTextBox.Visible = false;
            rangeLongTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // thrownLabel
            // 
            thrownLabel.AutoSize = true;
            thrownLabel.Enabled = false;
            thrownLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thrownLabel.Location = new Point(281, 266);
            thrownLabel.Name = "thrownLabel";
            thrownLabel.Size = new Size(73, 21);
            thrownLabel.TabIndex = 68;
            thrownLabel.Text = "Thrown";
            thrownLabel.Visible = false;
            // 
            // thrownLongTextBox
            // 
            thrownLongTextBox.Enabled = false;
            thrownLongTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thrownLongTextBox.Location = new Point(447, 263);
            thrownLongTextBox.MaxLength = 4;
            thrownLongTextBox.Multiline = true;
            thrownLongTextBox.Name = "thrownLongTextBox";
            thrownLongTextBox.Size = new Size(51, 29);
            thrownLongTextBox.TabIndex = 71;
            thrownLongTextBox.Text = "0";
            thrownLongTextBox.TextAlign = HorizontalAlignment.Center;
            thrownLongTextBox.Visible = false;
            thrownLongTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // thrownNormalTextBox
            // 
            thrownNormalTextBox.Enabled = false;
            thrownNormalTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thrownNormalTextBox.Location = new Point(368, 263);
            thrownNormalTextBox.MaxLength = 4;
            thrownNormalTextBox.Multiline = true;
            thrownNormalTextBox.Name = "thrownNormalTextBox";
            thrownNormalTextBox.Size = new Size(51, 29);
            thrownNormalTextBox.TabIndex = 69;
            thrownNormalTextBox.Text = "0";
            thrownNormalTextBox.TextAlign = HorizontalAlignment.Center;
            thrownNormalTextBox.Visible = false;
            thrownNormalTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // slash2
            // 
            slash2.AutoSize = true;
            slash2.Enabled = false;
            slash2.Font = new Font("Constantia", 16F);
            slash2.Location = new Point(421, 260);
            slash2.Name = "slash2";
            slash2.Size = new Size(26, 33);
            slash2.TabIndex = 70;
            slash2.Text = "/";
            slash2.Visible = false;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            costLabel.Location = new Point(12, 61);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(46, 21);
            costLabel.TabIndex = 72;
            costLabel.Text = "Cost";
            // 
            // costValueTextBox
            // 
            costValueTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            costValueTextBox.Location = new Point(135, 58);
            costValueTextBox.MaxLength = 8;
            costValueTextBox.Multiline = true;
            costValueTextBox.Name = "costValueTextBox";
            costValueTextBox.Size = new Size(91, 29);
            costValueTextBox.TabIndex = 73;
            costValueTextBox.Text = "0";
            costValueTextBox.TextAlign = HorizontalAlignment.Center;
            costValueTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // costUnitComboBox
            // 
            costUnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            costUnitComboBox.Font = new Font("Constantia", 10F);
            costUnitComboBox.FormattingEnabled = true;
            costUnitComboBox.Items.AddRange(new object[] { "cp", "sp", "gp", "pp" });
            costUnitComboBox.Location = new Point(232, 58);
            costUnitComboBox.Name = "costUnitComboBox";
            costUnitComboBox.Size = new Size(58, 29);
            costUnitComboBox.TabIndex = 74;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            weightLabel.Location = new Point(12, 102);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(68, 21);
            weightLabel.TabIndex = 75;
            weightLabel.Text = "Weight";
            // 
            // weightTextBox
            // 
            weightTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightTextBox.Location = new Point(135, 99);
            weightTextBox.MaxLength = 8;
            weightTextBox.Multiline = true;
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(91, 29);
            weightTextBox.TabIndex = 76;
            weightTextBox.Text = "0";
            weightTextBox.TextAlign = HorizontalAlignment.Center;
            weightTextBox.KeyPress += textBox_CheckDecimalInput;
            // 
            // lbsLabel
            // 
            lbsLabel.AutoSize = true;
            lbsLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbsLabel.Location = new Point(76, 102);
            lbsLabel.Name = "lbsLabel";
            lbsLabel.Size = new Size(43, 21);
            lbsLabel.TabIndex = 77;
            lbsLabel.Text = "(lbs)";
            // 
            // propCheckList
            // 
            propCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            propCheckList.BackColor = Color.WhiteSmoke;
            propCheckList.BorderStyle = BorderStyle.None;
            propCheckList.CheckOnClick = true;
            propCheckList.ColumnWidth = 150;
            propCheckList.Font = new Font("Constantia", 10.2F);
            propCheckList.FormattingEnabled = true;
            propCheckList.Items.AddRange(new object[] { "Ammunition", "Finesse", "Heavy", "Light", "Loading", "Monk", "Range", "Reach", "Special", "Thrown", "Two-Handed", "Versatile" });
            propCheckList.Location = new Point(12, 331);
            propCheckList.MultiColumn = true;
            propCheckList.Name = "propCheckList";
            propCheckList.Size = new Size(488, 92);
            propCheckList.TabIndex = 78;
            propCheckList.ItemCheck += propCheckList_ItemCheck;
            // 
            // propLabel
            // 
            propLabel.AutoSize = true;
            propLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            propLabel.Location = new Point(12, 307);
            propLabel.Name = "propLabel";
            propLabel.Size = new Size(94, 21);
            propLabel.TabIndex = 79;
            propLabel.Text = "Properties";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.Font = new Font("Constantia", 9F);
            descTextBox.Location = new Point(12, 460);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(488, 91);
            descTextBox.TabIndex = 80;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descLabel.Location = new Point(12, 436);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 81;
            descLabel.Text = "Description";
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(384, 707);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 83;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.BackColor = Color.Gainsboro;
            okBtn.Font = new Font("Constantia", 10.2F);
            okBtn.ForeColor = SystemColors.ControlText;
            okBtn.Location = new Point(268, 707);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 82;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // ftLabel
            // 
            ftLabel.AutoSize = true;
            ftLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ftLabel.Location = new Point(68, 266);
            ftLabel.Name = "ftLabel";
            ftLabel.Size = new Size(33, 21);
            ftLabel.TabIndex = 84;
            ftLabel.Text = "(ft)";
            // 
            // specialLabel
            // 
            specialLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            specialLabel.AutoSize = true;
            specialLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialLabel.Location = new Point(12, 563);
            specialLabel.Name = "specialLabel";
            specialLabel.Size = new Size(67, 21);
            specialLabel.TabIndex = 86;
            specialLabel.Text = "Special";
            // 
            // specialTextBox
            // 
            specialTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            specialTextBox.Font = new Font("Constantia", 9F);
            specialTextBox.Location = new Point(12, 587);
            specialTextBox.Multiline = true;
            specialTextBox.Name = "specialTextBox";
            specialTextBox.ScrollBars = ScrollBars.Vertical;
            specialTextBox.Size = new Size(488, 105);
            specialTextBox.TabIndex = 85;
            // 
            // WeaponCreateForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(512, 751);
            Controls.Add(specialLabel);
            Controls.Add(specialTextBox);
            Controls.Add(ftLabel);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(propLabel);
            Controls.Add(propCheckList);
            Controls.Add(lbsLabel);
            Controls.Add(weightTextBox);
            Controls.Add(weightLabel);
            Controls.Add(costUnitComboBox);
            Controls.Add(costValueTextBox);
            Controls.Add(costLabel);
            Controls.Add(thrownLongTextBox);
            Controls.Add(thrownNormalTextBox);
            Controls.Add(slash2);
            Controls.Add(thrownLabel);
            Controls.Add(rangeLongTextBox);
            Controls.Add(rangeNormalTextBox);
            Controls.Add(rangeLabel);
            Controls.Add(dmgNumPrimaryTextBox);
            Controls.Add(dmgNumSecondaryTextBox);
            Controls.Add(dmgTypeComboBox);
            Controls.Add(dmgDiceSecondaryComboBox);
            Controls.Add(dmgDice2Label);
            Controls.Add(dmgTypeLabel);
            Controls.Add(dmgDicePrimaryComboBox);
            Controls.Add(dmgDiceLabel);
            Controls.Add(rangeComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(slash1);
            MinimumSize = new Size(530, 780);
            Name = "WeaponCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Weapon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private ComboBox rangeComboBox;
        private ComboBox dmgDicePrimaryComboBox;
        private Label dmgDiceLabel;
        private Label dmgTypeLabel;
        private Label dmgDice2Label;
        private ComboBox dmgDiceSecondaryComboBox;
        private ComboBox dmgTypeComboBox;
        private TextBox dmgNumSecondaryTextBox;
        private TextBox dmgNumPrimaryTextBox;
        private Label rangeLabel;
        private TextBox rangeNormalTextBox;
        private Label slash1;
        private TextBox rangeLongTextBox;
        private Label thrownLabel;
        private TextBox thrownLongTextBox;
        private TextBox thrownNormalTextBox;
        private Label slash2;
        private Label costLabel;
        private TextBox costValueTextBox;
        private ComboBox costUnitComboBox;
        private Label weightLabel;
        private TextBox weightTextBox;
        private Label lbsLabel;
        private CheckedListBox propCheckList;
        private Label propLabel;
        private TextBox descTextBox;
        private Label descLabel;
        private Button cancelBtn;
        private Button okBtn;
        private Label ftLabel;
        private Label specialLabel;
        private TextBox specialTextBox;
    }
}