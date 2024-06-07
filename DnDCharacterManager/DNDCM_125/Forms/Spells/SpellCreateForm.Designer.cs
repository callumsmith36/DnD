namespace CharacterManager
{
    partial class SpellCreateForm
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
            higherLvlTextBox = new TextBox();
            higherLvlLabel = new Label();
            descTextBox = new TextBox();
            descLabel = new Label();
            durationLabel = new Label();
            durationTextBox = new TextBox();
            materialLabel = new Label();
            materialTextBox = new TextBox();
            componentLabel = new Label();
            materialCheck = new CheckBox();
            somaticCheck = new CheckBox();
            verbalCheck = new CheckBox();
            rangeTextBox = new TextBox();
            rangeLabel = new Label();
            timeTextBox = new TextBox();
            timeLabel = new Label();
            schoolLabel = new Label();
            levelNumCtrl = new NumericUpDown();
            concentrationCheck = new CheckBox();
            ritualCheck = new CheckBox();
            schoolComboBox = new ComboBox();
            levelLabel = new Label();
            nameTextBox = new TextBox();
            classLabel = new Label();
            classCheckList = new CheckedListBox();
            cancelBtn = new Button();
            okBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)levelNumCtrl).BeginInit();
            SuspendLayout();
            // 
            // higherLvlTextBox
            // 
            higherLvlTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            higherLvlTextBox.Font = new Font("Constantia", 9F);
            higherLvlTextBox.Location = new Point(12, 523);
            higherLvlTextBox.Multiline = true;
            higherLvlTextBox.Name = "higherLvlTextBox";
            higherLvlTextBox.ScrollBars = ScrollBars.Vertical;
            higherLvlTextBox.Size = new Size(816, 76);
            higherLvlTextBox.TabIndex = 66;
            // 
            // higherLvlLabel
            // 
            higherLvlLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            higherLvlLabel.AutoSize = true;
            higherLvlLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            higherLvlLabel.Location = new Point(12, 499);
            higherLvlLabel.Name = "higherLvlLabel";
            higherLvlLabel.Size = new Size(142, 21);
            higherLvlLabel.TabIndex = 65;
            higherLvlLabel.Text = "At Higher Levels";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.Font = new Font("Constantia", 9F);
            descTextBox.Location = new Point(12, 306);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(816, 175);
            descTextBox.TabIndex = 64;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            descLabel.Location = new Point(12, 282);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 63;
            descLabel.Text = "Description";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            durationLabel.Location = new Point(573, 118);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(84, 21);
            durationLabel.TabIndex = 62;
            durationLabel.Text = "Duration";
            // 
            // durationTextBox
            // 
            durationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            durationTextBox.Font = new Font("Constantia", 10F);
            durationTextBox.Location = new Point(663, 115);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(165, 28);
            durationTextBox.TabIndex = 61;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            materialLabel.Location = new Point(12, 212);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(87, 21);
            materialLabel.TabIndex = 60;
            materialLabel.Text = "Materials";
            // 
            // materialTextBox
            // 
            materialTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox.Font = new Font("Constantia", 10F);
            materialTextBox.Location = new Point(12, 236);
            materialTextBox.Name = "materialTextBox";
            materialTextBox.ScrollBars = ScrollBars.Vertical;
            materialTextBox.Size = new Size(816, 28);
            materialTextBox.TabIndex = 59;
            // 
            // componentLabel
            // 
            componentLabel.AutoSize = true;
            componentLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            componentLabel.Location = new Point(12, 165);
            componentLabel.Name = "componentLabel";
            componentLabel.Size = new Size(113, 21);
            componentLabel.TabIndex = 58;
            componentLabel.Text = "Components";
            // 
            // materialCheck
            // 
            materialCheck.AutoSize = true;
            materialCheck.Font = new Font("Constantia", 10F);
            materialCheck.Location = new Point(231, 164);
            materialCheck.Name = "materialCheck";
            materialCheck.Size = new Size(47, 25);
            materialCheck.TabIndex = 57;
            materialCheck.Text = "M";
            materialCheck.UseVisualStyleBackColor = true;
            // 
            // somaticCheck
            // 
            somaticCheck.AutoSize = true;
            somaticCheck.Font = new Font("Constantia", 10F);
            somaticCheck.Location = new Point(184, 164);
            somaticCheck.Name = "somaticCheck";
            somaticCheck.Size = new Size(41, 25);
            somaticCheck.TabIndex = 56;
            somaticCheck.Text = "S";
            somaticCheck.UseVisualStyleBackColor = true;
            // 
            // verbalCheck
            // 
            verbalCheck.AutoSize = true;
            verbalCheck.Font = new Font("Constantia", 10F);
            verbalCheck.Location = new Point(135, 164);
            verbalCheck.Name = "verbalCheck";
            verbalCheck.Size = new Size(43, 25);
            verbalCheck.TabIndex = 55;
            verbalCheck.Text = "V";
            verbalCheck.UseVisualStyleBackColor = true;
            // 
            // rangeTextBox
            // 
            rangeTextBox.Font = new Font("Constantia", 10F);
            rangeTextBox.Location = new Point(387, 115);
            rangeTextBox.Name = "rangeTextBox";
            rangeTextBox.Size = new Size(165, 28);
            rangeTextBox.TabIndex = 54;
            // 
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            rangeLabel.Location = new Point(321, 118);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(60, 21);
            rangeLabel.TabIndex = 53;
            rangeLabel.Text = "Range";
            // 
            // timeTextBox
            // 
            timeTextBox.Font = new Font("Constantia", 10F);
            timeTextBox.Location = new Point(135, 115);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(165, 28);
            timeTextBox.TabIndex = 52;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            timeLabel.Location = new Point(12, 118);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(117, 21);
            timeLabel.TabIndex = 51;
            timeLabel.Text = "Casting Time";
            // 
            // schoolLabel
            // 
            schoolLabel.AutoSize = true;
            schoolLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            schoolLabel.Location = new Point(153, 63);
            schoolLabel.Name = "schoolLabel";
            schoolLabel.Size = new Size(64, 21);
            schoolLabel.TabIndex = 50;
            schoolLabel.Text = "School";
            // 
            // levelNumCtrl
            // 
            levelNumCtrl.Font = new Font("Constantia", 10F);
            levelNumCtrl.Location = new Point(71, 61);
            levelNumCtrl.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            levelNumCtrl.Name = "levelNumCtrl";
            levelNumCtrl.Size = new Size(61, 28);
            levelNumCtrl.TabIndex = 49;
            levelNumCtrl.TextAlign = HorizontalAlignment.Center;
            // 
            // concentrationCheck
            // 
            concentrationCheck.AutoSize = true;
            concentrationCheck.Font = new Font("Constantia", 10F, FontStyle.Bold);
            concentrationCheck.Location = new Point(397, 62);
            concentrationCheck.Name = "concentrationCheck";
            concentrationCheck.Size = new Size(149, 25);
            concentrationCheck.TabIndex = 48;
            concentrationCheck.Text = "Concentration";
            concentrationCheck.UseVisualStyleBackColor = true;
            // 
            // ritualCheck
            // 
            ritualCheck.AutoSize = true;
            ritualCheck.Font = new Font("Constantia", 10F, FontStyle.Bold);
            ritualCheck.Location = new Point(562, 62);
            ritualCheck.Name = "ritualCheck";
            ritualCheck.Size = new Size(83, 25);
            ritualCheck.TabIndex = 47;
            ritualCheck.Text = "Ritual";
            ritualCheck.UseVisualStyleBackColor = true;
            // 
            // schoolComboBox
            // 
            schoolComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            schoolComboBox.Font = new Font("Constantia", 10F);
            schoolComboBox.FormattingEnabled = true;
            schoolComboBox.Items.AddRange(new object[] { "Abjuration", "Conjuration", "Divination", "Enchantment", "Evocation", "Illusion", "Necromancy", "Transmutation" });
            schoolComboBox.Location = new Point(223, 60);
            schoolComboBox.Name = "schoolComboBox";
            schoolComboBox.Size = new Size(143, 29);
            schoolComboBox.TabIndex = 46;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            levelLabel.Location = new Point(12, 63);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(53, 21);
            levelLabel.TabIndex = 45;
            levelLabel.Text = "Level";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Constantia", 14F);
            nameTextBox.Location = new Point(14, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Spell Name";
            nameTextBox.Size = new Size(814, 36);
            nameTextBox.TabIndex = 44;
            nameTextBox.TabStop = false;
            // 
            // classLabel
            // 
            classLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            classLabel.Location = new Point(12, 617);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(69, 21);
            classLabel.TabIndex = 67;
            classLabel.Text = "Classes";
            // 
            // classCheckList
            // 
            classCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            classCheckList.BackColor = Color.WhiteSmoke;
            classCheckList.BorderStyle = BorderStyle.None;
            classCheckList.CheckOnClick = true;
            classCheckList.ColumnWidth = 150;
            classCheckList.Font = new Font("Constantia", 10.2F);
            classCheckList.FormattingEnabled = true;
            classCheckList.Location = new Point(14, 641);
            classCheckList.MultiColumn = true;
            classCheckList.Name = "classCheckList";
            classCheckList.Size = new Size(814, 69);
            classCheckList.TabIndex = 68;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(679, 725);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 70;
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
            okBtn.Location = new Point(563, 725);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 69;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // SpellCreateForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(840, 769);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(classCheckList);
            Controls.Add(classLabel);
            Controls.Add(higherLvlTextBox);
            Controls.Add(higherLvlLabel);
            Controls.Add(descTextBox);
            Controls.Add(descLabel);
            Controls.Add(durationLabel);
            Controls.Add(durationTextBox);
            Controls.Add(materialLabel);
            Controls.Add(materialTextBox);
            Controls.Add(componentLabel);
            Controls.Add(materialCheck);
            Controls.Add(somaticCheck);
            Controls.Add(verbalCheck);
            Controls.Add(rangeTextBox);
            Controls.Add(rangeLabel);
            Controls.Add(timeTextBox);
            Controls.Add(timeLabel);
            Controls.Add(schoolLabel);
            Controls.Add(levelNumCtrl);
            Controls.Add(concentrationCheck);
            Controls.Add(ritualCheck);
            Controls.Add(schoolComboBox);
            Controls.Add(levelLabel);
            Controls.Add(nameTextBox);
            Name = "SpellCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Spell";
            ((System.ComponentModel.ISupportInitialize)levelNumCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox higherLvlTextBox;
        private Label higherLvlLabel;
        private TextBox descTextBox;
        private Label descLabel;
        private Label durationLabel;
        private TextBox durationTextBox;
        private Label materialLabel;
        private TextBox materialTextBox;
        private Label componentLabel;
        private CheckBox materialCheck;
        private CheckBox somaticCheck;
        private CheckBox verbalCheck;
        private TextBox rangeTextBox;
        private Label rangeLabel;
        private TextBox timeTextBox;
        private Label timeLabel;
        private Label schoolLabel;
        private NumericUpDown levelNumCtrl;
        private CheckBox concentrationCheck;
        private CheckBox ritualCheck;
        private ComboBox schoolComboBox;
        private Label levelLabel;
        private TextBox nameTextBox;
        private Label classLabel;
        private CheckedListBox classCheckList;
        private Button cancelBtn;
        private Button okBtn;
    }
}