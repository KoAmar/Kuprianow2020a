using System;
using System.Windows.Forms;

namespace lab_5.Forms
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelDBDataSet.Rooms);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Rooms' table. You can move, or remove it, as needed.
            roomsTableAdapter.Fill(hotelDBDataSet.Rooms);
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }
    }
}