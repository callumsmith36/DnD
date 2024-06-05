namespace CharacterManager
{
    partial class FeatDetailsForm
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
            usesTextBox = new TextBox();
            usesLabel = new Label();
            sourceLabel = new Label();
            nameTextBox = new TextBox();
            descLabel = new Label();
            descTextBox = new TextBox();
            SuspendLayout();
            // 
            // usesTextBox
            // 
            usesTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usesTextBox.BackColor = Color.WhiteSmoke;
            usesTextBox.BorderStyle = BorderStyle.None;
            usesTextBox.Font = new Font("Constantia", 10.2F);
            usesTextBox.Location = new Point(95, 73);
            usesTextBox.Name = "usesTextBox";
            usesTextBox.ReadOnly = true;
            usesTextBox.Size = new Size(269, 21);
            usesTextBox.TabIndex = 15;
            usesTextBox.TabStop = false;
            usesTextBox.Text = "[uses]";
            // 
            // usesLabel
            // 
            usesLabel.AutoSize = true;
            usesLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            usesLabel.Location = new Point(12, 73);
            usesLabel.Name = "usesLabel";
            usesLabel.Size = new Size(48, 21);
            usesLabel.TabIndex = 14;
            usesLabel.Text = "Uses";
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            sourceLabel.Location = new Point(12, 45);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new Size(60, 18);
            sourceLabel.TabIndex = 13;
            sourceLabel.Text = "[source]";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = Color.WhiteSmoke;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Constantia", 12F);
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(352, 25);
            nameTextBox.TabIndex = 12;
            nameTextBox.TabStop = false;
            nameTextBox.Text = "[Feat Name]";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            descLabel.Location = new Point(12, 104);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 19;
            descLabel.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.BackColor = Color.WhiteSmoke;
            descTextBox.Font = new Font("Constantia", 10.2F);
            descTextBox.Location = new Point(12, 128);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ReadOnly = true;
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(352, 129);
            descTextBox.TabIndex = 18;
            descTextBox.TabStop = false;
            descTextBox.Text = "[description]";
            // 
            // FeatDetailsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(376, 269);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(usesTextBox);
            Controls.Add(usesLabel);
            Controls.Add(sourceLabel);
            Controls.Add(nameTextBox);
            Name = "FeatDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Feat Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usesTextBox;
        private Label usesLabel;
        private Label sourceLabel;
        private TextBox nameTextBox;
        private Label descLabel;
        private TextBox descTextBox;
    }
}