using DND;
using DND.API;
using DND.Types;

namespace CharacterManager
{
    public enum BrowserType
    {
        Search, Select, Delete
    }


    public partial class MainForm : Form
    {
        private SavingThrowCtrl[] _saveCtrlList;
        private SkillCtrl[] _skillCtrlList;
        private CheckBox[] _deathSaveSuccessChecks;
        private CheckBox[] _deathSaveFailChecks;
        private Image? _d20Icon;

        public Action? OnCharacterSaved;


        //
        //  Constructor
        //
        public MainForm()
        {
            InitializeComponent();

            profTabCtrl.DrawItem += new DrawItemEventHandler(profTabCtrl_DrawItem);

            _saveCtrlList = new SavingThrowCtrl[]
            {
                strSaveCtrl, dexSaveCtrl, conSaveCtrl, intSaveCtrl, wisSaveCtrl, chaSaveCtrl
            };

            _skillCtrlList = new SkillCtrl[]
            {
                acrobaticsCtrl, animalHandlingCtrl, arcanaCtrl,
                athleticsCtrl, deceptionCtrl, historyCtrl,
                insightCtrl, intimidationCtrl, investigationCtrl,
                medicineCtrl, natureCtrl, perceptionCtrl,
                performanceCtrl, persuasionCtrl, religionCtrl,
                sleightOfHandCtrl, stealthCtrl, survivalCtrl
            };

            _deathSaveSuccessChecks = [deathSaveSuccessCheck1, deathSaveSuccessCheck2, deathSaveSuccessCheck3];
            _deathSaveFailChecks = [deathSaveFailCheck1, deathSaveFailCheck2, deathSaveFailCheck3];

            _d20Icon = inspirationPictureBox.BackgroundImage;

            try
            {
                var charFiles = Directory.GetFiles(APIReadWrite.RootPath + "\\characters");
                foreach (var file in charFiles)
                {
                    if (Path.GetExtension(file) == ".json")
                    {
                        var item = new CharacterMenuItem(Path.GetFileNameWithoutExtension(file));
                        item.Click += CharacterMenuItem_Click;
                        charMenuItem.DropDownItems.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error in retrieving character files.\n\nException:\n{0}", ex.Message), "D&D Character Manager");
            }

            spellClassComboBox.Items.Add("N/A");
            foreach (var className in APIReadWrite.GetClassNameList())
            {
                var c = APIReadWrite.GetClass(className);
                if (c != null && c.SpellList.Count > 0)
                {
                    spellClassComboBox.Items.Add(className);
                }
            }

            if (Session.AppSettings.SwapAbility)
                SwapAbilityScoreAndMod();

            int width = Session.AppSettings.Width < MinimumSize.Width ? MinimumSize.Width : Session.AppSettings.Width;
            int height = Session.AppSettings.Height < MinimumSize.Height ? MinimumSize.Height : Session.AppSettings.Height;
            Size = new Size(width, height);

            LoadPlayerCharacter();

            Session.OnCharacterChanged += LoadPlayerCharacter;
            AbilityCtrl.OnAnyScoreChanged += AbilityCtrl_OnAnyScoreChanged;
            ProficienciesForm.OnWeaponChanged += UpdateWeaponProficiencyListBox;
            ProficienciesForm.OnArmourChanged += UpdateArmourProficiencyListBox;
            ProficienciesForm.OnLanguageChanged += UpdateLanguageListBox;
            ProficienciesForm.OnToolChanged += UpdateToolProficiencyListBox;
            ProficienciesForm.OnVehicleChanged += UpdateVehicleProficiencyListBox;
        }


        //
        //  LoadPlayerCharacter
        //
        private void LoadPlayerCharacter()
        {
            nameTextBox.Text = Session.Player.Name;
            raceTextBox.Text = Session.Player.Race;
            backgroundTextBox.Text = Session.Player.Background;
            subclassTextBox.Text = Session.Player.Subclass;
            alignmentComboBox.Text = Session.Player.Alignment;

            UpdateClassString();
            UpdateHitPoints();

            acTextBox.Text = Session.Player.ArmourClass.ToString();
            speedTextBox.Text = Session.Player.Speed.ToString();

            UpdateModifierText(initTextBox, Session.Player.Initiative);
            UpdateModifierText(profBonusTextBox, Session.Player.ProficiencyBonus);

            if (string.IsNullOrWhiteSpace(Session.Player.SpellcastingClass))
                spellClassComboBox.SelectedIndex = 0;
            else
                spellClassComboBox.Text = Session.Player.SpellcastingClass;

            if (Session.Player.SpellcastingAbility == Ability.None)
                spellAbilityComboBox.SelectedIndex = 0;
            else
                spellAbilityComboBox.Text = TypeMaps.AbilityNames[Session.Player.SpellcastingAbility];

            UpdateModifierText(spellModTextBox, Session.Player.GetSpellcastingModifier());
            spellSaveTextBox.Text = Session.Player.GetSpellSaveDC().ToString();

            strCtrl.SetScore(Session.Player.Strength);
            dexCtrl.SetScore(Session.Player.Dexterity);
            conCtrl.SetScore(Session.Player.Constitution);
            intCtrl.SetScore(Session.Player.Intelligence);
            wisCtrl.SetScore(Session.Player.Wisdom);
            chaCtrl.SetScore(Session.Player.Charisma);

            UpdateSkills();
            UpdateSavingThrows();
            UpdatePassivePerception();
            UpdateHitDice();
            UpdateWeaponProficiencyListBox();
            UpdateArmourProficiencyListBox();
            UpdateLanguageListBox();
            UpdateToolProficiencyListBox();
            UpdateVehicleProficiencyListBox();

            for (int i = 0; i < 3; i++)
            {
                _deathSaveSuccessChecks[i].CheckedChanged -= deathSaveSuccessCheck_CheckedChanged;
                _deathSaveSuccessChecks[i].Checked = Session.Player.DeathSaveSuccesses[i];
                _deathSaveSuccessChecks[i].CheckedChanged += deathSaveSuccessCheck_CheckedChanged;

                _deathSaveFailChecks[i].CheckedChanged -= deathSaveFailCheck_CheckedChanged;
                _deathSaveFailChecks[i].Checked = Session.Player.DeathSaveFailures[i];
                _deathSaveFailChecks[i].CheckedChanged += deathSaveFailCheck_CheckedChanged;
            }

            if (Session.Player.IsConcentrating)
            {
                concentrationTextBox.Text = Session.Player.ConcentratingOn;
                ResizeTextToFit(concentrationTextBox);
            }

            LoadSpells();
            LoadFeats();
            LoadAttacks();

            inspirationPictureBox.BackgroundImage = Session.Player.HasInspiration ? _d20Icon : null;

            editClassBtn.Text = Session.Player.GetClassList().Length == 0 ? "Add..." : "Modify...";

            if (Session.Player.ImageFile.Length > 0 && File.Exists(Session.Player.ImageFile))
            {
                Image img = Image.FromFile(Session.Player.ImageFile);
                charPictureBox.Image = img;
            }
            else
            {
                charPictureBox.Image = null;
            }

            ageNumCtrl.Value = Session.Player.Age;
            heightTextBox.Text = Session.Player.Height;
            weightTextBox.Text = Session.Player.Weight;

            Utility.StringArrayToTextBox(Session.Player.Backstory, backstoryTextBox);
            Utility.StringArrayToTextBox(Session.Player.Allies, alliesTextBox);

            Session.Player.OnSpellCast += Player_OnSpellCast;
            Session.Player.OnPreparedSpellsChanged += Player_OnPreparedSpellsChanged;
            Session.Player.OnLevelChanged += Player_OnLevelChanged;
            Session.Player.OnClassChanged += Player_OnClassChanged;
            Session.Player.OnPrimaryClassChanged += Player_OnPrimaryClassChanged;
            Session.Player.OnSkillProficienciesChanged += Player_OnSkillProficienciesChanged;
            Session.Player.OnFeatsChanged += Player_OnFeatsChanged;
        }

        //
        //  LoadSpells
        //
        private void LoadSpells()
        {
            TableLayoutPanel? table = null;
            SpellSlotNumCtrl? slotNumCtrl = null;

            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        table = cantripTable;
                        break;
                    case 1:
                        table = firstLevelTable;
                        slotNumCtrl = firstLvlSlotCtrl;
                        break;
                    case 2:
                        table = secondLevelTable;
                        slotNumCtrl = secondLvlSlotCtrl;
                        break;
                    case 3:
                        table = thirdLevelTable;
                        slotNumCtrl = thirdLvlSlotCtrl;
                        break;
                    case 4:
                        table = fourthLevelTable;
                        slotNumCtrl = fourthLvlSlotCtrl;
                        break;
                    case 5:
                        table = fifthLevelTable;
                        slotNumCtrl = fifthLvlSlotCtrl;
                        break;
                    case 6:
                        table = sixthLevelTable;
                        slotNumCtrl = sixthLvlSlotCtrl;
                        break;
                    case 7:
                        table = seventhLevelTable;
                        slotNumCtrl = seventhLvlSlotCtrl;
                        break;
                    case 8:
                        table = eigthLevelTable;
                        slotNumCtrl = eigthLvlSlotCtrl;
                        break;
                    case 9:
                        table = ninthLevelTable;
                        slotNumCtrl = ninthLvlSlotCtrl;
                        break;
                    default:
                        break;
                }

                if (table != null)
                {
                    table.Controls.Clear();
                    foreach (var spell in Session.Player.GetPreparedSpells(i))
                    {
                        if (spell != null)
                            table.Controls.Add(new SpellCtrl(spell));
                    }
                }

                if (i > 0)
                {
                    if (slotNumCtrl != null)
                        slotNumCtrl.UpdateValues();
                }
            }
        }

