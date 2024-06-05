namespace CharacterManager
{
    public partial class WaitForm : Form
    {
        public WaitForm(string msg)
        {
            InitializeComponent();

            int h = msgLabel.Height;

            msgLabel.Text = msg;
            if (msgLabel.Height > h)
                Size = new Size(Width, Height + msgLabel.Height - h);
        }


        public void SetProgress(int value)
        {
            progBar.Value = value;
        }
    }
}
