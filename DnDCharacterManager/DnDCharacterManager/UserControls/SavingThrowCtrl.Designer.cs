namespace CharacterManager
{
    partial class SavingThrowCtrl
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
            modTextBox = new TextBox();
            abilityNameLabel = new Label();
            SuspendLayout();
            // 
            // modTextBox
            // 
            modTextBox.BackColor = Color.WhiteSmoke;
            modTextBox.BorderStyle = BorderStyle.FixedSingle;
            modTextBox.Font = new Font("Constantia", 10.8F, FontStyle.Bold);
            modTextBox.Location = new Point(3, 3);
            modTextBox.Name = "modTextBox";
            modTextBox.ReadOnly = true;
            modTextBox.Size = new Size(38, 29);
            modTextBox.TabIndex = 8;
            modTextBox.Text = "0";
            modTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // abilityNameLabel
            // 
            abilityNameLabel.AutoSize = true;
            abilityNameLabel.Font = new Font("Constantia", 9F);
            abilityNameLabel.Location = new Point(47, 8);
            abilityNameLabel.Name = "abilityNameLabel";
            abilityNameLabel.Size = new Size(0, 18);
            abilityNameLabel.TabIndex = 7;
            // 
            // SavingThrowCtrl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(modTextBox);
            Controls.Add(abilityNameLabel);
            MaximumSize = new Size(90, 37);
            MinimumSize = new Size(88, 35);
            Name = "SavingThrowCtrl";
            Size = new Size(88, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox modTextBox;
        private Label abilityNameLabel;
    }
}
