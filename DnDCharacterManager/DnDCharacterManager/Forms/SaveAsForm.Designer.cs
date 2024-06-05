namespace CharacterManager
{
    partial class SaveAsForm
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
            fileNameLabel = new Label();
            fileNameTextBox = new TextBox();
            cancelBtn = new Button();
            okBtn = new Button();
            SuspendLayout();
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fileNameLabel.Location = new Point(26, 24);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(85, 21);
            fileNameLabel.TabIndex = 0;
            fileNameLabel.Text = "File Name";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileNameTextBox.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            fileNameTextBox.Location = new Point(117, 20);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(210, 30);
            fileNameTextBox.TabIndex = 1;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(190, 69);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            okBtn.BackColor = Color.Gainsboro;
            okBtn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            okBtn.ForeColor = SystemColors.ControlText;
            okBtn.Location = new Point(80, 69);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 6;
            okBtn.Text = "OK";
            okBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // SaveAsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(364, 113);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(fileNameTextBox);
            Controls.Add(fileNameLabel);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SaveAsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Save As";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fileNameLabel;
        private TextBox fileNameTextBox;
        private Button cancelBtn;
        private Button okBtn;
    }
}