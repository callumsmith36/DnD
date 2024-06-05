namespace CharacterManager
{
    partial class FeatCtrl
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
            nameLabel = new Label();
            maxUsesTextBox = new TextBox();
            usesLeftNumCtrl = new NumericUpDown();
            slash = new Label();
            sourceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)usesLeftNumCtrl).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.WhiteSmoke;
            nameLabel.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(1, 4);
            nameLabel.MaximumSize = new Size(340, 24);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(107, 22);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "[Feat Name]";
            nameLabel.MouseClick += FeatCtrl_MouseClick;
            // 
            // maxUsesTextBox
            // 
            maxUsesTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            maxUsesTextBox.BackColor = Color.WhiteSmoke;
            maxUsesTextBox.BorderStyle = BorderStyle.None;
            maxUsesTextBox.Font = new Font("Constantia", 11F);
            maxUsesTextBox.Location = new Point(179, 35);
            maxUsesTextBox.MaxLength = 2;
            maxUsesTextBox.Name = "maxUsesTextBox";
            maxUsesTextBox.ReadOnly = true;
            maxUsesTextBox.Size = new Size(28, 23);
            maxUsesTextBox.TabIndex = 16;
            maxUsesTextBox.Text = "0";
            maxUsesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // usesLeftNumCtrl
            // 
            usesLeftNumCtrl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            usesLeftNumCtrl.BackColor = SystemColors.Window;
            usesLeftNumCtrl.BorderStyle = BorderStyle.FixedSingle;
            usesLeftNumCtrl.Font = new Font("Constantia", 11F);
            usesLeftNumCtrl.Location = new Point(107, 33);
            usesLeftNumCtrl.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            usesLeftNumCtrl.Name = "usesLeftNumCtrl";
            usesLeftNumCtrl.Size = new Size(58, 30);
            usesLeftNumCtrl.TabIndex = 14;
            usesLeftNumCtrl.TextAlign = HorizontalAlignment.Center;
            usesLeftNumCtrl.ValueChanged += usesLeftNumCtrl_ValueChanged;
            // 
            // slash
            // 
            slash.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            slash.AutoSize = true;
            slash.Font = new Font("Constantia", 16F);
            slash.Location = new Point(164, 30);
            slash.Name = "slash";
            slash.Size = new Size(26, 33);
            slash.TabIndex = 15;
            slash.Text = "/";
            // 
            // sourceLabel
            // 
            sourceLabel.AutoSize = true;
            sourceLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            sourceLabel.Location = new Point(3, 31);
            sourceLabel.Name = "sourceLabel";
            sourceLabel.Size = new Size(60, 18);
            sourceLabel.TabIndex = 17;
            sourceLabel.Text = "[source]";
            sourceLabel.MouseClick += FeatCtrl_MouseClick;
            // 
            // FeatCtrl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(nameLabel);
            Controls.Add(maxUsesTextBox);
            Controls.Add(usesLeftNumCtrl);
            Controls.Add(slash);
            Controls.Add(sourceLabel);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(210, 70);
            Name = "FeatCtrl";
            Size = new Size(210, 70);
            MouseClick += FeatCtrl_MouseClick;
            ((System.ComponentModel.ISupportInitialize)usesLeftNumCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nameLabel;
        private TextBox maxUsesTextBox;
        private NumericUpDown usesLeftNumCtrl;
        private Label slash;
        private Label sourceLabel;
    }
}
