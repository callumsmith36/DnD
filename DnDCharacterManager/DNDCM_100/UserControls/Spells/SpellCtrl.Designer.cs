namespace CharacterManager
{
    partial class SpellCtrl
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
            nameTextBox = new TextBox();
            concentrationLabel = new Label();
            castBtn = new Button();
            infoBtn = new Button();
            ritualLabel = new Label();
            conRitTable = new TableLayoutPanel();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = Color.WhiteSmoke;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Constantia", 12F);
            nameTextBox.Location = new Point(5, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(347, 25);
            nameTextBox.TabIndex = 0;
            nameTextBox.Text = "[Spell Name]";
            // 
            // concentrationLabel
            // 
            concentrationLabel.Anchor = AnchorStyles.Left;
            concentrationLabel.AutoSize = true;
            concentrationLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            concentrationLabel.Location = new Point(205, 71);
            concentrationLabel.Name = "concentrationLabel";
            concentrationLabel.Size = new Size(100, 18);
            concentrationLabel.TabIndex = 1;
            concentrationLabel.Text = "Concentration";
            concentrationLabel.Visible = false;
            // 
            // castBtn
            // 
            castBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            castBtn.BackColor = Color.Gainsboro;
            castBtn.Font = new Font("Constantia", 10.2F);
            castBtn.Location = new Point(5, 60);
            castBtn.Margin = new Padding(3, 3, 3, 6);
            castBtn.Name = "castBtn";
            castBtn.Size = new Size(94, 29);
            castBtn.TabIndex = 2;
            castBtn.Text = "Cast";
            castBtn.UseVisualStyleBackColor = true;
            castBtn.Click += castBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            infoBtn.BackColor = Color.Gainsboro;
            infoBtn.Font = new Font("Constantia", 10.2F);
            infoBtn.ForeColor = SystemColors.ControlText;
            infoBtn.Location = new Point(105, 60);
            infoBtn.Margin = new Padding(3, 3, 3, 6);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(94, 29);
            infoBtn.TabIndex = 3;
            infoBtn.Text = "Details...";
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // ritualLabel
            // 
            ritualLabel.Anchor = AnchorStyles.Left;
            ritualLabel.AutoSize = true;
            ritualLabel.Font = new Font("Constantia", 9F, FontStyle.Italic);
            ritualLabel.Location = new Point(205, 71);
            ritualLabel.Name = "ritualLabel";
            ritualLabel.Size = new Size(46, 18);
            ritualLabel.TabIndex = 4;
            ritualLabel.Text = "Ritual";
            ritualLabel.Visible = false;
            // 
            // conRitTable
            // 
            conRitTable.ColumnCount = 2;
            conRitTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            conRitTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            conRitTable.Location = new Point(5, 34);
            conRitTable.Name = "conRitTable";
            conRitTable.RowCount = 1;
            conRitTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            conRitTable.Size = new Size(230, 20);
            conRitTable.TabIndex = 5;
            // 
            // SpellCtrl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ritualLabel);
            Controls.Add(concentrationLabel);
            Controls.Add(conRitTable);
            Controls.Add(infoBtn);
            Controls.Add(castBtn);
            Controls.Add(nameTextBox);
            Name = "SpellCtrl";
            Size = new Size(357, 95);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label concentrationLabel;
        private Button castBtn;
        private Button infoBtn;
        private Label ritualLabel;
        private TableLayoutPanel conRitTable;
    }
}
