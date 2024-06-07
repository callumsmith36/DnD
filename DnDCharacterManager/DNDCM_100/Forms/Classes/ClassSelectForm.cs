namespace CharacterManager
{
    public partial class ClassSelectForm : Form
    {
        private Size _ctrlSize;
        private List<ClassSelectCtrl> _classCtrlList;


        //
        //  Constructor
        //
        public ClassSelectForm()
        {
            InitializeComponent();

            _ctrlSize = classSelectCtrl1.Size;
            _classCtrlList = new List<ClassSelectCtrl>() { classSelectCtrl1 };

            classSelectCtrl1.SetPrimary();
            var primaryClass = Session.Player.GetPrimaryClass();
            if (primaryClass != null)
            {
                classSelectCtrl1.SetClass(primaryClass.Name);
                classSelectCtrl1.SetLevel(Session.Player.GetClassLevel(primaryClass.Name));

                var classList = Session.Player.GetClassList();
                for (int i = 1; i < classList.Length; i++)
                    AddClassCtrl(classList[i].Name, Session.Player.GetClassLevel(classList[i].Name));
            }

        }


        //
        //  AddClassCtrl
        //
        private void AddClassCtrl(string name = "Fighter", int level = 1)
        {
            ClassSelectCtrl classCtrl = new ClassSelectCtrl();
            classCtrl.SetClass(name);
            classCtrl.SetLevel(level);
            classCtrl.Size = _ctrlSize;
            classCtrl.OnDelete += ClassSelectCtrl_OnDelete;

            int initialTableHeight = classCtrlTable.Height;
            classCtrlTable.Controls.Add(classCtrl);
            int heightDiff = classCtrlTable.Height - initialTableHeight;
            Size = new Size(Width, Height + heightDiff);

            _classCtrlList.Add(classCtrl);
        }

        //
        //  addBtn_Click
        //
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddClassCtrl();
        }

        //
        //  okBtn_Click
        //
        private void okBtn_Click(object sender, EventArgs e)
        {
            var newClassList = new List<string>();
            int totalLevel = 0;
            foreach (var ctrl in _classCtrlList)
            {
                if (newClassList.Contains(ctrl.GetClassName()))
                {
                    MessageBox.Show("Cannot add multiple instances of the same class.", "Select Class");
                    return;
                }

                newClassList.Add(ctrl.GetClassName());
                totalLevel += ctrl.GetLevel();
                if (totalLevel > 20)
                {
                    MessageBox.Show("Total level cannot exceed 20.", "Select Class");
                    return;
                }
            }

            var primaryClass = Session.Player.GetPrimaryClass();
            if (primaryClass != null)
            {
                if (primaryClass.Name != _classCtrlList[0].GetClassName())
                {
                    if (Session.Player.RemoveClass(primaryClass.Name) == true)
                    {
                        Session.Player.AddClass(_classCtrlList[0].GetClassName(), _classCtrlList[0].GetLevel(), true);
                    }
                }
            }
            else
            {
                Session.Player.AddClass(_classCtrlList[0].GetClassName(), _classCtrlList[0].GetLevel(), true);
            }

            var currentClassList = Session.Player.GetClassList();

            // Remove all classes not featured in the new list
            for (int i = 1; i < currentClassList.Length; i++)
            {
                var name = currentClassList[i].Name;
                if (!newClassList.Contains(name))
                    Session.Player.RemoveClass(name);
            }

            // For each class in the new list, either add the class if not already
            // present, or set its level accordingly if it is already present
            for (int i = 0; i < _classCtrlList.Count; i++)
            {
                var currentClass = Session.Player.GetClass(_classCtrlList[i].GetClassName());
                if (currentClass == null)
                {
                    Session.Player.AddClass(_classCtrlList[i].GetClassName(), _classCtrlList[i].GetLevel(), false);
                }
                else
                {
                    if (Session.Player.GetClassLevel(currentClass.Name) != _classCtrlList[i].GetLevel())
                    {
                        Session.Player.SetClassLevel(currentClass.Name, _classCtrlList[i].GetLevel());
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
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
        //  ClassSelectCtrl_OnDelete
        //
        private void ClassSelectCtrl_OnDelete(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                int initialTableHeight = classCtrlTable.Height;
                classCtrlTable.Controls.Remove(sender as ClassSelectCtrl);
                int heightDiff = classCtrlTable.Height - initialTableHeight;
                Size = new Size(Width, Height + heightDiff);

                _classCtrlList.Remove(sender as ClassSelectCtrl);
            }
        }
    }
}
