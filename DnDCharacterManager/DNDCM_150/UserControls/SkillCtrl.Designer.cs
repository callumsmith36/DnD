namespace CharacterManager
{
    partial class SkillCtrl
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
            skillModTextBox = new TextBox();
            skillNameLabel = new Label();
            SuspendLayout();
            // 
            // skillModTextBox
            // 
            skillModTextBox.BackColor = Color.WhiteSmoke;
            skillModTextBox.BorderStyle = BorderStyle.FixedSingle;
            skillModTextBox.Font = new Font("Constantia", 10.8F, FontStyle.Bold);
            skillModTextBox.Location = new Point(3, 3);
            skillModTextBox.Name = "skillModTextBox";
            skillModTextBox.ReadOnly = true;
            skillModTextBox.Size = new Size(38, 29);
            skillModTextBox.TabIndex = 6;
            skillModTextBox.Text = "0";
            skillModTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // skillNameLabel
            // 
            skillNameLabel.AutoSize = true;
            skillNameLabel.Font = new Font("Constantia", 9F);
            skillNameLabel.Location = new Point(47, 8);
            skillNameLabel.Name = "skillNameLabel";
            skillNameLabel.Size = new Size(84, 18);
            skillNameLabel.TabIndex = 5;
            skillNameLabel.Text = "[skill name]";
            // 
            // SkillCtrl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(skillModTextBox);
            Controls.Add(skillNameLabel);
            MaximumSize = new Size(180, 37);
            MinimumSize = new Size(178, 35);
            Name = "SkillCtrl";
            Size = new Size(178, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox skillModTextBox;
        private Label skillNameLabel;
    }
}
