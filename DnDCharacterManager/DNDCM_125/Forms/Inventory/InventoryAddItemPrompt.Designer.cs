namespace CharacterManager
{
    partial class InventoryAddItemPrompt
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
            browserBtn = new Button();
            addTempBtn = new Button();
            SuspendLayout();
            // 
            // browserBtn
            // 
            browserBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            browserBtn.BackColor = Color.Gainsboro;
            browserBtn.Font = new Font("Constantia", 10.2F);
            browserBtn.ForeColor = SystemColors.ControlText;
            browserBtn.Location = new Point(12, 12);
            browserBtn.Margin = new Padding(3, 3, 3, 6);
            browserBtn.Name = "browserBtn";
            browserBtn.Size = new Size(229, 45);
            browserBtn.TabIndex = 18;
            browserBtn.TabStop = false;
            browserBtn.Text = "Open Item Browser";
            browserBtn.UseVisualStyleBackColor = false;
            browserBtn.Click += browserBtn_Click;
            // 
            // addTempBtn
            // 
            addTempBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addTempBtn.BackColor = Color.Gainsboro;
            addTempBtn.Font = new Font("Constantia", 10.2F);
            addTempBtn.ForeColor = SystemColors.ControlText;
            addTempBtn.Location = new Point(12, 66);
            addTempBtn.Margin = new Padding(3, 3, 3, 6);
            addTempBtn.Name = "addTempBtn";
            addTempBtn.Size = new Size(229, 45);
            addTempBtn.TabIndex = 19;
            addTempBtn.TabStop = false;
            addTempBtn.Text = "Add Temporary Item";
            addTempBtn.UseVisualStyleBackColor = false;
            addTempBtn.Click += addTempBtn_Click;
            // 
            // InventoryAddItemPrompt
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(253, 128);
            Controls.Add(addTempBtn);
            Controls.Add(browserBtn);
            MaximumSize = new Size(271, 175);
            MinimumSize = new Size(271, 175);
            Name = "InventoryAddItemPrompt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add";
            ResumeLayout(false);
        }

        #endregion

        private Button browserBtn;
        private Button addTempBtn;
    }
}