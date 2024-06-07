namespace CharacterManager
{
    partial class InventoryForm
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
            invTabCtrl = new TabControl();
            generalTab = new TabPage();
            generalTable = new TableLayoutPanel();
            weaponTab = new TabPage();
            weaponTable = new TableLayoutPanel();
            armourTab = new TabPage();
            armourTable = new TableLayoutPanel();
            magicTab = new TabPage();
            magicTable = new TableLayoutPanel();
            potionTab = new TabPage();
            potionTable = new TableLayoutPanel();
            toolTab = new TabPage();
            toolTable = new TableLayoutPanel();
            containerTab = new TabPage();
            containerTable = new TableLayoutPanel();
            cpGroup = new GroupBox();
            cpCtrl = new NumericUpDown();
            spGroup = new GroupBox();
            spCtrl = new NumericUpDown();
            gpGroup = new GroupBox();
            gpCtrl = new NumericUpDown();
            ppGroup = new GroupBox();
            ppCtrl = new NumericUpDown();
            addBtn = new Button();
            categoryDescTextBox = new TextBox();
            categoryDescGroup = new GroupBox();
            showEquippedBtn = new Button();
            showAttunedBtn = new Button();
            invTabCtrl.SuspendLayout();
            generalTab.SuspendLayout();
            weaponTab.SuspendLayout();
            armourTab.SuspendLayout();
            magicTab.SuspendLayout();
            potionTab.SuspendLayout();
            toolTab.SuspendLayout();
            containerTab.SuspendLayout();
            cpGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cpCtrl).BeginInit();
            spGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spCtrl).BeginInit();
            gpGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gpCtrl).BeginInit();
            ppGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ppCtrl).BeginInit();
            categoryDescGroup.SuspendLayout();
            SuspendLayout();
            // 
            // invTabCtrl
            // 
            invTabCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            invTabCtrl.Controls.Add(generalTab);
            invTabCtrl.Controls.Add(weaponTab);
            invTabCtrl.Controls.Add(armourTab);
            invTabCtrl.Controls.Add(magicTab);
            invTabCtrl.Controls.Add(potionTab);
            invTabCtrl.Controls.Add(toolTab);
            invTabCtrl.Controls.Add(containerTab);
            invTabCtrl.Font = new Font("Constantia", 10F);
            invTabCtrl.Location = new Point(10, 144);
            invTabCtrl.Margin = new Padding(2, 2, 2, 2);
            invTabCtrl.Name = "invTabCtrl";
            invTabCtrl.SelectedIndex = 0;
            invTabCtrl.Size = new Size(558, 218);
            invTabCtrl.TabIndex = 11;
            invTabCtrl.SelectedIndexChanged += invTabCtrl_SelectedIndexChanged;
            // 
            // generalTab
            // 
            generalTab.AutoScroll = true;
            generalTab.Controls.Add(generalTable);
            generalTab.Location = new Point(4, 24);
            generalTab.Margin = new Padding(2, 2, 2, 2);
            generalTab.Name = "generalTab";
            generalTab.Padding = new Padding(2, 2, 2, 2);
            generalTab.Size = new Size(550, 190);
            generalTab.TabIndex = 0;
            generalTab.Text = "General   ";
            generalTab.UseVisualStyleBackColor = true;
            // 
            // generalTable
            // 
            generalTable.AutoSize = true;
            generalTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            generalTable.ColumnCount = 1;
            generalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            generalTable.Location = new Point(5, 5);
            generalTable.Margin = new Padding(2, 2, 2, 2);
            generalTable.Name = "generalTable";
            generalTable.RowCount = 2;
            generalTable.RowStyles.Add(new RowStyle());
            generalTable.RowStyles.Add(new RowStyle());
            generalTable.Size = new Size(0, 0);
            generalTable.TabIndex = 0;
            // 
            // weaponTab
            // 
            weaponTab.AutoScroll = true;
            weaponTab.Controls.Add(weaponTable);
            weaponTab.Location = new Point(4, 24);
            weaponTab.Margin = new Padding(2, 2, 2, 2);
            weaponTab.Name = "weaponTab";
            weaponTab.Padding = new Padding(2, 2, 2, 2);
            weaponTab.Size = new Size(550, 190);
            weaponTab.TabIndex = 1;
            weaponTab.Text = "Weapons   ";
            weaponTab.UseVisualStyleBackColor = true;
            // 
            // weaponTable
            // 
            weaponTable.AutoSize = true;
            weaponTable.ColumnCount = 1;
            weaponTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            weaponTable.Location = new Point(5, 5);
            weaponTable.Margin = new Padding(2, 2, 2, 2);
            weaponTable.Name = "weaponTable";
            weaponTable.RowCount = 2;
            weaponTable.RowStyles.Add(new RowStyle());
            weaponTable.RowStyles.Add(new RowStyle());
            weaponTable.Size = new Size(0, 0);
            weaponTable.TabIndex = 0;
            // 
            // armourTab
            // 
            armourTab.AutoScroll = true;
            armourTab.Controls.Add(armourTable);
            armourTab.Location = new Point(4, 24);
            armourTab.Margin = new Padding(2, 2, 2, 2);
            armourTab.Name = "armourTab";
            armourTab.Padding = new Padding(2, 2, 2, 2);
            armourTab.Size = new Size(550, 190);
            armourTab.TabIndex = 2;
            armourTab.Text = "Armour   ";
            armourTab.UseVisualStyleBackColor = true;
            // 
            // armourTable
            // 
            armourTable.AutoSize = true;
            armourTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            armourTable.ColumnCount = 1;
            armourTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            armourTable.Location = new Point(5, 5);
            armourTable.Margin = new Padding(2, 2, 2, 2);
            armourTable.Name = "armourTable";
            armourTable.RowCount = 2;
            armourTable.RowStyles.Add(new RowStyle());
            armourTable.RowStyles.Add(new RowStyle());
            armourTable.Size = new Size(0, 0);
            armourTable.TabIndex = 0;
            // 
            // magicTab
            // 
            magicTab.AutoScroll = true;
            magicTab.Controls.Add(magicTable);
            magicTab.Location = new Point(4, 24);
            magicTab.Margin = new Padding(2, 2, 2, 2);
            magicTab.Name = "magicTab";
            magicTab.Padding = new Padding(2, 2, 2, 2);
            magicTab.Size = new Size(550, 190);
            magicTab.TabIndex = 3;
            magicTab.Text = "Magic Items   ";
            magicTab.UseVisualStyleBackColor = true;
            // 
            // magicTable
            // 
            magicTable.AutoSize = true;
            magicTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            magicTable.ColumnCount = 1;
            magicTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            magicTable.Location = new Point(5, 5);
            magicTable.Margin = new Padding(2, 2, 2, 2);
            magicTable.Name = "magicTable";
            magicTable.RowCount = 2;
            magicTable.RowStyles.Add(new RowStyle());
            magicTable.RowStyles.Add(new RowStyle());
            magicTable.Size = new Size(0, 0);
            magicTable.TabIndex = 0;
            // 
            // potionTab
            // 
            potionTab.AutoScroll = true;
            potionTab.Controls.Add(potionTable);
            potionTab.Location = new Point(4, 24);
            potionTab.Margin = new Padding(2, 2, 2, 2);
            potionTab.Name = "potionTab";
            potionTab.Padding = new Padding(2, 2, 2, 2);
            potionTab.Size = new Size(550, 190);
            potionTab.TabIndex = 4;
            potionTab.Text = "Potions   ";
            potionTab.UseVisualStyleBackColor = true;
            // 
            // potionTable
            // 
            potionTable.AutoSize = true;
            potionTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            potionTable.ColumnCount = 1;
            potionTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            potionTable.Location = new Point(5, 5);
            potionTable.Margin = new Padding(2, 2, 2, 2);
            potionTable.Name = "potionTable";
            potionTable.RowCount = 2;
            potionTable.RowStyles.Add(new RowStyle());
            potionTable.RowStyles.Add(new RowStyle());
            potionTable.Size = new Size(0, 0);
            potionTable.TabIndex = 0;
            // 
            // toolTab
            // 
            toolTab.AutoScroll = true;
            toolTab.Controls.Add(toolTable);
            toolTab.Location = new Point(4, 24);
            toolTab.Margin = new Padding(2, 2, 2, 2);
            toolTab.Name = "toolTab";
            toolTab.Padding = new Padding(2, 2, 2, 2);
            toolTab.Size = new Size(550, 190);
            toolTab.TabIndex = 5;
            toolTab.Text = "Tools & Kits   ";
            toolTab.UseVisualStyleBackColor = true;
            // 
            // toolTable
            // 
            toolTable.AutoSize = true;
            toolTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            toolTable.ColumnCount = 1;
            toolTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            toolTable.Location = new Point(5, 5);
            toolTable.Margin = new Padding(2, 2, 2, 2);
            toolTable.Name = "toolTable";
            toolTable.RowCount = 2;
            toolTable.RowStyles.Add(new RowStyle());
            toolTable.RowStyles.Add(new RowStyle());
            toolTable.Size = new Size(0, 0);
            toolTable.TabIndex = 0;
            // 
            // containerTab
            // 
            containerTab.AutoScroll = true;
            containerTab.Controls.Add(containerTable);
            containerTab.Location = new Point(4, 24);
            containerTab.Margin = new Padding(2, 2, 2, 2);
            containerTab.Name = "containerTab";
            containerTab.Padding = new Padding(2, 2, 2, 2);
            containerTab.Size = new Size(550, 190);
            containerTab.TabIndex = 6;
            containerTab.Text = "Packs & Bags   ";
            containerTab.UseVisualStyleBackColor = true;
            // 
            // containerTable
            // 
            containerTable.AutoSize = true;
            containerTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            containerTable.ColumnCount = 1;
            containerTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            containerTable.Location = new Point(5, 5);
            containerTable.Margin = new Padding(2, 2, 2, 2);
            containerTable.Name = "containerTable";
            containerTable.RowCount = 2;
            containerTable.RowStyles.Add(new RowStyle());
            containerTable.RowStyles.Add(new RowStyle());
            containerTable.Size = new Size(0, 0);
            containerTable.TabIndex = 0;
            // 
            // cpGroup
            // 
            cpGroup.Controls.Add(cpCtrl);
            cpGroup.Font = new Font("Constantia", 11F);
            cpGroup.Location = new Point(10, 10);
            cpGroup.Margin = new Padding(2, 2, 2, 2);
            cpGroup.Name = "cpGroup";
            cpGroup.Padding = new Padding(2, 2, 2, 2);
            cpGroup.Size = new Size(112, 60);
            cpGroup.TabIndex = 12;
            cpGroup.TabStop = false;
            cpGroup.Text = "CP";
            // 
            // cpCtrl
            // 
            cpCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cpCtrl.BackColor = Color.WhiteSmoke;
            cpCtrl.BorderStyle = BorderStyle.None;
            cpCtrl.Font = new Font("Constantia", 20F);
            cpCtrl.Location = new Point(5, 17);
            cpCtrl.Margin = new Padding(2, 2, 2, 2);
            cpCtrl.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            cpCtrl.Name = "cpCtrl";
            cpCtrl.Size = new Size(102, 36);
            cpCtrl.TabIndex = 13;
            cpCtrl.TextAlign = HorizontalAlignment.Center;
            cpCtrl.ThousandsSeparator = true;
            cpCtrl.ValueChanged += cpCtrl_ValueChanged;
            // 
            // spGroup
            // 
            spGroup.Controls.Add(spCtrl);
            spGroup.Font = new Font("Constantia", 11F);
            spGroup.Location = new Point(126, 10);
            spGroup.Margin = new Padding(2, 2, 2, 2);
            spGroup.Name = "spGroup";
            spGroup.Padding = new Padding(2, 2, 2, 2);
            spGroup.Size = new Size(112, 60);
            spGroup.TabIndex = 14;
            spGroup.TabStop = false;
            spGroup.Text = "SP";
            // 
            // spCtrl
            // 
            spCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            spCtrl.BackColor = Color.WhiteSmoke;
            spCtrl.BorderStyle = BorderStyle.None;
            spCtrl.Font = new Font("Constantia", 20F);
            spCtrl.Location = new Point(5, 17);
            spCtrl.Margin = new Padding(2, 2, 2, 2);
            spCtrl.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            spCtrl.Name = "spCtrl";
            spCtrl.Size = new Size(102, 36);
            spCtrl.TabIndex = 13;
            spCtrl.TextAlign = HorizontalAlignment.Center;
            spCtrl.ThousandsSeparator = true;
            spCtrl.ValueChanged += spCtrl_ValueChanged;
            // 
            // gpGroup
            // 
            gpGroup.Controls.Add(gpCtrl);
            gpGroup.Font = new Font("Constantia", 11F);
            gpGroup.Location = new Point(243, 10);
            gpGroup.Margin = new Padding(2, 2, 2, 2);
            gpGroup.Name = "gpGroup";
            gpGroup.Padding = new Padding(2, 2, 2, 2);
            gpGroup.Size = new Size(112, 60);
            gpGroup.TabIndex = 15;
            gpGroup.TabStop = false;
            gpGroup.Text = "GP";
            // 
            // gpCtrl
            // 
            gpCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpCtrl.BackColor = Color.WhiteSmoke;
            gpCtrl.BorderStyle = BorderStyle.None;
            gpCtrl.Font = new Font("Constantia", 20F);
            gpCtrl.Location = new Point(5, 17);
            gpCtrl.Margin = new Padding(2, 2, 2, 2);
            gpCtrl.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            gpCtrl.Name = "gpCtrl";
            gpCtrl.Size = new Size(102, 36);
            gpCtrl.TabIndex = 13;
            gpCtrl.TextAlign = HorizontalAlignment.Center;
            gpCtrl.ThousandsSeparator = true;
            gpCtrl.ValueChanged += gpCtrl_ValueChanged;
            // 
            // ppGroup
            // 
            ppGroup.Controls.Add(ppCtrl);
            ppGroup.Font = new Font("Constantia", 11F);
            ppGroup.Location = new Point(360, 10);
            ppGroup.Margin = new Padding(2, 2, 2, 2);
            ppGroup.Name = "ppGroup";
            ppGroup.Padding = new Padding(2, 2, 2, 2);
            ppGroup.Size = new Size(112, 60);
            ppGroup.TabIndex = 16;
            ppGroup.TabStop = false;
            ppGroup.Text = "PP";
            // 
            // ppCtrl
            // 
            ppCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ppCtrl.BackColor = Color.WhiteSmoke;
            ppCtrl.BorderStyle = BorderStyle.None;
            ppCtrl.Font = new Font("Constantia", 20F);
            ppCtrl.Location = new Point(5, 17);
            ppCtrl.Margin = new Padding(2, 2, 2, 2);
            ppCtrl.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            ppCtrl.Name = "ppCtrl";
            ppCtrl.Size = new Size(102, 36);
            ppCtrl.TabIndex = 13;
            ppCtrl.TextAlign = HorizontalAlignment.Center;
            ppCtrl.ThousandsSeparator = true;
            ppCtrl.ValueChanged += ppCtrl_ValueChanged;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addBtn.BackColor = Color.Gainsboro;
            addBtn.Font = new Font("Constantia", 10.2F);
            addBtn.ForeColor = SystemColors.ControlText;
            addBtn.Location = new Point(29, 372);
            addBtn.Margin = new Padding(2, 2, 2, 5);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(104, 26);
            addBtn.TabIndex = 17;
            addBtn.TabStop = false;
            addBtn.Text = "Add Item...";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // categoryDescTextBox
            // 
            categoryDescTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoryDescTextBox.BackColor = Color.WhiteSmoke;
            categoryDescTextBox.BorderStyle = BorderStyle.None;
            categoryDescTextBox.Font = new Font("Constantia", 9F);
            categoryDescTextBox.Location = new Point(22, 20);
            categoryDescTextBox.Margin = new Padding(2, 2, 2, 2);
            categoryDescTextBox.Multiline = true;
            categoryDescTextBox.Name = "categoryDescTextBox";
            categoryDescTextBox.ReadOnly = true;
            categoryDescTextBox.Size = new Size(510, 30);
            categoryDescTextBox.TabIndex = 18;
            categoryDescTextBox.TabStop = false;
            categoryDescTextBox.Text = "General equipment that does not fit into the other categories. Here, you can also add temporary custom items that are not added to the database.";
            // 
            // categoryDescGroup
            // 
            categoryDescGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryDescGroup.Controls.Add(categoryDescTextBox);
            categoryDescGroup.Font = new Font("Constantia", 10F);
            categoryDescGroup.Location = new Point(10, 84);
            categoryDescGroup.Margin = new Padding(2, 2, 2, 2);
            categoryDescGroup.Name = "categoryDescGroup";
            categoryDescGroup.Padding = new Padding(2, 2, 2, 2);
            categoryDescGroup.Size = new Size(558, 55);
            categoryDescGroup.TabIndex = 14;
            categoryDescGroup.TabStop = false;
            categoryDescGroup.Text = "Category Description";
            // 
            // showEquippedBtn
            // 
            showEquippedBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            showEquippedBtn.BackColor = Color.Gainsboro;
            showEquippedBtn.Font = new Font("Constantia", 10.2F);
            showEquippedBtn.ForeColor = SystemColors.ControlText;
            showEquippedBtn.Location = new Point(314, 372);
            showEquippedBtn.Margin = new Padding(2, 2, 2, 5);
            showEquippedBtn.Name = "showEquippedBtn";
            showEquippedBtn.Size = new Size(114, 26);
            showEquippedBtn.TabIndex = 18;
            showEquippedBtn.TabStop = false;
            showEquippedBtn.Text = "Show Equipped";
            showEquippedBtn.UseVisualStyleBackColor = false;
            showEquippedBtn.Click += showEquippedBtn_Click;
            // 
            // showAttunedBtn
            // 
            showAttunedBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            showAttunedBtn.BackColor = Color.Gainsboro;
            showAttunedBtn.Font = new Font("Constantia", 10.2F);
            showAttunedBtn.ForeColor = SystemColors.ControlText;
            showAttunedBtn.Location = new Point(433, 372);
            showAttunedBtn.Margin = new Padding(2, 2, 2, 5);
            showAttunedBtn.Name = "showAttunedBtn";
            showAttunedBtn.Size = new Size(114, 26);
            showAttunedBtn.TabIndex = 19;
            showAttunedBtn.TabStop = false;
            showAttunedBtn.Text = "Show Attuned";
            showAttunedBtn.UseVisualStyleBackColor = false;
            showAttunedBtn.Click += showAttunedBtn_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(579, 409);
            Controls.Add(showAttunedBtn);
            Controls.Add(showEquippedBtn);
            Controls.Add(categoryDescGroup);
            Controls.Add(addBtn);
            Controls.Add(ppGroup);
            Controls.Add(gpGroup);
            Controls.Add(spGroup);
            Controls.Add(cpGroup);
            Controls.Add(invTabCtrl);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(595, 448);
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inventory";
            invTabCtrl.ResumeLayout(false);
            generalTab.ResumeLayout(false);
            generalTab.PerformLayout();
            weaponTab.ResumeLayout(false);
            weaponTab.PerformLayout();
            armourTab.ResumeLayout(false);
            armourTab.PerformLayout();
            magicTab.ResumeLayout(false);
            magicTab.PerformLayout();
            potionTab.ResumeLayout(false);
            potionTab.PerformLayout();
            toolTab.ResumeLayout(false);
            toolTab.PerformLayout();
            containerTab.ResumeLayout(false);
            containerTab.PerformLayout();
            cpGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cpCtrl).EndInit();
            spGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spCtrl).EndInit();
            gpGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gpCtrl).EndInit();
            ppGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ppCtrl).EndInit();
            categoryDescGroup.ResumeLayout(false);
            categoryDescGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl invTabCtrl;
        private TabPage generalTab;
        private TabPage weaponTab;
        private TabPage armourTab;
        private TabPage magicTab;
        private TabPage potionTab;
        private TabPage toolTab;
        private TabPage containerTab;
        private GroupBox cpGroup;
        private NumericUpDown cpCtrl;
        private GroupBox spGroup;
        private NumericUpDown spCtrl;
        private GroupBox gpGroup;
        private NumericUpDown gpCtrl;
        private GroupBox ppGroup;
        private NumericUpDown ppCtrl;
        private TableLayoutPanel generalTable;
        private Button addBtn;
        private TextBox categoryDescTextBox;
        private GroupBox categoryDescGroup;
        private TableLayoutPanel weaponTable;
        private TableLayoutPanel armourTable;
        private TableLayoutPanel magicTable;
        private TableLayoutPanel potionTable;
        private TableLayoutPanel toolTable;
        private TableLayoutPanel containerTable;
        private Button showEquippedBtn;
        private Button showAttunedBtn;
    }
}