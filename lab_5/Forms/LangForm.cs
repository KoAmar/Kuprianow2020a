using System;
using System.Windows.Forms;

namespace lab_5.Forms
{
    public partial class LangForm : Form
    {
        public LangForm()
        {
            InitializeComponent();
        }

        private void LangForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            this.languagesTableAdapter.Fill(this.hotelDBDataSet.Languages);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            languagesTableAdapter.Fill(hotelDBDataSet.Languages);
        }

        private void languagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.languagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }
    }
}