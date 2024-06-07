namespace CharacterManager
{
    partial class ClassCreateForm
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
            hpLabel = new Label();
            hitDieLabel = new Label();
            hitDiceComboBox = new ComboBox();
            profLabel = new Label();
            armourCheckList = new CheckedListBox();
            weaponCheckList = new CheckedListBox();
            weaponTypeCheckList = new CheckedListBox();
            savingThrowCheckList = new CheckedListBox();
            skillCheckList = new CheckedListBox();
            toolCheckList = new CheckedListBox();
            savingThrowTab = new TabControl();
            armourTab = new TabPage();
            weaponTab = new TabPage();
            tabPage1 = new TabPage();
            skillTab = new TabPage();
            label1 = new Label();
            skillChooseNumCtrl = new NumericUpDown();
            skillChooseLabel = new Label();
            toolTab = new TabPage();
            spellLabel = new Label();
            spellAbilityLabel = new Label();
            spellAbilityComboBox = new ComboBox();
            spellcasterCheck = new CheckBox();
            spellListLabel = new Label();
            spellListComboBox = new ComboBox();
            spellListBtn = new Button();
            cancelBtn = new Button();
            okBtn = new Button();
            savingThrowTab.SuspendLayout();
            armourTab.SuspendLayout();
            weaponTab.SuspendLayout();
            tabPage1.SuspendLayout();
            skillTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)skillChooseNumCtrl).BeginInit();
            toolTab.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Constantia", 14F);
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Class Name";
            nameTextBox.Size = new Size(517, 30);
            nameTextBox.TabIndex = 0;
            // 
            // hpLabel
            // 
            hpLabel.AutoSize = true;
            hpLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            hpLabel.Location = new Point(9, 92);
            hpLabel.Name = "hpLabel";
            hpLabel.Size = new Size(85, 19);
            hpLabel.TabIndex = 1;
            hpLabel.Text = "Hit Points";
            // 
            // hitDieLabel
            // 
            hitDieLabel.AutoSize = true;
            hitDieLabel.Font = new Font("Constantia", 10F);
            hitDieLabel.Location = new Point(12, 124);
            hitDieLabel.Name = "hitDieLabel";
            hitDieLabel.Size = new Size(54, 17);
            hitDieLabel.TabIndex = 2;
            hitDieLabel.Text = "Hit Die";
            // 
            // hitDiceComboBox
            // 
            hitDiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            hitDiceComboBox.Font = new Font("Constantia", 10F);
            hitDiceComboBox.FormattingEnabled = true;
            hitDiceComboBox.Items.AddRange(new object[] { "d4", "d6", "d8", "d10", "d12", "d20" });
            hitDiceComboBox.Location = new Point(82, 121);
            hitDiceComboBox.Name = "hitDiceComboBox";
            hitDiceComboBox.Size = new Size(61, 23);
            hitDiceComboBox.TabIndex = 3;
            // 
            // profLabel
            // 
            profLabel.AutoSize = true;
            profLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            profLabel.Location = new Point(9, 163);
            profLabel.Name = "profLabel";
            profLabel.Size = new Size(108, 19);
            profLabel.TabIndex = 4;
            profLabel.Text = "Proficiencies";
            // 
            // armourCheckList
            // 
            armourCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            armourCheckList.BackColor = SystemColors.Window;
            armourCheckList.BorderStyle = BorderStyle.None;
            armourCheckList.CheckOnClick = true;
            armourCheckList.ColumnWidth = 140;
            armourCheckList.Font = new Font("Constantia", 10F);
            armourCheckList.FormattingEnabled = true;
            armourCheckList.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "Shields" });
            armourCheckList.Location = new Point(6, 6);
            armourCheckList.MultiColumn = true;
            armourCheckList.Name = "armourCheckList";
            armourCheckList.Size = new Size(500, 76);
            armourCheckList.TabIndex = 7;
            // 
            // weaponCheckList
            // 
            weaponCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            weaponCheckList.BackColor = SystemColors.Window;
            weaponCheckList.BorderStyle = BorderStyle.None;
            weaponCheckList.CheckOnClick = true;
            weaponCheckList.ColumnWidth = 160;
            weaponCheckList.Font = new Font("Constantia", 10F);
            weaponCheckList.FormattingEnabled = true;
            weaponCheckList.Items.AddRange(new object[] { "Battleaxes", "Blowguns", "Clubs", "Crossbows, heavy", "Crossbows, light", "Daggers", "Darts", "Flails", "Glaives", "Greataxes", "Greatclubs", "Greatswords", "Halberds", "Hand crossbows", "Handaxes", "Javelins", "Lances", "Light hammers", "Longbows", "Longswords", "Maces", "Mauls", "Nets", "Morningstars", "Pikes", "Quarterstaffs", "Rapiers", "Scimitars", "Shortbows", "Shortswords", "Sickles", "Slings", "Spears", "Tridents", "War picks", "Warhammers", "Whips" });
            weaponCheckList.Location = new Point(6, 40);
            weaponCheckList.MultiColumn = true;
            weaponCheckList.Name = "weaponCheckList";
            weaponCheckList.Size = new Size(500, 247);
            weaponCheckList.TabIndex = 9;
            // 
            // weaponTypeCheckList
            // 
            weaponTypeCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            weaponTypeCheckList.BackColor = SystemColors.Window;
            weaponTypeCheckList.BorderStyle = BorderStyle.None;
            weaponTypeCheckList.CheckOnClick = true;
            weaponTypeCheckList.ColumnWidth = 160;
            weaponTypeCheckList.Font = new Font("Constantia", 10F);
            weaponTypeCheckList.FormattingEnabled = true;
            weaponTypeCheckList.Items.AddRange(new object[] { "Simple Weapons", "Martial Weapons" });
            weaponTypeCheckList.Location = new Point(6, 6);
            weaponTypeCheckList.MultiColumn = true;
            weaponTypeCheckList.Name = "weaponTypeCheckList";
            weaponTypeCheckList.Size = new Size(500, 19);
            weaponTypeCheckList.TabIndex = 10;
            // 
            // savingThrowCheckList
            // 
            savingThrowCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            savingThrowCheckList.BackColor = SystemColors.Window;
            savingThrowCheckList.BorderStyle = BorderStyle.None;
            savingThrowCheckList.CheckOnClick = true;
            savingThrowCheckList.ColumnWidth = 160;
            savingThrowCheckList.Font = new Font("Constantia", 10F);
            savingThrowCheckList.FormattingEnabled = true;
            savingThrowCheckList.Items.AddRange(new object[] { "STR", "DEX", "CON", "INT", "WIS", "CHA" });
            savingThrowCheckList.Location = new Point(6, 6);
            savingThrowCheckList.MultiColumn = true;
            savingThrowCheckList.Name = "savingThrowCheckList";
            savingThrowCheckList.Size = new Size(500, 152);
            savingThrowCheckList.TabIndex = 12;
            // 
            // skillCheckList
            // 
            skillCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            skillCheckList.BackColor = SystemColors.Window;
            skillCheckList.BorderStyle = BorderStyle.None;
            skillCheckList.CheckOnClick = true;
            skillCheckList.ColumnWidth = 160;
            skillCheckList.Font = new Font("Constantia", 10F);
            skillCheckList.FormattingEnabled = true;
            skillCheckList.Items.AddRange(new object[] { "Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "History", "Insight", "Intimidation", "Investigation", "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand", "Stealth", "Survival" });
            skillCheckList.Location = new Point(6, 45);
            skillCheckList.MultiColumn = true;
            skillCheckList.Name = "skillCheckList";
            skillCheckList.Size = new Size(500, 114);
            skillCheckList.TabIndex = 14;
            // 
            // toolCheckList
            // 
            toolCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toolCheckList.BackColor = SystemColors.Window;
            toolCheckList.BorderStyle = BorderStyle.None;
            toolCheckList.CheckOnClick = true;
            toolCheckList.ColumnWidth = 250;
            toolCheckList.Font = new Font("Constantia", 10F);
            toolCheckList.FormattingEnabled = true;
            toolCheckList.Items.AddRange(new object[] { "Alchemist's Supplies", "Artisan's Tools", "Brewer's Supplies", "Calligrapher's Supplies", "Carpenter's Tools", "Cartographer's Tools", "Cobbler's Tools", "Cook's utensils", "Disguise Kit", "Forgery Kit", "Glassblower's Tools", "Herbalism Kit", "Jeweler's Tools", "Leatherworker's Tools", "Mason's Tools", "Navigator's Tools", "Painter's Supplies", "Poisoner's Kit", "Potter's Tools", "Smith's Tools", "Thieves' Tools", "Tinker's Tools", "Weaver's Tools", "Woodcarver's Tools" });
            toolCheckList.Location = new Point(6, 6);
            toolCheckList.MultiColumn = true;
            toolCheckList.Name = "toolCheckList";
            toolCheckList.Size = new Size(500, 228);
            toolCheckList.TabIndex = 16;
            // 
            // savingThrowTab
            // 
            savingThrowTab.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            savingThrowTab.Controls.Add(armourTab);
            savingThrowTab.Controls.Add(weaponTab);
            savingThrowTab.Controls.Add(tabPage1);
            savingThrowTab.Controls.Add(skillTab);
            savingThrowTab.Controls.Add(toolTab);
            savingThrowTab.Font = new Font("Constantia", 10F);
            savingThrowTab.Location = new Point(12, 190);
            savingThrowTab.Name = "savingThrowTab";
            savingThrowTab.SelectedIndex = 0;
            savingThrowTab.Size = new Size(520, 338);
            savingThrowTab.TabIndex = 17;
            // 
            // armourTab
            // 
            armourTab.Controls.Add(armourCheckList);
            armourTab.Location = new Point(4, 24);
            armourTab.Name = "armourTab";
            armourTab.Padding = new Padding(3);
            armourTab.Size = new Size(512, 310);
            armourTab.TabIndex = 0;
            armourTab.Text = "Armour";
            armourTab.UseVisualStyleBackColor = true;
            // 
            // weaponTab
            // 
            weaponTab.Controls.Add(weaponTypeCheckList);
            weaponTab.Controls.Add(weaponCheckList);
            weaponTab.Location = new Point(4, 24);
            weaponTab.Name = "weaponTab";
            weaponTab.Padding = new Padding(3);
            weaponTab.Size = new Size(512, 310);
            weaponTab.TabIndex = 1;
            weaponTab.Text = "Weapons";
            weaponTab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(savingThrowCheckList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(512, 310);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Saving Throws";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // skillTab
            // 
            skillTab.Controls.Add(label1);
            skillTab.Controls.Add(skillChooseNumCtrl);
            skillTab.Controls.Add(skillChooseLabel);
            skillTab.Controls.Add(skillCheckList);
            skillTab.Location = new Point(4, 24);
            skillTab.Name = "skillTab";
            skillTab.Padding = new Padding(3);
            skillTab.Size = new Size(512, 310);
            skillTab.TabIndex = 3;
            skillTab.Text = "Skills";
            skillTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 10F);
            label1.Location = new Point(133, 8);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 17;
            label1.Text = "from:";
            // 
            // skillChooseNumCtrl
            // 
            skillChooseNumCtrl.Location = new Point(76, 6);
            skillChooseNumCtrl.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            skillChooseNumCtrl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            skillChooseNumCtrl.Name = "skillChooseNumCtrl";
            skillChooseNumCtrl.Size = new Size(51, 24);
            skillChooseNumCtrl.TabIndex = 16;
            skillChooseNumCtrl.TextAlign = HorizontalAlignment.Center;
            skillChooseNumCtrl.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // skillChooseLabel
            // 
            skillChooseLabel.AutoSize = true;
            skillChooseLabel.Font = new Font("Constantia", 10F);
            skillChooseLabel.Location = new Point(6, 8);
            skillChooseLabel.Name = "skillChooseLabel";
            skillChooseLabel.Size = new Size(54, 17);
            skillChooseLabel.TabIndex = 15;
            skillChooseLabel.Text = "Choose";
            // 
            // toolTab
            // 
            toolTab.Controls.Add(toolCheckList);
            toolTab.Location = new Point(4, 24);
            toolTab.Name = "toolTab";
            toolTab.Padding = new Padding(3);
            toolTab.Size = new Size(512, 310);
            toolTab.TabIndex = 4;
            toolTab.Text = "Tools";
            toolTab.UseVisualStyleBackColor = true;
            // 
            // spellLabel
            // 
            spellLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            spellLabel.AutoSize = true;
            spellLabel.Font = new Font("Constantia", 12F, FontStyle.Bold);
            spellLabel.Location = new Point(9, 540);
            spellLabel.Name = "spellLabel";
            spellLabel.Size = new Size(100, 19);
            spellLabel.TabIndex = 18;
            spellLabel.Text = "Spellcasting";
            // 
            // spellAbilityLabel
            // 
            spellAbilityLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            spellAbilityLabel.AutoSize = true;
            spellAbilityLabel.Font = new Font("Constantia", 10F);
            spellAbilityLabel.Location = new Point(12, 572);
            spellAbilityLabel.Name = "spellAbilityLabel";
            spellAbilityLabel.Size = new Size(49, 17);
            spellAbilityLabel.TabIndex = 19;
            spellAbilityLabel.Text = "Ability";
            // 
            // spellAbilityComboBox
            // 
            spellAbilityComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            spellAbilityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            spellAbilityComboBox.Font = new Font("Constantia", 10F);
            spellAbilityComboBox.FormattingEnabled = true;
            spellAbilityComboBox.Items.AddRange(new object[] { "STR", "DEX", "CON", "INT", "WIS", "CHA" });
            spellAbilityComboBox.Location = new Point(77, 569);
            spellAbilityComboBox.Name = "spellAbilityComboBox";
            spellAbilityComboBox.Size = new Size(72, 23);
            spellAbilityComboBox.TabIndex = 20;
            // 
            // spellcasterCheck
            // 
            spellcasterCheck.AutoSize = true;
            spellcasterCheck.Font = new Font("Constantia", 10F);
            spellcasterCheck.Location = new Point(16, 54);
            spellcasterCheck.Name = "spellcasterCheck";
            spellcasterCheck.Size = new Size(93, 21);
            spellcasterCheck.TabIndex = 21;
            spellcasterCheck.Text = "Spellcaster";
            spellcasterCheck.UseVisualStyleBackColor = true;
            spellcasterCheck.CheckedChanged += spellcasterCheck_CheckedChanged;
            // 
            // spellListLabel
            // 
            spellListLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            spellListLabel.AutoSize = true;
            spellListLabel.Enabled = false;
            spellListLabel.Font = new Font("Constantia", 10F);
            spellListLabel.Location = new Point(165, 572);
            spellListLabel.Name = "spellListLabel";
            spellListLabel.Size = new Size(65, 17);
            spellListLabel.TabIndex = 22;
            spellListLabel.Text = "Spell List";
            spellListLabel.Visible = false;
            // 
            // spellListComboBox
            // 
            spellListComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            spellListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            spellListComboBox.Enabled = false;
            spellListComboBox.Font = new Font("Constantia", 10F);
            spellListComboBox.FormattingEnabled = true;
            spellListComboBox.Items.AddRange(new object[] { "Bard", "Cleric", "Druid", "Paladin", "Ranger", "Sorcerer", "Warlock", "Wizard" });
            spellListComboBox.Location = new Point(249, 569);
            spellListComboBox.Name = "spellListComboBox";
            spellListComboBox.Size = new Size(177, 23);
            spellListComboBox.TabIndex = 23;
            spellListComboBox.Visible = false;
            // 
            // spellListBtn
            // 
            spellListBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            spellListBtn.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spellListBtn.Location = new Point(175, 569);
            spellListBtn.Name = "spellListBtn";
            spellListBtn.Size = new Size(107, 23);
            spellListBtn.TabIndex = 24;
            spellListBtn.Text = "Set Spell List...";
            spellListBtn.UseVisualStyleBackColor = true;
            spellListBtn.Click += spellListBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(403, 616);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 26;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            okBtn.BackColor = Color.Gainsboro;
            okBtn.Font = new Font("Constantia", 10.2F);
            okBtn.ForeColor = SystemColors.ControlText;
            okBtn.Location = new Point(287, 616);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 25;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // ClassCreateForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(543, 660);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(spellListBtn);
            Controls.Add(spellListComboBox);
            Controls.Add(spellListLabel);
            Controls.Add(spellcasterCheck);
            Controls.Add(spellAbilityComboBox);
            Controls.Add(spellAbilityLabel);
            Controls.Add(spellLabel);
            Controls.Add(savingThrowTab);
            Controls.Add(profLabel);
            Controls.Add(hitDiceComboBox);
            Controls.Add(hitDieLabel);
            Controls.Add(hpLabel);
            Controls.Add(nameTextBox);
            Font = new Font("Constantia", 9F);
            MinimumSize = new Size(559, 613);
            Name = "ClassCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Class";
            savingThrowTab.ResumeLayout(false);
            armourTab.ResumeLayout(false);
            weaponTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            skillTab.ResumeLayout(false);
            skillTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)skillChooseNumCtrl).EndInit();
            toolTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label hpLabel;
        private Label hitDieLabel;
        private ComboBox hitDiceComboBox;
        private Label profLabel;
        private CheckedListBox armourCheckList;
        private CheckedListBox weaponCheckList;
        private CheckedListBox weaponTypeCheckList;
        private CheckedListBox savingThrowCheckList;
        private CheckedListBox skillCheckList;
        private CheckedListBox toolCheckList;
        private TabControl savingThrowTab;
        private TabPage armourTab;
        private TabPage weaponTab;
        private TabPage tabPage1;
        private TabPage skillTab;
        private TabPage toolTab;
        private Label skillChooseLabel;
        private Label label1;
        private NumericUpDown skillChooseNumCtrl;
        private Label spellLabel;
        private Label spellAbilityLabel;
        private ComboBox spellAbilityComboBox;
        private CheckBox spellcasterCheck;
        private Label spellListLabel;
        private ComboBox spellListComboBox;
        private Button spellListBtn;
        private Button cancelBtn;
        private Button okBtn;
    }
}