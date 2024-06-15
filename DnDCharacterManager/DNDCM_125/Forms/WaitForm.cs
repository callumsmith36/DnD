/*********************************************************
 *  
 *  Name:       WaitForm.cs
 *  
 *  Purpose:    Dialog for displaying a 'please wait'
 *              message
 *  
 *  Author:     CS
 *  
 *  Created:    14/04/2024
 * 
 *********************************************************/

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