        //
        //  LoadFeats
        //
        private void LoadFeats()
        {
            classFeatTable.Visible = false;
            raceFeatTable.Visible = false;
            otherFeatTable.Visible = false;

            classFeatTable.Controls.Clear();
            raceFeatTable.Controls.Clear();
            otherFeatTable.Controls.Clear();

            foreach (var feat in Session.Player.GetFeatList(true))
            {
                FeatCtrl ctrl = new FeatCtrl(feat);
                ctrl.OnRemoved += FeatCtrl_OnRemoved;
                ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                switch (feat.Source)
                {
                    case Feat.FeatSource.Class: classFeatTable.Controls.Add(ctrl); break;
                    case Feat.FeatSource.Race: raceFeatTable.Controls.Add(ctrl); break;
                    case Feat.FeatSource.Other: otherFeatTable.Controls.Add(ctrl); break;
                    default:
                        break;
                }
            }

            classFeatTable.Visible = true;
            raceFeatTable.Visible = true;
            otherFeatTable.Visible = true;
        }

        //
        //  LoadAttacks
        //
        private void LoadAttacks()
        {
            attackTable.Controls.Clear();

            foreach (var attack in Session.Player.GetAttackList())
            {
                AttackCtrl ctrl = new AttackCtrl(attack);
                ctrl.OnRemoved += AttackCtrl_OnRemoved;
                ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                attackTable.Controls.Add(ctrl);
            }
        }

