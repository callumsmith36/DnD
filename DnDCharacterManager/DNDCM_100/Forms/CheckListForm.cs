namespace CharacterManager
{
    public partial class CheckListForm : Form
    {
        private string          _title;
        private List<string>    _selections;


        //
        //  Constructor
        //
        public CheckListForm(string title, string[] items)
        {
            InitializeComponent();
            Text = _title = title;
            _selections = new List<string>();

            int initialListHeight = checkList.Height;

            foreach (var item in items)
                checkList.Items.Add(item);

            int newFormHeight = Height + (initialListHeight * (checkList.Items.Count - 1));
            Size = new Size(Width, newFormHeight);
        }


        //
        //  GetSelections
        //
        public string[] GetSelections()
        {
            return _selections.ToArray();
        }


        //
        //  okBtn_Click
        //
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (checkList.CheckedItems.Count == 0)
            {
                var result = MessageBox.Show("No items selected. Exit dialog?", _title, MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
            }
            else
            {
                var message = "Are you sure you wish to delete the following?\n\n";
                foreach (var item in checkList.CheckedItems)
                    message += item.ToString() + "\n";

                var result = MessageBox.Show(message, _title, MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                foreach (var item in checkList.CheckedItems)
                {
                    var name = item.ToString();
                    if (name != null)
                        _selections.Add(name);
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
    }
}
