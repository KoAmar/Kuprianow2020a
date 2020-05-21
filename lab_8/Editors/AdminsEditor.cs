using System;
using System.Windows.Forms;

namespace lab_8.Editors
{
    public partial class AdminsEditor : Form
    {
        public AdminsEditor()
        {
            InitializeComponent();
        }

        private void administratorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            administratorsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void AdminsEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Administrators' table. You can move, or remove it, as needed.
            administratorsTableAdapter.Fill(hotelDBDataSet.Administrators);
        }
    }
}