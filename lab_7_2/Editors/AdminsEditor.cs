using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7_2.Editors
{
    public partial class AdminsEditor : Form
    {
        public AdminsEditor()
        {
            InitializeComponent();
        }

        private void administratorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.administratorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void AdminsEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Administrators' table. You can move, or remove it, as needed.
            this.administratorsTableAdapter.Fill(this.hotelDBDataSet.Administrators);

        }
    }
}
