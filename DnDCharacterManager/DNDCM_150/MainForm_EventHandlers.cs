using DND;
using DND.API;
using DND.Types;

namespace CharacterManager
{
    partial class MainForm
    {
        #region MAINFORM EVENTS

        //
        //  MainForm_FormClosing
        //
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PromptToSave();

            Session.AppSettings.LastCharacter = Path.GetFileNameWithoutExtension(Session.ActiveFile);
            Session.AppSettings.SwapAbility = swapAbilityMenuItem.Checked;
            Session.AppSettings.Width = Width;
            Session.AppSettings.Height = Height;
            Session.AppSettings.Save();
        }

        //
        //  shortRestBtn_Click
        //
        private void shortRestBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to short rest?", "D&D Character Manager", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Session.Player?.ShortRest();
            }
        }

        //
        //  longRestBtn_Click
        //
        private void longRestBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to long rest?", "D&D Character Manager", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Session.Player?.LongRest();
                UpdateHitPoints();
                UpdateSpellSlots();
                UpdateHitDice();
                concentrationTextBox.Text = string.Empty;
            }
        }

        //
        //  inventoryBtn_Click
        //
        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            var form = new InventoryForm(Session.Player.Inventory);
            form.ShowDialog();
        }

        //
        //  profBtn_Click
        //
        private void profBtn_Click(object sender, EventArgs e)
        {
            var form = new ProficienciesForm();
            form.ShowDialog();
        }

        //
        //  nameTextBox_Leave
        //
        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            Session.Player.Name = nameTextBox.Text;
        }

        //
        //  raceTextBox_Leave
        //
        private void raceTextBox_Leave(object sender, EventArgs e)
        {
            Session.Player.Race = raceTextBox.Text;
        }

        //
        //  subclassTextBox_Leave
        //
        private void subclassTextBox_Leave(object sender, EventArgs e)
        {
            Session.Player.Subclass = subclassTextBox.Text;
        }

        //
        //  backgroundTextBox_Leave
        //
        private void backgroundTextBox_Leave(object sender, EventArgs e)
        {
            Session.Player.Background = backgroundTextBox.Text;
        }

        //
        //  alignmentComboBox_SelectedIndexChanged
        //
        private void alignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Player.Alignment = alignmentComboBox.Text;
        }

        //
        //  editClassBtn_Click
        //
        private void editClassBtn_Click(object sender, EventArgs e)
        {
            var form = new ClassSelectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateClassString();
                if (classLevelTextBox.Text.Length > 0)
                    editClassBtn.Text = "Modify...";
            }
        }

        //
        //  currentHitPointsCtrl_ValueChanged
        //
        private void currentHitPointsCtrl_ValueChanged(object sender, EventArgs e)
        {
            Session.Player.CurrentHP = (int)currentHitPointsCtrl.Value;
        }

        //
        //  maxHitPointsCtrl_ValueChanged
        //
        private void maxHitPointsCtrl_ValueChanged(object sender, EventArgs e)
        {
            Session.Player.MaxHP = (int)maxHitPointsCtrl.Value;
            currentHitPointsCtrl.Maximum = (int)maxHitPointsCtrl.Value;
        }

        //
        //  tempHitPointsCtrl_ValueChanged
        //
        private void tempHitPointsCtrl_ValueChanged(object sender, EventArgs e)
        {
            Session.Player.TempHP = (int)tempHitPointsCtrl.Value;
        }

        //
        //  acTextBox_Leave
        //
        private void acTextBox_Leave(object sender, EventArgs e)
        {
            if (acTextBox.Text.Length == 0)
                acTextBox.Text = "0";

            HandleArmourClassChange();
        }

        //
        //  acTextBox_KeyPress
        //
        private void acTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
                Utility.CheckNumericInput(false, textBox, e, HandleArmourClassChange);
        }

        //
        //  initTextBox_Leave
        //
        private void initTextBox_Leave(object sender, EventArgs e)
        {
            if (initTextBox.Text.Length == 0)
                initTextBox.Text = "0";

            HandleInitiativeChange();
        }

        //
        //  initTextBox_KeyPress
        //
        private void initTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.CheckModifierInput(initTextBox, e, HandleInitiativeChange);
        }

        //
        //  speedTextBox_Leave
        //
        private void speedTextBox_Leave(object sender, EventArgs e)
        {
            if (speedTextBox.Text.Length == 0)
                speedTextBox.Text = "0";

            HandleSpeedChange();
        }

        //
        //  speedTextBox_KeyPress
        //
        private void speedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
                Utility.CheckNumericInput(false, textBox, e, HandleSpeedChange);
        }

        //
        //  AbilityCtrl_OnAnyScoreChanged
        //
        private void AbilityCtrl_OnAnyScoreChanged(object? sender, EventArgs e)
        {
            try
            {
                UpdateSkills();
                UpdateSavingThrows();
                UpdatePassivePerception();
                UpdateAttacks();

                var ctrl = (AbilityCtrl?)sender;
                if (ctrl != null)
                {
                    if (ctrl.Ability == Session.Player.SpellcastingAbility)
                    {
                        UpdateModifierText(spellModTextBox, Session.Player.GetSpellcastingModifier());
                        spellSaveTextBox.Text = Session.Player.GetSpellSaveDC().ToString();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        #endregion // MAINFORM EVENTS


        #region CORE TAB EVENTS

        //
        //  inspirationPictureBox_Click
        //
        private void inspirationPictureBox_Click(object sender, EventArgs e)
        {
            Session.Player.HasInspiration = !Session.Player.HasInspiration;
            inspirationPictureBox.BackgroundImage = Session.Player.HasInspiration ? _d20Icon : null;
        }

        //
        //  hitDiceComboBox_SelectedIndexChanged
        //
        private void hitDiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = hitDiceComboBox.Text;

            Class? c = Session.Player.GetClass(name);
            if (c == null)
                return;

            hitDiceLabel.Text = "d" + c.HitDie.ToString();

            int lvl = Session.Player.GetClassLevel(name);
            hitDiceMaxTextBox.Text = lvl.ToString();

            hitDiceNumCtrl.Maximum = int.MaxValue;
            hitDiceNumCtrl.Value = Session.Player.GetHitDiceRemaining(c.Name);
            hitDiceNumCtrl.Maximum = lvl;
        }

        //
        //  hitDiceNumCtrl_ValueChanged
        //
        private void hitDiceNumCtrl_ValueChanged(object sender, EventArgs e)
        {
            Session.Player.SetHitDiceRemaining(hitDiceComboBox.Text, (int)hitDiceNumCtrl.Value);
        }

        //
        //  deathSaveSuccessCheck_CheckedChanged
        //
        private void deathSaveSuccessCheck_CheckedChanged(object? sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                Session.Player.DeathSaveSuccesses[i] = _deathSaveSuccessChecks[i].Checked;
        }

        //
        //  deathSaveFailCheck_CheckedChanged
        //
        private void deathSaveFailCheck_CheckedChanged(object? sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                Session.Player.DeathSaveFailures[i] = _deathSaveFailChecks[i].Checked;
        }

        //
        //  profTabCtrl_DrawItem
        //
        private void profTabCtrl_DrawItem(object? sender, DrawItemEventArgs e)
        {
            Brush textBrush = new SolidBrush(Color.Black);

            TabPage page = profTabCtrl.TabPages[e.Index];
            Rectangle bounds = profTabCtrl.GetTabRect(e.Index);

            Brush rectBrush = e.State == DrawItemState.Selected ? Brushes.White : Brushes.WhiteSmoke;
            e.Graphics.FillRectangle(rectBrush, e.Bounds);

            Font font = new Font("Constantia", 9.0f);

            StringFormat strFlags = new StringFormat();
            strFlags.Alignment = StringAlignment.Center;
            strFlags.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(page.Text, font, textBrush, bounds, strFlags);
        }

        //
        //  addAttackBtn_Click
        //
        private void addAttackBtn_Click(object sender, EventArgs e)
        {
            var form = new AttackCreateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var attack = form.GetAttack();
                if (attack != null)
                {
                    Session.Player.AddAttack(attack);

                    AttackCtrl ctrl = new AttackCtrl(attack);
                    ctrl.OnRemoved += AttackCtrl_OnRemoved;
                    ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    attackTable.Controls.Add(ctrl);
                }
            }
        }

        //
        //  addFeatBtn_Click
        //
        private void addFeatBtn_Click(object sender, EventArgs e)
        {
            var form = new FeatCreateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var feat = form.GetFeat();
                if (feat != null)
                {
                    Session.Player.AddFeat(feat);
                    UpdateFeats(feat.Source);
                }
            }
        }

        //
        //  FeatCtrl_OnRemoved
        //
        private void FeatCtrl_OnRemoved(object? sender, EventArgs e)
        {
            FeatCtrl? ctrl = sender as FeatCtrl;
            if (ctrl != null)
            {
                Feat feat = ctrl.GetFeat();

                Session.Player.RemoveFeat(feat.Name);

                TableLayoutPanel? table = null;
                switch (feat.Source)
                {
                    case Feat.FeatSource.Class: table = classFeatTable; break;
                    case Feat.FeatSource.Race:  table = raceFeatTable;  break;
                    case Feat.FeatSource.Other: table = otherFeatTable; break;
                    default:
                        break;
                }

                if (table != null)
                {
                    table.Controls.Remove(ctrl);
                    table.Update();
                }
            }
        }

        //
        //  AttackCtrl_OnRemoved
        //
        private void AttackCtrl_OnRemoved(object? sender, EventArgs e)
        {
            AttackCtrl? ctrl = sender as AttackCtrl;
            if (ctrl != null)
            {
                Session.Player.RemoveAttack(ctrl.GetAttack().Name);
                attackTable.Controls.Remove(ctrl);
                attackTable.Update();
            }
        }

        #endregion // CORE TAB EVENTS


        #region BIO TAB EVENTS

        //
        //  selectImageBtn_Click
        //
        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files (*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image img = Image.FromFile(dialog.FileName);
                        Session.Player.ImageFile = dialog.FileName;
                        charPictureBox.Image = img;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to retrieve image.", "Error");
                        return;
                    }
                }
            }
        }

        //
        //  ageNumCtrl_ValueChanged
        //
        private void ageNumCtrl_ValueChanged(object sender, EventArgs e)
        {
            Session.Player.Age = (int)ageNumCtrl.Value;
        }

        //
        //  heightTextBox_Leave
        //
        private void heightTextBox_Leave(object sender, EventArgs e)
        {
            Session.Player.Height = heightTextBox.Text;
        }

        //
        //  weightTextBox_Leave
        //
        private void weightTextBox_Leave(object sender, EventArgs e)
        {
            Session.Player.Weight = weightTextBox.Text;
        }

        //
        //  backstoryTextBox_Leave
        //
        private void backstoryTextBox_Leave(object sender, EventArgs e)
        {
            Session.Player.Backstory = Utility.TextBoxToStringArray(backstoryTextBox);
        }

        //
        //  alliesTextBox_Leave
        //
        private void alliesTextBox_Leave(object sender, EventArgs e)
        {
            Session.Player.Allies = Utility.TextBoxToStringArray(alliesTextBox);
        }

        #endregion // BIO TAB EVENTS


        #region SPELLS TAB EVENTS

        //
        //  spellClassComboBox_SelectedIndexChanged
        //
        private void spellClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spellClassComboBox.Text.ToLower() == "n/a")
                Session.Player.SpellcastingClass = string.Empty;
            else
                Session.Player.SpellcastingClass = spellClassComboBox.Text;
        }

        //
        //  spellAbilityComboBox_SelectedIndexChanged
        //
        private void spellAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spellAbilityComboBox.Text.ToLower() == "n/a")
            {
                Session.Player.SpellcastingAbility = Ability.None;
            }
            else
            {
                foreach (var ability in TypeMaps.AbilityNames.Keys)
                {
                    if (spellAbilityComboBox.Text == TypeMaps.AbilityNames[ability])
                    {
                        Session.Player.SpellcastingAbility = ability;
                        UpdateModifierText(spellModTextBox, Session.Player.GetSpellcastingModifier());
                        spellSaveTextBox.Text = Session.Player.GetSpellSaveDC().ToString();
                        break;
                    }
                }
            }
        }

        //
        //  changeSpellsBtn_Click
        //
        private void changeSpellsBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            List<Spell> spells = new List<Spell>();
            for (int i = 0; i <= 9; i++)
            {
                foreach (var spell in Session.Player.GetPreparedSpells(i))
                    spells.Add(spell);
            }

            using (var form = new SpellBrowserForm(BrowserType.Select, spells.ToArray(), spellClassComboBox.Text))
            {
                Cursor = Cursors.Default;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Session.Player.ChangePreparedSpells(form.GetSelectedSpells());
                }
            }
        }

        //
        //  endConcentrationBtn_Click
        //
        private void endConcentrationBtn_Click(object sender, EventArgs e)
        {
            if (Session.Player.IsConcentrating)
            {
                var result = MessageBox.Show(
                    string.Format("End concentration on {0}?", Session.Player.ConcentratingOn),
                    "Concentration",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    Session.Player.IsConcentrating = false;
                    Session.Player.ConcentratingOn = string.Empty;
                    concentrationTextBox.Text = string.Empty;
                }
            }
        }

        #endregion // SPELLS TAB EVENTS


        #region MENU STRIP EVENTS

        //
        //  newCharMenuItem_Click
        //
        private void newCharMenuItem_Click(object sender, EventArgs e)
        {
            PromptToSave();
            UncheckCharacterMenuItems();
            Session.NewCharacter();
        }

        //
        //  delCharMenuItem_Click
        //
        private void delCharMenuItem_Click(object sender, EventArgs e)
        {
            string[] names = new string[charMenuItem.DropDownItems.Count - 3];
            for (int i = 3; i < charMenuItem.DropDownItems.Count; i++)
                names[i - 3] = charMenuItem.DropDownItems[i].ToString();

            using (var form = new CheckListForm("Delete Character", names))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    List<CharacterMenuItem> toRemove = new List<CharacterMenuItem>();

                    Logger.Info("Character delete start");

                    foreach (var name in form.GetSelections())
                    {
                        foreach (var item in charMenuItem.DropDownItems)
                        {
                            if (name != item.ToString())
                                continue;

                            CharacterMenuItem? charItem = item as CharacterMenuItem;
                            if (charItem == null)
                                continue;

                            toRemove.Add(charItem);
                        }
                    }

                    int errors = 0;
                    foreach (var item in toRemove)
                    {
                        Logger.Info(string.Format("Deleting {0}...", item.FileName));

                        try
                        {
                            if (File.Exists(item.FilePath))
                                File.Delete(item.FilePath);
                        }
                        catch (Exception ex)
                        {
                            Logger.Error(string.Format("Failed to delete {0} - Exception:\n\t{1}", item.FileName, ex.Message));
                            errors++;
                            continue;
                        }

                        charMenuItem.DropDownItems.Remove(item);

                        if (item.FilePath.ToLower() == Session.ActiveFile.ToLower())
                            Session.NewCharacter();

                        Logger.Info(item.FileName + " deleted successfully");
                    }

                    Logger.Info("Character delete end");

                    if (errors > 0)
                        MessageBox.Show("Failed to delete one or more characters. See log file for details.");
                }
            }
        }

        //
        //  saveMenuItem_Click
        //
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            bool success = File.Exists(Session.ActiveFile) ? Session.SaveCharacter() : SaveAs();
            if (success)
            {
                OnCharacterSaved?.Invoke();
                MessageBox.Show("Character saved successfully", "D&D Character Manager");
            }
        }

        //
        //  saveAsMenuItem_Click
        //
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveAs() == true)
            {
                OnCharacterSaved?.Invoke();
                MessageBox.Show("Character saved successfully", "D&D Character Manager");
            }
        }

        //
        //  restoreSRDDataMenuItem_Click
        //
        private void restoreSRDDataMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to restore the SRD data?\nThis can take several minutes.";
            if (MessageBox.Show(msg, "D&D Character Manager", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var waitForm = new WaitForm("Restoring SRD data...");
            Cursor = Cursors.WaitCursor;
            waitForm.Show();

            APIReadWrite.RetrieveAllSRDData();

            waitForm.Close();
            Cursor = Cursors.Default;
            MessageBox.Show("SRD data has been restored.", "D&D Character Manager");
        }

        //
        //  swapAbilityMenuItem_Click
        //
        private void swapAbilityMenuItem_Click(object sender, EventArgs e)
        {
            SwapAbilityScoreAndMod();
        }

        //
        //  addClassMenuItem_Click
        //
        private void addClassMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new ClassCreateForm())
            {
                form.ShowDialog();
            }
        }

        //
        //  delClassMenuItem_Click
        //
        private void delClassMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new CheckListForm("Delete Class", APIReadWrite.GetClassNameList()))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    foreach (var name in form.GetSelections())
                        APIReadWrite.DeleteClass(name);
                }
            } 
        }

        //
        //  addSpellMenuItem_Click
        //
        private void addSpellMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new SpellCreateForm())
            {
                form.ShowDialog();
            }
        }

        //
        //  delSpellMenuItem_Click
        //
        private void delSpellMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (var form = new SpellBrowserForm(BrowserType.Delete))
            {
                Cursor = Cursors.Default;
                form.ShowDialog();
            }
        }

        //
        //  addWeaponMenuItem_Click
        //
        private void addWeaponMenuItem_Click(object sender, EventArgs e)
        {
            var form = new WeaponCreateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var weapon = form.GetWeapon();
                if (weapon != null)
                {
                    string message;
                    if (APIReadWrite.SaveCustomWeapon(weapon) == 0)
                        message = weapon.Name + " added successfully.";
                    else
                        message = string.Format("Failed to add new weapon {0}.", weapon.Name);

                    MessageBox.Show(message, "D&D Character Manager");
                }
            }
        }

        //
        //  addArmourMenuItem_Click
        //
        private void addArmourMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ArmourCreateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var armour = form.GetArmour();
                if (armour != null)
                {
                    string message;
                    if (APIReadWrite.SaveCustomArmour(armour) == 0)
                        message = armour.Name + " added successfully.";
                    else
                        message = string.Format("Failed to add new armour {0}.", armour.Name);

                    MessageBox.Show(message, "D&D Character Manager");
                }
            }
        }

        //
        //  addMagicItemMenuItem_Click
        //
        private void addMagicItemMenuItem_Click(object sender, EventArgs e)
        {
            var form = new MagicItemCreateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var item = form.GetItem();
                if (item != null)
                {
                    string message;
                    if (APIReadWrite.SaveCustomMagicItem(item) == 0)
                        message = item.Name + " added successfully.";
                    else
                        message = string.Format("Failed to add new magic item {0}.", item.Name);

                    MessageBox.Show(message, "D&D Character Manager");
                }
            }
        }

        //
        //  delItemMenuItem_Click
        //
        private void delItemMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (var form = new ItemBrowserForm(false))
            {
                Cursor = Cursors.Default;
                form.ShowDialog();
            }
        }

        //
        //  spellSearchMenuItem_Click
        //
        private void spellSearchMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (var form = new SpellBrowserForm(BrowserType.Search))
            {
                Cursor = Cursors.Default;
                form.ShowDialog();
            }
        }

        //
        //  itemSearchMenuItem_Click
        //
        private void itemSearchMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            using (var form = new ItemBrowserForm(true))
            {
                Cursor = Cursors.Default;
                form.ShowDialog();
            }
        }

        //
        //  CharacterMenuItem_Click
        //
        private void CharacterMenuItem_Click(object? sender, EventArgs e)
        {
            bool success = false;

            try
            {
                var item = (CharacterMenuItem?)sender;
                if (item != null)
                {
                    if (!File.Exists(item.FilePath))
                    {
                        MessageBox.Show(string.Format("Could not find character file '{0}'", item.FileName), "Error");
                        return;
                    }

                    PromptToSave();

                    success = Session.OpenCharacter(item.FileName);
                    if (success)
                    {
                        UncheckCharacterMenuItems();
                        item.Checked = true;
                    }
                }
            }
            catch (Exception)
            {
                success = false;
            }

            if (!success)
                MessageBox.Show("Unable to open the selected character", "Error");
        }

        #endregion // MENU STRIP EVENTS


        #region PLAYER CHARACTER EVENTS

        //
        //  Player_OnSpellCast
        //
        private void Player_OnSpellCast()
        {
            UpdateSpellSlots();

            var textBox = concentrationTextBox;
            textBox.Font = new Font(textBox.Font.Name, 14.0f, FontStyle.Regular);

            if (Session.Player.IsConcentrating)
            {
                textBox.Text = Session.Player.ConcentratingOn;
                ResizeTextToFit(textBox);
            }
            else
            {
                textBox.Text = string.Empty;
            }
        }

        //
        //  Player_OnPreparedSpellsChanged
        //
        private void Player_OnPreparedSpellsChanged()
        {
            LoadSpells();
        }

        //
        //  Player_OnLevelChanged
        //
        private void Player_OnLevelChanged()
        {
            UpdateModifierText(profBonusTextBox, Session.Player.ProficiencyBonus);
            UpdateModifierText(spellModTextBox, Session.Player.GetSpellcastingModifier());
            spellSaveTextBox.Text = Session.Player.GetSpellSaveDC().ToString();

            UpdateSavingThrows();
            UpdateSkills();
            UpdatePassivePerception();
            UpdateHitDice();
        }

        //
        //  Player_OnClassChanged
        //
        private void Player_OnClassChanged()
        {
            UpdateHitDice();
        }

        //
        //  Player_OnPrimaryClassChanged
        //
        private void Player_OnPrimaryClassChanged()
        {
            UpdateSavingThrows();
        }

        //
        //  Player_OnSavingThrowsChanged
        //
        private void Player_OnSavingThrowsChanged()
        {
            UpdateSavingThrows();
        }

        //
        //  Player_OnSkillProficienciesChanged
        //
        private void Player_OnSkillProficienciesChanged()
        {
            UpdateSkills();
            UpdatePassivePerception();
        }

        //
        //  Player_OnFeatsChanged
        //
        private void Player_OnFeatsChanged()
        {
            LoadFeats();
        }

        #endregion // PLAYER CHARACTER EVENTS
    }
}
