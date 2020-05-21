using System;
using System.Windows.Forms;

namespace lab_8.Tables
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            roomsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Rooms' table. You can move, or remove it, as needed.
            roomsTableAdapter.Fill(hotelDBDataSet.Rooms);
        }
    }
}