namespace CharacterManager
{
    public partial class InventoryAddItemPrompt : Form
    {
        public int Option { get; private set; }


        public InventoryAddItemPrompt()
        {
            InitializeComponent();
            Option = 0;
        }


        private void browserBtn_Click(object sender, EventArgs e)
        {
            Option = 1;
            Close();
        }

        private void addTempBtn_Click(object sender, EventArgs e)
        {
            Option = 2;
            Close();
        }
    }
}
