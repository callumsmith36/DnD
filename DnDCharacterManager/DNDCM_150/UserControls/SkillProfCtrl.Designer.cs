namespace CharacterManager
{
    partial class SkillProfCtrl
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
            expertCheck = new CheckBox();
            profCheck = new CheckBox();
            skillNameLabel = new Label();
            SuspendLayout();
            // 
            // expertCheck
            // 
            expertCheck.AutoSize = true;
            expertCheck.Enabled = false;
            expertCheck.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expertCheck.Location = new Point(32, 10);
            expertCheck.Margin = new Padding(4, 4, 4, 4);
            expertCheck.Name = "expertCheck";
            expertCheck.Size = new Size(22, 21);
            expertCheck.TabIndex = 4;
            expertCheck.UseVisualStyleBackColor = true;
            expertCheck.CheckedChanged += expertCheck_CheckedChanged;
            // 
            // profCheck
            // 
            profCheck.AutoSize = true;
            profCheck.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profCheck.Location = new Point(4, 10);
            profCheck.Margin = new Padding(4, 4, 4, 4);
            profCheck.Name = "profCheck";
            profCheck.Size = new Size(22, 21);
            profCheck.TabIndex = 3;
            profCheck.UseVisualStyleBackColor = true;
            profCheck.CheckedChanged += profCheck_CheckedChanged;
            // 
            // skillNameLabel
            // 
            skillNameLabel.AutoSize = true;
            skillNameLabel.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skillNameLabel.Location = new Point(61, 5);
            skillNameLabel.Margin = new Padding(4, 0, 4, 0);
            skillNameLabel.Name = "skillNameLabel";
            skillNameLabel.Size = new Size(127, 27);
            skillNameLabel.TabIndex = 6;
            skillNameLabel.Text = "[skill name]";
            // 
            // SkillProfCtrl
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(skillNameLabel);
            Controls.Add(expertCheck);
            Controls.Add(profCheck);
            Margin = new Padding(4, 4, 4, 4);
            MaximumSize = new Size(274, 37);
            MinimumSize = new Size(274, 37);
            Name = "SkillProfCtrl";
            Size = new Size(274, 37);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox expertCheck;
        private CheckBox profCheck;
        private Label skillNameLabel;
    }
}
