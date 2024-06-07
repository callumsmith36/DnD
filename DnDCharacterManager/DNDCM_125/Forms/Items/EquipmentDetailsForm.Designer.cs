namespace CharacterManager
{
    partial class EquipmentDetailsForm
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
            descLabel = new Label();
            descTextBox = new TextBox();
            costTextBox = new TextBox();
            costLabel = new Label();
            weightTextBox = new TextBox();
            weightLabel = new Label();
            typeLabel = new Label();
            nameTextBox = new TextBox();
            SuspendLayout();
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            descLabel.Location = new Point(12, 133);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 25;
            descLabel.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.BackColor = Color.WhiteSmoke;
            descTextBox.Font = new Font("Constantia", 10.2F);
            descTextBox.Location = new Point(12, 157);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ReadOnly = true;
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(338, 122);
            descTextBox.TabIndex = 24;
            descTextBox.TabStop = false;
            descTextBox.Text = "[description]";
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
            costTextBox.TabIndex = 23;
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
            costLabel.TabIndex = 22;
            costLabel.Text = "Cost";
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
            weightTextBox.TabIndex = 21;
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
            weightLabel.TabIndex = 20;
            weightLabel.Text = "Weight";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            typeLabel.Location = new Point(12, 45);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(45, 18);
            typeLabel.TabIndex = 19;
            typeLabel.Text = "[type]";
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
            nameTextBox.TabIndex = 18;
            nameTextBox.TabStop = false;
            nameTextBox.Text = "[Item Name]";
            // 
            // EquipmentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(362, 291);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(costTextBox);
            Controls.Add(costLabel);
            Controls.Add(weightTextBox);
            Controls.Add(weightLabel);
            Controls.Add(typeLabel);
            Controls.Add(nameTextBox);
            Name = "EquipmentDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Equipment Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descLabel;
        private TextBox descTextBox;
        private TextBox costTextBox;
        private Label costLabel;
        private TextBox weightTextBox;
        private Label weightLabel;
        private Label typeLabel;
        private TextBox nameTextBox;
    }
}