        //
        //  UpdateFeats
        //
        private void UpdateFeats(Feat.FeatSource source)
        {
            TableLayoutPanel? table = null;
            switch (source)
            {
                case Feat.FeatSource.Class: table = classFeatTable; break;
                case Feat.FeatSource.Race:  table = raceFeatTable;  break;
                case Feat.FeatSource.Other: table = otherFeatTable; break;
                default:
                    break;
            }

            if (table == null)
                return;

            table.Visible = false;
            table.Controls.Clear();

            foreach (var feat in Session.Player.GetFeatList(true))
            {
                if (feat.Source == source)
                {
                    FeatCtrl ctrl = new FeatCtrl(feat);
                    ctrl.OnRemoved += FeatCtrl_OnRemoved;
                    ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    table.Controls.Add(ctrl);
                }
            }

            table.Visible = true;
        }

        //
        //  UpdateAttacks
        //
        private void UpdateAttacks()
        {
            foreach (var ctrl in attackTable.Controls)
            {
                var atkCtrl = ctrl as AttackCtrl;
                if (atkCtrl != null)
                    atkCtrl.UpdateInfo();
            }
        }

        //
        //  UpdateHitDice
        //
        private void UpdateHitDice()
        {
            hitDiceComboBox.Items.Clear();
            foreach (var c in Session.Player.GetClassList())
                hitDiceComboBox.Items.Add(c.Name);

            if (hitDiceComboBox.Items.Count > 0)
            {
                if (hitDiceComboBox.SelectedIndex < 0 ||
                    hitDiceComboBox.SelectedIndex >= hitDiceComboBox.Items.Count)
                {
                    hitDiceComboBox.SelectedIndex = 0;
                }
                else
                {
                    hitDiceNumCtrl.Value = Session.Player.GetHitDiceRemaining(hitDiceComboBox.Text);
                }
            }
            else
            {
                hitDiceLabel.Text = "d8";
                hitDiceNumCtrl.Value = 0;
                hitDiceNumCtrl.Maximum = 0;
                hitDiceMaxTextBox.Text = "0";
            }
        }

