namespace CharacterManager
{
    partial class WaitForm
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
            msgLabel = new Label();
            progBar = new ProgressBar();
            SuspendLayout();
            // 
            // msgLabel
            // 
            msgLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            msgLabel.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msgLabel.Location = new Point(12, 19);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(350, 44);
            msgLabel.TabIndex = 0;
            msgLabel.Text = "[message]";
            msgLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progBar
            // 
            progBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progBar.Location = new Point(41, 79);
            progBar.Name = "progBar";
            progBar.Size = new Size(293, 30);
            progBar.TabIndex = 2;
            // 
            // WaitForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(374, 121);
            ControlBox = false;
            Controls.Add(progBar);
            Controls.Add(msgLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WaitForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D&D Character Manager";
            ResumeLayout(false);
        }

        #endregion

        private Label msgLabel;
        private Label waitLabel;
        private ProgressBar progBar;
    }
}