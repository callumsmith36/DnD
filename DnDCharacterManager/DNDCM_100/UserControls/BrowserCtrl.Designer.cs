namespace CharacterManager
{
    partial class BrowserCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            infoBtn = new Button();
            nameLabel = new Label();
            tagLabel = new Label();
            SuspendLayout();
            // 
            // infoBtn
            // 
            infoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            infoBtn.BackColor = Color.Gainsboro;
            infoBtn.Font = new Font("Constantia", 10.2F);
            infoBtn.ForeColor = SystemColors.ControlText;
            infoBtn.Location = new Point(4, 28);
            infoBtn.Margin = new Padding(2, 2, 2, 5);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(75, 23);
            infoBtn.TabIndex = 6;
            infoBtn.TabStop = false;
            infoBtn.Text = "Details...";
            infoBtn.UseVisualStyleBackColor = false;
            infoBtn.Click += infoBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.WhiteSmoke;
            nameLabel.Cursor = Cursors.Hand;
            nameLabel.Enabled = false;
            nameLabel.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(1, 3);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.MaximumSize = new Size(272, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(114, 19);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "[Object Name]";
            // 
            // tagLabel
            // 
            tagLabel.Anchor = AnchorStyles.Right;
            tagLabel.AutoSize = true;
            tagLabel.Enabled = false;
            tagLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            tagLabel.Location = new Point(243, 36);
            tagLabel.Margin = new Padding(2, 0, 2, 0);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(31, 14);
            tagLabel.TabIndex = 9;
            tagLabel.Text = "[tag]";
            tagLabel.Visible = false;
            // 
            // BrowserCtrl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tagLabel);
            Controls.Add(nameLabel);
            Controls.Add(infoBtn);
            Cursor = Cursors.Hand;
            Margin = new Padding(2);
            Name = "BrowserCtrl";
            Size = new Size(277, 55);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button infoBtn;
        private Label nameLabel;
        private Label tagLabel;
    }
}
