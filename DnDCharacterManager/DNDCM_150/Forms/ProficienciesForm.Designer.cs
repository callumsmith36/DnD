namespace CharacterManager
{
    partial class ProficienciesForm
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
            mainTabCtrl = new TabControl();
            saveTab = new TabPage();
            primaryClassLabel = new Label();
            saveInfoLabel = new Label();
            dexLabel = new Label();
            conLabel = new Label();
            intLabel = new Label();
            wisLabel = new Label();
            chaLabel = new Label();
            strLabel = new Label();
            chaCheckBox = new CheckBox();
            wisCheckBox = new CheckBox();
            intCheckBox = new CheckBox();
            conCheckBox = new CheckBox();
            dexCheckBox = new CheckBox();
            strCheckBox = new CheckBox();
            skillTab = new TabPage();
            survivalCtrl = new SkillProfCtrl();
            stealthCtrl = new SkillProfCtrl();
            sleightOfHandCtrl = new SkillProfCtrl();
            religionCtrl = new SkillProfCtrl();
            persuasionCtrl = new SkillProfCtrl();
            performanceCtrl = new SkillProfCtrl();
            perceptionCtrl = new SkillProfCtrl();
            natureCtrl = new SkillProfCtrl();
            medicineCtrl = new SkillProfCtrl();
            investigationCtrl = new SkillProfCtrl();
            intimidationCtrl = new SkillProfCtrl();
            insightCtrl = new SkillProfCtrl();
            historyCtrl = new SkillProfCtrl();
            deceptionCtrl = new SkillProfCtrl();
            athleticsCtrl = new SkillProfCtrl();
            arcanaCtrl = new SkillProfCtrl();
            animalHandlingCtrl = new SkillProfCtrl();
            acrobaticsCtrl = new SkillProfCtrl();
            skillInfoLabel = new Label();
            toolTab = new TabPage();
            toolCheckList = new CheckedListBox();
            weaponTab = new TabPage();
            weaponCheckList = new CheckedListBox();
            weaponTypeCheckList = new CheckedListBox();
            armourTab = new TabPage();
            armourCheckList = new CheckedListBox();
            languageTab = new TabPage();
            languageCheckList = new CheckedListBox();
            vehicleTab = new TabPage();
            vehicleCheckList = new CheckedListBox();
            mainTabCtrl.SuspendLayout();
            saveTab.SuspendLayout();
            skillTab.SuspendLayout();
            toolTab.SuspendLayout();
            weaponTab.SuspendLayout();
            armourTab.SuspendLayout();
            languageTab.SuspendLayout();
            vehicleTab.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabCtrl
            // 
            mainTabCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabCtrl.Controls.Add(saveTab);
            mainTabCtrl.Controls.Add(skillTab);
            mainTabCtrl.Controls.Add(toolTab);
            mainTabCtrl.Controls.Add(weaponTab);
            mainTabCtrl.Controls.Add(armourTab);
            mainTabCtrl.Controls.Add(languageTab);
            mainTabCtrl.Controls.Add(vehicleTab);
            mainTabCtrl.Location = new Point(12, 12);
            mainTabCtrl.Name = "mainTabCtrl";
            mainTabCtrl.SelectedIndex = 0;
            mainTabCtrl.Size = new Size(645, 491);
            mainTabCtrl.TabIndex = 0;
            // 
            // saveTab
            // 
            saveTab.Controls.Add(primaryClassLabel);
            saveTab.Controls.Add(saveInfoLabel);
            saveTab.Controls.Add(dexLabel);
            saveTab.Controls.Add(conLabel);
            saveTab.Controls.Add(intLabel);
            saveTab.Controls.Add(wisLabel);
            saveTab.Controls.Add(chaLabel);
            saveTab.Controls.Add(strLabel);
            saveTab.Controls.Add(chaCheckBox);
            saveTab.Controls.Add(wisCheckBox);
            saveTab.Controls.Add(intCheckBox);
            saveTab.Controls.Add(conCheckBox);
            saveTab.Controls.Add(dexCheckBox);
            saveTab.Controls.Add(strCheckBox);
            saveTab.Location = new Point(4, 31);
            saveTab.Name = "saveTab";
            saveTab.Padding = new Padding(3);
            saveTab.Size = new Size(637, 456);
            saveTab.TabIndex = 0;
            saveTab.Text = "Saving Throws";
            saveTab.UseVisualStyleBackColor = true;
            // 
            // primaryClassLabel
            // 
            primaryClassLabel.AutoSize = true;
            primaryClassLabel.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            primaryClassLabel.Location = new Point(110, 3);
            primaryClassLabel.Name = "primaryClassLabel";
            primaryClassLabel.Size = new Size(136, 22);
            primaryClassLabel.TabIndex = 13;
            primaryClassLabel.Text = "[primary class]";
            // 
            // saveInfoLabel
            // 
            saveInfoLabel.AutoSize = true;
            saveInfoLabel.Location = new Point(6, 3);
            saveInfoLabel.Name = "saveInfoLabel";
            saveInfoLabel.Size = new Size(119, 22);
            saveInfoLabel.TabIndex = 12;
            saveInfoLabel.Text = "Primary class:";
            // 
            // dexLabel
            // 
            dexLabel.AutoSize = true;
            dexLabel.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dexLabel.Location = new Point(46, 67);
            dexLabel.Name = "dexLabel";
            dexLabel.Size = new Size(56, 27);
            dexLabel.TabIndex = 11;
            dexLabel.Text = "DEX";
            // 
            // conLabel
            // 
            conLabel.AutoSize = true;
            conLabel.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conLabel.Location = new Point(46, 99);
            conLabel.Name = "conLabel";
            conLabel.Size = new Size(59, 27);
            conLabel.TabIndex = 10;
            conLabel.Text = "CON";
            // 
            // intLabel
            // 
            intLabel.AutoSize = true;
            intLabel.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            intLabel.Location = new Point(46, 131);
            intLabel.Name = "intLabel";
            intLabel.Size = new Size(49, 27);
            intLabel.TabIndex = 9;
            intLabel.Text = "INT";
            // 
            // wisLabel
            // 
            wisLabel.AutoSize = true;
            wisLabel.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wisLabel.Location = new Point(46, 163);
            wisLabel.Name = "wisLabel";
            wisLabel.Size = new Size(52, 27);
            wisLabel.TabIndex = 8;
            wisLabel.Text = "WIS";
            // 
            // chaLabel
            // 
            chaLabel.AutoSize = true;
            chaLabel.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chaLabel.Location = new Point(46, 195);
            chaLabel.Name = "chaLabel";
            chaLabel.Size = new Size(58, 27);
            chaLabel.TabIndex = 7;
            chaLabel.Text = "CHA";
            // 
            // strLabel
            // 
            strLabel.AutoSize = true;
            strLabel.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            strLabel.Location = new Point(46, 35);
            strLabel.Name = "strLabel";
            strLabel.Size = new Size(51, 27);
            strLabel.TabIndex = 6;
            strLabel.Text = "STR";
            // 
            // chaCheckBox
            // 
            chaCheckBox.AutoSize = true;
            chaCheckBox.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chaCheckBox.Location = new Point(22, 199);
            chaCheckBox.Name = "chaCheckBox";
            chaCheckBox.Size = new Size(22, 21);
            chaCheckBox.TabIndex = 5;
            chaCheckBox.UseVisualStyleBackColor = true;
            chaCheckBox.CheckedChanged += chaCheckBox_CheckedChanged;
            // 
            // wisCheckBox
            // 
            wisCheckBox.AutoSize = true;
            wisCheckBox.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wisCheckBox.Location = new Point(22, 167);
            wisCheckBox.Name = "wisCheckBox";
            wisCheckBox.Size = new Size(22, 21);
            wisCheckBox.TabIndex = 4;
            wisCheckBox.UseVisualStyleBackColor = true;
            wisCheckBox.CheckedChanged += wisCheckBox_CheckedChanged;
            // 
            // intCheckBox
            // 
            intCheckBox.AutoSize = true;
            intCheckBox.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            intCheckBox.Location = new Point(22, 135);
            intCheckBox.Name = "intCheckBox";
            intCheckBox.Size = new Size(22, 21);
            intCheckBox.TabIndex = 3;
            intCheckBox.UseVisualStyleBackColor = true;
            intCheckBox.CheckedChanged += intCheckBox_CheckedChanged;
            // 
            // conCheckBox
            // 
            conCheckBox.AutoSize = true;
            conCheckBox.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conCheckBox.Location = new Point(22, 103);
            conCheckBox.Name = "conCheckBox";
            conCheckBox.Size = new Size(22, 21);
            conCheckBox.TabIndex = 2;
            conCheckBox.UseVisualStyleBackColor = true;
            conCheckBox.CheckedChanged += conCheckBox_CheckedChanged;
            // 
            // dexCheckBox
            // 
            dexCheckBox.AutoSize = true;
            dexCheckBox.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dexCheckBox.Location = new Point(22, 71);
            dexCheckBox.Name = "dexCheckBox";
            dexCheckBox.Size = new Size(22, 21);
            dexCheckBox.TabIndex = 1;
            dexCheckBox.UseVisualStyleBackColor = true;
            dexCheckBox.CheckedChanged += dexCheckBox_CheckedChanged;
            // 
            // strCheckBox
            // 
            strCheckBox.AutoSize = true;
            strCheckBox.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            strCheckBox.Location = new Point(22, 39);
            strCheckBox.Name = "strCheckBox";
            strCheckBox.Size = new Size(22, 21);
            strCheckBox.TabIndex = 0;
            strCheckBox.UseVisualStyleBackColor = true;
            strCheckBox.CheckedChanged += strCheckBox_CheckedChanged;
            // 
            // skillTab
            // 
            skillTab.AutoScroll = true;
            skillTab.Controls.Add(survivalCtrl);
            skillTab.Controls.Add(stealthCtrl);
            skillTab.Controls.Add(sleightOfHandCtrl);
            skillTab.Controls.Add(religionCtrl);
            skillTab.Controls.Add(persuasionCtrl);
            skillTab.Controls.Add(performanceCtrl);
            skillTab.Controls.Add(perceptionCtrl);
            skillTab.Controls.Add(natureCtrl);
            skillTab.Controls.Add(medicineCtrl);
            skillTab.Controls.Add(investigationCtrl);
            skillTab.Controls.Add(intimidationCtrl);
            skillTab.Controls.Add(insightCtrl);
            skillTab.Controls.Add(historyCtrl);
            skillTab.Controls.Add(deceptionCtrl);
            skillTab.Controls.Add(athleticsCtrl);
            skillTab.Controls.Add(arcanaCtrl);
            skillTab.Controls.Add(animalHandlingCtrl);
            skillTab.Controls.Add(acrobaticsCtrl);
            skillTab.Controls.Add(skillInfoLabel);
            skillTab.Location = new Point(4, 31);
            skillTab.Name = "skillTab";
            skillTab.Padding = new Padding(3);
            skillTab.Size = new Size(637, 456);
            skillTab.TabIndex = 1;
            skillTab.Text = "Skills";
            skillTab.UseVisualStyleBackColor = true;
            // 
            // survivalCtrl
            // 
            survivalCtrl.BackColor = Color.Transparent;
            survivalCtrl.IsExpert = false;
            survivalCtrl.IsProficient = false;
            survivalCtrl.Location = new Point(277, 325);
            survivalCtrl.Margin = new Padding(4);
            survivalCtrl.MaximumSize = new Size(245, 31);
            survivalCtrl.MinimumSize = new Size(245, 31);
            survivalCtrl.Name = "survivalCtrl";
            survivalCtrl.Size = new Size(245, 31);
            survivalCtrl.Skill = DND.Types.Skill.Survival;
            survivalCtrl.TabIndex = 25;
            // 
            // stealthCtrl
            // 
            stealthCtrl.BackColor = Color.Transparent;
            stealthCtrl.IsExpert = false;
            stealthCtrl.IsProficient = false;
            stealthCtrl.Location = new Point(277, 288);
            stealthCtrl.Margin = new Padding(4);
            stealthCtrl.MaximumSize = new Size(245, 31);
            stealthCtrl.MinimumSize = new Size(245, 31);
            stealthCtrl.Name = "stealthCtrl";
            stealthCtrl.Size = new Size(245, 31);
            stealthCtrl.Skill = DND.Types.Skill.Stealth;
            stealthCtrl.TabIndex = 24;
            // 
            // sleightOfHandCtrl
            // 
            sleightOfHandCtrl.BackColor = Color.Transparent;
            sleightOfHandCtrl.IsExpert = false;
            sleightOfHandCtrl.IsProficient = false;
            sleightOfHandCtrl.Location = new Point(277, 251);
            sleightOfHandCtrl.Margin = new Padding(4);
            sleightOfHandCtrl.MaximumSize = new Size(245, 31);
            sleightOfHandCtrl.MinimumSize = new Size(245, 31);
            sleightOfHandCtrl.Name = "sleightOfHandCtrl";
            sleightOfHandCtrl.Size = new Size(245, 31);
            sleightOfHandCtrl.Skill = DND.Types.Skill.SleightOfHand;
            sleightOfHandCtrl.TabIndex = 23;
            // 
            // religionCtrl
            // 
            religionCtrl.BackColor = Color.Transparent;
            religionCtrl.IsExpert = false;
            religionCtrl.IsProficient = false;
            religionCtrl.Location = new Point(277, 214);
            religionCtrl.Margin = new Padding(4);
            religionCtrl.MaximumSize = new Size(245, 31);
            religionCtrl.MinimumSize = new Size(245, 31);
            religionCtrl.Name = "religionCtrl";
            religionCtrl.Size = new Size(245, 31);
            religionCtrl.Skill = DND.Types.Skill.Religion;
            religionCtrl.TabIndex = 22;
            // 
            // persuasionCtrl
            // 
            persuasionCtrl.BackColor = Color.Transparent;
            persuasionCtrl.IsExpert = false;
            persuasionCtrl.IsProficient = false;
            persuasionCtrl.Location = new Point(277, 177);
            persuasionCtrl.Margin = new Padding(4);
            persuasionCtrl.MaximumSize = new Size(245, 31);
            persuasionCtrl.MinimumSize = new Size(245, 31);
            persuasionCtrl.Name = "persuasionCtrl";
            persuasionCtrl.Size = new Size(245, 31);
            persuasionCtrl.Skill = DND.Types.Skill.Persuasion;
            persuasionCtrl.TabIndex = 21;
            // 
            // performanceCtrl
            // 
            performanceCtrl.BackColor = Color.Transparent;
            performanceCtrl.IsExpert = false;
            performanceCtrl.IsProficient = false;
            performanceCtrl.Location = new Point(277, 140);
            performanceCtrl.Margin = new Padding(4);
            performanceCtrl.MaximumSize = new Size(245, 31);
            performanceCtrl.MinimumSize = new Size(245, 31);
            performanceCtrl.Name = "performanceCtrl";
            performanceCtrl.Size = new Size(245, 31);
            performanceCtrl.Skill = DND.Types.Skill.Performance;
            performanceCtrl.TabIndex = 20;
            // 
            // perceptionCtrl
            // 
            perceptionCtrl.BackColor = Color.Transparent;
            perceptionCtrl.IsExpert = false;
            perceptionCtrl.IsProficient = false;
            perceptionCtrl.Location = new Point(277, 103);
            perceptionCtrl.Margin = new Padding(4);
            perceptionCtrl.MaximumSize = new Size(245, 31);
            perceptionCtrl.MinimumSize = new Size(245, 31);
            perceptionCtrl.Name = "perceptionCtrl";
            perceptionCtrl.Size = new Size(245, 31);
            perceptionCtrl.Skill = DND.Types.Skill.Perception;
            perceptionCtrl.TabIndex = 19;
            // 
            // natureCtrl
            // 
            natureCtrl.BackColor = Color.Transparent;
            natureCtrl.IsExpert = false;
            natureCtrl.IsProficient = false;
            natureCtrl.Location = new Point(277, 66);
            natureCtrl.Margin = new Padding(4);
            natureCtrl.MaximumSize = new Size(245, 31);
            natureCtrl.MinimumSize = new Size(245, 31);
            natureCtrl.Name = "natureCtrl";
            natureCtrl.Size = new Size(245, 31);
            natureCtrl.Skill = DND.Types.Skill.Nature;
            natureCtrl.TabIndex = 18;
            // 
            // medicineCtrl
            // 
            medicineCtrl.BackColor = Color.Transparent;
            medicineCtrl.IsExpert = false;
            medicineCtrl.IsProficient = false;
            medicineCtrl.Location = new Point(277, 29);
            medicineCtrl.Margin = new Padding(4);
            medicineCtrl.MaximumSize = new Size(245, 31);
            medicineCtrl.MinimumSize = new Size(245, 31);
            medicineCtrl.Name = "medicineCtrl";
            medicineCtrl.Size = new Size(245, 31);
            medicineCtrl.Skill = DND.Types.Skill.Medicine;
            medicineCtrl.TabIndex = 17;
            // 
            // investigationCtrl
            // 
            investigationCtrl.BackColor = Color.Transparent;
            investigationCtrl.IsExpert = false;
            investigationCtrl.IsProficient = false;
            investigationCtrl.Location = new Point(11, 325);
            investigationCtrl.Margin = new Padding(4);
            investigationCtrl.MaximumSize = new Size(245, 31);
            investigationCtrl.MinimumSize = new Size(245, 31);
            investigationCtrl.Name = "investigationCtrl";
            investigationCtrl.Size = new Size(245, 31);
            investigationCtrl.Skill = DND.Types.Skill.Investigation;
            investigationCtrl.TabIndex = 16;
            // 
            // intimidationCtrl
            // 
            intimidationCtrl.BackColor = Color.Transparent;
            intimidationCtrl.IsExpert = false;
            intimidationCtrl.IsProficient = false;
            intimidationCtrl.Location = new Point(11, 288);
            intimidationCtrl.Margin = new Padding(4);
            intimidationCtrl.MaximumSize = new Size(245, 31);
            intimidationCtrl.MinimumSize = new Size(245, 31);
            intimidationCtrl.Name = "intimidationCtrl";
            intimidationCtrl.Size = new Size(245, 31);
            intimidationCtrl.Skill = DND.Types.Skill.Intimidation;
            intimidationCtrl.TabIndex = 15;
            // 
            // insightCtrl
            // 
            insightCtrl.BackColor = Color.Transparent;
            insightCtrl.IsExpert = false;
            insightCtrl.IsProficient = false;
            insightCtrl.Location = new Point(11, 251);
            insightCtrl.Margin = new Padding(4);
            insightCtrl.MaximumSize = new Size(245, 31);
            insightCtrl.MinimumSize = new Size(245, 31);
            insightCtrl.Name = "insightCtrl";
            insightCtrl.Size = new Size(245, 31);
            insightCtrl.Skill = DND.Types.Skill.Insight;
            insightCtrl.TabIndex = 14;
            // 
            // historyCtrl
            // 
            historyCtrl.BackColor = Color.Transparent;
            historyCtrl.IsExpert = false;
            historyCtrl.IsProficient = false;
            historyCtrl.Location = new Point(11, 214);
            historyCtrl.Margin = new Padding(4);
            historyCtrl.MaximumSize = new Size(245, 31);
            historyCtrl.MinimumSize = new Size(245, 31);
            historyCtrl.Name = "historyCtrl";
            historyCtrl.Size = new Size(245, 31);
            historyCtrl.Skill = DND.Types.Skill.History;
            historyCtrl.TabIndex = 13;
            // 
            // deceptionCtrl
            // 
            deceptionCtrl.BackColor = Color.Transparent;
            deceptionCtrl.IsExpert = false;
            deceptionCtrl.IsProficient = false;
            deceptionCtrl.Location = new Point(11, 177);
            deceptionCtrl.Margin = new Padding(4);
            deceptionCtrl.MaximumSize = new Size(245, 31);
            deceptionCtrl.MinimumSize = new Size(245, 31);
            deceptionCtrl.Name = "deceptionCtrl";
            deceptionCtrl.Size = new Size(245, 31);
            deceptionCtrl.Skill = DND.Types.Skill.Deception;
            deceptionCtrl.TabIndex = 12;
            // 
            // athleticsCtrl
            // 
            athleticsCtrl.BackColor = Color.Transparent;
            athleticsCtrl.IsExpert = false;
            athleticsCtrl.IsProficient = false;
            athleticsCtrl.Location = new Point(11, 140);
            athleticsCtrl.Margin = new Padding(4);
            athleticsCtrl.MaximumSize = new Size(245, 31);
            athleticsCtrl.MinimumSize = new Size(245, 31);
            athleticsCtrl.Name = "athleticsCtrl";
            athleticsCtrl.Size = new Size(245, 31);
            athleticsCtrl.Skill = DND.Types.Skill.Athletics;
            athleticsCtrl.TabIndex = 11;
            // 
            // arcanaCtrl
            // 
            arcanaCtrl.BackColor = Color.Transparent;
            arcanaCtrl.IsExpert = false;
            arcanaCtrl.IsProficient = false;
            arcanaCtrl.Location = new Point(11, 103);
            arcanaCtrl.Margin = new Padding(4);
            arcanaCtrl.MaximumSize = new Size(245, 31);
            arcanaCtrl.MinimumSize = new Size(245, 31);
            arcanaCtrl.Name = "arcanaCtrl";
            arcanaCtrl.Size = new Size(245, 31);
            arcanaCtrl.Skill = DND.Types.Skill.Arcana;
            arcanaCtrl.TabIndex = 10;
            // 
            // animalHandlingCtrl
            // 
            animalHandlingCtrl.BackColor = Color.Transparent;
            animalHandlingCtrl.IsExpert = false;
            animalHandlingCtrl.IsProficient = false;
            animalHandlingCtrl.Location = new Point(11, 66);
            animalHandlingCtrl.Margin = new Padding(4);
            animalHandlingCtrl.MaximumSize = new Size(245, 31);
            animalHandlingCtrl.MinimumSize = new Size(245, 31);
            animalHandlingCtrl.Name = "animalHandlingCtrl";
            animalHandlingCtrl.Size = new Size(245, 31);
            animalHandlingCtrl.Skill = DND.Types.Skill.AnimalHandling;
            animalHandlingCtrl.TabIndex = 9;
            // 
            // acrobaticsCtrl
            // 
            acrobaticsCtrl.BackColor = Color.Transparent;
            acrobaticsCtrl.IsExpert = false;
            acrobaticsCtrl.IsProficient = false;
            acrobaticsCtrl.Location = new Point(11, 29);
            acrobaticsCtrl.Margin = new Padding(4);
            acrobaticsCtrl.MaximumSize = new Size(245, 31);
            acrobaticsCtrl.MinimumSize = new Size(245, 31);
            acrobaticsCtrl.Name = "acrobaticsCtrl";
            acrobaticsCtrl.Size = new Size(245, 31);
            acrobaticsCtrl.Skill = DND.Types.Skill.Acrobatics;
            acrobaticsCtrl.TabIndex = 8;
            // 
            // skillInfoLabel
            // 
            skillInfoLabel.AutoSize = true;
            skillInfoLabel.Location = new Point(6, 3);
            skillInfoLabel.Name = "skillInfoLabel";
            skillInfoLabel.Size = new Size(380, 22);
            skillInfoLabel.TabIndex = 7;
            skillInfoLabel.Text = "First box is proficiency, second box is expertise.";
            // 
            // toolTab
            // 
            toolTab.AutoScroll = true;
            toolTab.Controls.Add(toolCheckList);
            toolTab.Location = new Point(4, 31);
            toolTab.Name = "toolTab";
            toolTab.Padding = new Padding(3);
            toolTab.Size = new Size(637, 456);
            toolTab.TabIndex = 2;
            toolTab.Text = "Tools";
            toolTab.UseVisualStyleBackColor = true;
            // 
            // toolCheckList
            // 
            toolCheckList.BackColor = SystemColors.Window;
            toolCheckList.BorderStyle = BorderStyle.None;
            toolCheckList.CheckOnClick = true;
            toolCheckList.ColumnWidth = 250;
            toolCheckList.Font = new Font("Constantia", 10F);
            toolCheckList.FormattingEnabled = true;
            toolCheckList.Items.AddRange(new object[] { "Alchemist's Supplies", "Artisan's Tools", "Brewer's Supplies", "Calligrapher's Supplies", "Carpenter's Tools", "Cartographer's Tools", "Cobbler's Tools", "Cook's utensils", "Disguise Kit", "Forgery Kit", "Glassblower's Tools", "Herbalism Kit", "Jeweler's Tools", "Leatherworker's Tools", "Mason's Tools", "Navigator's Tools", "Painter's Supplies", "Poisoner's Kit", "Potter's Tools", "Smith's Tools", "Thieves' Tools", "Tinker's Tools", "Weaver's Tools", "Woodcarver's Tools" });
            toolCheckList.Location = new Point(6, 9);
            toolCheckList.MultiColumn = true;
            toolCheckList.Name = "toolCheckList";
            toolCheckList.Size = new Size(514, 348);
            toolCheckList.TabIndex = 17;
            toolCheckList.ItemCheck += toolCheckList_ItemCheck;
            // 
            // weaponTab
            // 
            weaponTab.AutoScroll = true;
            weaponTab.Controls.Add(weaponCheckList);
            weaponTab.Controls.Add(weaponTypeCheckList);
            weaponTab.Location = new Point(4, 31);
            weaponTab.Name = "weaponTab";
            weaponTab.Padding = new Padding(3);
            weaponTab.Size = new Size(637, 456);
            weaponTab.TabIndex = 3;
            weaponTab.Text = "Weapons";
            weaponTab.UseVisualStyleBackColor = true;
            // 
            // weaponCheckList
            // 
            weaponCheckList.BackColor = SystemColors.Window;
            weaponCheckList.BorderStyle = BorderStyle.None;
            weaponCheckList.CheckOnClick = true;
            weaponCheckList.ColumnWidth = 200;
            weaponCheckList.Font = new Font("Constantia", 10F);
            weaponCheckList.FormattingEnabled = true;
            weaponCheckList.Items.AddRange(new object[] { "Battleaxes", "Blowguns", "Clubs", "Crossbows, heavy", "Crossbows, light", "Daggers", "Darts", "Flails", "Glaives", "Greataxes", "Greatclubs", "Greatswords", "Halberds", "Hand crossbows", "Handaxes", "Javelins", "Lances", "Light hammers", "Longbows", "Longswords", "Maces", "Mauls", "Nets", "Morningstars", "Pikes", "Quarterstaffs", "Rapiers", "Scimitars", "Shortbows", "Shortswords", "Sickles", "Slings", "Spears", "Tridents", "War picks", "Warhammers", "Whips" });
            weaponCheckList.Location = new Point(6, 40);
            weaponCheckList.MultiColumn = true;
            weaponCheckList.Name = "weaponCheckList";
            weaponCheckList.Size = new Size(608, 377);
            weaponCheckList.TabIndex = 12;
            weaponCheckList.ItemCheck += weaponCheckList_ItemCheck;
            // 
            // weaponTypeCheckList
            // 
            weaponTypeCheckList.BackColor = SystemColors.Window;
            weaponTypeCheckList.BorderStyle = BorderStyle.None;
            weaponTypeCheckList.CheckOnClick = true;
            weaponTypeCheckList.ColumnWidth = 200;
            weaponTypeCheckList.Font = new Font("Constantia", 10F);
            weaponTypeCheckList.FormattingEnabled = true;
            weaponTypeCheckList.Items.AddRange(new object[] { "Simple Weapons", "Martial Weapons" });
            weaponTypeCheckList.Location = new Point(6, 6);
            weaponTypeCheckList.MultiColumn = true;
            weaponTypeCheckList.Name = "weaponTypeCheckList";
            weaponTypeCheckList.Size = new Size(608, 29);
            weaponTypeCheckList.TabIndex = 11;
            weaponTypeCheckList.ItemCheck += weaponTypeCheckList_ItemCheck;
            // 
            // armourTab
            // 
            armourTab.Controls.Add(armourCheckList);
            armourTab.Location = new Point(4, 31);
            armourTab.Name = "armourTab";
            armourTab.Padding = new Padding(3);
            armourTab.Size = new Size(637, 456);
            armourTab.TabIndex = 4;
            armourTab.Text = "Armour";
            armourTab.UseVisualStyleBackColor = true;
            // 
            // armourCheckList
            // 
            armourCheckList.BackColor = SystemColors.Window;
            armourCheckList.BorderStyle = BorderStyle.None;
            armourCheckList.CheckOnClick = true;
            armourCheckList.ColumnWidth = 140;
            armourCheckList.Font = new Font("Constantia", 10F);
            armourCheckList.FormattingEnabled = true;
            armourCheckList.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "Shields" });
            armourCheckList.Location = new Point(6, 6);
            armourCheckList.MultiColumn = true;
            armourCheckList.Name = "armourCheckList";
            armourCheckList.Size = new Size(131, 145);
            armourCheckList.TabIndex = 8;
            armourCheckList.ItemCheck += armourCheckList_ItemCheck;
            // 
            // languageTab
            // 
            languageTab.Controls.Add(languageCheckList);
            languageTab.Location = new Point(4, 31);
            languageTab.Name = "languageTab";
            languageTab.Padding = new Padding(3);
            languageTab.Size = new Size(637, 456);
            languageTab.TabIndex = 5;
            languageTab.Text = "Languages";
            languageTab.UseVisualStyleBackColor = true;
            // 
            // languageCheckList
            // 
            languageCheckList.BackColor = SystemColors.Window;
            languageCheckList.BorderStyle = BorderStyle.None;
            languageCheckList.CheckOnClick = true;
            languageCheckList.ColumnWidth = 180;
            languageCheckList.Font = new Font("Constantia", 10F);
            languageCheckList.FormattingEnabled = true;
            languageCheckList.Items.AddRange(new object[] { "Abyssal", "Celestial", "Common", "Deep Speech", "Draconic", "Dwarvish", "Elvish", "Giant", "Gnomish", "Goblin", "Halfling", "Infernal", "Orc", "Primordial", "Sylvan", "Undercommon" });
            languageCheckList.Location = new Point(6, 6);
            languageCheckList.MultiColumn = true;
            languageCheckList.Name = "languageCheckList";
            languageCheckList.Size = new Size(407, 232);
            languageCheckList.TabIndex = 9;
            languageCheckList.ItemCheck += languageCheckList_ItemCheck;
            // 
            // vehicleTab
            // 
            vehicleTab.Controls.Add(vehicleCheckList);
            vehicleTab.Location = new Point(4, 31);
            vehicleTab.Name = "vehicleTab";
            vehicleTab.Padding = new Padding(3);
            vehicleTab.Size = new Size(637, 456);
            vehicleTab.TabIndex = 6;
            vehicleTab.Text = "Vehicles";
            vehicleTab.UseVisualStyleBackColor = true;
            // 
            // vehicleCheckList
            // 
            vehicleCheckList.BackColor = SystemColors.Window;
            vehicleCheckList.BorderStyle = BorderStyle.None;
            vehicleCheckList.CheckOnClick = true;
            vehicleCheckList.ColumnWidth = 220;
            vehicleCheckList.Font = new Font("Constantia", 10F);
            vehicleCheckList.FormattingEnabled = true;
            vehicleCheckList.Items.AddRange(new object[] { "Land Vehicles", "Waterborne Vehicles" });
            vehicleCheckList.Location = new Point(6, 6);
            vehicleCheckList.MultiColumn = true;
            vehicleCheckList.Name = "vehicleCheckList";
            vehicleCheckList.Size = new Size(490, 29);
            vehicleCheckList.TabIndex = 12;
            vehicleCheckList.ItemCheck += vehicleCheckList_ItemCheck;
            // 
            // ProficienciesForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(669, 515);
            Controls.Add(mainTabCtrl);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(575, 475);
            Name = "ProficienciesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Proficiencies";
            mainTabCtrl.ResumeLayout(false);
            saveTab.ResumeLayout(false);
            saveTab.PerformLayout();
            skillTab.ResumeLayout(false);
            skillTab.PerformLayout();
            toolTab.ResumeLayout(false);
            weaponTab.ResumeLayout(false);
            armourTab.ResumeLayout(false);
            languageTab.ResumeLayout(false);
            vehicleTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabCtrl;
        private TabPage saveTab;
        private TabPage skillTab;
        private CheckBox chaCheckBox;
        private CheckBox wisCheckBox;
        private CheckBox intCheckBox;
        private CheckBox conCheckBox;
        private CheckBox dexCheckBox;
        private CheckBox strCheckBox;
        private Label skillInfoLabel;
        private SkillProfCtrl animalHandlingCtrl;
        private SkillProfCtrl acrobaticsCtrl;
        private SkillProfCtrl athleticsCtrl;
        private SkillProfCtrl arcanaCtrl;
        private SkillProfCtrl investigationCtrl;
        private SkillProfCtrl intimidationCtrl;
        private SkillProfCtrl insightCtrl;
        private SkillProfCtrl historyCtrl;
        private SkillProfCtrl deceptionCtrl;
        private SkillProfCtrl survivalCtrl;
        private SkillProfCtrl stealthCtrl;
        private SkillProfCtrl sleightOfHandCtrl;
        private SkillProfCtrl religionCtrl;
        private SkillProfCtrl persuasionCtrl;
        private SkillProfCtrl performanceCtrl;
        private SkillProfCtrl perceptionCtrl;
        private SkillProfCtrl natureCtrl;
        private SkillProfCtrl medicineCtrl;
        private Label strLabel;
        private Label primaryClassLabel;
        private Label saveInfoLabel;
        private Label dexLabel;
        private Label conLabel;
        private Label intLabel;
        private Label wisLabel;
        private Label chaLabel;
        private TabPage toolTab;
        private CheckedListBox toolCheckList;
        private TabPage weaponTab;
        private TabPage armourTab;
        private TabPage languageTab;
        private CheckedListBox weaponTypeCheckList;
        private CheckedListBox weaponCheckList;
        private CheckedListBox armourCheckList;
        private CheckedListBox languageCheckList;
        private TabPage vehicleTab;
        private CheckedListBox vehicleCheckList;
    }
}