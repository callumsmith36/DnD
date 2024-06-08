namespace CharacterManager
{
    partial class MagicItemCreateForm
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
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            nameTextBox = new TextBox();
            rarityLabel = new Label();
            rarityComboBox = new ComboBox();
            isVariantLabel = new Label();
            isVariantCheckBox = new CheckBox();
            descLabel = new Label();
            descTextBox = new TextBox();
            variantsLabel = new Label();
            variantsTextBox = new TextBox();
            cancelBtn = new Button();
            okBtn = new Button();
            attunementLabel = new Label();
            attunementCheckBox = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            categoryLabel.Location = new Point(12, 61);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(81, 21);
            categoryLabel.TabIndex = 55;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Constantia", 10F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Weapon", "Armour", "Potion", "Ring", "Rod", "Scroll", "Staff", "Wand", "Wondrous Item" });
            categoryComboBox.Location = new Point(135, 58);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(152, 29);
            categoryComboBox.TabIndex = 54;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Constantia", 14F);
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " Item Name";
            nameTextBox.Size = new Size(378, 36);
            nameTextBox.TabIndex = 53;
            nameTextBox.TabStop = false;
            // 
            // rarityLabel
            // 
            rarityLabel.AutoSize = true;
            rarityLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            rarityLabel.Location = new Point(12, 102);
            rarityLabel.Name = "rarityLabel";
            rarityLabel.Size = new Size(60, 21);
            rarityLabel.TabIndex = 57;
            rarityLabel.Text = "Rarity";
            // 
            // rarityComboBox
            // 
            rarityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rarityComboBox.Font = new Font("Constantia", 10F);
            rarityComboBox.FormattingEnabled = true;
            rarityComboBox.Items.AddRange(new object[] { "Common", "Uncommon", "Rare", "Very Rare", "Legendary" });
            rarityComboBox.Location = new Point(135, 99);
            rarityComboBox.Name = "rarityComboBox";
            rarityComboBox.Size = new Size(152, 29);
            rarityComboBox.TabIndex = 56;
            // 
            // isVariantLabel
            // 
            isVariantLabel.AutoSize = true;
            isVariantLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isVariantLabel.Location = new Point(12, 198);
            isVariantLabel.Name = "isVariantLabel";
            isVariantLabel.Size = new Size(88, 21);
            isVariantLabel.TabIndex = 92;
            isVariantLabel.Text = "Is Variant";
            // 
            // isVariantCheckBox
            // 
            isVariantCheckBox.AutoSize = true;
            isVariantCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            isVariantCheckBox.Location = new Point(135, 201);
            isVariantCheckBox.Name = "isVariantCheckBox";
            isVariantCheckBox.Size = new Size(18, 17);
            isVariantCheckBox.TabIndex = 91;
            isVariantCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            isVariantCheckBox.UseVisualStyleBackColor = true;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descLabel.Location = new Point(12, 353);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 94;
            descLabel.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.Font = new Font("Constantia", 9F);
            descTextBox.Location = new Point(12, 377);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(378, 135);
            descTextBox.TabIndex = 93;
            // 
            // variantsLabel
            // 
            variantsLabel.AutoSize = true;
            variantsLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            variantsLabel.Location = new Point(12, 239);
            variantsLabel.Name = "variantsLabel";
            variantsLabel.Size = new Size(77, 21);
            variantsLabel.TabIndex = 96;
            variantsLabel.Text = "Variants";
            // 
            // variantsTextBox
            // 
            variantsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            variantsTextBox.Font = new Font("Constantia", 9F);
            variantsTextBox.Location = new Point(12, 263);
            variantsTextBox.Multiline = true;
            variantsTextBox.Name = "variantsTextBox";
            variantsTextBox.ScrollBars = ScrollBars.Vertical;
            variantsTextBox.Size = new Size(378, 77);
            variantsTextBox.TabIndex = 95;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(276, 529);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 103;
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
            okBtn.Location = new Point(160, 529);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 102;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // attunementLabel
            // 
            attunementLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attunementLabel.Location = new Point(12, 142);
            attunementLabel.Name = "attunementLabel";
            attunementLabel.Size = new Size(124, 46);
            attunementLabel.TabIndex = 105;
            attunementLabel.Text = "Requires Attunement";
            // 
            // attunementCheckBox
            // 
            attunementCheckBox.AutoSize = true;
            attunementCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            attunementCheckBox.Location = new Point(135, 151);
            attunementCheckBox.Name = "attunementCheckBox";
            attunementCheckBox.Size = new Size(18, 17);
            attunementCheckBox.TabIndex = 104;
            attunementCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            attunementCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 239);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 106;
            label1.Text = "(one item per line)";
            // 
            // MagicItemCreateForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(402, 573);
            Controls.Add(label1);
            Controls.Add(attunementLabel);
            Controls.Add(attunementCheckBox);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(variantsLabel);
            Controls.Add(variantsTextBox);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(isVariantLabel);
            Controls.Add(isVariantCheckBox);
            Controls.Add(rarityLabel);
            Controls.Add(rarityComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(nameTextBox);
            MinimumSize = new Size(317, 560);
            Name = "MagicItemCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Magic Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private TextBox nameTextBox;
        private Label rarityLabel;
        private ComboBox rarityComboBox;
        private Label isVariantLabel;
        private CheckBox isVariantCheckBox;
        private Label descLabel;
        private TextBox descTextBox;
        private Label variantsLabel;
        private TextBox variantsTextBox;
        private Button cancelBtn;
        private Button okBtn;
        private Label attunementLabel;
        private CheckBox attunementCheckBox;
        private Label label1;
    }
}