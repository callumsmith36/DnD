namespace CharacterManager
{
    partial class ClassSelectForm
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
            classSelectCtrl1 = new ClassSelectCtrl();
            cancelBtn = new Button();
            okBtn = new Button();
            addBtn = new Button();
            classCtrlTable = new TableLayoutPanel();
            classCtrlTable.SuspendLayout();
            SuspendLayout();
            // 
            // classSelectCtrl1
            // 
            classSelectCtrl1.BackColor = Color.WhiteSmoke;
            classSelectCtrl1.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            classSelectCtrl1.Location = new Point(3, 3);
            classSelectCtrl1.Name = "classSelectCtrl1";
            classSelectCtrl1.Size = new Size(575, 45);
            classSelectCtrl1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(468, 74);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 28;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.BackColor = Color.Gainsboro;
            okBtn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            okBtn.ForeColor = SystemColors.ControlText;
            okBtn.Location = new Point(352, 74);
            okBtn.Margin = new Padding(3, 3, 3, 6);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(94, 29);
            okBtn.TabIndex = 27;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBtn.BackColor = Color.Gainsboro;
            addBtn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = SystemColors.ControlText;
            addBtn.Location = new Point(236, 74);
            addBtn.Margin = new Padding(3, 3, 3, 6);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 29;
            addBtn.Text = "Add Class";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // classCtrlTable
            // 
            classCtrlTable.AutoSize = true;
            classCtrlTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            classCtrlTable.ColumnCount = 1;
            classCtrlTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            classCtrlTable.Controls.Add(classSelectCtrl1, 0, 0);
            classCtrlTable.Location = new Point(12, 12);
            classCtrlTable.Name = "classCtrlTable";
            classCtrlTable.RowCount = 1;
            classCtrlTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            classCtrlTable.Size = new Size(581, 51);
            classCtrlTable.TabIndex = 30;
            // 
            // ClassSelectForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(604, 118);
            Controls.Add(classCtrlTable);
            Controls.Add(addBtn);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ClassSelectForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Class";
            classCtrlTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ClassSelectCtrl classSelectCtrl1;
        private Button cancelBtn;
        private Button okBtn;
        private Button addBtn;
        private TableLayoutPanel classCtrlTable;
    }
}