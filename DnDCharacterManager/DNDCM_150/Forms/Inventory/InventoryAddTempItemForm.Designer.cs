namespace CharacterManager
{
    partial class InventoryAddTempItemForm
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
            descLabel = new Label();
            descTextBox = new TextBox();
            cancelBtn = new Button();
            okBtn = new Button();
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
            nameTextBox.Size = new Size(396, 36);
            nameTextBox.TabIndex = 74;
            nameTextBox.TabStop = false;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descLabel.Location = new Point(12, 61);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 83;
            descLabel.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.Font = new Font("Constantia", 9F);
            descTextBox.Location = new Point(12, 85);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(396, 171);
            descTextBox.TabIndex = 82;
            descTextBox.TabStop = false;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(299, 274);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 85;
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
            okBtn.Location = new Point(183, 274);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 84;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // InventoryAddTempItemForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(420, 318);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(nameTextBox);
            MinimumSize = new Size(280, 280);
            Name = "InventoryAddTempItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label descLabel;
        private TextBox descTextBox;
        private Button cancelBtn;
        private Button okBtn;
    }
}