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
            nameTextBox.Location = new Point(10, 10);
            nameTextBox.Margin = new Padding(2, 2, 2, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Item Name";
            nameTextBox.Size = new Size(391, 30);
            nameTextBox.TabIndex = 45;
            nameTextBox.TabStop = false;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            categoryLabel.Location = new Point(10, 114);
            categoryLabel.Margin = new Padding(2, 0, 2, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(67, 17);
            categoryLabel.TabIndex = 52;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Constantia", 10F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Simple", "Martial" });
            categoryComboBox.Location = new Point(108, 112);
            categoryComboBox.Margin = new Padding(2, 2, 2, 2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(74, 23);
            categoryComboBox.TabIndex = 51;
            // 
            // rangeComboBox
            // 
            rangeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rangeComboBox.Font = new Font("Constantia", 10F);
            rangeComboBox.FormattingEnabled = true;
            rangeComboBox.Items.AddRange(new object[] { "Melee", "Ranged" });
            rangeComboBox.Location = new Point(186, 112);
            rangeComboBox.Margin = new Padding(2, 2, 2, 2);
            rangeComboBox.Name = "rangeComboBox";
            rangeComboBox.Size = new Size(74, 23);
            rangeComboBox.TabIndex = 53;
            rangeComboBox.SelectedIndexChanged += rangeComboBox_SelectedIndexChanged;
            // 
            // dmgDicePrimaryComboBox
            // 
            dmgDicePrimaryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dmgDicePrimaryComboBox.Font = new Font("Constantia", 10F);
            dmgDicePrimaryComboBox.FormattingEnabled = true;
            dmgDicePrimaryComboBox.Items.AddRange(new object[] { "d4", "d6", "d8", "d10", "d12", "d20" });
            dmgDicePrimaryComboBox.Location = new Point(154, 145);
            dmgDicePrimaryComboBox.Margin = new Padding(2, 2, 2, 2);
            dmgDicePrimaryComboBox.Name = "dmgDicePrimaryComboBox";
            dmgDicePrimaryComboBox.Size = new Size(59, 23);
            dmgDicePrimaryComboBox.TabIndex = 55;
            // 
            // dmgDiceLabel
            // 
            dmgDiceLabel.AutoSize = true;
            dmgDiceLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dmgDiceLabel.Location = new Point(10, 147);
            dmgDiceLabel.Margin = new Padding(2, 0, 2, 0);
            dmgDiceLabel.Name = "dmgDiceLabel";
            dmgDiceLabel.Size = new Size(98, 17);
            dmgDiceLabel.TabIndex = 54;
            dmgDiceLabel.Text = "Damage Dice";
            // 
            // dmgTypeLabel
            // 
            dmgTypeLabel.AutoSize = true;
            dmgTypeLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dmgTypeLabel.Location = new Point(10, 180);
            dmgTypeLabel.Margin = new Padding(2, 0, 2, 0);
            dmgTypeLabel.Name = "dmgTypeLabel";
            dmgTypeLabel.Size = new Size(99, 17);
            dmgTypeLabel.TabIndex = 57;
            dmgTypeLabel.Text = "Damage Type";
            // 
            // dmgDice2Label
            // 
            dmgDice2Label.AutoSize = true;
            dmgDice2Label.Enabled = false;
            dmgDice2Label.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dmgDice2Label.Location = new Point(225, 147);
            dmgDice2Label.Margin = new Padding(2, 0, 2, 0);
            dmgDice2Label.Name = "dmgDice2Label";
            dmgDice2Label.Size = new Size(67, 17);
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
            dmgDiceSecondaryComboBox.Location = new Point(340, 145);
            dmgDiceSecondaryComboBox.Margin = new Padding(2, 2, 2, 2);
            dmgDiceSecondaryComboBox.Name = "dmgDiceSecondaryComboBox";
            dmgDiceSecondaryComboBox.Size = new Size(59, 23);
            dmgDiceSecondaryComboBox.TabIndex = 60;
            dmgDiceSecondaryComboBox.Visible = false;
            // 
            // dmgTypeComboBox
            // 
            dmgTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dmgTypeComboBox.Font = new Font("Constantia", 10F);
            dmgTypeComboBox.FormattingEnabled = true;
            dmgTypeComboBox.Items.AddRange(new object[] { "Bludgeoning", "Piercing", "Slashing" });
            dmgTypeComboBox.Location = new Point(108, 178);
            dmgTypeComboBox.Margin = new Padding(2, 2, 2, 2);
            dmgTypeComboBox.Name = "dmgTypeComboBox";
            dmgTypeComboBox.Size = new Size(105, 23);
            dmgTypeComboBox.TabIndex = 61;
            // 
            // dmgNumSecondaryTextBox
            // 
            dmgNumSecondaryTextBox.Enabled = false;
            dmgNumSecondaryTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dmgNumSecondaryTextBox.Location = new Point(294, 145);
            dmgNumSecondaryTextBox.Margin = new Padding(2, 2, 2, 2);
            dmgNumSecondaryTextBox.MaxLength = 1;
            dmgNumSecondaryTextBox.Multiline = true;
            dmgNumSecondaryTextBox.Name = "dmgNumSecondaryTextBox";
            dmgNumSecondaryTextBox.Size = new Size(42, 24);
            dmgNumSecondaryTextBox.TabIndex = 62;
            dmgNumSecondaryTextBox.Text = "1";
            dmgNumSecondaryTextBox.TextAlign = HorizontalAlignment.Center;
            dmgNumSecondaryTextBox.Visible = false;
            dmgNumSecondaryTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // dmgNumPrimaryTextBox
            // 
            dmgNumPrimaryTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dmgNumPrimaryTextBox.Location = new Point(108, 145);
            dmgNumPrimaryTextBox.Margin = new Padding(2, 2, 2, 2);
            dmgNumPrimaryTextBox.MaxLength = 1;
            dmgNumPrimaryTextBox.Multiline = true;
            dmgNumPrimaryTextBox.Name = "dmgNumPrimaryTextBox";
            dmgNumPrimaryTextBox.Size = new Size(42, 24);
            dmgNumPrimaryTextBox.TabIndex = 63;
            dmgNumPrimaryTextBox.Text = "1";
            dmgNumPrimaryTextBox.TextAlign = HorizontalAlignment.Center;
            dmgNumPrimaryTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rangeLabel.Location = new Point(10, 213);
            rangeLabel.Margin = new Padding(2, 0, 2, 0);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(51, 17);
            rangeLabel.TabIndex = 64;
            rangeLabel.Text = "Range";
            // 
            // rangeNormalTextBox
            // 
            rangeNormalTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rangeNormalTextBox.Location = new Point(108, 210);
            rangeNormalTextBox.Margin = new Padding(2, 2, 2, 2);
            rangeNormalTextBox.MaxLength = 4;
            rangeNormalTextBox.Multiline = true;
            rangeNormalTextBox.Name = "rangeNormalTextBox";
            rangeNormalTextBox.Size = new Size(42, 24);
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
            slash1.Location = new Point(150, 208);
            slash1.Margin = new Padding(2, 0, 2, 0);
            slash1.Name = "slash1";
            slash1.Size = new Size(21, 27);
            slash1.TabIndex = 66;
            slash1.Text = "/";
            slash1.Visible = false;
            // 
            // rangeLongTextBox
            // 
            rangeLongTextBox.Enabled = false;
            rangeLongTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rangeLongTextBox.Location = new Point(171, 210);
            rangeLongTextBox.Margin = new Padding(2, 2, 2, 2);
            rangeLongTextBox.MaxLength = 4;
            rangeLongTextBox.Multiline = true;
            rangeLongTextBox.Name = "rangeLongTextBox";
            rangeLongTextBox.Size = new Size(42, 24);
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
            thrownLabel.Location = new Point(225, 213);
            thrownLabel.Margin = new Padding(2, 0, 2, 0);
            thrownLabel.Name = "thrownLabel";
            thrownLabel.Size = new Size(60, 17);
            thrownLabel.TabIndex = 68;
            thrownLabel.Text = "Thrown";
            thrownLabel.Visible = false;
            // 
            // thrownLongTextBox
            // 
            thrownLongTextBox.Enabled = false;
            thrownLongTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thrownLongTextBox.Location = new Point(358, 210);
            thrownLongTextBox.Margin = new Padding(2, 2, 2, 2);
            thrownLongTextBox.MaxLength = 4;
            thrownLongTextBox.Multiline = true;
            thrownLongTextBox.Name = "thrownLongTextBox";
            thrownLongTextBox.Size = new Size(42, 24);
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
            thrownNormalTextBox.Location = new Point(294, 210);
            thrownNormalTextBox.Margin = new Padding(2, 2, 2, 2);
            thrownNormalTextBox.MaxLength = 4;
            thrownNormalTextBox.Multiline = true;
            thrownNormalTextBox.Name = "thrownNormalTextBox";
            thrownNormalTextBox.Size = new Size(42, 24);
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
            slash2.Location = new Point(337, 208);
            slash2.Margin = new Padding(2, 0, 2, 0);
            slash2.Name = "slash2";
            slash2.Size = new Size(21, 27);
            slash2.TabIndex = 70;
            slash2.Text = "/";
            slash2.Visible = false;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            costLabel.Location = new Point(10, 49);
            costLabel.Margin = new Padding(2, 0, 2, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(36, 17);
            costLabel.TabIndex = 72;
            costLabel.Text = "Cost";
            // 
            // costValueTextBox
            // 
            costValueTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            costValueTextBox.Location = new Point(108, 46);
            costValueTextBox.Margin = new Padding(2, 2, 2, 2);
            costValueTextBox.MaxLength = 8;
            costValueTextBox.Multiline = true;
            costValueTextBox.Name = "costValueTextBox";
            costValueTextBox.Size = new Size(74, 24);
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
            costUnitComboBox.Location = new Point(186, 46);
            costUnitComboBox.Margin = new Padding(2, 2, 2, 2);
            costUnitComboBox.Name = "costUnitComboBox";
            costUnitComboBox.Size = new Size(47, 23);
            costUnitComboBox.TabIndex = 74;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            weightLabel.Location = new Point(10, 82);
            weightLabel.Margin = new Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(56, 17);
            weightLabel.TabIndex = 75;
            weightLabel.Text = "Weight";
            // 
            // weightTextBox
            // 
            weightTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightTextBox.Location = new Point(108, 79);
            weightTextBox.Margin = new Padding(2, 2, 2, 2);
            weightTextBox.MaxLength = 8;
            weightTextBox.Multiline = true;
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(74, 24);
            weightTextBox.TabIndex = 76;
            weightTextBox.Text = "0";
            weightTextBox.TextAlign = HorizontalAlignment.Center;
            weightTextBox.KeyPress += textBox_CheckDecimalInput;
            // 
            // lbsLabel
            // 
            lbsLabel.AutoSize = true;
            lbsLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbsLabel.Location = new Point(61, 82);
            lbsLabel.Margin = new Padding(2, 0, 2, 0);
            lbsLabel.Name = "lbsLabel";
            lbsLabel.Size = new Size(36, 17);
            lbsLabel.TabIndex = 77;
            lbsLabel.Text = "(lbs)";
            // 
            // propCheckList
            // 
            propCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            propCheckList.BackColor = Color.WhiteSmoke;
            propCheckList.BorderStyle = BorderStyle.None;
            propCheckList.CheckOnClick = true;
            propCheckList.ColumnWidth = 120;
            propCheckList.Font = new Font("Constantia", 10.2F);
            propCheckList.FormattingEnabled = true;
            propCheckList.Items.AddRange(new object[] { "Ammunition", "Finesse", "Heavy", "Light", "Loading", "Monk", "Range", "Reach", "Special", "Thrown", "Two-Handed", "Versatile" });
            propCheckList.Location = new Point(10, 265);
            propCheckList.Margin = new Padding(2, 2, 2, 2);
            propCheckList.MultiColumn = true;
            propCheckList.Name = "propCheckList";
            propCheckList.Size = new Size(390, 76);
            propCheckList.TabIndex = 78;
            propCheckList.ItemCheck += propCheckList_ItemCheck;
            // 
            // propLabel
            // 
            propLabel.AutoSize = true;
            propLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            propLabel.Location = new Point(10, 246);
            propLabel.Margin = new Padding(2, 0, 2, 0);
            propLabel.Name = "propLabel";
            propLabel.Size = new Size(78, 17);
            propLabel.TabIndex = 79;
            propLabel.Text = "Properties";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.Font = new Font("Constantia", 9F);
            descTextBox.Location = new Point(10, 377);
            descTextBox.Margin = new Padding(2, 2, 2, 2);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(391, 74);
            descTextBox.TabIndex = 80;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descLabel.Location = new Point(10, 358);
            descLabel.Margin = new Padding(2, 0, 2, 0);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(87, 17);
            descLabel.TabIndex = 81;
            descLabel.Text = "Description";
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(307, 575);
            cancelBtn.Margin = new Padding(2, 2, 2, 5);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
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
            okBtn.Location = new Point(214, 575);
            okBtn.Margin = new Padding(2, 2, 2, 5);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 82;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // ftLabel
            // 
            ftLabel.AutoSize = true;
            ftLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ftLabel.Location = new Point(54, 213);
            ftLabel.Margin = new Padding(2, 0, 2, 0);
            ftLabel.Name = "ftLabel";
            ftLabel.Size = new Size(27, 17);
            ftLabel.TabIndex = 84;
            ftLabel.Text = "(ft)";
            // 
            // specialLabel
            // 
            specialLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            specialLabel.AutoSize = true;
            specialLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialLabel.Location = new Point(10, 459);
            specialLabel.Margin = new Padding(2, 0, 2, 0);
            specialLabel.Name = "specialLabel";
            specialLabel.Size = new Size(57, 17);
            specialLabel.TabIndex = 86;
            specialLabel.Text = "Special";
            // 
            // specialTextBox
            // 
            specialTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            specialTextBox.Font = new Font("Constantia", 9F);
            specialTextBox.Location = new Point(10, 479);
            specialTextBox.Margin = new Padding(2, 2, 2, 2);
            specialTextBox.Multiline = true;
            specialTextBox.Name = "specialTextBox";
            specialTextBox.ScrollBars = ScrollBars.Vertical;
            specialTextBox.Size = new Size(391, 85);
            specialTextBox.TabIndex = 85;
            // 
            // WeaponCreateForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(411, 610);
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
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(427, 632);
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