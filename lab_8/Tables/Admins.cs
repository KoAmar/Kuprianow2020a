using System;
using System.Windows.Forms;

namespace lab_8.Tables
{
    public partial class Admins : Form
    {
        public Admins()
        {
            InitializeComponent();
        }

        private void administratorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            administratorsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void Admins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Administrators' table. You can move, or remove it, as needed.
            administratorsTableAdapter.Fill(hotelDBDataSet.Administrators);
        }
    }
}