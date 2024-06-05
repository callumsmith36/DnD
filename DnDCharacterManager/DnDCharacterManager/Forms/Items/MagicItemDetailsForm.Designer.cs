namespace CharacterManager
{
    partial class MagicItemDetailsForm
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
            variantTable = new TableLayoutPanel();
            variantLabel = new Label();
            descLabel = new Label();
            descTextBox = new TextBox();
            typeLabel = new Label();
            nameTextBox = new TextBox();
            SuspendLayout();
            // 
            // variantTable
            // 
            variantTable.AutoSize = true;
            variantTable.ColumnCount = 1;
            variantTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            variantTable.Location = new Point(137, 73);
            variantTable.Name = "variantTable";
            variantTable.RowCount = 1;
            variantTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            variantTable.Size = new Size(57, 11);
            variantTable.TabIndex = 49;
            // 
            // variantLabel
            // 
            variantLabel.AutoSize = true;
            variantLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            variantLabel.Location = new Point(12, 73);
            variantLabel.Name = "variantLabel";
            variantLabel.Size = new Size(77, 21);
            variantLabel.TabIndex = 48;
            variantLabel.Text = "Variants";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Font = new Font("Constantia", 10.2F, FontStyle.Bold);
            descLabel.Location = new Point(12, 100);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(105, 21);
            descLabel.TabIndex = 47;
            descLabel.Text = "Description";
            // 
            // descTextBox
            // 
            descTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descTextBox.BackColor = Color.WhiteSmoke;
            descTextBox.Font = new Font("Constantia", 10.2F);
            descTextBox.Location = new Point(12, 127);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.ReadOnly = true;
            descTextBox.ScrollBars = ScrollBars.Vertical;
            descTextBox.Size = new Size(480, 221);
            descTextBox.TabIndex = 46;
            descTextBox.TabStop = false;
            descTextBox.Text = "[description]";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            typeLabel.Location = new Point(12, 45);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(45, 18);
            typeLabel.TabIndex = 45;
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
            nameTextBox.Size = new Size(480, 25);
            nameTextBox.TabIndex = 44;
            nameTextBox.TabStop = false;
            nameTextBox.Text = "[Item Name]";
            // 
            // MagicItemDetailsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(504, 360);
            Controls.Add(variantTable);
            Controls.Add(variantLabel);
            Controls.Add(descLabel);
            Controls.Add(descTextBox);
            Controls.Add(typeLabel);
            Controls.Add(nameTextBox);
            Name = "MagicItemDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Magic Item Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel variantTable;
        private Label variantLabel;
        private Label descLabel;
        private TextBox descTextBox;
        private Label typeLabel;
        private TextBox nameTextBox;
    }
}