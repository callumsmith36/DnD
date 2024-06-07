namespace CharacterManager
{
    partial class SpellCastForm
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
            confirmBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            levelCtrl = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)levelCtrl).BeginInit();
            SuspendLayout();
            // 
            // confirmBtn
            // 
            confirmBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            confirmBtn.BackColor = Color.Gainsboro;
            confirmBtn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            confirmBtn.ForeColor = SystemColors.ControlText;
            confirmBtn.Location = new Point(27, 82);
            confirmBtn.Margin = new Padding(3, 3, 3, 6);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(94, 29);
            confirmBtn.TabIndex = 4;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelBtn.BackColor = Color.Gainsboro;
            cancelBtn.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(137, 82);
            cancelBtn.Margin = new Padding(3, 3, 3, 6);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 6;
            label1.Text = "Cast at level";
            // 
            // levelCtrl
            // 
            levelCtrl.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            levelCtrl.Location = new Point(154, 20);
            levelCtrl.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            levelCtrl.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            levelCtrl.Name = "levelCtrl";
            levelCtrl.Size = new Size(57, 32);
            levelCtrl.TabIndex = 7;
            levelCtrl.TextAlign = HorizontalAlignment.Center;
            levelCtrl.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SpellCastForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(258, 126);
            Controls.Add(levelCtrl);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Name = "SpellCastForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cast Spell";
            ((System.ComponentModel.ISupportInitialize)levelCtrl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmBtn;
        private Button cancelBtn;
        private Label label1;
        private NumericUpDown levelCtrl;
    }
}