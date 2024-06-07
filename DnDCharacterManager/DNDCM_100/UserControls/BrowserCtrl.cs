namespace CharacterManager
{
    public abstract partial class BrowserCtrl : UserControl
    {
        protected bool _selected;
        protected bool _selectable;

        private Color _defaultBackColour = Color.WhiteSmoke;
        private Color _selectedBackColour = Color.PowderBlue;
        private Font _defaultFont = new Font("Constantia", 12.0f, FontStyle.Regular);
        private Font _boldFont = new Font("Constantia", 12.0f, FontStyle.Bold);


        //
        //  Constructor
        //
        public BrowserCtrl(EventHandler? onClick = null, bool selectable = true)
        {
            InitializeComponent();
            SetSelectable(selectable);
            _selected = false;

            if (onClick != null)
            {
                Click += onClick;
                nameLabel.Click += onClick;
            }
        }


        //
        //  IsSelected
        //
        public bool IsSelected()
        {
            return _selected;
        }

        //
        //  IsSelectable
        //
        public bool IsSelectable()
        {
            return _selectable;
        }

        //
        //  SetSelected
        //
        public void SetSelected(bool selected = true)
        {
            if (selected)
            {
                if (!_selectable)
                    return;

                nameLabel.Font = _boldFont;
                nameLabel.BackColor = _selectedBackColour;
                BackColor = _selectedBackColour;
                _selected = true;
            }
            else
            {
                nameLabel.Font = _defaultFont;
                nameLabel.BackColor = _defaultBackColour;
                BackColor = _defaultBackColour;
                _selected = false;
            }
        }

        //
        //  SetSelectable
        //
        public void SetSelectable(bool selectable = true)
        {
            _selectable = selectable;
            Cursor = nameLabel.Cursor = selectable ? Cursors.Hand : Cursors.Default;
        }

        //
        //  SetName
        //
        public void SetName(string name)
        {
            nameLabel.Text = name;

            if (TextRenderer.MeasureText(nameLabel.Text, nameLabel.Font).Width > nameLabel.MaximumSize.Width)
            {
                while (TextRenderer.MeasureText(nameLabel.Text, nameLabel.Font).Width > nameLabel.MaximumSize.Width)
                {
                    nameLabel.Font = new Font(nameLabel.Font.Name, nameLabel.Font.Size - 1.0f, FontStyle.Regular);
                }

                _defaultFont = nameLabel.Font;
                _boldFont = new Font(_defaultFont, FontStyle.Bold);
            }
        }

        //
        //  SetNameBold
        //
        public void SetNameBold(bool bold = true)
        {
            nameLabel.Font = bold ? _boldFont : _defaultFont;
        }

        //
        //  GetNameLabel
        //
        public Label GetNameLabel()
        {
            return nameLabel;
        }

        //
        //  SetTag
        //
        public void SetTag(string tag)
        {
            tagLabel.Text = tag;
        }

        //
        //  SetTagVisible
        //
        public void SetTagVisible(bool visible = true)
        {
            tagLabel.Visible = visible;
        }

        //
        //  SetFocused
        //
        public void SetFocused(bool focus = true)
        {
            if (focus)
            {
                BorderStyle = BorderStyle.FixedSingle;
                Focus();
            }
            else
            {
                BorderStyle = BorderStyle.None;
            }
        }


        //
        //  infoBtn_Click
        //
        protected abstract void infoBtn_Click(object sender, EventArgs e);
    }
}
