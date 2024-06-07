namespace CharacterManager
{
    partial class InventoryItemCtrl
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
            infoBtn = new Button();
            nameLabel = new Label();
            qtyNumCtrl = new NumericUpDown();
            qtyLabel = new Label();
            equipCheckBox = new CheckBox();
            attuneCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)qtyNumCtrl).BeginInit();
            SuspendLayout();
            // 
            // infoBtn
            // 
            infoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            infoBtn.BackColor = Color.Gainsboro;
            infoBtn.Font = new Font("Constantia", 10.2F);
            infoBtn.ForeColor = SystemColors.ControlText;
            infoBtn.Location = new Point(440, 10);
            infoBtn.Margin = new Padding(2, 2, 2, 5);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(75, 24);
            infoBtn.TabIndex = 10;
            infoBtn.TabStop = false;
            infoBtn.Text = "Details...";
            infoBtn.UseVisualStyleBackColor = false;
            infoBtn.Click += infoBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.WhiteSmoke;
            nameLabel.Font = new Font("Constantia", 12F);
            nameLabel.Location = new Point(2, 13);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.MaximumSize = new Size(328, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 19);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "[Item Name]";
            // 
            // qtyNumCtrl
            // 
            qtyNumCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qtyNumCtrl.Font = new Font("Constantia", 10F);
            qtyNumCtrl.Location = new Point(383, 10);
            qtyNumCtrl.Margin = new Padding(2);
            qtyNumCtrl.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            qtyNumCtrl.Name = "qtyNumCtrl";
            qtyNumCtrl.Size = new Size(53, 24);
            qtyNumCtrl.TabIndex = 11;
            qtyNumCtrl.TextAlign = HorizontalAlignment.Center;
            qtyNumCtrl.ValueChanged += qtyNumCtrl_ValueChanged;
            // 
            // qtyLabel
            // 
            qtyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new Font("Constantia", 9F);
            qtyLabel.Location = new Point(348, 13);
            qtyLabel.Margin = new Padding(2, 0, 2, 0);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(31, 14);
            qtyLabel.TabIndex = 12;
            qtyLabel.Text = "QTY";
            // 
            // equipCheckBox
            // 
            equipCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            equipCheckBox.AutoSize = true;
            equipCheckBox.Enabled = false;
            equipCheckBox.Font = new Font("Constantia", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equipCheckBox.Location = new Point(11, 25);
            equipCheckBox.Margin = new Padding(2);
            equipCheckBox.Name = "equipCheckBox";
            equipCheckBox.Size = new Size(70, 17);
            equipCheckBox.TabIndex = 14;
            equipCheckBox.Text = "Equipped";
            equipCheckBox.UseVisualStyleBackColor = true;
            equipCheckBox.Visible = false;
            equipCheckBox.CheckedChanged += equipCheckBox_CheckedChanged;
            // 
            // attuneCheckBox
            // 
            attuneCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            attuneCheckBox.AutoSize = true;
            attuneCheckBox.Enabled = false;
            attuneCheckBox.Font = new Font("Constantia", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attuneCheckBox.Location = new Point(82, 25);
            attuneCheckBox.Margin = new Padding(2);
            attuneCheckBox.Name = "attuneCheckBox";
            attuneCheckBox.Size = new Size(64, 17);
            attuneCheckBox.TabIndex = 15;
            attuneCheckBox.Text = "Attuned";
            attuneCheckBox.UseVisualStyleBackColor = true;
            attuneCheckBox.Visible = false;
            attuneCheckBox.CheckedChanged += attuneCheckBox_CheckedChanged;
            // 
            // InventoryItemCtrl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(nameLabel);
            Controls.Add(attuneCheckBox);
            Controls.Add(equipCheckBox);
            Controls.Add(qtyLabel);
            Controls.Add(qtyNumCtrl);
            Controls.Add(infoBtn);
            Margin = new Padding(2);
            Name = "InventoryItemCtrl";
            Size = new Size(526, 43);
            ((System.ComponentModel.ISupportInitialize)qtyNumCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button infoBtn;
        private Label nameLabel;
        private NumericUpDown qtyNumCtrl;
        private Label qtyLabel;
        private CheckBox equipCheckBox;
        private CheckBox attuneCheckBox;
    }
}
