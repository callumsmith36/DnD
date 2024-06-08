namespace CharacterManager
{
    partial class AttackCreateForm
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
            cancelBtn = new Button();
            okBtn = new Button();
            bonusLabel = new Label();
            nameTextBox = new TextBox();
            atkRollRadioBtn = new RadioButton();
            saveRadioBtn = new RadioButton();
            dmgLabel = new Label();
            saveAbilityComboBox = new ComboBox();
            weaponRadioBtn = new RadioButton();
            spellRadioBtn = new RadioButton();
            atkRollPanel = new Panel();
            weaponAtkPanel = new Panel();
            weaponProfCheckBox = new CheckBox();
            weaponProfLabel = new Label();
            weaponBonusNumCtrl = new NumericUpDown();
            weaponBonusLabel = new Label();
            weaponAbilityComboBox = new ComboBox();
            weaponAbilityLabel = new Label();
            savePanel = new Panel();
            panel2 = new Panel();
            plusLabel2 = new Label();
            dmgModNumCtrl = new NumericUpDown();
            plusLabel1 = new Label();
            dmgAbilityComboBox = new ComboBox();
            dmgDiceComboBox = new ComboBox();
            dmgDiceNumCtrl = new NumericUpDown();
            atkRollPanel.SuspendLayout();
            weaponAtkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weaponBonusNumCtrl).BeginInit();
            savePanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dmgModNumCtrl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dmgDiceNumCtrl).BeginInit();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(183, 338);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 99;
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
            okBtn.Location = new Point(67, 338);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 98;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // bonusLabel
            // 
            bonusLabel.AutoSize = true;
            bonusLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            bonusLabel.Location = new Point(12, 97);
            bonusLabel.Name = "bonusLabel";
            bonusLabel.Size = new Size(61, 21);
            bonusLabel.TabIndex = 96;
            bonusLabel.Text = "Bonus";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Constantia", 14F);
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Weapon/Spell Name";
            nameTextBox.Size = new Size(275, 36);
            nameTextBox.TabIndex = 95;
            nameTextBox.TabStop = false;
            // 
            // atkRollRadioBtn
            // 
            atkRollRadioBtn.AutoSize = true;
            atkRollRadioBtn.Checked = true;
            atkRollRadioBtn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            atkRollRadioBtn.Location = new Point(12, 64);
            atkRollRadioBtn.Name = "atkRollRadioBtn";
            atkRollRadioBtn.Size = new Size(100, 22);
            atkRollRadioBtn.TabIndex = 100;
            atkRollRadioBtn.TabStop = true;
            atkRollRadioBtn.Text = "Attack Roll";
            atkRollRadioBtn.UseVisualStyleBackColor = true;
            atkRollRadioBtn.CheckedChanged += atkRollRadioBtn_CheckedChanged;
            // 
            // saveRadioBtn
            // 
            saveRadioBtn.AutoSize = true;
            saveRadioBtn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveRadioBtn.Location = new Point(128, 64);
            saveRadioBtn.Name = "saveRadioBtn";
            saveRadioBtn.Size = new Size(119, 22);
            saveRadioBtn.TabIndex = 101;
            saveRadioBtn.Text = "Saving Throw";
            saveRadioBtn.UseVisualStyleBackColor = true;
            saveRadioBtn.CheckedChanged += saveRadioBtn_CheckedChanged;
            // 
            // dmgLabel
            // 
            dmgLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dmgLabel.AutoSize = true;
            dmgLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            dmgLabel.Location = new Point(12, 226);
            dmgLabel.Name = "dmgLabel";
            dmgLabel.Size = new Size(75, 21);
            dmgLabel.TabIndex = 102;
            dmgLabel.Text = "Damage";
            // 
            // saveAbilityComboBox
            // 
            saveAbilityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            saveAbilityComboBox.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveAbilityComboBox.FormattingEnabled = true;
            saveAbilityComboBox.Items.AddRange(new object[] { "STR", "DEX", "CON", "INT", "WIS", "CHA" });
            saveAbilityComboBox.Location = new Point(3, 3);
            saveAbilityComboBox.Name = "saveAbilityComboBox";
            saveAbilityComboBox.Size = new Size(70, 26);
            saveAbilityComboBox.TabIndex = 104;
            // 
            // weaponRadioBtn
            // 
            weaponRadioBtn.AutoSize = true;
            weaponRadioBtn.Checked = true;
            weaponRadioBtn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponRadioBtn.Location = new Point(3, 3);
            weaponRadioBtn.Name = "weaponRadioBtn";
            weaponRadioBtn.Size = new Size(82, 22);
            weaponRadioBtn.TabIndex = 105;
            weaponRadioBtn.TabStop = true;
            weaponRadioBtn.Text = "Weapon";
            weaponRadioBtn.UseVisualStyleBackColor = true;
            weaponRadioBtn.CheckedChanged += weaponRadioBtn_CheckedChanged;
            // 
            // spellRadioBtn
            // 
            spellRadioBtn.AutoSize = true;
            spellRadioBtn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spellRadioBtn.Location = new Point(96, 3);
            spellRadioBtn.Name = "spellRadioBtn";
            spellRadioBtn.Size = new Size(60, 22);
            spellRadioBtn.TabIndex = 106;
            spellRadioBtn.Text = "Spell";
            spellRadioBtn.UseVisualStyleBackColor = true;
            spellRadioBtn.CheckedChanged += spellRadioBtn_CheckedChanged;
            // 
            // atkRollPanel
            // 
            atkRollPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            atkRollPanel.Controls.Add(weaponAtkPanel);
            atkRollPanel.Controls.Add(weaponRadioBtn);
            atkRollPanel.Controls.Add(spellRadioBtn);
            atkRollPanel.Location = new Point(93, 92);
            atkRollPanel.Name = "atkRollPanel";
            atkRollPanel.Size = new Size(194, 119);
            atkRollPanel.TabIndex = 107;
            // 
            // weaponAtkPanel
            // 
            weaponAtkPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            weaponAtkPanel.Controls.Add(weaponProfCheckBox);
            weaponAtkPanel.Controls.Add(weaponProfLabel);
            weaponAtkPanel.Controls.Add(weaponBonusNumCtrl);
            weaponAtkPanel.Controls.Add(weaponBonusLabel);
            weaponAtkPanel.Controls.Add(weaponAbilityComboBox);
            weaponAtkPanel.Controls.Add(weaponAbilityLabel);
            weaponAtkPanel.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponAtkPanel.Location = new Point(3, 31);
            weaponAtkPanel.Name = "weaponAtkPanel";
            weaponAtkPanel.Size = new Size(188, 85);
            weaponAtkPanel.TabIndex = 107;
            // 
            // weaponProfCheckBox
            // 
            weaponProfCheckBox.AutoSize = true;
            weaponProfCheckBox.Location = new Point(115, 63);
            weaponProfCheckBox.Name = "weaponProfCheckBox";
            weaponProfCheckBox.Size = new Size(18, 17);
            weaponProfCheckBox.TabIndex = 109;
            weaponProfCheckBox.UseVisualStyleBackColor = true;
            // 
            // weaponProfLabel
            // 
            weaponProfLabel.AutoSize = true;
            weaponProfLabel.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponProfLabel.Location = new Point(3, 61);
            weaponProfLabel.Name = "weaponProfLabel";
            weaponProfLabel.Size = new Size(81, 18);
            weaponProfLabel.TabIndex = 108;
            weaponProfLabel.Text = "Proficiency";
            // 
            // weaponBonusNumCtrl
            // 
            weaponBonusNumCtrl.Location = new Point(115, 31);
            weaponBonusNumCtrl.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            weaponBonusNumCtrl.Minimum = new decimal(new int[] { 99, 0, 0, int.MinValue });
            weaponBonusNumCtrl.Name = "weaponBonusNumCtrl";
            weaponBonusNumCtrl.Size = new Size(70, 26);
            weaponBonusNumCtrl.TabIndex = 107;
            weaponBonusNumCtrl.TextAlign = HorizontalAlignment.Center;
            // 
            // weaponBonusLabel
            // 
            weaponBonusLabel.AutoSize = true;
            weaponBonusLabel.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponBonusLabel.Location = new Point(3, 33);
            weaponBonusLabel.Name = "weaponBonusLabel";
            weaponBonusLabel.Size = new Size(106, 18);
            weaponBonusLabel.TabIndex = 106;
            weaponBonusLabel.Text = "Weapon Bonus";
            // 
            // weaponAbilityComboBox
            // 
            weaponAbilityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            weaponAbilityComboBox.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponAbilityComboBox.FormattingEnabled = true;
            weaponAbilityComboBox.Items.AddRange(new object[] { "STR", "DEX", "CON", "INT", "WIS", "CHA" });
            weaponAbilityComboBox.Location = new Point(115, 2);
            weaponAbilityComboBox.Name = "weaponAbilityComboBox";
            weaponAbilityComboBox.Size = new Size(70, 26);
            weaponAbilityComboBox.TabIndex = 105;
            // 
            // weaponAbilityLabel
            // 
            weaponAbilityLabel.AutoSize = true;
            weaponAbilityLabel.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponAbilityLabel.Location = new Point(3, 5);
            weaponAbilityLabel.Name = "weaponAbilityLabel";
            weaponAbilityLabel.Size = new Size(50, 18);
            weaponAbilityLabel.TabIndex = 97;
            weaponAbilityLabel.Text = "Ability";
            // 
            // savePanel
            // 
            savePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            savePanel.Controls.Add(saveAbilityComboBox);
            savePanel.Enabled = false;
            savePanel.Location = new Point(93, 92);
            savePanel.Name = "savePanel";
            savePanel.Size = new Size(194, 32);
            savePanel.TabIndex = 108;
            savePanel.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(plusLabel2);
            panel2.Controls.Add(dmgModNumCtrl);
            panel2.Controls.Add(plusLabel1);
            panel2.Controls.Add(dmgAbilityComboBox);
            panel2.Controls.Add(dmgDiceComboBox);
            panel2.Controls.Add(dmgDiceNumCtrl);
            panel2.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(93, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 101);
            panel2.TabIndex = 109;
            // 
            // plusLabel2
            // 
            plusLabel2.AutoSize = true;
            plusLabel2.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plusLabel2.Location = new Point(3, 63);
            plusLabel2.Name = "plusLabel2";
            plusLabel2.Size = new Size(25, 28);
            plusLabel2.TabIndex = 115;
            plusLabel2.Text = "+";
            // 
            // dmgModNumCtrl
            // 
            dmgModNumCtrl.Location = new Point(34, 69);
            dmgModNumCtrl.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            dmgModNumCtrl.Minimum = new decimal(new int[] { 99, 0, 0, int.MinValue });
            dmgModNumCtrl.Name = "dmgModNumCtrl";
            dmgModNumCtrl.Size = new Size(70, 26);
            dmgModNumCtrl.TabIndex = 114;
            dmgModNumCtrl.TextAlign = HorizontalAlignment.Center;
            // 
            // plusLabel1
            // 
            plusLabel1.AutoSize = true;
            plusLabel1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plusLabel1.Location = new Point(3, 32);
            plusLabel1.Name = "plusLabel1";
            plusLabel1.Size = new Size(25, 28);
            plusLabel1.TabIndex = 113;
            plusLabel1.Text = "+";
            // 
            // dmgAbilityComboBox
            // 
            dmgAbilityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dmgAbilityComboBox.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dmgAbilityComboBox.FormattingEnabled = true;
            dmgAbilityComboBox.Items.AddRange(new object[] { "None", "STR", "DEX", "CON", "INT", "WIS", "CHA" });
            dmgAbilityComboBox.Location = new Point(34, 37);
            dmgAbilityComboBox.Name = "dmgAbilityComboBox";
            dmgAbilityComboBox.Size = new Size(70, 26);
            dmgAbilityComboBox.TabIndex = 112;
            // 
            // dmgDiceComboBox
            // 
            dmgDiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dmgDiceComboBox.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dmgDiceComboBox.FormattingEnabled = true;
            dmgDiceComboBox.Items.AddRange(new object[] { "d4", "d6", "d8", "d10", "d12", "d20" });
            dmgDiceComboBox.Location = new Point(79, 3);
            dmgDiceComboBox.Name = "dmgDiceComboBox";
            dmgDiceComboBox.Size = new Size(70, 26);
            dmgDiceComboBox.TabIndex = 111;
            // 
            // dmgDiceNumCtrl
            // 
            dmgDiceNumCtrl.Location = new Point(3, 3);
            dmgDiceNumCtrl.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            dmgDiceNumCtrl.Name = "dmgDiceNumCtrl";
            dmgDiceNumCtrl.Size = new Size(70, 26);
            dmgDiceNumCtrl.TabIndex = 110;
            dmgDiceNumCtrl.TextAlign = HorizontalAlignment.Center;
            dmgDiceNumCtrl.UpDownAlign = LeftRightAlignment.Left;
            // 
            // AttackCreateForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(299, 382);
            Controls.Add(panel2);
            Controls.Add(dmgLabel);
            Controls.Add(saveRadioBtn);
            Controls.Add(atkRollRadioBtn);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(nameTextBox);
            Controls.Add(bonusLabel);
            Controls.Add(savePanel);
            Controls.Add(atkRollPanel);
            Name = "AttackCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Attack";
            atkRollPanel.ResumeLayout(false);
            atkRollPanel.PerformLayout();
            weaponAtkPanel.ResumeLayout(false);
            weaponAtkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)weaponBonusNumCtrl).EndInit();
            savePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dmgModNumCtrl).EndInit();
            ((System.ComponentModel.ISupportInitialize)dmgDiceNumCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button okBtn;
        private TextBox sourceNameTextBox;
        private Label bonusLabel;
        private TextBox nameTextBox;
        private RadioButton atkRollRadioBtn;
        private RadioButton saveRadioBtn;
        private TextBox textBox1;
        private Label dmgLabel;
        private ComboBox saveAbilityComboBox;
        private RadioButton weaponRadioBtn;
        private RadioButton spellRadioBtn;
        private Panel atkRollPanel;
        private Panel savePanel;
        private Panel panel2;
        private Panel weaponAtkPanel;
        private ComboBox weaponAbilityComboBox;
        private Label weaponAbilityLabel;
        private NumericUpDown weaponBonusNumCtrl;
        private Label weaponBonusLabel;
        private CheckBox weaponProfCheckBox;
        private Label weaponProfLabel;
        private NumericUpDown dmgDiceNumCtrl;
        private ComboBox dmgDiceComboBox;
        private Label plusLabel1;
        private ComboBox dmgAbilityComboBox;
        private Label plusLabel2;
        private NumericUpDown dmgModNumCtrl;
    }
}