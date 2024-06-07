namespace CharacterManager
{
    partial class FeatCreateForm
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
            sourceLabel = new Label();
            sourceComboBox = new ComboBox();
            sourceNameTextBox = new TextBox();
            sourceNameLabel = new Label();
            limitedLabel = new Label();
            limitedCheckBox = new CheckBox();
            usesLabel = new Label();
            usesNumCtrl = new NumericUpDown();
            perLabel = new Label();
            frequencyComboBox = new ComboBox();
            descLabel = new Label();
            descTextBox = new TextBox();
            cancelBtn = new Button();
            okBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)usesNumCtrl).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Constantia", 14F);
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Feat Name";
            nameTextBox.Size = new Size(328, 36);
            nameTextBox.TabIndex = 46;
            nameTextBox.TabStop = false;
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            sourceLabel.Location = new Point(12, 61);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new Size(64, 21);
            sourceLabel.TabIndex = 79;
            sourceLabel.Text = "Source";
            // 
            // sourceComboBox
            // 
            sourceComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sourceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sourceComboBox.Font = new Font("Constantia", 10F);
            sourceComboBox.FormattingEnabled = true;
            sourceComboBox.Items.AddRange(new object[] { "Class", "Race", "Other" });
            sourceComboBox.Location = new Point(135, 58);
            sourceComboBox.Name = "sourceComboBox";
            sourceComboBox.Size = new Size(204, 29);
            sourceComboBox.TabIndex = 78;
            // 
            // sourceNameTextBox
            // 
            sourceNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sourceNameTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sourceNameTextBox.Location = new Point(135, 98);
            sourceNameTextBox.MaxLength = 100;
            sourceNameTextBox.Multiline = true;
            sourceNameTextBox.Name = "sourceNameTextBox";
            sourceNameTextBox.Size = new Size(204, 29);
            sourceNameTextBox.TabIndex = 84;
            // 
            // sourceNameLabel
            // 
            sourceNameLabel.AutoSize = true;
            sourceNameLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            sourceNameLabel.Location = new Point(12, 101);
            sourceNameLabel.Name = "sourceNameLabel";
            sourceNameLabel.Size = new Size(115, 21);
            sourceNameLabel.TabIndex = 83;
            sourceNameLabel.Text = "Source Name";
            // 
            // limitedLabel
            // 
            limitedLabel.AutoSize = true;
            limitedLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            limitedLabel.Location = new Point(12, 142);
            limitedLabel.Name = "limitedLabel";
            limitedLabel.Size = new Size(109, 21);
            limitedLabel.TabIndex = 85;
            limitedLabel.Text = "Limited Use";
            // 
            // limitedCheckBox
            // 
            limitedCheckBox.AutoSize = true;
            limitedCheckBox.Checked = true;
            limitedCheckBox.CheckState = CheckState.Checked;
            limitedCheckBox.Location = new Point(135, 145);
            limitedCheckBox.Name = "limitedCheckBox";
            limitedCheckBox.Size = new Size(18, 17);
            limitedCheckBox.TabIndex = 86;
            limitedCheckBox.UseVisualStyleBackColor = true;
            limitedCheckBox.CheckedChanged += limitedCheckBox_CheckedChanged;
            // 
            // usesLabel
            // 
            usesLabel.AutoSize = true;
            usesLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            usesLabel.Location = new Point(12, 183);
            usesLabel.Name = "usesLabel";
            usesLabel.Size = new Size(48, 21);
            usesLabel.TabIndex = 87;
            usesLabel.Text = "Uses";
            // 
            // usesNumCtrl
            // 
            usesNumCtrl.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usesNumCtrl.Location = new Point(135, 181);
            usesNumCtrl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            usesNumCtrl.Name = "usesNumCtrl";
            usesNumCtrl.Size = new Size(51, 28);
            usesNumCtrl.TabIndex = 88;
            usesNumCtrl.TextAlign = HorizontalAlignment.Center;
            usesNumCtrl.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // perLabel
            // 
            perLabel.AutoSize = true;
            perLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perLabel.Location = new Point(192, 183);
            perLabel.Name = "perLabel";
            perLabel.Size = new Size(35, 21);
            perLabel.TabIndex = 89;
            perLabel.Text = "per";
            // 
            // frequencyComboBox
            // 
            frequencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            frequencyComboBox.Font = new Font("Constantia", 10F);
            frequencyComboBox.FormattingEnabled = true;
            frequencyComboBox.Items.AddRange(new object[] { "Short Rest", "Long Rest", "Day" });
            frequencyComboBox.Location = new Point(233, 180);
            frequencyComboBox.Name = "frequencyComboBox";
            frequencyComboBox.Size = new Size(106, 29);
            frequencyComboBox.TabIndex = 90;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descLabel.Location = new Point(12, 219);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 92;
            descLabel.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.Font = new Font("Constantia", 9F);
            descTextBox.Location = new Point(12, 243);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(327, 80);
            descTextBox.TabIndex = 91;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(226, 344);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 94;
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
            okBtn.Location = new Point(110, 344);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 93;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // FeatCreateForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(352, 388);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(frequencyComboBox);
            Controls.Add(perLabel);
            Controls.Add(usesNumCtrl);
            Controls.Add(usesLabel);
            Controls.Add(limitedCheckBox);
            Controls.Add(limitedLabel);
            Controls.Add(sourceNameTextBox);
            Controls.Add(sourceNameLabel);
            Controls.Add(sourceLabel);
            Controls.Add(sourceComboBox);
            Controls.Add(nameTextBox);
            MinimumSize = new Size(370, 300);
            Name = "FeatCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Feat";
            ((System.ComponentModel.ISupportInitialize)usesNumCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label sourceLabel;
        private ComboBox sourceComboBox;
        private TextBox sourceNameTextBox;
        private Label sourceNameLabel;
        private Label limitedLabel;
        private CheckBox limitedCheckBox;
        private Label usesLabel;
        private NumericUpDown usesNumCtrl;
        private Label perLabel;
        private ComboBox frequencyComboBox;
        private Label descLabel;
        private TextBox descTextBox;
        private Button cancelBtn;
        private Button okBtn;
    }
}