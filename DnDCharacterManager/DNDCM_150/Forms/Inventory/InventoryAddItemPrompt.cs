/*********************************************************
 *  
 *  Name:       Inventory/InventoryAddItemPrompt.cs
 *  
 *  Purpose:    Dialog for selecting whether to add an
 *              item from the database or to add a
 *              temporary item
 *  
 *  Author:     CS
 *  
 *  Created:    14/04/2024
 * 
 *********************************************************/

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
