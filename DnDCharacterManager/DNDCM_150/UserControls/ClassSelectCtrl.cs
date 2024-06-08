using DND.API;

namespace CharacterManager
{
    public partial class ClassSelectCtrl : UserControl
    {
        public EventHandler? OnDelete;

        //
        //  Constructor
        //
        public ClassSelectCtrl()
        {
            InitializeComponent();

            foreach (var className in APIReadWrite.GetClassNameList())
                classComboBox.Items.Add(className);

            classComboBox.SelectedIndex = 0;
        }


        //
        //  SetPrimary
        //
        public void SetPrimary()
        {
            removeBtn.Enabled = false;
            removeBtn.Visible = false;
            primaryLabel.Enabled = true;
            primaryLabel.Visible = true;
        }

        //
        //  GetClassName
        //
        public string GetClassName()
        {
            return classComboBox.Text;
        }

        //
        //  SetClass
        //
        public void SetClass(string name)
        {
            for (int i = 0; i < classComboBox.Items.Count; i++)
            {
                if (classComboBox.Items[i].ToString().ToLower() == name.ToLower())
                {
                    classComboBox.SelectedIndex = i;
                    break;
                }
            }
        }

        //
        //  GetLevel
        //
        public int GetLevel()
        {
            return (int)levelNumCtrl.Value;
        }

        //
        //  SetLevel
        //
        public void SetLevel(int level)
        {
            if (level < 1)
                level = 1;
            else if (level > 20)
                level = 20;

            levelNumCtrl.Value = level;
        }

        //
        //  removeBtn_Click
        //
        private void removeBtn_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this, EventArgs.Empty);
        }
    }
}
