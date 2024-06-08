using DND.API;

namespace CharacterManager
{
    public partial class SaveAsForm : Form
    {
        private string _fileName;

        public SaveAsForm()
        {
            InitializeComponent();
            _fileName = string.Empty;
        }

        public string GetFileName()
        {
            return _fileName;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (fileNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("No file name entered.", "Error");
                return;
            }

            char[] invalidChars = { '<', '>', ':', '\"', '/', '|', '?', '*', ',' };
            foreach (var c in invalidChars)
            {
                if (fileNameTextBox.Text.Contains(c))
                {
                    var message = "Invalid file name. Cannot contain any of the following:\n";
                    for (int i = 0; i < invalidChars.Length; i++)
                    {
                        message += invalidChars[i];
                        if (i < invalidChars.Length - 1)
                            message += " ";
                    }

                    MessageBox.Show(message, "Error");
                    return;
                }
            }

            bool proceed = true;
            _fileName = fileNameTextBox.Text;

            while (_fileName.EndsWith('.'))
                _fileName = _fileName.Remove(_fileName.Length - 1);

            if (!(_fileName.EndsWith(".json")))
                _fileName += ".json";

            string file = APIReadWrite.RootPath + "\\characters\\" + _fileName;
            if (File.Exists(file))
            {
                var result = MessageBox.Show(string.Format("'{0}' already exists. Overwrite this file?", _fileName), "Caution", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    proceed = false;
            }

            if (proceed)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
