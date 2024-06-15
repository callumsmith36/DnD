/*********************************************************
 *  
 *  Name:       Spells/SpellBrowserForm.cs
 *  
 *  Purpose:    Dialog for browsing/selecting/deleting
 *              spells from the database
 *  
 *  Author:     CS
 *  
 *  Created:    01/04/2024
 * 
 *********************************************************/

using DND;
using DND.API;

namespace CharacterManager
{
    public partial class SpellBrowserForm : Form
    {
        private BrowserType             _type;
        private List<string>            _selectedCantrips;
        private List<string>            _selectedSpells;
        private List<TableLayoutPanel>  _spellTableList;
        private List<SpellBrowserCtrl>  _spellCtrlList;
        private List<SpellBrowserCtrl>  _searchResults;
        private string                  _currentSearch;
        private int                     _currentResultIndex;


        //
        //  Constructor
        //
        public SpellBrowserForm(BrowserType type, Spell[]? selectedSpells = null, string? spellClassName = null)
        {
            InitializeComponent();
            _selectedCantrips = new List<string>();
            _selectedSpells = new List<string>();
            _spellTableList = new List<TableLayoutPanel>();
            _spellCtrlList = new List<SpellBrowserCtrl>();
            _searchResults = new List<SpellBrowserCtrl>();
            _currentSearch = string.Empty;
            _currentResultIndex = 0;

            _spellTableList.Add(cantripTable);
            _spellTableList.Add(firstLevelTable);
            _spellTableList.Add(secondLevelTable);
            _spellTableList.Add(thirdLevelTable);
            _spellTableList.Add(fourthLevelTable);
            _spellTableList.Add(fifthLevelTable);
            _spellTableList.Add(sixthLevelTable);
            _spellTableList.Add(seventhLevelTable);
            _spellTableList.Add(eigthLevelTable);
            _spellTableList.Add(ninthLevelTable);

            _type = type;

            if (type == BrowserType.Search)
            {
                spellTabCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                MinimumSize = new Size(MinimumSize.Width, MinimumSize.Height - 20);
                Size = new Size(Width, Height - okBtn.Height - 20);
                Controls.Remove(okBtn);
                Controls.Remove(cancelBtn);
                Controls.Remove(clearBtn);
                Controls.Remove(deleteBtn);

                spellTabCtrl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
            else if (type == BrowserType.Select)
            {
                if (selectedSpells != null && selectedSpells.Length > 0)
                {
                    foreach (var spell in selectedSpells)
                    {
                        if (spell.Level == 0)
                            _selectedCantrips.Add(spell.Name);
                        else
                            _selectedSpells.Add(spell.Name);
                    }
                }

                Controls.Remove(deleteBtn);
            }
            else if (type == BrowserType.Delete)
            {
                Controls.Remove(okBtn);
                Controls.Remove(cancelBtn);
                Controls.Remove(clearBtn);
            }

            foreach (var className in APIReadWrite.GetClassNameList())
            {
                var c = APIReadWrite.GetClass(className);
                if (c != null && c.SpellList.Count > 0)
                {
                    spellClassComboBox.Items.Add(className);
                }
            }

            if (spellClassName != null && spellClassComboBox.Items.Contains(spellClassName))
            {
                for (int i = 0; i < spellClassComboBox.Items.Count; i++)
                {
                    if (spellClassComboBox.Items[i].ToString().ToLower() == spellClassName.ToLower())
                    {
                        spellClassComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                spellClassComboBox.SelectedIndex = 0;
            }
        }


        //
        //  GetSelectedSpells
        //
        public Spell[] GetSelectedSpells()
        {
            var spellList = new List<Spell>();

            _selectedCantrips.Sort();
            _selectedSpells.Sort();

            Spell? spell;
            foreach (var spellName in _selectedCantrips)
            {
                if ((spell = APIReadWrite.GetSpell(spellName)) != null)
                    spellList.Add(spell);
            }

            foreach (var spellName in _selectedSpells)
            {
                if ((spell = APIReadWrite.GetSpell(spellName)) != null)
                    spellList.Add(spell);
            }

            return spellList.ToArray();
        }

        //
        //  SetSpellClass
        //
        private void SetSpellClass(string className)
        {
            Spell[] spells;

            if (className.ToLower() == "all spells" || !spellClassComboBox.Items.Contains(className))
                spells = APIReadWrite.GetAllSpells();
            else
                spells = APIReadWrite.GetClassSpellList(className);

            foreach (var table in _spellTableList)
            {
                table.Visible = false;
                table.Controls.Clear();
            }

            foreach (var spell in spells)
            {
                SpellBrowserCtrl ctrl = new SpellBrowserCtrl(spell, SpellBrowserCtrl_OnClick, _type != BrowserType.Search);
                //ctrl.Click += SpellBrowserCtrl_OnClick;
                //ctrl.GetNameLabel().Click += SpellBrowserCtrl_OnClick;

                switch (spell.Level)
                {
                    case 0: cantripTable.Controls.Add(ctrl); break;
                    case 1: firstLevelTable.Controls.Add(ctrl); break;
                    case 2: secondLevelTable.Controls.Add(ctrl); break;
                    case 3: thirdLevelTable.Controls.Add(ctrl); break;
                    case 4: fourthLevelTable.Controls.Add(ctrl); break;
                    case 5: fifthLevelTable.Controls.Add(ctrl); break;
                    case 6: sixthLevelTable.Controls.Add(ctrl); break;
                    case 7: seventhLevelTable.Controls.Add(ctrl); break;
                    case 8: eigthLevelTable.Controls.Add(ctrl); break;
                    case 9: ninthLevelTable.Controls.Add(ctrl); break;
                    default:
                        break;
                }

                _spellCtrlList.Add(ctrl);

                if (_selectedCantrips.Contains(spell.Name) || _selectedSpells.Contains(spell.Name))
                {
                    ctrl.SetSelected(true);
                }
            }

            foreach (var table in _spellTableList)
                table.Visible = true;
        }

        //
        //  Search
        //
        private void Search(string text)
        {
            if (_searchResults.Count > 0)
                _searchResults[_currentResultIndex].SetFocused(false);

            _searchResults.Clear();
            _currentSearch = searchTextBox.Text;
            _currentResultIndex = 0;

            if (text.Length > 0)
            {
                string search = text.ToLower();
                foreach (var table in _spellTableList)
                {
                    foreach (var ctrl in table.Controls)
                    {
                        SpellBrowserCtrl? spellCtrl = (SpellBrowserCtrl?)ctrl;
                        if (spellCtrl != null && spellCtrl.GetSpell().Name.ToLower().Contains(search))
                        {
                            _searchResults.Add(spellCtrl);
                        }
                    }
                }

                if (_searchResults.Count > 0)
                {
                    spellTabCtrl.SelectTab(_searchResults[0].GetSpell().Level);
                    _searchResults[0].SetFocused(true);
                }
                else
                {
                    MessageBox.Show(string.Format("'{0}' not found.", searchTextBox.Text));
                }
            }
        }


        //
        //  SpellSelectCtrl_OnClick
        //
        private void SpellBrowserCtrl_OnClick(object? sender, EventArgs e)
        {
            try
            {
                SpellBrowserCtrl? ctrl = (SpellBrowserCtrl?)sender;
                if (ctrl != null && ctrl.IsSelectable())
                {
                    var spell = ctrl.GetSpell();
                    if (spell != null)
                    {
                        if (ctrl.IsSelected())
                        {
                            ctrl.SetSelected(false);
                            if (spell.Level == 0)
                                _selectedCantrips.Remove(spell.Name);
                            else
                                _selectedSpells.Remove(spell.Name);
                        }
                        else
                        {
                            ctrl.SetSelected(true);
                            if (spell.Level == 0)
                                _selectedCantrips.Add(spell.Name);
                            else
                                _selectedSpells.Add(spell.Name);
                        }

                        numSpellsLabel.Text = _selectedSpells.Count.ToString();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        //
        //  spellClassComboBox_SelectedIndexChanged
        //
        private void spellClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSpellClass(spellClassComboBox.Text);
        }

        //
        //  clearBtn_Click
        //
        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in _spellCtrlList)
                ctrl.SetSelected(false);

            _selectedCantrips.Clear();
            _selectedSpells.Clear();
        }

        //
        //  cancelBtn_Click
        //
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //
        //  okBtn_Click
        //
        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        //
        //  deleteBtn_Click
        //
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_selectedCantrips.Count == 0 && _selectedSpells.Count == 0)
                return;

            string confirmMsg = "Are you sure you want to delete the following spells?\n\n";
            foreach (var name in _selectedCantrips)
                confirmMsg += name + "\n";
            foreach (var name in _selectedSpells)
                confirmMsg += name + "\n";

            if (MessageBox.Show(confirmMsg, "D&D Character Manager", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var name in _selectedCantrips)
                    APIReadWrite.DeleteSpell(name);

                foreach (var name in _selectedSpells)
                    APIReadWrite.DeleteSpell(name);

                SetSpellClass(spellClassComboBox.Text);

                confirmMsg = "The selected spells have been deleted.";
                MessageBox.Show(confirmMsg, "D&D Character Manager");
            }
        }

        //
        //  searchTextBox_KeyPress
        //
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search(searchTextBox.Text);
                e.Handled = true;
            }
        }

        //
        //  prevBtn_Click
        //
        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.ToLower() != _currentSearch.ToLower())
            {
                Search(searchTextBox.Text);
            }
            else
            {
                if (_searchResults.Count == 0 || _currentResultIndex < 0)
                    return;

                if (_currentResultIndex > 0)
                {
                    _searchResults[_currentResultIndex].SetFocused(false);
                    _currentResultIndex--;
                }

                spellTabCtrl.SelectTab(_searchResults[_currentResultIndex].GetSpell().Level);
                _searchResults[_currentResultIndex].SetFocused(true);
            }
        }

        //
        //  nextBtn_Click
        //
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.ToLower() != _currentSearch.ToLower())
            {
                Search(searchTextBox.Text);
            }
            else
            {
                if (_searchResults.Count == 0 || _currentResultIndex >= _searchResults.Count)
                    return;

                if (_currentResultIndex < _searchResults.Count - 1)
                {
                    _searchResults[_currentResultIndex].SetFocused(false);
                    _currentResultIndex++;
                }

                spellTabCtrl.SelectTab(_searchResults[_currentResultIndex].GetSpell().Level);
                _searchResults[_currentResultIndex].SetFocused(true);
            }
        }
    }
}
