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
            higherLvlTextBox.Location = new Point(10, 418);
            higherLvlTextBox.Margin = new Padding(2);
            higherLvlTextBox.Multiline = true;
            higherLvlTextBox.Name = "higherLvlTextBox";
            higherLvlTextBox.ScrollBars = ScrollBars.Vertical;
            higherLvlTextBox.Size = new Size(651, 62);
            higherLvlTextBox.TabIndex = 66;
            // 
            // higherLvlLabel
            // 
            higherLvlLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            higherLvlLabel.AutoSize = true;
            higherLvlLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            higherLvlLabel.Location = new Point(10, 399);
            higherLvlLabel.Margin = new Padding(2, 0, 2, 0);
            higherLvlLabel.Name = "higherLvlLabel";
            higherLvlLabel.Size = new Size(118, 17);
            higherLvlLabel.TabIndex = 65;
            higherLvlLabel.Text = "At Higher Levels";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.Font = new Font("Constantia", 9F);
            descTextBox.Location = new Point(10, 245);
            descTextBox.Margin = new Padding(2);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(651, 141);
            descTextBox.TabIndex = 64;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            descLabel.Location = new Point(10, 226);
            descLabel.Margin = new Padding(2, 0, 2, 0);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(87, 17);
            descLabel.TabIndex = 63;
            descLabel.Text = "Description";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            durationLabel.Location = new Point(458, 94);
            durationLabel.Margin = new Padding(2, 0, 2, 0);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(69, 17);
            durationLabel.TabIndex = 62;
            durationLabel.Text = "Duration";
            // 
            // durationTextBox
            // 
            durationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            durationTextBox.Font = new Font("Constantia", 10F);
            durationTextBox.Location = new Point(530, 92);
            durationTextBox.Margin = new Padding(2);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(131, 24);
            durationTextBox.TabIndex = 61;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            materialLabel.Location = new Point(10, 170);
            materialLabel.Margin = new Padding(2, 0, 2, 0);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(72, 17);
            materialLabel.TabIndex = 60;
            materialLabel.Text = "Materials";
            // 
            // materialTextBox
            // 
            materialTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox.Font = new Font("Constantia", 10F);
            materialTextBox.Location = new Point(10, 189);
            materialTextBox.Margin = new Padding(2);
            materialTextBox.Name = "materialTextBox";
            materialTextBox.ScrollBars = ScrollBars.Vertical;
            materialTextBox.Size = new Size(651, 24);
            materialTextBox.TabIndex = 59;
            // 
            // componentLabel
            // 
            componentLabel.AutoSize = true;
            componentLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            componentLabel.Location = new Point(10, 132);
            componentLabel.Margin = new Padding(2, 0, 2, 0);
            componentLabel.Name = "componentLabel";
            componentLabel.Size = new Size(92, 17);
            componentLabel.TabIndex = 58;
            componentLabel.Text = "Components";
            // 
            // materialCheck
            // 
            materialCheck.AutoSize = true;
            materialCheck.Font = new Font("Constantia", 10F);
            materialCheck.Location = new Point(185, 131);
            materialCheck.Margin = new Padding(2);
            materialCheck.Name = "materialCheck";
            materialCheck.Size = new Size(40, 21);
            materialCheck.TabIndex = 57;
            materialCheck.Text = "M";
            materialCheck.UseVisualStyleBackColor = true;
            // 
            // somaticCheck
            // 
            somaticCheck.AutoSize = true;
            somaticCheck.Font = new Font("Constantia", 10F);
            somaticCheck.Location = new Point(147, 131);
            somaticCheck.Margin = new Padding(2);
            somaticCheck.Name = "somaticCheck";
            somaticCheck.Size = new Size(34, 21);
            somaticCheck.TabIndex = 56;
            somaticCheck.Text = "S";
            somaticCheck.UseVisualStyleBackColor = true;
            // 
            // verbalCheck
            // 
            verbalCheck.AutoSize = true;
            verbalCheck.Font = new Font("Constantia", 10F);
            verbalCheck.Location = new Point(108, 131);
            verbalCheck.Margin = new Padding(2);
            verbalCheck.Name = "verbalCheck";
            verbalCheck.Size = new Size(36, 21);
            verbalCheck.TabIndex = 55;
            verbalCheck.Text = "V";
            verbalCheck.UseVisualStyleBackColor = true;
            // 
            // rangeTextBox
            // 
            rangeTextBox.Font = new Font("Constantia", 10F);
            rangeTextBox.Location = new Point(310, 92);
            rangeTextBox.Margin = new Padding(2);
            rangeTextBox.Name = "rangeTextBox";
            rangeTextBox.Size = new Size(133, 24);
            rangeTextBox.TabIndex = 54;
            // 
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            rangeLabel.Location = new Point(257, 94);
            rangeLabel.Margin = new Padding(2, 0, 2, 0);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(51, 17);
            rangeLabel.TabIndex = 53;
            rangeLabel.Text = "Range";
            // 
            // timeTextBox
            // 
            timeTextBox.Font = new Font("Constantia", 10F);
            timeTextBox.Location = new Point(108, 92);
            timeTextBox.Margin = new Padding(2);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(133, 24);
            timeTextBox.TabIndex = 52;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            timeLabel.Location = new Point(10, 94);
            timeLabel.Margin = new Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(96, 17);
            timeLabel.TabIndex = 51;
            timeLabel.Text = "Casting Time";
            // 
            // schoolLabel
            // 
            schoolLabel.AutoSize = true;
            schoolLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            schoolLabel.Location = new Point(122, 50);
            schoolLabel.Margin = new Padding(2, 0, 2, 0);
            schoolLabel.Name = "schoolLabel";
            schoolLabel.Size = new Size(52, 17);
            schoolLabel.TabIndex = 50;
            schoolLabel.Text = "School";
            // 
            // levelNumCtrl
            // 
            levelNumCtrl.Font = new Font("Constantia", 10F);
            levelNumCtrl.Location = new Point(57, 49);
            levelNumCtrl.Margin = new Padding(2);
            levelNumCtrl.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            levelNumCtrl.Name = "levelNumCtrl";
            levelNumCtrl.Size = new Size(49, 24);
            levelNumCtrl.TabIndex = 49;
            levelNumCtrl.TextAlign = HorizontalAlignment.Center;
            // 
            // concentrationCheck
            // 
            concentrationCheck.AutoSize = true;
            concentrationCheck.Font = new Font("Constantia", 10F, FontStyle.Bold);
            concentrationCheck.Location = new Point(318, 50);
            concentrationCheck.Margin = new Padding(2);
            concentrationCheck.Name = "concentrationCheck";
            concentrationCheck.Size = new Size(123, 21);
            concentrationCheck.TabIndex = 48;
            concentrationCheck.Text = "Concentration";
            concentrationCheck.UseVisualStyleBackColor = true;
            // 
            // ritualCheck
            // 
            ritualCheck.AutoSize = true;
            ritualCheck.Font = new Font("Constantia", 10F, FontStyle.Bold);
            ritualCheck.Location = new Point(450, 50);
            ritualCheck.Margin = new Padding(2);
            ritualCheck.Name = "ritualCheck";
            ritualCheck.Size = new Size(69, 21);
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
            schoolComboBox.Location = new Point(178, 48);
            schoolComboBox.Margin = new Padding(2);
            schoolComboBox.Name = "schoolComboBox";
            schoolComboBox.Size = new Size(115, 23);
            schoolComboBox.TabIndex = 46;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            levelLabel.Location = new Point(10, 50);
            levelLabel.Margin = new Padding(2, 0, 2, 0);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(44, 17);
            levelLabel.TabIndex = 45;
            levelLabel.Text = "Level";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Constantia", 14F);
            nameTextBox.Location = new Point(11, 10);
            nameTextBox.Margin = new Padding(2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Spell Name";
            nameTextBox.Size = new Size(650, 30);
            nameTextBox.TabIndex = 44;
            nameTextBox.TabStop = false;
            // 
            // classLabel
            // 
            classLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            classLabel.Location = new Point(10, 494);
            classLabel.Margin = new Padding(2, 0, 2, 0);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(56, 17);
            classLabel.TabIndex = 67;
            classLabel.Text = "Classes";
            // 
            // classCheckList
            // 
            classCheckList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            classCheckList.BackColor = Color.WhiteSmoke;
            classCheckList.BorderStyle = BorderStyle.None;
            classCheckList.CheckOnClick = true;
            classCheckList.ColumnWidth = 120;
            classCheckList.Font = new Font("Constantia", 10.2F);
            classCheckList.FormattingEnabled = true;
            classCheckList.Location = new Point(11, 513);
            classCheckList.Margin = new Padding(2);
            classCheckList.MultiColumn = true;
            classCheckList.Name = "classCheckList";
            classCheckList.Size = new Size(650, 57);
            classCheckList.TabIndex = 68;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(543, 586);
            cancelBtn.Margin = new Padding(2, 2, 2, 5);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
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
            okBtn.Location = new Point(450, 586);
            okBtn.Margin = new Padding(2, 2, 2, 5);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 69;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // SpellCreateForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(672, 621);
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
            Margin = new Padding(2);
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