        //
        //  UpdateClassString
        //
        private void UpdateClassString()
        {
            string classStr = string.Empty;
            var classes = Session.Player.GetClassList();
            for (int i = 0; i < classes.Length; i++)
            {
                classStr += string.Format("{0} - {1}", classes[i].Name, Session.Player.GetClassLevel(classes[i].Name));
                if (i < classes.Length - 1)
                    classStr += "  /  ";
            }

            var textBox = classLevelTextBox;
            textBox.Font = new Font(textBox.Font.Name, 12.0f, FontStyle.Regular);
            textBox.Text = classStr;
            ResizeTextToFit(textBox);
        }

        //
        //  UpdateHitPoints
        //
        private void UpdateHitPoints()
        {
            currentHitPointsCtrl.Maximum = int.MaxValue;
            currentHitPointsCtrl.Value = Session.Player.CurrentHP;
            currentHitPointsCtrl.Maximum = Session.Player.MaxHP;
            maxHitPointsCtrl.Value = Session.Player.MaxHP;
            tempHitPointsCtrl.Value = Session.Player.TempHP;
        }

        //
        //  UpdatePassivePerception
        //
        private void UpdatePassivePerception()
        {
            passivePerceptionLabel.Text = (10 + Session.Player.GetSkillModifier(Skill.Perception)).ToString();
        }

        //
        //  UpdateSkillsAndSavingThrows
        //
        private void UpdateSkills()
        {
            foreach (var ctrl in _skillCtrlList)
                ctrl.UpdateModifier();
        }

        //
        //  UpdateSkillsAndSavingThrows
        //
        private void UpdateSavingThrows()
        {
            foreach (var ctrl in _saveCtrlList)
                ctrl.UpdateModifier();
        }

        //
        //  UpdateWeaponProficiencyListBox
        //
        private void UpdateWeaponProficiencyListBox()
        {
            weaponProfListBox.Items.Clear();
            foreach (var weapon in Session.Player.GetWeaponProficiencyList())
            {
                weaponProfListBox.Items.Add(TypeMaps.WeaponCategoryNames[weapon]);
            }
        }

        //
        //  UpdateArmourProficiencyListBox
        //
        private void UpdateArmourProficiencyListBox()
        {
            armourProfListBox.Items.Clear();
            foreach (var armour in Session.Player.GetArmourProficiencyList())
            {
                armourProfListBox.Items.Add(TypeMaps.ArmourCategoryNames[armour]);
            }
        }

        //
        //  UpdateLanguageListBox
        //
        private void UpdateLanguageListBox()
        {
            languageProfListBox.Items.Clear();
            foreach (var language in Session.Player.GetLanguageList())
            {
                languageProfListBox.Items.Add(TypeMaps.LanguageNames[language]);
            }
        }

        //
        //  UpdateToolProficiencyListBox
        //
        private void UpdateToolProficiencyListBox()
        {
            toolProfListBox.Items.Clear();
            foreach (var tool in Session.Player.GetToolProficiencyList())
            {
                toolProfListBox.Items.Add(TypeMaps.ToolNames[tool]);
            }
        }

        //
        //  UpdateVehicleProficiencyListBox
        //
        private void UpdateVehicleProficiencyListBox()
        {
            vehicleProfListBox.Items.Clear();
            foreach (var vehicle in Session.Player.GetVehicleProficiencyList())
            {
                vehicleProfListBox.Items.Add(TypeMaps.VehicleNames[vehicle]);
            }
        }

