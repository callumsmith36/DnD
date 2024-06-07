namespace CharacterManager
{
    partial class WeaponDetailsForm
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
            nameTextBox = new TextBox();
            typeLabel = new Label();
            damageTextBox = new TextBox();
            damageLabel = new Label();
            rangeTextBox = new TextBox();
            rangeLabel = new Label();
            weightTextBox = new TextBox();
            weightLabel = new Label();
            costTextBox = new TextBox();
            costLabel = new Label();
            propLabel = new Label();
            propTable = new TableLayoutPanel();
            descLabel = new Label();
            descTextBox = new TextBox();
            specialLabel = new Label();
            specialTextBox = new TextBox();
            SuspendLayout();
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
            nameTextBox.Size = new Size(338, 25);
            nameTextBox.TabIndex = 4;
            nameTextBox.TabStop = false;
            nameTextBox.Text = "[Item Name]";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            typeLabel.Location = new Point(12, 45);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(45, 18);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "[type]";
            // 
            // damageTextBox
            // 
            damageTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            damageTextBox.BackColor = Color.WhiteSmoke;
            damageTextBox.BorderStyle = BorderStyle.None;
            damageTextBox.Font = new Font("Constantia", 10.2F);
            damageTextBox.Location = new Point(145, 139);
            damageTextBox.Name = "damageTextBox";
            damageTextBox.ReadOnly = true;
            damageTextBox.Size = new Size(205, 21);
            damageTextBox.TabIndex = 7;
            damageTextBox.TabStop = false;
            damageTextBox.Text = "[damage]";
            // 
            // damageLabel
            // 
            damageLabel.AutoSize = true;
            damageLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            damageLabel.Location = new Point(12, 139);
            damageLabel.Name = "damageLabel";
            damageLabel.Size = new Size(75, 21);
            damageLabel.TabIndex = 6;
            damageLabel.Text = "Damage";
            // 
            // rangeTextBox
            // 
            rangeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rangeTextBox.BackColor = Color.WhiteSmoke;
            rangeTextBox.BorderStyle = BorderStyle.None;
            rangeTextBox.Font = new Font("Constantia", 10.2F);
            rangeTextBox.Location = new Point(145, 166);
            rangeTextBox.Name = "rangeTextBox";
            rangeTextBox.ReadOnly = true;
            rangeTextBox.Size = new Size(205, 21);
            rangeTextBox.TabIndex = 9;
            rangeTextBox.TabStop = false;
            rangeTextBox.Text = "[range]";
            // 
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            rangeLabel.Location = new Point(12, 166);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new Size(60, 21);
            rangeLabel.TabIndex = 8;
            rangeLabel.Text = "Range";
            // 
            // weightTextBox
            // 
            weightTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            weightTextBox.BackColor = Color.WhiteSmoke;
            weightTextBox.BorderStyle = BorderStyle.None;
            weightTextBox.Font = new Font("Constantia", 10.2F);
            weightTextBox.Location = new Point(145, 73);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.ReadOnly = true;
            weightTextBox.Size = new Size(205, 21);
            weightTextBox.TabIndex = 11;
            weightTextBox.TabStop = false;
            weightTextBox.Text = "[weight]";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            weightLabel.Location = new Point(12, 73);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(68, 21);
            weightLabel.TabIndex = 10;
            weightLabel.Text = "Weight";
            // 
            // costTextBox
            // 
            costTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            costTextBox.BackColor = Color.WhiteSmoke;
            costTextBox.BorderStyle = BorderStyle.None;
            costTextBox.Font = new Font("Constantia", 10.2F);
            costTextBox.Location = new Point(145, 100);
            costTextBox.Name = "costTextBox";
            costTextBox.ReadOnly = true;
            costTextBox.Size = new Size(205, 21);
            costTextBox.TabIndex = 13;
            costTextBox.TabStop = false;
            costTextBox.Text = "[cost]";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            costLabel.Location = new Point(12, 100);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(46, 21);
            costLabel.TabIndex = 12;
            costLabel.Text = "Cost";
            // 
            // propLabel
            // 
            propLabel.AutoSize = true;
            propLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            propLabel.Location = new Point(12, 205);
            propLabel.Name = "propLabel";
            propLabel.Size = new Size(94, 21);
            propLabel.TabIndex = 14;
            propLabel.Text = "Properties";
            // 
            // propTable
            // 
            propTable.AutoSize = true;
            propTable.ColumnCount = 1;
            propTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            propTable.Location = new Point(137, 205);
            propTable.Name = "propTable";
            propTable.RowCount = 1;
            propTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            propTable.Size = new Size(57, 11);
            propTable.TabIndex = 15;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            descLabel.Location = new Point(12, 235);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 17;
            descLabel.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.BackColor = Color.WhiteSmoke;
            descTextBox.Font = new Font("Constantia", 10.2F);
            descTextBox.Location = new Point(12, 259);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ReadOnly = true;
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(338, 122);
            descTextBox.TabIndex = 16;
            descTextBox.TabStop = false;
            descTextBox.Text = "[description]";
            // 
            // specialLabel
            // 
            specialLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            specialLabel.AutoSize = true;
            specialLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            specialLabel.Location = new Point(12, 393);
            specialLabel.Name = "specialLabel";
            specialLabel.Size = new Size(67, 21);
            specialLabel.TabIndex = 19;
            specialLabel.Text = "Special";
            // 
            // specialTextBox
            // 
            specialTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            specialTextBox.BackColor = Color.WhiteSmoke;
            specialTextBox.Font = new Font("Constantia", 10.2F);
            specialTextBox.Location = new Point(12, 417);
            specialTextBox.Multiline = true;
            specialTextBox.Name = "specialTextBox";
            specialTextBox.ReadOnly = true;
            specialTextBox.ScrollBars = ScrollBars.Vertical;
            specialTextBox.Size = new Size(338, 72);
            specialTextBox.TabIndex = 18;
            specialTextBox.TabStop = false;
            specialTextBox.Text = "[special]";
            // 
            // WeaponDetailsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(362, 501);
            Controls.Add(specialLabel);
            Controls.Add(specialTextBox);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(propTable);
            Controls.Add(propLabel);
            Controls.Add(costTextBox);
            Controls.Add(costLabel);
            Controls.Add(weightTextBox);
            Controls.Add(weightLabel);
            Controls.Add(rangeTextBox);
            Controls.Add(rangeLabel);
            Controls.Add(damageTextBox);
            Controls.Add(damageLabel);
            Controls.Add(typeLabel);
            Controls.Add(nameTextBox);
            Name = "WeaponDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Weapon Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label typeLabel;
        private TextBox damageTextBox;
        private Label damageLabel;
        private TextBox rangeTextBox;
        private Label rangeLabel;
        private TextBox weightTextBox;
        private Label weightLabel;
        private TextBox costTextBox;
        private Label costLabel;
        private Label propLabel;
        private TableLayoutPanel propTable;
        private Label descLabel;
        private TextBox descTextBox;
        private Label specialLabel;
        private TextBox specialTextBox;
    }
}