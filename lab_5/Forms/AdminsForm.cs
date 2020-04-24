using System;
using System.Windows.Forms;

namespace lab_5.Forms
{
    public partial class AdminsForm : Form
    {
        public AdminsForm()
        {
            InitializeComponent();
        }

        private void AdminsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Administrators' table. You can move, or remove it, as needed.
            administratorsTableAdapter.Fill(hotelDBDataSet.Administrators);
        }

        private void administratorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.administratorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }
    }
}