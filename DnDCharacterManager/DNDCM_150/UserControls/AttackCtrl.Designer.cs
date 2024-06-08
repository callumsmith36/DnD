namespace CharacterManager
{
    partial class AttackCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttackCtrl));
            removeIcon = new PictureBox();
            dmgLabel = new Label();
            attackLabel = new Label();
            nameLabel = new Label();
            lineLabel1 = new Label();
            lineLabel2 = new Label();
            ((System.ComponentModel.ISupportInitialize)removeIcon).BeginInit();
            SuspendLayout();
            // 
            // removeIcon
            // 
            removeIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeIcon.BackgroundImage = (Image)resources.GetObject("removeIcon.BackgroundImage");
            removeIcon.BackgroundImageLayout = ImageLayout.Zoom;
            removeIcon.Cursor = Cursors.Hand;
            removeIcon.Location = new Point(328, 8);
            removeIcon.Name = "removeIcon";
            removeIcon.Size = new Size(16, 16);
            removeIcon.TabIndex = 0;
            removeIcon.TabStop = false;
            removeIcon.Click += removeIcon_Click;
            // 
            // dmgLabel
            // 
            dmgLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dmgLabel.AutoSize = true;
            dmgLabel.Location = new Point(256, 8);
            dmgLabel.Name = "dmgLabel";
            dmgLabel.Size = new Size(56, 18);
            dmgLabel.TabIndex = 1;
            dmgLabel.Text = "2d8 + 6";
            dmgLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // attackLabel
            // 
            attackLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            attackLabel.Location = new Point(204, 8);
            attackLabel.Name = "attackLabel";
            attackLabel.Size = new Size(45, 18);
            attackLabel.TabIndex = 2;
            attackLabel.Text = "DC28";
            attackLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(8, 8);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(190, 18);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "[name]";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lineLabel1
            // 
            lineLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineLabel1.AutoSize = true;
            lineLabel1.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lineLabel1.Location = new Point(194, 5);
            lineLabel1.Name = "lineLabel1";
            lineLabel1.Size = new Size(16, 22);
            lineLabel1.TabIndex = 4;
            lineLabel1.Text = "|";
            // 
            // lineLabel2
            // 
            lineLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lineLabel2.AutoSize = true;
            lineLabel2.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lineLabel2.Location = new Point(245, 5);
            lineLabel2.Name = "lineLabel2";
            lineLabel2.Size = new Size(16, 22);
            lineLabel2.TabIndex = 5;
            lineLabel2.Text = "|";
            // 
            // AttackCtrl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            Controls.Add(attackLabel);
            Controls.Add(dmgLabel);
            Controls.Add(removeIcon);
            Controls.Add(lineLabel1);
            Controls.Add(lineLabel2);
            Controls.Add(nameLabel);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(360, 33);
            Name = "AttackCtrl";
            Size = new Size(360, 33);
            ((System.ComponentModel.ISupportInitialize)removeIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox removeIcon;
        private Label dmgLabel;
        private Label attackLabel;
        private Label nameLabel;
        private Label lineLabel1;
        private Label lineLabel2;
    }
}
