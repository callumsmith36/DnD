namespace CharacterManager
{
    partial class ArmourCreateForm
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
            weightTextBox = new TextBox();
            weightLabel = new Label();
            costUnitComboBox = new ComboBox();
            costValueTextBox = new TextBox();
            costLabel = new Label();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            nameTextBox = new TextBox();
            acTextBox = new TextBox();
            acLabel = new Label();
            dexCheckBox = new CheckBox();
            maxBonusLabel = new Label();
            label1 = new Label();
            maxBonusNumCtrl = new NumericUpDown();
            maxBonusCheckBox = new CheckBox();
            minStrLabel = new Label();
            minStrCheckBox = new CheckBox();
            minStrNumCtrl = new NumericUpDown();
            stealthLabel = new Label();
            stealthCheckBox = new CheckBox();
            descLabel = new Label();
            descTextBox = new TextBox();
            cancelBtn = new Button();
            okBtn = new Button();
            lbsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)maxBonusNumCtrl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minStrNumCtrl).BeginInit();
            SuspendLayout();
            // 
            // weightTextBox
            // 
            weightTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightTextBox.Location = new Point(135, 99);
            weightTextBox.MaxLength = 8;
            weightTextBox.Multiline = true;
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(91, 29);
            weightTextBox.TabIndex = 84;
            weightTextBox.Text = "0";
            weightTextBox.TextAlign = HorizontalAlignment.Center;
            weightTextBox.KeyPress += textBox_CheckDecimalInput;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            weightLabel.Location = new Point(12, 102);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(68, 21);
            weightLabel.TabIndex = 83;
            weightLabel.Text = "Weight";
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
            costUnitComboBox.TabIndex = 82;
            // 
            // costValueTextBox
            // 
            costValueTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            costValueTextBox.Location = new Point(135, 58);
            costValueTextBox.MaxLength = 8;
            costValueTextBox.Multiline = true;
            costValueTextBox.Name = "costValueTextBox";
            costValueTextBox.Size = new Size(91, 29);
            costValueTextBox.TabIndex = 81;
            costValueTextBox.Text = "0";
            costValueTextBox.TextAlign = HorizontalAlignment.Center;
            costValueTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            costLabel.Location = new Point(12, 61);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(46, 21);
            costLabel.TabIndex = 80;
            costLabel.Text = "Cost";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            categoryLabel.Location = new Point(12, 143);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(81, 21);
            categoryLabel.TabIndex = 79;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Constantia", 10F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "Shield" });
            categoryComboBox.Location = new Point(135, 140);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(91, 29);
            categoryComboBox.TabIndex = 78;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Constantia", 14F);
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Item Name";
            nameTextBox.Size = new Size(366, 36);
            nameTextBox.TabIndex = 77;
            nameTextBox.TabStop = false;
            // 
            // acTextBox
            // 
            acTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acTextBox.Location = new Point(135, 181);
            acTextBox.MaxLength = 2;
            acTextBox.Multiline = true;
            acTextBox.Name = "acTextBox";
            acTextBox.Size = new Size(91, 29);
            acTextBox.TabIndex = 86;
            acTextBox.Text = "1";
            acTextBox.TextAlign = HorizontalAlignment.Center;
            acTextBox.KeyPress += textBox_CheckIntegerInput;
            // 
            // acLabel
            // 
            acLabel.AutoSize = true;
            acLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acLabel.Location = new Point(12, 184);
            acLabel.Name = "acLabel";
            acLabel.Size = new Size(73, 21);
            acLabel.TabIndex = 85;
            acLabel.Text = "Base AC";
            // 
            // dexCheckBox
            // 
            dexCheckBox.AutoSize = true;
            dexCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            dexCheckBox.Location = new Point(135, 228);
            dexCheckBox.Name = "dexCheckBox";
            dexCheckBox.Size = new Size(18, 17);
            dexCheckBox.TabIndex = 87;
            dexCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            dexCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxBonusLabel
            // 
            maxBonusLabel.AutoSize = true;
            maxBonusLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            maxBonusLabel.Location = new Point(12, 266);
            maxBonusLabel.Name = "maxBonusLabel";
            maxBonusLabel.Size = new Size(99, 21);
            maxBonusLabel.TabIndex = 89;
            maxBonusLabel.Text = "Max Bonus";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 225);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 90;
            label1.Text = "Dex Bonus";
            // 
            // maxBonusNumCtrl
            // 
            maxBonusNumCtrl.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxBonusNumCtrl.Location = new Point(159, 264);
            maxBonusNumCtrl.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            maxBonusNumCtrl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            maxBonusNumCtrl.Name = "maxBonusNumCtrl";
            maxBonusNumCtrl.Size = new Size(67, 28);
            maxBonusNumCtrl.TabIndex = 91;
            maxBonusNumCtrl.TextAlign = HorizontalAlignment.Center;
            maxBonusNumCtrl.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // maxBonusCheckBox
            // 
            maxBonusCheckBox.AutoSize = true;
            maxBonusCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            maxBonusCheckBox.Location = new Point(135, 269);
            maxBonusCheckBox.Name = "maxBonusCheckBox";
            maxBonusCheckBox.Size = new Size(18, 17);
            maxBonusCheckBox.TabIndex = 92;
            maxBonusCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            maxBonusCheckBox.UseVisualStyleBackColor = true;
            // 
            // minStrLabel
            // 
            minStrLabel.AutoSize = true;
            minStrLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            minStrLabel.Location = new Point(12, 307);
            minStrLabel.Name = "minStrLabel";
            minStrLabel.Size = new Size(117, 21);
            minStrLabel.TabIndex = 93;
            minStrLabel.Text = "Min Strength";
            // 
            // minStrCheckBox
            // 
            minStrCheckBox.AutoSize = true;
            minStrCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            minStrCheckBox.Location = new Point(135, 310);
            minStrCheckBox.Name = "minStrCheckBox";
            minStrCheckBox.Size = new Size(18, 17);
            minStrCheckBox.TabIndex = 95;
            minStrCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            minStrCheckBox.UseVisualStyleBackColor = true;
            // 
            // minStrNumCtrl
            // 
            minStrNumCtrl.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minStrNumCtrl.Location = new Point(159, 305);
            minStrNumCtrl.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            minStrNumCtrl.Name = "minStrNumCtrl";
            minStrNumCtrl.Size = new Size(67, 28);
            minStrNumCtrl.TabIndex = 94;
            minStrNumCtrl.TextAlign = HorizontalAlignment.Center;
            // 
            // stealthLabel
            // 
            stealthLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stealthLabel.Location = new Point(12, 348);
            stealthLabel.Name = "stealthLabel";
            stealthLabel.Size = new Size(124, 46);
            stealthLabel.TabIndex = 97;
            stealthLabel.Text = "Stealth Disadvantage";
            // 
            // stealthCheckBox
            // 
            stealthCheckBox.AutoSize = true;
            stealthCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            stealthCheckBox.Location = new Point(135, 357);
            stealthCheckBox.Name = "stealthCheckBox";
            stealthCheckBox.Size = new Size(18, 17);
            stealthCheckBox.TabIndex = 96;
            stealthCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            stealthCheckBox.UseVisualStyleBackColor = true;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descLabel.Location = new Point(12, 404);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 99;
            descLabel.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.Font = new Font("Constantia", 9F);
            descTextBox.Location = new Point(12, 428);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(366, 128);
            descTextBox.TabIndex = 98;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(264, 577);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 101;
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
            okBtn.Location = new Point(148, 577);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 100;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // lbsLabel
            // 
            lbsLabel.AutoSize = true;
            lbsLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbsLabel.Location = new Point(76, 102);
            lbsLabel.Name = "lbsLabel";
            lbsLabel.Size = new Size(43, 21);
            lbsLabel.TabIndex = 102;
            lbsLabel.Text = "(lbs)";
            // 
            // ArmourCreateForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(390, 621);
            Controls.Add(lbsLabel);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(stealthLabel);
            Controls.Add(stealthCheckBox);
            Controls.Add(minStrCheckBox);
            Controls.Add(minStrNumCtrl);
            Controls.Add(minStrLabel);
            Controls.Add(maxBonusCheckBox);
            Controls.Add(maxBonusNumCtrl);
            Controls.Add(label1);
            Controls.Add(maxBonusLabel);
            Controls.Add(dexCheckBox);
            Controls.Add(acTextBox);
            Controls.Add(acLabel);
            Controls.Add(weightTextBox);
            Controls.Add(weightLabel);
            Controls.Add(costUnitComboBox);
            Controls.Add(costValueTextBox);
            Controls.Add(costLabel);
            Controls.Add(categoryLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(nameTextBox);
            MinimumSize = new Size(320, 648);
            Name = "ArmourCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Armour";
            ((System.ComponentModel.ISupportInitialize)maxBonusNumCtrl).EndInit();
            ((System.ComponentModel.ISupportInitialize)minStrNumCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox weightTextBox;
        private Label weightLabel;
        private ComboBox costUnitComboBox;
        private TextBox costValueTextBox;
        private Label costLabel;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private TextBox nameTextBox;
        private TextBox acTextBox;
        private Label acLabel;
        private CheckBox dexCheckBox;
        private Label maxBonusLabel;
        private Label label1;
        private NumericUpDown maxBonusNumCtrl;
        private CheckBox maxBonusCheckBox;
        private Label minStrLabel;
        private CheckBox minStrCheckBox;
        private NumericUpDown minStrNumCtrl;
        private Label stealthLabel;
        private CheckBox stealthCheckBox;
        private Label descLabel;
        private TextBox descTextBox;
        private Button cancelBtn;
        private Button okBtn;
        private Label lbsLabel;
    }
}