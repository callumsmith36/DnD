namespace CharacterManager
{
    partial class SpellDetailsForm
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
            levelSchoolLabel = new Label();
            nameTextBox = new TextBox();
            timeLabel = new Label();
            timeTextBox = new TextBox();
            rangeTextBox = new TextBox();
            rangeLabel = new Label();
            componentsTextBox = new TextBox();
            componentsLabel = new Label();
            durationTextBox = new TextBox();
            durationLabel = new Label();
            descTextBox = new TextBox();
            higherLvlTextBox = new TextBox();
            higherLvlLabel = new Label();
            descLabel = new Label();
            SuspendLayout();
            // 
            // levelSchoolLabel
            // 
            levelSchoolLabel.AutoSize = true;
            levelSchoolLabel.Font = new Font("Constantia", 9F, FontStyle.Italic, GraphicsUnit.Point);
            levelSchoolLabel.Location = new Point(12, 45);
            levelSchoolLabel.Name = "levelSchoolLabel";
            levelSchoolLabel.Size = new Size(110, 18);
            levelSchoolLabel.TabIndex = 2;
            levelSchoolLabel.Text = "[Level + School]";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = Color.WhiteSmoke;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(12, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(518, 25);
            nameTextBox.TabIndex = 3;
            nameTextBox.TabStop = false;
            nameTextBox.Text = "[Spell Name]";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(12, 73);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(117, 21);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "Casting Time";
            // 
            // timeTextBox
            // 
            timeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            timeTextBox.BackColor = Color.WhiteSmoke;
            timeTextBox.BorderStyle = BorderStyle.None;
            timeTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            timeTextBox.Location = new Point(145, 73);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.ReadOnly = true;
            timeTextBox.Size = new Size(385, 21);
            timeTextBox.TabIndex = 5;
            timeTextBox.TabStop = false;
            timeTextBox.Text = "[time]";
            // 
            // rangeTextBox
            // 
            rangeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rangeTextBox.BackColor = Color.WhiteSmoke;
            rangeTextBox.BorderStyle = BorderStyle.None;
            rangeTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rangeTextBox.Location = new Point(145, 100);
            rangeTextBox.Name = "rangeTextBox";
            rangeTextBox.ReadOnly = true;
            rangeTextBox.Size = new Size(385, 21);
            rangeTextBox.TabIndex = 7;
            rangeTextBox.TabStop = false;
            rangeTextBox.Text = "[range]";
            // 
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            rangeLabel.Location = new Point(12, 100);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(60, 21);
            rangeLabel.TabIndex = 6;
            rangeLabel.Text = "Range";
            // 
            // componentsTextBox
            // 
            componentsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            componentsTextBox.BackColor = Color.WhiteSmoke;
            componentsTextBox.BorderStyle = BorderStyle.None;
            componentsTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            componentsTextBox.Location = new Point(145, 127);
            componentsTextBox.Name = "componentsTextBox";
            componentsTextBox.ReadOnly = true;
            componentsTextBox.Size = new Size(385, 21);
            componentsTextBox.TabIndex = 9;
            componentsTextBox.TabStop = false;
            componentsTextBox.Text = "[components]";
            // 
            // componentsLabel
            // 
            componentsLabel.AutoSize = true;
            componentsLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            componentsLabel.Location = new Point(12, 127);
            componentsLabel.Name = "componentsLabel";
            componentsLabel.Size = new Size(113, 21);
            componentsLabel.TabIndex = 8;
            componentsLabel.Text = "Components";
            // 
            // durationTextBox
            // 
            durationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            durationTextBox.BackColor = Color.WhiteSmoke;
            durationTextBox.BorderStyle = BorderStyle.None;
            durationTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            durationTextBox.Location = new Point(145, 154);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.ReadOnly = true;
            durationTextBox.Size = new Size(385, 21);
            durationTextBox.TabIndex = 11;
            durationTextBox.TabStop = false;
            durationTextBox.Text = "[duration]";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            durationLabel.Location = new Point(12, 154);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(84, 21);
            durationLabel.TabIndex = 10;
            durationLabel.Text = "Duration";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.BackColor = Color.WhiteSmoke;
            descTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            descTextBox.Location = new Point(12, 208);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ReadOnly = true;
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(518, 122);
            descTextBox.TabIndex = 12;
            descTextBox.TabStop = false;
            descTextBox.Text = "[description]";
            // 
            // higherLvlTextBox
            // 
            higherLvlTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            higherLvlTextBox.BackColor = Color.WhiteSmoke;
            higherLvlTextBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            higherLvlTextBox.Location = new Point(12, 366);
            higherLvlTextBox.Multiline = true;
            higherLvlTextBox.Name = "higherLvlTextBox";
            higherLvlTextBox.ReadOnly = true;
            higherLvlTextBox.ScrollBars = ScrollBars.Vertical;
            higherLvlTextBox.Size = new Size(518, 72);
            higherLvlTextBox.TabIndex = 13;
            higherLvlTextBox.TabStop = false;
            higherLvlTextBox.Text = "[at higher levels]";
            // 
            // higherLvlLabel
            // 
            higherLvlLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            higherLvlLabel.AutoSize = true;
            higherLvlLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            higherLvlLabel.Location = new Point(12, 339);
            higherLvlLabel.Name = "higherLvlLabel";
            higherLvlLabel.Size = new Size(142, 21);
            higherLvlLabel.TabIndex = 14;
            higherLvlLabel.Text = "At Higher Levels";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            descLabel.Location = new Point(12, 181);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 15;
            descLabel.Text = "Description";
            // 
            // SpellDetailsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(542, 450);
            Controls.Add(descLabel);
            Controls.Add(higherLvlLabel);
            Controls.Add(higherLvlTextBox);
            Controls.Add(descTextBox);
            Controls.Add(durationTextBox);
            Controls.Add(durationLabel);
            Controls.Add(componentsTextBox);
            Controls.Add(componentsLabel);
            Controls.Add(rangeTextBox);
            Controls.Add(rangeLabel);
            Controls.Add(timeTextBox);
            Controls.Add(timeLabel);
            Controls.Add(nameTextBox);
            Controls.Add(levelSchoolLabel);
            Name = "SpellDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Spell Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label levelSchoolLabel;
        private TextBox nameTextBox;
        private Label timeLabel;
        private TextBox timeTextBox;
        private TextBox rangeTextBox;
        private Label rangeLabel;
        private TextBox componentsTextBox;
        private Label componentsLabel;
        private TextBox durationTextBox;
        private Label durationLabel;
        private TextBox descTextBox;
        private TextBox higherLvlTextBox;
        private Label higherLvlLabel;
        private Label descLabel;
    }
}