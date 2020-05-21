using System;
using System.Windows.Forms;

namespace lab_8.Editors
{
    public partial class LanguageEditor : Form
    {
        public LanguageEditor()
        {
            InitializeComponent();
        }

        private void languagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            languagesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void LanguageEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            languagesTableAdapter.Fill(hotelDBDataSet.Languages);
        }
    }
}