        //
        //  UpdateModifierText
        //
        private void UpdateModifierText(TextBox textBox, int mod)
        {
            textBox.Text = mod > 0 ? "+" + mod.ToString() : mod.ToString();
        }

        //
        //  UpdateSpellSlots
        //
        private void UpdateSpellSlots()
        {
            firstLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(1));
            secondLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(2));
            thirdLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(3));
            fourthLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(4));
            fifthLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(5));
            sixthLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(6));
            seventhLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(7));
            eigthLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(8));
            ninthLvlSlotCtrl.SetRemaining(Session.Player.GetNumSpellSlotsRemaining(9));
        }

        //
        //  SwapAbilityScoreAndMod
        //
        private void SwapAbilityScoreAndMod()
        {
            strCtrl.SwapScoreAndMod();
            dexCtrl.SwapScoreAndMod();
            conCtrl.SwapScoreAndMod();
            intCtrl.SwapScoreAndMod();
            wisCtrl.SwapScoreAndMod();
            chaCtrl.SwapScoreAndMod();

            swapAbilityMenuItem.Checked = !swapAbilityMenuItem.Checked;
        }

        //
        //  SaveAs
        //
        private bool SaveAs()
        {
            bool success = false;

            var form = new SaveAsForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                success = Session.SaveCharacter(form.GetFileName());
                if (success)
                {
                    var name = Path.GetFileNameWithoutExtension(Session.ActiveFile);
                    var item = new CharacterMenuItem(name);
                    item.Click += CharacterMenuItem_Click;

                    int i = 0;
                    for (i = 3; i < charMenuItem.DropDownItems.Count; i++)
                    {
                        int comp = string.Compare(name, charMenuItem.DropDownItems[i].Text);
                        if (comp == -1)
                        {
                            break;
                        }
                        else if (comp == 0)
                        {
                            charMenuItem.DropDownItems.RemoveAt(i);
                            break;
                        }
                    }

                    if (i < charMenuItem.DropDownItems.Count)
                        charMenuItem.DropDownItems.Insert(i, item);
                    else
                        charMenuItem.DropDownItems.Add(item);
                }
            }

            return success;
        }

        //
        //  PromptToSave
        //
        private void PromptToSave()
        {
            if (Session.IsCharacterModified())
            {
                var save = MessageBox.Show("Save active character?", "D&D Character Manager", MessageBoxButtons.YesNo);
                if (save == DialogResult.Yes)
                {
                    if (Session.SaveCharacter() == false)
                        SaveAs();
                }
            }
        }

        //
        //  ResizeTextToFit
        //
        private void ResizeTextToFit(TextBox textBox)
        {
            while (TextRenderer.MeasureText(textBox.Text, textBox.Font).Width > textBox.Width)
                textBox.Font = new Font(textBox.Font.Name, textBox.Font.Size - 1.0f, FontStyle.Regular);
        }

        //
        //  TryParseIntegerTextBox
        //
        private bool TryParseIntegerTextBox(TextBox textBox, out int value)
        {
            value = int.MinValue;

            string text = textBox.Text;
            if (text.Length == 0)
                return false;

            if (text.StartsWith('+'))
                text = text.Substring(1);

            return int.TryParse(text, out value);
        }

        //
        //  UncheckCharacterMenuItems
        //
        private void UncheckCharacterMenuItems()
        {
            CharacterMenuItem menuItem;
            for (int i = 0; i < charMenuItem.DropDownItems.Count; i++)
            {
                try
                {
                    menuItem = (CharacterMenuItem)charMenuItem.DropDownItems[i];
                    menuItem.Checked = false;
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        //
        //  HandleArmourClassChange
        //
        private void HandleArmourClassChange()
        {
            if (TryParseIntegerTextBox(acTextBox, out var ac) == true)
                Session.Player.ArmourClass = ac;
        }

        //
        //  HandleInitiativeChange
        //
        private void HandleInitiativeChange()
        {
            if (TryParseIntegerTextBox(initTextBox, out var init) == true)
                Session.Player.Initiative = init;
        }

        //
        //  HandleSpeedChange
        //
        private void HandleSpeedChange()
        {
            if (TryParseIntegerTextBox(speedTextBox, out var speed) == true)
                Session.Player.Speed = speed;
        }
    }
}