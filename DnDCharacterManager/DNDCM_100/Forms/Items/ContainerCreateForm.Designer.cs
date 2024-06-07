namespace CharacterManager
{
    partial class ContainerCreateForm
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
            typeLabel = new Label();
            baseNameTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            cancelBtn = new Button();
            okBtn = new Button();
            SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            typeLabel.Location = new Point(12, 45);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(45, 18);
            typeLabel.TabIndex = 7;
            typeLabel.Text = "[type]";
            // 
            // baseNameTextBox
            // 
            baseNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            baseNameTextBox.BackColor = Color.WhiteSmoke;
            baseNameTextBox.BorderStyle = BorderStyle.None;
            baseNameTextBox.Font = new Font("Constantia", 12F);
            baseNameTextBox.Location = new Point(12, 12);
            baseNameTextBox.Name = "baseNameTextBox";
            baseNameTextBox.ReadOnly = true;
            baseNameTextBox.Size = new Size(338, 25);
            baseNameTextBox.TabIndex = 6;
            baseNameTextBox.TabStop = false;
            baseNameTextBox.Text = "[Base Item Name]";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            nameLabel.Location = new Point(12, 73);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 21);
            nameLabel.TabIndex = 21;
            nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = Color.WhiteSmoke;
            nameTextBox.Font = new Font("Constantia", 10.2F);
            nameTextBox.Location = new Point(12, 97);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ScrollBars = ScrollBars.Vertical;
            nameTextBox.Size = new Size(338, 28);
            nameTextBox.TabIndex = 20;
            nameTextBox.TabStop = false;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(246, 149);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 23;
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
            okBtn.Location = new Point(146, 149);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 22;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // ContainerCreateForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(362, 193);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(typeLabel);
            Controls.Add(baseNameTextBox);
            Name = "ContainerCreateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Container";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label typeLabel;
        private TextBox baseNameTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Button cancelBtn;
        private Button okBtn;
    }
}