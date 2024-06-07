namespace CharacterManager
{
    partial class AbilityCtrl
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
            lowerTextBox = new TextBox();
            upperTextBox = new TextBox();
            SuspendLayout();
            // 
            // lowerTextBox
            // 
            lowerTextBox.Anchor = AnchorStyles.Bottom;
            lowerTextBox.Font = new Font("Constantia", 11F);
            lowerTextBox.Location = new Point(18, 50);
            lowerTextBox.Margin = new Padding(2, 2, 2, 4);
            lowerTextBox.MaxLength = 2;
            lowerTextBox.Name = "lowerTextBox";
            lowerTextBox.Size = new Size(36, 30);
            lowerTextBox.TabIndex = 0;
            lowerTextBox.Text = "10";
            lowerTextBox.TextAlign = HorizontalAlignment.Center;
            lowerTextBox.KeyPress += scoreTextBox_KeyPress;
            lowerTextBox.Leave += scoreTextBox_Leave;
            // 
            // upperTextBox
            // 
            upperTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            upperTextBox.BorderStyle = BorderStyle.None;
            upperTextBox.Font = new Font("Constantia", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upperTextBox.Location = new Point(2, -3);
            upperTextBox.Margin = new Padding(2);
            upperTextBox.Name = "upperTextBox";
            upperTextBox.ReadOnly = true;
            upperTextBox.Size = new Size(68, 53);
            upperTextBox.TabIndex = 1;
            upperTextBox.Text = "0";
            upperTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AbilityCtrl
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(upperTextBox);
            Controls.Add(lowerTextBox);
            Margin = new Padding(2);
            Name = "AbilityCtrl";
            Size = new Size(72, 86);
            BackColorChanged += AbilityCtrl_BackColorChanged;
            ForeColorChanged += AbilityCtrl_ForeColorChanged;
            Resize += AbilityCtrl_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lowerTextBox;
        private TextBox upperTextBox;
    }
}
