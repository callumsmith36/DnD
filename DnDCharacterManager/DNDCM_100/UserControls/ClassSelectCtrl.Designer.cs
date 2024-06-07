namespace CharacterManager
{
    partial class ClassSelectCtrl
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
            levelNumCtrl = new NumericUpDown();
            levelLabel = new Label();
            classComboBox = new ComboBox();
            classLabel = new Label();
            removeBtn = new Button();
            primaryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)levelNumCtrl).BeginInit();
            SuspendLayout();
            // 
            // levelNumCtrl
            // 
            levelNumCtrl.Font = new Font("Constantia", 11F);
            levelNumCtrl.Location = new Point(330, 8);
            levelNumCtrl.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            levelNumCtrl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            levelNumCtrl.Name = "levelNumCtrl";
            levelNumCtrl.Size = new Size(63, 30);
            levelNumCtrl.TabIndex = 7;
            levelNumCtrl.TextAlign = HorizontalAlignment.Center;
            levelNumCtrl.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Font = new Font("Constantia", 11F, FontStyle.Bold);
            levelLabel.Location = new Point(267, 10);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(57, 23);
            levelLabel.TabIndex = 6;
            levelLabel.Text = "Level";
            // 
            // classComboBox
            // 
            classComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            classComboBox.Font = new Font("Constantia", 11F);
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(71, 7);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(179, 30);
            classComboBox.TabIndex = 5;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Constantia", 11F, FontStyle.Bold);
            classLabel.Location = new Point(8, 10);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(57, 23);
            classLabel.TabIndex = 4;
            classLabel.Text = "Class";
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.Gainsboro;
            removeBtn.Font = new Font("Constantia", 9F);
            removeBtn.ForeColor = SystemColors.ControlText;
            removeBtn.Location = new Point(429, 8);
            removeBtn.Margin = new Padding(3, 3, 3, 6);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(81, 29);
            removeBtn.TabIndex = 28;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // primaryLabel
            // 
            primaryLabel.AutoSize = true;
            primaryLabel.Enabled = false;
            primaryLabel.Font = new Font("Constantia", 10F, FontStyle.Bold);
            primaryLabel.Location = new Point(429, 11);
            primaryLabel.Name = "primaryLabel";
            primaryLabel.Size = new Size(135, 21);
            primaryLabel.TabIndex = 29;
            primaryLabel.Text = "(Primary Class)";
            primaryLabel.Visible = false;
            // 
            // ClassSelectCtrl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(primaryLabel);
            Controls.Add(removeBtn);
            Controls.Add(levelNumCtrl);
            Controls.Add(levelLabel);
            Controls.Add(classComboBox);
            Controls.Add(classLabel);
            Font = new Font("Constantia", 9F);
            Name = "ClassSelectCtrl";
            Size = new Size(575, 45);
            ((System.ComponentModel.ISupportInitialize)levelNumCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown levelNumCtrl;
        private Label levelLabel;
        private ComboBox classComboBox;
        private Label classLabel;
        private Button removeBtn;
        private Label primaryLabel;
    }
}
