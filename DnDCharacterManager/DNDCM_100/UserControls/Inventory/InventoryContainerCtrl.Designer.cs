namespace CharacterManager
{
    partial class InventoryContainerCtrl
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
            removeBtn = new Button();
            openBtn = new Button();
            infoBtn = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.WhiteSmoke;
            nameLabel.Font = new Font("Constantia", 12F);
            nameLabel.Location = new Point(4, 13);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.MaximumSize = new Size(256, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(136, 19);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "[Container Name]";
            // 
            // removeBtn
            // 
            removeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeBtn.BackColor = Color.Gainsboro;
            removeBtn.Font = new Font("Constantia", 10.2F);
            removeBtn.ForeColor = SystemColors.ControlText;
            removeBtn.Location = new Point(443, 10);
            removeBtn.Margin = new Padding(4, 4, 4, 8);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(75, 25);
            removeBtn.TabIndex = 15;
            removeBtn.TabStop = false;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // openBtn
            // 
            openBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            openBtn.BackColor = Color.Gainsboro;
            openBtn.Font = new Font("Constantia", 10.2F);
            openBtn.ForeColor = SystemColors.ControlText;
            openBtn.Location = new Point(277, 10);
            openBtn.Margin = new Padding(4, 4, 4, 8);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(75, 25);
            openBtn.TabIndex = 16;
            openBtn.TabStop = false;
            openBtn.Text = "Open...";
            openBtn.UseVisualStyleBackColor = false;
            openBtn.Click += openBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            infoBtn.BackColor = Color.Gainsboro;
            infoBtn.Font = new Font("Constantia", 10.2F);
            infoBtn.ForeColor = SystemColors.ControlText;
            infoBtn.Location = new Point(360, 10);
            infoBtn.Margin = new Padding(4, 4, 4, 8);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(75, 25);
            infoBtn.TabIndex = 17;
            infoBtn.TabStop = false;
            infoBtn.Text = "Details...";
            infoBtn.UseVisualStyleBackColor = false;
            infoBtn.Click += infoBtn_Click;
            // 
            // InventoryContainerCtrl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(infoBtn);
            Controls.Add(openBtn);
            Controls.Add(removeBtn);
            Controls.Add(nameLabel);
            Margin = new Padding(4);
            Name = "InventoryContainerCtrl";
            Size = new Size(526, 43);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Button removeBtn;
        private Button openBtn;
        private Button infoBtn;
    }
}
