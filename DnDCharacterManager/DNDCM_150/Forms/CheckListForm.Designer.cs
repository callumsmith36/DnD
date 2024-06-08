namespace CharacterManager
{
    partial class CheckListForm
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
            checkList = new CheckedListBox();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(186, 63);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 28;
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
            okBtn.Location = new Point(70, 63);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 27;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // checkList
            // 
            checkList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkList.BackColor = Color.WhiteSmoke;
            checkList.BorderStyle = BorderStyle.None;
            checkList.CheckOnClick = true;
            checkList.Font = new Font("Constantia", 10F);
            checkList.FormattingEnabled = true;
            checkList.Location = new Point(12, 12);
            checkList.Name = "checkList";
            checkList.Size = new Size(279, 23);
            checkList.TabIndex = 29;
            // 
            // CheckListForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(303, 107);
            Controls.Add(checkList);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Font = new Font("Constantia", 9F);
            Name = "CheckListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CheckListForm";
            ResumeLayout(false);
        }

        #endregion

        private Button cancelBtn;
        private Button okBtn;
        private CheckedListBox checkList;
    }
}