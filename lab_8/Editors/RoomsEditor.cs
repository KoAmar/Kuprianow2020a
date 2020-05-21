using System;
using System.Windows.Forms;

namespace lab_8.Editors
{
    public partial class RoomsEditor : Form
    {
        public RoomsEditor()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            roomsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void RoomsEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Rooms' table. You can move, or remove it, as needed.
            roomsTableAdapter.Fill(hotelDBDataSet.Rooms);
        }
    }
}